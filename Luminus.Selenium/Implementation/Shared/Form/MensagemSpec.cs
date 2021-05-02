using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using OpenQA.Selenium;

namespace Luminus.Selenium.Implementation.Shared.Form
{
    public class MensagemSpec
    {
        private MensagemPage _page = new MensagemPage();

        [Step("Verificar mensagem criacao com sucesso")]
        public void VerificarMensagemCriacaoComSucesso()
        {
            VerificarMensagem("Cria��o realizada com sucesso.");
        }

        [Step("Verificar mensagem alteracao com sucesso")]
        public void VerificarMensagemAlteracaoComSucesso()
        {
            VerificarMensagem("Altera��o realizada com sucesso.");
        }

        [Step("Verificar mensagem exclusao com sucesso")]
        public void VerificarMensagemExclusaoComSucesso()
        {
            VerificarMensagem("Exclus�o realizada com sucesso.");
        }

        [Step("Verificar mensagem aplicacao com sucesso")]
        public void VerificarMensagemAplicacaoComSucesso()
        {
            VerificarMensagem("Aplica��o realizada com sucesso");
        }

        [Step("Verificar mensagem Opera��o executada com sucesso")]
        public void VerificarMensagemOperacaoComSucesso()
        {
            VerificarMensagemPortal("Opera��o executada com sucesso.");
        }

        [Step("Verificar mensagem de erro do campo <erro>")]
        public void VerificarmensagemDoCampo(string erro)
        {
            VerificarMensagemDeErroNoCampo(erro);
        }        

        [Step("Validar mensagem <mensagem>")]
        public void Verificarmensagem(string mensagem)
        {
            _page.ListarMensagens().Should().Contain(mensagem).And.HaveCount(1);
        }

        public void VerificarMensagemDeErroNoCampo(string mensagem, By by = null)
        {
            _page.ListarMensagensDeErroNoCampo().Should().Contain(mensagem);
        }

        private void VerificarMensagem(string mensagem)
        {
            _page.ListarMensagens().Should().Contain(mensagem).And.HaveCount(1);
        }

        private void VerificarMensagemPortal(string mensagem)
        {
            _page.ListarMensagensPortal(mensagem).Should().Contain(mensagem).And.HaveCount(1);
        }
        

    }
}
