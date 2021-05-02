
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsAdicionarPerifericoLprOcrEmUmEquipamentoEae17861;

namespace Luminus.Selenium.specs.Shared.SsAdicionarPerifericoLprOcrEmUmEquipamentoEae17861
{
    public class SsAdicionarPerifericoLprOcrEmUmEquipamentoEae17861PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
    
        [Step("SS - Adicionar periférico LPR/OCR em um equipamento EAE <tabela> [17861]")]
        public void SsAdicionarPerifericoLprOcrEmUmEquipamentoEae17861(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherOsCamposDoPopUpDePerifericoLPREquipamentosPageStep17847(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarBotaoSalvar();
            new MensagemSpec().VerificarMensagemAlteracaoComSucesso();
        }      
    }
}