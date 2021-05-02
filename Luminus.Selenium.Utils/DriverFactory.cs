using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Html5;
using OpenQA.Selenium.Remote;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Luminus.Selenium.Utils
{
    public class DriverFactory
    {
        public static IWebDriver Driver
        {
            get
            {
                return Create(_browser, _browserPath, _headless, _logChromeDriver, _logBrowserVerbose, _clearCache);
            }
        }

        private static IDriverCacheStrategy _driverCacheStrategy;
        private static Browser _browser;
        private static string _browserPath;
        private static bool _headless;
        private static string _logChromeDriver;
        private static bool _logBrowserVerbose;
        private static bool _clearCache;
        private static string _browserSessionPath;
        private static string _cookieDomainOverwrite;
        private static string _cookiesSufix = ".cookies";

        public static void Initialize(IDriverCacheStrategy driverCacheStrategy, Browser browser, string browserPath, bool headless, string logChromeDriver, bool logBrowserVerbose, bool clearCache, string browserSessionPath, string cookieDomainOverwrite)
        {
            _driverCacheStrategy = driverCacheStrategy;
            _browser = browser;
            _browserPath = browserPath;
            _headless = headless;
            _logChromeDriver = logChromeDriver;
            _clearCache = clearCache;
            _browserSessionPath = browserSessionPath;
            _cookieDomainOverwrite = cookieDomainOverwrite;
            _logBrowserVerbose = logBrowserVerbose;
        }

        public static IWebDriver Create(Browser browser, string browserPath, bool headless, string logChromeDriver, bool logBrowserVerbose, bool clearCache)
        {
            return _driverCacheStrategy.GetOrAdd(() => CreateInternal(browser, browserPath, headless, logChromeDriver, logBrowserVerbose, clearCache, _cookieDomainOverwrite));
        }

        private static IWebDriver CreateInternal(Browser browser, string browserPath, bool headless, string logChromeDriver, bool logBrowserVerbose, bool clearCache, string cookieDomainOverwrite)
        {
            Console.WriteLine("Create webdriver");

            var driver = WebDriverFactory.CreateWebDriver(browser, browserPath, headless, logChromeDriver, logBrowserVerbose);

            if (clearCache)
            {
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Navigate().GoToUrl("chrome://settings/clearBrowserData");
                driver.FindElement(By.XPath("//settings-ui")).SendKeys(Keys.Enter);
            }

            LoadSessionData(driver, cookieDomainOverwrite);

            return driver;
        }

        private static void LoadSessionData(IWebDriver driver, string domainOverwrite = null)
        {
            LoadCookies(driver, domainOverwrite);
        }

        private static void LoadCookies(IWebDriver driver, string domainOverwrite = null)
        {
            string searchPattern = $"*{_cookiesSufix}*";
            string[] files = null;
            try
            {
                if (!Directory.Exists(_browserSessionPath) || (files = Directory.GetFiles(_browserSessionPath, searchPattern)).Length <= 0)
                    return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler a pasta de sessão do browser, salva na execução dos testes, procurando por cookies. Caminho: {_browserSessionPath} Busca: {searchPattern} - Message: {ex.Message} - StackTrace: {ex.StackTrace}");
                throw;
            }

            var lstCookies = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(File.ReadAllText(files.First(), Encoding.Default))
                .Select(x =>
                {
                    return new Cookie(
                       x.ContainsKey("Name") && x["Name"] != null ? x["Name"].ToString() : "",
                       x.ContainsKey("Value") && x["Value"] != null ? x["Value"].ToString() : "",
                       x.ContainsKey("Domain") && x["Domain"] != null ? x["Domain"].ToString() : "",
                       x.ContainsKey("Path") && x["Path"] != null ? x["Path"].ToString() : "",
                       x.ContainsKey("Expiry") && x["Expiry"] != null ? (DateTime?)Convert.ChangeType(x["Expiry"], typeof(DateTime?)) : (DateTime?)null);
                })
                .ToList();

            string domain;

            if (string.IsNullOrWhiteSpace(domainOverwrite))
            {
                domain = lstCookies.Where(x => !string.IsNullOrWhiteSpace(x.Domain)).Select(x => x.Domain).FirstOrDefault();
                domain = domain.StartsWith("http") || domain.StartsWith("www") ? domain : domain.Insert(0, "http://");
            }
            else
                domain = domainOverwrite;

            driver.Navigate().GoToUrl(domain);

            foreach (var cookie in lstCookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }
        }      

        public static void Dispose(IWebDriver driver)
        {
            if (driver != null)
            {
                SaveSessionData(driver);
            }

            _driverCacheStrategy.Dispose();
        }

        private static void SaveSessionData(IWebDriver driver)
        {
            SaveCookies(driver);
        }

        private static void SaveCookies(IWebDriver driver)
        {
            var lstCookies = driver.Manage().Cookies.AllCookies.ToList();
            string jsonCookies = JsonConvert.SerializeObject(lstCookies);
            File.WriteAllText(Path.Combine(_browserSessionPath, Guid.NewGuid().ToString() + $"{_cookiesSufix}.json"), jsonCookies);
        }     
    }
}
