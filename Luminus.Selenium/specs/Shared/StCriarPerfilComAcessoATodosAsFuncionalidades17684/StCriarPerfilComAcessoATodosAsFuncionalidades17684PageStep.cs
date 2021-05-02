
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoATodosAsFuncionalidades17684;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoATodosAsFuncionalidades17684
{
    public class StCriarPerfilComAcessoATodosAsFuncionalidades17684PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil com acesso a todos as funcionalidades <tabela> [17684]")]
        public void StCriarPerfilComAcessoATodosAsFuncionalidades17684(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfilcomacessoatodosasfuncionalidadesstepbysteppagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}