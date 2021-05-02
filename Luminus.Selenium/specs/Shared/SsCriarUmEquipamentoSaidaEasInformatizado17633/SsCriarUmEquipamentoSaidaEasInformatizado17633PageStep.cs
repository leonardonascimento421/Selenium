
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoSaidaEasInformatizado17633;

namespace Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoSaidaEasInformatizado17633
{
    public class SsCriarUmEquipamentoSaidaEasInformatizado17633PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
    
        [Step("SS - Criar um equipamento saída EAS (informatizado) <tabela> [17633]")]
        public void SsCriarUmEquipamentoSaidaEasInformatizado17633(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlEquipamentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep17633(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeImpressorEquipamentosPageStep17633(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarBotaoSalvar();
            new MensagemSpec().VerificarMensagemCriacaoComSucesso();
        }      

    }
}