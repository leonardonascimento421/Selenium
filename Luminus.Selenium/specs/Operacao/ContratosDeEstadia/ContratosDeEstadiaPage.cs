
using Luminus.Selenium.Implementation.Pages;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Operacao.ContratosDeEstadia
{
    public class ContratosDeEstadiaPage : BasePage
    {
        public IWebElement RetornarTabelaMidiaDeAcesso()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Mídias de acesso')]/.."),
                    By.CssSelector("table")));
        }


        public IWebElement RetornarTabelaAditamento()
        {
            return _driver.GetElement(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Aditamento')]/.."),
                    By.CssSelector("table")));
        }

        public string RetornarTipoDeMidiaDeAcesso(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Tipo da mídia de acesso", numeroLinha);
        }

        public string RetornarIdentificacao(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Identificação da mídia de acesso", numeroLinha);
        }

        public string RetornarNumeroSerial(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Identificação da mídia de acesso", numeroLinha);
        }

        public string RetornarValorRecebido(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor recebido", numeroLinha);
        }

        public string RetornarValidadoAteePopUpAditamento(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Validado até", numeroLinha);
        }

        public string RetornarFormaPagamento(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Meio de pagamento", numeroLinha);
        }

        public string RetornarDataDaValidacao(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Data da validação", numeroLinha);
        }

        public string RetornarValorDaValidacao(IWebElement tabela, int numeroLinha)
        {
            return _driver.GetColumnText(tabela, "Valor da validação", numeroLinha);
        }

        public void MarcarImediatamente(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), check);
        }

        public bool RetornarImediatamente()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }

        public void SelecionarProdutoDeEstadia(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ProdutoEstadia.Id']"), valor);
        }

        public string RetornarProdutoDeEstadia()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ProdutoEstadia.Id']"));
        }

        public void SelecionarClienteEstacionamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ClienteEstacionamento.Id']"), valor);
        }

        public string RetornarClienteEstacionamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ClienteEstacionamento.Id']"));
        }

        public void PreencherVigenteAPartirDe(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='VigenteAPartirDe']"), valor.ToString());
        }

        public string RetornarVigenteAPartirDe()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='VigenteAPartirDe']"));
        }

        public void PreencherValidoAteData(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValidoAteData']"), valor.ToString());
        }

        public string RetornarValidoAteData()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValidoAteData']"));
        }

        public void PreencherValidoAteHora(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValidoAteHora']"), valor.ToString());
        }

        public string RetornarValidoAteHora()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValidoAteHora']"));
        }

        public void ClicarNoBotaoAdicionarDeMidiasDeAcesso()
        {
            _driver.Click(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Mídias de acesso')]/.."),
                    By.CssSelector("button")));
        }

        public void SelecionarTipoMidia(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='TipoMidia']"), valor);
        }

        public string RetornarTipoMidia()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='TipoMidia']"));
        }

        public void PreencherIdentificacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Identificacao']"), valor.ToString());
        }        

        public void PreencherNumeroSerial(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NumeroSerial']"), valor.ToString());
        }        

        public void PreencherNumeroCartaoCodigoDeBarras(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Numero']"), valor.ToString());
        }

        public string RetornarNumeroCartaoCodigoDeBarras()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Numero']"));
        }

        public void PreencherNumeroCustomerSpacenet(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CustomerSpacenet']"), valor.ToString());
        }

        public string RetornarNumeroCustomerSpacenet()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='CustomerSpacenet']"));
        }

        public void ClicarNoBotaoAdicionarDeAditamento()
        {
            _driver.Click(
                new ByChained(
                    By.XPath("//legend[contains(text(),'Aditamento')]/.."),
                    By.CssSelector("button")));
        }

        public void MarcarValorEditadoManualmente(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='EditadoManualmente']"), check);
        }

        public bool RetornarValorEditadoManualmente()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='EditadoManualmente']"));
        }

        public void SelecionarOpcaoRevalidacao(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='opcaoRevalidacao']"), valor);
        }

        public string RetornarOpcaoRevalidacao()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='opcaoRevalidacao']"));
        }

        public void PreencherValorRecebido(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorRecebido']"), valor.ToString());
        }        

        public void PreencherValidadoAteePopUpAditamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValidadoAte']"), valor.ToString());
        }        

        public void PreencherValidoAtePopUpAditamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValidadoAte']"), valor.ToString());
        }

        public string RetornarValidoAtePopUpAditamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValidoAte']"));
        }

        public void SelecionarFormaPagamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='FormaPagamento']"), valor);
        }        

        public void RetornarVerificarTabelaVaziaMidiaAcesso()
        {           
            new ListagemPage().VerificarTabelaVazia(new ByChained(
                    By.XPath("//legend[contains(text(),'Mídias de acesso')]/.."),
                    By.CssSelector("table")));
        }

        public void RetornarVerificarTabelaVaziaAditamento()
        {
            new ListagemPage().VerificarTabelaVazia(new ByChained(
                    By.XPath("//legend[contains(text(),'Aditamento')]/.."),
                    By.CssSelector("table")));
        }

        public void PreencherDataExpiracaoMidiaAcesso(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataExpiracaoMidiaAcesso']"), valor.ToString());
        }

        public string RetornarDataExpiracaoMidiaAcesso()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DataExpiracaoMidiaAcesso']"));
        }

        public void SelecionarIdMotivoGravacao(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdMotivoGravacao']"), valor);
        }

        public string RetornarIdMotivoGravacao()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdMotivoGravacao']"));
        }

        public void SelecionarIdSituacaoEstadia(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdSituacaoEstadia']"), valor);
        }

        public string RetornarIdSituacaoEstadia()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdSituacaoEstadia']"));
        }


    }
}