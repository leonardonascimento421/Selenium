
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoEntradaEaeInformatizado17936;

namespace Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoEntradaEaeInformatizado17936
{
    public class SsCriarUmEquipamentoEntradaEaeInformatizado17936PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("SS - Criar um equipamento entrada(EAE-Informatizado) <tabela> [17936]")]
        public void SsCriarUmEquipamentoEntradaEaeInformatizado17936(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlEquipamentoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep17182(tabela);
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitoraImpressoraEquipamentosPageStep17182(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();

        }     

    }
}