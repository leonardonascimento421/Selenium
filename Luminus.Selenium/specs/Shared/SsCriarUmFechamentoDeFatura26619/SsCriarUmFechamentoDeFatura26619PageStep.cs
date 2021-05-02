
using System;
using System.Threading;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Locadora.FechamentoFatura;
using Luminus.Selenium.specs.Shared.SsCriarUmFechamentoDeFatura26619;

namespace Luminus.Selenium.specs.Shared.SsCriarUmFechamentoDeFatura26619
{
    public class SsCriarUmFechamentoDeFatura26619PageStep
    {
        private FechamentoFaturaPageStep _page = new FechamentoFaturaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar um fechamento de fatura <tabela> [26619]")]
        public void SsCriarUmFechamentoDeFatura26619(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlFechamentoFaturaPage");
            Thread.Sleep(60000);
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarumfechamentodefaturastepbysteppagestep26619(tabela);
            _pageBotoes.ClicarBotaoCriar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }
    }
}