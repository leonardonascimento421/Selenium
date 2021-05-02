using Luminus.Selenium.Implementation.Pages;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.specs.ProdutoDeEstadia.EstruturaDeTabelaDeCobranca
{
    public class EstruturasDeTabelasDeCobrancaPage : BasePage
    {
        private BotoesCRUDPage _pageBotoes = new BotoesCRUDPage();

        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void MarcarDomingo(bool checkDomingo)
        {
            _driver.MarcarCheckBox(new ByChained(By.CssSelector("li[title='Domingo']"), By.CssSelector("input[type='checkbox']")), checkDomingo);
        }

        public bool RetornarDomingo()
        {
            return _driver.GetCheck(new ByChained(
            By.CssSelector("li[title='Domingo']"),
            By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSegunda(bool checkSegunda)
        {
            _driver.MarcarCheckBox(new ByChained(By.CssSelector("li[title='Segunda-feira']"), By.CssSelector("input[type='checkbox']")), checkSegunda);

        }

        public bool RetornarSegunda()
        {
            return _driver.GetCheck(new ByChained(
          By.CssSelector("li[title='Segunda-feira']"),
          By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarTerca(bool checkTerca)
        {
            _driver.MarcarCheckBox(new ByChained(By.CssSelector("li[title='Terça-feira']"), By.CssSelector("input[type='checkbox']")), checkTerca);
        }

        public bool RetornarTerca()
        {
            return _driver.GetCheck(new ByChained(
         By.CssSelector("li[title='Terça-feira']"),
         By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarQuarta(bool checkQuarta)
        {
            _driver.MarcarCheckBox(new ByChained(By.CssSelector("li[title='Quarta-feira']"), By.CssSelector("input[type='checkbox']")), checkQuarta);
        }

        public bool RetornarQuarta()
        {
            return _driver.GetCheck(new ByChained(
           By.CssSelector("li[title='Quarta-feira']"),
           By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarQuinta(bool checkQuinta)
        {
            _driver.MarcarCheckBox(new ByChained(By.CssSelector("li[title='Quinta-feira']"), By.CssSelector("input[type='checkbox']")), checkQuinta);
        }

        public bool RetornarQuinta()
        {
            return _driver.GetCheck(new ByChained(
        By.CssSelector("li[title='Quinta-feira']"),
        By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSexta(bool checkSexta)
        {
            _driver.MarcarCheckBox(new ByChained(By.CssSelector("li[title='Sexta-feira']"), By.CssSelector("input[type='checkbox']")), checkSexta);
        }

        public bool RetornarSexta()
        {
            return _driver.GetCheck(new ByChained(
        By.CssSelector("li[title='Sexta-feira']"),
        By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSabado(bool checkSabado)
        {
            _driver.MarcarCheckBox(new ByChained(By.CssSelector("li[title='Sábado']"), By.CssSelector("input[type='checkbox']")), checkSabado);
        }

        public bool RetornarSabado()
        {
            return _driver.GetCheck(new ByChained(
         By.CssSelector("li[title='Sábado']"),
         By.CssSelector("input[type='checkbox']")));
        }

        public void PreencherPeriodoInicio(string valor)
        {
            _driver.SetText(new ByChained(
                By.XPath("//label[contains(text(),'Período 1 - Inicio:')]/.."),
                By.CssSelector("input[formcontrolname='Inicio']")), valor.ToString());
        }

        public string RetornarPeriodoInicio()
        {
            return _driver.GetText(new ByChained(
             By.XPath("//label[contains(text(),'Período 1 - Inicio:')]/.."),
             By.CssSelector("input[formcontrolname='Inicio']")));
        }

        public void PreencherPeriodoInicio2(string valor)
        {
            _driver.SetText(new ByChained(
                By.XPath("//label[contains(text(),'Período 2 - Inicio:')]/.."),
                By.CssSelector("input[formcontrolname='Inicio']")), valor.ToString());
        }

        public string RetornarPeriodoInicio2()
        {
            return _driver.GetText(new ByChained(
             By.XPath("//label[contains(text(),'Período 2 - Inicio:')]/.."),
             By.CssSelector("input[formcontrolname='Inicio']")));
        }

        public void PreencherDuracao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Duracao']"), valor.ToString());
        }

        public string RetornarDuracao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Duracao']"));
        }

        public void PreencherRepeticao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Repeticao']"), valor.ToString());
        }

        public string RetornarRepeticao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Repeticao']"));
        }

        public void SelecionarIntervaloRepeticoesPeriodoDe(string valor, int indicePeriodo)
        {
            _driver.SelecionarCombo(
                By.XPath($"(//select[@formcontrolname='IntervaloRepeticoesPeriodoDe'])[{indicePeriodo}]"), valor.ToString());
        }

        public string RetornarIntervaloRepeticoesPeriodoDe(int indicePeriodo)
        {
            return _driver.GetSelect(By.XPath($"(//select[@formcontrolname='IntervaloRepeticoesPeriodoDe'])[{indicePeriodo}]"));
        }

        public void SelecionarIntervaloRepeticoesPeriodoAte(string valor, int indicePeriodo)
        {
            _driver.SelecionarCombo(By.XPath($"(//select[@formcontrolname='IntervaloRepeticoesPeriodoAte'])[{indicePeriodo}]"), valor.ToString());
        }

        public string RetornarIntervaloRepeticoesPeriodoAte(int indicePeriodo)
        {
            return _driver.GetSelect(By.XPath($"(//select[@formcontrolname='IntervaloRepeticoesPeriodoAte'])[{indicePeriodo}]"));
        }

        public string RetornarBotaoCriarDesabilitado(string nome, string atributo)
        {
            return _driver.IsAttributePresent(atributo, By.XPath(".//button[@funcionalidade='ProdutoEstadia.EstruturaTabelaCobranca.Incluir']"));
        }

        public void MarcarImediatamente(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), check); 
        }

        public void ClicarBotaoAdicionarEstrutura()
        {
            _pageBotoes.ClicarBotaoPorTexto("adicionar estrutura");
        }

        public void ClicarBotaoAdicionarPeriodo(int indice)
        {
            ClicarBotaoPorTextoComIndice("adicionar período", indice);
        }

        public void ClicarBotaoAdicionarFracao(int indice)
        {
            ClicarBotaoPorTextoComIndice("adicionar fração", indice);
        }

        public void ClicarBotaoPorTextoComIndice(string texto, int indice, IWebElement element = null)
        {
            _driver.Click(By.XPath($"(.//button[contains(.,'{texto}')])[{indice}]"), element);
        }

    }
}
