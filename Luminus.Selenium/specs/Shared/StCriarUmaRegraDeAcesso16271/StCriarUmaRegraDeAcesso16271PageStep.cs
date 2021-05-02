
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeAcesso;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcesso16271;

namespace Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcesso16271
{
    public class StCriarUmaRegraDeAcesso16271PageStep
    {
        private RegrasDeAcessoPageStep _page = new RegrasDeAcessoPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();

        [Step("ST - Criar uma regra de acesso <tabela> [16271]")]
        public void StCriarUmaRegraDeAcesso16271(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlRegraDeAcessoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarumaregradeacessostepbysteppagestep(tabela);
            _pageListagem.ClicarNoMenuDeContextoNaLinhaContendoOValorNaTabela("Domingo");
            _pageListagem.ClicarBotaoAlterar();
            _page.PreencherOsCamposDaTelaCriarumaregradeacessostepbysteppagestep16271(tabela);
            _pageBotoes.ClicarNoBotaoAlterarPopUp();
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();       
        }

    }
}