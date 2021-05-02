
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaProdutoEstadiaDiaDoMes17885;

namespace Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaProdutoEstadiaDiaDoMes17885
{
    public class SsCriarContratoDeEstadiaProdutoEstadiaDiaDoMes17885PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar contrato de estadia Produto estadia 'Dia do mês' <tabela> [17885]")]
        public void SsCriarContratoDeEstadiaProdutoEstadiaDiaDoMes17885(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlContratosDeEstadiaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaSecaoInformacoesGeraisContratosDeEstadiaPageStep17885(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageBotoes.ClicarBotaoSalvareContinuar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }      
    }
}