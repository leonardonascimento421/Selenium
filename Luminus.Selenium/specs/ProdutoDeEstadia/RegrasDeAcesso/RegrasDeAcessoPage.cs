
using Gauge.CSharp.Lib;
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System.Collections.Generic;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeAcesso
{
    public class RegrasDeAcessoPage : BasePage
    {
        public void MarcarImediatamente(bool checkImediatamente)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), checkImediatamente);
        }

        public bool RetornarImediatamente()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Imediatamente']"));
        }

        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void SelecionarFuncaoDeOperacaoDoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexFuncaoOperacao']"), valor.ToString());
        }

        public string RetornarFuncaoDeOperacaoDoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexFuncaoOperacao']"));
        }

        public void MarcarDomingo(bool checkDomingo)
        {
            _driver.MarcarCheckBox(By.CssSelector("li[title='Domingo']"), checkDomingo);
        }

        public bool RetornarDomingo()
        {
          return _driver.GetCheck(new ByChained(
          By.CssSelector("li[title='Domingo']"),
          By.CssSelector("input[type='checkbox']")));
      
        }

        public void MarcarSegunda(bool checkSegunda)
        {
            _driver.MarcarCheckBox(By.CssSelector("li[title='Segunda-feira']"), checkSegunda);

        }

        public bool RetornarSegunda()
        {
            return _driver.GetCheck(new ByChained(
          By.CssSelector("li[title='Segunda-feira']"),
          By.CssSelector("input[type='checkbox']")));            
        }

        public void MarcarTerca(bool checkTerca)
        {
            _driver.MarcarCheckBox(By.CssSelector("li[title='Terça-feira']"), checkTerca);
        }

        public bool RetornarTerca()
        {
            return _driver.GetCheck(new ByChained(
         By.CssSelector("li[title='Terça-feira']"),
         By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarQuarta(bool checkQuarta)
        {
            _driver.MarcarCheckBox(By.CssSelector("li[title='Quarta-feira']"), checkQuarta);
        }

        public bool RetornarQuarta()
        {
            return _driver.GetCheck(new ByChained(
           By.CssSelector("li[title='Quarta-feira']"),
           By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarQuinta(bool checkQuinta)
        {
            _driver.MarcarCheckBox(By.CssSelector("li[title='Quinta-feira']"), checkQuinta);
        }

        public bool RetornarQuinta()
        {
            return _driver.GetCheck(new ByChained(
        By.CssSelector("li[title='Quinta-feira']"),
        By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSexta(bool checkSexta)
        {
            _driver.MarcarCheckBox(By.CssSelector("li[title='Sexta-feira']"), checkSexta);
        }

        public bool RetornarSexta()
        {
            return _driver.GetCheck(new ByChained(
        By.CssSelector("li[title='Sexta-feira']"),
        By.CssSelector("input[type='checkbox']")));
        }

        public void MarcarSabado(bool checkSabado)
        {
            _driver.MarcarCheckBox(By.CssSelector("li[title='Sábado']"), checkSabado);
        }

        public bool RetornarSabado()
        {
            return _driver.GetCheck(new ByChained(
         By.CssSelector("li[title='Sábado']"),
         By.CssSelector("input[type='checkbox']")));
        }

        public void PreencherPeriodoValidoInicial(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='PeriodoValidoInicial']"), valor.ToString());
        }

        public string RetornarPeriodoValidoInicial()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='PeriodoValidoInicial']"));
        }

        public void PreencherPeriodoValidoFinal(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='PeriodoValidoFinal']"), valor.ToString());
        }

        public string RetornarPeriodoValidoFinal()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='PeriodoValidoFinal']"));
        }

        public void MarcarVerificarBolsaoPrecedente(bool checkSabado)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='VerificarBolsaoPrecedente']"), checkSabado);
        }

        public bool RetornarVerificarBolsaoPrecedente()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='VerificarBolsaoPrecedente']"));
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

        public void SelecionarVeiculosPermitidos(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexVeiculosPermitidos']"), valor.ToString());
        }

        public string RetornarVeiculosPermitidos()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexVeiculosPermitidos']"));
        }

        public void SelecionarCartoesVencidos(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexCartoesVencidos']"), valor.ToString());
        }

        public string RetornarCartoesVencidos()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexCartoesVencidos']"));
        }

        public void PreencherToleranciaEmDiasCartoesVencidos(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ToleranciaEmDiasCartoesVencidos']"), valor.ToString());
        }

        public string RetornarToleranciaEmDiasCartoesVencidos()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ToleranciaEmDiasCartoesVencidos']"));
        }

        public void PreencherTempoDesistenciaEntrada(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoDesistenciaEntrada']"), valor.ToString());
        }

        public string RetornarTempoDesistenciaEntrada()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoDesistenciaEntrada']"));
        }

        public void MarcarInfinitoDesistenciaEntrada(bool checkSabado)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='infinitoDesistenciaEntrada']"), checkSabado);
        }

        public bool RetornarInfinitoDesistenciaEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[name='infinitoDesistenciaEntrada']"));
        }

        public void MarcarTratarCartoesFantasma(bool checkSabado)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='TratarCartoesFantasma']"), checkSabado);
        }

        public bool RetornarTratarCartoesFantasma()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='TratarCartoesFantasma']"));
        }

        public void MarcarRejeitarCartoesInconsistentes(bool checkSabado)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='RejeitarCartoesInconsistentes']"), checkSabado);
        }

        public bool RetornarRejeitarCartoesInconsistentes()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='RejeitarCartoesInconsistentes']"));
        }

        public void MarcarRealizarValidacaoEstadiaEntrada(bool checkSabado)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='RealizarValidacaoEstadiaEntrada']"), checkSabado);
        }

        public bool RetornarRealizarValidacaoEstadiaEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='RealizarValidacaoEstadiaEntrada']"));
        }

        public void MarcarPermitirEmissaoReciboImpressoraRemota(bool checkSabado)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirEmissaoReciboImpressoraRemota']"), checkSabado);
        }

        public bool RetornarPermitirEmissaoReciboImpressoraRemota()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirEmissaoReciboImpressoraRemota']"));
        }

        public void SelecionarAcaoCartaoSaldoNegativo(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexAcaoCartaoSaldoNegativo']"), valor.ToString());
        }

        public string RetornarAcaoCartaoSaldoNegativo()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexAcaoCartaoSaldoNegativo']"));
        }

        public void PreencherTempoTransitoEntreEquipamentos(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoTransitoEntreEquipamentos']"), valor.ToString());
        }

        public string RetornarTempoTransitoEntreEquipamentos()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoTransitoEntreEquipamentos']"));
        }

        public void MarcarInfinitoTransitoEntreEquipamentos(bool checkInfinito)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='infinitoTransitoEntreEquipamentos']"), checkInfinito);
        }

        public bool RetornarInfinitoTransitoEntreEquipamentos()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='infinitoTransitoEntreEquipamentos']"));
        }

        public void SelecionarTempoDeTransitoAPartir(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexTempoDeTransitoAPartir']"), valor.ToString());
        }

        public string RetornarTempoDeTransitoAPartir()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexTempoDeTransitoAPartir']"));
        }

        public void SelecionarAcaoTempoTransitoExcedido(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexAcaoTempoTransitoExcedido']"), valor.ToString());
        }

        public string RetornarAcaoTempoTransitoExcedido()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexAcaoTempoTransitoExcedido']"));
        }

        public void SelecionarConsiderarVeiculos(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexConsiderarVeiculos']"), valor.ToString());
        }

        public string RetornarConsiderarVeiculos()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexConsiderarVeiculos']"));
        }

        public void MarcarInformarPrismaEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='DigitarPrismaEntrada']"), check);
        }

        public bool RetornarInformarPrismaEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='DigitarPrismaEntrada']"));
        }

        public void MarcarInformarPlacaEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='DigitarPlacaEntrada']"), check);
        }

        public bool RetornarInformarPlacaEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='DigitarPlacaEntrada']"));
        }

        public void MarcarHabilitarPrismaIgualTicketEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarPrismaIgualTicketEntrada']"), check);
        }

        public bool RetornarHabilitarPrismaIgualTicketEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarPrismaIgualTicketEntrada']"));
        }

        public void MarcarUtilizarListaVeiculosModeloMarca(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='UtilizarListaVeiculosModeloMarca']"), check);
        }

        public bool RetornarUtilizarListaVeiculosModeloMarca()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='UtilizarListaVeiculosModeloMarca']"));
        }

        public void MarcarPermitirTicketAvulsoEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirTicketAvulsoEntrada']"), check);
        }

        public bool RetornarPermitirTicketAvulsoEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirTicketAvulsoEntrada']"));
        }

        public void MarcarReimprimirCodigoBarrasTicketEntradaCredenciado(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ReimprimirCodigoBarrasTicketEntradaCredenciado']"), check);
        }

        public bool RetornarReimprimirCodigoBarrasTicketEntradaCredenciado()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ReimprimirCodigoBarrasTicketEntradaCredenciado']"));
        }

        public void MarcarReimprimirCodigoBarrasTicketDevolucaoCredenciado(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ReimprimirCodigoBarrasTicketDevolucaoCredenciado']"), check);
        }

        public bool RetornarReimprimirCodigoBarrasTicketDevolucaoCredenciado()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ReimprimirCodigoBarrasTicketDevolucaoCredenciado']"));
        }

        public void MarcarHabilitarValidacaoEstadiaEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarValidacaoEstadiaEntrada']"), check);
        }

        public bool RetornarHabilitarValidacaoEstadiaEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarValidacaoEstadiaEntrada']"));
        }

        public void MarcarPermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida']"), check);
        }

        public bool RetornarPermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida']"));
        }

        public void MarcarExibirInformacaoLotadoDisplaySecundario(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ExibirInformacaoLotadoDisplaySecundario']"), check);
        }

        public bool RetornarExibirInformacaoLotadoDisplaySecundario()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ExibirInformacaoLotadoDisplaySecundario']"));
        }

        public void MarcarInformarLocalizacaoNaEntrada(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='InformarLocalizacaoNaEntrada']"), check);
        }

        public bool RetornarInformarLocalizacaoNaEntrada()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='InformarLocalizacaoNaEntrada']"));
        }

        public void SelecionarAcessoCarro(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexAcessoCarro']"), valor.ToString());
        }

        public string RetornarAcessoCarro()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexAcessoCarro']"));
        }

        public void SelecionarAcessoMoto(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexAcessoMoto']"), valor.ToString());
        }

        public string RetornarAcessoMoto()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexAcessoMoto']"));
        }
    }
}