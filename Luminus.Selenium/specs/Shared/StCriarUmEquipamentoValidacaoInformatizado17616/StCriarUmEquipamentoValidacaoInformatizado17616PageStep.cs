
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.StCriarUmEquipamentoValidacaoInformatizado17616;

namespace Luminus.Selenium.specs.Shared.StCriarUmEquipamentoValidacaoInformatizado17616
{
    public class StCriarUmEquipamentoValidacaoInformatizado17616PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
        private NavegacaoSpec _pageNavegação = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoesGRUD = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagem = new MensagemSpec();
    
        [Step("ST - Criar um equipamento validação (Informatizado) <tabela> [17616]")]
        public void StCriarUmEquipamentoValidacaoInformatizado17616(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
           _pageNavegação.NavegarParaUrl("UrlEquipamentoPage");
           _pageBotoesGRUD.ClicarBotaoCriar();
           _page.PreencherOsCamposDaTelaEquipamentosPageStep17616(tabela);
           new BotoesCRUDSpec().ClicarNoBotaoAdicionar();
           _page.PreencherOsCamposDoPopUpDePerifericoDeImpressorEquipamentosPageStep17616(tabela);
           new BotoesCRUDSpec().ClicarNoBotaoAdicionarPopUp();
           _pageBotoesGRUD.ClicarBotaoSalvar();
           _pageMensagem.Verificarmensagem("Criação realizada com sucesso.");
                    
        }      
        
    }
}