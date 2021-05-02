
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.Operacao.ClientesDoEstacionamento;
using Luminus.Selenium.specs.Shared.Listagem;

namespace Luminus.Selenium.specs.Operacao.ClientesDoEstacionamento
{
    public class ClientesDoEstacionamentoPageStep
    {
        private ClientesDoEstacionamentoPage _page = new ClientesDoEstacionamentoPage();
        private BotoesCRUDSpec _pageButton = new BotoesCRUDSpec();
        private ListagemPageStep _pageListagem = new ListagemPageStep();

        [Step("Preencher os campos da tela Criar um Clientes do estacionamento com CNPJ <tabela>")]
        public void PreencherOsCamposDaTelaCriarUmClientesDoEstacionamentoComCnpj(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeClienteDoEstacionamentoCNPJ(row.GetCell("nomeClienteDoEstacionamentoCNPJ"));
            _page.PreencheremailClienteDoEstacionamentoCNPJ(row.GetCell("emailClienteDoEstacionamentoCNPJ"));
            _page.SelecionardocumentoClienteDoEstacionamentoCNPJ(row.GetCell("documentoClienteDoEstacionamentoCNPJ"));
            _page.PreenchernumeroDocumentoClienteDoEstacionamentoCNPJ(row.GetCell("numeroDocumentoClienteDoEstacionamentoCNPJ"));
            _page.PreenchertelefoneClienteDoEstacionamentoCNPJ(row.GetCell("telefoneClienteDoEstacionamentoCNPJ"));
            _page.PreencherlogradouroClienteDoEstacionamentoCNPJ(row.GetCell("logradouroClienteDoEstacionamentoCNPJ"));
            _page.PreenchernumeroClienteDoEstacionamentoCNPJ(row.GetCell("numeroClienteDoEstacionamentoCNPJ"));
            _page.PreenchercepClienteDoEstacionamentoCNPJ(row.GetCell("cepClienteDoEstacionamentoCNPJ"));
            _page.PreenchercidadeClienteDoEstacionamentoCNPJ(row.GetCell("cidadeClienteDoEstacionamentoCNPJ"));
            _page.PreencherufClienteDoEstacionamentoCNPJ(row.GetCell("ufClienteDoEstacionamentoCNPJ"));

        }

