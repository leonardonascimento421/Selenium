
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System.Collections.Generic;

namespace Luminus.Selenium.specs.Operacao.AgendamentoDeTarefasAutomatizadas
{
    public class AgendamentoDeTarefasAutomatizadasPage : BasePage
    {

        public void SelecionarTarefa(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='TarefaAutomatizada.Id']"), valor);
        }

        public string RetornarTarefa()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='TarefaAutomatizada.Id']"));
        }

        public void MarcarHabilitarNExecucoes(bool checkNExecucoes)
        {
          
            _driver.MarcarCheckBox(By.XPath("//label[contains(text(),'N Execuções')]"), checkNExecucoes);
        }

        public bool RetornarHabilitarNExecucoes()
        {
            return _driver.GetCheck(By.XPath("//label[contains(text(),'N Execuções')]"));
        }

        public void PreencherDataInicioValidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataInicioValidade']"), valor.ToString());
        }

        public string RetornarDataInicioValidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DataInicioValidade']"));
        }

        public void PreencherDataTerminoValidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataTerminoValidade']"), valor.ToString());
        }

        public string RetornarDataTerminoValidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='DataTerminoValidade']"));
        }

        public void MarcarSemDataTerminoValidade(bool check)
        {

            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='SemDataTerminoValidade']"), check);
        }

        public bool RetornarSemDataTerminoValidade()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='SemDataTerminoValidade']"));
        }

        public void PreencherHoraInicioValidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='HoraInicioValidade']"), valor.ToString());
        }

        public string RetornarHoraInicioValidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='HoraInicioValidade']"));
        }

        public void PreencherHoraTerminoValidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='HoraTerminoValidade']"), valor.ToString());
        }

        public string RetornarHoraTerminoValidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='HoraTerminoValidade']"));
        }

        public void PreencherTempoEsperaEntreRepeticoesEmMinutos(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TempoEsperaEntreRepeticoesEmMinutos']"), valor.ToString());
        }

        public string RetornarTempoEsperaEntreRepeticoesEmMinutos()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TempoEsperaEntreRepeticoesEmMinutos']"));
        }

        public void MarcarExecutarEmCasoErro(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ExecutarEmCasoErro']"), check);
        }

        public bool RetornarExecutarEmCasoErro()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ExecutarEmCasoErro']"));
        }

        public void MarcarUtilizarHorarioViradaOperacional(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ParametroEspecificoObject.UtilizarHorarioViradaOperacional']"), check);
        }

        public bool RetornarUtilizarHorarioViradaOperacional()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ParametroEspecificoObject.UtilizarHorarioViradaOperacional']"));
        }

        public void PreencherTempoEstadiaUtilizado(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ParametroEspecificoObject.TempoEstadiaUtilizado']"), valor.ToString());
        }

        public string RetornarTempoEstadiaUtilizado()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ParametroEspecificoObject.TempoEstadiaUtilizado']"));
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

        public void SelecionarTipoOcorrencia(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ParametroEspecificoObject.TipoOcorrencia.Id']"), valor.ToString());
        }

        public string RetornarTipoOcorrencia()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='ParametroEspecificoObject.TipoOcorrencia.Id']"));
        }

        public void PreencherJustificativaTipoOcorrencia(string valor)
        {
            _driver.SetText(By.CssSelector("textarea[formcontrolname='ParametroEspecificoObject.JustificativaTipoOcorrencia']"), valor.ToString());
        }

        public string RetornarJustificativaTipoOcorrencia()
        {
            return _driver.GetText(By.CssSelector("textarea[formcontrolname='ParametroEspecificoObject.JustificativaTipoOcorrencia']"));
        }

        public void MarcarAtivo(bool checkAtivo)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Ativo']"), checkAtivo);
        }

        public bool RetornarAtivo()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='Ativo']"));
        }

    }
}