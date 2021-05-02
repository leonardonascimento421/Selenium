
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoAInstalacoesEAtualizacoes17675;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoAInstalacoesEAtualizacoes17675
{
    public class StCriarPerfilDeAcessoAInstalacoesEAtualizacoes17675PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil de acesso a instalações e atualizações <tabela> [17675]")]
        public void StCriarPerfilDeAcessoAInstalacoesEAtualizacoes17675(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfildeacessoainstalacoeseatualizacoespagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}