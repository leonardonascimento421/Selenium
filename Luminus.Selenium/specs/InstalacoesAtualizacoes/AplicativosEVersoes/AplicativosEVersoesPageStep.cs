
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.InstalacoesAtualizacoes.AplicativosEVersoes;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.InstalacoesAtualizacoes.AplicativosEVersoes
{
    public class AplicativosEVersoesPageStep
    {
        private AplicativosEVersoesPage _page = new AplicativosEVersoesPage();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();                 

        [Step("Clicar no botão carregar arquivo")]
        public void ClicarNoBotaoCarregarArquivo()
        {
            _page.ClicarBotaoCarregarArquivo();
        }

        [Step("Clicar no botão carregar")]
        public void ClicarNoBotaoCarregar()
        {
            TimeSpan timeout = default(TimeSpan);
            if (TestContextHelper.IsScenario(16227, 16226, 15883, 15882, 15881, 15880))
                timeout = TimeSpan.FromMinutes(5);

            _page.ClicarBotaoCarregar(timeout);
        }

        [Step("Clicar no botão Escolher arquivo")]
        public void ClicarNoBotaoEscolherArquivo(Table tabela)
        {            
            var row = tabela.GetTableRows()[0];
            _page.EscolherArquivo(row.GetCell("caminhoArquivo") + row.GetCell("aplicativoVersao"));
        }        

        [Step("Clicar no valor <listaAplicativoVersao> da listagem apresentada na tela")]
        public void ClicarNoValorDaListagemApresentadaNaTela(string listaAplicativoVersao)
        {
            _page.ClicarNoValorDaListagemApresentadaNaTela(listaAplicativoVersao);
        } 

        [Step("Verificar os campos da tela Detalhar aplicativo EAC -Step by Step <tabela>")]
        public void VerificarOsCamposDaTelaDetalharAplicativoEacStepByStep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.Retornarsigla().Should().Be(row.GetCell("sigla"));
                _page.RetornarnomeAplicativoVersao().Should().Be(row.GetCell("nomeAplicativoVersao"));
                _page.RetornardescricaoAplicativo().Should().Be(row.GetCell("descricaoAplicativo"));
                _page.RetornarnumeroDaVersao().Should().Be(row.GetCell("numeroDaVersao"));
                _page.RetornarsistemaOperacional().Should().Be(row.GetCell("sistemaOperacional"));
                _page.RetornaraplicativoVersao().Should().Be(row.GetCell("aplicativoVersao"));
                _page.RetornardescricaoVersao().Should().Be(row.GetCell("descricaoVersao"));
            }
        }
    }
}