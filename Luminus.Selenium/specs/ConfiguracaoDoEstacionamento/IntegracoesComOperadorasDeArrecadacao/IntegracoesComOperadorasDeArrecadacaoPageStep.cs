
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.IntegracoesComOperadorasDeArrecadacao;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.IntegracoesComOperadorasDeArrecadacao
{
    public class IntegracoesComOperadorasDeArrecadacaoPageStep
    {
        private IntegracoesComOperadorasDeArrecadacaoPage _page = new IntegracoesComOperadorasDeArrecadacaoPage();

        [Step("Preencher os campos da tela <tabela> [CriarIntegracaoComOperadorasDeArrecadacaoSemPararPageStep]")]
        public void PreencherOsCamposDaTelaCriarintegracaocomoperadorasdearrecadacaosempararpagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNomeSempararintegracaooperadoraarrecadacao(row.GetCell("nomeSempararintegracaooperadoraarrecadacao"));
            _page.SelecionarOperadoradearrecadacaointegracaooperadoraarrecadacao(row.GetCell("operadoradearrecadacaointegracaooperadoraarrecadacao"));
            _page.SelecionarTipodeintegracaointegracaooperadoraarrecadacao(row.GetCell("tipodeintegracaointegracaooperadoraarrecadacao"));
            _page.PreencherIgnorarleituradamesmatagsegintegracaooperadoraarrecadacao(row.GetCell("ignorarleituradamesmatagsegintegracaooperadoraarrecadacao"));
            _page.PreencherTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao(row.GetCell("tempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao"));
            _page.MarcarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("mantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao")));
            _page.MarcarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("permitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao")));
            _page.PreencherEnderecoIPdoservicointegracaooperadoraarrecadacao(row.GetCell("enderecoIPdoservicointegracaooperadoraarrecadacao"));
            _page.PreencherPortaintegracaooperadoraarrecadacao(row.GetCell("portaintegracaooperadoraarrecadacao"));
            _page.PreencherCaminhointegracaooperadoraarrecadacao(row.GetCell("caminhointegracaooperadoraarrecadacao"));
            _page.PreencherUsuariointegracaooperadoraarrecadacao(row.GetCell("usuariointegracaooperadoraarrecadacao"));
            _page.PreencherSenhaintegracaooperadoraarrecadacao(row.GetCell("senhaintegracaooperadoraarrecadacao"));

        }

        [Step("Verificar os campos da tela <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep]")]
        public void VerificarOsCamposDaTelaIntegracoescomoperadorasdearrecadacaopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNomeSempararintegracaooperadoraarrecadacao().Should().Be(row.GetCell("nomeSempararintegracaooperadoraarrecadacao"));
                _page.RetornarOperadoradearrecadacaointegracaooperadoraarrecadacao().Should().Be(row.GetCell("operadoradearrecadacaointegracaooperadoraarrecadacao"));
                _page.RetornarTipodeintegracaointegracaooperadoraarrecadacao().Should().Be(row.GetCell("tipodeintegracaointegracaooperadoraarrecadacao"));
                _page.RetornarIgnorarleituradamesmatagsegintegracaooperadoraarrecadacao().Should().Be(row.GetCell("ignorarleituradamesmatagsegintegracaooperadoraarrecadacao"));
                _page.RetornarTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao().Should().Be(row.GetCell("tempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao"));
                _page.RetornarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("mantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao")));
                _page.RetornarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("permitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao")));
                _page.RetornarEnderecoIPdoservicointegracaooperadoraarrecadacao().Should().Be(row.GetCell("enderecoIPdoservicointegracaooperadoraarrecadacao"));
                _page.RetornarPortaintegracaooperadoraarrecadacao().Should().Be(row.GetCell("portaintegracaooperadoraarrecadacao"));
                _page.RetornarCaminhointegracaooperadoraarrecadacao().Should().Be(row.GetCell("caminhointegracaooperadoraarrecadacao"));
                _page.RetornarUsuariointegracaooperadoraarrecadacao().Should().Be(row.GetCell("usuariointegracaooperadoraarrecadacao"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep] [16650]")]
        public void PreencherOsCamposDaTelaIntegracoescomoperadorasdearrecadacaopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamenteintegracaooperadoraarrecadacaoalterar(Convert.ToBoolean(row.GetCell("imediatamenteintegracaooperadoraarrecadacaoalterar")));
            _page.PreencherNomeSempararintegracaooperadoraarrecadacao(row.GetCell("nomeSempararintegracaooperadoraarrecadacaoalterar"));
            _page.PreencherIgnorarleituradamesmatagsegintegracaooperadoraarrecadacao(row.GetCell("ignorarleituradamesmatagsegintegracaooperadoraarrecadacaoalterar"));
            _page.PreencherTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao(row.GetCell("tempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacaoalterar"));
            _page.MarcarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("mantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacaoalterar")));
            _page.MarcarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("permitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacaoalterar")));
            _page.PreencherEnderecoIPdoservicointegracaooperadoraarrecadacao(row.GetCell("enderecoIPdoservicointegracaooperadoraarrecadacaoalterar"));
            _page.PreencherPortaintegracaooperadoraarrecadacao(row.GetCell("portaintegracaooperadoraarrecadacaoalterar"));
            _page.PreencherCaminhointegracaooperadoraarrecadacao(row.GetCell("caminhointegracaooperadoraarrecadacaoalterar"));
            _page.PreencherUsuariointegracaooperadoraarrecadacao(row.GetCell("usuariointegracaooperadoraarrecadacaoalterar"));
            _page.PreencherSenhaintegracaooperadoraarrecadacao(row.GetCell("senhaintegracaooperadoraarrecadacaoalterar"));
        }

        [Step("Verificar os campos da tela <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep] [16650]")]
        public void VerificarOsCamposDaTelaIntegracoescomoperadorasdearrecadacaopagestep16650(Table tabela)
        {
             var row = tabela.GetTableRows()[0];
             using (new AssertionScope())
             {
                _page.RetornarNomeSempararintegracaooperadoraarrecadacao().Should().Be(row.GetCell("nomeSempararintegracaooperadoraarrecadacaoalterar"));
                _page.RetornarIgnorarleituradamesmatagsegintegracaooperadoraarrecadacaoalterar().Should().Be(row.GetCell("ignorarleituradamesmatagsegintegracaooperadoraarrecadacaoalterar"));
                _page.RetornarTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacaoalterar().Should().Be(row.GetCell("tempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacaoalterar"));
                _page.RetornarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("mantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacaoalterar")));
                _page.RetornarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("permitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacaoalterar")));
                _page.RetornarEnderecoIPdoservicointegracaooperadoraarrecadacao().Should().Be(row.GetCell("enderecoIPdoservicointegracaooperadoraarrecadacaoalterar"));
                _page.RetornarPortaintegracaooperadoraarrecadacao().Should().Be(row.GetCell("portaintegracaooperadoraarrecadacaoalterar"));
                _page.RetornarCaminhointegracaooperadoraarrecadacao().Should().Be(row.GetCell("caminhointegracaooperadoraarrecadacaoalterar"));
                _page.RetornarUsuariointegracaooperadoraarrecadacao().Should().Be(row.GetCell("usuariointegracaooperadoraarrecadacaoalterar"));
             }           

        }

        [Step("Na seção Informações gerais clicar no combobox Operadora de arrecadação e selecionar o valor <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep]")]
        public void NasecaoInformacoesgeraisclicarnocomboboxOperadoradearrecadacaoeselecionarovalorIntegracoesComOperadorasDeArrecadacaoPageStep (Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarOperadoradearrecadacaointegracaooperadoraarrecadacao(row.GetCell("operadoradearrecadacaointegracaooperadoraarrecadacao"));      

        }

        [Step("Preencher os campos da tela <tabela> [CriarIntegracoesComOperadorasConectcarPageStep]")]
        public void PreencherOsCamposDaTelaCriarintegracoescomoperadorasconectcarpagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNomeSempararintegracaooperadoraarrecadacao(row.GetCell("nomeIntegracoesComOperadoras"));
            _page.SelecionarOperadoradearrecadacaointegracaooperadoraarrecadacao(row.GetCell("operadorDeArrecadacaoIntegracoesComOperadoras"));
            _page.SelecionarTipodeintegracaointegracaooperadoraarrecadacao(row.GetCell("tipoDeIntegracaoIntegracoesComOperadoras"));
            _page.PreencherIgnorarleituradamesmatagsegintegracaooperadoraarrecadacao(row.GetCell("ignorarLeituraDaMesmaTagIntegracoesComOperadoras"));
            _page.PreencherTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao(row.GetCell("tempoLimiteParaConfirmacaoDaSaidaDoVeiculoIntegracoesComOperadoras"));
            _page.MarcarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("manterCancelaAbertaSeAcessoComMidiaDaOperadoraCanceladoIntegracoesComOperadoras")));
            _page.MarcarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("permitirOperadoraMudarTabelaDeCobrancaIntegracoesComOperadoras")));
            _page.PreencherEnderecoIPdoservicointegracaooperadoraarrecadacao(row.GetCell("enderecoIPDoServicoIntegracoesComOperadoras"));
            _page.PreencherPortaintegracaooperadoraarrecadacao(row.GetCell("portaIntegracoesComOperadoras"));
            _page.PreencherCaminhointegracaooperadoraarrecadacao(row.GetCell("caminhoIntegracoesComOperadoras"));
            _page.PreencherUsuariointegracaooperadoraarrecadacao(row.GetCell("usuarioIntegracoesComOperadoras"));
            _page.PreencherSenhaintegracaooperadoraarrecadacao(row.GetCell("senhaIntegracoesComOperadoras"));


        }

        [Step("Verificar os campos da tela <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep] [16653]")]
        public void VerificarOsCamposDaTelaIntegracoescomoperadorasdearrecadacaopagestep16653(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNomeSempararintegracaooperadoraarrecadacao().Should().Be(row.GetCell("nomeIntegracoesComOperadoras"));
                _page.RetornarIgnorarleituradamesmatagsegintegracaooperadoraarrecadacaoalterar().Should().Be(row.GetCell("ignorarLeituraDaMesmaTagIntegracoesComOperadoras"));
                _page.RetornarTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacaoalterar().Should().Be(row.GetCell("tempoLimiteParaConfirmacaoDaSaidaDoVeiculoIntegracoesComOperadoras"));
                _page.RetornarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("manterCancelaAbertaSeAcessoComMidiaDaOperadoraCanceladoIntegracoesComOperadoras")));
                _page.RetornarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("permitirOperadoraMudarTabelaDeCobrancaIntegracoesComOperadoras")));
                _page.RetornarEnderecoIPdoservicointegracaooperadoraarrecadacao().Should().Be(row.GetCell("enderecoIPDoServicoIntegracoesComOperadoras"));
                _page.RetornarPortaintegracaooperadoraarrecadacao().Should().Be(row.GetCell("portaIntegracoesComOperadoras"));
                _page.RetornarCaminhointegracaooperadoraarrecadacao().Should().Be(row.GetCell("caminhoIntegracoesComOperadoras"));
                _page.RetornarUsuariointegracaooperadoraarrecadacao().Should().Be(row.GetCell("usuarioIntegracoesComOperadoras"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep] [16654]")]
        public void PreencherOsCamposDaTelaIntegracoescomoperadorasdearrecadacaopagestep16654(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamenteintegracaooperadoraarrecadacaoalterar(Convert.ToBoolean(row.GetCell("imediatamenteIntegracoesComOperadoras")));
            _page.PreencherNomeSempararintegracaooperadoraarrecadacao(row.GetCell("nomeIntegracoesComOperadorasalterar"));
            _page.PreencherIgnorarleituradamesmatagsegintegracaooperadoraarrecadacao(row.GetCell("ignorarLeituraDaMesmaTagIntegracoesComOperadorasalterar"));
            _page.PreencherTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacao(row.GetCell("tempoLimiteParaConfirmacaoDaSaidaDoVeiculoIntegracoesComOperadorasalterar"));
            _page.MarcarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("manterCancelaAbertaSeAcessoComMidiaDaOperadoraCanceladoIntegracoesComOperadorasalterar")));
            _page.MarcarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao(Convert.ToBoolean(row.GetCell("permitirOperadoraMudarTabelaDeCobrancaIntegracoesComOperadorasalterar")));
            _page.PreencherEnderecoIPdoservicointegracaooperadoraarrecadacao(row.GetCell("enderecoIPDoServicoIntegracoesComOperadorasalterar"));
            _page.PreencherPortaintegracaooperadoraarrecadacao(row.GetCell("portaIntegracoesComOperadorasalterar"));
            _page.PreencherCaminhointegracaooperadoraarrecadacao(row.GetCell("caminhoIntegracoesComOperadorasalterar"));
            _page.PreencherUsuariointegracaooperadoraarrecadacao(row.GetCell("usuarioIntegracoesComOperadorasalterar"));
            _page.PreencherSenhaintegracaooperadoraarrecadacao(row.GetCell("senhaIntegracoesComOperadorasalterar"));

        }

        [Step("Verificar os campos da tela <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep] [16654]")]
        public void VerificarOsCamposDaTelaIntegracoescomoperadorasdearrecadacaopagestep16654(Table tabela)
        {
             var row = tabela.GetTableRows()[0];
             using (new AssertionScope())
             {
                _page.RetornarNomeSempararintegracaooperadoraarrecadacao().Should().Be(row.GetCell("nomeIntegracoesComOperadorasalterar"));
                _page.RetornarIgnorarleituradamesmatagsegintegracaooperadoraarrecadacaoalterar().Should().Be(row.GetCell("ignorarLeituraDaMesmaTagIntegracoesComOperadorasalterar"));
                _page.RetornarTempolimiteparaconfirmacaodasaidadoveiculosegintegracaooperadoraarrecadacaoalterar().Should().Be(row.GetCell("tempoLimiteParaConfirmacaoDaSaidaDoVeiculoIntegracoesComOperadorasalterar"));
                _page.RetornarMantercancelaabertaseacessocommidiadaoperadoracanceladointegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("manterCancelaAbertaSeAcessoComMidiaDaOperadoraCanceladoIntegracoesComOperadorasalterar")));
                _page.RetornarPermitiroperadoramudartabeladecobrancaintegracaooperadoraarrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("permitirOperadoraMudarTabelaDeCobrancaIntegracoesComOperadorasalterar")));
                _page.RetornarEnderecoIPdoservicointegracaooperadoraarrecadacao().Should().Be(row.GetCell("enderecoIPDoServicoIntegracoesComOperadorasalterar"));
                _page.RetornarPortaintegracaooperadoraarrecadacao().Should().Be(row.GetCell("portaIntegracoesComOperadorasalterar"));
                _page.RetornarCaminhointegracaooperadoraarrecadacao().Should().Be(row.GetCell("caminhoIntegracoesComOperadorasalterar"));
                _page.RetornarUsuariointegracaooperadoraarrecadacao().Should().Be(row.GetCell("usuarioIntegracoesComOperadorasalterar"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [IntegracoesComOperadorasDeArrecadacaoPageStep] [16656]")]
        public void PreencherOsCamposDaTelaIntegracoescomoperadorasdearrecadacaopagestep16656(Table tabela)
        {
             var row = tabela.GetTableRows()[0];
             _page.MarcarImediatamenteintegracaooperadoraarrecadacaoalterar(Convert.ToBoolean(row.GetCell("imediatamenteIntegracoesComOperadoras")));
             _page.SelecionarOperadoradearrecadacaointegracaooperadoraarrecadacao(row.GetCell("operadorDeArrecadacaoIntegracoesComOperadoras"));

        }          

    }
}