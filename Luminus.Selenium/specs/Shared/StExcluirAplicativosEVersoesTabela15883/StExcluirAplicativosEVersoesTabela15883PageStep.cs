
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.InstalacoesAtualizacoes.AplicativosEVersoes;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.StExcluirAplicativosEVersoesTabela15883;

namespace Luminus.Selenium.specs.Shared.StExcluirAplicativosEVersoesTabela15883
{
    public class StExcluirAplicativosEVersoesTabela15883PageStep
    {
        private AplicativosEVersoesPageStep _page = new AplicativosEVersoesPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private ListagemPageStep _pageListagemPageStep = new ListagemPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("ST - Excluir Aplicativos e versões <tabela> [15883]")]
         public void StExcluirAplicativosEVersoes15883(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlAplicativoVersaoPage");
            _page.ClicarNoValorDaListagemApresentadaNaTela(row.GetCell("listaAplicativoVersao"));
            _pageListagemPageStep.ClicarNoMenuDeContextoNaLinhaContendoOValorNaTabela(row.GetCell("numeroDaVersaoAplicativoVersao"));
            _pageListagemPageStep.ClicarBotaoExcluir();
            _pageBotoesCRUD.ClicarBotaoExcluir();
            _pageMensagem.Verificarmensagem("Exclusão realizada com sucesso.");
        }
    }
}