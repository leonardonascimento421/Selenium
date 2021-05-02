
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.RegrasDeEmissaoDeBilhetesImpressos;
using Luminus.Selenium.specs.Shared.SsCriarEquipamentoDeEntradaEaeMifareStepByStep16899;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoATodosAsFuncionalidades17684;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.RegrasDeEmissaoDeBilhetesImpressos
{
    public class RegrasDeEmissaoDeBilhetesImpressosPageStep
    {
        private RegrasDeEmissaoDeBilhetesImpressosPage _page = new RegrasDeEmissaoDeBilhetesImpressosPage();

        [Step("Carregar dependências Regras de Emissao de Bilhetes Impressos <tabela>")]
        public void CarregarDependenciasRegrasDeEmissaoBilhetesImpre(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecution(() =>
            {
                // steps de dependências
                new StCriarUmBolsaoDeVagas16266PageStep().StCriarUmBolsaoDeVagas16266(tabela);
                new StCriarPerfilComAcessoATodosAsFuncionalidades17684PageStep().StCriarPerfilComAcessoATodosAsFuncionalidades17684(tabela);
                new SsCriarEquipamentoDeEntradaEaeMifareStepByStep16899PageStep().SsCriarEquipamentoDeEntradaEaeMifareStepByStep16899(tabela);
            });
        }

        [Step("Preencher os campos da tela de Regras de emissão de recibo <tabela> [RegrasDeEmissaoDeBilhetesImpressosPageStep]")]
        public void PreencherOsCamposDatelaOValorTesteCriacaoRegrasdeemissaodebilhetesimpressospagestep(Table tabela)
        {

            var row = tabela.GetTableRows()[0];
            _page.PreencherNomeRegraDeRecibo(row.GetCell("nomeEmissaoDeBilhetes"));
            _page.PreencherCabecalhoLinhaUm(row.GetCell("linha1CabecalhoEmissaoDeBilhetes"));
            _page.PreencherCabecalhoLinhaDois(row.GetCell("linha2CabecalhoEmissaoDeBilhetes"));
            _page.PreencherRodapeLinhaUm(row.GetCell("linha1RodapeEmissaoDeBilhetes"));
            _page.PreencherRodapeLinhaDois(row.GetCell("linha2RodapeEmissaoDeBilhetes"));
        }


        [Step("Preencher os campos da tela Alterar regras de emissão de recibo <tabela> [RegrasDeEmissaoDeBilhetesImpressosPageStep]")]
        public void PreencherOCampoNomeComOValorTesteAlteracaoRegrasdeemissaodebilhetesimpressospagestep(Table tabela)
        {

            var row = tabela.GetTableRows()[0];
            _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteEmissaoDeBilhetes")));
            _page.PreencherNomeRegraDeRecibo(row.GetCell("nomeEmissaoDeBilhetesAlterar"));
            _page.PreencherCabecalhoLinhaUm(row.GetCell("linha1CabecalhoEmissaoDeBilhetesAlterar"));
            _page.PreencherCabecalhoLinhaDois(row.GetCell("linha2CabecalhoEmissaoDeBilhetesAlterar"));
            _page.PreencherRodapeLinhaUm(row.GetCell("linha1RodapeEmissaoDeBilhetesAlterar"));
            _page.PreencherRodapeLinhaDois(row.GetCell("linha2RodapeEmissaoDeBilhetesalterar"));
        }



        [Step("Verificar os campos da tela <tabela> [RegrasDeEmissaoDeBilhetesImpressosPageStep]")]
        public void VerificarOsCamposDaTelaRegrasdeemissaodebilhetesimpressospagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarVersaoEmissaoDeBilhetes().Should().Be(row.GetCell("versaoEmissaoDeBilhetes"));
                _page.RetornarNomeRegraDeRecibo().Should().Be(row.GetCell("nomeEmissaoDeBilhetes"));
                _page.RetornarCabecalhoLinhaUm().Should().Be(row.GetCell("linha1CabecalhoEmissaoDeBilhetes"));
                _page.RetornarCabecalhoLinhaDois().Should().Be(row.GetCell("linha2CabecalhoEmissaoDeBilhetes"));
                _page.RetornarRodapeLinhaUm().Should().Be(row.GetCell("linha1RodapeEmissaoDeBilhetes"));
                _page.RetornarRodapeLinhaDois().Should().Be(row.GetCell("linha2RodapeEmissaoDeBilhetes"));
            }
        }

        [Step("Verificar os campos da tela alterado <tabela> [RegrasDeEmissaoDeBilhetesImpressosPageStep] [17513]")]
        public void VerificarOsCamposDaTelaRegrasdeemissaodebilhetesimpressosAlteradopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarVersaoEmissaoDeBilhetes().Should().Be(row.GetCell("versaoEmissaoDeBilhetesalterar"));
                _page.RetornarNomeRegraDeRecibo().Should().Be(row.GetCell("nomeEmissaoDeBilhetesAlterar"));
                _page.RetornarCabecalhoLinhaUm().Should().Be(row.GetCell("linha1CabecalhoEmissaoDeBilhetesAlterar"));
                _page.RetornarCabecalhoLinhaDois().Should().Be(row.GetCell("linha2CabecalhoEmissaoDeBilhetesAlterar"));
                _page.RetornarRodapeLinhaUm().Should().Be(row.GetCell("linha1RodapeEmissaoDeBilhetesAlterar"));
                _page.RetornarRodapeLinhaDois().Should().Be(row.GetCell("linha2RodapeEmissaoDeBilhetesalterar"));
            }

        }

        [Step("Preencher os campos da tela de Regras de emissão de recibo <tabela> [RegrasDeEmissaoDeBilhetesImpressosPageStep] [17512]")]
        public void PreencherOsCampos17512Regrasdeemissaodebilhetesimpressospagestep(Table tabela)
        {

            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.MarcarImediatamente(Convert.ToBoolean(row.GetCell("imediatamenteEmissaoDeBilhetes")));
            }
        }

        [Step("Preencher os campos da tela de Aplicar regras de emissão de recibo <tabela> [RegrasDeEmissaoDeBilhetesImpressosPageStep]")]
        public void PreencherOsCamposDatelaOValorTesteAplicacaoRegrasdeemissaodebilhetesimpressospagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarEquipamento(row.GetCell("nomeEquipamentoEAEMifare"));
            _page.SelecionarRegraAplicar(row.GetCell("nomeEmissaoDeBilhetes"), Convert.ToBoolean(row.GetCell("radiobuttonRegraDeEmissao")));
        }
    }
}