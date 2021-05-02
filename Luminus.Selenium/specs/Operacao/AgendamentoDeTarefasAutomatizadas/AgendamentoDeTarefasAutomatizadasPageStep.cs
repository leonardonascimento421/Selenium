
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.specs.Operacao.AgendamentoDeTarefasAutomatizadas;

namespace Luminus.Selenium.specs.Operacao.AgendamentoDeTarefasAutomatizadas
{
    public class AgendamentoDeTarefasAutomatizadasPageStep
    {
        private AgendamentoDeTarefasAutomatizadasPage _page = new AgendamentoDeTarefasAutomatizadasPage();
        private BotoesCRUDPage _pageBotoes = new BotoesCRUDPage();

        [Step("Preencher os campos da tela <tabela> [AgendamentoDeTarefasAutomatizadasPageStep] [17493]")]
        public void PreencherOsCamposDaTelaAgendamentodetarefasautomatizadaspagestep17493(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
           _page.SelecionarTarefa(row.GetCell("limpaPatioTaskAgendamentoTarefaAutomatizada"));
           _page.MarcarHabilitarNExecucoes(Convert.ToBoolean(row.GetCell("numeroExecucoesTarefaAgendamentoTarefaAutomatizada")));
           _page.PreencherDataInicioValidade(row.GetCell("dataInicioExecucaoAgendamentoTarefaAutomatizada"));
           _page.MarcarSemDataTerminoValidade(Convert.ToBoolean(row.GetCell("semDataFimAgendamentoTarefaAutomatizada")));
           _page.PreencherHoraInicioValidade(row.GetCell("horarioInicioExecucaoAgendamentoTarefaAutomatizada"));
           _page.PreencherHoraTerminoValidade(row.GetCell("horarioFimExecucaoAgendamentoTarefaAutomatizada"));
           _page.PreencherTempoEsperaEntreRepeticoesEmMinutos(row.GetCell("tempoRepeticaoAgendamentoTarefaAutomatizada"));
           _page.MarcarExecutarEmCasoErro(Convert.ToBoolean(row.GetCell("executarCasoErroAgendamentoTarefaAutomatizada")));
           _page.MarcarUtilizarHorarioViradaOperacional(Convert.ToBoolean(row.GetCell("utilizarHorarioViradaAgendamentoTarefaAutomatizada")));
           _page.PreencherTempoEstadiaUtilizado(row.GetCell("tempoUsadoEstadiaAgendamentoTarefaAutomatizada"));
           _page.SelecionarUmBolsaoDualist(row.GetCell("nomeBolsaoDeVagas"));
           _pageBotoes.ClicarBotaoMover();
           _page.SelecionarTipoOcorrencia(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
           _page.PreencherJustificativaTipoOcorrencia(row.GetCell("justificativaLimpaPatioAgendamentoTarefaAutomatizada"));
        }

        [Step("Verificar os campos da tela <tabela> [AgendamentoDeTarefasAutomatizadasPageStep] [17493]")]
        public void VerificarOsCamposDaTelaAgendamentodetarefasautomatizadaspagestep17493(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarTarefa().Should().Be(row.GetCell("limpaPatioTaskAgendamentoTarefaAutomatizada"));
               _page.RetornarAtivo().Should().Be(Convert.ToBoolean(row.GetCell("tarefaAtivaAgendamentoTarefaAutomatizada")));
               _page.RetornarHabilitarNExecucoes().Should().Be(Convert.ToBoolean(row.GetCell("numeroExecucoesTarefaAgendamentoTarefaAutomatizada")));
               _page.RetornarDataInicioValidade().Should().Be(row.GetCell("dataInicioExecucaoAgendamentoTarefaAutomatizada"));
               _page.RetornarDataTerminoValidade().Should().Be(row.GetCell("dataFimExecucaoAgendamentoTarefaAutomatizada"));
               _page.RetornarSemDataTerminoValidade().Should().Be(Convert.ToBoolean(row.GetCell("semDataFimAgendamentoTarefaAutomatizada")));
               _page.RetornarHoraInicioValidade().Should().Be(row.GetCell("horarioInicioExecucaoAgendamentoTarefaAutomatizada"));
               _page.RetornarHoraTerminoValidade().Should().Be(row.GetCell("horarioFimExecucaoAgendamentoTarefaAutomatizada"));
               _page.RetornarTempoEsperaEntreRepeticoesEmMinutos().Should().Be(row.GetCell("tempoRepeticaoAgendamentoTarefaAutomatizada"));
               _page.RetornarExecutarEmCasoErro().Should().Be(Convert.ToBoolean(row.GetCell("executarCasoErroAgendamentoTarefaAutomatizada")));
               _page.RetornarUtilizarHorarioViradaOperacional().Should().Be(Convert.ToBoolean(row.GetCell("utilizarHorarioViradaAgendamentoTarefaAutomatizada")));
               _page.RetornarTempoEstadiaUtilizado().Should().Be(row.GetCell("tempoUsadoEstadiaAgendamentoTarefaAutomatizada"));
               _page.RetornarUmSelecionadoBolsaoDualist().Should().BeEquivalentTo(new string[] { row.GetCell("nomeBolsaoDeVagas") });
               _page.RetornarTipoOcorrencia().Should().Be(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
               _page.RetornarJustificativaTipoOcorrencia().Should().Be(row.GetCell("justificativaLimpaPatioAgendamentoTarefaAutomatizada"));
            }            
        }
    }
}