
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.IntegracoesComOperadorasDeArrecadacao;
using Luminus.Selenium.specs.Shared.SsCriarIntegracoesComOperadorasConectcar16843;

namespace Luminus.Selenium.specs.Shared.SsCriarIntegracoesComOperadorasConectcar16843
{
    public class SsCriarIntegracoesComOperadorasConectcar16843PageStep
    {
        private IntegracoesComOperadorasDeArrecadacaoPageStep _page = new IntegracoesComOperadorasDeArrecadacaoPageStep();
    
        [Step("SS - Criar integrações com operadoras(ConectCar) <tabela> [16843]")]
        public void SsCriarIntegracoesComOperadorasConectcar16843(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlIntegracoesComOperadorasDeArrecadacaoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarintegracoescomoperadorasconectcarpagestep(tabela);
            new BotoesCRUDSpec().ClicarBotaoSalvar();


        }

        


    }
}