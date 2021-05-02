using OpenQA.Selenium;
using System;

namespace Luminus.Selenium.Utils
{
    public class DriverCacheSingletonStrategy : IDriverCacheStrategy
    {
        private static IWebDriver _staticWebDriver;

        public IWebDriver GetOrAdd(Func<IWebDriver> driverFactory)
        {
            IWebDriver webDriver;

            webDriver = _staticWebDriver;

            if (webDriver == null)
            {
                webDriver = driverFactory();

                Console.WriteLine($"webDriver criado: {webDriver?.ToString()}");

                _staticWebDriver = webDriver;
            }

            return webDriver;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose webdriver");
            var driver = _staticWebDriver;
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }        
    }
}
