using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;

namespace Luminus.Selenium.specs.Customizacao.Multimidia
{
    public class MultimidiaPageStep
    {
        private MultimidiaPage _page = new MultimidiaPage();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();

        [Step("Preencher os campos da tela <tabela> [MultimidiaPageStep] [26414]")]
        public void PreencherOsCamposDaTelaCriarumamultimidiaaudiostepbysteppagestep26414(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeAudio"));
            _page.SelecionarMultimidiaAudio(row.GetCell("caminhoArquivoAudio") + row.GetCell("audio"));
        }


        [Step("Preencher os campos da tela <tabela> [MultimidiaPageStep] [26419]")]
        public void PreencherOsCamposDaTelaCriarumamultimidiaimagemtepbysteppagestep26419(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeImagem"));
            _page.SelecionarMultimidiaImagem(row.GetCell("caminhoArquivoImagem") + row.GetCell("imagem"));
        }


        [Step("Verificar os campos da tela <tabela> [MultimidiaPageStep] [26397]")]
        public void VerificarOsCamposDaTelaMultimidiaAudiopagestep26397(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeAudio"));
                var grid = _page.RetornarTabelaArquivoMultimidia();
                _page.RetornarNomeArquivoAudio(grid, 1).Should().Be(row.GetCell("audio"));
                _page.RetornarMimetypeArquivoAudio(grid, 1).Should().Be(row.GetCell("mimeType"));
            }

        }


        [Step("Verificar os campos da tela <tabela> [MultimidiaPageStep] [26399]")]
        public void VerificarOsCamposDaTelaMultimidiaAudioAlteradopagestep26399(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeAudioAlterado"));
                var grid = _page.RetornarTabelaArquivoMultimidia();
                _page.RetornarNomeArquivoAudio(grid, 1).Should().Be(row.GetCell("audioAlterado"));
                _page.RetornarMimetypeArquivoAudio(grid, 1).Should().Be(row.GetCell("mimeType"));
            }

        }


        [Step("Verificar os campos da tela <tabela> [MultimidiaPageStep] [26398]")]
        public void VerificarOsCamposDaTelaMultimidiaImagempagestep26398(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeImagem"));
                var grid = _page.RetornarTabelaArquivoMultimidia();
                _page.RetornarNomeArquivoImagem(grid, 1).Should().Be(row.GetCell("imagem"));
                _page.RetornarMimetypeArquivoImagem(grid, 1).Should().Be(row.GetCell("mimeType"));
            }
        }


        [Step("Verificar os campos da tela <tabela> [MultimidiaPageStep] [26400]")]
        public void VerificarOsCamposDaTelaMultimidiaImagemAlteradapagestep26400(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeImagemAlterada"));
                var grid = _page.RetornarTabelaArquivoMultimidia();
                _page.RetornarNomeArquivoImagem(grid, 1).Should().Be(row.GetCell("imagemAlterada"));
                _page.RetornarMimetypeArquivoImagem(grid, 1).Should().Be(row.GetCell("mimeType"));
            }
        }


        [Step("Alterar os campos da tela <tabela> [MultimidiaPageStep] [26399]")]
        public void AlterarOsCamposDaTelaMultimidiaAudiopagestep26399(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeAudioAlterado"));
            _page.SelecionarMultimidiaAudio(row.GetCell("caminhoArquivoAudio") + row.GetCell("audioAlterado"));
            _pageBotoesCRUD.ClicarBotaoSalvar();
        }


        [Step("Alterar os campos da tela <tabela> [MultimidiaPageStep] [26400]")]
        public void AlterarOsCamposDaTelaMultimidiaImagempagestep26400(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeImagemAlterada"));
            _page.SelecionarMultimidiaAudio(row.GetCell("caminhoArquivoImagem") + row.GetCell("imagemAlterada"));
            _pageBotoesCRUD.ClicarBotaoSalvar();
        }


        //[Step("Na seção Alterar configuração de multimídia, alterar o campo Nome com o valor <nomeAudioAlterado> [MultimidiaPageStep]")]
        //public void NaSecaoAlterarConfiguracaoDeMultimidiaAlterarOCampoNomeComOValorMultimidiapagestep(string nomeAudioAlterado)
        //{
        //    _page.NomeAudioAlterado(nomeAudioAlterado);
        //}

        //[Step("Na seção Selecionar multimídia clicar no botão Escolher arquivo para selecionar um áudio [MultimidiaPageStep]")]
        //public void NaSecaoSelecionarMultimidiaClicarNoBotaoEscolherArquivoParaSelecionarUmAudioMultimidiapagestep()
        //{

        //}

        //[Step("No Explorador de Arquivos inserir o caminho <caminhoArquivo> e pressionar o botão 'Abrir' [MultimidiaPageStep]")]
        //public void NoExploradorDeArquivosInserirOCaminhoEPressionarOBotaoAbrirMultimidiapagestep(string caminhoArquivo)
        //{

        //}

        //[Step("Selecionar o arquivo da pasta com valor <audioAlterado> e clicar no botão Abrir [MultimidiaPageStep]")]
        //public void SelecionarOArquivoDaPastaComValorEClicarNoBotaoAbrirMultimidiapagestep(string audioAlterado)
        //{
        //    _page.SelecionarAudioAlterado(audioAlterado);
        //}

        //[Step("Verificar os campos da tela <tabela> [MultimidiaPageStep] [26399]")]
        //public void VerificarOsCamposDaTelaMultimidiapagestep26399(Table tabela)
        //{
        //    var row = tabela.GetTableRows()[0];
        //    using (new AssertionScope())
        //    {
        //       _page.RetornarNomeAudioAlterado().Should().Be(row.GetCell("nomeAudioAlterado"));
        //       _page.RetornarAudioAlterado().Should().Be(row.GetCell("audioAlterado"));
        //       _page.RetornarMimeType().Should().Be(row.GetCell("mimeType"));
        //    }

        //}

        //[Step("Na seção Alterar configuração de multimídia, alterar o campo Nome com o valor <nomeImagemAlterada> [MultimidiaPageStep]")]
        //public void NaSecaoAlterarConfiguracaoDeMultimidiaAlterarOCampoNomeComOValorMultimidiapagestep(string nomeImagemAlterada)
        //{
        //    _page.NomeImagemAlterada(nomeImagemAlterada);
        //}

        //[Step("Na seção Selecionar multimídia clicar no botão Escolher arquivo para selecionar uma imagem [MultimidiaPageStep]")]
        //public void NaSecaoSelecionarMultimidiaClicarNoBotaoEscolherArquivoParaSelecionarUmaImagemMultimidiapagestep()
        //{

        //}

        //[Step("Selecionar o arquivo da pasta com valor <imagemAlterada> e clicar no botão Abrir [MultimidiaPageStep]")]
        //public void SelecionarOArquivoDaPastaComValorEClicarNoBotaoAbrirMultimidiapagestep(string imagemAlterada)
        //{
        //    _page.SelecionarImagemAlterada(imagemAlterada);
        //}

        //[Step("Verificar os campos da tela <tabela> [MultimidiaPageStep] [26400]")]
        //public void VerificarOsCamposDaTelaMultimidiapagestep26400(Table tabela)
        //{
        //    var row = tabela.GetTableRows()[0];
        //    using (new AssertionScope())
        //    {
        //       _page.RetornarNomeImagemAlterada().Should().Be(row.GetCell("nomeImagemAlterada"));
        //       _page.RetornarImagemAlterada().Should().Be(row.GetCell("imagemAlterada"));
        //       _page.RetornarMimeType().Should().Be(row.GetCell("mimeType"));
        //    }

        //}


    }
}