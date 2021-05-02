
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Financeiro.TaxasCambiais;
using Luminus.Selenium.specs.Shared.SsAlterarTaxasCambiais16018;

namespace Luminus.Selenium.specs.Shared.SsAlterarTaxasCambiais16018
{
    public class SsAlterarTaxasCambiais16018PageStep
    {
        private TaxasCambiaisPageStep _page = new TaxasCambiaisPageStep();
    
        [Step("SS - Alterar Taxas cambiais <tabela> [16018]")]
        public void SsAlterarTaxasCambiais16018(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlTaxasCambiaisPage");
            new BotoesCRUDSpec().ClicarBotaoAlterar();
            _page.PreencherOsCamposDaTelaAlterartaxascambiaisstepbysteppagestep(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDaTelaTaxascambiaispagestep(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarBotaoSalvar();
        }      
    }
}