using Gauge.CSharp.Lib.Attribute;
using Gauge.CSharp.Lib;
using OpenQA.Selenium;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Luminus.Selenium.Implementation.Pages.Shared.Form
{

    public class BotoesCRUDPage : BasePage
    {

        public void ClicarBotaoAdicionar(IWebElement element = null)
        {
            ClicarBotaoPorTexto("adicionar", element);
        }

        public void ClicarBotaoAdicionarPopUp()
        {
            _driver.Click(By.XPath("//*[contains(@class, 'modal fade in')]//button[contains(.,'adicionar')]"));
        }

        public void ClicarBotaoAlterarPopUp()
        {
            _driver.Click(By.XPath("//*[contains(@class, 'modal fade in')]//button[contains(.,'alterar')]"));
        }

        public void ClicarBotaoSalvarPopUp()
        {
            _driver.Click(By.XPath("//*[contains(@class, 'modal fade in')]//button[contains(.,'salvar')]"));
        }

        public void ClicarBotaoGravarPopUp()
        {
            _driver.Click(By.XPath("//*[contains(@class, 'modal fade in')]//button[contains(.,'gravar')]"));
        }

        public void ClicarBotaoFecharPopUp()
        {
            _driver.Click(By.XPath("//*[contains(@class, 'modal fade in')]//button[contains(.,' fechar ')]"));
        }

        public void ClicarBotaoSalvarEFecharPopUp()
        {
            _driver.Click(By.XPath("//*[contains(@class, 'modal fade in')]//button[contains(.,'salvar e fechar')]"));
        }

        public void ClicarBotaoSalvar()
        {
            ClicarBotaoPorTexto("salvar"); 
        }

        public void ClicarBotaoSalvareSair()
        {
            ClicarBotaoPorTexto("salvar e sair");
        }

        public void ClicarBotaoSalvareContinuar()
        {
            ClicarBotaoPorTexto("salvar e continuar");
        }

        public void ClicarBotaoAlterar()
        {
            ClicarBotaoPorTexto("alterar");
        }

        public void ClicarBotaoCriar()
        {
            ClicarBotaoPorTexto("criar");
        }

        public void ClicarBotaoAplicar()
        {
            ClicarBotaoPorTexto("aplicar");
        }

        public void ClicarBotaoVoltar()
        {
            ClicarBotaoPorTexto("voltar");
        }

        public void ClicarBotaoExcluir()
        {
            ClicarBotaoPorTexto("excluir");
        }

        public void ClicarBotaoFechar()
        {
            ClicarBotaoPorTexto("fechar");
        }

        public void ClicarBotaoImprimir()
        {
            ClicarBotaoPorTexto("imprimir");
        }

        public void ClicarBotaoMover()
        {
            _driver.Click(By.CssSelector("button[title='Mover']"));
        }

        public void ClicarBotaoMoverTodos()
        {
            _driver.Click(By.CssSelector("button[title='Mover todos']"));
        }
       
        public void ClicarBotaoRemover()
        {
            _driver.Click(By.CssSelector("button[title='Remover']"));
        }

        public void ClicarBotaoRemoverTodos()
        {
            _driver.Click(By.CssSelector("button[title='Remover todos']"));
        }

        public void ClicarBotaoEnviar()
        {
            ClicarBotaoPorTexto("enviar");
        }

        public void ClicarBotaoConfirmar()
        {
            ClicarBotaoPorTexto("confirmar");
        }

        public void ClicarBotaoBuscar()
        {
            ClicarBotaoPorTexto("buscar");
        }

        public void ClicarBotaoPorTexto(string texto, IWebElement element = null)
        {
            _driver.Click(By.XPath($".//button[contains(.,'{texto}')]"), element); // pega todo o conteudo escrito dentro do botão e faz um contains, funciona msm que tenha um span dentro do botão
        }
    }
}
