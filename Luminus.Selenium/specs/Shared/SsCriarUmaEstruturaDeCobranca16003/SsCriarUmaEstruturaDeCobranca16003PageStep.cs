
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutoDeEstadia.EstruturaDeTabelaDeCobranca;
using Luminus.Selenium.specs.ProdutosDeEstadia.EstruturasDeTabelasDeCobranca;
using Luminus.Selenium.specs.Shared.SsCriarUmaEstruturaDeCobranca16003;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.Shared.SsCriarUmaEstruturaDeCobranca16003
{
    public class SsCriarUmaEstruturaDeCobranca16003PageStep
    {
        private EstruturasDeTabelasDeCobrancaPageStep _page = new EstruturasDeTabelasDeCobrancaPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Criar uma Estrutura de cobrança <tabela> [16003]")]
        public void SsCriarUmaEstruturaDeCobranca16003(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecutionForKey(tabela.GetTableRows()[0].GetCell("nomeEstruturaCobranca"), () =>
            {
                var row = tabela.GetTableRows()[0];
                _pageNavegacao.NavegarParaUrl("UrlEstruturaTabelaCobrancaPage");
                _pageBotoesCRUD.ClicarBotaoCriar();
                _page.PreencherOCampoNomeComOValor16003(tabela);
                _page.ClicarBotaoAdicionarEstrutura();
                _page.PreencherOsCamposDaSecaoEstrutura16003(tabela);
                _page.ClicarBotaoAdicionarFracao(1);
                _page.PreencherOsCamposDoPopUpFração1EstruturasDeTabelasDeCobrancaPageStep16003(tabela);
                _pageBotoesCRUD.ClicarBotaoSalvarPopUp();
                _page.PreencherOsCamposDaSecaoPeriodo1EstruturasDeTabelasDeCobrancaPageStep16003(tabela);
                _page.ClicarBotaoAdicionarPeriodo(1);
                _page.ClicarBotaoAdicionarFracao(2);
                _page.PreencherOsCamposDoPopUpFração2EstruturasDeTabelasDeCobrancaPageStep16003(tabela);
                _pageBotoesCRUD.ClicarBotaoSalvarPopUp();
                _page.PreencherOsCamposDaSecaoPeriodo2EstruturasDeTabelasDeCobrancaPageStep16003(tabela);
                _pageBotoesCRUD.ClicarBotaoSalvar();
                _pageMensagem.VerificarMensagemCriacaoComSucesso();
            });
        }
    }
}