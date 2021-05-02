
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoARelatoriosCustomizados17677;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoARelatoriosCustomizados17677
{
    public class StCriarPerfilComAcessoARelatoriosCustomizados17677PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil com acesso a Relatórios customizados <tabela> [17677]")]
        public void StCriarPerfilComAcessoARelatoriosCustomizados17677(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfilcomacessoarelatorioscustomizadosstepbysteppagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}