
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.AgendamentoDeTarefasAutomatizadas;
using Luminus.Selenium.specs.Shared.SsLimparLogAuditoria17649;

namespace Luminus.Selenium.specs.Shared.SsLimparLogAuditoria17649
{
    public class SsCriarTarefaAutomatizada17493PageStep
    {
        private AgendamentoDeTarefasAutomatizadasPageStep _page = new AgendamentoDeTarefasAutomatizadasPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("SS - Criar tarefa automatizada limpar pátio <tabela> [17493]")]
        public void SsCriarTarefaAutomatizadaLimparPatio17493(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlAgendamentoDeTarefasAutomatizadasPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaAgendamentodetarefasautomatizadaspagestep17493(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();
        }
    }
}