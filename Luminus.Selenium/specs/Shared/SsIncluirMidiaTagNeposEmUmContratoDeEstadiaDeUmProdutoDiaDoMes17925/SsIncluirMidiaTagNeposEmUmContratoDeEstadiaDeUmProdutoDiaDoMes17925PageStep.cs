
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaTagNeposEmUmContratoDeEstadiaDeUmProdutoDiaDoMes17925;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaTagNeposEmUmContratoDeEstadiaDeUmProdutoDiaDoMes17925
{
    public class SsIncluirMidiaTagNeposEmUmContratoDeEstadiaDeUmProdutoDiaDoMes17925PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("SS - incluir mídia Tag Nepos em um contrato de estadia de um produto 'Dia do mês' <tabela> [17925]")]
        public void SsIncluirMidiaTagNeposEmUmContratoDeEstadiaDeUmProdutoDiaDoMes17925(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17925(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
        }
    }
}