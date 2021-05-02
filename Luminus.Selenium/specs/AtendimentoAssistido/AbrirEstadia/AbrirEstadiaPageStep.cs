
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.AtendimentoAssistido.AbrirEstadia;

namespace Luminus.Selenium.specs.AtendimentoAssistido.AbrirEstadia
{
    public class AbrirEstadiaPageStep
    {
        private AbrirEstadiaPage _page = new AbrirEstadiaPage();
    
        [Step(" [AbrirEstadiaPageStep]")]
        public void Abrirestadiapagestep()
        {
            
        }


        [Step("Preencher os campos da tela <tabela> [AbrirEstadiaPageStep] 26869")]
        public void PreencherOsCamposDaTelaAbrirestadiacommidiabarcodestepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarCartaoCodDeBarras(Convert.ToBoolean(row.GetCell("imgCodDeBarras")));
            _page.SelecionarProdutoEstadia(row.GetCell("nomeProdutoEstadiaAvulso"));
            _page.SelecionarBolsaoVagas(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarTipoVeiculo(row.GetCell("tipoDeVeiculoAtendimentoAssistido"));

        }


    }
}