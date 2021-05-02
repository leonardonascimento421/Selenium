
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoASeloDeDesconto17661;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoASeloDeDesconto17661
{
    public class StCriarPerfilComAcessoASeloDeDesconto17661PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil com acesso a Selo de Desconto <tabela> [17661]")]
        public void StCriarPerfilComAcessoASeloDeDesconto17661(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfilcomacessoaselodedescontopagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}