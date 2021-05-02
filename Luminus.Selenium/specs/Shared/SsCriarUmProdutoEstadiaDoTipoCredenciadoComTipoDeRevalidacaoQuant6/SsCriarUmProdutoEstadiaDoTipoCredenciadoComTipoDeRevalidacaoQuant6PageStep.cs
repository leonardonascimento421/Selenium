
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuant6;

namespace Luminus.Selenium.specs.Shared.SsCriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuant6
{
    public class SsCriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuant6PageStep
    {
        private ProdutoDeEstadiaPageStep _page = new ProdutoDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar um produto estadia do tipo credenciado com tipo de revalidação quantidade de dias <tabela> [16346]")]
        public void SsCriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuantidadeDeDias16346(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlProdutoEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16232(tabela);
            _page.ClicarNoBotaoAdicionarNaSecaoConfiguracaoPorBolsaoProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16232(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _page.ClicarNoBotaoAdicionarNaSecaoRegrasDeRevalidacaoProdutoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16346(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();                       
        }      
    }
}