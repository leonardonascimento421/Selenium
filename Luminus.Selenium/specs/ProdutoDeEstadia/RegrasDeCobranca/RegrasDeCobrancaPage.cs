
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System.Collections.Generic;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeCobranca
{
    public class RegrasDeCobrancaPage : BasePage
    {
        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void MarcarImediatamente(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), check);
        }

        public bool RetornarImediatamente()
        {
           return _driver.GetCheck(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }

        public void SelecionartipoDeInformatizadoValidacaoEquipamentos(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexTipoInformatizado']"), valor);
        }

        public void PreencherValorMaximoDiario(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorMaximoDiario']"), valor.ToString());
        }

        public string RetornarValorMaximoDiario()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMaximoDiario']"));
        }

        public void MarcarValorMaximoDiarioReferenteAoHorarioEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ValorMaximoDiarioReferenteAoHorarioEntrada']"), check);
        }

        public bool RetornarValorMaximoDiarioReferenteAoHorarioEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ValorMaximoDiarioReferenteAoHorarioEntrada']"));
        }

        public void PreencherValorMaximoEstadia(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorMaximoEstadia']"), valor.ToString());
        }

        public string RetornarValorMaximoEstadia()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMaximoEstadia']"));
        }

        public void MarcarUsarValorMaximoEstadiaAposMudancaDeDia(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='UsarValorMaximoEstadiaAposMudancaDeDia']"), check);
        }

        public bool RetornarUsarValorMaximoEstadiaAposMudancaDeDia()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='UsarValorMaximoEstadiaAposMudancaDeDia']"));
        }

        public void PreencherValorMaximoEstadiaSemAprovacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ValorMaximoEstadiaSemAprovacao']"), valor.ToString());
        }

        public string RetornarValorMaximoEstadiaSemAprovacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ValorMaximoEstadiaSemAprovacao']"));
        }

        public void PreencherNivelOperadorMinimoParaAprovacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NivelOperadorMinimoParaAprovacao']"), valor.ToString());
        }

        public string RetornarNivelOperadorMinimoParaAprovacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='NivelOperadorMinimoParaAprovacao']"));
        }

        public void PreencherQuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados']"), valor.ToString());
        }

        public string RetornarQuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados']"));
        }

        public void PreencherProximaFracaoPeriodoAposMudancaEstrutura(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ProximaFracaoPeriodoAposMudancaEstrutura']"), valor.ToString());
        }

        public string RetornarProximaFracaoPeriodoAposMudancaEstrutura()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ProximaFracaoPeriodoAposMudancaEstrutura']"));
        }

        public void MarcarManter(bool check)
        {
            _driver.MarcarCheckBox(new ByChained(
            By.XPath("//label[contains(text(),'Manter')]/.."),
            By.CssSelector("input[type=checkbox]"))
             , check);
        }

        public bool RetornarManter()
        {
            return _driver.GetCheck(new ByChained(
            By.XPath("//label[contains(text(),'Manter')]/.."),
            By.CssSelector("input[type=checkbox]")));
        }

        public void SelecionarMetodoDeCalculo(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.CssSelector("np-select-enum[controlname='IndexMetodoCalculo']"),
            By.CssSelector("select"))
            , valor);
        }

        public string RetornarMetodoDeCalculo()
        {
            return _driver.GetSelect(new ByChained(
             By.CssSelector("np-select-enum[controlname='IndexMetodoCalculo']"),
             By.CssSelector("select")));
        }

        public void SelecionarMetodoDeCalculoParaRepagamento(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.CssSelector("np-select-enum[controlname='IndexMetodoCalculoRepagamento']"),
            By.CssSelector("select"))
            , valor);
        }

        public string RetornarMetodoDeCalculoParaRepagamento()
        {
            return _driver.GetSelect(new ByChained(
             By.CssSelector("np-select-enum[controlname='IndexMetodoCalculoRepagamento']"),
             By.CssSelector("select")));
        }
        
        public void SelecionarUmBolsaoDualist(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.XPath("//label[contains(text(),'Não selecionados')]/.."),
            By.CssSelector("select"))
            , valor);
        }

        public IEnumerable<string> RetornarUmSelecionadoBolsaoDualist()
        {
            return _driver.GetItems(new ByChained(
             By.XPath("//label[contains(text(),'Selecionados')]/.."),
             By.CssSelector("select")));
        }

        public void SelecionarUmaTabelaDeCobrancaInibidaParaAValidacaoDeAvulsos(string valor)
        { 
            _driver.SelecionarCombo(new ByChained(
            By.XPath("//legend[contains(text(),'Tabelas de cobrança inibidas para a validação de a')]/.."),
            By.CssSelector("select"))
            , valor);
        }

        public IEnumerable<string> RetornarUmaTabelaDeCobrancaParaInibidaParaAValidacaoDeAvulsos()
        {
            return _driver.GetItems(new ByChained(
            By.XPath("//legend[contains(text(),'Tabelas de cobrança inibidas para a validação de a')]/.."),
            By.XPath("//label[contains(text(),'Tabelas de cobrança inibidas')]/.."),
            By.CssSelector("select")));
        }

        public void SelecionarUmaTabelaDeCobrancaInibidaParaAValidacaoDePrePago(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.XPath("//legend[contains(text(),'Tabelas de cobrança inibidas para a validação de p')]/.."),
            By.CssSelector("select"))
            , valor);
        }

        public IEnumerable<string> RetornarUmaTabelaDeCobrancaParaInibidaParaValidacaoDePrePago()
        {
            return _driver.GetItems(new ByChained(
            By.XPath("//legend[contains(text(),'Tabelas de cobrança inibidas para a validação de p')]/.."),
            By.XPath("//label[contains(text(),'Tabelas de cobrança inibidas')]/.."),
            By.CssSelector("select")));
        }

        public void MarcarCobrarUsandoApenasValoresPeriodoDaEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='CobrarUsandoApenasValoresPeriodoDaEntrada']"), check);
        }

        public bool RetornarCobrarUsandoApenasValoresPeriodoDaEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='CobrarUsandoApenasValoresPeriodoDaEntrada']"));
        }

        public void MarcarInterromperFracaoDoPeriodoNaMudancaPerido(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='InterromperFracaoDoPeriodoNaMudancaPerido']"), check);
        }

        public bool RetornarInterromperFracaoDoPeriodoNaMudancaPerido()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='InterromperFracaoDoPeriodoNaMudancaPerido']"));
        }

        public void MarcarInterromperFracaoDoPeriodoNaMudancaDia(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='InterromperFracaoDoPeriodoNaMudancaDia']"), check);
        }

        public bool RetornarInterromperFracaoDoPeriodoNaMudancaDia()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='InterromperFracaoDoPeriodoNaMudancaDia']"));
        }

        public void MarcarInterromperFracaoDoPeriodoNaMudancaEstrutura(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='InterromperFracaoDoPeriodoNaMudancaEstrutura']"), check);
        }

        public bool RetornarInterromperFracaoDoPeriodoNaMudancaEstrutura()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='InterromperFracaoDoPeriodoNaMudancaEstrutura']"));
        }

        public void MarcarPermitirPagarFracaoFuturo(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirPagarFracaoFuturo']"), check);
        }

        public bool RetornarPermitirPagarFracaoFuturo()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirPagarFracaoFuturo']"));
        }

        public void MarcarPermitirOperadorAlterarCamposRecarga(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirOperadorAlterarCamposRecarga']"), check);
        }

        public bool RetornarPermitirOperadorAlterarCamposRecarga()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirOperadorAlterarCamposRecarga']"));
        }

        public void MarcarHabilitarOpcaoRecargaManualPrePago(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarOpcaoRecargaManualPrePago']"), check);
        }

        public bool RetornarHabilitarOpcaoRecargaManualPrePago()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarOpcaoRecargaManualPrePago']"));
        }

        public void MarcarPermitirRetrocessoEstadiaNaValidacao(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirRetrocessoEstadiaNaValidacao']"), check);
        }

        public bool RetornarPermitirRetrocessoEstadiaNaValidacao()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirRetrocessoEstadiaNaValidacao']"));
        }

        public void MarcarHabilitarPagamentoAvulsoComCartaoPrePago(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarPagamentoAvulsoComCartaoPrePago']"), check);
        }

        public bool RetornarHabilitarPagamentoAvulsoComCartaoPrePago()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarPagamentoAvulsoComCartaoPrePago']"));
        }

        public void MarcarHabilitarTransferenciaAvulsoParaPrePago(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarTransferenciaAvulsoParaPrePago']"), check);
        }

        public bool RetornarHabilitarTransferenciaAvulsoParaPrePago()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarTransferenciaAvulsoParaPrePago']"));
        }

        public void PreencherLimiteDeTempoDeEstadiaParaTransferenciaDeAvulsos(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='LimiteDeTempoDeEstadiaParaTransferenciaDeAvulsos']"), valor.ToString());
        }

        public string RetornarLimiteDeTempoDeEstadiaParaTransferenciaDeAvulsos()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='LimiteDeTempoDeEstadiaParaTransferenciaDeAvulsos']"));
        }

        public void MarcarSemLimite(bool check)
        {
           _driver.MarcarCheckBox(new ByChained(
           By.XPath("//label[contains(text(),'Sem limite')]/.."),
           By.CssSelector("input[type=checkbox]"))
            , check);
        }

        public bool RetornarSemLimite()
        {
            return _driver.GetCheck(new ByChained(
            By.XPath("//label[contains(text(),'Sem limite')]/.."),
            By.CssSelector("input[type=checkbox]")));
        }

        public void PreencherTempoAdicionalAntesMudancaFracaoPeriodo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoAdicionalAntesMudancaFracaoPeriodo']"), valor.ToString());
        }

        public string RetornarTempoAdicionalAntesMudancaFracaoPeriodo()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoAdicionalAntesMudancaFracaoPeriodo']"));
        }

        public void PreencherNivelOperadorMinimoParaEditarExtensaoValidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NivelOperadorMinimoParaEditarExtensaoValidade']"), valor.ToString());
        }

        public string RetornarNivelOperadorMinimoParaEditarExtensaoValidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='NivelOperadorMinimoParaEditarExtensaoValidade']"));
        }

        public void SelecionarModoDeOtimizacaoDeCobranca(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.CssSelector("np-select-enum[controlname='IndexModoOtimizacaoCobranca']"),
            By.CssSelector("select"))
            , valor);
        }

        public string RetornarModoDeOtimizacaoDeCobranca()
        {
            return _driver.GetSelect(new ByChained(
             By.CssSelector("np-select-enum[controlname='IndexModoOtimizacaoCobranca']"),
             By.CssSelector("select")));
        }

        public void SelecionarBolsaoDeAcessoARevalidacao(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.CssSelector("np-select-enum[controlname='IndexDefinicaoDoBolsaoAcessonaRevalidacao']"),
            By.CssSelector("select"))
            , valor);
        }

        public string RetornarBolsaoDeAcessoARevalidacao()
        {
            return _driver.GetSelect(new ByChained(
             By.CssSelector("np-select-enum[controlname='IndexDefinicaoDoBolsaoAcessonaRevalidacao']"),
             By.CssSelector("select")));
        }

        public void SelecionarBloquearValidacaoDeEstadiaZerada(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.CssSelector("np-select-enum[controlname='IndexBloquearValidacaoEstadiaZerada']"),
            By.CssSelector("select"))
            , valor);
        }

        public string RetornarBloquearValidacaoDeEstadiaZerada()
        {
            return _driver.GetSelect(new ByChained(
             By.CssSelector("np-select-enum[controlname='IndexBloquearValidacaoEstadiaZerada']"),
             By.CssSelector("select")));
        }

        public void SelecionarTabelaDeCobrancaSupostaDaEntrada(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdTabelaDeCobrancaSupostaDaEntrada']"), valor.ToString());
        }

        public string RetornarTabelaDeCobrancaSupostaDaEntrada()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdTabelaDeCobrancaSupostaDaEntrada']"));
        }

        public void SelecionarComportamentoDeRevalidacaoDeCredenciadosVencidos(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.CssSelector("np-select-enum[controlname='IndexComportamentoRevalidacaoCredenciadosVencidos']"),
            By.CssSelector("select"))
            , valor);
        }

        public string RetornarComportamentoDeRevalidacaoDeCredenciadosVencidos()
        {
            return _driver.GetSelect(new ByChained(
             By.CssSelector("np-select-enum[controlname='IndexComportamentoRevalidacaoCredenciadosVencidos']"),
             By.CssSelector("select")));
        }

        public void PreencherQuantidadeTempoSupostaDaEntradaDias(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QuantidadeTempoSupostaDaEntradaDias']"), valor.ToString());
        }

        public string RetornarQuantidadeTempoSupostaDaEntradaDias()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QuantidadeTempoSupostaDaEntradaDias']"));
        }

        public void PreencherQuantidadeTempoSupostaDaEntradaHoras(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QuantidadeTempoSupostaDaEntradaHoras']"), valor.ToString());
        }

        public string RetornarQuantidadeTempoSupostaDaEntradaHoras()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QuantidadeTempoSupostaDaEntradaHoras']"));
        }

        public void PreencherQuantidadeTempoSupostaDaEntradaMinutos(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='QuantidadeTempoSupostaDaEntradaMinutos']"), valor.ToString());
        }

        public string RetornarQuantidadeTempoSupostaDaEntradaMinutos()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='QuantidadeTempoSupostaDaEntradaMinutos']"));
        }

        public void SelecionarFormasDePagamento(string valor)
        {
            _driver.SelecionarCombo(new ByChained(
            By.CssSelector("np-select-enum[controlname='IndexFormasPagamento']"),
            By.CssSelector("select"))
            , valor);
        }

        public string RetornarFormasDePagamento()
        {
            return _driver.GetSelect(new ByChained(
             By.CssSelector("np-select-enum[controlname='IndexFormasPagamento']"),
             By.CssSelector("select")));
        }

        public void MarcarVerificarBolsaoPrecedente(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='VerificarBolsaoPrecedente']"), check);
        }

        public bool RetornarVerificarBolsaoPrecedente()
        {
          return _driver.GetCheck(By.CssSelector("input[formcontrolname='VerificarBolsaoPrecedente']"));
        }

        public void ClicarBotaoMoverComIndice(int indice)
        {
            _driver.Click(By.XPath($"(//button[@title='Mover'])[{indice}]"));
        }
    }
}