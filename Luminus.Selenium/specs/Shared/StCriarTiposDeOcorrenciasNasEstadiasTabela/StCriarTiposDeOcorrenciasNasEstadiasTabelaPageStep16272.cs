
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.TiposDeOcorrenciasNasEstadias;
using Luminus.Selenium.specs.Shared.StCriarTiposDeOcorrenciasNasEstadiasTabela16272;

namespace Luminus.Selenium.specs.Shared.StCriarTiposDeOcorrenciasNasEstadiasTabela16272
{
    public class StCriarTiposDeOcorrenciasNasEstadiasTabelaPageStep
    {
        private TiposDeOcorrenciasNasEstadiasPageStep _pageStep = new TiposDeOcorrenciasNasEstadiasPageStep();
        private TiposDeOcorrenciasNasEstadiasPage _page = new TiposDeOcorrenciasNasEstadiasPage();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();

        [Step("ST - Criar tipos de ocorrências nas estadias <tabela> [16272]")]
        public void StCriarTiposDeOcorrenciasNasEstadias(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlTipoDeOcorrenciaNasEstadiasPage");
            _pageBotoesCRUD.ClicarBotaoCriar();
            _pageStep.NaSecaoInformacoesGeraisPreencherOCampoNomeComOValor(tabela);
            _page.MarcarobrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias(Convert.ToBoolean(row.GetCell("obrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias")));
            _page.MarcarocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias(Convert.ToBoolean(row.GetCell("ocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias"))); 
            _pageBotoesCRUD.ClicarBotaoSalvar();
        }       

    }
}