
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.TabelasDeCobranca;
using Luminus.Selenium.specs.Shared.SsCriarTabelasDeCobranca16091;

namespace Luminus.Selenium.specs.Shared.SsCriarTabelasDeCobranca16091
{
    public class SsCriarTabelasDeCobranca16091PageStep
    {
        private TabelasDeCobrancaPageStep _page = new TabelasDeCobrancaPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Criar tabelas de cobrança <tabela> [16091]")]
        public void SsCriarTabelasDeCobranca16091(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlTabelaDeCobrancaPage");
            _pageBotoesCRUD.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriartabelasdecobrancastepbysteppagestep(tabela);
            _pageBotoesCRUD.ClicarBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpAdicionarTempoDeToleranciaPorPeriodo16091(tabela);
            _pageBotoesCRUD.ClicarBotaoAdicionarPopUp();
            _page.PreencherOsCamposDaSecaoDeEstruturas16091(tabela);
            _pageBotoesCRUD.ClicarBotaoSalvar();
            _pageMensagem.VerificarMensagemCriacaoComSucesso();
        }

    }
}