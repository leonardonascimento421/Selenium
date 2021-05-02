using Gauge.CSharp.Lib;
using Luminus.Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium
{
    public class AfterSpecEventHandler : IEventHandler
    {
        public void Configure(EventHub hub)
        {
            hub.Subscribe(Events.BeginAfterSpec, OnBeginAfterSpec);
        }

        private void OnBeginAfterSpec(object obj)
        {
            ExecutionContext context = (ExecutionContext)obj;

            // Mantendo estrutura de exemplo para futuras implementações
        }
    }
}
