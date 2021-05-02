
using Luminus.Selenium.Implementation.Pages;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Operacao.OperacaoDeMultiplasCancelas
{
    public class OperacaoDeMultiplasCancelasPage : BasePage
    {
        private By byModal = By.XPath("//*[contains(@class, 'modal fade in')]");

        public void VerificarMensagemDeErroNoCampoNaSecaoEquipamentos(string erro)
        {
            new MensagemSpec().VerificarMensagemDeErroNoCampo(erro, By.XPath("//legend[contains(text(),'Equipamentos')]/.."));
        }

        public void VerificarMensagemDeErroNoCampoNaSecaoAcao(string erro)
        {
            new MensagemSpec().VerificarMensagemDeErroNoCampo(erro, By.XPath("//legend[contains(text(),'Ação')]/.."));
        }

        public void MarcarAcaoAbrir(bool check)
        {
            _driver.MarcarCheckBox(By.XPath("(.//input[@name='acao'])[1]"), check);
        }

        public bool RetornarMarcarAcaoAbrir(bool modal = false)
        {
            By by = By.XPath("(.//input[@name='acao'])[1]");
            if (modal)
                by = by.CombineBefore(byModal);

            return _driver.GetCheck(by);
        }

        public void MarcarAcaoFechar(bool check)
        {
            _driver.MarcarCheckBox(By.XPath("(.//input[@name='acao'])[2]"), check);
        }

        public bool RetornarMarcarAcaoFechar(bool modal = false)
        {
            By by = By.XPath("(.//input[@name='acao'])[2]");
            if (modal)
                by = by.CombineBefore(byModal);

            return _driver.GetCheck(by);
        }

        public void MarcarEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='entrada']"), check);
        }

        public bool RetornarMarcarEntrada(bool modal = false)
        {
            By by = By.CssSelector("input[name='entrada']");
            if (modal)
                by = by.CombineBefore(byModal);

            return _driver.GetCheck(by);
        }

        public void MarcarPassagem(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='passagem']"), check);
        }

        public bool RetornarMarcarPassagem(bool modal = false)
        {
            By by = By.CssSelector("input[name='passagem']");
            if (modal)
                by = by.CombineBefore(byModal);

            return _driver.GetCheck(by);
        }

        public void MarcarSaida(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='saida']"), check);
        }

        public bool RetornarMarcarSaida(bool modal = false)
        {
            By by = By.CssSelector("input[name='saida']");
            if (modal)
                by = by.CombineBefore(byModal);

            return _driver.GetCheck(by);
        }

        public void SelecionarOcorrencia(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[name='ocorrencia']"), valor.ToString());
        }

        public string RetornarOcorrencia(bool modal = false)
        {
            By by = By.CssSelector("select[name='ocorrencia']");
            if (modal)
                by = by.CombineBefore(byModal);

            return _driver.GetSelect(by);
        }

        public void PreencherJustificativa(string valor)
        {
            _driver.SetText(By.CssSelector("textarea[name='justiicativa']"), valor.ToString());
        }

        public string RetornarJustificativa(bool modal = false)
        {
            By by = By.CssSelector("textarea[name='justiicativa']");
            if (modal)
                by = by.CombineBefore(byModal);

            return _driver.GetText(by);
        }
    }
}




