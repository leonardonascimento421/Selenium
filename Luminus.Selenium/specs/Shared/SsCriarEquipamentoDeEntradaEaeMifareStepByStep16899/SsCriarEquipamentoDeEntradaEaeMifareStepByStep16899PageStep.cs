
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarEquipamentoDeEntradaEaeMifareStepByStep16899;

namespace Luminus.Selenium.specs.Shared.SsCriarEquipamentoDeEntradaEaeMifareStepByStep16899
{
    public class SsCriarEquipamentoDeEntradaEaeMifareStepByStep16899PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
    
        [Step("SS - Criar equipamento de entrada (EAE) Mifare step by step <tabela> [16899]")]
        public void SsCriarEquipamentoDeEntradaEaeMifareStepByStep16899(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlEquipamentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep16899(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16899(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16899(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeTelaVgaEquipamentosPageStep16899(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            _page.PreencherOsCamposDaTelaNaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16899(tabela);
            new BotoesCRUDSpec().ClicarBotaoSalvar();
            new MensagemSpec().VerificarMensagemCriacaoComSucesso();
        }      

    }
}