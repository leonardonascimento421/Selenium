using Gauge.CSharp.Lib;
using Luminus.Selenium.Implementation;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public static class ScreenshotHelper
    {
        private static string _printsPath;

        public static void Initialize(string printsPath)
        {
            _printsPath = printsPath;
            Screenshot.Configure(ScreenshotHelper.TakeScreenshot);
            GaugeScreenshots.RegisterCustomScreenshotGrabber(new ScreenGrabber());
        }

        public static void SaveFile(OpenQA.Selenium.Screenshot screenshot)
        {
            string scenarioId = DataStoreFactory.ScenarioDataStore.Get(TestContextHelper.scenarioIdKey)?.ToString();
            bool traceScreenshot = DataStoreFactory.ScenarioDataStore.Get(TestContextHelper.traceScreenshotKey) != null ? true : false;
            DataStoreFactory.ScenarioDataStore.Add(TestContextHelper.traceScreenshotKey, null); // clear

            object objStepSequenceNumber = DataStoreFactory.ScenarioDataStore.Get(TestContextHelper.stepSequenceNumber);
            int sequence = objStepSequenceNumber != null ? (int)objStepSequenceNumber : 0;

            string fileName;
            if (string.IsNullOrWhiteSpace(scenarioId))
                fileName = string.Empty;
            else if (traceScreenshot)
                fileName = $"{scenarioId} - {sequence}";
            else
                fileName = scenarioId;

            ScreenshotHelper.SaveFile(fileName, screenshot);
        }

        public static void SaveFile(string fileName, OpenQA.Selenium.Screenshot screenshot)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                fileName = DateTime.Now.ToString("yyyyMMddHHmmssttt");
            Task.Run(() =>
            {
                string path = Path.Combine(_printsPath, fileName + ".png");
                screenshot.SaveAsFile(path);
            });
        }

        public static void TakeScreenshot(bool traceScreenshot = true)
        {
            if (traceScreenshot)
                DataStoreFactory.ScenarioDataStore.Add(TestContextHelper.traceScreenshotKey, traceScreenshot);

            GaugeScreenshots.Capture();
        }
    }
}
