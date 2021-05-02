
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarProdutoDeEstadiaPrePago16395;

namespace Luminus.Selenium.specs.Shared.SsCriarProdutoDeEstadiaPrePago16395
{
    public class SsCriarProdutoDeEstadiaPrePago16395PageStep
    {
        private ProdutoDeEstadiaPageStep _page = new ProdutoDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar Produto de estadia - Pré-pago <tabela> [16395]")]
        public void SsCriarProdutoDeEstadiaPrePago16395(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlProdutoEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16395(tabela);
            _page.ClicarNoBotaoAdicionarNaSecaoConfiguracaoPorBolsaoProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16395(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _page.ClicarNoBotaoAdicionarNaSecaoRegrasDeRecargaProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpRegraDeRecargaProdutoDeEstadiaPageStep16395(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _page.PreencherOsCamposDaTelaNaSecaoConfiguracaoPorBolsaoDeVagas16395(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();           
        }      
    }
}