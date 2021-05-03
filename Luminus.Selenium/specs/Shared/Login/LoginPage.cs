using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utils;
using System;

namespace Luminus.Selenium.Implementation.Pages.Shared.Login
{
    public class LoginPage : BasePage
    {
        public void AbrirPaginaInicial(string url)
        {
            Console.WriteLine($"Url navegação: {url}");
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(5);
            _driver.Navigate().GoToUrl(url);
            Console.WriteLine($"Url após navegação: {_driver.Url}");
            EventHubHelper.Publish(Events.Navigated, null);
        }
    }
}
