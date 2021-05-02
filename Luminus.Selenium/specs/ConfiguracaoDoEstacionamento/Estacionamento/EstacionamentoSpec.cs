
using System;
using System.Threading;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Estacionamento;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Estacionamento
{
    public class EstacionamentoSpec : BasePage
    {
        private EstacionamentoPage _page = new EstacionamentoPage();
        private BotoesCRUDPage _pageButton = new BotoesCRUDPage();
        private ListagemPage _pageListagem = new ListagemPage();

        #region ## Alterar um estacionamento [16590]
           
        [Step("Alterar o campo 'Nome' para o valor <nomeEstacionamentoalterado>")]
        public void AlterarOCampoNomeParaOValor(Table nomeEstacionamentoalterado)
        {
            var row = nomeEstacionamentoalterado.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeEstacionamentoalterado"));

        }

        [Step("Alterar o campo 'Cor' para o valor <coralterado>")]
        public void AlterarOCampoCorParaOValor(Table coralterado)
        {
            var row = coralterado.GetTableRows()[0];
            _page.PreencherCor(row.GetCell("coralterado"));
        }

        [Step("Clicar no botão Escolher arquivo da tela de Estacionamento <CaminhoImagem>")]
        public void ClicarNoBotaoEscolherArquivo(Table imagem)
        {
            var row = imagem.GetTableRows()[0];
            _page.EscolherArquivo(row.GetCell("caminhoImagem") + row.GetCell("imagem"));
        }


        [Step("Verificar os campos da tela Estacionamento <tabela>")]
        public void VerificarOsCamposDaTelaEstacionamentoAlterar16590(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarNome().Should().Be(row.GetCell("nomeEstacionamentoalterado"));
               _page.RetornartipoMidiaOperacaoEstacionamento().Should().Be(row.GetCell("tipoMidiaOperacaoEstacionamento"));
               _page.RetornarCor().Should().Be(row.GetCell("coralterado"));             
               _page.RetornarLote().Should().Be(row.GetCell("lote"));
               _page.RetornarSublote().Should().Be(row.GetCell("sublote"));
            }
        
        }

        #endregion ## Alterar um estacionamento [16590]

        #region ## Acessar os parâmetros gerais a partir da tela [16593]
               
        #endregion ## Acessar os parâmetros gerais a partir da tela [16593]
    }
}