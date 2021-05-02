using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Utils
{
    public static class WebDriverExtensions
    {

        public static TimeSpan Timeout = TimeSpan.FromSeconds(30);
        public static TimeSpan TimeoutAposClick = TimeSpan.FromSeconds(1);

        #region LoadPage
        /// <summary>
        /// Carrega uma página com timeout de 2 minutos
        /// </summary>
        /// <param name="webDriver">Driver</param>
        /// <param name="url">URL</param>
        public static void LoadPage(this IWebDriver webDriver, string url)
        {
            LoadPage(webDriver, TimeSpan.FromMinutes(5), url);
        }
        #endregion

        #region LoadPage
        /// <summary>
        /// Carrega uma página com timeout de acordo com o parâmetro
        /// </summary>
        /// <param name="webDriver">Driver</param>
        /// <param name="timeToWait">Tempo de timeout</param>
        /// <param name="url">URL</param>
        public static void LoadPage(this IWebDriver webDriver,
            TimeSpan timeToWait, string url)
        {
            Console.WriteLine($"Url navegação: {url}");
            webDriver.Manage().Timeouts().PageLoad = timeToWait;
            webDriver.Navigate().GoToUrl(url);
            Console.WriteLine($"Url após navegação: {webDriver.Url}");
            EventHubHelper.Publish(Events.Navigated, webDriver.Url);
            AguardarLoading(webDriver);
        }
        #endregion

        public static void ClicarMenuContextoTabela(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Highlight();
            webElement.Click();
            AguardarLoading(webDriver);
        }

        public static string GetText(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElement(webDriver);
            webElement.Highlight();
            return webElement.GetAttribute("value");
        }
        
        public static string GetSelect(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElement(webDriver);
            webElement.Highlight();
            SelectElement select = new SelectElement(webElement);
            return select.SelectedOption.Text?.Trim();
        }

        public static IEnumerable<string> GetSelectedItems(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElement(webDriver);
            webElement.Highlight();
            SelectElement select = new SelectElement(webElement);
            return select.AllSelectedOptions.Select(x => x.Text).ToList();
        }

        public static IEnumerable<string> GetItems(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElement(webDriver);
            webElement.Highlight();
            SelectElement select = new SelectElement(webElement);
            return select.Options.Select(x => x.Text).ToList();
        }

        public static string GetLinkText(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElement(webDriver);
            webElement.Highlight();
            return webElement.GetAttribute("text");
        }

        public static bool GetCheck(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElement(webDriver);
            webElement.Highlight();
            string check = webElement.GetAttribute("checked");
            return check == "true";
        }


        public static void SetText(this IWebDriver webDriver,
            By by, string text)
        {
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Highlight();
            if (webElement.Enabled)
            {
                webElement.Clear();
                webElement.SendKeys(text);
            }
        }

        public static void SetText(this IWebDriver webDriver,
    By by, string text, int indice)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElements(by)[indice];
            webElement.Highlight();
            webElement.ScrollToElement(webDriver);
            webElement.Clear();
            webElement.SendKeys(text);
            AguardarLoading(webDriver);
        }

        public static void SelecionarArquivo(this IWebDriver webDriver, By by, string arquivo)
        {

            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);            
            webElement.Highlight();
            webElement.ScrollToElement(webDriver);
            webElement.SendKeys(arquivo);
            AguardarLoading(webDriver);
        }

        public static IWebElement Click(this IWebDriver webDriver, By by, TimeSpan timeout = default(TimeSpan))
        {
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Highlight();

            EventHubHelper.Publish(Events.BeforeClick, webElement);
            // refresh no posicionamento do elemento
            webElement = webDriver.FindElement(by);
            webElement.Click();
            EventHubHelper.Publish(Events.AfterClick, webElement);
            // TODO: Revisar Sleep para removê-lo
            Thread.Sleep((int)TimeoutAposClick.TotalMilliseconds);
            return webElement;
        }

        public static void Click(this IWebDriver webDriver, By by, bool check, string nome)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);

            IList<IWebElement> elements = webDriver.FindElements(by);
            String[] allElements = new String[elements.Count + 1];
            int i = 0;
            foreach (IWebElement elemento in elements)
            {
                allElements[i++] = elemento.Text;

                if (elemento.Text == nome)

                    if (elemento.Selected && !check || !elemento.Selected && check)
                    {
                        webElement.Highlight();
                        EventHubHelper.Publish(Events.BeforeClick, webElement);
                        elemento.Click();
                        EventHubHelper.Publish(Events.AfterClick, webElement);
                        AguardarLoading(webDriver);
                        return;
                    }
            }
        }

        public static void Click_(this IWebDriver webDriver, By by, bool check)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            if (check && webElement.Selected)
            {
                webElement.Highlight();
                EventHubHelper.Publish(Events.BeforeClick, webElement);
                webElement.Click();
                EventHubHelper.Publish(Events.AfterClick, webElement);
                AguardarLoading(webDriver);
            }
        }

        public static void SelecionarCombo(this IWebDriver webDriver, By by, string textoDropDown)
        {
            AguardarLoading(webDriver);            
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Highlight();
            var select = new SelectElement(webElement);
            webElement.ScrollToElement(webDriver);
            select.SelectByText(textoDropDown);
            AguardarLoading(webDriver);
        }

        public static void SelecionarOption(this IWebDriver webDriver, By by, string textoDropDown)
        {
            AguardarLoading(webDriver);            
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Highlight();
            webElement.ScrollToElement(webDriver);
            webElement.Click();
            AguardarLoading(webDriver);
        }


        public static void MarcarCheckBox(this IWebDriver webDriver, By by, bool check)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Highlight();
            webElement.ScrollToElement(webDriver);
            if ((check && !webElement.Selected) || (!check && webElement.Selected))
                webElement.Click();
            AguardarLoading(webDriver);
        }



        private static void AguardarLoad(IWebDriver driver, string componente, IWait<IWebDriver> wait)
        {
            By loadingImageFull = By.CssSelector(componente);
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(loadingImageFull));
        }

        public static void AguardarLoading(this IWebDriver driver)
        {
            AguardarLoading(driver, 0, null);
        }

        public static void AguardarLoading(this IWebDriver driver, TimeSpan timeout)
        {
            var wait = new WebDriverWait(driver, timeout == default(TimeSpan) ? Timeout : timeout);
            AguardarLoading(driver, 0, wait);
        }

        public static void AguardarLoading(this IWebDriver driver, int contador, IWait<IWebDriver> wait = null)
        {
            if (wait == null)
                wait = new WebDriverWait(driver, Timeout);

            DateTime inicio = DateTime.Now;

            wait.Until(driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            if (!driver.Url.Contains("/login") && !driver.Url.Contains(":4400"))
            {
                By loadingImageFull = By.CssSelector("app-main-layout");
                wait.Until(ExpectedConditions.ElementExists(loadingImageFull));
            }       

            AguardarLoad(driver, ".np-loader-full--component", wait);
            AguardarLoad(driver, ".np-loader-secao--component", wait);
            AguardarLoad(driver, ".np-loader-tabela--component", wait);
            AguardarLoad(driver, ".np-loader-model--component", wait);
            AguardarLoad(driver, ".np-loader-campo--directive", wait);
            AguardarLoad(driver, ".np-loader-full--component", wait);
            AguardarLoad(driver, ".placeholder", wait);
            AguardarLoad(driver, ".np-loading", wait);
          

            AguardarLoadModal(driver, wait);

            DateTime fim = DateTime.Now;
            TimeSpan diff2 = fim - inicio;

            System.Diagnostics.Debug.WriteLine(diff2.Milliseconds);

            if (diff2.Milliseconds > 500)
                AguardarLoading(driver, contador + 1, wait);
        }

        private static void AguardarLoadModal(IWebDriver driver, IWait<IWebDriver> wait)
        {
            By byModal = By.CssSelector(".modal.in");
            if (ElementExists(byModal, driver))
            {
                var el = wait.Until(ExpectedConditions.ElementToBeClickable(byModal));
                wait.Until(x =>
                    driver.FindElements(By.CssSelector(".modal.in[opened]"))?.Count == 1 ||
                    (el.GetCssValue("opacity") == "1" && WaitElementStopMoving(byModal, driver, wait)));

                el = driver.FindElement(byModal);
                if (string.IsNullOrWhiteSpace(el.GetAttribute("opened")))
                    el.SetAttribute("opened", "");
            }

            By byModalFechado = By.CssSelector(".modal:not(.in)");
            if (ElementExists(byModalFechado, driver))
            {
                AguardarLoad(driver, ".modal:not(.in)", wait);

                var lstEl = driver.FindElements(By.CssSelector(".modal:not(.in)[opened]"));
                if (lstEl?.Count > 0)
                    foreach (var el in lstEl)
                        el.RemoveAttribute("opened");
            }
        }

        public static IWebElement SetAttribute(this IWebElement element, string name, string value)
        {
            var driver = ((IWrapsDriver)element).WrappedDriver;
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2]);", element, name, value);

            return element;
        }

        public static IWebElement RemoveAttribute(this IWebElement element, string name)
        {
            var driver = ((IWrapsDriver)element).WrappedDriver;
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].removeAttribute(arguments[1]);", element, name);

            return element;
        }

        private static bool ElementExists(By by, IWebDriver driver)
        {
            return driver.FindElements(by).Count > 0;
        }

        private static bool WaitElementStopMoving(By by, IWebDriver driver, IWait<IWebDriver> wait)
        {
            return wait.Until(x =>
            {
                bool stoped = !ElementMoved(by, driver, 50);

                if (stoped)
                    // Executando de novo para garantir que não está se movendo e não foi apenas uma parada
                    stoped = !ElementMoved(by, driver, 2000);

                return stoped;
            });
        }

        private static bool ElementMoved(By by, IWebDriver driver, int waitMoviment)
        {
            var element = driver.FindElement(by);

            var point = element.Location;

            Thread.Sleep(waitMoviment);

            element = driver.FindElement(by);

            var point2 = element.Location;

            return !point.Equals(point2);
        }

        public static IWebElement Click(this IWebDriver webDriver, By by, IWebElement parentElement)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = parentElement == null ? webDriver.FindElement(by) : parentElement.FindElement(by);
            webElement.Highlight();
            webElement.ScrollToElement(webDriver);

            EventHubHelper.Publish(Events.BeforeClick, webElement);
            // refresh no posicionamento do elemento
            webElement = parentElement == null ? webDriver.FindElement(by) : parentElement.FindElement(by);
            webElement.ScrollToElement(webDriver);
            webElement.Click();
            EventHubHelper.Publish(Events.AfterClick, webElement);

            AguardarLoading(webDriver);
            return webElement;
        }

        public static void Click(this IWebDriver webDriver, By by, int indice)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElements(by)[indice];
            webElement.Highlight();
            webElement.ScrollToElement(webDriver);

            EventHubHelper.Publish(Events.BeforeClick, webElement);
            // refresh no posicionamento do elemento
            webElement = webDriver.FindElements(by)[indice];
            webElement.Click();
            EventHubHelper.Publish(Events.AfterClick, webElement);

            AguardarLoading(webDriver);
        }

        public static void Submit(this IWebDriver webDriver, By by)
        {
            IWebElement webElement = webDriver.FindElement(by);
            webElement.Highlight();
            webElement.ScrollToElement(webDriver);

            AguardarLoading(webDriver);

            EventHubHelper.Publish(Events.BeforeClick, webElement);
            // refresh no posicionamento do elemento
            webElement = webDriver.FindElement(by);

            if (!(webDriver is InternetExplorerDriver))

                webElement.Submit();

            else
                webElement.SendKeys(Keys.Enter);

            EventHubHelper.Publish(Events.AfterClick, webElement);
            //EJMThread.Sleep(500);

            AguardarLoading(webDriver);


        }

        public static bool ValidarConfiguracao(this IWebDriver webDriver, By by, string parametro)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);

            IList<IWebElement> elements = webDriver.FindElements(by);
            String[] allElements = new String[elements.Count + 1];
            int i = 0;
            foreach (IWebElement elemento in elements)
            {
                allElements[i++] = elemento.Text;
                if (elemento.Text == parametro)
                    return true;
            }
            return false;
        }

        /*Testar metodo para Listar parametros*/
        public static List<string> ListarParametros(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IList<IWebElement> all = webDriver.FindElements(by);
            List<string> allText = new List<string>();
            foreach (IWebElement elemento in all)
            {
                allText.Add(elemento.Text);
            }
            return allText;
        }

        //metodo para detalhar alterar e excluir 
        //tela.ClicarMenuContexto("PASSAGEM", "detalhar");

        public static void ClicarMenuContexto(this IWebDriver webDriver, string opcao, string acao)
        {
            AguardarLoading(webDriver);
            var _opcao = opcao;
            var _acao = acao;
            var comando = $"//div//table/tbody//tr//td//span[contains(text(),'{_opcao}')]/ancestor::tr//";

            IWebElement menu = webDriver.FindElement(By.XPath($"{comando}td//np-menu-contexto"));
            menu.Highlight();
            menu.Click();
            IWebElement selecao = webDriver.FindElement(By.XPath($"{comando}ul//li//a[contains(text(),'{_acao}')]"));
            selecao.Highlight();
            selecao.Click();

            switch (_acao)
            {
                case "detalhar":

                    AguardarLoading(webDriver);
                    IWebElement detalhar = webDriver.FindElement(By.CssSelector("button[type='button']"));
                    detalhar.Highlight();
                    EventHubHelper.Publish(Events.BeforeClick, detalhar);
                    detalhar.Click();
                    EventHubHelper.Publish(Events.AfterClick, detalhar);
                    break;

                case "alterar":

                    AguardarLoading(webDriver);
                    break;

                case "excluir":

                    AguardarLoading(webDriver);
                    IWebElement excluir = webDriver.FindElement(By.CssSelector("button[type='submit']"));

                    excluir.Highlight();
                    EventHubHelper.Publish(Events.BeforeClick, excluir);
                    excluir.Click();
                    EventHubHelper.Publish(Events.AfterClick, excluir);
                    break;
            }


        }

        //Menu contexto para Periferico
        public static void ClicarMenuContextoPerifericos(this IWebDriver webDriver, string opcao, string acao)
        {
            AguardarLoading(webDriver);
            var _opcao = opcao;
            var _acao = acao;
            var comando = $"//div//table/tbody//tr//td[contains(text(),'{_opcao}')]/ancestor::tr//";

            IWebElement menu = webDriver.FindElement(By.XPath($"{comando}td//np-menu-contexto"));
            menu.Highlight();
            menu.Click();
            IWebElement selecao = webDriver.FindElement(By.XPath($"{comando}ul//li//a[contains(text(),'{_acao}')]"));
            selecao.Highlight();
            selecao.Click();

            switch (_acao)
            {
                case "detalhar":

                    AguardarLoading(webDriver);
                    IWebElement detalhar = webDriver.FindElement(By.CssSelector("button[type='button']"));
                    detalhar.Highlight();

                    EventHubHelper.Publish(Events.BeforeClick, detalhar);
                    detalhar.Click();
                    EventHubHelper.Publish(Events.AfterClick, detalhar);
                    break;

                case "alterar":

                    AguardarLoading(webDriver);
                    break;

                case "excluir":

                    AguardarLoading(webDriver);
                    IWebElement excluir = webDriver.FindElement(By.CssSelector("button[type='submit']"));
                    excluir.Highlight();

                    EventHubHelper.Publish(Events.BeforeClick, excluir);
                    excluir.Click();
                    EventHubHelper.Publish(Events.AfterClick, excluir);
                    break;
            }
        }

        public static IWebElement GetElement(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            return webDriver.FindElement(by);
        }

        public static string GetColumnText(this IWebDriver webDriver, By tableSelector, string headerValue, int rowNumber)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(tableSelector);

            return GetColumnText(webDriver, webElement, headerValue, rowNumber);
        }

        public static string GetColumnText(this IWebDriver webDriver, IWebElement table, string headerValue, int rowNumber)
        {
            var byHeader = By.CssSelector("th");
            var headers = table.FindElements(byHeader);
            var header = headers.FirstOrDefault(x => x.Text == headerValue);

            if (header == null)
                throw new Exception($"Não foi possível encontrar o cabeçalho da tabela pelo seletor: {byHeader.ToString()}");

            int columnIndex = headers.IndexOf(header) + 1;
            var byColumn = By.XPath($".//tr[{rowNumber}]/td[{columnIndex}]");
            var td = table.FindElement(byColumn);

            return td.Text;
        }

        public static IEnumerable<IWebElement> GetElements(this IWebDriver webDriver, By by)
        {            
            var webElements =  webDriver.FindElements(by);
            foreach (var webElement in webElements)
            {
                webElement.Highlight();
                webElement.ScrollToElement(webDriver);
            }
           
            return webElements;
        }

        public static void ScrollToElement(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElement(webDriver);
        }

        private static void ScrollToElement(this IWebElement webElement, IWebDriver webDriver)
        {
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(false);", webElement);
            AguardarLoading(webDriver);
        }

        public static string IsAttributePresent(this IWebDriver driver, string name, By by)
        {
            IWebElement webElement = driver.FindElement(by);

            return webElement.GetAttribute(name) != null ? "true" : "false";
        }

        public static void ScrollToElementToView(this IWebDriver webDriver, By by)
        {
            AguardarLoading(webDriver);
            IWebElement webElement = webDriver.FindElement(by);
            webElement.ScrollToElementToView(webDriver);
        }

        private static void ScrollToElementToView(this IWebElement webElement, IWebDriver webDriver)
        {
            ((IJavaScriptExecutor)webDriver).ExecuteScript("arguments[0].scrollIntoView(false);", webElement);
            AguardarLoading(webDriver);
        }

    }
}