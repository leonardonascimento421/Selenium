using Gauge.CSharp.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public static class TestContextHelper
    {
        /// <summary>
        /// Id do workitem do testcase ou, se não existir, nome do cenário sem caracteres especiais.
        /// </summary>
        public const string scenarioIdKey = "scenarioId";
        public const string stepSequenceNumber = "stepSequenceNumber";
        public const string eventHubKey = "eventHub";
        public const string testManagerKey = "testManager";
        public const string traceScreenshotKey = "traceScreenshot";

        private static Regex _regexPalavraColchetes = new Regex("\\[(([^\\[])*)\\]", RegexOptions.Compiled);
        private static Regex _regexDiferenteDeLetraNumero = new Regex(@"[^0-9a-zA-Z]+", RegexOptions.Compiled);

        public static void StoreStepSequenceNumber()
        {
            var scenarioStore = DataStoreFactory.ScenarioDataStore;

            var obj = scenarioStore.Get(stepSequenceNumber);
            int sequence = obj != null ? (int)obj : 0;

            sequence++;

            scenarioStore.Add(stepSequenceNumber, sequence);
        }

        public static void StoreScenarioId(string scenarioName)
        {
            var match = _regexPalavraColchetes.Match(scenarioName);

            string id;
            var scenarioStore = DataStoreFactory.ScenarioDataStore;
            if (match.Groups.Count > 1)
                id = match.Groups[1].Value;
            else
                id = _regexDiferenteDeLetraNumero.Replace(scenarioName, "");

            scenarioStore.Add(scenarioIdKey, id);
        }

        public static void StoreEventHub(EventHub hub)
        {
            DataStoreFactory.ScenarioDataStore.Add(eventHubKey, hub);
            EventHubHelper.Configure(() => (EventHub)DataStoreFactory.ScenarioDataStore.Get(eventHubKey));
        }

        public static void StoreTestManager()
        {
            TestManager testManager = new TestManager();
            DataStoreFactory.ScenarioDataStore.Add(testManagerKey, testManager);
        }

        public static bool IsScenario(params int[] scenariosId)
        {
            string scenarioId = DataStoreFactory.ScenarioDataStore.Get(scenarioIdKey)?.ToString();

            int.TryParse(scenarioId, out int id);

            return scenariosId.Contains(id);
        }

        public static T Get<T>(string key)
        {
            var value = DataStoreFactory.ScenarioDataStore.Get(key);
            return value != null ? (T)value : default(T);
        }

        public static void Clear(string key)
        {
            DataStoreFactory.ScenarioDataStore.Add(key, null);
        }
    }
}
