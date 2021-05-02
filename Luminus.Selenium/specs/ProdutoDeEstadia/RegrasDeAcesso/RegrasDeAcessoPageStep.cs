
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeAcesso;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeAcesso
{
    public class RegrasDeAcessoPageStep
    {
        private RegrasDeAcessoPage _page = new RegrasDeAcessoPage();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("Carregar dependências Regras de acesso <tabela>")]
        public void CarregarDependenciasRegrasAcesso(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecution(() =>
            {
                // steps de dependências
                new StCriarUmBolsaoDeVagas16266PageStep().StCriarUmBolsaoDeVagas16266(tabela);
            });
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16004]")]
        public void PreencherOsCamposDaTelaCriarumaregradeacessoentradastepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeentradaregrasdeacesso"));
            _page.SelecionarFuncaoDeOperacaoDoEquipamento(row.GetCell("funcaodeoperacaodoequipamentoregrasdeacessoentrada"));

        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeAcessoPageStep] [16004]")]
        public void VerificarOsCamposDaTelaCriarumaregradeacessoentradastepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeentradaregrasdeacesso"));
                _page.RetornarFuncaoDeOperacaoDoEquipamento().Should().Be(row.GetCell("funcaodeoperacaodoequipamentoregrasdeacessoentrada"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16005]")]
        public void PreencherOsCamposDaTelaCriarumaregradeacessopassagemstepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomepassagemregrasdeacesso"));
            _page.SelecionarFuncaoDeOperacaoDoEquipamento(row.GetCell("funcaodeoperacaodoequipamentoregrasdeacessopassagem"));
        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeAcessoPageStep] [16005]")]
        public void VerificarOsCamposDaTelaCriarumaregradeacessopassagemstepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomepassagemregrasdeacesso"));
                _page.RetornarFuncaoDeOperacaoDoEquipamento().Should().Be(row.GetCell("funcaodeoperacaodoequipamentoregrasdeacessopassagem"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16006]")]
        public void PreencherOsCamposDaTelaCriarumaregradeacessosaidastepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomesaidaregrasdeacesso"));
            _page.SelecionarFuncaoDeOperacaoDoEquipamento(row.GetCell("funcaodeoperacaodoequipamentoregrasdeacessosaida"));
        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeAcessoPageStep] [16006]")]
        public void VerificarOsCamposDaTelaCriarumaregradeacessosaidastepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomesaidaregrasdeacesso"));
                _page.RetornarFuncaoDeOperacaoDoEquipamento().Should().Be(row.GetCell("funcaodeoperacaodoequipamentoregrasdeacessosaida"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16085]")]
        public void PreencherOsCamposDaTelaCriarumaregradeacessostepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeregrasdeacesso"));
            _page.SelecionarFuncaoDeOperacaoDoEquipamento(row.GetCell("funcaodeoperacaoregradeacesso"));
            _page.MarcarSegunda(Convert.ToBoolean(row.GetCell("segundaregrasdeacesso")));
            _page.MarcarTerca(Convert.ToBoolean(row.GetCell("tercaregrasdeacesso")));
            _page.MarcarQuarta(Convert.ToBoolean(row.GetCell("quartaregrasdeacesso")));
            _page.MarcarQuinta(Convert.ToBoolean(row.GetCell("quintaregrasdeacesso")));
            _page.MarcarSexta(Convert.ToBoolean(row.GetCell("sextaregrasdeacesso")));
            _page.MarcarSabado(Convert.ToBoolean(row.GetCell("sabadoregrasdeacesso")));
            _page.MarcarDomingo(Convert.ToBoolean(row.GetCell("domingoregrasdeacesso")));
            _page.PreencherPeriodoValidoInicial(row.GetCell("dasregrasdeacesso"));
            _page.PreencherPeriodoValidoFinal(row.GetCell("asregrasdeacesso"));
            _page.MarcarVerificarBolsaoPrecedente(Convert.ToBoolean(row.GetCell("verificarbolsaoprecedente")));
            _page.SelecionarUmBolsaoDualist(row.GetCell("nomeBolsaoDeVagas"));
            _pageBotoes.ClicarBotaoMover();
            _page.SelecionarVeiculosPermitidos(row.GetCell("veiculospermitidosregrasdeacesso"));
            _page.SelecionarCartoesVencidos(row.GetCell("cartoesvencidosregrasdeacesso"));
            _page.PreencherToleranciaEmDiasCartoesVencidos(row.GetCell("toleranciaemdiasparacartoesvencidosregrasdeacesso"));
            _page.PreencherTempoDesistenciaEntrada(row.GetCell("tempoconsideradoparadesistenciasegregrasdeacesso"));
            _page.MarcarTratarCartoesFantasma(Convert.ToBoolean(row.GetCell("tratarcartoesfantasmasregrasdeacesso")));
            _page.MarcarRejeitarCartoesInconsistentes(Convert.ToBoolean(row.GetCell("rejeitarcartoesinconsistentesnodispensadorregrasdeacesso")));
            _page.MarcarRealizarValidacaoEstadiaEntrada(Convert.ToBoolean(row.GetCell("realizarvalidacaodaestadiarnaentradaregrasdeacesso")));
            _page.MarcarPermitirEmissaoReciboImpressoraRemota(Convert.ToBoolean(row.GetCell("permitiremissaodereciboemimpressoraremotaregrasdeacesso")));
            _page.SelecionarAcaoCartaoSaldoNegativo(row.GetCell("permitiracessodeprepagoscomsaldonegativoregrasdeacesso"));
            _page.PreencherTempoTransitoEntreEquipamentos(row.GetCell("tempodetransitoentreequipamentosregrasdeacesso"));
            _page.SelecionarTempoDeTransitoAPartir(row.GetCell("calculatempodetransitoapartirregrasdeacesso"));
            _page.SelecionarAcaoTempoTransitoExcedido(row.GetCell("setempodetransitoexcedidoregrasdeacesso"));
            _page.SelecionarConsiderarVeiculos(row.GetCell("considerarveiculosregrasdeacesso"));
            _page.MarcarInformarPrismaEntrada(Convert.ToBoolean(row.GetCell("informarprismaemoperacaodeentradaregrasdeacesso")));
            _page.MarcarInformarPlacaEntrada(Convert.ToBoolean(row.GetCell("informarplacaemoperacaodeentradaregrasdeacesso")));
            _page.MarcarHabilitarPrismaIgualTicketEntrada(Convert.ToBoolean(row.GetCell("habilitarnumerodoprismaigualaoticketdeentradaregrasdeacesso")));
            _page.MarcarUtilizarListaVeiculosModeloMarca(Convert.ToBoolean(row.GetCell("utilizarlistadeveiculoscommodeloemarcaregrasdeacesso")));
            _page.MarcarPermitirTicketAvulsoEntrada(Convert.ToBoolean(row.GetCell("permitirgeracaodeticketnaentradaregrasdeacesso")));
            _page.MarcarReimprimirCodigoBarrasTicketEntradaCredenciado(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnoinformedeentradadecredenciadoregrasdeacesso")));
            _page.MarcarReimprimirCodigoBarrasTicketDevolucaoCredenciado(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnachamadadeveiculo")));
            _page.MarcarHabilitarValidacaoEstadiaEntrada(Convert.ToBoolean(row.GetCell("permitirvalidacaodaestadianaentradaregrasdeacesso")));
            _page.MarcarPermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida(Convert.ToBoolean(row.GetCell("permitirimpressaoremotadeinformativoparachamadadeveiculosemrealizarsaidaregrasdeacesso")));
            _page.MarcarExibirInformacaoLotadoDisplaySecundario(Convert.ToBoolean(row.GetCell("exibirinformacaodelotadonodisplaysecundarioregrasdeacesso")));
            _page.MarcarInformarLocalizacaoNaEntrada(Convert.ToBoolean(row.GetCell("informarlocalizacaodoveiculoemoperacaodeentradaregrasdeacesso")));

        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeAcessoPageStep] [16085]")]
        public void VerificarOsCamposDaTelaCriarumaregradeacessostepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeregrasdeacesso"));
                _page.RetornarFuncaoDeOperacaoDoEquipamento().Should().Be(row.GetCell("funcaodeoperacaoregradeacesso"));
                _page.RetornarSegunda().Should().Be(Convert.ToBoolean(row.GetCell("segundaregrasdeacesso")));
                _page.RetornarTerca().Should().Be(Convert.ToBoolean(row.GetCell("tercaregrasdeacesso")));
                _page.RetornarQuarta().Should().Be(Convert.ToBoolean(row.GetCell("quartaregrasdeacesso")));
                _page.RetornarQuinta().Should().Be(Convert.ToBoolean(row.GetCell("quintaregrasdeacesso")));
                _page.RetornarSexta().Should().Be(Convert.ToBoolean(row.GetCell("sextaregrasdeacesso")));
                _page.RetornarSabado().Should().Be(Convert.ToBoolean(row.GetCell("sabadoregrasdeacesso")));
                _page.RetornarDomingo().Should().Be(Convert.ToBoolean(row.GetCell("domingoregrasdeacesso")));
                _page.RetornarPeriodoValidoInicial().Should().Be(row.GetCell("dasregrasdeacesso"));
                _page.RetornarPeriodoValidoFinal().Should().Be(row.GetCell("asregrasdeacesso"));
                _page.RetornarVerificarBolsaoPrecedente().Should().Be((Convert.ToBoolean(row.GetCell("verificarbolsaoprecedente"))));
                _page.RetornarUmSelecionadoBolsaoDualist().Should().BeEquivalentTo(new string[] { row.GetCell("nomeBolsaoDeVagas") });
                _page.RetornarVeiculosPermitidos().Should().Be(row.GetCell("veiculospermitidosregrasdeacesso"));
                _page.RetornarCartoesVencidos().Should().Be(row.GetCell("cartoesvencidosregrasdeacesso"));
                _page.RetornarToleranciaEmDiasCartoesVencidos().Should().Be(row.GetCell("toleranciaemdiasparacartoesvencidosregrasdeacesso"));
                _page.RetornarTempoDesistenciaEntrada().Should().Be(row.GetCell("tempoconsideradoparadesistenciasegregrasdeacesso"));
                _page.RetornarTratarCartoesFantasma().Should().Be(Convert.ToBoolean(row.GetCell("tratarcartoesfantasmasregrasdeacesso")));
                _page.RetornarRejeitarCartoesInconsistentes().Should().Be(Convert.ToBoolean(row.GetCell("rejeitarcartoesinconsistentesnodispensadorregrasdeacesso")));
                _page.RetornarRealizarValidacaoEstadiaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("realizarvalidacaodaestadiarnaentradaregrasdeacesso")));
                _page.RetornarPermitirEmissaoReciboImpressoraRemota().Should().Be(Convert.ToBoolean(row.GetCell("permitiremissaodereciboemimpressoraremotaregrasdeacesso")));
                _page.RetornarAcaoCartaoSaldoNegativo().Should().Be(row.GetCell("permitiracessodeprepagoscomsaldonegativoregrasdeacesso"));
                _page.RetornarTempoTransitoEntreEquipamentos().Should().Be(row.GetCell("tempodetransitoentreequipamentosregrasdeacesso"));
                _page.RetornarTempoDeTransitoAPartir().Should().Be(row.GetCell("calculatempodetransitoapartirregrasdeacesso"));
                _page.RetornarAcaoTempoTransitoExcedido().Should().Be(row.GetCell("setempodetransitoexcedidoregrasdeacesso"));
                _page.RetornarConsiderarVeiculos().Should().Be(row.GetCell("considerarveiculosregrasdeacesso"));
                _page.RetornarInformarPrismaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("informarprismaemoperacaodeentradaregrasdeacesso")));
                _page.RetornarInformarPlacaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("informarplacaemoperacaodeentradaregrasdeacesso")));
                _page.RetornarHabilitarPrismaIgualTicketEntrada().Should().Be(Convert.ToBoolean(row.GetCell("habilitarnumerodoprismaigualaoticketdeentradaregrasdeacesso")));
                _page.RetornarUtilizarListaVeiculosModeloMarca().Should().Be(Convert.ToBoolean(row.GetCell("utilizarlistadeveiculoscommodeloemarcaregrasdeacesso")));
                _page.RetornarPermitirTicketAvulsoEntrada().Should().Be(Convert.ToBoolean(row.GetCell("permitirgeracaodeticketnaentradaregrasdeacesso")));
                _page.RetornarReimprimirCodigoBarrasTicketEntradaCredenciado().Should().Be(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnoinformedeentradadecredenciadoregrasdeacesso")));
                _page.RetornarReimprimirCodigoBarrasTicketDevolucaoCredenciado().Should().Be(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnachamadadeveiculo")));
                _page.RetornarHabilitarValidacaoEstadiaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("permitirvalidacaodaestadianaentradaregrasdeacesso")));
                _page.RetornarPermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida().Should().Be(Convert.ToBoolean(row.GetCell("permitirimpressaoremotadeinformativoparachamadadeveiculosemrealizarsaidaregrasdeacesso")));
                _page.RetornarExibirInformacaoLotadoDisplaySecundario().Should().Be(Convert.ToBoolean(row.GetCell("exibirinformacaodelotadonodisplaysecundarioregrasdeacesso")));
                _page.RetornarInformarLocalizacaoNaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("informarlocalizacaodoveiculoemoperacaodeentradaregrasdeacesso")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16271]")]
        public void PreencherOsCamposDaTelaCriarumaregradeacessostepbysteppagestep16271(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAcessoCarro(row.GetCell("carroregrasdeacesso"));
            _page.SelecionarAcessoMoto(row.GetCell("motoregrasdeacesso"));
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16012]")]
        public void PreencherOsCamposDaTelaRegrasdeacessopagestep16012(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarDomingo(Convert.ToBoolean(row.GetCell("domingoRegrasDeAcesso")));
            _page.MarcarVerificarBolsaoPrecedente(Convert.ToBoolean(row.GetCell("verificarBolsaoPrecedenteRegrasDeAcesso")));
            _page.MarcarVerificarBolsaoPrecedente(Convert.ToBoolean(row.GetCell("verificarBolsaoPrecedenteRegrasDeAcesso")));
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16013]")]
        public void PreencherOsCamposDaTelaRegrasdeacessopagestep16013(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarDomingo(Convert.ToBoolean(row.GetCell("domingoRegrasDeAcesso")));
            _page.MarcarInfinitoDesistenciaEntrada(Convert.ToBoolean(row.GetCell("tempoconsideradoparadesistenciaseginfinitoregrasdeacesso")));

        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16014]")]
        public void PreencherOsCamposDaTelaRegrasdeacessopagestep16014(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarDomingo(Convert.ToBoolean(row.GetCell("domingoRegrasDeAcesso")));
            _page.MarcarInfinitoTransitoEntreEquipamentos(Convert.ToBoolean(row.GetCell("infinitoRegrasDeAcesso"))); //rever o porquê do gerador ter repetido 
            _page.MarcarInfinitoTransitoEntreEquipamentos(Convert.ToBoolean(row.GetCell("infinitoRegrasDeAcesso")));

        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16033]")]
        public void PreencherOsCamposDaTelaRegrasdeacessopagestep16033(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarDomingo(Convert.ToBoolean(row.GetCell("domingoregrasdeacesso")));
            _page.MarcarVerificarBolsaoPrecedente(Convert.ToBoolean(row.GetCell("verificarbolsaoprecedente")));
            _page.SelecionarVeiculosPermitidos("");
            _page.SelecionarCartoesVencidos("");
            _page.SelecionarAcaoCartaoSaldoNegativo("");
            _page.PreencherTempoTransitoEntreEquipamentos(" ");
            _page.SelecionarTempoDeTransitoAPartir("");
            _page.SelecionarAcaoTempoTransitoExcedido("");
            _page.SelecionarConsiderarVeiculos("");
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeAcessoPageStep] [16134]")]
        public void PreencherOsCamposDaTelaRegrasdeacessopagestep16134(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteregrasdeacessoalterar")));
            _page.PreencherNome(row.GetCell("nomeregrasdeacessoalterar"));
            _page.SelecionarFuncaoDeOperacaoDoEquipamento(row.GetCell("funcaodeoperacaoregradeacessoalterar"));
            _page.PreencherPeriodoValidoInicial(row.GetCell("dasregrasdeacessoalterar"));
            _page.PreencherPeriodoValidoFinal(row.GetCell("asregrasdeacessoalterar"));
            _page.MarcarVerificarBolsaoPrecedente(Convert.ToBoolean(row.GetCell("verificarbolsaoprecedentealterar")));
            _page.SelecionarVeiculosPermitidos(row.GetCell("veiculospermitidosregrasdeacessoalterar"));
            _page.SelecionarCartoesVencidos(row.GetCell("cartoesvencidosregrasdeacessoalterar"));
            _page.PreencherToleranciaEmDiasCartoesVencidos(row.GetCell("toleranciaemdiasparacartoesvencidosregrasdeacessoalterar"));
            _page.PreencherTempoDesistenciaEntrada(row.GetCell("tempoconsideradoparadesistenciasegregrasdeacessoalterar"));
            _page.MarcarTratarCartoesFantasma(Convert.ToBoolean(row.GetCell("tratarcartoesfantasmasregrasdeacessoalterar")));
            _page.MarcarRejeitarCartoesInconsistentes(Convert.ToBoolean(row.GetCell("rejeitarcartoesinconsistentesnodispensadorregrasdeacessoalterar")));
            _page.MarcarRealizarValidacaoEstadiaEntrada(Convert.ToBoolean(row.GetCell("realizarvalidacaodaestadiarnaentradaregrasdeacessoalterar")));
            _page.MarcarPermitirEmissaoReciboImpressoraRemota(Convert.ToBoolean(row.GetCell("permitiremissaodereciboemimpressoraremotaregrasdeacessoalterar")));
            _page.SelecionarAcaoCartaoSaldoNegativo(row.GetCell("permitiracessodeprepagoscomsaldonegativoregrasdeacessoalterar"));
            _page.PreencherTempoTransitoEntreEquipamentos(row.GetCell("tempodetransitoentreequipamentosregrasdeacessoalterar"));
            _page.SelecionarTempoDeTransitoAPartir(row.GetCell("calculatempodetransitoapartirregrasdeacessoalterar"));
            _page.SelecionarAcaoTempoTransitoExcedido(row.GetCell("setempodetransitoexcedidoregrasdeacessoalterar"));
            _page.SelecionarConsiderarVeiculos(row.GetCell("considerarveiculosregrasdeacessoalterar"));
            _page.MarcarInformarPrismaEntrada(Convert.ToBoolean(row.GetCell("informarprismaemoperacaodeentradaregrasdeacessoalterar")));
            _page.MarcarInformarPlacaEntrada(Convert.ToBoolean(row.GetCell("informarplacaemoperacaodeentradaregrasdeacessoalterar")));
            _page.MarcarHabilitarPrismaIgualTicketEntrada(Convert.ToBoolean(row.GetCell("habilitarnumerodoprismaigualaoticketdeentradaregrasdeacessoalterar")));
            _page.MarcarHabilitarPrismaIgualTicketEntrada(Convert.ToBoolean(row.GetCell("habilitarnumerodoprismaigualaoticketdeentradaregrasdeacessoalterar")));
            _page.MarcarUtilizarListaVeiculosModeloMarca(Convert.ToBoolean(row.GetCell("utilizarlistadeveiculoscommodeloemarcaregrasdeacessoalterar")));
            _page.MarcarPermitirTicketAvulsoEntrada(Convert.ToBoolean(row.GetCell("permitirgeracaodeticketnaentradaregrasdeacessoalterar")));
            _page.MarcarReimprimirCodigoBarrasTicketEntradaCredenciado(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnoinformedeentradadecredenciadoregrasdeacessoalterar")));
            _page.MarcarReimprimirCodigoBarrasTicketDevolucaoCredenciado(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnachamadadeveiculoalterar")));
            _page.MarcarHabilitarValidacaoEstadiaEntrada(Convert.ToBoolean(row.GetCell("permitirvalidacaodaestadianaentradaregrasdeacessoalterar")));
            _page.MarcarPermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida(Convert.ToBoolean(row.GetCell("permitirimpressaoremotadeinformativoparachamadadeveiculosemrealizarsaidaregrasdeacessoalterar")));
            _page.MarcarExibirInformacaoLotadoDisplaySecundario(Convert.ToBoolean(row.GetCell("exibirinformacaodelotadonodisplaysecundarioregrasdeacessoalterar")));
            _page.MarcarInformarLocalizacaoNaEntrada(Convert.ToBoolean(row.GetCell("informarlocalizacaodoveiculoemoperacaodeentradaregrasdeacessoalterar")));
        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeAcessoPageStep] [16134]")]
        public void VerificarOsCamposDaTelaRegrasdeacessopagestep16134(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeregrasdeacessoalterar"));
                _page.RetornarFuncaoDeOperacaoDoEquipamento().Should().Be(row.GetCell("funcaodeoperacaoregradeacessoalterar"));
                _page.RetornarSegunda().Should().Be(Convert.ToBoolean(row.GetCell("segundaregrasdeacesso")));
                _page.RetornarTerca().Should().Be(Convert.ToBoolean(row.GetCell("tercaregrasdeacesso")));
                _page.RetornarQuarta().Should().Be(Convert.ToBoolean(row.GetCell("quartaregrasdeacesso")));
                _page.RetornarQuinta().Should().Be(Convert.ToBoolean(row.GetCell("quintaregrasdeacesso")));
                _page.RetornarSexta().Should().Be(Convert.ToBoolean(row.GetCell("sextaregrasdeacesso")));
                _page.RetornarSabado().Should().Be(Convert.ToBoolean(row.GetCell("sabadoregrasdeacesso")));
                _page.RetornarDomingo().Should().Be(Convert.ToBoolean(row.GetCell("domingoregrasdeacesso")));
                _page.RetornarPeriodoValidoInicial().Should().Be(row.GetCell("dasregrasdeacessoalterar"));
                _page.RetornarPeriodoValidoFinal().Should().Be(row.GetCell("asregrasdeacessoalterar"));
                _page.RetornarVerificarBolsaoPrecedente().Should().Be((Convert.ToBoolean(row.GetCell("verificarbolsaoprecedentealterar"))));
                _page.RetornarVeiculosPermitidos().Should().Be(row.GetCell("veiculospermitidosregrasdeacessoalterar"));
                _page.RetornarCartoesVencidos().Should().Be(row.GetCell("cartoesvencidosregrasdeacessoalterar"));
                _page.RetornarTempoDesistenciaEntrada().Should().Be(row.GetCell("tempoconsideradoparadesistenciasegregrasdeacessoalterar"));
                _page.RetornarTratarCartoesFantasma().Should().Be(Convert.ToBoolean(row.GetCell("tratarcartoesfantasmasregrasdeacessoalterar")));
                _page.RetornarRejeitarCartoesInconsistentes().Should().Be(Convert.ToBoolean(row.GetCell("rejeitarcartoesinconsistentesnodispensadorregrasdeacessoalterar")));
                _page.RetornarRealizarValidacaoEstadiaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("realizarvalidacaodaestadiarnaentradaregrasdeacessoalterar")));
                _page.RetornarPermitirEmissaoReciboImpressoraRemota().Should().Be(Convert.ToBoolean(row.GetCell("permitiremissaodereciboemimpressoraremotaregrasdeacessoalterar")));
                _page.RetornarAcaoCartaoSaldoNegativo().Should().Be(row.GetCell("permitiracessodeprepagoscomsaldonegativoregrasdeacessoalterar"));
                _page.RetornarTempoTransitoEntreEquipamentos().Should().Be(row.GetCell("tempodetransitoentreequipamentosregrasdeacessoalterar"));
                _page.RetornarTempoDeTransitoAPartir().Should().Be(row.GetCell("calculatempodetransitoapartirregrasdeacessoalterar"));
                _page.RetornarAcaoTempoTransitoExcedido().Should().Be(row.GetCell("setempodetransitoexcedidoregrasdeacessoalterar"));
                _page.RetornarConsiderarVeiculos().Should().Be(row.GetCell("considerarveiculosregrasdeacessoalterar"));
                _page.RetornarInformarPrismaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("informarprismaemoperacaodeentradaregrasdeacessoalterar")));
                _page.RetornarInformarPlacaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("informarplacaemoperacaodeentradaregrasdeacessoalterar")));
                _page.RetornarHabilitarPrismaIgualTicketEntrada().Should().Be(Convert.ToBoolean(row.GetCell("habilitarnumerodoprismaigualaoticketdeentradaregrasdeacessoalterar")));
                _page.RetornarUtilizarListaVeiculosModeloMarca().Should().Be(Convert.ToBoolean(row.GetCell("utilizarlistadeveiculoscommodeloemarcaregrasdeacessoalterar")));
                _page.RetornarPermitirTicketAvulsoEntrada().Should().Be(Convert.ToBoolean(row.GetCell("permitirgeracaodeticketnaentradaregrasdeacessoalterar")));
                _page.RetornarReimprimirCodigoBarrasTicketEntradaCredenciado().Should().Be(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnoinformedeentradadecredenciadoregrasdeacessoalterar")));
                _page.RetornarReimprimirCodigoBarrasTicketDevolucaoCredenciado().Should().Be(Convert.ToBoolean(row.GetCell("reimprimircodigodebarrasnachamadadeveiculoalterar")));
                _page.RetornarHabilitarValidacaoEstadiaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("permitirvalidacaodaestadianaentradaregrasdeacessoalterar")));
                _page.RetornarPermitirImpressaoRemotaInformativoParaChamadaVeiculoSemRealizarSaida().Should().Be(Convert.ToBoolean(row.GetCell("permitirimpressaoremotadeinformativoparachamadadeveiculosemrealizarsaidaregrasdeacessoalterar")));
                _page.RetornarExibirInformacaoLotadoDisplaySecundario().Should().Be(Convert.ToBoolean(row.GetCell("exibirinformacaodelotadonodisplaysecundarioregrasdeacessoalterar")));
                _page.RetornarInformarLocalizacaoNaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("informarlocalizacaodoveiculoemoperacaodeentradaregrasdeacessoalterar")));
            }
        }
    }
}