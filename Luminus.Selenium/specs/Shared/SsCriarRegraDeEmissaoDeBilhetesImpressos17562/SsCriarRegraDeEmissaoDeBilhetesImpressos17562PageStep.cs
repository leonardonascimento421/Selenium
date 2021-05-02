
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
using Luminus.Selenium.specs.Shared.SsCriarRegraDeEmissaoDeBilhetesImpressos17562;

namespace Luminus.Selenium.specs.Shared.SsCriarRegraDeEmissaoDeBilhetesImpressos17562
{
    public class SsCriarRegraDeEmissaoDeBilhetesImpressos17562PageStep
    {
        private RegrasDeEmissaoDeBilhetesImpressosPageStep _pageStep = new RegrasDeEmissaoDeBilhetesImpressosPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();


        [Step("SS - Criar regra de emissão de bilhetes impressos <tabela> [17562]")]
        public void SsCriarRegraDeEmissaoDeBilhetesImpressos17562(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlRegraDeEmissaoDeBilhetesImpressos");
            _pageBotoesCRUD.ClicarBotaoCriar();
            _pageStep.PreencherOsCamposDatelaOValorTesteCriacaoRegrasdeemissaodebilhetesimpressospagestep(tabela);
            _pageBotoesCRUD.ClicarBotaoSalvar();
            _pageMensagem.VerificarMensagemCriacaoComSucesso();
        }
    }
}