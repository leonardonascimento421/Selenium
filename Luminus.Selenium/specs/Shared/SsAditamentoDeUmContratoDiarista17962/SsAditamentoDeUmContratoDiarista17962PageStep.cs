
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsAditamentoDeUmContratoDiarista17962;

namespace Luminus.Selenium.specs.Shared.SsAditamentoDeUmContratoDiarista17962
{
    public class SsAditamentoDeUmContratoDiarista17962PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Aditamento de um contrato diarista <tabela> [17962]")]
        public void SsAditamentoDeUmContratoDiarista17962(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoAditamentoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopupDeAditamentoContratosDeEstadiaPageStep17962(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
        }      
    }
}