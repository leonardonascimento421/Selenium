
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaDiaDoMes17954;

namespace Luminus.Selenium.specs.Shared.SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaDiaDoMes17954
{
    public class SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaDiaDoMes17954PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Realizar aditamento em um contrato de estadia de produto estadia 'Dia do mês' <tabela> [17954]")]
        public void SsRealizarAditamentoEmUmContratoDeEstadiaDeProdutoEstadiaDiaDoMes17954(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoAditamentoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDoPopUpAdicionarValidacaoAoContratoDeEstadiaDaTelaContratoDeEstadiaProdutoStep17885(tabela);
            _pageBotoes.ClicarNoBotaoSalvarPopUp();
        }      
    }
}