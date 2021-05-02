
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.specs.Locadora.Contrato;

namespace Luminus.Selenium.specs.Locadora.Contrato
{
    public class ContratoPageStep
    {
        private ContratoPage _page = new ContratoPage();
        private BotoesCRUDPage _pageBotoes = new BotoesCRUDPage();


        [Step("Preencher os campos da tela <tabela> [CriarContratoDeLocadoraStepByStepPageStep] [26617]")]
        public void PreencherOsCamposDaTelaCriarcontratodelocadorastepbysteppagestep26617(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
           _page.PreencherNomeDoContratoContratoLocadora(row.GetCell("nomeDoContratoContratoLocadora"));
           _page.SelecionarTipoDeCalculoExcedenteContratoLocadora(row.GetCell("tipoDeCalculoExcedenteContratoLocadora"));
           _page.PreencherValorMensalidadeContratoLocadora(row.GetCell("valorMensalidadeContratoLocadora"));
           _page.PreencherDiaDeVencimentoContratoLocadora(row.GetCell("diaDeVencimentoContratoLocadora"));
           _page.PreencherQuantidadeDeVagasContratoLocadora(row.GetCell("quantidadeDeVagasContratoLocadora"));
           _page.SelecionarNometabelasdecobrancaExcedente(row.GetCell("nometabelasdecobranca"));
           _page.SelecionarNometabelasdecobrancaCheckIn(row.GetCell("nometabelasdecobranca"));
           _page.SelecionarNometabelasdecobrancaCheckOut(row.GetCell("nometabelasdecobranca"));
           _page.SelecionarNomeUsuarioSistema(row.GetCell("nomeUsuarioSistema"));
           _pageBotoes.ClicarBotaoMover();
        }
        
		[Step("Verificar os campos da tela <tabela> [ContratoPageStep] [23161]")]
        public void VerificarOsCamposDaTelaContratopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarNomeDoContratoContratoLocadora().Should().Be(row.GetCell("nomeDoContratoContratoLocadora"));
               _page.RetornarTipoDeCalculoExcedenteContratoLocadora().Should().Be(row.GetCell("tipoDeCalculoExcedenteContratoLocadora"));
               _page.RetornarValorMensalidadeContratoLocadora().Should().Be(row.GetCell("valorMensalidadeContratoLocadora"));
               _page.RetornarDiaDeVencimentoContratoLocadora().Should().Be(row.GetCell("diaDeVencimentoContratoLocadora"));
               _page.RetornarQuantidadeDeVagasContratoLocadora().Should().Be(row.GetCell("quantidadeDeVagasContratoLocadora"));
               _page.RetornarNometabelasdecobrancaExcedente().Should().Be(row.GetCell("nometabelasdecobranca"));
               _page.RetornarNometabelasdecobrancaCheckIn().Should().Be(row.GetCell("nometabelasdecobranca"));
               _page.RetornarNometabelasdecobrancaCheckOut().Should().Be(row.GetCell("nometabelasdecobranca"));
               _page.RetornarNomeUsuarioSistema().Should().BeEquivalentTo(new string[] { row.GetCell("nomeUsuarioSistema") });
            }
        }

        [Step("Preencher os campos da tela <tabela> [ContratoPageStep] [23163]")]
        public void PreencherOsCamposDaTelaContratopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
           _page.MarcarImediatamenteContratoLocadora(Convert.ToBoolean(row.GetCell("imediatamenteContratoLocadoraalterar")));
           _page.PreencherNomeDoContratoContratoLocadora(row.GetCell("nomeDoContratoContratoLocadoraAlterar"));
           _page.PreencherValorMensalidadeContratoLocadora(row.GetCell("valorMensalidadeContratoLocadoraAlterar"));
           _page.PreencherDiaDeVencimentoContratoLocadora(row.GetCell("diaDeVencimentoContratoLocadoraAlterar"));
           _page.PreencherQuantidadeDeVagasContratoLocadora(row.GetCell("quantidadeDeVagasContratoLocadoraAlterar"));
           _page.SelecionarNometabelasdecobrancaExcedente(row.GetCell("nometabelasdecobranca"));
           _page.SelecionarNometabelasdecobrancaCheckIn(row.GetCell("nometabelasdecobranca"));
           _page.SelecionarNometabelasdecobrancaCheckOut(row.GetCell("nometabelasdecobranca"));

        }

        [Step("Verificar os campos da tela <tabela> [ContratoPageStep] [23163]")]
        public void VerificarOsCamposDaTelaContratopagestep23163(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarNomeDoContratoContratoLocadora().Should().Be(row.GetCell("nomeDoContratoContratoLocadoraAlterar"));
               _page.RetornarTipoDeCalculoExcedenteContratoLocadora().Should().Be(row.GetCell("tipoDeCalculoExcedenteContratoLocadora"));
               _page.RetornarValorMensalidadeContratoLocadora().Should().Be(row.GetCell("valorMensalidadeContratoLocadoraAlterar"));
               _page.RetornarDiaDeVencimentoContratoLocadora().Should().Be(row.GetCell("diaDeVencimentoContratoLocadoraAlterar"));
               _page.RetornarQuantidadeDeVagasContratoLocadora().Should().Be(row.GetCell("quantidadeDeVagasContratoLocadoraAlterar"));
               _page.RetornarNometabelasdecobrancaExcedente().Should().Be(row.GetCell("nometabelasdecobranca"));
               _page.RetornarNometabelasdecobrancaCheckIn().Should().Be(row.GetCell("nometabelasdecobranca"));
               _page.RetornarNometabelasdecobrancaCheckOut().Should().Be(row.GetCell("nometabelasdecobranca"));
               _page.RetornarNomeUsuarioSistema().Should().BeEquivalentTo(new string[] { row.GetCell("nomeUsuarioSistema") });
            }            
        }
    }
}