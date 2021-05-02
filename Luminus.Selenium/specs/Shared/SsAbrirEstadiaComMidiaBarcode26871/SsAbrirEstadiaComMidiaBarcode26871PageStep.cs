
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.AtendimentoAssistido.AbrirEstadia;
using Luminus.Selenium.specs.Shared.SsAbrirEstadiaComMidiaBarcode26871;

namespace Luminus.Selenium.specs.Shared.SsAbrirEstadiaComMidiaBarcode26871
{
    public class SsAbrirEstadiaComMidiaBarcode26871PageStep
    {
        private AbrirEstadiaPageStep _page = new AbrirEstadiaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Abrir estadia com mídia barcode <tabela> [26871]")]
        public void SsAbrirEstadiaComMidiaBarcode26871(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlAtendimentoAssistidoAbertura");
            _page.PreencherOsCamposDaTelaAbrirestadiacommidiabarcodestepbysteppagestep(tabela);
            _pageBotoes.ClicarBotaoConfirmar();
            _pageMensagens.VerificarMensagemOperacaoComSucesso();
        }
    }
}