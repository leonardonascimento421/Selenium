
using System;
using System.Threading;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Financeiro.IntegracaoTef;
using Luminus.Selenium.specs.Shared.StCriarUmaIntegracaoTefPayGoStepByStepTabela16998;

namespace Luminus.Selenium.specs.Shared.StCriarUmaIntegracaoTefPayGoStepByStepTabela16998
{
    public class StCriarUmaIntegracaoTefPayGoStepByStepTabela16998PageStep
    {
        private IntegracaoTefPageStep _page = new IntegracaoTefPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("ST - Criar uma integração TEF Pay&Go <tabela> [16998]")]
        public void StCriarUmaIntegracaoTefPayGoStepByStep16998(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlIntegracaoTEFPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarUmaIntegracaoTefPayGoStepByStep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();

        }

        


    }
}