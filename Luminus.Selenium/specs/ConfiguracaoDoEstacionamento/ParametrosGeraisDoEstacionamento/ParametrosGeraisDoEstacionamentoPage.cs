
using Gauge.CSharp.Lib.Attribute;
using Gauge.CSharp.Lib;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium.Support.PageObjects;



namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ParametrosGeraisDoEstacionamento


{
    public class ParametrosGeraisDoEstacionamentoPage : BasePage
    {
        public string RetornarenderecoIpDoServidorLuminusParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=EnderecoIP]"));
        }

        public void PreencherenderecoIpDoServidorLuminusParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=EnderecoIP]"), valor);
        }

        public string RetornarportaIpDoServidorLuminusParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=PortaIp]"));
        }

        public void PreencherportaIpDoServidorLuminusParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=PortaIp]"), valor);
        }

        public string RetornartempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=TempoLimiteTransacoesOnline]"));
        }

        public void PreenchertempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=TempoLimiteTransacoesOnline]"), valor);
        }

        public string RetornartempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=TempoLimiteRecebimentoMensagensBarramento]"));
        }

        public void PreenchertempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=TempoLimiteRecebimentoMensagensBarramento]"), valor);
        }

        public string RetornartempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=TempoLimiteEnvioMensagensBarramento]"));
        }

        public void PreenchertempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=TempoLimiteEnvioMensagensBarramento]"), valor);
        }

        public void SelecionaridiomaParametrosGerais(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname=Idioma]"), valor);
        }

        public string RetornaridiomaParametrosGerais()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='Idioma']"));
        }

        public string RetornarhorarioDeViradaOperacionalParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=HorarioViradaOperacional]"));
        }

        public void PreencherhorarioDeViradaOperacionalParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=HorarioViradaOperacional]"), valor);
        }

        public void MarcartratarCartoesFantasmasParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='TratarCartoesFantasmas']"), check);
        }

        public bool RetornartratarCartoesFantasmasParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='TratarCartoesFantasmas']"));
        }

        public void MarcartratarCartoesFantasmasParaEscapeParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='TratarCartoesFantasmasEscape']"), check);
        }

        public bool RetornartratarCartoesFantasmasParaEscapeParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='TratarCartoesFantasmasEscape']"));
        }

        public void MarcaroperacaoComMidiasComNumeracaoFixaParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoMidiasNumeracaoFixa']"), check);
        }

        public bool RetornaroperacaoComMidiasComNumeracaoFixaParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoMidiasNumeracaoFixa']"));
        }

        public void MarcarhabilitarConsultaOnLineDeValidacoesParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarConsultaOnlineValidacoes']"), check);
        }

        public bool RetornarhabilitarConsultaOnLineDeValidacoesParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarConsultaOnlineValidacoes']"));
        }

        public void MarcarpermitirCriaaoDeRegrasDeAcessoEspecificasNosContratosDeEstadiaParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirControleAcessoEspecificoPorUsuario']"), check);
        }

        public bool RetornarpermitirCriaaoDeRegrasDeAcessoEspecificasNosContratosDeEstadiaParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirControleAcessoEspecificoPorUsuario']"));
        }

        public void MarcararredondarValorEstadiaParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ArredondarValorEstadia']"), check);
        }

        public bool RetornararredondarValorEstadiaParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ArredondarValorEstadia']"));
        }

        public void MarcarutilizarSegundosNosCalculosDeEstadiaParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='UtilizarSegundosNosCalculosEstadia']"), check);
        }

        public bool RetornarutilizarSegundosNosCalculosDeEstadiaParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='UtilizarSegundosNosCalculosEstadia']"));
        }

        public void MarcarpermitirLoginDeOperadorOffLineParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermiteLoginOperadorOffline']"), check);
        }

        public bool RetornarpermitirLoginDeOperadorOffLineParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermiteLoginOperadorOffline']"));
        }

        public void MarcarpermitirOperacaoEmContingenciaParaMidiaCodigoDeBarrasParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='PermitirOperacaoContigenciaParaMidiaCodigoBarras']"), check);
        }

        public bool RetornarpermitirOperacaoEmContingenciaParaMidiaCodigoDeBarrasParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='PermitirOperacaoContigenciaParaMidiaCodigoBarras']"));
        }

        public void MarcarverificarGravacaoMifareParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='VerificarGravacaoMifare']"), check);
        }

        public bool RetornarverificarGravacaoMifareParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='VerificarGravacaoMifare']"));
        }

        public void MarcarhabilitarApenasSelosDeDescontosGerenciadosParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarApenasSelosDescontosGerenciados']"), check);
        }

        public bool RetornarhabilitarApenasSelosDeDescontosGerenciadosParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarApenasSelosDescontosGerenciados']"));
        }

        public string RetornardataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=DataBaseDataImpressaSeloDesconto]"));
        }

        public void PreencherdataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=DataBaseDataImpressaSeloDesconto]"), valor);
        }

        public string RetornartempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=TempoVerificacoesOcupacaoPatio]"));
        }

        public void PreenchertempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=TempoVerificacoesOcupacaoPatio]"), valor);

        }

        public string RetornarquantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=QtdeVerificacoesConsiderarOffline]"));
        }

        public void PreencherquantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=QtdeVerificacoesConsiderarOffline]"), valor);
        }

        public void SelecionarcomportamentoSeTempoExcedidoParametrosGerais(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname=ComportamentoTempoExcedido]"), valor);
        }

        public string RetornarcomportamentoSeTempoExcedidoParametrosGerais()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ComportamentoTempoExcedido']"));
        }


        public void SelecionarnomeBolsaoDeVagas(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname=IdBolsaoVagasOsa]"), valor);
        }

        public string RetornarnomeBolsaoDeVagas()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdBolsaoVagasOsa']"));
        }

        public void MarcarbloquearPlacasDiferentesNaSaidaParametrosGerais(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='BloquearPlacaDiferenteSaida']"), check);
        }

        public bool RetornarbloquearPlacasDiferentesNaSaidaParametrosGerais()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='BloquearPlacaDiferenteSaida']"));
        }

        public string RetornarquantidadeMaximaDeCaracteresDiferentesParametrosGerais()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=QtdeCaracteresDiferentesPermitidosPlacaSaida]"));
        }

        public void PreencherquantidadeMaximaDeCaracteresDiferentesParametrosGerais(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=QtdeCaracteresDiferentesPermitidosPlacaSaida]"), valor);

        }
    }
}