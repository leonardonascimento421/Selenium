
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaProdutoEstadiaDiaDoMes17885;
using Luminus.Selenium.specs.Shared.SsCriarProdutoDeEstadiaPrePago16395;
using Luminus.Selenium.specs.Shared.SsCriarProdutoEstadiaDiarista16341;
using Luminus.Selenium.specs.Shared.SsCriarProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMe9;
using Luminus.Selenium.specs.Shared.SsCriarRegrasDeCobranca16135;
using Luminus.Selenium.specs.Shared.SsCriarTabelasDeCobranca16091;
using Luminus.Selenium.specs.Shared.SsCriarUmaEstruturaDeCobranca16003;
using Luminus.Selenium.specs.Shared.SsCriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuant6;
using Luminus.Selenium.specs.Shared.StCriarClientesDoEstacionamentoTabela16128;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoEntrada16330;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoPassagem16331;
using Luminus.Selenium.specs.Shared.StCriarUmaRegraDeAcessoSaida16333;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;
using Luminus.Selenium.Utils;
using Luminus.Selenium.Utils.Barramento;

namespace Luminus.Selenium.specs.Operacao.ContratosDeEstadia
{
    public class ContratosDeEstadiaPageStep
    {
        private ContratosDeEstadiaPage _page = new ContratosDeEstadiaPage();


        [Step("Carregar dependências Contratos De Estadia <tabela>")]
        public void CarregarDependenciasContratoDeProdutoDeEstadia(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecution(() =>
            {
                //steps de dependências
                new StCriarUmBolsaoDeVagas16266PageStep().StCriarUmBolsaoDeVagas16266(tabela);
                new SsCriarUmaEstruturaDeCobranca16003PageStep().SsCriarUmaEstruturaDeCobranca16003(tabela);
                new SsCriarRegrasDeCobranca16135PageStep().SsCriarRegrasDeCobranca16135(tabela);
                new SsCriarTabelasDeCobranca16091PageStep().SsCriarTabelasDeCobranca16091(tabela);
                new StCriarUmaRegraDeAcessoEntrada16330PageStep().StCriarUmaRegraDeAcessoEntrada16330(tabela);
                new StCriarUmaRegraDeAcessoPassagem16331PageStep().StCriarUmaRegraDeAcessoPassagem16331(tabela);
                new StCriarUmaRegraDeAcessoSaida16333PageStep().StCriarUmaRegraDeAcessoSaida16333(tabela);
                new SsCriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuant6PageStep().SsCriarUmProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoQuantidadeDeDias16346(tabela);
                new SsCriarProdutoDeEstadiaPrePago16395PageStep().SsCriarProdutoDeEstadiaPrePago16395(tabela);
                new SsCriarProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMe9PageStep().SsCriarProdutoEstadiaDoTipoCredenciadoComTipoDeRevalidacaoDiaDoMesStepByStep16289(tabela);
            });
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17362]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17362(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomecredenciadoquantidadeDeDiasprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
            }

        }

        [Step("Na seção Informações gerais o campo Vigente a partir de deve conter a data de criação DateTime_now [ContratosDeEstadiaPageStep]")]
        public void NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep()
        {
            using (new AssertionScope())
            {
                string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
                _page.RetornarVigenteAPartirDe().Should().Be(dataAtual);
            }
        }

        [Step("Na seção Mídia de acesso, na tabela deve apresentar a mensagem Não há registros a serem exibidos [ContratosDeEstadiaPageStep]")]
        public void NaSecaoMIdiaDeAcessoNatabelaDeveApresentarAMensagemNaoHaRegistrosASeremExibidosContratosdeestadiapagestep()
        {
            _page.RetornarVerificarTabelaVaziaMidiaAcesso();

        }

