
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Locadora.FechamentoFatura
{
    public class FechamentoFaturaPage : BasePage
    {

        public void SelecionarNomeDoContratoContratoLocadora(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdContratoLocadora']"), valor);
        }

        public string RetornarNomeDoContratoContratoLocadora()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdContratoLocadora']"));
        }

        public void PreencherDataFechamentoFechamentoFatura(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataFechamento']"), valor.ToString());
        }

        public string RetornarDataFechamentoFechamentoFatura()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DataFechamento']"));
        }

        public void PreencherHoraFechamentoFechamentoFatura(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='HoraFechamento']"), valor.ToString());
        }

        public string RetornarHoraFechamentoFechamentoFatura()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='HoraFechamento']"));
        }

        public void PreencherHoraLiquidacaoFechamentoFatura(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='HoraLiquidacao']"), valor.ToString());
        }

        public string RetornarHoraLiquidacaoFechamentoFatura()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='HoraLiquidacao']"));
        }

        public string RetornarNumeroFaturaContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='NumeroFatura']"));
        }

        public string RetornarDataPagamentoFaturaContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DataLiquidacao']")); 
        }

        public string RetornarValorParcialFaturaContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorGerado']"));
        }

        public string RetornarValorMensalistaFaturaContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMensalidade']"));
        }

        public string RetornarTipoCalculoExcedenteFaturaContratoLocadora()
        {
            return _driver.GetSelect(new ByChained(By.CssSelector("np-select-enum[controlname='IndexTipoCalculoExcedente']"), By.CssSelector("select")));
        }

        public void PreencherDataPagamentoFechamentoFatura(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataLiquidacao']"), valor.ToString());
        }

        public void ClicarBotaoliquidarListagem(IWebElement element)
        {
            ClicarLinkPorTexto("liquidar", element);
        }

        private void ClicarLinkPorTexto(string texto, IWebElement element)
        {
            _driver.Click(By.XPath($"//a[contains(.,'{texto}')]"), element);
        }

        public IWebElement ClicarBotao3Pontos(IWebElement element = null)
        {
            return _driver.Click(By.CssSelector(".menu-popovertable"), element);
        }

        public void ClicarBotaoLiquidar()
        {
            ClicarBotaoPorTexto("liquidar");
        }

        public void ClicarBotaoPorTexto(string texto, IWebElement element = null)
        {
            _driver.Click(By.XPath($".//button[contains(.,'{texto}')]"), element); 
        }

        public IWebElement ClicarNaLinhaDaColunaNumeroFaturaComValor2()
        {
            return _driver.Click(By.XPath($"//tbody/tr[2]"));
        }

    }
}