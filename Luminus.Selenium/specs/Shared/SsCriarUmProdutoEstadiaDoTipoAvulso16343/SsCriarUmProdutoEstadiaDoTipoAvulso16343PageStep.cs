
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarUmProdutoEstadiaDoTipoAvulso16343;

namespace Luminus.Selenium.specs.Shared.SsCriarUmProdutoEstadiaDoTipoAvulso16343
{
    public class SsCriarUmProdutoEstadiaDoTipoAvulso16343PageStep
    {
        private ProdutoDeEstadiaPageStep _page = new ProdutoDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar um produto estadia do tipo avulso <tabela> [16343]")]
        public void SsCriarUmProdutoEstadiaDoTipoAvulso16343(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlProdutoEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.NaSecaoInformacoesGeraisPreencherOCampoNomeComOValorProdutoDeEstadiaPageStep15924(tabela);
            _page.NaSecaoInformacoesGeraisOCampoTipoDeUsuarioDeveEstarSelecionadoComOValorProdutoDeEstadiaPageStep15924(tabela);
            _page.ClicarNoBotaoAdicionarNaSecaoConfiguracaoPorBolsaoProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDaTelaProdutoDeEstadiaPageStep15924(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
            
        }     
    }
}