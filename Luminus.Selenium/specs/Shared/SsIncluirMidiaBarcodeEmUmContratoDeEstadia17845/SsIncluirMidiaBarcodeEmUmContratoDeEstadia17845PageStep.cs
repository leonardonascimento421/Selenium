
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaBarcodeEmUmContratoDeEstadia17845;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaBarcodeEmUmContratoDeEstadia17845
{
    public class SsIncluirMidiaBarcodeEmUmContratoDeEstadia17845PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("SS - Incluir mídia Barcode em um contrato de estadia <tabela> [17845]")]
        public void SsIncluirMidiaBarcodeEmUmContratoDeEstadia17845(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17845(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
        }      
    }
}