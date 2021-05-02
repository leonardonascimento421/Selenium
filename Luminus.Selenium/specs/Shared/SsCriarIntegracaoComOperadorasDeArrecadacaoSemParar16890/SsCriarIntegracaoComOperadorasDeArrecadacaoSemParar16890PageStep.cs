
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.IntegracoesComOperadorasDeArrecadacao;
using Luminus.Selenium.specs.Shared.SsCriarIntegracaoComOperadorasDeArrecadacaoSemParar16890;

namespace Luminus.Selenium.specs.Shared.SsCriarIntegracaoComOperadorasDeArrecadacaoSemParar16890
{
    public class SsCriarIntegracaoComOperadorasDeArrecadacaoSemParar16890PageStep
    {
        private IntegracoesComOperadorasDeArrecadacaoPageStep _page = new IntegracoesComOperadorasDeArrecadacaoPageStep();
    
        [Step("SS - Criar integração com operadoras de arrecadação (Sem Parar) <tabela> [16890]")]
        public void SsCriarIntegracaoComOperadorasDeArrecadacaoSemParar16890(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlIntegracoesComOperadorasDeArrecadacaoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarintegracaocomoperadorasdearrecadacaosempararpagestep(tabela);
            new BotoesCRUDSpec().ClicarBotaoSalvar();

        }

        


    }
}