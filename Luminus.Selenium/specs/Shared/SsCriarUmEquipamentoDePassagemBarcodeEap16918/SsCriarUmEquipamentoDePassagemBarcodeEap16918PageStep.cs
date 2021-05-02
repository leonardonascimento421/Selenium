
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoDePassagemBarcodeEap16918;

namespace Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoDePassagemBarcodeEap16918
{
    public class SsCriarUmEquipamentoDePassagemBarcodeEap16918PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
    
        [Step("SS - Criar um equipamento de passagem barcode (EAP) <tabela> [16918]")]
        public void SsCriarUmEquipamentoDePassagemBarcodeEap16918(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlEquipamentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep16918(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentosPageStep16918(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorTagEquipamentosPageStep16918(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            _page.PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16918(tabela);
            new BotoesCRUDSpec().ClicarBotaoSalvar();
            new MensagemSpec().VerificarMensagemCriacaoComSucesso();


        }      

    }
}