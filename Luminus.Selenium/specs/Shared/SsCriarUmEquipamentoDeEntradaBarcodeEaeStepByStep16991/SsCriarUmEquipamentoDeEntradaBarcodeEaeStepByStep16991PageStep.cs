
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoDeEntradaBarcodeEaeStepByStep16991;

namespace Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoDeEntradaBarcodeEaeStepByStep16991
{
    public class SsCriarUmEquipamentoDeEntradaBarcodeEaeStepByStep16991PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("SS - Criar um equipamento de entrada Barcode(EAE) step by step <tabela> [16632]")]
        public void SsCriarUmEquipamentoDeEntradaBarcodeEaeStepByStep16991(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlEquipamentoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep16632(tabela);
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitora1D2DEquipamentosPageStep16632(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitorDeTagEquipamentosPageStep16632(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitoraImpressoraEquipamentosPageStep16632(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCampoDoPopupDePerifericoDePlacaDeSomEquipamentosPageStep16632(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _page.PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentospagestep16632(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();
        }      

    }
}