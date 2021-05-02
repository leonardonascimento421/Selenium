
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ArquivoSeriaisMifare;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ArquivoSeriaisMifare
{
    public class ArquivoSeriaisMifarePageStep
    {
        private ArquivoSeriaisMifarePage _page = new ArquivoSeriaisMifarePage();
    
        [Step("Clicar no botão Escolher arquivo <tabela> [ArquivoSeriaisMifarePageStep]")]
        public void ClicarNoBotaoEscolherArquivoArquivoseriaismifarepagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.EscolherArquivoSerialMifare(row.GetCell("caminhoArquivoMifare") + row.GetCell("arquivoMifare"));
        }

        [Step("Clicar no botão carregar [ArquivoSeriaisMifarePageStep]")]
        public void ClicarNoBotaoCarregarArquivoseriaismifarepagestep()
        {
            _page.ClicarBotaoCarregarArquivo();
        }
    }
}