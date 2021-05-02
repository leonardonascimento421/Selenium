
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Financeiro.RegrasDeNumerarioDeAutoatendimento;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;

namespace Luminus.Selenium.specs.Financeiro.RegrasDeNumerarioDeAutoatendimento
{
    public class RegrasDeNumerarioDeAutoatendimentoPageStep
    {
        private RegrasDeNumerarioDeAutoatendimentoPage _page = new RegrasDeNumerarioDeAutoatendimentoPage();       

        [Step("Preencher os campos da tela <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep] [16943]")]
        public void PreencherOsCamposDaTelaRegrasDeNumerarioDeAutoatendimentoPageStep16943(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeRegrasDeNumerario(row.GetCell("nomeRegrasDeNumerario"));
            _page.SelecionarmodeloDoModuloFinanceiroRegrasDeNumerario(row.GetCell("modeloDoModuloFinanceiroRegrasDeNumerario"));
            _page.MarcarsemLimitesRegrasDeNumerario(Convert.ToBoolean(row.GetCell("semLimitesRegrasDeNumerario")));
            _page.PreenchervalorMaximoParaTrocoEmCedulasRegrasDeNumerario(row.GetCell("valorMaximoParaTrocoEmCedulasRegrasDeNumerario"));
            _page.PreencherquantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario"));
            _page.PreencherquantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario"));
            _page.PreencherquantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario(row.GetCell("quantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario"));
            _page.PreenchervalorMaximoParaTrocoEmMoedasRegrasDeNumerario(row.GetCell("valorMaximoParaTrocoEmMoedasRegrasDeNumerario"));
            _page.PreencherquantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario"));
            _page.PreencherquantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario"));     
        }

