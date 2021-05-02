
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Financeiro.IntegracaoTef;
using Luminus.Selenium.specs.Shared.Listagem;

namespace Luminus.Selenium.specs.Financeiro.IntegracaoTef
{
    public class IntegracaoTefPageStep
    {
        private IntegracaoTefPage _page = new IntegracaoTefPage();


        [Step("Preencher os campos da tela Criar uma integração TEF Pay&Go <tabela>")]
        public void PreencherOsCamposDaTelaCriarUmaIntegracaoTefPayGoStepByStep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeItegracaoTEFPayGo"));
            _page.SelecionarOperadoraTEF(row.GetCell("operadoraTEFIntegracaoTEFPayGo"));
            _page.SelecionarTipoDeReciboTEF(row.GetCell("tipoDeReciboTEFItegracaoTEFPayGo"));
            _page.PreencherIPdoServidor(row.GetCell("iPDoServidorItegracaoTEFPayGo"));
            _page.PreencherTimeoutDeComunicacao(row.GetCell("timeoutDeComunicacaoItegracaoTEFPayGo"));
            _page.MarcarImprimirViaDoClienteEmFormatoReduzido(Convert.ToBoolean(row.GetCell("imprimirViaDoClienteEmFormatoReduzidoItegracaoTEFPayGo")));

        }

        [Step("Preencher os campos da tela Criar uma integração TEF SITEF <tabela>")]
        public void PreencherOsCamposDaTelaCriarUmaIntegracaoTefSitef(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeIntegracaoTEF"));
            _page.SelecionarOperadoraTEF(row.GetCell("operadoraIntegracaoTEF"));
            _page.SelecionarTipoDeReciboTEF(row.GetCell("tipoDeReciboIntegracaoTEF"));
            _page.PreencherIPdoServidor(row.GetCell("iPDoServidorSITEFIntegracaoTEF"));
            _page.PreencherCodigoDaLoja(row.GetCell("codigoDaLojaSITEFIntegracaoTEF"));

        }

