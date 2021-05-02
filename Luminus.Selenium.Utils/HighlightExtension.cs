using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Utils
{
    public static class HighlightExtension
    {
        public static void Highlight(this IWebElement element)
        {
            var rc = (RemoteWebElement)element;
            var driver = (IJavaScriptExecutor)rc.WrappedDriver;
            var script = @"arguments[0].style.cssText = ""outline: 2px solid #FF0000""; ";
            driver.ExecuteScript(script, rc);

            EventHubHelper.Publish(Events.Highlighted, element);
        }

        public static void ClearHighlight(this IWebElement element)
        {
            try
            {
                var rc = (RemoteWebElement)element;
                var driver = (IJavaScriptExecutor)rc.WrappedDriver;
                var clear = @"arguments[0].style.cssText = ""outline: 2px solid #FF0000""; ";
                driver.ExecuteScript(clear, rc);
            }
            catch (Exception)
            {
            }

            EventHubHelper.Publish(Events.Unhighlighted, element);
        }
    }
}
