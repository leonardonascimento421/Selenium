
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.CheckIn.Abertura;
using Luminus.Selenium.specs.Shared.SsCriarContratoDeLocadora26617;
using Luminus.Selenium.specs.Shared.SsCriarRegrasDeCobranca16135;
using Luminus.Selenium.specs.Shared.SsCriarTabelasDeCobranca16091;
using Luminus.Selenium.specs.Shared.SsCriarUmaEstruturaDeCobranca16003;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoFixo26677;
using Luminus.Selenium.specs.Shared.SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoVolante26674;
using Luminus.Selenium.specs.Shared.SsCriarUmProdutoEstadiaDoTipoAvulso16343;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoATodosAsFuncionalidades17684;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoEntrada16330;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoPassagem16331;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoSaida16333;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;
using Luminus.Selenium.specs.Shared.StCriarUmUsuarioDoSistemaTabela17595;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.CheckIn.Abertura
{
    public class CheckIn_CheckOutPageStep
    {
        private CheckIn_CheckOutPage _page = new CheckIn_CheckOutPage();

        [Step("Carregar dependências de Check-in <tabela>")]
        public void CarregarDependenciasAberturaCheckIn26585(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecution(() =>
            {
               // steps de dependências
               //  new StCriarPerfilComAcessoATodosAsFuncionalidades17684PageStep().StCriarPerfilComAcessoATodosAsFuncionalidades17684(tabela);
               // new StCriarUmUsuarioDoSistemaTabela17595PageStep().StCriarUmUsuarioDoSistema17595(tabela);
               // new StCriarUmBolsaoDeVagas16266PageStep().StCriarUmBolsaoDeVagas16266(tabela);

               ////  new SsCriarUmaEstruturaDeCobranca16003PageStep().SsCriarUmaEstruturaDeCobranca16003(tabela);

               // new SsCriarRegrasDeCobranca16135PageStep().SsCriarRegrasDeCobranca16135(tabela);
               // new SsCriarTabelasDeCobranca16091PageStep().SsCriarTabelasDeCobranca16091(tabela);
               // new StCriarUmaRegraDeAcessoEntrada16330PageStep().StCriarUmaRegraDeAcessoEntrada16330(tabela);
               // new StCriarUmaRegraDeAcessoPassagem16331PageStep().StCriarUmaRegraDeAcessoPassagem16331(tabela);
               // new StCriarUmaRegraDeAcessoSaida16333PageStep().StCriarUmaRegraDeAcessoSaida16333(tabela);
               // new SsCriarUmProdutoEstadiaDoTipoAvulso16343PageStep().SsCriarUmProdutoEstadiaDoTipoAvulso16343(tabela);
               // new SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoVolante26674PageStep().SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoVolante26674(tabela);
               // new SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoFixo26677PageStep().SsCriarUmEquipamentoEntradaSaidaPassagemEValidacaoInformatizadoFixo26677(tabela);
               // new SsCriarContratoDeLocadora26617PageStep().SsCriarContratoDeLocadora26617(tabela);

            });
        }


        [Step("No menu lateral clicar na opção Locadora [EfetuarCheckinLocadoraStepByStepPageStep]")]
        public void NoMenuLateralClicarNaOpcaoLocadoraEfetuarcheckinlocadorastepbysteppagestep()
        {
            _page.ClicarNoMenuLocadora();
        }

        [Step("Clicar na opção Checkin/Checkout [EfetuarCheckinLocadoraStepByStepPageStep]")]
        public void ClicarNaOpcaoCheckinCheckoutEfetuarcheckinlocadorastepbysteppagestep()
        {
            _page.ClicarNoLinkCheckInCheckOut();
        }

        [Step("na seção Buscar cliente preencher o campo Identificação da mídia com o valor <identificacaoMidia> [EfetuarCheckinLocadoraStepByStepPageStep]")]
        public void NaSecaoBuscarClientePreencherOCampoIdentificacaoDaMidiaComOValorEfetuarcheckinlocadorastepbysteppagestep(string identificacaoMidia)
        {
            _page.PreencherIdentificacaoMidia(identificacaoMidia);

        }

        [Step("Clicar no botão Buscar [EfetuarCheckinLocadoraStepByStepPageStep]")]
        public void ClicarNoBotaoBuscarcheckinlocadorastepbysteppagestep()
        {
            _page.ClicarBotaoBuscar();
        }

        [Step("Clicar no botão Confirmar [EfetuarCheckinLocadoraStepByStepPageStep]")]
        public void ClicarNoBotaoConfirmarEfetuarcheckinlocadorastepbysteppagestep()
        {         
            _page.ClicarBotaoConfirmar();
        }

        [Step("Na seção Locadora no Widget Vagas em uso deve ser adicionado um veiculo [EfetuarCheckinLocadoraStepByStepPageStep]")]
        public void NaSecaoLocadoraNoWidgetVagasEmUsoDeveSerAdicionadoUmVeiculoEfetuarcheckinlocadorastepbysteppagestep()
        {

        }

    }
}