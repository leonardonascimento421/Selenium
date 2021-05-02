using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Customizacao.Multimidia
{
    public class MultimidiaPage : BasePage
    {
        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }


        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }


        public void SelecionarMultimidiaAudio(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Upload']"), valor.ToString());
        }


        public void SelecionarMultimidiaImagem(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Upload']"), valor.ToString());
        }


        public IWebElement RetornarTabelaArquivoMultimidia()
        {
            return _driver.GetElement(By.CssSelector(".table"));
        }


        public string RetornarNomeArquivoAudio(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Nome", numeroLinha);
        }


        public string RetornarMimetypeArquivoAudio(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Extensão", numeroLinha);
        }


        public string RetornarNomeArquivoImagem(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Nome", numeroLinha);
        }


        public string RetornarMimetypeArquivoImagem(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Extensão", numeroLinha);
        }
    }
}