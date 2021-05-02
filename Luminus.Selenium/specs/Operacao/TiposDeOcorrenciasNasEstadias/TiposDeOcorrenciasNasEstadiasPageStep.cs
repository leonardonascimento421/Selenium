
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.TiposDeOcorrenciasNasEstadias;
using Luminus.Selenium.specs.Shared.Listagem;

namespace Luminus.Selenium.specs.Operacao.TiposDeOcorrenciasNasEstadias
{
    public class TiposDeOcorrenciasNasEstadiasPageStep
    {
        private TiposDeOcorrenciasNasEstadiasPage _page = new TiposDeOcorrenciasNasEstadiasPage();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();


        [Step("Preencher os campos da tela Tipos de ocorrências nas estadias <tabela>")]
        public void PreencherOsCamposDaTelaCriarTiposDeOcorrenciasNasEstadias(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeTipoDeOcorrenciaNasEstadias(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
            _page.MarcarobrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias(Convert.ToBoolean(row.GetCell("obrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias")));
            _page.MarcarocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias(Convert.ToBoolean(row.GetCell("ocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias")));
        }

        [Step("Preencher os campos da tela Tipos de ocorrências nas estadias alterar <tabela>")]
        public void PreencherOsCamposDaTelaCriarTiposDeOcorrenciasNasEstadiasAlterar(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeTipoDeOcorrenciaNasEstadias(row.GetCell("nomeTipoDeOcorrenciaNasEstadias2"));
            _page.MarcarobrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias(Convert.ToBoolean(row.GetCell("obrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias2")));
            _page.MarcarocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias(Convert.ToBoolean(row.GetCell("ocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias2")));
        }

        [Step("Verificar os campos da tela Tipos de ocorrências nas estadias <tabela>")]
        public void VerificarOsCamposDaTelaTiposDeOcorrenciasNasEstadias(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {                
                _page.RetornarnomeTipoDeOcorrenciaNasEstadias().Should().Be(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
                _page.RetornarobrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias().Should().Be(Convert.ToBoolean(row.GetCell("obrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias")));
                _page.RetornarocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias().Should().Be(Convert.ToBoolean(row.GetCell("ocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias")));
            }
        }

        [Step("Verificar os campos da tela Tipos de ocorrências nas estadias alterar <tabela>")]
        public void VerificarOsCamposDaTelaTiposDeOcorrenciasNasEstadiasAlterar(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeTipoDeOcorrenciaNasEstadias().Should().Be(row.GetCell("nomeTipoDeOcorrenciaNasEstadias2"));
                _page.RetornarobrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias().Should().Be(Convert.ToBoolean(row.GetCell("obrigarPreenchimentoDaJustificativaTiposDeOcorrenciasNasEstadias2")));
                _page.RetornarocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias().Should().Be(Convert.ToBoolean(row.GetCell("ocorrenciaObrigatoriaTiposDeOcorrenciasNasEstadias2")));
            }
        }

        [Step("Na seção Informações Gerais preencher o campo Nome com o valor <tabela>")]
        public void NaSecaoInformacoesGeraisPreencherOCampoNomeComOValor(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeTipoDeOcorrenciaNasEstadias(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
        }

        [Step("Na seção Informações Gerais o campo Nome deve conter o valor <nomeTipoDeOcorrenciaNasEstadias>")]
        public void NaSecaoInformacoesGeraisOCampoNomeDeveConterOValor(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeTipoDeOcorrenciaNasEstadias().Should().Be(row.GetCell("nomeTipoDeOcorrenciaNasEstadias"));
            }
        }

        [Step("Na seção Informações Gerais preencher o campo Nome com o valor <tabela> não obrigatório")]
        public void NaSecaoInformacoesGeraisPreencherOCampoNomeNaoObrigatorioComOValor(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeTipoDeOcorrenciaNasEstadias(row.GetCell("nomeTipoDeOcorrenciaNasEstadiasNaoObrigatorio"));
        }

        [Step("Na seção Informações Gerais o campo Nome deve conter o valor <nomeTipoDeOcorrenciaNasEstadias> não obrigatório")]
        public void NaSecaoInformacoesGeraisOCampoNomeDeveConterOValorNaoObrigatorioComOValor(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeTipoDeOcorrenciaNasEstadias().Should().Be(row.GetCell("nomeTipoDeOcorrenciaNasEstadiasNaoObrigatorio"));
            }
        }
    }
}