
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.ConfiguracaoDoEstacionamento;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.BolsaoVagas;
using Luminus.Selenium.specs.Shared.Listagem;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.BolsaoVagas
{
    public class BolsaoVagasPageStep
    {
        private BolsaoVagasManterPage _page = new BolsaoVagasManterPage();

        #region ## Permitir código de bolsão de 1 até 14 [13720]

        [Step("Preencher os campos da tela Bolsao Vagas [13720] <tabela>")]
        public void PreencherOsCamposDaTelaBolsaoVagas13720(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherCodigo(row.GetCell("codigoMaiorPermitido"));
            _page.PreencherNome(row.GetCell("nome"));
            _page.PreencherQuantidade(row.GetCell("quantidadeVagas"));
            _page.MarcarBloquearAcessoQuandoLotado(Convert.ToBoolean(row.GetCell("bloquearAacesso")));

        }

        #endregion ## Permitir código de bolsão de 1 até 14 [13720]

        #region ## Nome do bolsão pode ter apenas até 50 caracteres [13722]

        [Step("Preencher os campos da tela Bolsao Vagas [13722] <tabela>")]
        public void PreencherOsCamposDaTelaBolsaoVagas13722(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            PreencherCampo(
                row.GetCell("codigo"),
                row.GetCell("nomeExcecao"),
                row.GetCell("quantidadeVagas"),
                Convert.ToBoolean(row.GetCell("bloquearAacesso"))
                );
        }

        private void PreencherCampo(string codigo, string nome, string quantidade, bool bloquearAcesso)
        {
            _page.PreencherCodigo(codigo);
            _page.PreencherNome(nome);
            _page.PreencherQuantidade(quantidade);
            _page.MarcarBloquearAcessoQuandoLotado(bloquearAcesso);
        }


        #endregion ## Nome do bolsão pode ter apenas até 50 caracteres [13722]

        #region ## Número de vagas deve ser no máximo 999999 [13723]

        [Step("Preencher os campos da tela Bolsao Vagas [13723] <tabela>")]
        public void PreencherOsCamposDaTelaBolsaoVagas13723(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            PreencherCampo(
                            row.GetCell("codigo"),
                            row.GetCell("nome"),
                            row.GetCell("quantidadeVagasMaior"),
                            Convert.ToBoolean(row.GetCell("bloquearAacesso"))
                            );
        }

        #endregion ## Número de vagas deve ser no máximo 999999 [13723]

        #region ## Validar se o código do Bolsão de vagas é único" [13719]

        [Step("Preencher os campos da tela Bolsao Vagas [13719] <tabela>")]
        public void PreencherOsCamposDaTelaBolsaoVagas13719(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherCodigo(row.GetCell("codigoBolsaoDeVagas"));
            _page.PreencherNome(row.GetCell("nomeBolsaoDeVagas"));
            _page.PreencherQuantidade(row.GetCell("quantidadedevagasBolsaoDeVagas"));
            _page.MarcarBloquearAcessoQuandoLotado(Convert.ToBoolean(row.GetCell("bloquearacessoquandolotadobolsaodevagas")));
            _page.MarcarHabilitarControleVagasPorSetor(Convert.ToBoolean(row.GetCell("habilitarControledeVagasporSetorbolsaodevagas")));

        }

        #endregion ## Validar se o código do Bolsão de vagas é único" [13719]

        #region ## Alterar um bolsão de vagas [13709]

        [Step("Preencher os campos da tela Bolsao Vagas [13709] <tabela>")]
        public void PreencherOsCamposDaTelaBolsaoVagas13709(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherCodigo(row.GetCell("nomebolsaodevagas"));
            _page.PreencherNome(row.GetCell("nomebolsaodevagasalterar"));
            _page.PreencherQuantidade(row.GetCell("quantidadedevagasbolsaodevagasalterar"));
            _page.MarcarBloquearAcessoQuandoLotado(Convert.ToBoolean(row.GetCell("bloquearacessoquandolotadobolsaodevagasalterar")));
            _page.MarcarHabilitarControleVagasPorSetor(Convert.ToBoolean(row.GetCell("habilitarControledeVagasporSetorbolsaodevagasalterar")));

        }

        #endregion ## Alterar um bolsão de vagas [13709]

        #region ## Excluir um bolsão de vagas [13710]
              
        #endregion ## Excluir um bolsão de vagas [13710]

        [Step("Verificar campos da tela Bolsao de Vagas <tabela> [13707]")]
        public void VerificarCamposInclusao(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarCodigo().Should().Be(row.GetCell("codigoBolsaoDeVagas"));
                _page.RetornarNome().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarQuantidade().Should().Be(row.GetCell("quantidadedevagasBolsaoDeVagas"));
                _page.RetornarBloquearAcessoQuandoLotado().Should().Be(Convert.ToBoolean(row.GetCell("bloquearacessoquandolotadobolsaodevagas")));
                _page.RetornarHabilitarControleVagasPorSetor().Should().Be(Convert.ToBoolean(row.GetCell("habilitarControledeVagasporSetorbolsaodevagas")));
            }
        }

        [Step("Verificar campos da tela Bolsao de Vagas <tabela> [13709]")]
        public void VerificarCamposAlterados(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarCodigo().Should().Be(row.GetCell("codigoBolsaoDeVagas"));
                _page.RetornarNome().Should().Be(row.GetCell("nomebolsaodevagasalterar"));
                _page.RetornarQuantidade().Should().Be(row.GetCell("quantidadedevagasbolsaodevagasalterar"));
                _page.RetornarBloquearAcessoQuandoLotado().Should().Be(Convert.ToBoolean(row.GetCell("bloquearacessoquandolotadobolsaodevagasalterar")));
                _page.RetornarHabilitarControleVagasPorSetor().Should().Be(Convert.ToBoolean(row.GetCell("habilitarControledeVagasporSetorbolsaodevagasalterar")));
            }
        }

        [Step("Preencher os campos da tela Bolsao Vagas [16266] <tabela>")]
        public void PreencherOsCamposDaTelaBolsaoVagas16266(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherCodigo(row.GetCell("codigoBolsaoDeVagas"));
            _page.PreencherNome(row.GetCell("nomeBolsaoDeVagas"));
            _page.PreencherQuantidade(row.GetCell("quantidadedevagasBolsaoDeVagas"));
            _page.MarcarBloquearAcessoQuandoLotado(Convert.ToBoolean(row.GetCell("bloquearacessoquandolotadobolsaodevagas")));
            _page.MarcarHabilitarControleVagasPorSetor(Convert.ToBoolean(row.GetCell("habilitarControledeVagasporSetorbolsaodevagas")));
        }
    }
}