
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Operacao.ClientesDoEstacionamento;

namespace Luminus.Selenium.specs.Shared.StCriarUmClientesDoEstacionamentoComCnpjTabela16845
{
    public class StCriarUmClientesDoEstacionamentoComCnpjTabela16845PageStep
    {
        private ClientesDoEstacionamentoPageStep _page = new ClientesDoEstacionamentoPageStep();

        [Step("ST - Criar um Clientes do estacionamento com CNPJ <tabela> [16845]")]
        public void StCriarUmClientesDoEstacionamentoComCnpj16845(Table tabela)
        {
            var row = tabela.GetTableRows()[0];

            new NavegacaoSpec().NavegarParaUrl("UrlClientesDoEstacionamentoPage");
            new BotoesCRUDSpec().ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarUmClientesDoEstacionamentoComCnpj(tabela);
            new BotoesCRUDSpec().ClicarBotaoSalvar();
        }
    }
}