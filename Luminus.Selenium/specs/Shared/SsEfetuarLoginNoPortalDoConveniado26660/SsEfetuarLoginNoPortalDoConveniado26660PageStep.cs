
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Shared.SsEfetuarLoginNoPortalDoConveniado26660;

namespace Luminus.Selenium.specs.Shared.SsEfetuarLoginNoPortalDoConveniado26660
{
    public class SsEfetuarLoginNoPortalDoConveniado26660PageStep
    {
        private SsEfetuarLoginNoPortalDoConveniado26660Page _page = new SsEfetuarLoginNoPortalDoConveniado26660Page();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagens = new MensagemSpec();

        [Step("SS - Efetuar Login no Portal do Conveniado <tabela> [26660]")]
        public void SsEfetuarLoginNoPortalDoConveniado26660(Table tabela)
        {
            var row = tabela.GetTableRows()[0];

            _pageNavegacao.NavegarParaUrl("UrlLuminusPortalDoConveniado");
           // _page.PreencherOsCamposDaTelaEfetuarloginnoportaldoconveniadostepbysteppagestep(tabela);

            //ClicarNoBotaoEntrarEfetuarloginnoportaldoconveniadostepbysteppagestep();


        }

        [Step("Preencher os campos da tela <tabela> [EfetuarLoginNoPortalDoConveniadoStepByStepPageStep]")]
        public void PreencherOsCamposDaTelaEfetuarloginnoportaldoconveniadostepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
         //  _page.PreencherUsuarioPortalDoConveniado(row.GetCell("usuarioPortalDoConveniado"));
         //  _page.PreencherSenhaPortalDoConveniado(row.GetCell("senhaPortalDoConveniado"));
            
        }

        [Step("Clicar no botão entrar [EfetuarLoginNoPortalDoConveniadoStepByStepPageStep]")]
        public void ClicarNoBotaoEntrarEfetuarloginnoportaldoconveniadostepbysteppagestep()
        {
            
        }


    }
}