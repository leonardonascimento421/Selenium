
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAFinanceiro17678;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAFinanceiro17678
{
    public class StCriarPerfilComAcessoAFinanceiro17678PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil com acesso a Financeiro <tabela> [17678]")]
        public void StCriarPerfilComAcessoAFinanceiro17678(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarPerfilDeAcessoCustomizacao17267(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}