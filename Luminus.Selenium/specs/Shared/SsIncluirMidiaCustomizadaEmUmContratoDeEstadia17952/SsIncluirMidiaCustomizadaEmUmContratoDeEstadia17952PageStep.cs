
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaCustomizadaEmUmContratoDeEstadia17952;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaCustomizadaEmUmContratoDeEstadia17952
{
    public class SsIncluirMidiaCustomizadaEmUmContratoDeEstadia17952PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Incluir mídia customizada em um contrato de estadia <tabela> [17952]")]
        public void SsIncluirMidiaCustomizadaEmUmContratoDeEstadia17952(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17952(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
        }       
    }
}