
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Financeiro.TaxasCambiais;
using OpenQA.Selenium.Support.PageObjects;

namespace Luminus.Selenium.specs.Financeiro.TaxasCambiais
{
    public class TaxasCambiaisPageStep
    {
        private TaxasCambiaisPage _page = new TaxasCambiaisPage();
        private ListagemPage _listagemPage = new ListagemPage();

        [Step("Preencher os campos da tela <tabela> [TaxasCambiaisPageStep] [15793]")]
        public void PreencherOsCamposDaTelaAlterartaxascambiaisstepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamentetaxacambial(Convert.ToBoolean(row.GetCell("imediatamentetaxacambial")));
            _page.PreencherVigenteAtetaxacambial(row.GetCell("vigenteAtetaxacambial"));
            _page.PreencherVigenteAteHoraeMinutotaxacambial(row.GetCell("vigenteAteHoraeMinutotaxacambial"));
            _page.SelecionarMoedaBase(row.GetCell("moedaBase"));
        }

        [Step("Preencher os campos da tela <tabela> [TaxasCambiaisPageStep]")]
        public void PreencherOsCamposDaTelaTaxascambiaispagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarMoedaBasetaxacambial(row.GetCell("moedaBasetaxacambial"));
            _page.PreencherValorTaxaDireta(row.GetCell("valorTaxaDireta"));

        }

        [Step("Preencher os campos da tela <tabela> [TaxasCambiaisPageStep] [15972]")]
        public void PreencherOsCamposDaTelaTaxasCambiaisPageStep15972(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarMoedaBasetaxacambial(row.GetCell("moedaBasetaxacambialalterar"));
            _page.PreencherValorTaxaDireta(row.GetCell("valorTaxaDiretaalterar"));
        }

        [Step("Preencher os campos da tela <tabela> [TaxasCambiaisPageStep] [15970]")]
        public void PreencherOsCamposDaTelaTaxasCambiaisPageStep15970(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherVigenteAPartirtaxacambial(row.GetCell("vigenteAPartirtaxacambial"));
            _page.PreencherVigenteAPartirHoraeMinuto(row.GetCell("vigenteAPartirHoraeMinuto"));
            _page.PreencherVigenteAtetaxacambial(row.GetCell("vigenteAtetaxacambial"));
            _page.PreencherVigenteAteHoraeMinutotaxacambial(row.GetCell("vigenteAteHoraeMinutotaxacambial"));
            _page.SelecionarMoedaBase(row.GetCell("moedaBase"));

        }

        [Step("Verificar os campos da tela <tabela> [TaxasCambiaisPageStep]")]
        public void VerificarOsCamposDaTelaTaxasCambiaisPageStep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarVigenteAtetaxacambial().Should().Be(row.GetCell("vigenteAtetaxacambial"));
                _page.RetornarVigenteAteHoraeMinutotaxacambial().Should().Be(row.GetCell("vigenteAteHoraeMinutotaxacambial"));
                _page.RetornarMoedaBase().Should().Be(row.GetCell("moedaBase"));

            }
        }

        [Step("Verificar os campos da tela <tabela> [TaxasCambiaisPageStep] [15972]")]
        public void VerificarOsCamposDaTelaTaxasCambiaisPageStep15972(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                var grid = _page.RetornarTabelaTaxasCambiaisPorMoeda();
                _page.RetornarMoedaBasetaxacambial(grid,1).Should().Be(row.GetCell("moedaBasetaxacambialalterar"));
                _page.RetornarValorTaxaDireta(grid,1).Should().Be(row.GetCell("valorTaxaDiretaalterar"));

            }
        }

        [Step("O checkBox Imediatamente deve estar marcado <tabela> [TaxasCambiaisPageStep]")]
        public void OCheckboxImediatamenteDeveEstarDesmarcadoTaxascambiaispagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamentetaxacambial(Convert.ToBoolean(row.GetCell("imediatamentetaxacambial")));

        }

        [Step("Validar na seção Taxas cambiais por moeda <tabela> [TaxasCambiaisPageStep]")]
        public void ValidarNaSecaoTaxasCambiaisPorMoedaTaxasCambiaisPageStep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _listagemPage.RetornarLinhaDaTabelaComValor(row.GetCell("moedaBasetaxacambial")).Should().BeNullOrEmpty();
        }

        
    }
}