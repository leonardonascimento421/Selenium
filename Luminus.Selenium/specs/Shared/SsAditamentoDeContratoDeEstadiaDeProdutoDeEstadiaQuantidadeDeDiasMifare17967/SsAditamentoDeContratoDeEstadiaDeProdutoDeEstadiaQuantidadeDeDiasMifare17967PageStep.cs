
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadiaQuantidadeDeDiasMifare17967;

namespace Luminus.Selenium.specs.Shared.SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadiaQuantidadeDeDiasMifare17967
{
    public class SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadiaQuantidadeDeDiasMifare17967PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("SS - Aditamento de contrato de estadia de Produto de estadia 'Quantidade de dias (Mifare) <tabela> [17967]")]
        public void SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadiaQuantidadeDeDiasMifare17967(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoAditamentoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpAditamentoContratosDeEstadiaPageStep17387(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
        }
    }
}