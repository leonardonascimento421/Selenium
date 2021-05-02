
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarEquipamentoDeValidacaoAutomaticaEap16921;

namespace Luminus.Selenium.specs.Shared.SsCriarEquipamentoDeValidacaoAutomaticaEap16921
{
    public class SsCriarEquipamentoDeValidacaoAutomaticaEap16921PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("SS - Criar equipamento de validação automática (EAP) <tabela> [16921]")]
        public void SsCriarEquipamentoDeValidacaoAutomaticaEap16921(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlEquipamentoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep16921(tabela);
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16921(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeImpressoraEquipamentosPageStep16921(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitora1D2DEquipamentosPageStep16921(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeModuloFinanceiroEquipamentosPageStep16921(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _page.PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16921(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();       
        }      
    }
}