        [Step("Verificar os campos da tela Clientes do estacionamento com CNPJ <tabela> [15980]")]
        public void VerificarOsCamposDaTelaClientesDoEstacionamentocomCNPJ15980(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("nomeClienteDoEstacionamentoCNPJ"));
                _page.RetornaremailClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("emailClienteDoEstacionamentoCNPJ"));
                _page.RetornardocumentoClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("documentoClienteDoEstacionamentoCNPJ"));
                _page.RetornarnumeroDocumentoClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("numeroDocumentoClienteDoEstacionamentoCNPJ"));
                _page.RetornartelefoneClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("telefoneClienteDoEstacionamentoCNPJ"));
                _page.RetornarlogradouroClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("logradouroClienteDoEstacionamentoCNPJ"));
                _page.RetornarnumeroClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("numeroClienteDoEstacionamentoCNPJ"));
                _page.RetornarcepClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("cepClienteDoEstacionamentoCNPJ"));
                _page.RetornarcidadeClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("cidadeClienteDoEstacionamentoCNPJ"));
                _page.RetornarufClienteDoEstacionamentoCNPJ().Should().Be(row.GetCell("ufClienteDoEstacionamentoCNPJ"));
            }
        }

        [Step("Preencher os campos da tela Criar clientes do estacionamento <tabela> [16128]")]
        public void PreencherOsCamposDaTelaCriarClientesDoEstacionamento16128(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeClienteDoEstacionamento(row.GetCell("nomeClienteDoEstacionamento"));
            _page.PreencheremailClienteDoEstacionamento(row.GetCell("emailClienteDoEstacionamento"));
            _page.SelecionardocumentoClienteDoEstacionamento(row.GetCell("documentoClienteDoEstacionamento"));
            _page.PreenchernumeroDocumentoClienteDoEstacionamento(row.GetCell("numeroDocumentoClienteDoEstacionamento"));
            _page.Selecionardocumento2ClienteDoEstacionamento(row.GetCell("documento2ClienteDoEstacionamento"));
            _page.PreenchernumeroDocumento2ClienteDoEstacionamento(row.GetCell("numeroDocumento2ClienteDoEstacionamento"));
            _page.PreenchertelefoneClienteDoEstacionamento(row.GetCell("telefoneClienteDoEstacionamento"));
            _page.PreenchercelularClienteDoEstacionamento(row.GetCell("celularClienteDoEstacionamento"));
            _page.PreencherlogradouroClienteDoEstacionamento(row.GetCell("logradouroClienteDoEstacionamento"));
            _page.PreenchernumeroClienteDoEstacionamento(row.GetCell("numeroClienteDoEstacionamento"));
            _page.PreenchercomplementoClienteDoEstacionamento(row.GetCell("complementoClienteDoEstacionamento"));
            _page.PreenchercepClienteDoEstacionamento(row.GetCell("cepClienteDoEstacionamento"));
            _page.PreenchercidadeClienteDoEstacionamento(row.GetCell("cidadeClienteDoEstacionamento"));
            _page.PreencherufClienteDoEstacionamento(row.GetCell("ufClienteDoEstacionamento"));
            _page.Preencherobservacao1ClienteDoEstacionamento(row.GetCell("observacao1ClienteDoEstacionamento"));
            _page.Preencherobservacao2ClienteDoEstacionamento(row.GetCell("observacao2ClienteDoEstacionamento"));
            _pageButton.ClicarNoBotaoAdicionar();
            _page.PreencherplacaClienteDoEstacionamento(row.GetCell("placaClienteDoEstacionamento"));
            _page.SelecionarmodeloClienteDoEstacionamento(row.GetCell("modeloClienteDoEstacionamento"));
            _page.SelecionarcorClienteDoEstacionamento(row.GetCell("corClienteDoEstacionamento"));
        }

        [Step("Verificar os campos da tela Clientes do estacionamento <tabela> [15980]")]
        public void VerificarOsCamposDaTelaClientesDoEstacionamento15980(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarnomeClienteDoEstacionamento().Should().Be(row.GetCell("nomeClienteDoEstacionamento"));
                _page.RetornaremailClienteDoEstacionamento().Should().Be(row.GetCell("emailClienteDoEstacionamento"));
                _page.RetornardocumentoClienteDoEstacionamento().Should().Be(row.GetCell("documentoClienteDoEstacionamento"));
                _page.RetornarnumeroDocumentoClienteDoEstacionamento().Should().Be(row.GetCell("numeroDocumentoClienteDoEstacionamento"));
                _page.RetornartelefoneClienteDoEstacionamento().Should().Be(row.GetCell("telefoneClienteDoEstacionamento"));
                _page.RetornarlogradouroClienteDoEstacionamento().Should().Be(row.GetCell("logradouroClienteDoEstacionamento"));
                _page.Retornardocumento2ClienteDoEstacionamento().Should().Be(row.GetCell("documento2ClienteDoEstacionamento"));
                _page.RetornarnumeroDocumento2ClienteDoEstacionamento().Should().Be(row.GetCell("numeroDocumento2ClienteDoEstacionamento"));
                _page.Retornarobservacao1ClienteDoEstacionamento().Should().Be(row.GetCell("observacao1ClienteDoEstacionamento"));
                _page.Retornarobservacao2ClienteDoEstacionamento().Should().Be(row.GetCell("observacao2ClienteDoEstacionamento"));
                _page.RetornarcelularClienteDoEstacionamento().Should().Be(row.GetCell("celularClienteDoEstacionamento"));
                _page.RetornarcomplementoClienteDoEstacionamento().Should().Be(row.GetCell("complementoClienteDoEstacionamento"));
                _page.RetornarnumeroClienteDoEstacionamento().Should().Be(row.GetCell("numeroClienteDoEstacionamento"));
                _page.RetornarcepClienteDoEstacionamento().Should().Be(row.GetCell("cepClienteDoEstacionamento"));
                _page.RetornarcidadeClienteDoEstacionamento().Should().Be(row.GetCell("cidadeClienteDoEstacionamento"));
                _page.RetornarufClienteDoEstacionamento().Should().Be(row.GetCell("ufClienteDoEstacionamento"));
                var grid = _page.RetornarTabelaVeiculos();
                _page.RetornarplacaClienteDoEstacionamento(grid, 1).Should().Be(row.GetCell("placaClienteDoEstacionamento"));
                _page.RetornarmodeloClienteDoEstacionamento(grid, 1).Should().Be(row.GetCell("modeloClienteDoEstacionamento"));
                _page.RetornarcorClienteDoEstacionamento(grid, 1).Should().Be(row.GetCell("corClienteDoEstacionamento"));
            }
        }


        [Step("Preencher os campos da tela Alterar clientes do estacionamento <tabela> [16128]")]
        public void PreencherOsCamposDaTelaAlterarClientesDoEstacionamento(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreenchernomeClienteDoEstacionamento(row.GetCell("alterarNomeClienteDoEstacionamento"));
            _page.PreencheremailClienteDoEstacionamento(row.GetCell("alterarEmailClientoDoEstacionamento"));
            _page.SelecionardocumentoClienteDoEstacionamento(row.GetCell("alterarDocumentoClienteDoEstacionamento"));
            _page.PreenchernumeroDocumentoClienteDoEstacionamento(row.GetCell("alterarNumeroDocumentoClienteDoEstacionamento"));
            _page.Selecionardocumento2ClienteDoEstacionamento(row.GetCell("alterarDocumento2ClienteDoEstacionamento"));
            _page.PreenchernumeroDocumento2ClienteDoEstacionamento(row.GetCell("alterarNumeroDocumento2ClienteDoEstacionamento"));
            _page.PreenchertelefoneClienteDoEstacionamento(row.GetCell("alterarTelefoneClienteDoEstacionamento"));
            _page.PreenchercelularClienteDoEstacionamento(row.GetCell("alterarCelularClienteDoEstacionamento"));
            _page.PreencherlogradouroClienteDoEstacionamento(row.GetCell("alterarLogradouroClienteDoEstacionamento"));
            _page.PreenchernumeroClienteDoEstacionamento(row.GetCell("alterarNumeroClienteDoEstacionamento"));
            _page.PreenchercomplementoClienteDoEstacionamento(row.GetCell("alterarComplementoClienteDoEstacionamento"));
            _page.PreenchercepClienteDoEstacionamento(row.GetCell("alterarCepClienteDoEstacionamento"));
            _page.PreenchercidadeClienteDoEstacionamento(row.GetCell("alterarCidadeClienteDoEstacionamento"));
            _page.PreencherufClienteDoEstacionamento(row.GetCell("alterarUfClienteDoEstacionamento"));
            _page.Preencherobservacao1ClienteDoEstacionamento(row.GetCell("alterarObservacao1ClienteDoEstacionamento"));
            _page.Preencherobservacao2ClienteDoEstacionamento(row.GetCell("alterarObservacao2ClienteDoEstacionamento"));
            _pageListagem.ClicarNoMenuDeContextoNaLinhaContendoOValorNaTabela("ALT2019");
            _pageListagem.ClicarBotaoAlterar();
            _page.PreencherplacaClienteDoEstacionamento(row.GetCell("alterarPlacaClienteDoEstacionamento"));
            _page.SelecionarmodeloClienteDoEstacionamento(row.GetCell("alterarModeloClienteDoEstacionamento"));
            _page.SelecionarcorClienteDoEstacionamento(row.GetCell("alterarCorClienteDoEstacionamento"));
            _pageButton.ClicarNoBotaoAlterarPopUp();
        }
    }
}