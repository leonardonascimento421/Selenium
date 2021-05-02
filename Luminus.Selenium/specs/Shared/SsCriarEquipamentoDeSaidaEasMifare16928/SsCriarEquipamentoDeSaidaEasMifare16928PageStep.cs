
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarEquipamentoDeSaidaEasMifare16928;

namespace Luminus.Selenium.specs.Shared.SsCriarEquipamentoDeSaidaEasMifare16928
{
    public class SsCriarEquipamentoDeSaidaEasMifare16928PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
    
        [Step("SS - Criar equipamento de Saída (EAS) Mifare <tabela> [16928]")]
        public void SsCriarEquipamentoDeSaidaEasMifare16928(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlEquipamentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep16599(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16599(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16599(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCampoDoPopupDePerifericoDePlacaDeSomEquipamentosPageStep16599(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            _page.PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16599(tabela);
            new BotoesCRUDSpec().ClicarBotaoSalvar();
            new MensagemSpec().VerificarMensagemCriacaoComSucesso();


        }       

    }
}