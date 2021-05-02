using Gauge.CSharp.Lib.Attribute;
using Gauge.CSharp.Lib;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luminus.Selenium.Implementation.Pages;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using OpenQA.Selenium.Support.PageObjects;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.RegrasDeEmissaoDeBilhetesImpressos
{
    public class RegrasDeEmissaoDeBilhetesImpressosPage : BasePage
    {
        public string RetornarVersaoEmissaoDeBilhetes()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Versao']"));
        }

        public void PreencherVigenciaData(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='VigenciaData']"), valor.ToString());
        }

        public string RetornarVigenciaData()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='VigenciaData']"));
        }

        public void MarcarImediatamente(bool valor)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), valor);
        }

        public string RetornarImediatamente()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }


        public void PreencherNomeRegraDeRecibo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNomeRegraDeRecibo()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void PreencherCabecalhoLinhaUm(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CabecalhoLinhaUm']"), valor.ToString());
        }

        public string RetornarCabecalhoLinhaUm()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='CabecalhoLinhaUm']"));
        }

        public void PreencherCabecalhoLinhaDois(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CabecalhoLinhaDois']"), valor.ToString());
        }

        public string RetornarCabecalhoLinhaDois()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='CabecalhoLinhaDois']"));
        }

        public void PreencherRodapeLinhaUm(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='RodapeLinhaUm']"), valor.ToString());
        }

        public string RetornarRodapeLinhaUm()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='RodapeLinhaUm']"));
        }

        public void PreencherRodapeLinhaDois(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='RodapeLinhaDois']"), valor.ToString());
        }

        public string RetornarRodapeLinhaDois()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='RodapeLinhaDois']"));
        }

        public void SelecionarEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Equipamento']"), valor.ToString());
        }

        public string RetornarEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='Equipamento']"));
        }

        public void SelecionarRegraAplicar(string valor, bool check)
        {
            _driver.MarcarCheckBox(
                new ByChained(
                    By.XPath($".//tr[contains(.,'{valor}')]"),
                    By.CssSelector("input[formcontrolname='Selecionado']")                    
                    ), check);
        }

    }
}