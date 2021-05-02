
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaConnectcarEmUmContratoDeEstadia17920;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaConnectcarEmUmContratoDeEstadia17920
{
    public class SsIncluirMidiaConnectcarEmUmContratoDeEstadia17920PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagem = new MensagemSpec();
    
        [Step("SS - Incluir mídia ConnectCar em um contrato de estadia <tabela> [17920]")]
        public void SsIncluirMidiaConnectcarEmUmContratoDeEstadia17920(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDaTelaIncluirmidiaconnectcaremumcontratodeestadiastepbysteppagestep17920(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
        }      
    }
}