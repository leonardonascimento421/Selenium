
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoFixo26677;

namespace Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoFixo26677
{
    public class SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoFixo26677PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        [Step("SS - Criar um Equipamento Entrada, Saida, Passagem e Validacao Informatizado Fixo <tabela> [26677]")]
        public void SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoFixo26677(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlEquipamentoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaEquipamentospagestep26677(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageMensagemSpec.VerificarMensagemCriacaoComSucesso();
        }
    }
}