
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Financeiro.RegrasDeNumerarioDeAutoatendimento;
using Luminus.Selenium.specs.Shared.StCriarUmaRegrasDeNumerario16943;

namespace Luminus.Selenium.specs.Shared.StCriarUmaRegrasDeNumerario16943
{
    public class StCriarUmaRegrasDeNumerario16943PageStep
    {
        private RegrasDeNumerarioDeAutoatendimentoPageStep _page = new RegrasDeNumerarioDeAutoatendimentoPageStep();
    
        [Step("ST - Criar uma regras de numerario <tabela> [16943]")]
        public void StCriarUmaRegrasDeNumerario16943(Table tabela)
        {
             var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlRegrasDeNumerarioDeAutoAtendimentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaRegrasDeNumerarioDeAutoatendimentoPageStep16943(tabela);
            _page.ClicarBotaoAdicionarCedulas();
            _page.PreencherOsCamposDaTelaPopUpCedulasRegrasdenumerariodeautoatendimentopagestep(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoSalvarPopUp();
            _page.ClicarBotaoAdicionarMoedas();
            _page.PreencherOsCamposDaTelaPopUpMoedasRegrasdenumerariodeautoatendimentopagestep(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoSalvarPopUp();
            new BotoesCRUDSpec().ClicarBotaoSalvar();
        }       
        
    }
}