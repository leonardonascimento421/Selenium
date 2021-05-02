
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.ProdutoDeEstadia.TabelasDeCobranca;
using Luminus.Selenium.specs.ProdutosDeEstadia.TabelasDeCobranca;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.TabelasDeCobranca
{
    public class TabelasDeCobrancaPageStep
    {
        private TabelasDeCobrancaPage _page = new TabelasDeCobrancaPage();

        [Step("Preencher os campos da tela <tabela> [TabelasDeCobrancaPageStep] [16091]")]
        public void PreencherOsCamposDaTelaCriartabelasdecobrancastepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDaTabelaDeCobranca(row.GetCell("numerodatabeladecobrancatabelasdecobranca"));
            _page.PreencherNomeDaTabelaDeCobranca(row.GetCell("nometabelasdecobranca"));
            _page.SelecionarEstruturaTabelaCobranca(row.GetCell("nomeEstruturaCobranca"));
            _page.SelecionarRegraCobranca(row.GetCell("nomeRegrasDeCobranca"));

        }

        [Step("Preencher os campos do pop-up Adicionar tempo de tolerância por período <tabela> [TabelasDeCobrancaPageStep] [16091]")]
        public void PreencherOsCamposDoPopUpAdicionarTempoDeToleranciaPorPeriodo16091(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarDomingo(Convert.ToBoolean(row.GetCell("domingodiasdasemanatabelasdecobranca")));
            _page.MarcarSegunda(Convert.ToBoolean(row.GetCell("segundadiasdasemanatabelasdecobranca")));
            _page.MarcarTerca(Convert.ToBoolean(row.GetCell("tercadiasdasemanatabelasdecobranca")));
            _page.MarcarQuarta(Convert.ToBoolean(row.GetCell("quartadiasdasemanatabelasdecobranca")));
            _page.MarcarQuinta(Convert.ToBoolean(row.GetCell("quintadiasdasemanatabelasdecobranca")));
            _page.MarcarSexta(Convert.ToBoolean(row.GetCell("sextadiasdasemanatabelasdecobranca")));
            _page.MarcarSabado(Convert.ToBoolean(row.GetCell("sabadodiasdasemanatabelasdecobranca")));
            _page.PreencherVigenteAPartirDe(row.GetCell("vigenteapartirdeadicionartempodetoleranciaporperiodotabelasdecobranca"));
        }

        [Step("Preencher os campos da seção de Estruturas <tabela> [TabelasDeCobrancaPageStep] [16091]")]
        public void PreencherOsCamposDaSecaoDeEstruturas16091(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorFracao(row.GetCell("valorfracao1periodo1tabelasdecobranca"),1);
            _page.PreencherValorFracao(row.GetCell("valorfracao2periodo1tabelasdecobranca"),2);
        }
    }
}