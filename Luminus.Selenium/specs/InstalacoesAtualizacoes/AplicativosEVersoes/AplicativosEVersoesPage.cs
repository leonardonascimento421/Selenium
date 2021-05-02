
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;
using System;

namespace Luminus.Selenium.specs.InstalacoesAtualizacoes.AplicativosEVersoes
{
    public class AplicativosEVersoesPage : BasePage
    {
        public void ClicarBotaoCarregarArquivo()
        {
            _driver.Click(By.XPath($"//button[contains(.,'carregar arquivo')]"));
        }

        public void ClicarBotaoCarregar(TimeSpan timeout = default(TimeSpan))
        {
            _driver.Click(By.XPath($"//button[contains(.,'carregar')]"), timeout);
        }

        public void EscolherArquivo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Arquivo']"), valor);
        }

        public void ClicarNoValorDaListagemApresentadaNaTela(string versao)
        {
            _driver.Click(By.XPath($"//button[contains(.,'{versao}')]"));
        }

        public IWebElement ClicarNoValorDaListagemApresentadaNaTelaDentro(string numeroDaVersaoAplicativoVersao)
        {
            return _driver.Click(By.XPath($"//tr[contains(.,'{numeroDaVersaoAplicativoVersao}')]"));
        }

        public string Retornarsigla()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Sigla]"));
        }

        public string RetornarnomeAplicativoVersao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Nome]"));
        }

        public string RetornardescricaoAplicativo()
        {
            return _driver.GetText(By.XPath("//div[2]/div/div/textarea"));
        }

        public string RetornarnumeroDaVersao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=NumeroVersao]"));
        }

        public string RetornarsistemaOperacional()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=SistemaOperacional]"));
        }

        public string RetornaraplicativoVersao()
        {
            return _driver.GetLinkText(By.CssSelector("a[download$='.zip']"));
        }

        public string RetornardescricaoVersao()
        {
            return _driver.GetText(By.XPath("//div[3]/div/div/textarea"));
        }
    }
}