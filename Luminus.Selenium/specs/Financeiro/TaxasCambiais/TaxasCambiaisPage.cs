
using Gauge.CSharp.Lib;
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Financeiro.TaxasCambiais
{
    public class TaxasCambiaisPage : BasePage
    {
        public void PreencherVigenteAPartirtaxacambial(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='VigenciaData']"), valor.ToString());
        }

        public string RetornarVigenteAPartirtaxacambial()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='VigenciaData']"));
        }

        public void PreencherVigenteAPartirHoraeMinuto(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='VigenciaHora']"), valor.ToString());
        }

        public string RetornarVigenteAPartirHoraeMinuto()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='VigenciaHora']"));
        }

        public void MarcarImediatamentetaxacambial(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), checkConsultarVeiculos);
        }

        public bool RetornarImediatamentetaxacambial()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }

        public void PreencherVigenteAtetaxacambial(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataFimVigenciaData']"), valor.ToString());
        }

        public string RetornarVigenteAtetaxacambial()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DataFimVigenciaData']"));
        }

        public void PreencherVigenteAteHoraeMinutotaxacambial(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataFimVigenciaHora']"), valor.ToString());
        }

        public string RetornarVigenteAteHoraeMinutotaxacambial()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DataFimVigenciaHora']"));
        }

        public void SelecionarMoedaBase(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='MoedaBase.Id']"), valor.ToString());
        }

        public string RetornarMoedaBase()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='MoedaBase.Id']"));
        }

        public void SelecionarMoedaBasetaxacambial(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='MoedaPara.Id']"), valor.ToString());
        }

        public string RetornarMoedaBasetaxacambial(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Moeda para", numeroLinha);
        }

        public void PreencherValorTaxaDireta(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TaxaCambialDireta']"), valor.ToString());
        }

        public string RetornarValorTaxaDireta(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor taxa direta", numeroLinha);
        }

        public string RetornarNaoaRegistro()
        {
            return _driver.GetText(By.XPath($"//table[@class='table']//td[contains(text(),'Não há registros a serem exibidos')]"));
        }

        public IWebElement RetornarTabelaTaxasCambiaisPorMoeda()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Taxas cambiais por moeda')]/.."),
                    By.CssSelector("table")));
        }
    }
}