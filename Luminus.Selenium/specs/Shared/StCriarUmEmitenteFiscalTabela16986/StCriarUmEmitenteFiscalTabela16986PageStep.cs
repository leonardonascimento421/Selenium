
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Financeiro.EmitentesFiscais;
using Luminus.Selenium.specs.Shared.StCriarUmEmitenteFiscalTabela16986;

namespace Luminus.Selenium.specs.Shared.StCriarUmEmitenteFiscalTabela16986
{
    public class StCriarUmEmitenteFiscalTabela16986PageStep
    {
        private EmitentesFiscaisPageStep _page = new EmitentesFiscaisPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("ST - Criar um emitente fiscal <tabela> [16986]")]
        public void StCriarUmEmitenteFiscal16986(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlEmitentesFiscaisPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarUmEmitenteFiscal(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();
        }

        


    }
}