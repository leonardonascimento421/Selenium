
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadia17930;

namespace Luminus.Selenium.specs.Shared.SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadia17930
{
    public class SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadia17930PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Aditamento de contrato de estadia de Produto de estadia <tabela> [17930]")]
        public void SsAditamentoDeContratoDeEstadiaDeProdutoDeEstadia17930(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoAditamentoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17930(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();

        }      
    }
}