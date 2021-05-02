
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ParametrosGeraisDoEstacionamento;
using Luminus.Selenium.specs.Shared.StAlterarATelaDeParametrosGeraisDoEstacionamento17883;

namespace Luminus.Selenium.specs.Shared.StAlterarATelaDeParametrosGeraisDoEstacionamento17883
{
    public class StAlterarATelaDeParametrosGeraisDoEstacionamento17883PageStep
    {
        private ParametrosGeraisDoEstacionamentoPageStep _page = new ParametrosGeraisDoEstacionamentoPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Alterar a tela de parâmetros gerais do estacionamento <tabela> [17883]")]
        public void StAlterarATelaDeParametrosGeraisDoEstacionamento17883(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlParametrosGeraisPage");
            _pageBotoes.ClicarBotaoAlterar();
            _page.PreencherOsCamposDaTelaParametrosGeraisDoEstacionamento17883(tabela);
        }
    }
}