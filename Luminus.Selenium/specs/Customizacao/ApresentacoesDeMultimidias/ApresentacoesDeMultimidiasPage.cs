using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Customizacao.ApresentacoesDeMultimidias
{
    public class ApresentacoesDeMultimidiasPage : BasePage
    {
        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }


        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }


        public void SelecionarMultimidia(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ArquivoMultimidia_Id']"), valor);
        }


        public string RetornarMultimidia()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ArquivoMultimidia_Id']"));
        }


        public void SelecionarGatilho(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='GatilhoMensagemAudio']"), valor);
        }


        public string RetornarGatilho()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='GatilhoMensagemAudio']"));
        }


        public IWebElement RetornarTabelaMultimidia()
        {
            return _driver.GetElement(By.CssSelector(".table"));
        }


        public string RetornarNomeMultimidia(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Multimídia", numeroLinha);
        }


        public string RetornarGatilho(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Gatilho", numeroLinha);
        }


        public void SelecionarTempoExibicaoImagem(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoExibicaoImagem']"), valor);
        }


        public string RetornarTempoExibicaoImagem(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Tempo de exibição (seg)", numeroLinha);
        }


        public void SelecionarPosicaoVerticalMensagem(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='PosicaoVerticalMensagem']"), valor);
        }


        public string RetornarPosicaoVerticalMensagem(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Posição vertical da mensagem", numeroLinha);
        }


        public void SelecionarPosicaoHorizontalMensagem(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='PosicaoHorizontalMensagem']"), valor);
        }


        public string RetornarPosicaoHorizontalMensagem(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Posição horizontal da mensagem", numeroLinha);
        }


        public void SelecionarCorFonteMensagem(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CorFonteMensagem']"), valor);
        }


        public void SelecionarCorFundoMensagem(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CorFundoMensagem']"), valor);
        }
    }
}