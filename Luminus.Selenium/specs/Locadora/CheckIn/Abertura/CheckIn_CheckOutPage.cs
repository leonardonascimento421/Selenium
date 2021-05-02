
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System.Threading;

namespace Luminus.Selenium.specs.CheckIn.Abertura
{
    public class CheckIn_CheckOutPage : BasePage
    {
        public void ClicarNoMenuLocadora()
        {
            _driver.Click(By.CssSelector("a[title='Locadora']"));
        }

        public void ClicarNoLinkCheckInCheckOut()
        {
            _driver.Click(By.XPath("//a[contains(text(), 'Checkin/Checkout')]"));       
        }

        public void PreencherIdentificacaoMidia(string valor)
        {
            _driver.SetText(By.CssSelector("input[ng-reflect-name='IdentificacaoMidia']"), valor.ToString());
        }

        public string RetornarIdentificacaoMidia()
        {
            return _driver.GetText(By.CssSelector("input[ng-reflect-name='IdentificacaoMidia']"));
        }

        public void ClicarBotaoBuscar()
        {
            _driver.Click(By.CssSelector("input[value='Buscar']"));
        }

        public void ClicarBotaoConfirmar()
        {
            _driver.Url.Contains("/login");
            Thread.Sleep(15000);
            _driver.ScrollToElementToView(By.CssSelector("input[value='Confirmar']"));           
            _driver.Click(By.CssSelector("input[value='Confirmar']"));
        }
        
    }
}