        [Step("Preencher os campos da tela PopUp Cédulas <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep]")]
        public void PreencherOsCamposDaTelaPopUpCedulasRegrasdenumerariodeautoatendimentopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarmoedaCedulasRegrasDeNumerario(row.GetCell("moedaCedulasRegrasDeNumerario"));
            _page.SelecionarvalorCedulasRegrasDeNumerario(row.GetCell("valorCedulasRegrasDeNumerario"));
            _page.PreencherquantidadeMximaNoDispensadorCedulasRegrasDeNumerario(row.GetCell("quantidadeMximaNoDispensadorCedulasRegrasDeNumerario"));
            _page.PreencherquantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorCedulasRegrasDeNumerario"));
            _page.SelecionaracaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario"));
            _page.PreencherquantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario"));
            _page.MarcaravulsoCedulasRegrasDeNumerario(Convert.ToBoolean(row.GetCell("avulsoCedulasRegrasDeNumerario")));
            _page.MarcarprePagoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("prePagoCedulasRegrasDeNumerario")));
            _page.MarcarcredenciadoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("credenciadoCedulasRegrasDeNumerario")));
        }

        [Step("Preencher os campos da tela PopUp Moedas <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep]")]
        public void PreencherOsCamposDaTelaPopUpMoedasRegrasdenumerariodeautoatendimentopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarmoedaMoedasRegrasDeNumerario(row.GetCell("moedaMoedasRegrasDeNumerario"));
            _page.SelecionarvalorMoedasRegrasDeNumerario(row.GetCell("valorMoedasRegrasDeNumerario"));
            _page.PreencherquantidadeMximaNoDispensadorMoedasRegrasDeNumerario(row.GetCell("quantidadeMximaNoDispensadorMoedasRegrasDeNumerario"));
            _page.PreencherquantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorMoedasRegrasDeNumerario"));
            _page.SelecionaracaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario"));
            _page.PreencherquantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario"));
            _page.MarcaravulsoMoedasRegrasDeNumerario(Convert.ToBoolean(row.GetCell("avulsoMoedasRegrasDeNumerario")));
            _page.MarcarprePagoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("prePagoMoedasRegrasDeNumerario")));
            _page.MarcarcredenciadoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("credenciadoMoedasRegrasDeNumerario")));
        }             

        [Step("Preencher os campos da tela <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep] [16646]")]
        public void PrencherOsCamposDaTelaRegrasdenumerariodeautoatendimentopagestep16646(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarimediatamenteRegrasDeNumerario(Convert.ToBoolean(row.GetCell("imediatamenteRegrasDeNumerario")));
            _page.PreenchernomeRegrasDeNumerario(row.GetCell("nomeRegrasDeNumerarioalterar"));
            _page.SelecionarmodeloDoModuloFinanceiroRegrasDeNumerario(row.GetCell("modeloDoModuloFinanceiroRegrasDeNumerarioalterar"));
            _page.MarcarsemLimitesRegrasDeNumerario(Convert.ToBoolean(row.GetCell("semLimitesRegrasDeNumerarioalterar")));
            _page.PreencherQuantidadeMaximaParaContraVales(row.GetCell("QuantidadeMaximaParaContraVales"));
            _page.PreenchervalorMaximoParaTrocoEmCedulasRegrasDeNumerario(row.GetCell("valorMaximoParaTrocoEmCedulasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario(row.GetCell("quantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerarioalterar"));
            _page.PreenchervalorMaximoParaTrocoEmMoedasRegrasDeNumerario(row.GetCell("valorMaximoParaTrocoEmMoedasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario(row.GetCell("quantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerarioalterar"));
        }

        [Step("Preencher os campos da tela PopUp Cédulas <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep] [16646]")]
        public void PreencherOsCamposDaTelaPopUpCedulasRegrasdenumerariodeautoatendimentopagestep16446(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarmoedaCedulasRegrasDeNumerario(row.GetCell("moedaCedulasRegrasDeNumerarioalterar"));
            _page.SelecionarvalorCedulasRegrasDeNumerario(row.GetCell("valorCedulasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMximaNoDispensadorCedulasRegrasDeNumerario(row.GetCell("quantidadeMximaNoDispensadorCedulasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorCedulasRegrasDeNumerarioalterar"));
            _page.SelecionaracaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerarioalterar"));
            _page.MarcaravulsoCedulasRegrasDeNumerario(Convert.ToBoolean(row.GetCell("avulsoCedulasRegrasDeNumerarioalterar")));
            _page.MarcarprePagoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("prePagoCedulasRegrasDeNumerarioalterar")));
            _page.MarcarcredenciadoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("credenciadoCedulasRegrasDeNumerarioalterar")));
        }

        [Step("Preencher os campos da tela PopUp Moedas <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep] [16646]")]
        public void PreencherOsCamposDaTelaPopUpMoedasRegrasdenumerariodeautoatendimentopagestep16646(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarmoedaMoedasRegrasDeNumerario(row.GetCell("moedaMoedasRegrasDeNumerarioalterar"));
            _page.SelecionarvalorMoedasRegrasDeNumerario(row.GetCell("valorMoedasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMximaNoDispensadorMoedasRegrasDeNumerario(row.GetCell("quantidadeMximaNoDispensadorMoedasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorMoedasRegrasDeNumerarioalterar"));
            _page.SelecionaracaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerarioalterar"));
            _page.PreencherquantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerarioalterar"));
            _page.MarcaravulsoMoedasRegrasDeNumerario(Convert.ToBoolean(row.GetCell("avulsoMoedasRegrasDeNumerarioalterar")));
            _page.MarcarprePagoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("prePagoMoedasRegrasDeNumerarioalterar")));
            _page.MarcarcredenciadoMonetarioCedulasRegrasNumerario(Convert.ToBoolean(row.GetCell("credenciadoMoedasRegrasDeNumerarioalterar")));
        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep] [16645]")]
        public void VerificarOsCamposDaTelaRegrasdenumerariodeautoatendimentopagestep16645(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeRegrasDeNumerario().Should().Be(row.GetCell("nomeRegrasDeNumerario"));
                _page.RetornarmodeloDoModuloFinanceiroRegrasDeNumerario().Should().Be(row.GetCell("modeloDoModuloFinanceiroRegrasDeNumerario"));
                _page.RetornarsemLimitesRegrasDeNumerario().Should().Be(Convert.ToBoolean(row.GetCell("semLimitesRegrasDeNumerario")));
                Formatacao.AdicionarCasasDecimais(_page.RetornarvalorMaximoParaTrocoEmCedulasRegrasDeNumerario()).Should().Be(row.GetCell("valorMaximoParaTrocoEmCedulasRegrasDeNumerario"));
                _page.RetornarquantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario"));
                _page.RetornarquantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario"));
                _page.RetornarquantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario"));
                var tabelacedula = _page.RetornarTabelaCedulas();
                _page.RetornarmoedaCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("moedaCedulasRegrasDeNumerario"));
                _page.RetornarvalorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("valorCedulasRegrasDeNumerario"));
                _page.RetornarquantidadeMximaNoDispensadorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("quantidadeMximaNoDispensadorCedulasRegrasDeNumerario"));
                _page.RetornarquantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorCedulasRegrasDeNumerario"));
                _page.RetornaracaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario"));
                _page.RetornarquantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario"));
                _page.RetornarvalorMaximoParaTrocoEmMoedasRegrasDeNumerario().Should().Be(row.GetCell("valorMaximoParaTrocoEmMoedasRegrasDeNumerario"));
                _page.RetornarquantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario"));
                _page.RetornarquantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario"));     
                var tabelamoeda = _page.RetornarTabelaMoedas();
                _page.RetornarMoedaMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("moedaMoedasRegrasDeNumerario"));
                _page.RetornarValorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("valorMoedasRegrasDeNumerario"));
                _page.RetornarquantidadeMximaNoDispensadorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("quantidadeMximaNoDispensadorMoedasRegrasDeNumerario"));
                _page.RetornarquantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorMoedasRegrasDeNumerario"));
                _page.RetornaracaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario"));
                _page.RetornarquantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeNumerarioDeAutoatendimentoPageStep] [16646]")]
        public void VerificarOsCamposDaTelaRegrasdenumerariodeautoatendimentopagestep16646(Table tabela)
        {
             var row = tabela.GetTableRows()[0];
             using (new AssertionScope())
             {
              _page.RetornarnomeRegrasDeNumerario().Should().Be(row.GetCell("nomeRegrasDeNumerarioalterar"));
              _page.RetornarmodeloDoModuloFinanceiroRegrasDeNumerario().Should().Be(row.GetCell("modeloDoModuloFinanceiroRegrasDeNumerarioalterar"));
              _page.RetornarsemLimitesRegrasDeNumerario().Should().Be(Convert.ToBoolean(row.GetCell("semLimitesRegrasDeNumerarioalterar")));
              _page.RetornarQuantidadeMaximaParaContraVales().Should().Be(row.GetCell("QuantidadeMaximaParaContraVales"));
                Formatacao.AdicionarCasasDecimais(_page.RetornarvalorMaximoParaTrocoEmCedulasRegrasDeNumerario()).Should().Be(row.GetCell("valorMaximoParaTrocoEmCedulasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeCedulasNoRecicladorParaAlertaRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeCedulasNoCofreParaAlertaRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeCedulasNoRejeitadorRegrasDeNumerarioalterar"));
              var tabelacedula = _page.RetornarTabelaCedulas();
              _page.RetornarmoedaCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("moedaCedulasRegrasDeNumerarioalterar"));
              _page.RetornarvalorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("valorCedulasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMximaNoDispensadorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("quantidadeMximaNoDispensadorCedulasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorCedulasRegrasDeNumerarioalterar"));
              _page.RetornaracaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorCedulasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerario(tabelacedula, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaCedulasRegrasDeNumerarioalterar"));
              _page.RetornarvalorMaximoParaTrocoEmMoedasRegrasDeNumerario().Should().Be(row.GetCell("valorMaximoParaTrocoEmMoedasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeMoedasNoRecicladorParaAlertaRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerario().Should().Be(row.GetCell("quantidadeMaximaDeMoedasNoCofreParaAlertaRegrasDeNumerarioalterar"));    
              var tabelamoeda = _page.RetornarTabelaMoedas();
              _page.RetornarMoedaMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("moedaMoedasRegrasDeNumerarioalterar"));
              _page.RetornarValorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("valorMoedasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMximaNoDispensadorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("quantidadeMximaNoDispensadorMoedasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorMoedasRegrasDeNumerarioalterar"));
              _page.RetornaracaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("acaoParaQuantidadeMinimaNoDispensadorMoedasRegrasDeNumerarioalterar"));
              _page.RetornarquantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerario(tabelamoeda, 1).Should().Be(row.GetCell("quantidadeMinimaNoDispensadorParaAlertaMoedasRegrasDeNumerarioalterar"));
            }
        }

        [Step("Clicar Botao Adicionar Cedulas")]
        public void ClicarBotaoAdicionarCedulas()
        {
            _page.ClicarBotaoAdicionarCedulas();
        }

        [Step("Clicar Botao Adicionar Moedas")]
        public void ClicarBotaoAdicionarMoedas()
        {
            _page.ClicarBotaoAdicionarMoedas();
        }
    }
}