        [Step("Na seção Aditamento, na tabela deve apresentar a mensagem Não há registros a serem exibidos [ContratosDeEstadiaPageStep]")]
        public void NaSecaoAditamentoNatabelaDeveApresentarAMensagemNaoHaRegistrosASeremExibidosContratosdeestadiapagestep()
        {
            _page.RetornarVerificarTabelaVaziaAditamento();

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17363]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17363(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17365]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17365(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeprePagoprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarVerificarTabelaVaziaAditamento();
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17366]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17366(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("ValidoAte"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17369]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17369(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("ValidoAte"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17371]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17371(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("retornarcodigoDoCartaoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();

            }

        }


        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17374]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17374(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadiana"));
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17375]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17375(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoConectCarContratoEstadiana"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("RetornarcodigoDoCartaoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17376]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17376(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("RetornarcodigoDoCartaoContratoEstadia"));
                _page.RetornarTipoDeMidiaDeAcesso(grid, 2).Should().Be(row.GetCell("tipoDeMidiaDeAcessoProximityContratoEstadia"));
                _page.RetornarNumeroSerial(grid, 2).Should().Be(row.GetCell("codigoCartaoProximityContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17377]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17377(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("RetornarcodigoDoCartaoContratoEstadia"));
                _page.RetornarTipoDeMidiaDeAcesso(grid, 2).Should().Be(row.GetCell("tipodamidiadeacessocontratosestadiatagnepos"));
                _page.RetornarNumeroSerial(grid, 2).Should().Be(row.GetCell("numeroserialdatagcontratosestadiatagnepos"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17379]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17379(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("RetornarcodigoDoCartaoContratoEstadia"));
                _page.RetornarTipoDeMidiaDeAcesso(grid, 2).Should().Be(row.GetCell("tipoDeMidiaDeAcessoTagGenericaContratoEstadia"));
                _page.RetornarIdentificacao(grid, 2).Should().Be(row.GetCell("RetornarcodigoDoCartaoTagGenericaContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Preencher os campos do popup midia de acesso <tabela> [ContratosDeEstadiaPageStep] [17381]")]
        public void PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17381(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
            _page.PreencherIdentificacao(row.GetCell("placaVeiculoContratoEstadia"));
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17381]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17381(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("placaVeiculoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Preencher os campos do popup midia de acesso <tabela> [ContratosDeEstadiaPageStep] [17952]")]
        public void PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17952(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoCustomizadaContratoEstadia"));
            _page.PreencherIdentificacao(row.GetCell("codigoDoCartaoCustomizadoContratoEstadia"));
            _page.PreencherNumeroCartaoCodigoDeBarras(row.GetCell("numeroCustomizadoContratoEstadia"));
            _page.PreencherNumeroCustomerSpacenet(row.GetCell("customerCustomizadoContratoEstadia"));
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17383]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17383(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoCustomizadaContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("codigoDoCartaoCustomizadoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }
        }


        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17384]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17384(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("RetornarcodigoDoCartaoContratoEstadia"));
                _page.RetornarTipoDeMidiaDeAcesso(grid, 2).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadiaVeloe"));
                _page.RetornarIdentificacao(grid, 2).Should().Be(row.GetCell("placaVeiculoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17386]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17386(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeprePagoprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17385]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17385(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var gridMidia = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(gridMidia, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(gridMidia, 1).Should().Be(row.GetCell("codigoDoCartaoContratoEstadia"));
                var gridAditamento = _page.RetornarTabelaAditamento();
                _page.RetornarValorDaValidacao(gridAditamento, 1).Should().Be(row.GetCell("valorDaValidacaoAditamento"));
                _page.RetornarFormaPagamento(gridAditamento, 1).Should().Be(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
                _page.RetornarValorRecebido(gridAditamento, 1).Should().Be(row.GetCell("valorRecebidoAditamento"));
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17389]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17389(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var gridMidia = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(gridMidia, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(gridMidia, 1).Should().Be(row.GetCell("RetornarcodigoDoCartaoContratoEstadia"));
                var gridAditamento = _page.RetornarTabelaAditamento();
                _page.RetornarValorDaValidacao(gridAditamento, 1).Should().Be(row.GetCell("valorDaValidacaoAditamento"));
                _page.RetornarFormaPagamento(gridAditamento, 1).Should().Be(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
                _page.RetornarValorRecebido(gridAditamento, 1).Should().Be(row.GetCell("valorRecebidoAditamento"));
            }

        }

        [Step("Preencher os campos do PopUp Aditamento <tabela> [ContratosDeEstadiaPageStep] [17387]")]
        public void PreencherOsCamposDoPopUpAditamentoContratosDeEstadiaPageStep17387(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarValorEditadoManualmente(Convert.ToBoolean(row.GetCell("valorEditadoManualmente")));
            _page.PreencherValorRecebido(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
            _page.PreencherValidadoAteePopUpAditamento(row.GetCell("validadoAteAditamentoContratosEstadia"));
            _page.SelecionarFormaPagamento(row.GetCell("meioPagamentoAditamentoContratosEstadia"));

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17387]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17387(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("codigoDoCartaoContratoEstadia"));
                var grid2 = _page.RetornarTabelaAditamento();
                _page.RetornarValorRecebido(grid2, 1).Should().Be(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
                _page.RetornarFormaPagamento(grid2, 1).Should().Be(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
                _page.RetornarValidadoAteePopUpAditamento(grid2, 1).Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17388]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17388(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("codigoDoCartaoContratoEstadia"));
                var grid2 = _page.RetornarTabelaAditamento();
                _page.RetornarValorRecebido(grid2, 1).Should().Be(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
                _page.RetornarFormaPagamento(grid2, 1).Should().Be(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
                _page.RetornarValidadoAteePopUpAditamento(grid2, 1).Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17391]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17391(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("codigoDoCartaoContratoEstadia"));
                var grid2 = _page.RetornarTabelaAditamento();
                _page.RetornarValorRecebido(grid2, 1).Should().Be(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
                _page.RetornarFormaPagamento(grid2, 1).Should().Be(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
                _page.RetornarValidadoAteePopUpAditamento(grid2, 1).Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17397]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17397(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarTipoDeMidiaDeAcesso(grid, 2).Should().Be(row.GetCell("tipoDeMidiaDeAcessoProximityContratoEstadia"));
                //_page.RetornarTipoDeMidiaDeAcesso(grid, 2).Should().Be(row.GetCell("tipodamidiadeacessocontratosestadiatagnepos"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17395]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17395(Table tabela)
        {
            // TODO : Depende de Maquina
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                //_page.RetornarNomeProdutoEstadiaQuantidadeDeDias().Should().Be(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
                //_page.RetornarTipoDeMidiaDeAcessoContratoEstadia().Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17409]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17409(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17412]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17412(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }
        }

        [Step("Preencher os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void PreencherOsCamposDaTelaContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarProdutoDeEstadia(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
            _page.SelecionarClienteEstacionamento(row.GetCell("nomeClienteDoEstacionamento"));

        }

        [Step("No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 1 - Cartão código de barras sem horário de entrada <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void NoPopUpSelecionarOComboboxTipoDaMidiaDeAcessoComOValor1CartaocodigodebarrassemhorariodeentradaContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoBarcodeContratoEstadia"));
        }

        [Step("No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 2 - Cartão mifare <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void NoPopUpSelecionarOComboboxTipoDaMidiaDeAcessoComOValor2CartaomifareContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoMifareContratoEstadia"));
        }

        [Step("No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 4 - ConectCar <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void NoPopUpSelecionarOComboboxTipoDaMidiaDeAcessoComOValor4ConectCarContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoConnectCarContratoEstadia"));
        }

        [Step("No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 6 - Tag Nepos <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void NoPopUpSelecionarOComboboxTipoDaMidiaDeAcessoComOValor6TagNeposContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoTagNeposContratoEstadia"));
        }

        [Step("Preencher os campos do PopUp <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void PreencherOsCamposDoPopUpContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoBarcodeContratoEstadia"));
            _page.PreencherIdentificacao(row.GetCell("codigoDoCartaoContratoEstadia"));

        }

        [Step("No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 7 - Tag genérica <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void NoPopUpSelecionarOComboboxTipoDaMidiaDeAcessoComOValor7TagGenericaContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoTagGenericaContratoEstadia"));
        }

        [Step("No pop-up selecionar o combobox Tipo da mídia de acesso com o valor 8 - Placa do veículo <tabela> [ContratosDeEstadiaPageStep] [17417]")]
        public void NoPopUpSelecionarOComboboxTipoDaMidiaDeAcessoComOValor8PlacaDoVeiculoContratosdeestadiapagestep17417(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoPlacaContratoEstadia"));
        }

        [Step("Preencher os campos do PopUp Aditamento <tabela> [ContratosDeEstadiaPageStep] [17390]")]
        public void PreencherOsCamposDoPopUpAditamentoContratosDeEstadiaPageStep17390(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarValorEditadoManualmente(Convert.ToBoolean(row.GetCell("valorEditadoManualmente")));
            _page.PreencherValorRecebido(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
            _page.PreencherValidadoAteePopUpAditamento(row.GetCell("validadoAteAditamentoContratosEstadia"));
            _page.SelecionarFormaPagamento(row.GetCell("meioPagamentoAditamentoContratosEstadia"));

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17390]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17390(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoMidiaAcessoContratosEstadias"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("identificacaoMidiaBarcodeContratosEstadias"));
                var grid2 = _page.RetornarTabelaAditamento();
                _page.RetornarValorRecebido(grid2, 1).Should().Be(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
                _page.RetornarValidadoAteePopUpAditamento(grid2, 1).Should().Be(row.GetCell("validadoAteAditamentoContratosEstadia"));
                _page.RetornarFormaPagamento(grid2, 1).Should().Be(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [18013]")]
        public void VerificarOsCamposDaTelaContratosDeEstadiaPageStep18013(Table tabela)
        {
            // TODO : Depende de Maquina
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                //_page.RetornarNomeProdutoEstadiaDiaDoMes().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                //_page.RetornarNomeClienteDoEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                //_page.RetornarVigenteAPartirDeContratosEstadias().Should().Be(row.GetCell("vigenteAPartirDeContratosEstadias"));
                //_page.RetornarValidadoAteContratosEstadia().Should().Be(row.GetCell("validadoAteContratosEstadia"));
                //_page.RetornarTipoDeMidiaDeAcessoContratoEstadia().Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                //_page.RetornarCodigoDoCartaoContratoEstadia().Should().Be(row.GetCell("codigoDoCartaoContratoEstadia"));
                //_page.RetornarDataInclusaoMidiaContratosEstadias().Should().Be(row.GetCell("dataInclusaoMidiaContratosEstadias"));
                //_page.RetornarValidadoAteContratosEstadia().Should().Be(row.GetCell("validadoAteContratosEstadia"));
                //_page.RetornarStatusMidiaContratosEstadia().Should().Be(row.GetCell("statusMidiaContratosEstadia"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17363]")]
        public void PreencherOsCamposDaTelaContratosDeEstadiaPageStep17363(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarProdutoDeEstadia(row.GetCell("nomecredenciadodiaristaprodutosdeestadia"));
            _page.SelecionarClienteEstacionamento(row.GetCell("nomeClienteDoEstacionamento"));

        }

        [Step("Preencher os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17365]")]
        public void PreencherOsCamposDaTelaContratosDeEstadiaPageStep17365(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarProdutoDeEstadia(row.GetCell("nomeprePagoprodutosdeestadia"));
            _page.SelecionarClienteEstacionamento(row.GetCell("nomeClienteDoEstacionamento"));

        }

        [Step("Preencher os campos do pop-up Adicionar validação ao contrato de estadia <tabela> [CriarContratoDeEstadiaProdutoEstadiaDiaDoMesPageStep] [17885]")]
        public void PreencherOsCamposDoPopUpAdicionarValidacaoAoContratoDeEstadiaDaTelaContratoDeEstadiaProdutoStep17885(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarOpcaoRevalidacao(row.GetCell("opcaoderevalidacaocontratosestadia"));
            _page.SelecionarFormaPagamento(row.GetCell("meiodepagamentocontratosestadia"));
        }

        [Step("Preencher os campos da seção Informações gerais <tabela> [ContratosDeEstadiaPageStep] [17885]")]
        public void PreencherOsCamposDaSecaoInformacoesGeraisContratosDeEstadiaPageStep17885(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarProdutoDeEstadia(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
            _page.SelecionarClienteEstacionamento(row.GetCell("nomeClienteDoEstacionamento"));
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17361]")]
        public void VerificarOsCamposDaTelaCriarContratoDeEstadia17361(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17885]")]
        public void PreencherOsCamposDaTelaContratosDeEstadiaPageStep17885(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarProdutoDeEstadia(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
            _page.SelecionarClienteEstacionamento(row.GetCell("nomeClienteDoEstacionamento"));

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17367]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17367(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("ValidoAte"));
                _page.RetornarVerificarTabelaVaziaAditamento();
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17373]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17373(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaQuantidadeDeDias"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornarValidoAteData().Should().Be(row.GetCell("ValidoAte"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipoMidiaAcessoContratosEstadias"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("identificacaoMidiaBarcodeContratosEstadias"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }
        }

        [Step("Preencher os campos do Popup Midia Acesso <tabela> [ContratosDeEstadiaPageStep] [17885]")]
        public void PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17885(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoMidiaAcessoContratosEstadias"));
            _page.PreencherIdentificacao(row.GetCell("codigoCartaoContratosEstadias"));

        }

        [Step("Preencher os campos do Popup de Aditamento <tabela> [ContratosDeEstadiaPageStep] [17930]")]
        public void PreencherOsCamposDoPopupAditamentoContratosDeEstadiaPageStep17930(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherDataExpiracaoMidiaAcesso(row.GetCell("dataExpiracaoMidiaAcessoContratosEstadias"));
            _page.SelecionarIdMotivoGravacao(row.GetCell("motivoGravacaoContratosEstadias"));
            _page.SelecionarIdSituacaoEstadia(row.GetCell("situacaoEstadiaAtualContratosEstadias"));

        }

        [Step("Preencher os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17931]")]
        public void PreencherOsCamposDaTelaContratosDeEstadiaPageStep17931(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherDataExpiracaoMidiaAcesso(row.GetCell("dataExpiracaoMidiaAcessoContratosEstadias"));
            _page.SelecionarIdMotivoGravacao(row.GetCell("motivoGravacaoContratosEstadias"));
            _page.SelecionarIdSituacaoEstadia(row.GetCell("situacaoEstadiaAtualContratosEstadias"));

        }

        [Step("Preencher os campos do PopUp <tabela> [ContratosDeEstadiaPageStep] [17845]")]
        public void PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17845(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
            _page.PreencherIdentificacao(row.GetCell("codigoDoCartaoContratoEstadia"));

        }

        [Step("Preencher os campos do PopUp <tabela> [ContratosDeEstadiaPageStep] [17995]")]
        public void PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17995(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoProximityContratoEstadia"));
            _page.PreencherNumeroSerial(row.GetCell("codigoCartaoProximityContratoEstadia"));

        }

        [Step("Preencher os campos do PopUp <tabela> [ContratosDeEstadiaPageStep] [17390]")]
        public void PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17390(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoMidiaAcessoContratosEstadias"));
            _page.PreencherIdentificacao(row.GetCell("codigoCartaoContratosEstadias"));

        }

        [Step("Preencher os campos da tela <tabela> [IncluirMidiaConnectcarEmUmContratoDeEstadiaStepByStepPageStep] [17920]")]
        public void PreencherOsCamposDaTelaIncluirmidiaconnectcaremumcontratodeestadiastepbysteppagestep17920(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoConectCarContratoEstadia"));
            _page.PreencherIdentificacao(row.GetCell("placaDoVeiculoContratoEstadia"));

        }

        [Step("Preencher os campos da tela <tabela> [IncluirMidiaVeloeEmUmContratoDeEstadiaStepByStepPageStep] [17935]")]
        public void PreencherOsCamposDaTelaIncluirmidiaVeloeEmumcontratodeestadiastepbysteppagestep17935(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoContratoEstadiaVeloe"));
            _page.PreencherIdentificacao(row.GetCell("placaVeiculoContratoEstadia"));
        }

        [Step("Preencher os campos do popup de aditamento <tabela> [ContratosDeEstadiaPageStep] [17930]")]
        public void PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17930(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarOpcaoRevalidacao(row.GetCell("opcaoDeRevalidacaoContratosEstadia"));
            _page.SelecionarFormaPagamento(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
        }

        [Step("Preencher os campos do popup de aditamento <tabela> [ContratosDeEstadiaPageStep] [17962]")]
        public void PreencherOsCamposDoPopupDeAditamentoContratosDeEstadiaPageStep17962(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorRecebido(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
            _page.PreencherValidoAtePopUpAditamento(row.GetCell("validadoAteAditamentoContratosEstadia"));
            _page.SelecionarFormaPagamento(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
        }

        [Step("Preencher os campos do popup de aditamento <tabela> [ContratosDeEstadiaPageStep] [17963]")]
        public void PreencherOsCamposDoPopupDeAditamentoContratosDeEstadiaPageStep17963(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherValorRecebido(row.GetCell("valorRecebidoAditamentoContratosEstadia"));
            _page.PreencherValidoAtePopUpAditamento(row.GetCell("validadoAteAditamentoContratosEstadia"));
            _page.SelecionarFormaPagamento(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
        }

        [Step("Preencher os campos do popup midia de acesso <tabela> [ContratosDeEstadiaPageStep] [17365]")]
        public void PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17365(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
            _page.PreencherIdentificacao(row.GetCell("codigoDoCartaoContratoEstadia"));

        }

        [Step("Preencher os campos do PopUp Gravar Cartão <tabela> [ContratosDeEstadiaPageStep] [17365]")]
        public void PreencherOsCamposDoPopUpGravarCartãoContratosDeEstadiaPageStep17365(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherDataExpiracaoMidiaAcesso(row.GetCell("dataDeExpiracaoContratoEstadia"));
            _page.SelecionarIdMotivoGravacao(row.GetCell("motivoDaGravacaoContratoEstadia"));
            _page.SelecionarIdSituacaoEstadia(row.GetCell("situacaoDaEstadiaAtualContratoEstadia"));

        }

        [Step("Preencher os campos do popup midia de acesso <tabela> [ContratosDeEstadiaPageStep] [17929]")]
        public void PreencherOsCamposDoPopupMidiaDeAcessoContratosDeEstadiaPageStep17929(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipodamidiadeacessocontratosestadiaopngo"));
            _page.PreencherIdentificacao(row.GetCell("placadoveiculocontratosestadiaopngo"));

        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17382]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17382(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(grid, 1).Should().Be(row.GetCell("tipodamidiadeacessocontratosestadiaopngo"));
                _page.RetornarIdentificacao(grid, 1).Should().Be(row.GetCell("placadoveiculocontratosestadiaopngo"));
                _page.RetornarVerificarTabelaVaziaAditamento();
            }

        }

        [Step("Preencher os campos do PopUp Midia Acesso <tabela> [ContratosDeEstadiaPageStep] [17937]")]
        public void PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17937(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipoDeMidiaDeAcessoTagGenericaContratoEstadia"));
            _page.PreencherIdentificacao(row.GetCell("codigoDoCartaoTagGenericaContratoEstadia"));
            _page.PreencherNumeroSerial(row.GetCell("numeroSerialTagGenericaContratoEstadia"));

        }

        [Step("Preencher os campos do PopUp Midia Acesso <tabela> [ContratosDeEstadiaPageStep] [17925]")]
        public void PreencherOsCamposDoPopUpMidiaAcessoContratosDeEstadiaPageStep17925(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoMidia(row.GetCell("tipodamidiadeacessocontratosestadiatagnepos"));
            _page.PreencherIdentificacao(row.GetCell("numeroserialdatagcontratosestadiatagnepos"));

        }

        [Step("Clicar no botão adicionar na seção Mídias de acesso [ProdutoDeEstadiaPageStep]")]
        public void ClicarNoBotaoAdicionarNaSecaoMidiaDeAcessoContratoDeEstadiaPageStep()
        {
            _page.ClicarNoBotaoAdicionarDeMidiasDeAcesso();
        }

        [Step("Clicar no botão adicionar na seção Aditamento [ProdutoDeEstadiaPageStep]")]
        public void ClicarNoBotaoAdicionarNaSecaoAditamentoContratoDeEstadiaPageStep()
        {
            _page.ClicarNoBotaoAdicionarDeAditamento();
        }

        [Step("Aditar contrato no caixa <tabela> [ContratosDeEstadiaPageStep] [17393]")]
        public void AditarContratoCaixaContratosDeEstadiaPageStep17393(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            new ProcessadorMensagem().Processar("specs/Shared/MensagensBarramento/M41EPAYMENTREVALIDATION.json", new[]
            {
                new CamposAlterarMensagemDto(null, "data", DateTime.Now),
                new CamposAlterarMensagemDto(null, "id_pgto", int.Parse(row.GetCell("numeroEquipamentosEAC"))),
            });
        }

        [Step("Verificar os campos da tela <tabela> [ContratosDeEstadiaPageStep] [17393]")]
        public void VerificarOsCamposDaTelaContratosdeestadiapagestep17393(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {                
                _page.RetornarProdutoDeEstadia().Should().Be(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
                _page.RetornarClienteEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                NaSecaoInformacoesGeraisOCampoVigenteAPartirDeDeveConterADataDeCriacaoDatetimeNowContratosdeestadiapagestep();
                var gridMidia = _page.RetornarTabelaMidiaDeAcesso();
                _page.RetornarTipoDeMidiaDeAcesso(gridMidia, 1).Should().Be(row.GetCell("tipoDeMidiaDeAcessoContratoEstadia"));
                _page.RetornarIdentificacao(gridMidia, 1).Should().Be(row.GetCell("retornarcodigoDoCartaoContratoEstadia"));
                var gridAditamento = _page.RetornarTabelaAditamento();
                _page.RetornarValorDaValidacao(gridAditamento, 1).Should().Be(row.GetCell("valorDaValidacaoAditamento"));
                _page.RetornarFormaPagamento(gridAditamento, 1).Should().Be(row.GetCell("meioPagamentoAditamentoContratosEstadia"));
                _page.RetornarValorRecebido(gridAditamento, 1).Should().Be(row.GetCell("valorRecebidoAditamento"));
            }

        }
    }
}