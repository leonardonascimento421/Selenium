
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsIncluirMidiaVeloeEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17935;

namespace Luminus.Selenium.specs.Shared.SsIncluirMidiaVeloeEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17935
{
    public class SsIncluirMidiaVeloeEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17935PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Incluir Mídia VELOE em um contrato de estadia Produto estadia 'Dia do mês' <tabela> [17935]")]
        public void SsIncluirMidiaVeloeEmUmContratoDeEstadiaProdutoEstadiaDiaDoMes17935(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep();
            _page.PreencherOsCamposDaTelaIncluirmidiaVeloeEmumcontratodeestadiastepbysteppagestep17935(tabela);
            _pageBotoes.ClicarNoBotaoSalvarEFecharPopUp();


        }      
    }
}