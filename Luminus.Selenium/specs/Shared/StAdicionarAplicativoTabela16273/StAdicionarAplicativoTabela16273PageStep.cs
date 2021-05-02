
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.InstalacoesAtualizacoes.AplicativosEVersoes;
using Luminus.Selenium.specs.Shared.StAdicionarAplicativoTabela16273;

namespace Luminus.Selenium.specs.Shared.StAdicionarAplicativoTabela16273
{
    public class StAdicionarAplicativoTabela16273PageStep
    {
        private AplicativosEVersoesPageStep _page = new AplicativosEVersoesPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("ST - Adicionar aplicativo <tabela> [16273]")]
        public void StAdicionarAplicativo16273(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlAplicativoVersaoPage");
            _page.ClicarNoBotaoCarregarArquivo();
            _page.ClicarNoBotaoEscolherArquivo(tabela);
            _page.ClicarNoBotaoCarregar();
            _pageMensagem.Verificarmensagem("Carregamento realizado com sucesso.");

        }


    }
}