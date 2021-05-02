using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.specs.ProdutoDeEstadia.TabelasDeCobranca
{
    public class TabelasDeCobrancaPage : BasePage
    {

        public void PreencherNumeroDaTabelaDeCobranca(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Codigo']"), valor.ToString());
        }

        public string RetornarNumeroDaTabelaDeCobranca()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Codigo']"));
        }

        public void PreencherNomeDaTabelaDeCobranca(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNomeDaTabelaDeCobranca()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void SelecionarEstruturaTabelaCobranca(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='EstruturaTabelaCobrancaId']"), valor.ToString());
        }

        public string RetornarEstruturaTabelaCobranca()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='EstruturaTabelaCobrancaId']"));
        }

        public void SelecionarRegraCobranca(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='RegraCobrancaId']"), valor.ToString());
        }

        public string RetornarRegraCobranca()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='RegraCobrancaId']"));
        }

        public void MarcarDomingo(bool checkDomingo)
        {
            _driver.MarcarCheckBox(new ByChained(
                By.XPath("//label[contains(text(),'Dias da semana')]/.."),
                By.CssSelector("li[title='Domingo']")            
                ), checkDomingo);
        }

        public bool RetornarDomingo()
        {
            return _driver.GetCheck(new ByChained(
            By.CssSelector("li[title='Domingo']"),
            By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSegunda(bool checkSegunda)
        {
            _driver.MarcarCheckBox(new ByChained(
                By.XPath("//label[contains(text(),'Dias da semana')]/.."), 
                By.CssSelector("li[title='Segunda-feira']")
                ), checkSegunda);
        }

        public bool RetornarSegunda()
        {
            return _driver.GetCheck(new ByChained(
          By.CssSelector("li[title='Segunda-feira']"),
          By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarTerca(bool checkTerca)
        {
            _driver.MarcarCheckBox(new ByChained(
                By.XPath("//label[contains(text(),'Dias da semana')]/.."), 
                By.CssSelector("li[title='Terça-feira']")
                ), checkTerca);
        }

        public bool RetornarTerca()
        {
            return _driver.GetCheck(new ByChained(
         By.CssSelector("li[title='Terça-feira']"),
         By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarQuarta(bool checkQuarta)
        {
            _driver.MarcarCheckBox(new ByChained(
                By.XPath("//label[contains(text(),'Dias da semana')]/.."), 
                By.CssSelector("li[title='Quarta-feira']")
                ), checkQuarta);
        }

        public bool RetornarQuarta()
        {
            return _driver.GetCheck(new ByChained(
           By.CssSelector("li[title='Quarta-feira']"),
           By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarQuinta(bool checkQuinta)
        {
            _driver.MarcarCheckBox(new ByChained(
                By.XPath("//label[contains(text(),'Dias da semana')]/.."), 
                By.CssSelector("li[title='Quinta-feira']")
                ), checkQuinta);
        }

        public bool RetornarQuinta()
        {
            return _driver.GetCheck(new ByChained(
        By.CssSelector("li[title='Quinta-feira']"),
        By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSexta(bool checkSexta)
        {
            _driver.MarcarCheckBox(new ByChained(
                By.XPath("//label[contains(text(),'Dias da semana')]/.."), 
                By.CssSelector("li[title='Sexta-feira']")
                ), checkSexta);
        }

        public bool RetornarSexta()
        {
            return _driver.GetCheck(new ByChained(
        By.CssSelector("li[title='Sexta-feira']"),
        By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSabado(bool checkSabado)
        {
            _driver.MarcarCheckBox(new ByChained(
                By.XPath("//label[contains(text(),'Dias da semana')]/.."), 
                By.CssSelector("li[title='Sábado']")
                ), checkSabado);
        }

        public bool RetornarSabado()
        {
            return _driver.GetCheck(new ByChained(
         By.CssSelector("li[title='Sábado']"),
         By.CssSelector("input[type='checkbox']")));
        }

        public void PreencherVigenteAPartirDe(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='VigenteAPartirDe']"), valor.ToString());
        }

        public string RetornarVigenteAPartirDe()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='VigenteAPartirDe']"));
        }

        public void PreencherValorFracao(string valor, int indicePeriodo)
        {
            _driver.SetText(By.XPath($"(//input[@formcontrolname='Valor'])[{indicePeriodo}]"), valor.ToString());    
        }

        public string RetornarValorFracao(int indicePeriodo)
        {
            return _driver.GetText(By.XPath($"(//input[@formcontrolname='Valor'])[{indicePeriodo}]"));
        }
    }
}
