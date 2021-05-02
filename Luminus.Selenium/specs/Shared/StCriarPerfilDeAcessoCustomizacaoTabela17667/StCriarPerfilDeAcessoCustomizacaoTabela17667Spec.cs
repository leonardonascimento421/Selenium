
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoCustomizacaoTabela17667;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoCustomizacaoTabela17667
{
    public class StCriarPerfilDeAcessoCustomizacaoTabela17667Spec
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil de acesso - Customização <tabela> [17667]")]
        public void StCriarPerfilComAcessoAAtedimentovalet17667(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarPerfilDeAcessoCustomizacao17667(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}