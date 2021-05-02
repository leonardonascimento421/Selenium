
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaPrePago17963;

namespace Luminus.Selenium.specs.Shared.SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaPrePago17963
{
    public class SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaPrePago17963PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Realizar aditamento em um contrato de estadia de produto estadia 'Pré pago' <tabela> [17963]")]
        public void SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaPrePago17963(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoAditamentoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopupDeAditamentoContratosDeEstadiaPageStep17963(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
        }      

    }
}