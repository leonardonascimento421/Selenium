
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ParametrosGeraisDoEstacionamento;
using Luminus.Selenium.Implementation.Pages.ConfiguracaoDoEstacionamento;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Shared.StAlterarATelaDeParametrosGeraisDoEstacionamento17883;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.ParametrosGeraisDoEstacionamento
{
    public class ParametrosGeraisDoEstacionamentoPageStep
    {
        private ParametrosGeraisDoEstacionamentoPage _page = new ParametrosGeraisDoEstacionamentoPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();
        private MensagemSpec _pageMensagemSpec = new MensagemSpec();

        //TODO: Implementar seleção de produto estadia em parâmetros gerais
        //[Step("Criar um Produto Estadia Credenciado(falta fazer)")]
        //public void CriarUmProdutoEstadiaCredenciadoFaltaFazer()
        //{

        //}

        [Step("Preencher os campos da tela<tabela>[ParametrosGeraisDoEstacionamentoPageStep][17883]")]
        public void PreencherOsCamposDaTelaParametrosGeraisDoEstacionamento17883(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherenderecoIpDoServidorLuminusParametrosGerais(row.GetCell("enderecoIpDoServidorLuminusParametrosGerais"));
            _page.PreencherportaIpDoServidorLuminusParametrosGerais(row.GetCell("portaIpDoServidorLuminusParametrosGerais"));
            _page.PreenchertempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais(row.GetCell("tempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais"));
            _page.PreenchertempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais(row.GetCell("tempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais"));
            _page.PreenchertempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais(row.GetCell("tempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais"));
            _page.SelecionaridiomaParametrosGerais(row.GetCell("idiomaParametrosGerais"));
            _page.PreencherhorarioDeViradaOperacionalParametrosGerais(row.GetCell("horarioDeViradaOperacionalParametrosGerais"));
            _page.MarcartratarCartoesFantasmasParametrosGerais(Convert.ToBoolean(row.GetCell("tratarCartoesFantasmasParametrosGerais")));
            _page.MarcartratarCartoesFantasmasParaEscapeParametrosGerais(Convert.ToBoolean(row.GetCell("tratarCartoesFantasmasParaEscapeParametrosGerais")));
            _page.MarcaroperacaoComMidiasComNumeracaoFixaParametrosGerais(Convert.ToBoolean(row.GetCell("operacaoComMidiasComNumeracaoFixaParametrosGerais")));
            _page.MarcarpermitirCriaaoDeRegrasDeAcessoEspecificasNosContratosDeEstadiaParametrosGerais(Convert.ToBoolean(row.GetCell("permitirCriaaoDeRegrasDeAcessoEspecificasNosContratosDeEstadiaParametrosGerais")));
            _page.MarcararredondarValorEstadiaParametrosGerais(Convert.ToBoolean(row.GetCell("arredondarValorEstadiaParametrosGerais")));
            _page.MarcarutilizarSegundosNosCalculosDeEstadiaParametrosGerais(Convert.ToBoolean(row.GetCell("utilizarSegundosNosCalculosDeEstadiaParametrosGerais")));
            _page.MarcarpermitirLoginDeOperadorOffLineParametrosGerais(Convert.ToBoolean(row.GetCell("permitirLoginDeOperadorOffLineParametrosGerais")));
            _page.MarcarpermitirOperacaoEmContingenciaParaMidiaCodigoDeBarrasParametrosGerais(Convert.ToBoolean(row.GetCell("permitirOperacaoEmContingenciaParaMidiaCodigoDeBarrasParametrosGerais")));
            _page.MarcarverificarGravacaoMifareParametrosGerais(Convert.ToBoolean(row.GetCell("verificarGravacaoMifareParametrosGerais")));
            _page.MarcarhabilitarApenasSelosDeDescontosGerenciadosParametrosGerais(Convert.ToBoolean(row.GetCell("habilitarApenasSelosDeDescontosGerenciadosParametrosGerais")));
            _page.PreencherdataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais(row.GetCell("dataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais"));
            _page.PreenchertempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais(row.GetCell("tempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais"));
            _page.PreencherquantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais(row.GetCell("quantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais"));
            _page.SelecionarcomportamentoSeTempoExcedidoParametrosGerais(row.GetCell("comportamentoSeTempoExcedidoParametrosGerais"));
            //TODO: Implementar seleção de produto estadia em parâmetros gerais
            //_page.SelecionarprodutoEstadiaParametrosGerais(row.GetCell("produtoEstadiaParametrosGerais")); [Ainda falta fazer]
            _page.SelecionarnomeBolsaoDeVagas(row.GetCell("nomeBolsaoDeVagas"));
            _page.MarcarbloquearPlacasDiferentesNaSaidaParametrosGerais(Convert.ToBoolean(row.GetCell("bloquearPlacasDiferentesNaSaidaParametrosGerais")));
            _page.PreencherquantidadeMaximaDeCaracteresDiferentesParametrosGerais(row.GetCell("quantidadeMaximaDeCaracteresDiferentesParametrosGerais"));

        }
        [Step("Verificar os campos da tela <tabela> [ParametrosGeraisDoEstacionamentoPageStep] [16228]")]
        public void VerificarOsCamposDaTelaParametrosGeraisDoEstacionamento16228(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarenderecoIpDoServidorLuminusParametrosGerais().Should().Be(row.GetCell("enderecoIpDoServidorLuminusParametrosGerais"));
                _page.RetornarportaIpDoServidorLuminusParametrosGerais().Should().Be(row.GetCell("portaIpDoServidorLuminusParametrosGerais"));
                _page.RetornartempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais().Should().Be(row.GetCell("tempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais"));
                _page.RetornartempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais().Should().Be(row.GetCell("tempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais"));
                _page.RetornartempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais().Should().Be(row.GetCell("tempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais"));
                _page.RetornaridiomaParametrosGerais().Should().Be(row.GetCell("idiomaParametrosGerais"));
                _page.RetornarhorarioDeViradaOperacionalParametrosGerais().Should().Be(row.GetCell("horarioDeViradaOperacionalParametrosGerais"));
                _page.RetornartratarCartoesFantasmasParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("tratarCartoesFantasmasParametrosGerais")));
                _page.RetornartratarCartoesFantasmasParaEscapeParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("tratarCartoesFantasmasParaEscapeParametrosGerais")));
                _page.RetornaroperacaoComMidiasComNumeracaoFixaParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("operacaoComMidiasComNumeracaoFixaParametrosGerais")));
                _page.RetornarpermitirCriaaoDeRegrasDeAcessoEspecificasNosContratosDeEstadiaParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("permitirCriaaoDeRegrasDeAcessoEspecificasNosContratosDeEstadiaParametrosGerais")));
                _page.RetornararredondarValorEstadiaParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("arredondarValorEstadiaParametrosGerais")));
                _page.RetornarutilizarSegundosNosCalculosDeEstadiaParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("utilizarSegundosNosCalculosDeEstadiaParametrosGerais")));
                _page.RetornarpermitirLoginDeOperadorOffLineParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("permitirLoginDeOperadorOffLineParametrosGerais")));
                _page.RetornarpermitirOperacaoEmContingenciaParaMidiaCodigoDeBarrasParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("permitirOperacaoEmContingenciaParaMidiaCodigoDeBarrasParametrosGerais")));
                _page.RetornarverificarGravacaoMifareParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("verificarGravacaoMifareParametrosGerais")));
                _page.RetornarhabilitarApenasSelosDeDescontosGerenciadosParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("habilitarApenasSelosDeDescontosGerenciadosParametrosGerais")));
                _page.RetornardataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais().Should().Be(row.GetCell("dataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais"));
                _page.RetornartempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais().Should().Be(row.GetCell("tempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais"));
                _page.RetornarquantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais().Should().Be(row.GetCell("quantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais"));
                _page.RetornarcomportamentoSeTempoExcedidoParametrosGerais().Should().Be(row.GetCell("comportamentoSeTempoExcedidoParametrosGerais"));
                //TODO: Implementar seleção de produto estadia em parâmetros gerais
                //_page.SelecionarprodutoEstadiaParametrosGerais().Should().Be(row.GetCell("produtoEstadiaParametrosGerais")); [Ainda falta fazer]
                _page.RetornarnomeBolsaoDeVagas().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarbloquearPlacasDiferentesNaSaidaParametrosGerais().Should().Be(Convert.ToBoolean(row.GetCell("bloquearPlacasDiferentesNaSaidaParametrosGerais")));
                _page.RetornarquantidadeMaximaDeCaracteresDiferentesParametrosGerais().Should().Be(row.GetCell("quantidadeMaximaDeCaracteresDiferentesParametrosGerais"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [ParametrosGeraisDoEstacionamentoPageStep] [16229]")]
        public void PreencherOsCamposDaTelaParametrosGeraisDoEstacionamento16229(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherenderecoIpDoServidorLuminusParametrosGerais(row.GetCell("enderecoIpDoServidorLuminusParametrosGerais"));
            _page.SelecionaridiomaParametrosGerais(row.GetCell("idiomaParametrosGerais"));
            _page.PreencherhorarioDeViradaOperacionalParametrosGerais(row.GetCell("horarioDeViradaOperacionalParametrosGerais"));
            _page.PreencherdataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais(row.GetCell("dataBaseParaDataImpressaNoSeloDeDescontoParametrosGerais"));
        }

        [Step("Preencher os campos da tela <tabela> [ParametrosGeraisDoEstacionamentoPageStep] [16230]")]
        public void PreencherOsCamposDaTelaParametrosGeraisDoEstacionamento16230(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchertempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais(row.GetCell("tempoLimiteParaExecucaoDeTransacoesOnlineParametrosGerais"));
            _page.PreenchertempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais(row.GetCell("tempoLimiteParaRecebimentoDeMensagensNoBarramentoMilisegundosParametrosGerais"));
            _page.PreenchertempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais(row.GetCell("tempoLimiteParaEnvioDeMensagensNoBarramentoMilisegundosParametrosGerais"));
            _page.PreenchertempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais(row.GetCell("tempoEntreVerificacoesDaOcupacaoDoPatioParametrosGerais"));
            _page.PreencherquantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais(row.GetCell("quantidadeDeVerificacoesParaConsiderarOffLinePrametrosGerais"));

        }
    }
}