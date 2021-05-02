using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Luminus.Selenium.specs.Manipulae
{
    class ManipulaePage : BasePage
    {
        public void ClicarBotaoCadastrar()
        {
            _driver.Click(By.XPath($"//p[contains(text(),'Cadastrar')]"));
            Thread.Sleep(1100);
        }

        public void PreencherEmail(string valor)
        {
            _driver.SetText(By.CssSelector("input[placeholder=E-mail]"), valor.ToString());
        }

        public void PreencherSenha(string valor)
        {
            _driver.SetText(By.CssSelector("input[placeholder=Senha]"), valor.ToString());
        }

        public void PreencherConfirmarSenha(string valor)
        {
            _driver.SetText(By.CssSelector("input[placeholder='Confirmar Senha']"), valor.ToString());
        }

        public void ClicarBotaoProximo()
        {
            _driver.Click(By.XPath($"//h3[contains(text(),'Próximo')]"));
            Thread.Sleep(1100);
        }

        public void PreencherNomeCompleto(string valor)
        {
            _driver.SetText(By.CssSelector("input[placeholder='Nome Completo']"), valor.ToString());
        }

        public void PreencherCelular(string valor)
        {
            _driver.SetText(By.CssSelector("input[placeholder='Celular']"), valor.ToString());
        }

        public void ClicarBotaoCadastrarFormulario()
        {
            _driver.Click(By.XPath($"//h3[contains(text(),'Cadastrar')]"));
            Thread.Sleep(1100);
        }
    }
}
