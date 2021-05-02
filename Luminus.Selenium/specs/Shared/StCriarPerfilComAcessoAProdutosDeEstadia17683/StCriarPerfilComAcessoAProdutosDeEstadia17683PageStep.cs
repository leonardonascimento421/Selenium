
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAProdutosDeEstadia17683;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAProdutosDeEstadia17683
{
    public class StCriarPerfilComAcessoAProdutosDeEstadia17683PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
    
        [Step("ST - Criar perfil com acesso a Produtos de estadia <tabela> [17683]")]
        public void PreencherOsCamposDaTelaCriarperfilcomacessoaprodutosdeestadiastepbysteppagestep(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfilcomacessoaprodutosdeestadiastepbysteppagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}