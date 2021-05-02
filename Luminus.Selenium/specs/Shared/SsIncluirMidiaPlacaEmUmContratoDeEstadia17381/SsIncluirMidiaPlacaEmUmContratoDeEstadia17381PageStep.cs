
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaPlacaEmUmContratoDeEstadia17381;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaPlacaEmUmContratoDeEstadia17381
{
    public class SsIncluirMidiaPlacaEmUmContratoDeEstadia17381PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Incluir mídia Placa em um contrato de estadia <tabela> [17381]")]
        public void SsIncluirMidiaPlacaEmUmContratoDeEstadia17381(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17381(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
        }
    }
}