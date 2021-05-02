
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaProdutoEstadiaPrePago17948;

namespace Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaProdutoEstadiaPrePago17948
{
    public class SsCriarContratoDeEstadiaProdutoEstadiaPrePago17948PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar contrato de estadia Produto estadia 'Pré-pago' <tabela> [17948]")]
        public void SsCriarContratoDeEstadiaProdutoEstadiaPrePago17948(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlContratosDeEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaContratosDeEstadiaPageStep17365(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageBotoes.ClicarBotaoSalvareContinuar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }      
    }
}