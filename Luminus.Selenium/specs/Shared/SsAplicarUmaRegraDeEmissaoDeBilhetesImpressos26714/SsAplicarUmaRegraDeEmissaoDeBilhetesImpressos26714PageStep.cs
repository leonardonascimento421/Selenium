
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.RegrasDeEmissaoDeBilhetesImpressos;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.SsAplicarUmaRegraDeEmissaoDeBilhetesImpressos26714;

namespace Luminus.Selenium.specs.Shared.SsAplicarUmaRegraDeEmissaoDeBilhetesImpressos26714
{
    public class SsAplicarUmaRegraDeEmissaoDeBilhetesImpressos26714PageStep
    {
        private RegrasDeEmissaoDeBilhetesImpressosPageStep _pageStep = new RegrasDeEmissaoDeBilhetesImpressosPageStep();
        private ListagemPageStep _pageListagem = new ListagemPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Aplicar uma regra de emissão de bilhetes impressos <tabela> [26714]")]
        public void SsAplicarUmaRegraDeEmissaoDeBilhetesImpressos26714(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageBotoesCRUD.ClicarBotaoAplicar();
            _pageStep.PreencherOsCamposDatelaOValorTesteAplicacaoRegrasdeemissaodebilhetesimpressospagestep(tabela);
            _pageBotoesCRUD.ClicarBotaoSalvar();
            _pageMensagem.VerificarMensagemAplicacaoComSucesso();
        }
    }
}