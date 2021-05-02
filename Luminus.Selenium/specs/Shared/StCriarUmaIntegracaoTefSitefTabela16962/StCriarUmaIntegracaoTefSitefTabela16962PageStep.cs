
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Financeiro.IntegracaoTef;
using Luminus.Selenium.specs.Shared.StCriarUmaIntegracaoTefSitefTabela16962;

namespace Luminus.Selenium.specs.Shared.StCriarUmaIntegracaoTefSitefTabela16962
{
    public class StCriarUmaIntegracaoTefSitefTabela16962PageStep
    {
        private IntegracaoTefPageStep _page = new IntegracaoTefPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("ST - Criar uma integração TEF SITEF <tabela> [16962]")]
        public void StCriarUmaIntegracaoTefSitef16962(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlIntegracaoTEFPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarUmaIntegracaoTefSitef(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }

    }
}