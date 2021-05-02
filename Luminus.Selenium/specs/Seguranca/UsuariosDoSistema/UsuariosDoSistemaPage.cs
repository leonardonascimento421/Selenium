
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Seguranca.UsuariosDoSistema
{
    public class UsuariosDoSistemaPage : BasePage
    {

        public void PreenchernomeUsuarioSistema(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Nome]"), valor.ToString());
        }

        public string RetornarnomeUsuarioSistema()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Nome]"));
        }

        public void PreencheremailUsuarioSistema(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=Email]"), valor.ToString());
        }

        public string RetornaremailUsuarioSistema()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname=Email]"));
        }

        public void PreencherloginUsuarioSistema(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Login']"), valor.ToString());
        }

        public string RetornarloginUsuarioSistema()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Login']"));
        }

        public void PreenchercelularUsuarioSistema(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Celular']"), valor.ToString());
        }

        public string RetornarcelularUsuarioSistema()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Celular']"));
        }

        public void SelecionarnomePerfilPerfisAcessoSistema(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='PerfilAcessoId']"), valor);
        }

        public string RetornarnomePerfilPerfisAcessoSistema()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='PerfilAcessoId']"));
        }

        public void EscolherArquivoImagem(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Arquivo']"), valor);
        }

        public void PreenchersenhaPrimeiroAcessoUsuarioSistema(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CredencialAcessoSistemaSenha.Senha']"), valor.ToString());
        }

        public void PreencherconfirmacaoSenhaUsuarioSistema(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfirmacaoSenha']"), valor.ToString());
        }

        public void Preenchercodigodocartaooperadorcartaooperador(string valor)
        {
            _driver.SetText(By.CssSelector("input[npi18n='numero']"), valor.ToString());
        }

        public void Preenchersenhadocartaocartaooperador(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NovaSenha']"), valor.ToString());
        }

        public void Preencherconfirmacaodasenhacartaooperador(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='ConfirmacaoSenha']"), valor.ToString());
        }

        public void Preencherniveloperadorcartaooperador(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NivelOperador']"), valor.ToString());
        }

        public void Preencherdataexpiracaocartaooperador(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='DataExpiracao']"), valor.ToString()); 
        }

        public void SelecionarnomeClienteDoEstacionamentoCNPJ(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='ParceiroEstacionamento.Cliente.Id']"), valor);
        }

        public string RetornarnomeClienteDoEstacionamentoCNPJ()
        {
           return _driver.GetSelect(By.CssSelector("select[formcontrolname='ParceiroEstacionamento.Cliente.Id']"));
        }                

        public void MarcarusuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento(bool usuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='ParceiroEstacionamento.UsuarioPodeAplicarMultiplosSelosDesconto']"), usuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento);
        }

        public bool RetornarusuarioPodeAplicarMultiplosDescontosClienteDoEstacionamento()
        {
            return _driver.GetCheck(By.CssSelector("input[formcontrolname='ParceiroEstacionamento.UsuarioPodeAplicarMultiplosSelosDesconto']"));

        }

    }
}