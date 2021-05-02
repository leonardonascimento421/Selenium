using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.Implementation.Pages.Shared.Form
{
    public class MensagemPage : BasePage
    {

        /// <summary>
        /// Retorna uma lista de mesagens da página (Erro / Sucesso)
        /// </summary>
        /// <returns></returns>
        public List<string> ListarMensagens()
        {
            List<string> lista = new List<string>();
            WebDriverExtensions.AguardarLoading(_driver);
            WebDriverWait wait = new WebDriverWait(_driver, WebDriverExtensions.Timeout);
            var webElement = wait.Until(x => x.FindElements(By.XPath("//*/np-mensagem-alerta//p")));

            foreach (var elemento in webElement)
            {
                lista.Add(elemento.Text);
            }

            return lista;
        }

        public List<string> ListarMensagensPortal(string msg)
        {
            List<string> lista = new List<string>();
            WebDriverExtensions.AguardarLoading(_driver);
            WebDriverWait wait = new WebDriverWait(_driver, WebDriverExtensions.Timeout);
            var webElement = wait.Until(x => x.FindElements(By.XPath($"//span[contains(text(),'{msg}')]")));

            foreach (var elemento in webElement)
            {
                lista.Add(elemento.Text);
            }

            return lista;
        }

        public List<string> ListarMensagensDeErroNoCampo(By by)
        {
            By byError = By.CssSelector(".help-block.error-container");
            By byFinal;

            if (by == null)
                byFinal = byError;
            else
                byFinal = new ByChained(by, byError);

            List<string> lista = new List<string>();
            WebDriverExtensions.AguardarLoading(_driver);
            WebDriverWait wait = new WebDriverWait(_driver, WebDriverExtensions.Timeout);
            var webElement = wait.Until(x => x.FindElements(byFinal));

            foreach (var elemento in webElement)
            {
                lista.Add(elemento.Text);
                elemento.Highlight();
            }

            return lista;
        }

        public List<string> ListarMensagensDeErroNoCampo()
        {
            return ListarMensagensDeErroNoCampo(null);
        }
    }
}
