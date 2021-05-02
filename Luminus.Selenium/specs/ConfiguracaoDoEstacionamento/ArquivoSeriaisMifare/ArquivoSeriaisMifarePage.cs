
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ArquivoSeriaisMifare
{
    public class ArquivoSeriaisMifarePage : BasePage
    {

        public void EscolherArquivoSerialMifare(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Arquivo']"), valor);
        }

        public void ClicarBotaoCarregarArquivo()
        {
            _driver.Click(By.XPath($"//button[contains(.,'carregar')]"));
        }

    }
}