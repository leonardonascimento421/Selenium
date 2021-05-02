
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Financeiro.IntegracaoTef
{
    public class IntegracaoTefPage : BasePage
    {
        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void SelecionarOperadoraTEF(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='OperadoraTEF']"), valor.ToString());
        }

        public string RetornarOperadoraTEF()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='OperadoraTEF']"));
        }

        public void SelecionarTipoDeReciboTEF(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='TextTipoReciboTEF']"), valor.ToString());
        }

        public string RetornarTipoDeReciboTEF()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='TextTipoReciboTEF']"));
        }

        public void PreencherIPdoServidor(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.EnderecoServidor']"), valor.ToString());
        }

        public string RetornarIPdoServidor()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.EnderecoServidor']"));
        }

        public void PreencherTimeoutDeComunicacao(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.Timeout']"), valor.ToString());
        }

        public string RetornarTimeoutDeComunicacao()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.Timeout']"));
        }

        public void MarcarImprimirViaDoClienteEmFormatoReduzido(bool checkConsultarVeiculos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.ImprimirViaClienteFormatoReduzido']"), checkConsultarVeiculos);
        }

        public bool RetornarImprimirViaDoClienteEmFormatoReduzido()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.ImprimirViaClienteFormatoReduzido']"));
        }

        public void PreencherCodigoDaLoja(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.CodigoLoja']"), valor.ToString());
        }

        public string RetornarCodigoDaLoja()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='ParametrosConfiguracaoOperadoraTEF.CodigoLoja']"));
        }


    }
}