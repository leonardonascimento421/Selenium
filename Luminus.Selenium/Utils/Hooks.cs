using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public class Hooks
    {
        [BeforeSuite]
        public void Setup()
        {
            Console.WriteLine("BEFORE SUITE");
            Initializer.Initialize();
        }

        [AfterSuite]
        public void TearDown()
        {
            Console.WriteLine("AFTER SUITE");
            Initializer.CleanUp();
        }

        [BeforeSpec]
        public void BeforeSpec()
        {
            string parallelPhase = Environment.GetEnvironmentVariable("testtools_gauge_run_parallel_phase");
            if (!string.IsNullOrWhiteSpace(parallelPhase) && parallelPhase != "1")
                DriverFactory.Driver.LoadPage(Config.Url.UrlLuminus + "/home"); // redirecionando para home para preencher localStorage e sessionStorage
        }

        [BeforeScenario]
        public void BeforeScenario(ExecutionContext context)
        {
            var hub = new EventHub();
            new EventHandlers().Configure(hub, new[]
            {
                new AfterSpecEventHandler()
            });
            TestContextHelper.StoreEventHub(hub);
            TestContextHelper.StoreTestManager();
            TestContextHelper.StoreScenarioId(context.CurrentScenario.Name);
        }

        [AfterSpec]
        public void AfterSpec(ExecutionContext context)
        {
            EventHubHelper.Publish(Events.BeginAfterSpec, context);
        }

        [BeforeStep]
        public void BeforeStep(ExecutionContext context)
        {
            TestContextHelper.StoreStepSequenceNumber();
        }

        [AfterStep]
        public void AfterStep()
        {
            EventHubHelper.Publish(Events.BeginAfterStep, null);
        }
    }
}
