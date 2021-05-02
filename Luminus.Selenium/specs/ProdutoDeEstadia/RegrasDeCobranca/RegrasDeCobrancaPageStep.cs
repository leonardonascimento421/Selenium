
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeCobranca;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.RegrasDeCobranca
{
    public class RegrasDeCobrancaPageStep
    {
        private RegrasDeCobrancaPage _page = new RegrasDeCobrancaPage();

        [Step("Preencher os campos da tela <tabela> [RegrasDeCobrancaPageStep] [16135]")]
        public void PreencherOsCamposDaTelaRegrasdecobrancapagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
           _page.PreencherNome(row.GetCell("nomeRegrasDeCobranca"));
           _page.MarcarValorMaximoDiarioReferenteAoHorarioEntrada(Convert.ToBoolean(row.GetCell("valorMaximoDiarioReferenteAoHorarioEntrada")));
           _page.PreencherValorMaximoEstadiaSemAprovacao(row.GetCell("valorMaximoDaEstadiaSemAprovacaoRegrasDeCobranca"));
           _page.MarcarUsarValorMaximoEstadiaAposMudancaDeDia(Convert.ToBoolean(row.GetCell("usarValorMaximoDeEstadiaAposMudancaDeDiaOperacionalRegrasDeCobranca")));
           _page.PreencherQuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados(row.GetCell("quantidadeDeDiasAntecedenciaDePermitidaParaRevalidacaoDeCredenciadosRegrasDeCobranca"));
           _page.MarcarManter(Convert.ToBoolean(row.GetCell("manterProximaFracaoRegrasDeCobranca")));
           _page.SelecionarMetodoDeCalculo(row.GetCell("metodoDeCalculoRegrasDeCobranca"));
           _page.SelecionarMetodoDeCalculoParaRepagamento(row.GetCell("metodoDeCalculosParaRepagamentosRegrasDeCobranca"));
           _page.MarcarCobrarUsandoApenasValoresPeriodoDaEntrada(Convert.ToBoolean(row.GetCell("cobrarUsandoApenasValoresDoPeriodoDaEntradaRegrasDeCobranca")));
           _page.MarcarInterromperFracaoDoPeriodoNaMudancaPerido(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDePeriodoRegrasDeCobranca")));
           _page.MarcarInterromperFracaoDoPeriodoNaMudancaDia(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeDiaRegrasDeCobranca")));
           _page.MarcarInterromperFracaoDoPeriodoNaMudancaEstrutura(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeEstruturaRegrasDeCobranca")));
           _page.MarcarPermitirPagarFracaoFuturo(Convert.ToBoolean(row.GetCell("permitirAvancoDeEstadiaParaValidacaoRegrasDeCobranca")));
           _page.MarcarPermitirOperadorAlterarCamposRecarga(Convert.ToBoolean(row.GetCell("permitirOperadorAlterarCamposDeRecargaRegrasDeCobranca")));
           _page.MarcarHabilitarOpcaoRecargaManualPrePago(Convert.ToBoolean(row.GetCell("habilitarOpcaoDeRecargaManualDePrePagoRegrasDeCobranca")));
           _page.MarcarPermitirRetrocessoEstadiaNaValidacao(Convert.ToBoolean(row.GetCell("permitirRetrocessoDeEstadiaParaValidacaoRegrasDeCobranca")));
           _page.MarcarHabilitarPagamentoAvulsoComCartaoPrePago(Convert.ToBoolean(row.GetCell("habilitarPagamentoAvulsoComCartaoPrePagoRegrasDeCobranca")));
           _page.MarcarHabilitarTransferenciaAvulsoParaPrePago(Convert.ToBoolean(row.GetCell("habilitarTransferenciaAvulsoParaPrePagoRegraDeCobranca")));
           _page.MarcarSemLimite(Convert.ToBoolean(row.GetCell("semLimiteRegrasDeCobranca")));
           _page.PreencherTempoAdicionalAntesMudancaFracaoPeriodo(row.GetCell("tempoAdicionalAntesDaMudancaDeFracaoDoPeriodoRegrasDeCobranca"));
           _page.PreencherNivelOperadorMinimoParaEditarExtensaoValidade(row.GetCell("nivelDoOperadorMinimoParaEditarExtensaoValidadeRegrasDeCobranca"));
           _page.SelecionarModoDeOtimizacaoDeCobranca(row.GetCell("modoDeOtimizacaoDeCobrancaRegrasDeCobranca"));
           _page.SelecionarBolsaoDeAcessoARevalidacao(row.GetCell("bolsaoDeAcessoARevalidacaoRegrasDeCobranca"));
           _page.SelecionarBloquearValidacaoDeEstadiaZerada(row.GetCell("bloquearValidacaoDeEstadiaZeradaRegrasDeCobranca"));
           _page.SelecionarComportamentoDeRevalidacaoDeCredenciadosVencidos(row.GetCell("comportamentoDeRevalidacaoDeCredenciadosVencidos"));
           _page.PreencherQuantidadeTempoSupostaDaEntradaDias(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmDiasRegrasDeCobranca"));
           _page.PreencherQuantidadeTempoSupostaDaEntradaHoras(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmHorasRegrasDeCobranca"));
           _page.PreencherQuantidadeTempoSupostaDaEntradaMinutos(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmMinutosRegrasDeCobranca"));
           _page.SelecionarFormasDePagamento(row.GetCell("formasDePagamentoRegrasDeCobranca"));
           _page.MarcarVerificarBolsaoPrecedente(Convert.ToBoolean(row.GetCell("naoSeAplicaRegrasDeCobranca")));           
        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeCobrancaPageStep] [16135]")]
        public void VerificarOsCamposDaTelaDetalharregradecobrancastepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeRegrasDeCobranca"));
                _page.RetornarValorMaximoDiarioReferenteAoHorarioEntrada().Should().Be(Convert.ToBoolean(row.GetCell("valorMaximoDiarioReferenteAoHorarioEntrada")));
                _page.RetornarValorMaximoEstadiaSemAprovacao().Should().Be(row.GetCell("valorMaximoDaEstadiaSemAprovacaoRegrasDeCobranca"));
                _page.RetornarUsarValorMaximoEstadiaAposMudancaDeDia().Should().Be(Convert.ToBoolean(row.GetCell("usarValorMaximoDeEstadiaAposMudancaDeDiaOperacionalRegrasDeCobranca")));
                _page.RetornarQuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados().Should().Be(row.GetCell("quantidadeDeDiasAntecedenciaDePermitidaParaRevalidacaoDeCredenciadosRegrasDeCobranca"));               
                _page.RetornarManter().Should().Be(Convert.ToBoolean(row.GetCell("manterProximaFracaoRegrasDeCobranca")));
                _page.RetornarMetodoDeCalculo().Should().Be(row.GetCell("metodoDeCalculoRegrasDeCobranca"));
                _page.RetornarMetodoDeCalculoParaRepagamento().Should().Be(row.GetCell("metodoDeCalculosParaRepagamentosRegrasDeCobranca"));
                _page.RetornarCobrarUsandoApenasValoresPeriodoDaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("cobrarUsandoApenasValoresDoPeriodoDaEntradaRegrasDeCobranca")));
                _page.RetornarInterromperFracaoDoPeriodoNaMudancaPerido().Should().Be(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDePeriodoRegrasDeCobranca")));
                _page.RetornarInterromperFracaoDoPeriodoNaMudancaDia().Should().Be(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeDiaRegrasDeCobranca")));
                _page.RetornarInterromperFracaoDoPeriodoNaMudancaEstrutura().Should().Be(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeEstruturaRegrasDeCobranca")));
                _page.RetornarPermitirPagarFracaoFuturo().Should().Be(Convert.ToBoolean(Convert.ToBoolean(row.GetCell("permitirAvancoDeEstadiaParaValidacaoRegrasDeCobranca"))));
                _page.RetornarPermitirOperadorAlterarCamposRecarga().Should().Be(Convert.ToBoolean(row.GetCell("permitirOperadorAlterarCamposDeRecargaRegrasDeCobranca")));
                _page.RetornarHabilitarOpcaoRecargaManualPrePago().Should().Be(Convert.ToBoolean(row.GetCell("habilitarOpcaoDeRecargaManualDePrePagoRegrasDeCobranca")));
                _page.RetornarPermitirRetrocessoEstadiaNaValidacao().Should().Be(Convert.ToBoolean(row.GetCell("permitirRetrocessoDeEstadiaParaValidacaoRegrasDeCobranca")));
                _page.RetornarHabilitarPagamentoAvulsoComCartaoPrePago().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPagamentoAvulsoComCartaoPrePagoRegrasDeCobranca")));
                _page.RetornarHabilitarTransferenciaAvulsoParaPrePago().Should().Be(Convert.ToBoolean(row.GetCell("habilitarTransferenciaAvulsoParaPrePagoRegraDeCobranca")));
                _page.RetornarSemLimite().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteRegrasDeCobranca")));
                _page.RetornarTempoAdicionalAntesMudancaFracaoPeriodo().Should().Be(row.GetCell("tempoAdicionalAntesDaMudancaDeFracaoDoPeriodoRegrasDeCobranca"));
                _page.RetornarNivelOperadorMinimoParaEditarExtensaoValidade().Should().Be(row.GetCell("nivelDoOperadorMinimoParaEditarExtensaoValidadeRegrasDeCobranca"));
                _page.RetornarModoDeOtimizacaoDeCobranca().Should().BeEquivalentTo(row.GetCell("modoDeOtimizacaoDeCobrancaRegrasDeCobranca"));
                _page.RetornarBolsaoDeAcessoARevalidacao().Should().BeEquivalentTo(row.GetCell("bolsaoDeAcessoARevalidacaoRegrasDeCobranca"));
                _page.RetornarBloquearValidacaoDeEstadiaZerada().Should().BeEquivalentTo(row.GetCell("bloquearValidacaoDeEstadiaZeradaRegrasDeCobranca"));
                _page.RetornarComportamentoDeRevalidacaoDeCredenciadosVencidos().Should().BeEquivalentTo(row.GetCell("comportamentoDeRevalidacaoDeCredenciadosVencidos"));
                _page.RetornarQuantidadeTempoSupostaDaEntradaDias().Should().Be(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmDiasRegrasDeCobranca"));
                _page.RetornarQuantidadeTempoSupostaDaEntradaHoras().Should().Be(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmHorasRegrasDeCobranca"));
                _page.RetornarQuantidadeTempoSupostaDaEntradaMinutos().Should().Be(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmMinutosRegrasDeCobranca"));
                _page.RetornarFormasDePagamento().Should().Be(row.GetCell("formasDePagamentoRegrasDeCobranca"));
                _page.RetornarVerificarBolsaoPrecedente().Should().Be(Convert.ToBoolean(row.GetCell("naoSeAplicaRegrasDeCobranca")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeCobrancaPageStep] [15950]")]
        public void PreencherOsCamposDaTelaRegrasdecobrancapagestep15950(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeRegrasDeCobranca"));
            _page.PreencherValorMaximoDiario(row.GetCell("valorMaximoDiario"));
            _page.PreencherValorMaximoEstadia(row.GetCell("valorMaximoDaEstadia"));
            _page.PreencherValorMaximoEstadiaSemAprovacao(row.GetCell("valorMaximoDaEstadiaSemAprovacaoRegrasDeCobranca"));
            _page.PreencherNivelOperadorMinimoParaAprovacao(row.GetCell("nivelOperadorMinimoParaAprovacao"));
            _page.PreencherProximaFracaoPeriodoAposMudancaEstrutura(row.GetCell("proximaFracaoPeriodoAposMudancaEstrutura"));
            _page.PreencherLimiteDeTempoDeEstadiaParaTransferenciaDeAvulsos(row.GetCell("limiteDeTempoDeEstadiaParaTransferenciaDeAvulsos"));
            _page.PreencherTempoAdicionalAntesMudancaFracaoPeriodo(row.GetCell("tempoAdicionalAntesDaMudancaDeFracaoDoPeriodoRegrasDeCobranca"));
            _page.PreencherNivelOperadorMinimoParaEditarExtensaoValidade(row.GetCell("nivelDoOperadorMinimoParaEditarExtensaoValidadeRegrasDeCobranca"));     
            _page.PreencherQuantidadeTempoSupostaDaEntradaDias(row.GetCell("quantidadeTempoSupostaDaEntradaDias"));     
            _page.PreencherQuantidadeTempoSupostaDaEntradaHoras(row.GetCell("quantidadeTempoSupostaDaEntradaHoras"));     
            _page.PreencherQuantidadeTempoSupostaDaEntradaMinutos(row.GetCell("quantidadeTempoSupostaDaEntradaMinutos"));     
            
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeCobrancaPageStep] [15951]")]
        public void PreencherOsCamposDaTelaRegrasdecobrancapagestep15951(Table tabela)
        {       
            var row = tabela.GetTableRows()[0];
           _page.PreencherValorMaximoDiario(row.GetCell("valorMaximoDiarioReferenteAoHorarioDeEntradaRegrasDeCobranca"));
           _page.PreencherValorMaximoEstadia(row.GetCell("valorMaximoDaEstadiaRegrasDeCobranca"));
           _page.PreencherValorMaximoEstadiaSemAprovacao(row.GetCell("valorMaximoDaEstadiaSemAprovacaoRegrasDeCobranca"));
           _page.PreencherNivelOperadorMinimoParaAprovacao(row.GetCell("nivelDoOperadorMinimoParaAprovacaoRegrasDeCobranca"));
           _page.PreencherProximaFracaoPeriodoAposMudancaEstrutura(row.GetCell("proximaFracaoDoPeriodoRegrasDeCobranca"));
           _page.PreencherNivelOperadorMinimoParaEditarExtensaoValidade(row.GetCell("nivelOperadorMinimoParaEditarExtensaoValidadeRegrasDeCobranca"));       
        }

        [Step("Preencher os campos da tela <tabela> [RegrasDeCobrancaPageStep] [15952]")]
        public void PreencherOsCamposDaTelaRegrasdecobrancapagestep15952(Table tabela)
        {
           var row = tabela.GetTableRows()[0];
           _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteregrasDeCobrancaalterar")));
           _page.PreencherNome(row.GetCell("nomeRegrasDeCobrancaalterar"));
           _page.MarcarValorMaximoDiarioReferenteAoHorarioEntrada(Convert.ToBoolean(row.GetCell("valorMaximoDiarioReferenteAoHorarioDeEntradaRegrasDeCobrancaalterar")));
           _page.PreencherValorMaximoDiario(row.GetCell("valorMaximoDiarioalterar"));
           _page.PreencherValorMaximoEstadia(row.GetCell("valormaximodaestadiaregrasdecobrancaalterar"));
           _page.PreencherValorMaximoEstadiaSemAprovacao(row.GetCell("valorMaximoDaEstadiaSemAprovacaoRegrasDeCobrancaalterar"));
           _page.PreencherNivelOperadorMinimoParaAprovacao(row.GetCell("niveldooperadorminimoparaaprovacaoregrasdecobrancaalterar"));
           _page.MarcarUsarValorMaximoEstadiaAposMudancaDeDia(Convert.ToBoolean(row.GetCell("usarValorMaximoDeEstadiaAposMudancaDeDiaOperacionalRegrasDeCobrancaalterar")));
           _page.PreencherQuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados(row.GetCell("quantidadeDeDiasAntecedenciaDePermitidaParaRevalidacaoDeCredenciadosRegrasDeCobrancaalterar"));
           _page.MarcarManter(Convert.ToBoolean(row.GetCell("manterProximaFracaoRegrasDeCobrancaalterar")));
           _page.PreencherProximaFracaoPeriodoAposMudancaEstrutura(row.GetCell("proximaFracaoDoPeriodoRegrasDeCobranca"));
           _page.SelecionarMetodoDeCalculo(row.GetCell("metodoDeCalculoRegrasDeCobrancaalterar"));
           _page.SelecionarMetodoDeCalculoParaRepagamento(row.GetCell("metodoDeCalculosParaRepagamentosRegrasDeCobrancaalterar"));
           _page.MarcarCobrarUsandoApenasValoresPeriodoDaEntrada(Convert.ToBoolean(row.GetCell("cobrarUsandoApenasValoresDoPeriodoDaEntradaRegrasDeCobrancaalterar")));
           _page.MarcarInterromperFracaoDoPeriodoNaMudancaPerido(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDePeriodoRegrasDeCobrancaalterar")));
           _page.MarcarInterromperFracaoDoPeriodoNaMudancaDia(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeDiaRegrasDeCobrancaalterar")));
           _page.MarcarInterromperFracaoDoPeriodoNaMudancaEstrutura(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeEstruturaRegrasDeCobrancaalterar")));
           _page.MarcarPermitirPagarFracaoFuturo(Convert.ToBoolean(row.GetCell("permitirAvancoDeEstadiaParaValidacaoRegrasDeCobrancaalterar")));
           _page.MarcarPermitirOperadorAlterarCamposRecarga(Convert.ToBoolean(row.GetCell("permitirOperadorAlterarCamposDeRecargaRegrasDeCobrancaalterar")));
           _page.MarcarHabilitarOpcaoRecargaManualPrePago(Convert.ToBoolean(row.GetCell("habilitarOpcaoDeRecargaManualDePrePagoRegrasDeCobrancaalterar")));
           _page.MarcarPermitirRetrocessoEstadiaNaValidacao(Convert.ToBoolean(row.GetCell("permitirRetrocessoDeEstadiaParaValidacaoRegrasDeCobrancaalterar")));
           _page.MarcarHabilitarPagamentoAvulsoComCartaoPrePago(Convert.ToBoolean(row.GetCell("habilitarPagamentoAvulsoComCartaoPrePagoRegrasDeCobrancaalterar")));
           _page.MarcarHabilitarTransferenciaAvulsoParaPrePago(Convert.ToBoolean(row.GetCell("habilitarTransferenciaAvulsoParaPrePagoRegraDeCobrancaalterar")));
           _page.MarcarSemLimite(Convert.ToBoolean(row.GetCell("semLimiteRegrasDeCobrancaalterar")));
           _page.PreencherLimiteDeTempoDeEstadiaParaTransferenciaDeAvulsos(row.GetCell("bloquearTransferenciaDoAvulsoComMaisDeRegrasDeCobrancaalterar"));
           _page.PreencherTempoAdicionalAntesMudancaFracaoPeriodo(row.GetCell("tempoAdicionalAntesDaMudancaDeFracaoDoPeriodoRegrasDeCobrancaalterar"));
           _page.PreencherNivelOperadorMinimoParaEditarExtensaoValidade(row.GetCell("nivelOperadorMinimoParaEditarExtensaoValidadeRegrasDeCobrancaalterar"));
           _page.SelecionarModoDeOtimizacaoDeCobranca(row.GetCell("modoDeOtimizacaoDeCobrancaRegrasDeCobrancaalterar"));
           _page.SelecionarBolsaoDeAcessoARevalidacao(row.GetCell("bolsaoDeAcessoARevalidacaoRegrasDeCobrancaalterar"));
           _page.SelecionarBloquearValidacaoDeEstadiaZerada(row.GetCell("bloquearValidacaoDeEstadiaZeradaRegrasDeCobrancaalterar"));
           _page.SelecionarTabelaDeCobrancaSupostaDaEntrada(row.GetCell("nometabelasdecobranca"));
           _page.SelecionarComportamentoDeRevalidacaoDeCredenciadosVencidos(row.GetCell("comportamentoDeRevalidacaoDeCredenciadosVencidosalterar"));
           _page.PreencherQuantidadeTempoSupostaDaEntradaDias(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmDiasRegrasDeCobrancaalterar"));
           _page.PreencherQuantidadeTempoSupostaDaEntradaHoras(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmHorasRegrasDeCobrancaalterar"));
           _page.PreencherQuantidadeTempoSupostaDaEntradaMinutos(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmMinutosRegrasDeCobrancaalterar"));
           _page.SelecionarFormasDePagamento(row.GetCell("formasDePagamentoRegrasDeCobrancaalterar"));
           _page.SelecionarUmaTabelaDeCobrancaInibidaParaAValidacaoDeAvulsos(row.GetCell("nometabelasdecobranca"));
           _page.ClicarBotaoMoverComIndice(1);
           _page.SelecionarUmaTabelaDeCobrancaInibidaParaAValidacaoDePrePago(row.GetCell("nometabelasdecobranca"));
           _page.ClicarBotaoMoverComIndice(2);
           _page.MarcarVerificarBolsaoPrecedente(Convert.ToBoolean(row.GetCell("naoSeAplicaRegrasDeCobrancaalterar")));
           _page.SelecionarUmBolsaoDualist(row.GetCell("nomeBolsaoDeVagas"));
        }

        [Step("Verificar os campos da tela <tabela> [RegrasDeCobrancaPageStep] [15952]")]
        public void VerificarOsCamposDaTelaDetalharregradecobrancastepbysteppagestep15952(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeRegrasDeCobrancaalterar"));
                _page.RetornarValorMaximoDiarioReferenteAoHorarioEntrada().Should().Be(Convert.ToBoolean(row.GetCell("valorMaximoDiarioReferenteAoHorarioDeEntradaRegrasDeCobrancaalterar")));
                _page.RetornarValorMaximoDiario().Should().Be(row.GetCell("valorMaximoDiarioalterar")); 
                _page.RetornarValorMaximoEstadia().Should().Be(row.GetCell("valormaximodaestadiaregrasdecobrancaalterar")); 
                _page.RetornarValorMaximoEstadiaSemAprovacao().Should().Be(row.GetCell("valorMaximoDaEstadiaSemAprovacaoRegrasDeCobrancaalterar")); 
                _page.RetornarNivelOperadorMinimoParaAprovacao().Should().Be(row.GetCell("niveldooperadorminimoparaaprovacaoregrasdecobrancaalterar"));
                _page.RetornarUsarValorMaximoEstadiaAposMudancaDeDia().Should().Be(Convert.ToBoolean(row.GetCell("usarValorMaximoDeEstadiaAposMudancaDeDiaOperacionalRegrasDeCobrancaalterar")));
                _page.RetornarQuantidadeDiasAntecedenciaPermitidaParaRevalidacaoCredenciados().Should().Be(row.GetCell("quantidadeDeDiasAntecedenciaDePermitidaParaRevalidacaoDeCredenciadosRegrasDeCobrancaalterar"));
                _page.RetornarManter().Should().Be(Convert.ToBoolean(row.GetCell("manterProximaFracaoRegrasDeCobrancaalterar")));
                _page.RetornarMetodoDeCalculo().Should().Be(row.GetCell("metodoDeCalculoRegrasDeCobrancaalterar"));
                _page.RetornarMetodoDeCalculoParaRepagamento().Should().Be(row.GetCell("metodoDeCalculosParaRepagamentosRegrasDeCobrancaalterar"));
                _page.RetornarCobrarUsandoApenasValoresPeriodoDaEntrada().Should().Be(Convert.ToBoolean(row.GetCell("cobrarUsandoApenasValoresDoPeriodoDaEntradaRegrasDeCobrancaalterar")));
                _page.RetornarInterromperFracaoDoPeriodoNaMudancaPerido().Should().Be(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDePeriodoRegrasDeCobrancaalterar")));
                _page.RetornarInterromperFracaoDoPeriodoNaMudancaDia().Should().Be(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeDiaRegrasDeCobrancaalterar")));
                _page.RetornarInterromperFracaoDoPeriodoNaMudancaEstrutura().Should().Be(Convert.ToBoolean(row.GetCell("interromperFracaoDoPeriodoNaMudancaDeEstruturaRegrasDeCobrancaalterar")));
                _page.RetornarPermitirPagarFracaoFuturo().Should().Be(Convert.ToBoolean(Convert.ToBoolean(row.GetCell("permitirAvancoDeEstadiaParaValidacaoRegrasDeCobrancaalterar"))));
                _page.RetornarPermitirOperadorAlterarCamposRecarga().Should().Be(Convert.ToBoolean(row.GetCell("permitirOperadorAlterarCamposDeRecargaRegrasDeCobrancaalterar")));
                _page.RetornarHabilitarOpcaoRecargaManualPrePago().Should().Be(Convert.ToBoolean(row.GetCell("habilitarOpcaoDeRecargaManualDePrePagoRegrasDeCobrancaalterar")));
                _page.RetornarPermitirRetrocessoEstadiaNaValidacao().Should().Be(Convert.ToBoolean(row.GetCell("permitirRetrocessoDeEstadiaParaValidacaoRegrasDeCobrancaalterar")));
                _page.RetornarHabilitarPagamentoAvulsoComCartaoPrePago().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPagamentoAvulsoComCartaoPrePagoRegrasDeCobrancaalterar")));
                _page.RetornarHabilitarTransferenciaAvulsoParaPrePago().Should().Be(Convert.ToBoolean(row.GetCell("habilitarTransferenciaAvulsoParaPrePagoRegraDeCobrancaalterar")));
                _page.RetornarSemLimite().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteRegrasDeCobrancaalterar")));
                _page.RetornarLimiteDeTempoDeEstadiaParaTransferenciaDeAvulsos().Should().Be(row.GetCell("bloquearTransferenciaDoAvulsoComMaisDeRegrasDeCobrancaalterar"));
                _page.RetornarTempoAdicionalAntesMudancaFracaoPeriodo().Should().Be(row.GetCell("tempoAdicionalAntesDaMudancaDeFracaoDoPeriodoRegrasDeCobrancaalterar"));
                _page.RetornarNivelOperadorMinimoParaEditarExtensaoValidade().Should().Be(row.GetCell("nivelOperadorMinimoParaEditarExtensaoValidadeRegrasDeCobrancaalterar"));
                _page.RetornarModoDeOtimizacaoDeCobranca().Should().BeEquivalentTo(row.GetCell("modoDeOtimizacaoDeCobrancaRegrasDeCobrancaalterar"));
                _page.RetornarBolsaoDeAcessoARevalidacao().Should().BeEquivalentTo(row.GetCell("bolsaoDeAcessoARevalidacaoRegrasDeCobrancaalterar"));
                _page.RetornarBloquearValidacaoDeEstadiaZerada().Should().BeEquivalentTo(row.GetCell("bloquearValidacaoDeEstadiaZeradaRegrasDeCobrancaalterar"));
                _page.RetornarTabelaDeCobrancaSupostaDaEntrada().Should().BeEquivalentTo(row.GetCell("nometabelasdecobranca"));
                _page.RetornarComportamentoDeRevalidacaoDeCredenciadosVencidos().Should().BeEquivalentTo(row.GetCell("comportamentoDeRevalidacaoDeCredenciadosVencidosalterar"));
                _page.RetornarQuantidadeTempoSupostaDaEntradaDias().Should().Be(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmDiasRegrasDeCobrancaalterar"));
                _page.RetornarQuantidadeTempoSupostaDaEntradaHoras().Should().Be(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmHorasRegrasDeCobrancaalterar"));
                _page.RetornarQuantidadeTempoSupostaDaEntradaMinutos().Should().Be(row.GetCell("quantidadeDeTempoSupostaDaEntradaEmMinutosRegrasDeCobrancaalterar"));
                _page.RetornarFormasDePagamento().Should().Be(row.GetCell("formasDePagamentoRegrasDeCobrancaalterar"));
                _page.RetornarUmaTabelaDeCobrancaParaInibidaParaAValidacaoDeAvulsos().Should().BeEquivalentTo(new string[] { row.GetCell("nometabelasdecobranca") });
                _page.RetornarUmaTabelaDeCobrancaParaInibidaParaValidacaoDePrePago().Should().BeEquivalentTo(new string[] { row.GetCell("nometabelasdecobranca") });
                _page.RetornarVerificarBolsaoPrecedente().Should().Be(Convert.ToBoolean(row.GetCell("naoSeAplicaRegrasDeCobrancaalterar")));
            }
        }

    }
}