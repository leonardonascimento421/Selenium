
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.CheckIn.Abertura;
using Luminus.Selenium.specs.Shared.SsEfetuarCheckinLocadora26692;

namespace Luminus.Selenium.specs.Shared.SsEfetuarCheckinLocadora26692
{
    public class SsEfetuarCheckinLocadora26692PageStep
    {
        private CheckIn_CheckOutPageStep _page = new CheckIn_CheckOutPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Efetuar CheckIn Locadora <tabela> [26692]")]
        public void SsEfetuarCheckinLocadora26692(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrlPortal("UrlLuminusPortalDoConveniado");
            _page.NoMenuLateralClicarNaOpcaoLocadoraEfetuarcheckinlocadorastepbysteppagestep();
            _page.ClicarNaOpcaoCheckinCheckoutEfetuarcheckinlocadorastepbysteppagestep();
            _page.NaSecaoBuscarClientePreencherOCampoIdentificacaoDaMidiaComOValorEfetuarcheckinlocadorastepbysteppagestep(row.GetCell("identificacaoMidia"));
            _page.ClicarNoBotaoBuscarcheckinlocadorastepbysteppagestep();
            _page.ClicarNoBotaoConfirmarEfetuarcheckinlocadorastepbysteppagestep();
            //NaSecaoLocadoraNoWidgetVagasEmUsoDeveSerAdicionadoUmVeiculoEfetuarcheckinlocadorastepbysteppagestep();


        }

    }
}