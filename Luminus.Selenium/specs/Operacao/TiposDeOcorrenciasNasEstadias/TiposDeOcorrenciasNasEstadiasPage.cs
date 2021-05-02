
using System;
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Operacao.TiposDeOcorrenciasNasEstadias
{
    public class TiposDeOcorrenciasNasEstadiasPage : BasePage
    {
        public IWebElement ClicarNoValorDaListagemApresentadaNaTelaDentro(string nomeTipoDeOcorrenciaNasEstadias)
        {
            return _driver.Click(By.XPath($"//tr[contains(.,'{nomeTipoDeOcorrenciaNasEstadias}')]"));
        }

        public string RetornarnomeTipoDeOcorrenciaNasEstadias()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Nome]"));
        }

        public void PreenchernomeTipoDeOcorrenciaNasEstadias(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Nome]"), valor.ToString());
        }

        public void MarcarocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OcorrenciaPadrao']"), check);
        }

        public void MarcarobrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ObrigarPreenchimentoJustificativa']"), check);
        }

        public bool RetornarobrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ObrigarPreenchimentoJustificativa']"));
        }        

        public bool RetornarocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OcorrenciaPadrao']"));
        }

    }
}