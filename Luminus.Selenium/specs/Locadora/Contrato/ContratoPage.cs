
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System.Collections.Generic;

namespace Luminus.Selenium.specs.Locadora.Contrato
{
    public class ContratoPage : BasePage
    {
        public void PreencherNomeDoContratoContratoLocadora(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNomeDoContratoContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }        

        public void SelecionarTipoDeCalculoExcedenteContratoLocadora(string valor)
        {
            _driver.SelecionarCombo(new ByChained(By.CssSelector("np-select-enum[controlname='IndexTipoCalculoExcedente']"), By.CssSelector("select")), valor.ToString());
        }

        public string RetornarTipoDeCalculoExcedenteContratoLocadora()
        {
            return _driver.GetSelect(new ByChained(By.CssSelector("np-select-enum[controlname='IndexTipoCalculoExcedente']"), By.CssSelector("select")));
        }

        public void PreencherValorMensalidadeContratoLocadora(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorMensalidade']"), valor.ToString());
        }

        public string RetornarValorMensalidadeContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMensalidade']"));
        }

        public void PreencherDiaDeVencimentoContratoLocadora(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DiaVencimento']"), valor.ToString());
        }

        public string RetornarDiaDeVencimentoContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DiaVencimento']"));
        }

        public void PreencherQuantidadeDeVagasContratoLocadora(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QuantidadeDeVagas']"), valor.ToString());
        }

        public string RetornarQuantidadeDeVagasContratoLocadora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QuantidadeDeVagas']"));
        }

        public void SelecionarNometabelasdecobrancaExcedente(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaExcedente']"), valor);
        }

        public string RetornarNometabelasdecobrancaExcedente()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaExcedente']"));
        }

        public void SelecionarNometabelasdecobrancaCheckIn(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaCheckin']"), valor);
        }

        public string RetornarNometabelasdecobrancaCheckIn()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaCheckin']"));
        }

        public void SelecionarNometabelasdecobrancaCheckOut(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaCobrancaCheckout']"), valor);
        }

        public string RetornarNometabelasdecobrancaCheckOut()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaCobrancaCheckout']"));
        }

        public void SelecionarNomeUsuarioSistema(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.XPath("//label[contains(text(),'Não selecionados')]/.."),
            By.CssSelector("select"))
            , valor);
        }

        public IEnumerable<string> RetornarNomeUsuarioSistema()
        {
            return _driver.GetItems(new ByChained(
             By.XPath("//label[contains(text(),'Selecionados')]/.."),
             By.CssSelector("select")));
        }

        public void MarcarImediatamenteContratoLocadora(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), checkConsultarVeiculos);
        }
    }
}
