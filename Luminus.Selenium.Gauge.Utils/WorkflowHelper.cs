using Gauge.CSharp.Lib;
using Luminus.Selenium.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public static class WorkflowHelper
    {
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static bool ContinueIfFirstExecution(Action action)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(1);

            string methodName = sf.GetMethod().Name;

            return ContinueIfFirstExecutionForKey(methodName, "", action);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static bool ContinueIfFirstExecutionForKey(string key, Action action)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(1);

            string methodName = sf.GetMethod().Name;

            return ContinueIfFirstExecutionForKey(methodName, key, action);
        }

        public static bool ContinueIfFirstExecutionForKey(string methodName, string key, Action action)
        {
            string storeKey = methodName + "|" + key;

            var repo = RepositoryHelper.GetRepository<IRepository<KeyValueEntity>>();

            return HandleProcessQueue(action, storeKey, repo);
        }

        private static bool HandleProcessQueue(Action action, string storeKey, IRepository<KeyValueEntity> repo)
        {
            DateTime timeout = DateTime.Now.AddMinutes(15);

            do
            {
                var objExecuted = repo.Get(storeKey);
                string value = objExecuted?.Value?.ToString();

                switch (value)
                {
                    case "processed":
                        return false;
                    case "processing":
                        {
                            Console.WriteLine($"Aguardando a execução do método {storeKey}. Esperando 500ms para verificar novamente.");
                            Thread.Sleep(500);
                            break;
                        }
                    default:
                        {
                            repo.Save(new KeyValueEntity() { Id = storeKey, Value = "processing" });

                            try
                            {
                                action();
                                repo.Save(new KeyValueEntity() { Id = storeKey, Value = "processed" });
                                return true;
                            }
                            catch
                            {
                                repo.Save(new KeyValueEntity() { Id = storeKey, Value = "error" });
                                throw;
                            }
                        }
                }
            } while (DateTime.Now < timeout);

            Console.WriteLine($"Tempo máximo de espera atingido para o método {storeKey}");
            return false;
        }
    }
}
