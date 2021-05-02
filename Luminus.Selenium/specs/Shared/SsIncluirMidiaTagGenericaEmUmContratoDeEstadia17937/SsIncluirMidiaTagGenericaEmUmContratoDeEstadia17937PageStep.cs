
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaTagGenericaEmUmContratoDeEstadia17937;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaTagGenericaEmUmContratoDeEstadia17937
{
    public class SsIncluirMidiaTagGenericaEmUmContratoDeEstadia17937PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("SS - Incluir mídia Tag genérica em um contrato de estadia <tabela> [17937]")]
        public void SsIncluirMidiaTagGenericaEmUmContratoDeEstadia17937(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17937(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();


        }      
    }
}