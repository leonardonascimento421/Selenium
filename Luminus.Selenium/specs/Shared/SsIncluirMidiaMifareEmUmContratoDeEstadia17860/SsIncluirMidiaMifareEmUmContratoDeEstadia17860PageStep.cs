
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaMifareEmUmContratoDeEstadia17860;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaMifareEmUmContratoDeEstadia17860
{
    public class SsIncluirMidiaMifareEmUmContratoDeEstadia17860PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Incluir mídia Mifare em um contrato de estadia <tabela> [17860]")]
        public void SsIncluirMidiaMifareEmUmContratoDeEstadia17860(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17365(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
            _pageListagem.ClicarNoBotaoGravarCartaoNaListagem();
            _page.PreencherOsCamposDoPopUpGravarCartãoContratosDeEstadiaPageStep17365(tabela);
            _pageBotoes.ClicarNoBotaoGravarPopUp();
            _pageBotoes.ClicarNoBotaoFecharPopUp();
        }
    }
}