
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoAtendimentoAssistido17666;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoAtendimentoAssistido17666
{
    public class StCriarPerfilDeAcessoAtendimentoAssistido17666PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil de acesso - atendimento assistido <tabela> [17666]")]
        public void StCriarPerfilDeAcessoAtendimentoAssistido17666(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfildeacessoatendimentoassistidopagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}