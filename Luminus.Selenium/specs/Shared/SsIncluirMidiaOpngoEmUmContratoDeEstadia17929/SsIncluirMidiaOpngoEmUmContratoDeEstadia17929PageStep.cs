
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaOpngoEmUmContratoDeEstadia17929;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaOpngoEmUmContratoDeEstadia17929
{
    public class SsIncluirMidiaOpngoEmUmContratoDeEstadia17929PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("SS - Incluir mídia OpnGo em um contrato de estadia <tabela> [17929]")]
        public void SsIncluirMidiaOpngoEmUmContratoDeEstadia17929(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17929(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
        }     
    }
}