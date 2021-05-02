
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeCobranca;

namespace Luminus.Selenium.specs.Shared.SsCriarRegrasDeCobranca16135
{
    public class SsCriarRegrasDeCobranca16135PageStep
    {
        private RegrasDeCobrancaPageStep _page = new RegrasDeCobrancaPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Criar regras de cobrança <tabela> [16135]")]
        public void SsCriarRegrasDeCobranca16135(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlRegraDeCobrancaPage");
            _pageBotoesCRUD.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaRegrasdecobrancapagestep(tabela);
            _pageBotoesCRUD.ClicarBotaoSalvar();
            _pageMensagem.VerificarMensagemCriacaoComSucesso();
        }
    }
}