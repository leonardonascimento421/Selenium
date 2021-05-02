using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Luminus.Selenium.specs.Shared.Listagem
{
    public class ListagemPageStep
    {
        private ListagemPage _page = new ListagemPage();

        [Obsolete("Não utilizar")]
        [Step("Consultar na listagem <valor>")]
        public void ConsultarListagem(string valor)
        {
            _page.Pesquisar(valor);
        }       

        [Step("Clicar no botão Detalhar na listagem")]
        public void ClicarBotaoDetalhar()
        {
            IWebElement elementoMenuContexto = ClicarBotao3PontosVerificandoContexto();
            _page.ClicarBotaoDetalhar(elementoMenuContexto);
        }

        [Step("Clicar no botão Alterar na listagem")]
        public void ClicarBotaoAlterar()
        {
            IWebElement elementoMenuContexto = ClicarBotao3PontosVerificandoContexto();
            _page.ClicarBotaoAlterar(elementoMenuContexto);
        }

        [Step("Clicar no botão Excluir na listagem")]
        public void ClicarBotaoExcluir()
        {
            IWebElement elementoMenuContexto = ClicarBotao3PontosVerificandoContexto();
            _page.ClicarBotaoExcluir(elementoMenuContexto);
        }

        private IWebElement ClicarBotao3PontosVerificandoContexto()
        {
            var elementoMenuContexto = TestContextHelper.Get<IWebElement>("elementoMenuContexto");
            TestContextHelper.Clear("elementoMenuContexto");

            if (elementoMenuContexto == null)
                elementoMenuContexto = _page.ClicarBotao3Pontos();
            return elementoMenuContexto;
        }
        
        [Step("Clicar no botão Parâmetros gerais na listagem")]
        public void ClicarOpcaoParametrosGerais()
        {
            IWebElement elementoMenuContexto = ClicarBotao3PontosVerificandoContexto();
            _page.ClicarBotaoParametrosGerais(elementoMenuContexto);
        }

        [Obsolete("Não utilizar")]
        [Step("Excluir consultando por <valor> campo tabela na listagem")]
        public void ExcluirConsultandoPorValorCampoTabelaNaListagem(string valor)
        {
            var listagemSpec = new ListagemPageStep();
            listagemSpec.ConsultarListagem(valor);
            listagemSpec.ClicarBotaoExcluir();
        }

        [Obsolete("Não utilizar")]
        [Step("Detalhar consultando por <valor> campo tabela na listagem")]
        public void DetalharConsultandoPorValorCampoTabelaNaListagem(string valor)
        {
            var listagemSpec = new ListagemPageStep();
            listagemSpec.ConsultarListagem(valor);
            listagemSpec.ClicarBotaoDetalhar();
        }

        [Obsolete("Não utilizar")]
        [Step("Alterar consultando por <valor> campo tabela na listagem")]
        public void AlterarConsultandoPorValorCampoTabelaNaListagem(string valor)
        {
            var listagemSpec = new ListagemPageStep();
            listagemSpec.ConsultarListagem(valor);
            listagemSpec.ClicarBotaoAlterar();
        }

        [Step("Clicar no menu de contexto (...) na linha contendo o valor <valor> na tabela")]
        public void ClicarNoMenuDeContextoNaLinhaContendoOValorNaTabela(string valor)
        {
            var element = _page.ClicarNaLinhaDaTabelaComValor(valor);
            element = _page.ClicarBotao3Pontos(element);

            DataStoreFactory.ScenarioDataStore.Add("elementoMenuContexto", element);
        }

        [Step("Clicar no menu de contexto (...) na label contendo o valor <valor>")]
        public void ClicarNoMenuDeContextoNaLabelContendoOValor(string valor)
        {
            var element = _page.ClicarNaLabelComValor(valor);
            element = _page.ClicarBotao3Pontos(element);

            DataStoreFactory.ScenarioDataStore.Add("elementoMenuContexto", element);
        }

        [Step("Clicar no botão gravar cartão na listagem")]
        public void ClicarNoBotaoGravarCartaoNaListagem()
        {
            IWebElement elementoMenuContexto = ClicarBotao3PontosVerificandoContexto();
            _page.ClicarBotaoGravarCartao(elementoMenuContexto);
        }
    }
}
