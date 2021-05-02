using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utils;
using System;

namespace Luminus.Selenium.Implementation.Pages.Shared.Login
{
    public class LoginPage : BasePage
    {
        public void PreencherUsuario(string valor)
        {
            _driver.SetText(By.Name("username"), valor.ToString());
        }

        public void PreencherSenha(string valor)
        {
            _driver.SetText(By.Name("password"), valor.ToString());
        }

        public void Processar()
        {
            _driver.Click(By.Id("submit"));
        }

        public void RedirecionarLogin(string url)
        {
            Console.WriteLine($"Url navegação: {url}");
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(5);
            _driver.Navigate().GoToUrl(url);

            var wait = new WebDriverWait(_driver, TimeSpan.FromMinutes(5));
            wait.Until(ExpectedConditions.UrlContains(Config.Aplicacao.PortaLoginIdentityServer));

            Console.WriteLine($"Url após navegação: {_driver.Url}");
            EventHubHelper.Publish(Events.Navigated, null);
            WebDriverExtensions.AguardarLoading(_driver);
        }
    }
}
