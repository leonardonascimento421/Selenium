
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.ClientesDoEstacionamento;
using Luminus.Selenium.specs.Shared.StCriarClientesDoEstacionamentoTabela16128;

namespace Luminus.Selenium.specs.Shared.StCriarClientesDoEstacionamentoTabela16128
{
    public class StCriarClientesDoEstacionamentoTabela16128PageStep
    {
        private ClientesDoEstacionamentoPageStep _page = new ClientesDoEstacionamentoPageStep();
    
        [Step("ST - Criar clientes do estacionamento <tabela> [16128]")]
        public void StCriarClientesDoEstacionamento16128(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new NavegacaoSpec().NavegarParaUrl("UrlClientesDoEstacionamentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarClientesDoEstacionamento16128(tabela);
            new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
            new BotoesCRUDSpec().ClicarBotaoSalvar();
        }    

    }
}