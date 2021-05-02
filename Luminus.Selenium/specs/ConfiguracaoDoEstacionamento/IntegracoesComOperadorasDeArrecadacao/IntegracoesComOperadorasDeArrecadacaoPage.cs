
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.IntegracoesComOperadorasDeArrecadacao
{
    public class IntegracoesComOperadorasDeArrecadacaoPage : BasePage
    {

        public void PreencherNomeSempararintegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNomeSempararintegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void SelecionarOperadoradearrecadacaointegracaooperadoraarrecadacao(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='OperadoraArrecadacao']"), valor);
        }

        public string RetornarOperadoradearrecadacaointegracaooperadoraarrecadacao()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='OperadoraArrecadacao']"));
        }

        public void SelecionarTipodeintegracaointegracaooperadoraarrecadacao(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='TipoIntegracao']"), valor);
        }

        public string RetornarTipodeintegracaointegracaooperadoraarrecadacao()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='TipoIntegracao']"));
        }

        public void PreencherIgnorarleituradamesmatagsegintegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='IgnorarLeituraSeg']"), valor.ToString());
        }

        public string RetornarIgnorarleituradamesmatagsegintegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='IgnorarLeituraSeg']"));
        }

        public void PreencherTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoLimite']"), valor.ToString());
        }

        public string RetornarTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoLimite']"));
        }

        public void MarcarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ManterCancela']"), check);
        }

        public bool RetornarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ManterCancela']"));
        }

        public void MarcarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirOperadora']"), check);
        }

        public bool RetornarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirOperadora']"));
        }

        public void PreencherEnderecoIPdoservicointegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='EnderecoIP']"), valor.ToString());
        }

        public string RetornarEnderecoIPdoservicointegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='EnderecoIP']"));
        }

        public void PreencherPortaintegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Porta']"), valor.ToString());
        }

        public string RetornarPortaintegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Porta']"));
        }

        public void PreencherCaminhointegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("textarea[formcontrolname='Caminho']"), valor.ToString());
        }

        public string RetornarCaminhointegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("textarea[formcontrolname='Caminho']"));
        }

        public void PreencherUsuariointegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Usuario']"), valor.ToString());
        }

        public string RetornarUsuariointegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Usuario']"));
        }

        public void PreencherSenhaintegracaooperadoraarrecadacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Senha']"), valor.ToString());
        }

        public string RetornarSenhaintegracaooperadoraarrecadacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Senha']"));
        }

        public void MarcarImediatamenteintegracaooperadoraarrecadacaoalterar(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), check);
        }

        public bool RetornarImediatamenteintegracaooperadoraarrecadacaoalterar()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }

        public void NomeSempararintegracaooperadoraarrecadacaoalterar(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetonarNomeSempararintegracaooperadoraarrecadacaoalterar()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void Ignorarleituradamesmatagsegintegracaooperadoraarrecadacaoalterar(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='IgnorarLeituraSeg']"), valor.ToString());
        }

        public string RetornarIgnorarleituradamesmatagsegintegracaooperadoraarrecadacaoalterar()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='IgnorarLeituraSeg']"));
        }

        public void Tempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacaoalterar(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoLimite']"), valor.ToString());
        }

        public string RetornarTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacaoalterar()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoLimite']"));
        }

    }
}