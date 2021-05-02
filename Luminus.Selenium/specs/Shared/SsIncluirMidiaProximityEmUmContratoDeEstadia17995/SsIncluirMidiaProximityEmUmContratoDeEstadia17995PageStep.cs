
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaProximityEmUmContratoDeEstadia17995;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaProximityEmUmContratoDeEstadia17995
{
    public class SsIncluirMidiaProximityEmUmContratoDeEstadia17995PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("SS - Incluir mídia Proximity em um contrato de estadia <tabela> [17995]")]
        public void SsIncluirMidiaProximityEmUmContratoDeEstadia17995(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17995(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();


        }      

    }
}