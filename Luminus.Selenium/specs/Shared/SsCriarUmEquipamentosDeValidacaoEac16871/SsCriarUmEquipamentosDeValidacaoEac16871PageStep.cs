
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentosDeValidacaoEac16871;

namespace Luminus.Selenium.specs.Shared.SsCriarUmEquipamentosDeValidacaoEac16871
{
    public class SsCriarUmEquipamentosDeValidacaoEac16871PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
    
        [Step("SS - Criar um Equipamentos de validação (EAC) <tabela> [16871]")]
        public void SsCriarUmEquipamentosDeValidacaoEac16871(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlEquipamentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep16603(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16603(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeImpressorEquipamentosPageStep16603(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentosPageStep16603(tabela); 
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeTarjaMagneticaEquipamentosPageStep16603(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            _page.PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16603(tabela);
            new BotoesCRUDSpec().ClicarBotaoSalvar();
            new MensagemSpec().VerificarMensagemCriacaoComSucesso();



        }     

    }
}