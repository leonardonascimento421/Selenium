
using System;
using System.Threading;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAConfiguracoesDeEstacionamentoTabela17739;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAConfiguracoesDeEstacionamentoTabela17739
{
    public class StCriarPerfilComAcessoAConfiguracoesDeEstacionamentoTabela17739Spec
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil com acesso a configurações de estacionamento <tabela> [17739]")]
        public void StCriarPerfilComAcessoAConfiguracoesDeEstacionamento17739(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarPerfilComAcessoAConfiguracoesDeEstacionamento17739(tabela);
            _pageBotoes.ClicarBotaoSalvar();
        }
    }
}