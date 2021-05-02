
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoPassagemEapInformatizado17939;

namespace Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoPassagemEapInformatizado17939
{
    public class SsCriarUmEquipamentoPassagemEapInformatizado17939PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("SS - Criar um equipamento passagem (EAP -Informatizado) <tabela> [17939]")]
        public void SsCriarUmEquipamentoPassagemEapInformatizado17939(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlEquipamentoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentosPageStep17186(tabela);
            _pageBotoes.ClicarNoBotaoAdicionar();
            _page.PreencherOsCamposDoPopUpDePerifericoDeLeitoraImpressoraEquipamentosPageStep17186(tabela);
            _pageBotoes.ClicarNoBotaoAdicionarPopUp();
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();
        }      

    }
}