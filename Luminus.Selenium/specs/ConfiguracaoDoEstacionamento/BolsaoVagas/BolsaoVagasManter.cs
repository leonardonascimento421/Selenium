using Gauge.CSharp.Lib.Attribute;
using Gauge.CSharp.Lib;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Implementation.Pages.ConfiguracaoDoEstacionamento
{
    public class BolsaoVagasManterPage : BasePage
    {
        public string RetornarCodigo()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Codigo]"));
        }

        public void PreencherCodigo(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Codigo]"), valor);
        }

        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Nome]"));
        }

        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Nome]"), valor.ToString());
        }

        public void PreencherQuantidade(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=QuantidadeVagas]"), valor);
        }

        public string RetornarQuantidade()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=QuantidadeVagas]"));
        }

        public void MarcarBloquearAcessoQuandoLotado(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='BloquearAcessoQuandoLotado']"), check);
        }

        public bool RetornarBloquearAcessoQuandoLotado()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='BloquearAcessoQuandoLotado']"));
        }

        public void MarcarHabilitarControleVagasPorSetor(bool check)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='HabilitarControleVagasSetor']"), check);
        }

        public bool RetornarHabilitarControleVagasPorSetor()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='HabilitarControleVagasSetor']"));
        }

    }
}
