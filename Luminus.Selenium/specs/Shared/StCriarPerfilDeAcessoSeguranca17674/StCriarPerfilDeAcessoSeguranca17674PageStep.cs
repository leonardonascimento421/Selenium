
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoSeguranca17674;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoSeguranca17674
{
    public class StCriarPerfilDeAcessoSeguranca17674PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil de acesso - Segurança <tabela> [17674]")]
        public void StCriarPerfilDeAcessoSeguranca17674(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfildeacessosegurancapagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}