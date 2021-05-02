using FluentAssertions;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Luminus.Selenium.Implementation.Pages.Shared.Listagem
{
    public class ListagemPage : BasePage
    {
        public IWebElement  ClicarBotao3Pontos(IWebElement element = null)
        {
            return _driver.Click(By.CssSelector(".menu-popovertable"), element);
        }

        public void ClicarBotaoDetalhar(IWebElement element)
        {
            ClicarLinkPorTexto("detalhar", element);
        }

        public void ClicarBotaoGravarCartao(IWebElement element)
        {
            ClicarLinkPorTexto("gravar cartão", element);
        }

        public void ClicarBotaoAlterar(IWebElement element)
        {
            ClicarLinkPorTexto("alterar", element);
        }

        public void ClicarBotaoExcluir(IWebElement element)
        {
            ClicarLinkPorTexto("excluir", element);
        }

        public void ClicarBotaoParametrosGerais(IWebElement element)
        {
            ClicarLinkPorTexto("parâmetros gerais", element);
        }

        private void ClicarLinkPorTexto(string texto, IWebElement element)
        {
            _driver.Click(By.XPath($"//a[contains(.,'{texto}')]"), element); // pega todo o conteudo escrito dentro do botão e faz um contains, funciona msm que tenha um span dentro do botão
        }

        public void ClicarBotaoPesquisaAvancada()
        {
            _driver.Click(By.CssSelector(".glyphicon-search"));
        }

        public IWebElement ClicarNaLinhaDaTabelaComValor(string valor)
        {
            return _driver.Click(By.XPath($"//tr[contains(.,'{valor}')]"));
        }

        public IWebElement ClicarNaLabelComValor(string valor)
        {
            var elementoPai = _driver.Click(By.XPath($"//label[contains(.,'{valor}')]"));
            return elementoPai.FindElement(By.XPath("./.."));
        }

        public void Pesquisar(string texto)
        {
            PreencherCampoPesquisa(texto);

            // tirando o foco do controle de pesquisa para efetuar a consulta e não haver um duplo refresh na listagem
            _driver.Click(By.CssSelector("np-tabela-pesquisa small"));
            // TODO: substituir por task.delay e configurar o tempo do front de espera após digitar para 20 ms ou menos
            Thread.Sleep(1100);
            _driver.AguardarLoading();
        }

        private void PreencherCampoPesquisa(string texto)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname=pesquisa]"), texto);
        }

        public IEnumerable<IWebElement> RetornarLinhaDaTabelaComValor(string valor)
        {
            return _driver.GetElements(By.XPath($"//tr[contains(.,'{valor}')]"));
        }

        public IEnumerable<IWebElement> RetornarLinhaDaTabelaComValor(By by, string valor)
        {
            By byChained = new ByChained(by, By.XPath($".//tr[contains(.,'{valor}')]"));
            return _driver.GetElements(byChained);
        }

        public void VerificarTabelaVazia(By by)
        {
            RetornarLinhaDaTabelaComValor(by, Config.Constantes.MensagemTabelaVazia).Should().NotBeNull();
        }

    }

}
