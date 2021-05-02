
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMe9;

namespace Luminus.Selenium.specs.Shared.SsCriarProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMe9
{
    public class SsCriarProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMe9PageStep
    {
        private ProdutoDeEstadiaPageStep _page = new ProdutoDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar produto estadia do tipo credenciado com tipo de revalidação dia do mês step by step <tabela> [16289]")]
        public void SsCriarProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMesStepByStep16289(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlProdutoEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16289(tabela);
            _page.ClicarNoBotaoAdicionarNaSecaoConfiguracaoPorBolsaoProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16289(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _page.ClicarNoBotaoAdicionarNaSecaoRegrasDeRevalidacaoProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDaTelaRevalidacaoProdutoDeEstadiaPageStep16289(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();          
        }      
    }
}