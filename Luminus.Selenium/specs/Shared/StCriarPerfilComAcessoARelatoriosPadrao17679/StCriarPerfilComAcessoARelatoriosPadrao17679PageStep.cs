
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoARelatoriosPadrao17679;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoARelatoriosPadrao17679
{
    public class StCriarPerfilComAcessoARelatoriosPadrao17679PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - criar perfil com acesso a relatórios padrão <tabela> [17679]")]
        public void StCriarPerfilComAcessoARelatoriosPadrao17679(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfilcomacessoarelatoriospadraopagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }


    }
}