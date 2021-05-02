using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.IO;

namespace Selenium.Utils
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(
            Browser browser, string pathDriver, bool headless, string logChromeDriver, bool logBrowserVerbose)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browser.Firefox:
                    FirefoxOptions optionsFF = new FirefoxOptions();
                    if (headless)
                        optionsFF.AddArgument("--headless");

                    if (string.IsNullOrWhiteSpace(pathDriver))
                        webDriver = new FirefoxDriver(optionsFF);
                    else
                        webDriver = new FirefoxDriver(pathDriver, optionsFF);

                    break;
                case Browser.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    if (headless)
                        options.AddArgument("--headless");

                    options.AddArgument("no-sandbox");
                    options.AddArgument("start-maximized"); // open Browser in maximized mode
                    options.AddArgument("disable-infobars"); // disabling infobars
                    options.AddArgument("--disable-extensions"); // disabling extensions
                    options.AddArgument("--disable-gpu"); // applicable to windows os only
                    options.AddArgument("--disable-dev-shm-usage"); // overcome limited resource problems
                    options.AddArgument("--no-sandbox"); // Bypass OS security model
                    options.AddArgument("--lang=pt-BR"); // language
                    pathDriver = pathDriver.Replace("[Diretorio]", AppContext.BaseDirectory);
                    ChromeDriverService service;
                    if (string.IsNullOrWhiteSpace(pathDriver))
                        service = ChromeDriverService.CreateDefaultService();
                    else
                        service = ChromeDriverService.CreateDefaultService(pathDriver);
                    service.Port = 9515;
                    service.LogPath = Path.IsPathRooted(logChromeDriver) ? logChromeDriver : Path.Combine(Directory.GetCurrentDirectory(), logChromeDriver);
                    service.EnableVerboseLogging = logBrowserVerbose;
                    webDriver = new ChromeDriver(service, options, TimeSpan.FromMinutes(10));
                    break;
            }

            return webDriver;
        }
    }
}