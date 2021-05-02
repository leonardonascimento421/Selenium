using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoOperacao17610;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilDeAcessoOperacao17610
{
    public class StCriarPerfilDeAcessoOperacao17610PageStep
    {
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil de acesso - Operação <tabela> [17610]")]
        public void StCriarPerfilDeAcessoOperacao17610(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarperfildeacessooperacaopagestep17269(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            new MensagemSpec().VerificarMensagemCriacaoComSucesso();
        }
    }
}