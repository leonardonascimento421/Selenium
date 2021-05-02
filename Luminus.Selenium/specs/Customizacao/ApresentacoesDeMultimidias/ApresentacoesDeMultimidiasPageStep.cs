using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsCriarUmaMultimidiaAudio26414;
using Luminus.Selenium.specs.Shared.SsCriarUmaMultimidiaImagem26419;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.Customizacao.ApresentacoesDeMultimidias
{
    public class ApresentacoesDeMultimidiasPageStep
    {
        private ApresentacoesDeMultimidiasPage _page = new ApresentacoesDeMultimidiasPage();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private ListagemPage _pageListagem = new ListagemPage();

        [Step("Carregar dependências Apresentações de multimídias <tabela>")]
        public void CarregarDependenciasEquipamentos(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecution(() =>
            {
                // steps de dependências
                new SsCriarUmaMultimidiaAudio26414PageStep().SsCriarUmaMultimidiaAudio26414(tabela);
                new SsCriarUmaMultimidiaImagem26419PageStep().SsCriarUmaMultimidiaImagem26419(tabela);
            });
        }

        [Step("Preencher os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26422]")]
        public void PreencherOsCamposDaTelaApresentacoesdemultimidiasaudiopagestep26422(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeApresentacao"));
            _pageBotoesCRUD.ClicarBotaoAdicionar();
            _page.SelecionarMultimidia(row.GetCell("multimidiaAudio"));
            _page.SelecionarGatilho(row.GetCell("gatilho"));
            _pageBotoesCRUD.ClicarBotaoAdicionarPopUp();
        }


        [Step("Preencher os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26556]")]
        public void PreencherOsCamposDaTelaApresentacoesdemultimidiasimagempagestep26556(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeApresentacao"));
            _pageBotoesCRUD.ClicarBotaoAdicionar();
            _page.SelecionarMultimidia(row.GetCell("multimidiaImagem"));
            _page.SelecionarTempoExibicaoImagem(row.GetCell("tempoExibicao"));
            _page.SelecionarPosicaoVerticalMensagem(row.GetCell("posicaoVerticalMensagem"));
            _page.SelecionarPosicaoHorizontalMensagem(row.GetCell("posicaoHorizontalMensagem"));
            _page.SelecionarCorFonteMensagem(row.GetCell("corFonteMensagem"));
            _page.SelecionarCorFundoMensagem(row.GetCell("corFundoMensagem"));
            _pageBotoesCRUD.ClicarBotaoAdicionarPopUp();
        }


        [Step("Verificar os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26410]")]
        public void VerificarOsCamposDaTelaApresentacaoMultimidiaAudiopagestep26410(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeApresentacao"));
                var grid = _page.RetornarTabelaMultimidia();
                _page.RetornarNomeMultimidia(grid, 1).Should().Be(row.GetCell("multimidiaAudio"));
                _page.RetornarGatilho(grid, 1).Should().Be(row.GetCell("gatilho"));
            }
        }


        [Step("Verificar os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26560]")]
        public void VerificarOsCamposDaTelaApresentacaoMultimidiaImagempagestep26560(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeApresentacao"));
                var grid = _page.RetornarTabelaMultimidia();
                _page.RetornarTempoExibicaoImagem(grid, 1).Should().Be(row.GetCell("tempoExibicao"));
                _page.RetornarPosicaoVerticalMensagem(grid, 1).Should().Be(row.GetCell("posicaoVerticalMensagem"));
                _page.RetornarPosicaoHorizontalMensagem(grid, 1).Should().Be(row.GetCell("posicaoHorizontalMensagem"));
            }
        }


        [Step("Preencher o campo do nome da apresentação <tabela> [ApresentacoesDeMultimidiasPageStep] [26413]")]
        public void PreencherOCampoNomeDaApresentacaoMultimidiapagestep26413(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeApresentacao"));
        }


        [Step("Alterar o nome da apresentação multimídia <tabela> [ApresentacoesDeMultimidiasPageStep] [26411]")]
        public void AlterarONomeApresentacaoMultimidiaAudiopagestep26411(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeApresentacaoAlterado"));
        }


        [Step("Alterar os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26411]")]
        public void AlterarOsCamposDaTelaApresentacaoMultimidiaAudiopagestep26411(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarMultimidia(row.GetCell("multimidiaAlterado"));
            _page.SelecionarGatilho(row.GetCell("gatilhoAlterado"));
            _pageBotoesCRUD.ClicarBotaoAlterarPopUp();
            _pageBotoesCRUD.ClicarBotaoSalvar();
        }


        [Step("Verificar os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26411]")]
        public void VerificarOsCamposDaTelaApresentacaoMultimidiaAudiopagestep26411(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeApresentacaoAlterado"));
                var grid = _page.RetornarTabelaMultimidia();
                _page.RetornarNomeMultimidia(grid, 1).Should().Be(row.GetCell("multimidiaAlterado"));
                _page.RetornarGatilho(grid, 1).Should().Be(row.GetCell("gatilhoAlterado"));
            }
        }


        [Step("Alterar o nome da apresentação multimídia <tabela> [ApresentacoesDeMultimidiasPageStep] [26723]")]
        public void AlterarONomeApresentacaoMultimidiaImagempagestep26723(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeApresentacaoAlterado"));
        }


        [Step("Alterar os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26723]")]
        public void AlterarOsCamposDaTelaApresentacaoMultimidiaImagempagestep26723(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarMultimidia(row.GetCell("multimidiaAlterado"));
            _page.SelecionarTempoExibicaoImagem(row.GetCell("tempoExibicaoAlterado"));
            _page.SelecionarPosicaoVerticalMensagem(row.GetCell("posicaoVerticalMensagemAlterado"));
            _page.SelecionarPosicaoHorizontalMensagem(row.GetCell("posicaoHorizontalMensagemAlterado"));
            _page.SelecionarCorFonteMensagem(row.GetCell("corFonteMensagemAlterado"));
            _page.SelecionarCorFundoMensagem(row.GetCell("corFundoMensagemAlterado"));
            _pageBotoesCRUD.ClicarBotaoAlterarPopUp();
            _pageBotoesCRUD.ClicarBotaoSalvar();
        }


        [Step("Verificar os campos da tela <tabela> [ApresentacoesDeMultimidiasPageStep] [26723]")]
        public void VerificarOsCamposDaTelaApresentacaoMultimidiaImagempagestep26723(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeApresentacaoAlterado"));
                var grid = _page.RetornarTabelaMultimidia();
                _page.RetornarTempoExibicaoImagem(grid, 1).Should().Be(row.GetCell("tempoExibicaoAlterado"));
                _page.RetornarPosicaoVerticalMensagem(grid, 1).Should().Be(row.GetCell("posicaoVerticalMensagemAlterado"));
                _page.RetornarPosicaoHorizontalMensagem(grid, 1).Should().Be(row.GetCell("posicaoHorizontalMensagemAlterado"));
            }
        }
    }
}