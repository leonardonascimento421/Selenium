
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaBarcodeEmUmContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17940;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaBarcodeEmUmContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17940
{
    public class SsIncluirMidiaBarcodeEmUmContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17940PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Incluir Mídia Barcode em um contrato de estadia Produto estadia 'Quantidade de dias' <tabela> [17940]")]
        public void SsIncluirMidiaBarcodeEmUmContratoDeEstadiaProdutoEstadiaQuantidadeDeDias17940(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17390(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();
            _pageMensagem.VerificarMensagemAlteracaoComSucesso();


        }     
    }
}