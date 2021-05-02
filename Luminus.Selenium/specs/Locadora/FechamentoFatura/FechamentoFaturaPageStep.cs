
using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Locadora.FechamentoFatura;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;

namespace Luminus.Selenium.specs.Locadora.FechamentoFatura
{
    public class FechamentoFaturaPageStep
    {
        private FechamentoFaturaPage _page = new FechamentoFaturaPage();		
		
		[Step("Preencher os campos da tela <tabela> [CriarUmFechamentoDeFaturaStepByStepPageStep] [26619]")]
        public void PreencherOsCamposDaTelaCriarumfechamentodefaturastepbysteppagestep26619(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            Thread.Sleep(60000);
            DateTime Data = DateTime.Now;
            _page.SelecionarNomeDoContratoContratoLocadora(row.GetCell("nomeDoContratoContratoLocadora"));
            _page.PreencherDataFechamentoFechamentoFatura(Data.ToString("ddMMyyyy"));                      
            _page.PreencherHoraFechamentoFechamentoFatura(Data.ToString("HH:mm"));
            
        }
    
        [Step("Verificar os campos da tela <tabela> [FechamentoFaturaPageStep] [23169]")]
        public void VerificarOsCamposDaTelaFechamentofaturapagestep23169(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarNomeDoContratoContratoLocadora().Should().Be(row.GetCell("nomeDoContratoContratoLocadora"));
               _page.RetornarNumeroFaturaContratoLocadora().Should().Be(row.GetCell("numeroFechamentoFatura"));
               _page.RetornarDataPagamentoFaturaContratoLocadora().Should().Be(row.GetCell("dataPagamentoFechamentoFatura"));
               _page.RetornarValorParcialFaturaContratoLocadora().Should().Be(row.GetCell("valorParcialFechamentoFatura"));
               _page.RetornarValorMensalistaFaturaContratoLocadora().Should().Be(row.GetCell("valorMensalidadeContratoLocadora"));
               _page.RetornarTipoCalculoExcedenteFaturaContratoLocadora().Should().Be(row.GetCell("tipoDeCalculoExcedenteContratoLocadora"));
            }
            
        }
        
        [Step("Clicar na opção liquidar na listagem [FechamentoFaturaPageStep]")]
        public void ClicarNaOpcaoLiquidarFechamentofaturapagestep()
        {
            IWebElement elementoMenuContexto = ClicarBotao3PontosVerificandoContexto();
            _page.ClicarBotaoliquidarListagem(elementoMenuContexto);

        }

        private IWebElement ClicarBotao3PontosVerificandoContexto()
        {
            var elementoMenuContexto = TestContextHelper.Get<IWebElement>("elementoMenuContexto");
            TestContextHelper.Clear("elementoMenuContexto");

            if (elementoMenuContexto == null)
                elementoMenuContexto = _page.ClicarBotao3Pontos();
            return elementoMenuContexto;
        }

        [Step("Na seção Dados fatura preencher o campo Data pagamento com o valor DateTime.Now [FechamentoFaturaPageStep]")]
        public void NaSecaoDadosFaturaPreencherOCampoDataPagamentoComOValorFechamentofaturapagestep()
        {
             DateTime Data = DateTime.Now;
            _page.PreencherDataPagamentoFechamentoFatura(Data.ToString("ddMMyyyy"));
        }

        [Step("Na seção Dados fatura preencher o campo Hora fechamento com o valor <horaFechamentoFatura> [FechamentoFaturaPageStep]")]
        public void NaSecaoDadosFaturaPreencherOCampoHoraFechamentoComOValorFechamentofaturapagestep(string horaFechamentoFatura)
        {
            _page.PreencherHoraFechamentoFechamentoFatura(horaFechamentoFatura);
        }

        [Step("Na seção Dados fatura preencher o campo Hora Liquidação com o valor DateTime.Now [FechamentoFaturaPageStep]")]
        public void NaSecaoDadosFaturaPreencherOCampoHoraLiquidacaoComOValorFechamentofaturapagestep()
        {
             DateTime Data = DateTime.Now;
             _page.PreencherHoraLiquidacaoFechamentoFatura(Data.ToString("HH:mm"));
        } 

        [Step("Clicar no botão liquidar [FechamentoFaturaPageStep]")]
        public void ClicarNoBotaoLiquidarFechamentofaturapagestep()
        {
            _page.ClicarBotaoLiquidar();            
        }

        [Step("Verificar os campos da tela <tabela> [FechamentoFaturaPageStep] [23172]")]
        public void VerificarOsCamposDaTelaFechamentofaturapagestep23172(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                DateTime Data = DateTime.Now;
               _page.RetornarNomeDoContratoContratoLocadora().Should().Be(row.GetCell("nomeDoContratoContratoLocadora"));
               _page.RetornarNumeroFaturaContratoLocadora().Should().Be(row.GetCell("numeroFechamentoFatura"));
               _page.RetornarDataPagamentoFaturaContratoLocadora().Should().Be(Data.ToString("dd/M/yyyy"));
               _page.RetornarValorParcialFaturaContratoLocadora().Should().Be(row.GetCell("valorParcialFechamentoFatura"));
               _page.RetornarValorMensalistaFaturaContratoLocadora().Should().Be(row.GetCell("valorMensalidadeContratoLocadora"));
               _page.RetornarTipoCalculoExcedenteFaturaContratoLocadora().Should().Be(row.GetCell("tipoDeCalculoExcedenteContratoLocadora"));
            }            
        }        
    }
}