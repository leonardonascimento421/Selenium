
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarRegrasDeCobranca16135;
using Luminus.Selenium.specs.Shared.SsCriarTabelasDeCobranca16091;
using Luminus.Selenium.specs.Shared.SsCriarUmaEstruturaDeCobranca16003;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoEntrada16330;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoPassagem16331;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoSaida16333;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.ProdutosDeEstadia.ProdutoDeEstadia
{
    public class ProdutoDeEstadiaPageStep
    {
        private ProdutoDeEstadiaPage _page = new ProdutoDeEstadiaPage();

        [Step("Carregar dependências Produto De Estadia <tabela>")]
        public void CarregarDependenciasProdutoDeEstadia(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecution(() =>
            {
                // steps de dependências
                new StCriarUmBolsaoDeVagas16266PageStep().StCriarUmBolsaoDeVagas16266(tabela);
                new SsCriarUmaEstruturaDeCobranca16003PageStep().SsCriarUmaEstruturaDeCobranca16003(tabela);
                new SsCriarRegrasDeCobranca16135PageStep().SsCriarRegrasDeCobranca16135(tabela);
                new SsCriarTabelasDeCobranca16091PageStep().SsCriarTabelasDeCobranca16091(tabela);
                new StCriarUmaRegraDeAcessoEntrada16330PageStep().StCriarUmaRegraDeAcessoEntrada16330(tabela);
                new StCriarUmaRegraDeAcessoPassagem16331PageStep().StCriarUmaRegraDeAcessoPassagem16331(tabela);
                new StCriarUmaRegraDeAcessoSaida16333PageStep().StCriarUmaRegraDeAcessoSaida16333(tabela);
            });
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [15924]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep15924(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeProdutoEstadiaAvulso"));
                _page.RetornarTipoDeUsuario().Should().Be(row.GetCell("tipoDeUsuarioProdutoEstadiaAvulso"));
            }
        }

        [Step("Verificar os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [15924]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep15924(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadiaVerificar"));
                _page.RetornarTabelaDeCobrancaSecundaria().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadiaVerificar"));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
                _page.RetornarTabelaDeCobrancaPrincipalTransitoExcedido().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadiaVerificar"));
                _page.RetornarTabelaDeCobrancaSecundariaTransitoExcedido().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadiaVerificar"));
                _page.RetornarRegrasAcessoEntrada().Should().Be(row.GetCell("nomeentradaregrasdeacesso"));
                _page.RetornarRegrasAcessoPassagem().Should().Be(row.GetCell("nomepassagemregrasdeacesso"));
                _page.RetornarRegrasAcessoSaida().Should().Be(row.GetCell("nomesaidaregrasdeacesso"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16231]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16231(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeprePagoprodutosdeestadia"));
            _page.SelecionarTipoDeUsuario(row.GetCell("tipodeusuarioprodutosdeestadia"));
            _page.PreencherCodigoDoGrupo(row.GetCell("codigodogrupoprodutosdeestadia"));
            _page.PreencherTempoMinimoDeUtilizacaoprePago(row.GetCell("tempoMinimoDeUtilizacaoprePagoprodutosdeestadia"));
            _page.PreencherTempoMaximoDeUtilizacaoprePago(row.GetCell("tempoMaximoDeUtilizacaoprePagoprodutosdeestadia"));
            _page.PreencherQuantidadeDeDiasValidadeInicial(row.GetCell("QuantidadeDeDiasValidadeInicial"));
            _page.PreencherQuantidadeDeUtilizacaoDiaria(row.GetCell("QuantidadeDeUtilizacaoDiaria"));
            _page.PreencherQuantidadeDeDiasExtesaoDeValidade(row.GetCell("QuantidadeDeDiasExtesaoDeValidade"));

        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16234]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16234(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeprePagoprodutosdeestadia"));
            _page.SelecionarTipoDeUsuario(row.GetCell("tipodeusuarioprodutosdeestadia"));
            _page.PreencherCodigoDoGrupo(row.GetCell("codigodogrupoprodutosdeestadia"));
            _page.PreencherTempoMinimoDeUtilizacaoprePago(row.GetCell("tempoMinimoDeUtilizacaoprePagoprodutosdeestadia"));
            _page.PreencherTempoMaximoDeUtilizacaoprePago(row.GetCell("tempoMaximoDeUtilizacaoprePagoprodutosdeestadia"));

        }

        [Step("Na seção Informações gerais preencher o campo Código do grupo com o valor <tabela> [ProdutoDeEstadiaPageStep] [16234]")]
        public void NaSecaoInformacoesGeraisPreencherOCampoCodigoDoGrupoComOValorProdutodeestadiapagestep16234(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherCodigoDoGrupo(row.GetCell("codigodogrupoprodutosdeestadia2"));
        }

        [Step("Na seção Informações gerais clicar no combobox Tipo de usuário e selecionar o valor '2 - Credenciado' <tabela> [ProdutoDeEstadiaPageStep] [16254]")]
        public void NaSecaoInformacoesGeraisPreencherOCampoTipoDeUsuarioComOValorProdutodeestadiapagestep16254(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDeUsuario(row.GetCell("tipodeusuarioprodutosdeestadia"));
        }

        [Step("Na seção Informações gerais clicar no combobox Tipo de revalidação e selecionar o valor '3 - Diarista' <tabela> [ProdutoDeEstadiaPageStep] [16254]")]
        public void NaSecaoInformacoesGeraisPreencherOCampoTipoDeRevalidacaoComOValorProdutodeestadiapagestep16254(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoRevalidacao(row.GetCell("tipoderevalidacaoprodutosdeestadia"));
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16236]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16236(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeProdutoEstadia"));
            _page.SelecionarTipoDeUsuario(row.GetCell("tipoDeUsuarioProdutoEstadia"));
            _page.SelecionarTipoRevalidacao(row.GetCell("tipoDeRevalidacaoProdutoEstadia"));

        }
        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16238]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16238(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDeUsuario(row.GetCell("tipoDeUsuarioProdutoEstadia"));
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16239]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16239(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarTipoDeUsuario().Should().Be(row.GetCell("tipoDeUsuarioProdutoEstadiaDiaDoMes"));
                _page.RetornarCodigoDoGrupo().Should().Be(row.GetCell("codigoDoGrupoProdutoEstadiaDiaDoMes"));
                _page.RetornarTipoRevalidacao().Should().Be(row.GetCell("tipoDeRevalidacaoProdutoEstadiaDiaDoMes"));
                var grid = _page.RetornarTabelaRevalidacao();
                _page.RetornarNumeroOpcaoDeRevalidacao(grid, 1).Should().Be(row.GetCell("numeroDaOpcaoDeRevalidacaoProdutoEstadia"));
                _page.RetornarValorDaRevalicao(grid, 1).Should().Be(row.GetCell("valorProdutoEstadia"));
            }
        }

        [Step("Verificar os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16239]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16239(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarBolsaoDeVagas().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarTabelaDeCobrancaSecundaria().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
                _page.RetornarTabelaDeCobrancaPrincipalTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarTabelaDeCobrancaSecundariaTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarRegrasAcessoEntrada().Should().Be(row.GetCell("nomeentradaregrasdeacesso"));
                _page.RetornarRegrasAcessoPassagem().Should().Be(row.GetCell("nomepassagemregrasdeacesso"));
                _page.RetornarRegrasAcessoSaida().Should().Be(row.GetCell("nomesaidaregrasdeacesso"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16241]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16241(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarTipoDeUsuario().Should().Be(row.GetCell("tipoDeUsuarioProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarCodigoDoGrupo().Should().Be(row.GetCell("codigoDoGrupoProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarTipoRevalidacao().Should().Be(row.GetCell("tipoDeRevalidacaoProdutoEstadiaQuantidadeDeDias"));
            }
        }

        [Step("Verificar os campos do Pop Up <tabela> [ProdutoDeEstadiaPageStep] [16241]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16241(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarBolsaoDeVagas().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nometabelasdecobrancaVerificar"));
                _page.RetornarTabelaDeCobrancaSecundaria().Should().Be(row.GetCell("nometabelasdecobrancaVerificar"));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
                _page.RetornarTabelaDeCobrancaPrincipalTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobrancaVerificar"));
                _page.RetornarTabelaDeCobrancaSecundariaTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobrancaVerificar"));
                _page.RetornarRegrasAcessoEntrada().Should().Be(row.GetCell("nomeentradaregrasdeacesso"));
                _page.RetornarRegrasAcessoPassagem().Should().Be(row.GetCell("nomepassagemregrasdeacesso"));
                _page.RetornarRegrasAcessoSaida().Should().Be(row.GetCell("nomesaidaregrasdeacesso"));
            }
        }

        [Step("Verificar os campos do PopUp de Revalidação <tabela> [ProdutoDeEstadiaPageStep] [16241]")]
        public void VerificarOsCamposDoPopUpDeRevalicaoProdutodeestadiapagestep16241(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                var grid = _page.RetornarTabelaRevalidacao();
                _page.RetornarNumeroOpcaoDeRevalidacao(grid, 1).Should().Be(row.GetCell("numeroDaOpcaoDeRevalidacaoProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarQuantidadeDeDias(grid, 1).Should().Be(row.GetCell("valorDaRepeticaoQuantidadeDeDias"));
                _page.RetornarValorDaRevalicao(grid, 1).Should().Be(row.GetCell("valorProdutoEstadiaQuantidadeDeDias"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16243]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16243(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
                _page.RetornarTipoDeUsuario().Should().Be(row.GetCell("tipodeusuarioprodutosdeestadiaDiarista"));
                _page.RetornarCodigoDoGrupo().Should().Be(row.GetCell("codigodogrupoprodutosdeestadiaDiarista"));
                _page.RetornarTipoRevalidacao().Should().Be(row.GetCell("tipoderevalidacaoprodutosdeestadiaDiarista"));
            }
        }

        [Step("Verificar os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16243]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16243(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarBolsaoDeVagas().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nometabelasdecobrancaexcedenteDiarista"));
                _page.RetornarTabelaDeCobrancaSecundaria().Should().Be(row.GetCell("nometabelasdecobrancaexcedenteDiarista"));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
                _page.RetornarTabelaDeCobrancaPrincipalTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobrancaexcedenteDiarista"));
                _page.RetornarTabelaDeCobrancaSecundariaTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobrancaexcedenteDiarista"));
                _page.RetornarRegrasAcessoEntrada().Should().Be(row.GetCell("nomeentradaregrasdeacesso"));
                _page.RetornarRegrasAcessoPassagem().Should().Be(row.GetCell("nomepassagemregrasdeacesso"));
                _page.RetornarRegrasAcessoSaida().Should().Be(row.GetCell("nomesaidaregrasdeacesso"));
            }
        }


        [Step("Verificar os campos da tela Revalidação <tabela> [ProdutoDeEstadiaPageStep] [16243]")]
        public void VerificarOsCamposDaTelaRevalidacaoProdutodeestadiapagestep16243(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarValorDaRevalicao().Should().Be(row.GetCell("valorprodutosdeestadiaDiarista"));
                _page.RetornarQuantidadeMaximaDiarias().Should().Be(row.GetCell("quantidademaximadediariaporvalidacaoprodutosdeestadiaDiarista"));
                _page.RetornarTabelaCobrancaExcedente().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarPermitirVendaPrevia().Should().Be(Convert.ToBoolean(row.GetCell("permitirvendapreviadediariaprodutosdeestadiaDiarista")));
                _page.RetornarNivelMinimoOperadorReImpressaoTicket().Should().Be(row.GetCell("nivelminimodooperadorparareimpressaodoticketprodutosdeestadiaDiarista"));
            }
        }

        [Step("Verificar os campos da tela na seção Informações Gerais <tabela> [ProdutoDeEstadiaPageStep] [16245]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16245(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeprePagoprodutosdeestadia"));
                _page.RetornarTipoDeUsuario().Should().Be(row.GetCell("tipodeusuarioprodutosdeestadia"));
                _page.RetornarCodigoDoGrupo().Should().Be(row.GetCell("codigodogrupoprodutosdeestadia"));
            }

        }

        [Step("Verificar os campos da tela no Pop-up Configuração por bolsão de vagas <tabela> [ProdutoDeEstadiaPageStep] [16245]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16245(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarBolsaoDeVagas().Should().Be(row.GetCell("nomeBolsaoDeVagasNaTelaDeProdutoEstadia"));
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadiaVerificar"));
                _page.RetornarManterTabelaCobrancaSecundaria().Should().Be(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadia")));
                _page.RetornarManterTabelaCobrancaPrincipalTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadia")));
                _page.RetornarManterTabelaCobrancaSecundariaTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadia")));
                _page.RetornarRegrasAcessoEntrada().Should().Be(row.GetCell("nomeEntradaRegrasDeAcessoNaTelaProdutoEstadia"));
                _page.RetornarRegrasAcessoPassagem().Should().Be(row.GetCell("nomePassagemRegrasDeAcessoNaTelaProdutoEstadia"));
                _page.RetornarRegrasAcessoSaida().Should().Be(row.GetCell("nomeSaidaRegrasDeAcessoNaTelaProdutoEstadia"));
            }
        }

        [Step("Verificar os campos da tela na seção Configuração por estacionamento <tabela> [ProdutoDeEstadiaPageStep] [16245]")]
        public void VerificarOsCamposDaTelaNaSecaoConfiguracaoPorEstacionamentoProdutodeestadiapagestep16245(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                var grid = _page.RetornarTabelaRecarga();
                _page.RetornarNumeroOpcaoDeRecarga(grid, 1).Should().Be(row.GetCell("numeroDaOpcaoDeRecargaprePagoprodutosdeestadia"));
                _page.RetornarValorRecargaNoPopUp(grid, 1).Should().Be(row.GetCell("valorDaRecargaprePagoprodutosdeestadia"));
                _page.RetornarValorPagamentoNoPopUp(grid, 1).Should().Be(row.GetCell("valorDoPagamentoprePagoprodutosdeestadia"));
                _page.RetornarQuantidadeDeDiasExtensaoValidadeNoPopUp(grid, 1).Should().Be(row.GetCell("quantidadeDeDiasDeExtesaoDeValidadeprePagoprodutosdeestadia"));
                _page.RetornarSugerirOpcaoRecargaMaxima().Should().Be(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaMaximaprePagoprodutosdeestadia")));
                _page.RetornarQuantidadeDeDiasValidadeInicial().Should().Be(row.GetCell("quantidadeDeDiasdeValidadeInicialprePagoprodutosdeestadia"));
                _page.RetornarSaldoMinimo().Should().Be(row.GetCell("saldoMinimoprePagoprodutosdeestadia"));
                _page.RetornarSaldoMaximo().Should().Be(row.GetCell("saldoMaximoprePagoprodutosdeestadia"));
                _page.RetornarSaldoNegativoLimite().Should().Be(row.GetCell("saldoNegativoLimiteprePagoprodutosdeestadia"));
                _page.RetornarValorMaximoDiario().Should().Be(row.GetCell("valorMaximoDiarioprePagoprodutosdeestadia"));
                _page.RetornarQuantidadeDeUtilizacaoDiaria().Should().Be(row.GetCell("quantidadeDeUtilizacoesDiariasprePagoprodutosdeestadia"));
                _page.RetornarTempoMinimoDeUtilizacaoprePago().Should().Be(row.GetCell("tempoMinimoDeUtilizacaoprePagoprodutosdeestadia"));
                _page.RetornarTempoMaximoDeUtilizacaoprePago().Should().Be(row.GetCell("tempoMaximoDeUtilizacaoprePagoprodutosdeestadia"));
                _page.RetornarQuantidadeDeDiasExtesaoDeValidade().Should().Be(row.GetCell("quantidadeDeDiasSugeridoParaExtensaoDaValidadeManualprePagoprodutosdeestadia"));
                _page.RetornarSugerirOpcaoDeRecargaParaAtingirSaldoMaximo().Should().Be(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaParaAtingirSaldoMaximoprePagoprodutosdeestadia")));
                _page.RetornarHabilitarTempoBonus().Should().Be(Convert.ToBoolean(row.GetCell("habilitarTempoDeBonusprePagoprodutosdeestadia")));
            }

        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16246]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16246(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteprodutosdeestadiaalterar")));
            _page.PreencherNome(row.GetCell("nomeProdutoEstadiaAvulsoAlterar"));
        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16246]")]
        public void PreencherOsCamposDoPopUpProdutodeestadiapagestep16246(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarManterTabelaCobrancaPrincipal(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiaalterar")));
            _page.MarcarManterTabelaCobrancaSecundaria(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadia")));
            _page.MarcarManterTabelaCobrancaPrincipalTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiaalterar")));
            _page.MarcarManterTabelaCobrancaSecundariaTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadiaalterar")));
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16246]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16246(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeProdutoEstadiaAvulsoAlterar"));
                _page.RetornarImediatamente().Should().Be(Convert.ToBoolean(row.GetCell("imediatamenteprodutosdeestadiaalterar")));
            }
        }

        [Step("Verificar os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16246]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16246(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarManterTabelaCobrancaPrincipal().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaSecundaria().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancasecundariaprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaPrincipalTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadia")));
                _page.RetornarManterTabelaCobrancaSecundariaTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiaalterar")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16247]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16247(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteProdutoEstadiaDiaDoMes")));
            _page.PreencherNome(row.GetCell("nomeProdutoEstadiaDiaDoMesalterar"));
            _page.PreencherDiaDoMes(row.GetCell("diaDoMesProdutoEstadiaDiaDoMesAlterar"));

        }

        [Step("Preencher os campos do PopUp Revalidação <tabela> [ProdutoDeEstadiaPageStep] [16247]")]
        public void PreencherOsCamposDoPopUpRevalidacaoProdutodeestadiapagestep16247(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorDaRevalicao(row.GetCell("valorProdutoEstadiaDiaDoMesAlterar"));
        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16247]")]
        public void PreencherOsCamposDoPopUpProdutodeestadiapagestep16247(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTabelaDeCobrancaPrincipal(row.GetCell("nometabelasdecobranca"));
            _page.SelecionarTabelaDeCobrancaSecundaria(row.GetCell("nometabelasdecobranca"));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadiadiadomesalterar")));
            _page.MarcarManterTabelaCobrancaPrincipalTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiadiadomesalterar")));
            _page.MarcarManterTabelaCobrancaSecundariaTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadiadiadomesalterar")));
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16247]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16247(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMesalterar"));
                _page.RetornarDiaDoMes().Should().Be(row.GetCell("diaDoMesProdutoEstadiaDiaDoMesAlterar"));
                var grid = _page.RetornarTabelaRevalidacao();
                _page.RetornarValorDaRevalicao(grid, 1).Should().Be(row.GetCell("valorProdutoEstadiaDiaDoMesAlterar"));
            }
        }

        [Step("Verificar os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16247]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16247(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarManterTabelaCobrancaPrincipal().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiadiadomesalterar")));
                _page.RetornarManterTabelaCobrancaSecundaria().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancasecundariaprodutosdeestadiadiadomesalterar")));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadiadiadomesalterar")));
                _page.RetornarManterTabelaCobrancaPrincipalTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiadiadomesalterar")));
                _page.RetornarManterTabelaCobrancaSecundariaTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadiadiadomesalterar")));
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarTabelaDeCobrancaSecundaria().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarTabelaDeCobrancaPrincipalTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarTabelaDeCobrancaSecundariaTransitoExcedido().Should().Be(row.GetCell("nometabelasdecobranca"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16249]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16249(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteprodutosdeestadiaalterar")));
            _page.PreencherNome(row.GetCell("nomeProdutoEstadiaalterado"));

        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16249]")]
        public void PreencherOsCamposDoPopUpProdutodeestadiapagestep16249(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarManterTabelaCobrancaPrincipal(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiaalterar")));
            _page.MarcarManterTabelaCobrancaSecundaria(Convert.ToBoolean(row.GetCell("manteratabeladecobrancasecundariaprodutosdeestadiaalterar")));

        }

        [Step("Preencher os campos do PopUp Revalidação <tabela> [ProdutoDeEstadiaPageStep] [16249]")]
        public void PreencherOsCamposDoPopUpRevalidacaoProdutodeestadiapagestep16249(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorDaRevalicao(row.GetCell("valorProdutoEstadiaalterado"));
            _page.PreencherQuantidadeDeDias(row.GetCell("quantidadeDeDiasProdutoEstadiaalterado"));
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16249]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16249(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeProdutoEstadiaalterado"));
                _page.RetornarTipoDeUsuario().Should().Be(row.GetCell("tipoDeUsuarioProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarCodigoDoGrupo().Should().Be(row.GetCell("codigoDoGrupoProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarTipoRevalidacao().Should().Be(row.GetCell("tipoDeRevalidacaoProdutoEstadiaQuantidadeDeDias"));
                var grid = _page.RetornarTabelaRevalidacao();
                _page.RetornarNumeroOpcaoDeRevalidacao(grid, 1).Should().Be(row.GetCell("numeroDaOpcaoDeRevalidacaoProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarQuantidadeDeDias(grid, 1).Should().Be(row.GetCell("quantidadeDeDiasProdutoEstadiaalterado"));
                _page.RetornarValorDaRevalicao(grid, 1).Should().Be(row.GetCell("valorProdutoEstadiaalterado"));
            }

        }

        [Step("Verificar os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16249]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16249(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarBolsaoDeVagas().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nometabelasdecobrancaalterada"));
                _page.RetornarTabelaDeCobrancaSecundaria().Should().Be(row.GetCell("nometabelasdecobrancaalterada"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16250]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16250(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteprodutosdeestadiaalterar")));
            _page.PreencherNome(row.GetCell("nomecredenciadodiaristaprodutosdeestadiaalterar"));

        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16250]")]
        public void PreencherOsCamposDoPopUpProdutodeestadiapagestep16250(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarManterTabelaCobrancaPrincipal(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiaalterar")));
            _page.MarcarManterTabelaCobrancaSecundaria(Convert.ToBoolean(row.GetCell("manteratabeladecobrancasecundariaprodutosdeestadiaalterar")));
            _page.SelecionarTabelaDeCobrancaPrincipal(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadiaalterar")));
            _page.MarcarManterTabelaCobrancaPrincipalTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiaalterar")));
            _page.SelecionarTabelaDeCobrancaPrincipalTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarManterTabelaCobrancaSecundariaTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadiaalterar")));
            _page.SelecionarTabelaDeCobrancaSecundariaTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
        }

        [Step("Preencher os campos da tela Revalidação <tabela> [ProdutoDeEstadiaPageStep] [16250]")]
        public void PreencherOsCamposDaTelaRevalidacaoProdutodeestadiapagestep16250(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorDaRevalicao(row.GetCell("valorprodutosdeestadiaalterar"));
            _page.PreencherQuantidadeMaximaDiarias(row.GetCell("quantidademaximadediariaporvalidacaoprodutosdeestadiaalterar"));
            _page.MarcarPermitirVendaPrevia(Convert.ToBoolean(row.GetCell("permitirvendapreviadediariaprodutosdeestadiaalterar")));
            _page.PreencherNivelMinimoOperadorReImpressaoTicket(row.GetCell("nivelminimodooperadorparareimpressaodoticketprodutosdeestadiaalterar"));
        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16250]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16250(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadiaalterar"));
            }
        }

        [Step("Verificar os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16250]")]
        public void VerificarOsCamposDoPopUpProdutodeestadiapagestep16250(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarManterTabelaCobrancaPrincipal().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaSecundaria().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancasecundariaprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaPrincipalTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaSecundariaTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadiaalterar")));
            }
        }

        [Step("Verificar os campos da tela Revalidação <tabela> [ProdutoDeEstadiaPageStep] [16250]")]
        public void VerificarOsCamposDaTelaRevalidacaoProdutodeestadiapagestep16250(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarValorDaRevalicao().Should().Be(row.GetCell("valorprodutosdeestadiaalterar"));
                _page.RetornarQuantidadeMaximaDiarias().Should().Be(row.GetCell("quantidademaximadediariaporvalidacaoprodutosdeestadiaalterar"));
                _page.RetornarTabelaCobrancaExcedente().Should().Be(row.GetCell("nometabelasdecobranca"));
                _page.RetornarPermitirVendaPrevia().Should().Be(Convert.ToBoolean(row.GetCell("permitirvendapreviadediariaprodutosdeestadiaalterar")));
                _page.RetornarNivelMinimoOperadorReImpressaoTicket().Should().Be(row.GetCell("nivelminimodooperadorparareimpressaodoticketprodutosdeestadiaalterar"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16252]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16252(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteprodutosdeestadiaalterar")));
            _page.PreencherNome(row.GetCell("nomeprePagoprodutosdeestadiaalterar"));

        }

        [Step("Preencher os campos da tela PopUp <tabela> [ProdutoDeEstadiaPageStep] [16252]")]
        public void PreencherOsCamposDaTelaPopUpProdutodeestadiapagestep16252(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarManterTabelaCobrancaPrincipal(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiaalterar")));
            _page.MarcarManterTabelaCobrancaSecundaria(Convert.ToBoolean(row.GetCell("manteratabeladecobrancasecundariaprodutosdeestadiaalterar")));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadiaalterar")));
            _page.MarcarManterTabelaCobrancaPrincipalTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiaalterar")));
            _page.SelecionarTabelaDeCobrancaPrincipalTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarManterTabelaCobrancaSecundariaTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadiaalterar")));
            _page.SelecionarTabelaDeCobrancaSecundariaTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));

        }

        [Step("Preencher os campos da tela PopUp Recarga <tabela> [ProdutoDeEstadiaPageStep] [16252]")]
        public void PreencherOsCamposDaTelaPopUpRecargaProdutodeestadiapagestep16252(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorRecargaNoPopUp(row.GetCell("valorDaRecargaprePagoprodutosdeestadiaalterar"));
            _page.PreencherValorPagamentoNoPopUp(row.GetCell("valorDoPagamentoprePagoprodutosdeestadiaalterar"));
            _page.PreencherQuantidadeDeDiasExtensaoValidadeNoPopUp(row.GetCell("quantidadeDeDiasDeExtesaoDeValidadeprePagoprodutosdeestadiaalterar"));
        }

        [Step("Preencher os campos da tela Regras Recarga <tabela> [ProdutoDeEstadiaPageStep] [16252]")]
        public void PreencherOsCamposDaTelaRegrasRecargaProdutodeestadiapagestep16252(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarSugerirOpcaoRecargaMaxima(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaMaximaprePagoprodutosdeestadiaalterar")));
            _page.PreencherQuantidadeDeDiasValidadeInicial(row.GetCell("quantidadeDeDiasdeValidadeInicialprePagoprodutosdeestadiaalterar"));
            _page.PreencherSaldoMinimo(row.GetCell("saldoMinimoprePagoprodutosdeestadiaalterar"));
            _page.PreencherSaldoMaximo(row.GetCell("saldoMaximoprePagoprodutosdeestadiaalterar"));
            _page.PreencherSaldoNegativoLimite(row.GetCell("saldoNegativoLimiteprePagoprodutosdeestadiaalterar"));
            _page.PreencherValorMaximoDiario(row.GetCell("valorMaximoDiarioprePagoprodutosdeestadiaalterar"));
            _page.PreencherQuantidadeDeUtilizacaoDiaria(row.GetCell("quantidadeDeUtilizacoesDiariasprePagoprodutosdeestadiaalterar"));
            _page.PreencherTempoMinimoDeUtilizacaoprePago(row.GetCell("tempoMinimoDeUtilizacaoprePagoprodutosdeestadiaalterar"));
            _page.PreencherTempoMaximoDeUtilizacaoprePago(row.GetCell("tempoMaximoDeUtilizacaoprePagoprodutosdeestadiaalterar"));
            _page.PreencherQuantidadeDeDiasExtesaoDeValidade(row.GetCell("quantidadeDeDiasSugeridoParaExtensaoDaValidadeManualprePagoprodutosdeestadiaalterar"));
            _page.MarcarSugerirOpcaoDeRecargaParaAtingirSaldoMaximo(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaParaAtingirSaldoMaximoprePagoprodutosdeestadiaalterar")));
            _page.MarcarHabilitarTempoBonus(Convert.ToBoolean(row.GetCell("habilitarTempoDeBonusprePagoprodutosdeestadiaalterar")));
            _page.SelecionarModoUtilizacaoTempoBonus(row.GetCell("modoDeUtilizacaoDoTempoBonusprePagoprodutosdeestadiaalterar"));
            _page.PreencherTempoBonusMaximo(row.GetCell("tempoDeBonusMaximoprePagoprodutosdeestadiaalterar"));

        }

        [Step("Verificar os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16252]")]
        public void VerificarOsCamposDaTelaProdutodeestadiapagestep16252(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeprePagoprodutosdeestadiaalterar"));
            }
        }

        [Step("Verificar os campos da tela PopUp <tabela> [ProdutoDeEstadiaPageStep] [16252]")]
        public void VerificarOsCamposDaTelaPopUpProdutodeestadiapagestep16252(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarManterTabelaCobrancaPrincipal().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaprincipalprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaSecundaria().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancasecundariaprodutosdeestadiaalterar")));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaPrincipalTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadiaalterar")));
                _page.RetornarManterTabelaCobrancaSecundariaTransitoExcedido().Should().Be(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadiaalterar")));
            }

        }

        [Step("Verificar os campos da tela Regras Recarga <tabela> [ProdutoDeEstadiaPageStep] [16252]")]
        public void VerificarOsCamposDaTelaRegrasRecargaProdutodeestadiapagestep16252(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                var grid = _page.RetornarTabelaRecarga();
                _page.RetornarNumeroOpcaoDeRecarga(grid, 1).Should().Be(row.GetCell("numeroDaOpcaoDeRecargaprePagoprodutosdeestadia"));
                _page.RetornarSugerirOpcaoRecargaMaxima().Should().Be(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaMaximaprePagoprodutosdeestadiaalterar")));
                _page.RetornarQuantidadeDeDiasValidadeInicial().Should().Be(row.GetCell("quantidadeDeDiasdeValidadeInicialprePagoprodutosdeestadiaalterar"));
                _page.RetornarSaldoMinimo().Should().Be(row.GetCell("saldoMinimoprePagoprodutosdeestadiaalterar"));
                _page.RetornarSaldoMaximo().Should().Be(row.GetCell("saldoMaximoprePagoprodutosdeestadiaalterar"));
                _page.RetornarSaldoNegativoLimite().Should().Be(row.GetCell("saldoNegativoLimiteprePagoprodutosdeestadiaalterar"));
                _page.RetornarValorMaximoDiario().Should().Be(row.GetCell("valorMaximoDiarioprePagoprodutosdeestadiaalterar"));
                _page.RetornarQuantidadeDeUtilizacaoDiaria().Should().Be(row.GetCell("quantidadeDeUtilizacoesDiariasprePagoprodutosdeestadiaalterar"));
                _page.RetornarTempoMinimoDeUtilizacaoprePago().Should().Be(row.GetCell("tempoMinimoDeUtilizacaoprePagoprodutosdeestadiaalterar"));
                _page.RetornarTempoMaximoDeUtilizacaoprePago().Should().Be(row.GetCell("tempoMaximoDeUtilizacaoprePagoprodutosdeestadiaalterar"));
                _page.RetornarQuantidadeDeDiasExtesaoDeValidade().Should().Be(row.GetCell("quantidadeDeDiasSugeridoParaExtensaoDaValidadeManualprePagoprodutosdeestadiaalterar"));
                _page.RetornarSugerirOpcaoDeRecargaParaAtingirSaldoMaximo().Should().Be(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaParaAtingirSaldoMaximoprePagoprodutosdeestadiaalterar")));
                _page.RetornarHabilitarTempoBonus().Should().Be(Convert.ToBoolean(row.GetCell("habilitarTempoDeBonusprePagoprodutosdeestadiaalterar")));
                _page.RetornarModoUtilizacaoTempoBonus().Should().Be(row.GetCell("modoDeUtilizacaoDoTempoBonusprePagoprodutosdeestadiaalterar"));
                _page.RetornarTempoBonusMaximo().Should().Be(row.GetCell("tempoDeBonusMaximoprePagoprodutosdeestadiaalterar"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16259]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16259(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDeUsuario(row.GetCell("tipoDeUsuario"));
            _page.SelecionarTipoRevalidacao(row.GetCell("tipoDeRevalidacao"));

        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16259]")]
        public void PreencherOsCamposDoPopUpProdutodeestadiapagestep16259(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarNumeroOpcao(row.GetCell("numeroDaOpcaoDeRevalidacaoProdutoEstadia"));
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16260]")]
        public void PreencherOsCamposDaTelaProdutodeestadiapagestep16260(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDeUsuario(row.GetCell("tipoDeUsuario"));
            _page.SelecionarTipoRevalidacao(row.GetCell("tipoDeRevalidacao"));

        }

        [Step("Preencher os campos do pop-up <tabela> [ProdutoDeEstadiaPageStep] [16260]")]
        public void PreencherOsCamposDoPopUpProdutodeestadiapagestep16260(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarNumeroOpcao(row.GetCell("numeroDaOpcaoDeRevalidacaoProdutoEstadia"));
            _page.PreencherQuantidadeDeDiasNoPopUp(row.GetCell("quantidadeDeDiasPopUp"));
        }


        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16395]")]
        public void PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16395(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeprePagoprodutosdeestadia"));
            _page.SelecionarTipoDeUsuario(row.GetCell("tipodeusuarioprodutosdeestadia"));
            _page.PreencherCodigoDoGrupo(row.GetCell("codigodogrupoprodutosdeestadia"));

        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16395]")]
        public void PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16395(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarBolsaoDeVagas(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarTabelaDeCobrancaPrincipal(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarManterTabelaCobrancaSecundaria(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadia")));
            _page.MarcarManterTabelaCobrancaPrincipalTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidaprincipalprodutosdeestadia")));
            _page.MarcarManterTabelaCobrancaSecundariaTransitoExcedido(Convert.ToBoolean(row.GetCell("manteratabeladecobrancaexcedidasecundariaprodutosdeestadia")));
            _page.SelecionarRegrasAcessoEntrada(row.GetCell("nomeEntradaRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoPassagem(row.GetCell("nomePassagemRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoSaida(row.GetCell("nomeSaidaRegrasDeAcessoNaTelaProdutoEstadia"));

        }

        [Step("Preencher os campos do Pop-up Regras de recarga <tabela> [ProdutoDeEstadiaPageStep] [16395]")]
        public void PreencherOsCamposDoPopUpRegraDeRecargaProdutoDeEstadiaPageStep16395(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarNumeroOpcao(row.GetCell("numeroDaOpcaoDeRecargaprePagoprodutosdeestadia"));
            _page.PreencherValorRecargaNoPopUp(row.GetCell("valorDaRecargaprePagoprodutosdeestadia"));
            _page.PreencherValorPagamentoNoPopUp(row.GetCell("valorDoPagamentoprePagoprodutosdeestadia"));
            _page.PreencherQuantidadeDeDiasExtensaoValidadeNoPopUp(row.GetCell("quantidadeDeDiasDeExtesaoDeValidadeprePagoprodutosdeestadia"));

        }

        [Step("Preencher os campos da tela na seção Configuração por bolsão de vagas <tabela> [ProdutoDeEstadiaPageStep] [16395]")]
        public void PreencherOsCamposDaTelaNaSecaoConfiguracaoPorBolsaoDeVagas16395(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarSugerirOpcaoRecargaMaxima(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaMaximaprePagoprodutosdeestadia")));
            _page.PreencherQuantidadeDeDiasValidadeInicial(row.GetCell("quantidadeDeDiasdeValidadeInicialprePagoprodutosdeestadia"));
            _page.PreencherSaldoMinimo(row.GetCell("saldoMinimoprePagoprodutosdeestadia"));
            _page.PreencherSaldoMaximo(row.GetCell("saldoMaximoprePagoprodutosdeestadia"));
            _page.PreencherSaldoNegativoLimite(row.GetCell("saldoNegativoLimiteprePagoprodutosdeestadia"));
            _page.PreencherValorMaximoDiario(row.GetCell("valorMaximoDiarioprePagoprodutosdeestadia"));
            _page.PreencherQuantidadeDeUtilizacaoDiaria(row.GetCell("quantidadeDeUtilizacoesDiariasprePagoprodutosdeestadia"));
            _page.PreencherTempoMinimoDeUtilizacaoprePago(row.GetCell("tempoMinimoDeUtilizacaoprePagoprodutosdeestadia"));
            _page.PreencherTempoMaximoDeUtilizacaoprePago(row.GetCell("tempoMaximoDeUtilizacaoprePagoprodutosdeestadia"));
            _page.PreencherQuantidadeDeDiasExtesaoDeValidade(row.GetCell("quantidadeDeDiasSugeridoParaExtensaoDaValidadeManualprePagoprodutosdeestadia"));
            _page.MarcarSugerirOpcaoDeRecargaParaAtingirSaldoMaximo(Convert.ToBoolean(row.GetCell("sugerirOpcaoDeRecargaParaAtingirSaldoMaximoprePagoprodutosdeestadia"))); //rever necessidade do checkbox no Luminus
            _page.MarcarHabilitarTempoBonus(Convert.ToBoolean(row.GetCell("habilitarTempoDeBonusprePagoprodutosdeestadia")));

        }



        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16341]")]
        public void PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16341(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
            _page.SelecionarTipoDeUsuario(row.GetCell("tipodeusuarioprodutosdeestadiaDiarista"));
            _page.PreencherCodigoDoGrupo(row.GetCell("codigodogrupoprodutosdeestadiaDiarista"));
            _page.SelecionarTipoRevalidacao(row.GetCell("tipoderevalidacaoprodutosdeestadiaDiarista"));
        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16341]")]
        public void PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16341(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarBolsaoDeVagas(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarTabelaDeCobrancaPrincipal(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundaria(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
            _page.SelecionarTabelaDeCobrancaPrincipalTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundariaTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoEntrada(row.GetCell("nomeEntradaRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoPassagem(row.GetCell("nomePassagemRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoSaida(row.GetCell("nomeSaidaRegrasDeAcessoNaTelaProdutoEstadia"));
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16243]")]
        public void PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16243(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorDaRevalicao(row.GetCell("valorprodutosdeestadiaDiarista"));
            _page.PreencherQuantidadeMaximaDiarias(row.GetCell("quantidademaximadediariaporvalidacaoprodutosdeestadiaDiarista"));
            _page.SelecionarTabelaCobrancaExcedente(row.GetCell("nometabelasdecobranca"));
            _page.MarcarPermitirVendaPrevia(Convert.ToBoolean(row.GetCell("permitirvendapreviadediariaprodutosdeestadiaDiarista")));
            _page.PreencherNivelMinimoOperadorReImpressaoTicket(row.GetCell("nivelminimodooperadorparareimpressaodoticketprodutosdeestadiaDiarista"));

        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16289]")]
        public void PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16289(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
            _page.SelecionarTipoDeUsuario(row.GetCell("tipoDeUsuarioProdutoEstadiaDiaDoMes"));
            _page.PreencherCodigoDoGrupo(row.GetCell("codigoDoGrupoProdutoEstadiaDiaDoMes"));
            _page.SelecionarTipoRevalidacao(row.GetCell("tipoDeRevalidacaoProdutoEstadiaDiaDoMes"));
            _page.PreencherDiaDoMes(row.GetCell("diaDoMesProdutoEstadiaDiaDoMes"));
        }

        [Step("Preencher os campos da tela Revalidação <tabela> [ProdutoDeEstadiaPageStep] [16289]")]
        public void PreencherOsCamposDaTelaRevalidacaoProdutoDeEstadiaPageStep16289(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarNumeroOpcao(row.GetCell("numeroDaOpcaoDeRevalidacaoProdutoEstadia"));
            _page.PreencherValorDaRevalicao(row.GetCell("valorProdutoEstadia"));
            _page.PreencherValorDaRepeticao(row.GetCell("valorDaRepeticao"));
        }

        [Step("Preencher os campos Do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16289]")]
        public void PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16289(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarBolsaoDeVagas(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarTabelaDeCobrancaPrincipal(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundaria(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
            _page.SelecionarTabelaDeCobrancaPrincipalTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundariaTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoEntrada(row.GetCell("nomeEntradaRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoPassagem(row.GetCell("nomePassagemRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoSaida(row.GetCell("nomeSaidaRegrasDeAcessoNaTelaProdutoEstadia"));
        }

        [Step("Na seção Informações gerais preencher o campo Nome com o valor <tabela> [ProdutoDeEstadiaPageStep] [15924]")]
        public void NaSecaoInformacoesGeraisPreencherOCampoNomeComOValorProdutoDeEstadiaPageStep15924(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeProdutoEstadiaAvulso"));
        }

        [Step("Na seção Informações gerais o campo Tipo de usuário deve selecionar o valor <tabela> [ProdutoDeEstadiaPageStep] [15924]")]
        public void NaSecaoInformacoesGeraisOCampoTipoDeUsuarioDeveEstarSelecionadoComOValorProdutoDeEstadiaPageStep15924(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDeUsuario(row.GetCell("tipoDeUsuarioProdutoEstadiaAvulso"));
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [15924]")]
        public void PreencherOsCamposDaTelaProdutoDeEstadiaPageStep15924(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarBolsaoDeVagas(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarTabelaDeCobrancaPrincipal(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundaria(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadia")));
            _page.SelecionarTabelaDeCobrancaPrincipalTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundariaTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoEntrada(row.GetCell("nomeentradaregrasdeacesso"));
            _page.SelecionarRegrasAcessoPassagem(row.GetCell("nomepassagemregrasdeacesso"));
            _page.SelecionarRegrasAcessoSaida(row.GetCell("nomesaidaregrasdeacesso"));

        }

        [Step("Verificar os campos do pop-up <tabela> [ProdutoDeEstadiaPageStep] [15924]")]
        public void VerificaroscamposdopopupProdutoEstadiapagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarBolsaoDeVagas().Should().Be(row.GetCell("nomeBolsaoDeVagasNaTelaDeProdutoEstadia"));
                _page.RetornarTabelaDeCobrancaPrincipal().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
                _page.RetornarTabelaDeCobrancaSecundaria().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
                _page.RetornarEquipamentoPassagemMantemTabelaCobrancaEstadia().Should().Be(Convert.ToBoolean(row.GetCell("equipamentosdepassagemmantemtabeladecobrancadaestadiaprodutosdeestadia")));
                _page.RetornarTabelaDeCobrancaPrincipalTransitoExcedido().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
                _page.RetornarTabelaDeCobrancaSecundariaTransitoExcedido().Should().Be(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
                _page.RetornarRegrasAcessoEntrada().Should().Be(row.GetCell("nomeEntradaRegrasDeAcessoNaTelaProdutoEstadia"));
                _page.RetornarRegrasAcessoPassagem().Should().Be(row.GetCell("nomePassagemRegrasDeAcessoNaTelaProdutoEstadia"));
                _page.RetornarRegrasAcessoSaida().Should().Be(row.GetCell("nomeSaidaRegrasDeAcessoNaTelaProdutoEstadia"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [ProdutoDeEstadiaPageStep] [16232]")]
        public void PreencherOsCamposDaTelaProdutoDeEstadiaPageStep16232(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
            _page.SelecionarTipoDeUsuario(row.GetCell("tipoDeUsuarioProdutoEstadiaQuantidadeDeDias"));
            _page.PreencherCodigoDoGrupo(row.GetCell("codigoDoGrupoProdutoEstadiaQuantidadeDeDias"));
            _page.SelecionarTipoRevalidacao(row.GetCell("tipoDeRevalidacaoProdutoEstadiaQuantidadeDeDias"));
        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16232]")]
        public void PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16232(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarBolsaoDeVagas(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarTabelaDeCobrancaPrincipal(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundaria(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.MarcarEquipamentoPassagemMantemTabelaCobrancaEstadia(Convert.ToBoolean(row.GetCell("equipamentoDePassagemMantemTabelaDeCobranca")));
            _page.SelecionarTabelaDeCobrancaPrincipalTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarTabelaDeCobrancaSecundariaTransitoExcedido(row.GetCell("nomeTabelasDeCobrancaNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoEntrada(row.GetCell("nomeEntradaRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoPassagem(row.GetCell("nomePassagemRegrasDeAcessoNaTelaProdutoEstadia"));
            _page.SelecionarRegrasAcessoSaida(row.GetCell("nomeSaidaRegrasDeAcessoNaTelaProdutoEstadia"));
        }

        [Step("Preencher os campos do PopUp <tabela> [ProdutoDeEstadiaPageStep] [16346]")]
        public void PreencherOsCamposDoPopUpProdutoDeEstadiaPageStep16346(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarNumeroOpcao(row.GetCell("numeroDaOpcaoDeRevalidacaoProdutoEstadiaQuantidadeDeDias"));
            _page.PreencherValorDaRevalicao(row.GetCell("valorProdutoEstadiaQuantidadeDeDias"));
            _page.PreencherQuantidadeDeDias(row.GetCell("valorDaRepeticaoQuantidadeDeDias"));
        }

        [Step("Clicar no botão adicionar na seção Configuração por bolsão [ProdutoDeEstadiaPageStep]")]
        public void ClicarNoBotaoAdicionarNaSecaoConfiguracaoPorBolsaoProdutoDeEstadiaPageStep()
        {
            _page.ClicarNoBotaoAdicionarDeConfiguracaoPorEstacionamento();
        }

        [Step("Clicar no botão adicionar na seção Regras de revalidação [ProdutoDeEstadiaPageStep]")]
        public void ClicarNoBotaoAdicionarNaSecaoRegrasDeRevalidacaoProdutoDeEstadiaPageStep()
        {
            _page.ClicarNoBotaoAdicionarDeRegrasDeRevalidacao();
        }

        [Step("Clicar no botão adicionar na seção Regras de recarga [ProdutoDeEstadiaPageStep]")]
        public void ClicarNoBotaoAdicionarNaSecaoRegrasDeRecargaProdutoDeEstadiaPageStep()
        {
            _page.ClicarNoBotaoAdicionarDeRegrasDeRecarga();
        }

    }
}