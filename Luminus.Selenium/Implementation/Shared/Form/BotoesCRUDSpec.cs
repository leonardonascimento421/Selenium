using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;

namespace Luminus.Selenium.Implementation.Shared.Form
{
    public class BotoesCRUDSpec
    {
        private BotoesCRUDPage _page = new BotoesCRUDPage();

        [Step("Clicar no botão Adicionar")]
        public void ClicarNoBotaoAdicionar()
        {
            _page.ClicarBotaoAdicionar();
        }

        [Step("Clicar no botão Adicionar Pop Up")]
        public void ClicarNoBotaoAdicionarPopUp()
        {
            _page.ClicarBotaoAdicionarPopUp();
        }

        [Step("Clicar no botão Alterar Pop Up")]
        public void ClicarNoBotaoAlterarPopUp()
        {
            _page.ClicarBotaoAlterarPopUp();
        }

        [Step("Clicar no botão Salvar Pop Up")]
        public void ClicarNoBotaoSalvarPopUp()
        {
            _page.ClicarBotaoSalvarPopUp();
        }

        [Step("Clicar no botão Gravar Pop Up")]
        public void ClicarNoBotaoGravarPopUp()
        {
            _page.ClicarBotaoGravarPopUp();
        }

        [Step("Clicar no botão Fechar Pop Up")]
        public void ClicarNoBotaoFecharPopUp()
        {
            _page.ClicarBotaoFecharPopUp();
        }

        [Step("Clicar no botão Salvar e Fechar Pop Up")]
        public void ClicarNoBotaoSalvarEFecharPopUp()
        {
            _page.ClicarBotaoSalvarEFecharPopUp();
        }

        [Step("Clicar no botão Salvar")]
        public void ClicarBotaoSalvar()
        {
            _page.ClicarBotaoSalvar();
        }

        [Step("Clicar no botão Salvar e Sair")]
        public void ClicarBotaoSalvareSair()
        {
            _page.ClicarBotaoSalvareSair();
        }

        [Step("Clicar no botão Salvar e Continuar")]
        public void ClicarBotaoSalvareContinuar()
        {
            _page.ClicarBotaoSalvareContinuar();
        }

        [Step("Clicar no botão Voltar")]
        public void ClicarBotaoVoltar()
        {
            _page.ClicarBotaoVoltar();
        }

        [Step("Clicar no botão Fechar")]
        public void ClicarBotaoFechar()
        {
            _page.ClicarBotaoFechar();
        }

        [Step("Clicar no botão Excluir")]
        public void ClicarBotaoExcluir()
        {
            _page.ClicarBotaoExcluir();
        }

        [Step("Clicar no botão Imprimir")]
        public void ClicarBotaoImprimir()
        {
            _page.ClicarBotaoImprimir();
        }

        [Step("Clicar no botão Alterar")]
        public void ClicarBotaoAlterar()
        {
            _page.ClicarBotaoAlterar();
        }

        [Step("Clicar no botão Criar")]
        public void ClicarBotaoCriar()
        {
            _page.ClicarBotaoCriar();
        }

        [Step("Clicar no botão Mover")]
        public void ClicarBotaoMover()
        {
            _page.ClicarBotaoMover();
        }

        [Step("Clicar no botão Mover Todos")]
        public void ClicarBotaoMoverTodos()
        {
            _page.ClicarBotaoMoverTodos();
        }

        [Step("Clicar no botão Remover")]
        public void ClicarBotaoRemover()
        {
            _page.ClicarBotaoRemover();
        }

        [Step("Clicar no botão Remover Todos")]
        public void ClicarBotaoRemoverTodos()
        {
            _page.ClicarBotaoRemoverTodos();
        }

        [Step("Clicar no botão Enviar")]
        public void ClicarBotaoEnviar()
        {
            _page.ClicarBotaoEnviar();
        }


        [Step("Clicar no botão Confirmar")]
        public void ClicarBotaoConfirmar()
        {
            _page.ClicarBotaoConfirmar();
        }


        [Step("Clicar no botão Buscar")]
        public void ClicarBotaoBuscar()
        {
            _page.ClicarBotaoBuscar();
        }
    }
}
