
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17859;

namespace Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17859
{
    public class SsCriarContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17859PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar contrato de estadia Produto estadia 'Quantidade de dias' <tabela> [17859]")]
        public void SsCriarContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17859(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlContratosDeEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaContratosDeEstadiaPageStep17885(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageBotoes.ClicarBotaoSalvareContinuar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }      
    }
}