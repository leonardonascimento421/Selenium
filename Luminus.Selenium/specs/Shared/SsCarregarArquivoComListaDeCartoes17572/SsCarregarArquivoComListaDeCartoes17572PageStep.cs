
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ArquivoSeriaisMifare;
using Luminus.Selenium.specs.Shared.SsCarregarArquivoComListaDeCartoes17572;

namespace Luminus.Selenium.specs.Shared.SsCarregarArquivoComListaDeCartoes17572
{
    public class SsCarregarArquivoComListaDeCartoes17572PageStep
    {
        private ArquivoSeriaisMifarePageStep _page = new ArquivoSeriaisMifarePageStep();
    
        [Step("SS - Carregar arquivo com lista de cartões <tabela> [17572]")]
        public void SsCarregarArquivoComListaDeCartoes17572(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlArquivosSeriais");
            _page.ClicarNoBotaoEscolherArquivoArquivoseriaismifarepagestep(tabela);
            _page.ClicarNoBotaoCarregarArquivoseriaismifarepagestep();
            new MensagemSpec().Verificarmensagem("Carregamento realizado com sucesso.\r\n Foram alterados 0 mídias mifare. \r\n Foram incluídas 2000 mídias mifare.");
        }     
    }
}