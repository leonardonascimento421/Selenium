
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeAcesso;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoEntrada16330;

namespace Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoEntrada16330
{
    public class StCriarUmaRegraDeAcessoEntrada16330PageStep
    {
        private RegrasDeAcessoPageStep _page = new RegrasDeAcessoPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("ST - Criar uma regra de acesso Entrada <tabela> [16330]")]
        public void StCriarUmaRegraDeAcessoEntrada16330(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlRegraDeAcessoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarumaregradeacessoentradastepbysteppagestep(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
        }



    }
}