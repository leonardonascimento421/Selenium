
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarProdutoEstadiaDiarista16341;

namespace Luminus.Selenium.specs.Shared.SsCriarProdutoEstadiaDiarista16341
{
    public class SsCriarProdutoEstadiaDiarista16341PageStep
    {
        private ProdutoDeEstadiaPageStep _page = new ProdutoDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar Produto estadia diarista <tabela> [16341]")]
        public void SsCriarProdutoEstadiaDiarista16341(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlProdutoEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16341(tabela);
            _page.ClicarNoBotaoAdicionarNaSecaoConfiguracaoPorBolsaoProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16341(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _page.PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16243(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }      
    }
}