        [Step("Verificar os campos da tela Integração TEF PayAndGo <tabela>")]
        public void VerificarOsCamposDaTelaIntegracaoTef(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarNome().Should().Be(row.GetCell("nomeItegracaoTEFPayGo"));
               _page.RetornarOperadoraTEF().Should().Be(row.GetCell("operadoraTEFIntegracaoTEFPayGo"));
               _page.RetornarTipoDeReciboTEF().Should().Be(row.GetCell("tipoDeReciboTEFItegracaoTEFPayGo"));
               _page.RetornarIPdoServidor().Should().Be(row.GetCell("iPDoServidorItegracaoTEFPayGo"));
               _page.RetornarTimeoutDeComunicacao().Should().Be(row.GetCell("timeoutDeComunicacaoItegracaoTEFPayGo"));
               _page.RetornarImprimirViaDoClienteEmFormatoReduzido().Should().Be(Convert.ToBoolean(row.GetCell("imprimirViaDoClienteEmFormatoReduzidoItegracaoTEFPayGo")));
            }      
        }

        [Step("Verificar os campos da tela Integração SiTEF <tabela>")]
        public void VerificarOsCamposDaTelaIntegracaoSiTef(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeItegracaoTEFPayGo"));
                _page.RetornarOperadoraTEF().Should().Be(row.GetCell("operadoraTEFIntegracaoTEFPayGo"));
                _page.RetornarTipoDeReciboTEF().Should().Be(row.GetCell("tipoDeReciboTEFItegracaoTEFPayGo"));
                _page.RetornarIPdoServidor().Should().Be(row.GetCell("iPDoServidorItegracaoTEFPayGo"));
                _page.RetornarTimeoutDeComunicacao().Should().Be(row.GetCell("timeoutDeComunicacaoItegracaoTEFPayGo"));
                _page.RetornarCodigoDaLoja().Should().Be(row.GetCell("codigoDaLojaSITEFIntegracaoTEF"));
            }
        }

        [Step("Verificar os campos da tela Integração TEF <tabela> [16454]")]
        public void VerificarOsCamposDaTelaIntegracaoTef16454(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarNome().Should().Be(row.GetCell("nomeIntegracaoTEF"));
               _page.RetornarOperadoraTEF().Should().Be(row.GetCell("operadoraIntegracaoTEF"));
               _page.RetornarTipoDeReciboTEF().Should().Be(row.GetCell("tipoDeReciboIntegracaoTEF"));
               _page.RetornarIPdoServidor().Should().Be(row.GetCell("iPDoServidorSITEFIntegracaoTEF"));
               _page.RetornarCodigoDaLoja().Should().Be(row.GetCell("codigoDaLojaSITEFIntegracaoTEF"));
            }
        
        }

        [Step("Na seção Informações gerais alterar o campo nome para o valor <alterarNomeItegracaoTEF> [16455]")]
        public void NaSecaoInformacoesGeraisAlterarOCampoNomeParaOValor(string alterarNomeItegracaoTEF)
        {
            _page.PreencherNome(alterarNomeItegracaoTEF);
        }

        [Step("Na seção Informações gerais alterar o campo nome para o valor <alterarNomeItegracaoTEF> [16456]")]
        public void NaSecaoInformacoesGeraisAlterarOCampoNomeParaOValorSiTef(string alterarNomeItegracaoTEF)
        {
            _page.PreencherNome(alterarNomeItegracaoTEF);
        }

        [Step("Na seção Informações gerais no combobox Tipo de recibo TEF alterar a opção para <alterarTipoDeReciboTEFItegracaoTEFPayGo>")]
        public void NaSecaoInformacoesGeraisNoComboboxTipoDeReciboTefAlterarAOpcaoPara(string alterarTipoDeReciboTEFItegracaoTEF)
        {
            _page.SelecionarTipoDeReciboTEF(alterarTipoDeReciboTEFItegracaoTEF);
        }

        [Step("Na seção Operadora TEF:Pay&Go no campo IP do servidor alterar o valor para <alterarIPDoServidorItegracaoTEFPayGo>")]
        public void NaSecaoOperadoraTefPayAmpGoNoCampoIpDoServidorAlterarOValorPara(string alterarIPDoServidorItegracaoTEF)
        {
            _page.PreencherIPdoServidor(alterarIPDoServidorItegracaoTEF);
        }

        [Step("Na seção Operadora TEF:Pay&Go no campo Timeout de comunicação alterar o valor para <alterarTimeoutDeComunicacaoItegracaoTEFPayGo>")]
        public void NaSecaoOperadoraTefPayAmpGoNoCampoTimeoutDeComunicacaoAlterarOValorPara(string alterarTimeoutDeComunicacaoItegracaoTEF)
        {
            _page.PreencherTimeoutDeComunicacao(alterarTimeoutDeComunicacaoItegracaoTEF);
        }

        [Step("Na seção Operadora_TEF_Integração_TEF_Pay_Go desmarcar o checkbox Imprimir via do cliente em formato reduzido para o valor <alterarImprimirViaDoClienteEmFormatoReduzidoItegracaoTEFPayGo>")]
        public void NaSecaoOperadoraTefIntegracaoTefPayGoDesmarcarOCheckboxImprimirViaDoClienteEmFormatoReduzidoParaOValor(bool alterarImprimirViaDoClienteEmFormatoReduzidoItegracaoTEFPayGo)
        {
            _page.MarcarImprimirViaDoClienteEmFormatoReduzido(alterarImprimirViaDoClienteEmFormatoReduzidoItegracaoTEFPayGo);
        }

        [Step("Na seção Operadora TEF: SITEF alterar o campo Código da loja com o valor <codigoDaLojaSITEFIntegracaoTEFAlterado>")]
        public void NaSecaoOperadoraTefSitefAlterarOCampoCodigoDaLojaComOValor(string codigoDaLojaSITEFIntegracaoTEFAlterado)
        {
            _page.PreencherCodigoDaLoja(codigoDaLojaSITEFIntegracaoTEFAlterado);
        }

        [Step("Na seção Informações gerais alterar o campo Tipo de recibo TEF com o valor <alterarTipoDeReciboTEFItegracaoTEF>")]
        public void NaSecaoOperadoraTefIntegracaoTefSifAlterarTipoDeRecibo(string alterarTipoDeReciboTEFItegracaoTEF)
        {
            _page.SelecionarTipoDeReciboTEF(alterarTipoDeReciboTEFItegracaoTEF);
        }

        [Step("Na seção Operadora TEF: SITEF alterar o campo IP do servidor com o valor <alterarIpDoServidorIntegracaoTEF>")]
        public void NaSecaoOperadoraTefIntegracaoTefSifPreencherCampoIp(string alterarIpDoServidorIntegracaoTEF)
        {
            _page.PreencherIPdoServidor(alterarIpDoServidorIntegracaoTEF);
        }


        [Step("Verificar os campos da tela Integração TEF <tabela> [16455]")]
        public void VerificarOsCamposDaTelaIntegracaoTef16455(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarNome().Should().Be(row.GetCell("alterarNomeItegracaoTEFPayGo"));
               _page.RetornarOperadoraTEF().Should().Be(row.GetCell("alterarOperadoraTEFIntegracaoTEFPayGo"));
               _page.RetornarTipoDeReciboTEF().Should().Be(row.GetCell("alterarTipoDeReciboTEFItegracaoTEFPayGo"));
               _page.RetornarIPdoServidor().Should().Be(row.GetCell("alterarIPDoServidorItegracaoTEFPayGo"));
               _page.RetornarTimeoutDeComunicacao().Should().Be(row.GetCell("alterarTimeoutDeComunicacaoItegracaoTEFPayGo"));
               _page.RetornarImprimirViaDoClienteEmFormatoReduzido().Should().Be(Convert.ToBoolean(row.GetCell("alterarImprimirViaDoClienteEmFormatoReduzidoItegracaoTEFPayGo")));
            }
        }

         [Step("Verificar os campos da tela Integração SiTEF <tabela> [16456]")]
         public void VerificarOsCamposDaTelaIntegracaoSiTef16456(Table tabela)
         {
             var row = tabela.GetTableRows()[0];
             using (new AssertionScope())
             {
                _page.RetornarNome().Should().Be(row.GetCell("nomeIntegracaoTEFAlterado"));
                _page.RetornarOperadoraTEF().Should().Be(row.GetCell("operadoraIntegracaoTEF"));
                _page.RetornarTipoDeReciboTEF().Should().Be(row.GetCell("tipoDeReciboIntegracaoTEFAlterado"));
                _page.RetornarIPdoServidor().Should().Be(row.GetCell("iPDoServidorSITEFIntegracaoTEFAlterado"));
                _page.RetornarCodigoDaLoja().Should().Be(row.GetCell("codigoDaLojaSITEFIntegracaoTEFAlterado"));
             }

         }

        [Step("Na seção Informações gerais selecionar no combobox Operadora TEF o valor <operadoraTEFIntegracaoTefPayampGo>")]
        public void NaSecaoInformacoesGeraisSelecionarNoComboboxOperadoraTefOValor(string operadoraTEFIntegracaoTefPayampGo)
        {
            _page.SelecionarOperadoraTEF(operadoraTEFIntegracaoTefPayampGo);
        }

        [Step("Na seção Informações gerais clicar no combobox Operadora TEF e selecionar o valor <operadoraTEFintegracaotef>")]
        public void NaSecaoInformacoesGeraisClicarNoComboboxOperadoraTefESelecionarOValor(string operadoraTEFintegracaotef)
        {
            _page.SelecionarOperadoraTEF(operadoraTEFintegracaotef);
        }


    }
}