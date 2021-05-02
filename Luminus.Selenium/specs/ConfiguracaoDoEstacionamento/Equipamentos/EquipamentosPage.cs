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
using Luminus.Selenium.Implementation.Pages.Shared.Form;

namespace Luminus.Selenium.specs.ConfiguracaoDoEstacionamento.Equipamentos
{
    public class EquipamentosPage : BasePage
    {

        public void PreencherNumeroDoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Numero]"), valor.ToString());
        }

        public string RetornarNumeroDoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Numero]"));
        }

        public void PreencherNomeEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Nome]"), valor.ToString());
        }

        public string RetornarNomeEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Nome]"));
        }

        public void PreencherEnderecoIPEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=EnderecoIP]"), valor.ToString());
        }

        public string RetornarEnderecoIPEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=EnderecoIP]"));
        }

        public void PreencherMascaraIPEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=MascaraIP]"), valor.ToString());
        }

        public string RetornarMascaraIPEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=MascaraIP]"));
        }

        public void PreencherIPDoGatewayEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=IPGateway]"), valor.ToString());
        }

        public string RetornarIPDoGatewayEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=IPGateway]"));
        }

        public void MarcarHabilitadoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Habilitado']"), check);
        }

        public bool RetornarHabilitadoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Habilitado']"));
        }

        public void SelecionarAplicativoDoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Aplicativo.Id']"), valor);
        }

        public string RetornarAplicativoDoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='Aplicativo.Id']"));
        }

        public void MarcarFuncaoDeOperacaoValidacaoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='IsValidacao']"), check);
        }

        public bool RetornarFuncaoDeOperacaoValidacaoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='IsValidacao']"));
        }

        public void MarcarFuncaoDeOperacaoEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='IsEntrada']"), check);
        }

        public bool RetornarFuncaoDeOperacaoEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='IsEntrada']"));
        }

        public void MarcarFuncaoDeOperacaoSaidaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='IsSaida']"), check);
        }

        public bool RetornarFuncaoDeOperacaoSaidaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='IsSaida']"));
        }

        public void MarcarFuncaoDeOperacaoPassagemEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='IsPassagem']"), check);
        }

        public bool RetornarFuncaoDeOperacaoPassagemEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='IsPassagem']"));
        }

        public void MarcarSemLimiteTransacoesOffLineEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='SemLimiteTransacaoOffLine']"), check);
        }

        public bool RetornarSemLimiteTransacoesOffLineEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='SemLimiteTransacaoOffLine']"));
        }

        public string RetornarLimiteDeTransacoesOffLineEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=LimiteTransacoesOffLine]"));
        }

        public void PreencherNumeroDoSetorSpacenetEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=NumeroSetorSpacenet]"), valor.ToString());
        }

        public string RetornarNumeroDoSetorSpacenetEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=NumeroSetorSpacenet]"));
        }

        public void PreencherLimiteDeTransacoesOffLineEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=LimiteTransacoesOffLine]"), valor.ToString());
        }

        public string RetornarPreenchimentoDeLimiteDeTransacoesOffLineEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=LimiteTransacoesOffLine]"));
        }

        public void MarcarDigitarMidiaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.PermitirDigitacaoNumeroMidia']"), check);
        }

        public bool RetornarDigitarMidiaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.PermitirDigitacaoNumeroMidia']"));
        }

        public void MarcarMultiplasMedasEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.UtilizarMultiplasMoedas']"), check);
        }

        public bool RetornarMultiplasMedasEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.UtilizarMultiplasMoedas']"));
        }

        public void MarcarBloquearPagamentosEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.BloquearPagamentos']"), check);
        }

        public bool RetornarBloquearPagamentosEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.BloquearPagamentos']"));
        }

        public void PreencherPeriodoDeFuncionamentoDasEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='OperacaoAcesso.PeriodoFuncionamentoDe']"), valor.ToString());
        }

        public string RetornarPeriodoDeFuncionamentoDasEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='OperacaoAcesso.PeriodoFuncionamentoDe']"));
        }

        public void PreencherPeriodoDeFuncionamentoAsEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='OperacaoAcesso.PeriodoFuncionamentoAte']"), valor.ToString());
        }

        public string RetornarPeriodoDeFuncionamentoAsEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='OperacaoAcesso.PeriodoFuncionamentoAte']"));
        }

        public void MarcarPeriodoDeFuncionamentoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAcesso.SemPeriodoDefinido']"), check);
        }

        public bool RetornarMarcarPeriodoDeFuncionamentoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAcesso.SemPeriodoDefinido']"));
        }

        public void SelecionarModoDeAcionamentoDoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='OperacaoAcesso.IndexModoAcionamentoEquipamento']"), valor);
        }

        public string RetornarModoDeAcionamentoDoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='OperacaoAcesso.IndexModoAcionamentoEquipamento']"));
        }

        public void MarcarDeteccaoDeMotoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAcesso.DeteccaoDeMoto']"), check);
        }

        public bool RetornarDeteccaoDeMotoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAcesso.DeteccaoDeMoto']"));
        }

        public void MarcarAcessoPassagemEspecialEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAcesso.AcessoComoPassagemEspecial']"), check);
        }

        public bool RetornarAcessoPassagemEspecialEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAcesso.AcessoComoPassagemEspecial']"));
        }

        public void MarcarSomenteTagNeposEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAcesso.SomenteTagNepos']"), check);
        }

        public bool RetornarSomenteTagNeposEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAcesso.SomenteTagNepos']"));
        }

        public void MarcarPossuiEscapeGateModeEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAcesso.PossuiEscapeGateMode']"), check);
        }

        public bool RetornarPossuiEscapeGateModeEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAcesso.PossuiEscapeGateMode']"));
        }

        public void MarcarMultiplosequipamentosporacesso3oumaisEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAcesso.MultiposEquipamentosPorAcesso']"), check);
        }

        public bool RetornarMultiplosequipamentosporacesso3oumaisEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='OperacaoAcesso.MultiposEquipamentosPorAcesso']"));
        }

        public void SelecionarTipodeescapegatemodeEquipamentos(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='OperacaoAcesso.IndexTipoEscapeGateMode']"), valor);
        }

        public string RetornarTipodeescapegatemodeEquipamentos()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='OperacaoAcesso.IndexTipoEscapeGateMode']"));
        }

        public void SelecionarSentidodoescapegatemodeEquipamentos(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='OperacaoAcesso.IndexSentidoDoEscapeGateMode']"), valor);
        }

        public string RetornarSentidodoescapegatemodeEquipamentos()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='OperacaoAcesso.IndexSentidoDoEscapeGateMode']"));
        }

        public void SelecionartipoDeInformatizadoEquipamentos(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexTipoInformatizado']"), valor);
        }

        public string RetornartipoDeInformatizadoEquipamentos()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexTipoInformatizado']"));
        }

        public void MarcarutilizarMutiplasMoedasInformatizadoValidacaoEquipamentos(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.UtilizarMultiplasMoedas']"), check);
        }

        public void SelecionarNomeUsuarioSistemaEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='UsuarioInformatizadoVolante.Id']"), valor);
        }

        public string RetornarNomeUsuarioSistemaEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='UsuarioInformatizadoVolante.Id']"));
        }

        public void MarcarbloquearPagamentosInformatizadoValidacaoEquipamentos(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='OperacaoAtendimentoAssistido.BloquearPagamentos']"), check);
        }

        public void SelecionarNomeBolsaoDeVagasPrincipalEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='OperacaoAcesso.AcessoBolsaoPrincipal.Id']"), valor);
        }

        public string RetornarNomeBolsaoDeVagasPrincipalEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='OperacaoAcesso.AcessoBolsaoPrincipal.Id']"));
        }

        public void SelecionarNomeBolsaoDeVagasSecundarioEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='OperacaoAcesso.AcessoBolsaoSecundario.Id']"), valor);
        }

        public string RetornarNomeBolsaoDeVagasSecundarioEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='OperacaoAcesso.AcessoBolsaoSecundario.Id']"));
        }

        public void SelecionarEquipamentoEscapeGateModevinculadoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdEquipamentoVinculadoEscapeGateMode']"), valor);
        }

        public string RetornarEquipamentoEscapeGateModevinculadoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdEquipamentoVinculadoEscapeGateMode']"));
        }

        public void MarcarPossuicancelaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.PossuiCancela']"), check);
        }

        public bool RetornarPossuicancelaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.PossuiCancela']"));
        }

        public void MarcarPossuicancelaEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.PossuiCancela']"), check);
        }

        public bool RetornarPossuicancelaEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.PossuiCancela']"));
        }

        public void MarcarAutoparadaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.AutoParada']"), check);
        }

        public bool RetornarAutoparadaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.AutoParada']"));
        }

        public void MarcarAutoparadaEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.AutoParada']"), check);
        }

        public bool RetornarAutoparadaEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.AutoParada']"));
        }

        public void MarcarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.IniciaNovaTransacaoComVeiculoSobreOLacoDeFechamento']"), check);
        }

        public bool RetornarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.IniciaNovaTransacaoComVeiculoSobreOLacoDeFechamento']"));
        }

        public void MarcarInicianovatransacaocomveiculossobreolacodefechamentoEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.IniciaNovaTransacaoComVeiculoSobreOLacoDeFechamento']"), check);
        }

        public bool RetornarInicianovatransacaocomveiculossobreolacodefechamentoEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.IniciaNovaTransacaoComVeiculoSobreOLacoDeFechamento']"));
        }

        public void MarcarInicianovatransacaoaposfechamentototaldacancelaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.IniciaNovaTransacaoAposFechamentoTotalDaCancela']"), check);
        }

        public bool RetornarInicianovatransacaoaposfechamentototaldacancelaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.IniciaNovaTransacaoAposFechamentoTotalDaCancela']"));
        }

        public void MarcarInicianovatransacaoaposfechamentototaldacancelaEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.IniciaNovaTransacaoAposFechamentoTotalDaCancela']"), check);
        }

        public bool RetornarInicianovatransacaoaposfechamentototaldacancelaEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.IniciaNovaTransacaoAposFechamentoTotalDaCancela']"));
        }

        public void MarcarExistelacoparaacionamentodoequipamentoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.ExisteLacoParaAcionamentoEquipamento']"), check);
        }

        public bool RetornarExistelacoparaacionamentodoequipamentoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.ExisteLacoParaAcionamentoEquipamento']"));
        }

        public void MarcarExistelacoparaacionamentodoequipamentoEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.ExisteLacoParaAcionamentoEquipamento']"), check);
        }

        public bool RetornarExistelacoparaacionamentodoequipamentoEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.ExisteLacoParaAcionamentoEquipamento']"));
        }

        public void MarcarExistelacodefechamentodacancelaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.ExisteLacoDeFechamentoDaCancela']"), check);
        }

        public bool RetornarExistelacodefechamentodacancelaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.ExisteLacoDeFechamentoDaCancela']"));
        }

        public void MarcarExistelacodefechamentodacancelaEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.ExisteLacoDeFechamentoDaCancela']"), check);
        }

        public bool RetornarExistelacodefechamentodacancelaEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.ExisteLacoDeFechamentoDaCancela']"));
        }

        public void MarcarAguardarsinaldecancelafechadaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.AguardarSinalCancelaFechada']"), check);
        }

        public bool RetornarAguardarsinaldecancelafechadaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.AguardarSinalCancelaFechada']"));
        }

        public void MarcarAguardarsinaldecancelafechadaEntradaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.AguardarSinalCancelaFechada']"), check);
        }

        public bool RetornarAguardarsinaldecancelafechadaEntradaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.AguardarSinalCancelaFechada']"));
        }

        public void PreencherTempolimitepararespostadacancelasegEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.TempoLimiteParaRespostaCancelaSeg']"), valor.ToString());
        }

        public string RetornarTempolimitepararespostadacancelasegEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaSaida.TempoLimiteParaRespostaCancelaSeg']"));
        }

        public void PreencherTempolimitepararespostadacancelasegEntradaEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.TempoLimiteParaRespostaCancelaSeg']"), valor.ToString());
        }

        public string RetornarTempolimitepararespostadacancelasegEntradaEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoCancelaEntrada.TempoLimiteParaRespostaCancelaSeg']"));
        }

        public void SelecionarTipoDePerifericoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IndexTipoPeriferico']"), valor);
        }

        public string RetornarTipoDePerifericoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IndexTipoPeriferico']"));
        }

        public void MarcarPerifericoPrincipalEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PerifericoPrincipal']"), check);
        }

        public bool RetornarPerifericoPrincipalEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PerifericoPrincipal']"));
        }

        public void MarcarHabilitarPerifericoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Habilitar']"), check);
        }

        public bool RetornarHabilitarPerifericoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Habilitar']"));
        }

        public void SelecionarModeloPerifericoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexModelo']"), valor);
        }

        public string RetornarModeloPerifericoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexModelo']"));
        }

        public void PreencherPortaSerialEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PortaSerial']"), valor.ToString());
        }

        public void MarcarLaserContinuo1D2DEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLaserContinuo']"), check);
        }

        public bool RetornarLaserContinuo1D2DEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLaserContinuo']"));
        }

        public void MarcarLeituraSeloDescontoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLeituraDeSeloDeDesconto']"), check);
        }

        public bool RetornarLeituraSeloDescontoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLeituraDeSeloDeDesconto']"));
        }

        public void MarcarVerificarDigitoVerificador1D2DEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras']"), check);
        }

        public bool RetornarVerificarDigitoVerificador1D2DEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras']"));
        }

        public string RetornarPortaSerialEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PortaSerial']"));
        }

        public void PreencherEnderecoIPPopUpEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.EnderecoIP']"), valor.ToString());
        }

        public string RetornarEnderecoIPPopUpEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.EnderecoIP']"));
        }//

        public void RPreencherEnderecoMACImpressoraRemotaEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.MacAddress']"), valor.ToString());
        }

        public string RetornarEnderecoMACImpressoraRemotaEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.MacAddress']"));
        }

        public void PreencherMascaraIpPopUpEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.MascaraIP']"), valor.ToString());
        }

        public string RetornarMascaraIpPopUpEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.MascaraIP']"));
        }

        public void PreencherGatewayIpPopUpEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.IPGateway']"), valor.ToString());
        }

        public string RetornarGatewayIpPopUpEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.IPGateway']"));
        }

        public void SelecionarTipodeinstalacaooperacaodaleitoraantenatagequipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexTipoInstalacaoLeitoraAntena']"), valor);
        }

        public string RetornarTipodeinstalacaooperacaodaleitoraantenatagequipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexTipoInstalacaoLeitoraAntena']"));
        }

        public void PreencherCodigoInterfoneVoipEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Codigo']"), valor.ToString());
        }

        public string RetornarCodigoInterfoneVoipEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Codigo']"));
        }

        public void PreencherCanaldaantenaconectadoaoleitoraantenaequipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.CanalAntenaConectadaAoLeitor']"), valor.ToString());
        }

        public string RetornarCanaldaantenaconectadoaoleitoraantenaequipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.CanalAntenaConectadaAoLeitor']"));
        }

        public void PreencherIgnorarleituradamesmatagporsegequipamentos(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.IgnoraLeituraMesmaTagPorSeg']"), valor.ToString());
        }

        public string RetornarIgnorarleituradamesmatagporsegequipamentos()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.IgnoraLeituraMesmaTagPorSeg']"));
        }

        public void PreencherConsiderarleiturasrealizadashaatedecimosdesegequipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConsiderarLeituraEmDecimosSeg']"), valor.ToString());
        }

        public string RetornarConsiderarleiturasrealizadashaatedecimosdesegequipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConsiderarLeituraEmDecimosSeg']"));
        }

        public void SelecionarModeloDoBocalEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexModeloBocalLeitorMifare']"), valor);
        }

        public string RetornarModeloDoBocalEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexModeloBocalLeitorMifare']"));
        }

        public void PreencherTempoDeEsperaNaEsteiraEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.TempoEspera']"), valor.ToString());
        }

        public string RetornarTempoDeEsperaNaEsteiraEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.TempoEspera']"));
        }

        public void PreencherTempoDeAguardoParaEmissaoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.TempoSaida']"), valor.ToString());
        }

        public string RetornarTempoDeAguardoParaEmissaoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.TempoSaida']"));
        }

        public void SelecionarmodeloImpressoraValidacaoInformatizado(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexModelo']"), valor);
        }

        public void SelecionarTelaVgaResolucaoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexResolucaoTela']"), valor);
        }

        public string RetornarTelaVgaResolucaoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexResolucaoTela']"));
        }

        public void MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='MostrarDetalhesEsperaAposTeclaAcionada']"), check);
        }

        public bool RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='MostrarDetalhesEsperaAposTeclaAcionada']"));
        }

        public void MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='AlternarEntreMensagensDetalhesEspera']"), check);
        }

        public bool RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='AlternarEntreMensagensDetalhesEspera']"));
        }

        public void PreencherTempoParaMostrarDetalhesDeErroEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoParaMostrarDetalhesErro']"), valor.ToString());
        }

        public string RetornarTempoParaMostrarDetalhesDeErroEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoParaMostrarDetalhesErro']"));
        }

        public void PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoParaMostrarDetalhesEspera']"), valor.ToString());
        }

        public string RetornarTempoParaMostrarDetalhesDeEsperaEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoParaMostrarDetalhesEspera']"));
        }

        public void MarcarHabilitarValidacaoComCartaoDebito(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarValidacaoComCartaoDebito']"), check);
        }

        public bool RetornarHabilitarValidacaoComCartaoDebito()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarValidacaoComCartaoDebito']"));
        }

        public void MarcarHabilitarValidacaoEmDinheiro(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarValidacaoEmDinheiro']"), check);
        }

        public bool RetornarHabilitarValidacaoEmDinheiro()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarValidacaoEmDinheiro']"));
        }

        public void MarcarHabilitarLaserContinuo(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLaserContinuo']"), check);
        }

        public bool RetornarHabilitarLaserContinuo()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLaserContinuo']"));
        }

        public void MarcarHabilitarLeituraDeSeloDeDesconto(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLeituraDeSeloDeDesconto']"), check);
        }

        public bool RetornarHabilitarLeituraDeSeloDeDesconto()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarLeituraDeSeloDeDesconto']"));
        }

        public void MarcarHabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras']"), check);
        }

        public bool RetornarHabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.HabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras']"));
        }

        public void MarcarPermitirPagamentoComDinheiroNaTelaConsulta(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PermitirPagamentoComDinheiroNaTelaConsulta']"), check);
        }

        public bool RetornarPermitirPagamentoComDinheiroNaTelaConsulta()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PermitirPagamentoComDinheiroNaTelaConsulta']"));
        }

        public void MarcarHabilitarSinalizacaoPorLed(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.HabilitarSinalizacaoPorLed']"), check);
        }

        public bool RetornarHabilitarSinalizacaoPorLed()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.HabilitarSinalizacaoPorLed']"));
        }

        public void PreencherPortaSerialDoAceitadorCedulas(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoAceitadorCedulas']"), valor.ToString());
        }

        public string RetornarPortaSerialDoAceitadorCedulas()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoAceitadorCedulas']"));
        }

        public void PreencherPortaSerialDoDispensadorCedulas(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoDispensadorCedulas']"), valor.ToString());
        }

        public string RetornarPortaSerialDoDispensadorCedulas()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoDispensadorCedulas']"));
        }

        public void PreencherPortaSerialDoAceitadorMoedas(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoAceitadorMoedas']"), valor.ToString());
        }

        public string RetornarPortaSerialDoAceitadorMoedas()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoAceitadorMoedas']"));
        }

        public void PreencherPortaSerialDoDispensadorMoedas(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoDispensadorMoedas']"), valor.ToString());
        }

        public string RetornarPortaSerialDoDispensadorMoedas()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloFinanceiro.PortaSerialDoDispensadorMoedas']"));
        }

        public void MovimentarBarraRolagemAteBotaoAdicionar()
        {
            _driver.ScrollToElement(By.XPath($".//button[contains(.,'adicionar')]"));
        }

        public void PreencherNumeroLPRPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.NumeroLPR']"), valor.ToString());
        }

        public string RetornarNumeroLPRPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.NumeroLPR']"));
        }

        public void PreencherPortaLPRPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PortaLPR']"), valor.ToString());
        }

        public string RetornarPortaLPRPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PortaLPR']"));
        }

        public void PreencherPortaLPRSerialPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PortaEquipamento']"), valor.ToString());
        }

        public string RetornarPortaLPRSerialPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.PortaEquipamento']"));
        }

        public void PreencherUsuarioPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Usuario']"), valor.ToString());
        }

        public string RetornarUsuarioPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Usuario']"));
        }

        public void PreencherSenhaPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Senha']"), valor.ToString());
        }

        public string RetornarSenhaPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.Senha']"));
        }

        public void PreencherCaminhoArmazenamentoImagensPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("textarea[formcontrolname='ConfiguracaoPeriferico.CaminhoArmazenamentoImagens']"), valor.ToString());
        }

        public string RetornarCaminhoArmazenamentoImagensPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("textarea[formcontrolname='ConfiguracaoPeriferico.CaminhoArmazenamentoImagens']"));
        }

        public void PreencherTempoLimiteRespostaCameraPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.TempoLimiteRespostaCamera']"), valor.ToString());
        }

        public string RetornarTempoLimiteRespostaCameraPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.TempoLimiteRespostaCamera']"));
        }

        public void PreencherNumeroCapturasPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.NumeroCapturas']"), valor.ToString());
        }

        public string RetornarNumeroCapturasPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.NumeroCapturas']"));
        }

        public void PreencherQuantidadeMinimaCaracteresCoincidenciaPerifericoEquipamento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.QtdeMinimaCaracteresCoincidencia']"), valor.ToString());
        }

        public string RetornarQuantidadeMinimaCaracteresCoincidenciaPerifericoEquipamento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.QtdeMinimaCaracteresCoincidencia']"));
        }

        public void PreencherHabilitaConfiguracaoAutomaticaSenha(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloLPR.Senha']"), valor.ToString());
        }

        public string RetornarHabilitaConfiguracaoAutomaticaSenha()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloLPR.Senha']"));
        }

        public void PreencherHabilitaConfiguracaoAutomaticaPortaConfiguracao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloLPR.PortaConfiguracao']"), valor.ToString());
        }

        public string RetornarHabilitaConfiguracaoAutomaticaPortaConfiguracao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloLPR.PortaConfiguracao']"));
        }

        public void MarcarVerificaDivergenciaEntradaPerifericoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.VerificarDivergenciaPlacaEntrada']"), check);
        }

        public bool RetornarVerificaDivergenciaEntradaPerifericoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.VerificarDivergenciaPlacaEntrada']"));
        }

        public void MarcarReconhecimentoCameraListaNegraPerifericoEquipamento(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.UsarReconhecimentoListaNegra']"), check);
        }

        public bool RetornarReconhecimentoCameraListaNegraPerifericoEquipamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.UsarReconhecimentoListaNegra']"));
        }

        public void MarcarHabilitaConfiguracaoAutomatica(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloLPR.HabilitaConfiguracao']"), check);
        }

        public bool RetornarHabilitaConfiguracaoAutomatica()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ConfiguracaoPeriferico.ConfiguracaoModuloLPR.HabilitaConfiguracao']"));
        }

        public void SelecionarPontoCapturaPerifericoEquipamento(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexPontoCaptura']"), valor);
        }

        public string RetornarPontoCapturaPerifericoEquipamento()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ConfiguracaoPeriferico.IndexPontoCaptura']"));
        }
    }
}