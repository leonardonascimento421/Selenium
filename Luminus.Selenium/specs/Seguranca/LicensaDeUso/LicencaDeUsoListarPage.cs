using FluentAssertions;
using Luminus.Selenium.Implementation.Pages;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Seguranca.LicencaDeUso
{
    public class LicencaDeUsoListarPage : BasePage
    {
        public void ClicarBotaoCarregar()
        {
            _driver.Click(By.XPath($"//button[contains(.,'carregar')]"));
        }
    }
}