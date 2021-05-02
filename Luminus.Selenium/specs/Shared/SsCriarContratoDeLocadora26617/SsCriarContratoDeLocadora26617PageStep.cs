
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Locadora.Contrato;
using Luminus.Selenium.specs.Shared.SsCriarContratoDeLocadora26617;

namespace Luminus.Selenium.specs.Shared.SsCriarContratoDeLocadora26617
{
    public class SsCriarContratoDeLocadora26617PageStep
    {
        private ContratoPageStep _page = new ContratoPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Criar contrato de locadora <tabela> [26617]")]
        public void SsCriarContratoDeLocadora26617(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlContratoLocadoraPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarcontratodelocadorastepbysteppagestep26617(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagens.VerificarMensagemCriacaoComSucesso();
		
        }      
    }
}