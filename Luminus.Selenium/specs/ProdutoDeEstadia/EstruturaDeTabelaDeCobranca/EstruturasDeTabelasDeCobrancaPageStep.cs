
using System;
using System.Linq;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.ProdutoDeEstadia.EstruturaDeTabelaDeCobranca;
using Luminus.Selenium.specs.ProdutosDeEstadia.EstruturasDeTabelasDeCobranca;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.EstruturasDeTabelasDeCobranca
{
    public class EstruturasDeTabelasDeCobrancaPageStep
    {
        private EstruturasDeTabelasDeCobrancaPage _page = new EstruturasDeTabelasDeCobrancaPage();
        private BotoesCRUDPage _pageBotoes = new BotoesCRUDPage();

        [Step("Preencher o campo 'Nome' com o valor <nomeEstruturaCobranca> [EstruturasDeTabelasDeCobrancaPageStep] [16003]")]
        public void PreencherOCampoNomeComOValor16003(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeEstruturaCobranca"));
        }

        [Step("Preencher os campos da seção Estrutura <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [16003]")]
        public void PreencherOsCamposDaSecaoEstrutura16003(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarDomingo(Convert.ToBoolean(row.GetCell("domingoEstrutura1")));
            _page.MarcarSegunda(Convert.ToBoolean(row.GetCell("segundaEstrutura1")));
            _page.MarcarTerca(Convert.ToBoolean(row.GetCell("tercaEstrutura1")));
            _page.MarcarQuarta(Convert.ToBoolean(row.GetCell("quartaEstrutura1")));
            _page.MarcarQuinta(Convert.ToBoolean(row.GetCell("quintaEstrutura1")));
            _page.MarcarSexta(Convert.ToBoolean(row.GetCell("sextaEstrutura1")));
            _page.MarcarSabado(Convert.ToBoolean(row.GetCell("sabadoEstrutura1")));
        }

        [Step("Preencher os campos do pop-up Fração 1 <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [16003]")]
        public void PreencherOsCamposDoPopUpFração1EstruturasDeTabelasDeCobrancaPageStep16003(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherDuracao(row.GetCell("fracaoDuracao1Periodo1"));
            _page.PreencherRepeticao(row.GetCell("fracaoDuracao1RepeticaoPeriodo1"));
        }

        [Step("Preencher os campos do pop-up Fração 2 <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [16003]")]
        public void PreencherOsCamposDoPopUpFração2EstruturasDeTabelasDeCobrancaPageStep16003(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherDuracao(row.GetCell("fracaoDuracao1Periodo2"));
            _page.PreencherRepeticao(row.GetCell("fracaoDuracao1RepeticaoPeriodo2"));
        }

        [Step("Preencher os campos da seção Perído 1 <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [16003]")]
        public void PreencherOsCamposDaSecaoPeriodo1EstruturasDeTabelasDeCobrancaPageStep16003(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherPeriodoInicio(row.GetCell("horaMinutoPeriodo1"));
            _page.SelecionarIntervaloRepeticoesPeriodoDe(row.GetCell("periodo1De"), 1);
            _page.SelecionarIntervaloRepeticoesPeriodoAte(row.GetCell("periodo1Ate"), 1);
        }

        [Step("Preencher os campos da seção Perído 2 <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [16003]")]
        public void PreencherOsCamposDaSecaoPeriodo2EstruturasDeTabelasDeCobrancaPageStep16003(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherPeriodoInicio2(row.GetCell("horaMinutoPeriodo2"));
            _page.SelecionarIntervaloRepeticoesPeriodoDe(row.GetCell("periodo2De"), 2);
            _page.SelecionarIntervaloRepeticoesPeriodoAte(row.GetCell("periodo2Ate"), 2);
        }

        [Step("Verificar os campos da tela <table:resources/CriarUmaEstruturaDeCobranca15991.csv> [EstruturasDeTabelasDeCobrancaPageStep] [16003]")]
        public void VerificarOsCamposDaTelaCriarumaestruturadecobrancastepbysteppagestep16003(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.RetornarNome().Should().Be(row.GetCell("nomeEstruturaCobranca"));
            _page.RetornarDomingo().Should().Be(Convert.ToBoolean(row.GetCell("domingoEstrutura1")));
            _page.RetornarSegunda().Should().Be(Convert.ToBoolean(row.GetCell("segundaEstrutura1")));
            _page.RetornarTerca().Should().Be(Convert.ToBoolean(row.GetCell("tercaEstrutura1")));
            _page.RetornarQuarta().Should().Be(Convert.ToBoolean(row.GetCell("quartaEstrutura1")));
            _page.RetornarQuinta().Should().Be(Convert.ToBoolean(row.GetCell("quintaEstrutura1")));
            _page.RetornarSexta().Should().Be(Convert.ToBoolean(row.GetCell("sextaEstrutura1")));
            _page.RetornarSabado().Should().Be(Convert.ToBoolean(row.GetCell("sabadoEstrutura1")));
            _page.RetornarPeriodoInicio().Should().Be(row.GetCell("horaMinutoPeriodo1"));
            _page.RetornarIntervaloRepeticoesPeriodoDe(1).Should().Be(row.GetCell("periodo1De"));
            _page.RetornarIntervaloRepeticoesPeriodoAte(1).Should().Be(row.GetCell("periodo1Ate"));
            _page.RetornarPeriodoInicio2().Should().Be(row.GetCell("horaMinutoPeriodo2"));
            _page.RetornarIntervaloRepeticoesPeriodoDe(2).Should().Be(row.GetCell("periodo2De"));
            _page.RetornarIntervaloRepeticoesPeriodoAte(2).Should().Be(row.GetCell("periodo2Ate"));
        }

        [Step("Clicar no botão Adicionar estrutura")]
        public void ClicarBotaoAdicionarEstrutura()
        {
            _page.ClicarBotaoAdicionarEstrutura();
        }

        [Step("Clicar no botão Adicionar período")]
        public void ClicarBotaoAdicionarPeriodo(int indice)
        {
            _page.ClicarBotaoAdicionarPeriodo(indice);
        }

        [Step("Clicar no botão Adicionar fração <indice>")]
        public void ClicarBotaoAdicionarFracao(int indice)
        {
            _page.ClicarBotaoAdicionarFracao(indice);
        }

        [Step("Preencher o campo 'Nome' com o valor <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [15993]")]
        public void PreencherOCampoNomeComOValorEstruturasdetabelasdecobrancapagestep15993(Table tabela)
        {
            var row = tabela.GetTableRows().First().GetCell("nomeEstruturaCobranca");
            _page.PreencherNome(row);
        }

        [Step("Na seção Período 1 - Preencher o campo 'Início': <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [15993]")]
        public void NaSecaoPeriodo1PreencherOCampoInicioEstruturasdetabelasdecobrancapagestep15993(Table tabela)
        {
            var row = tabela.GetTableRows().First().GetCell("horaMinutoPeriodo1");
            _page.PreencherPeriodoInicio(row);
        }

        [Step("Verificar se o campo 'Inicio' esta vazio [EstruturasDeTabelasDeCobrancaPageStep]")]
        public void VerificarSeOCampoInicioEstaVazioEstruturasDeTabelasDeCobrancaPageStep()
        {
            _page.RetornarPeriodoInicio().Should().Be(string.Empty);
        }

        [Step("Preencher o campo 'Duração' com o valor <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [15993]")]
        public void PreencherOCampoDuracaoComOValorEstruturasdetabelasdecobrancapagestep(Table tabela)
        {
            var row = tabela.GetTableRows().First().GetCell("fracaoDuracao1Periodo1");
            _page.PreencherDuracao(row);
        }

        [Step("Verificar se o campo 'Duração' esta vazio [EstruturasDeTabelasDeCobrancaPageStep]")]
        public void VerificarSeOCampoDuracaoEstaVazioEstruturasDeTabelasDeCobrancaPageStep()
        {
            _page.RetornarDuracao().Should().Be(string.Empty);
        }
        
        [Step("Na seção Período 1 - Preencher o campo 'Início': <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [15997]")]
        public void NaSecaoPeriodo1PreencherOCampoInicioEstruturasdetabelasdecobrancapagestep15997(Table tabela)
        {
            var row = tabela.GetTableRows().First().GetCell("horaMinutoPeriodo1alterado");
            _page.PreencherPeriodoInicio(row);
        }

        [Step("Preencher o campo 'Duração' com o valor <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [15997]")]
        public void PreecherOCampoDuracaoComOValorEstruturasdetabelasdecobrancapagestep15997(Table tabela)
        {
            var row = tabela.GetTableRows().First();
            _page.PreencherDuracao(row.GetCell("fracaoDuracao1Periodo1alterado"));
        }

        [Step("Na Seção Período 1 - com o rótulo 'Intervalo das repetições neste período' selecionar no ComboBox a opção <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [15997]")]
        public void NaSecaoPeriodo1ComORotuloIntervaloDasRepeticoesNestePeriodoSelecionarNoComboboxAOpcaoEstruturasdetabelasdecobrancapagestep15997(Table tabela)
        {
            var row = tabela.GetTableRows().First();
            _page.SelecionarIntervaloRepeticoesPeriodoDe(row.GetCell("periodo1Atealterado"),1);
        }

        [Step("Na seção Período 1 | Fração 2 - Preencher o campo 'Repetição' com o valor <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [15997]")]
        public void NaSecaoPeriodo1Fracao2PreencherOCampoRepeticaoComOValorEstruturasdetabelasdecobrancapagestep15997(Table tabela)
        {
            var row = tabela.GetTableRows().First();
            _page.PreencherRepeticao(row.GetCell("fracaoDuracao2RepeticaoPeriodo1alterado"));
        }
        
        [Step("Na seção Informações gerais clicar no Checkbox Imediatamente <tabela> [EstruturasDeTabelasDeCobrancaPageStep]")]
        public void NaSecaoInformacoesGeraisClicarNoCheckboxImediatamenteEstruturasdetabelasdecobrancapagestep(Table tabela)
        {
            var row = tabela.GetTableRows().First();
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamente")));
        }

        [Step("Na Seção Período 1 - com o rótulo 'Intervalo das repetições neste período' selecionar no ComboBox a opção <tabela> [EstruturasDeTabelasDeCobrancaPageStep]")]
        public void NaSecaoPeriodo1ComORotuloIntervaloDasRepeticoesNestePeriodoSelecionarNoComboboxAOpcaoEstruturasdetabelasdecobrancapagestep(Table tabela)
        {
            var row = tabela.GetTableRows().First();
            _page.SelecionarIntervaloRepeticoesPeriodoDe(row.GetCell("periodo1De"), 1);
        }


        [Step("Verificar se o botão Criar esta desabilitado [EstruturasDeTabelasDeCobrancaPageStep]")]
        public void VerificarSeoBotaoCriarEstaDesabilitadoEstruturasDeTabelasDeCobrancaPageStep()
        {
            _page.RetornarBotaoCriarDesabilitado("criar","disabled").Should().Be("true");
        }

        [Step("Verificar os campos da tela <tabela> [EstruturasDeTabelasDeCobrancaPageStep] [17997]")]
        public void VerificarOsCamposDaTelaCriarumaestruturadecobrancastepbysteppagestep17997(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.RetornarNome().Should().Be(row.GetCell("nomeEstruturaCobranca"));
            _page.RetornarDomingo().Should().Be(Convert.ToBoolean(row.GetCell("domingoEstrutura1")));
            _page.RetornarSegunda().Should().Be(Convert.ToBoolean(row.GetCell("segundaEstrutura1")));
            _page.RetornarTerca().Should().Be(Convert.ToBoolean(row.GetCell("tercaEstrutura1")));
            _page.RetornarQuarta().Should().Be(Convert.ToBoolean(row.GetCell("quartaEstrutura1")));
            _page.RetornarQuinta().Should().Be(Convert.ToBoolean(row.GetCell("quintaEstrutura1")));
            _page.RetornarSexta().Should().Be(Convert.ToBoolean(row.GetCell("sextaEstrutura1")));
            _page.RetornarSabado().Should().Be(Convert.ToBoolean(row.GetCell("sabadoEstrutura1")));
            _page.RetornarPeriodoInicio().Should().Be(row.GetCell("horaMinutoPeriodo1alterado"));
            _page.RetornarIntervaloRepeticoesPeriodoDe(1).Should().Be(row.GetCell("periodo1Atealterado"));
            _page.RetornarIntervaloRepeticoesPeriodoAte(1).Should().Be(row.GetCell("periodo1Atealterado"));
            _page.RetornarPeriodoInicio2().Should().Be(row.GetCell("horaMinutoPeriodo2"));
            _page.RetornarIntervaloRepeticoesPeriodoDe(2).Should().Be(row.GetCell("periodo2De"));
            _page.RetornarIntervaloRepeticoesPeriodoAte(2).Should().Be(row.GetCell("periodo2Ate"));
        }
    }
}