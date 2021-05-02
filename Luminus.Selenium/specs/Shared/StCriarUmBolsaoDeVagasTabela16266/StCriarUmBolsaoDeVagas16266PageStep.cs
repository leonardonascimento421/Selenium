
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.BolsaoVagas;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;

namespace Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266
{
    public class StCriarUmBolsaoDeVagas16266PageStep
    {
        private BolsaoVagasPageStep _page = new BolsaoVagasPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("ST - Criar um bolsão de vagas <tabela> [16266]")]
        public void StCriarUmBolsaoDeVagas16266(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlBolsaoListarPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaBolsaoVagas16266(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();
        }
    }
}
