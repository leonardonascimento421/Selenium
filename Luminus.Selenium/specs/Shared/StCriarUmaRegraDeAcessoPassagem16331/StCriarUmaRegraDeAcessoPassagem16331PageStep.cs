
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeAcesso;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoPassagem16331;

namespace Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoPassagem16331
{
    public class StCriarUmaRegraDeAcessoPassagem16331PageStep
    {
        private RegrasDeAcessoPageStep _page = new RegrasDeAcessoPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("ST - Criar uma regra de acesso Passagem <tabela> [16331]")]
        public void StCriarUmaRegraDeAcessoPassagem16331(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlRegraDeAcessoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarumaregradeacessopassagemstepbysteppagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }
    }
}