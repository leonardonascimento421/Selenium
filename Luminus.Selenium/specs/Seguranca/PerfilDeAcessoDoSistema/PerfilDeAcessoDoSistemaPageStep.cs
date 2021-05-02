
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;

namespace Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema
{
    public class PerfilDeAcessoDoSistemaPageStep
    {
        private PerfilDeAcessoDoSistemaPage _page = new PerfilDeAcessoDoSistemaPage();

        [Step("Preencher os campos da tela Criar perfil com acesso a AtedimentoValet [17676] <tabela>")]
        public void PreencherOsCamposDaTelaCriarPerfilComAcessoAAtedimentovalet17676(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomePerfisDeAcessoDoSistema"));
            _page.MarcarAtendimentoValetAtendimentoValetConsultarVeiculos(Convert.ToBoolean(row.GetCell("consultarVeiculosperfisdeacessodosistema")));
        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17676]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17676(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomePerfisDeAcessoDoSistema"));
                _page.RetornarAtendimentoValetAtendimentoValetConsultarVeiculos().Should().Be(Convert.ToBoolean(row.GetCell("consultarVeiculosperfisdeacessodosistema")));
            }
        }

        [Step("PreencherOsCamposDaTelaCriarPerfilComAcessoAConfiguracoesDeEstacionamento [17739] <tabela>")]
        public void PreencherOsCamposDaTelaCriarPerfilComAcessoAConfiguracoesDeEstacionamento17739(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomePerfisDeAcessoDoSistema"));
            _page.MarcarConfiguracoesdoestacionamentoBolsoesdevagasConsultar(Convert.ToBoolean(row.GetCell("consultarBolsoesDeVagasPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoBolsoesdevagasIncluir(Convert.ToBoolean(row.GetCell("incluirBolsoesDeVagasPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoBolsoesdevagasAlterar(Convert.ToBoolean(row.GetCell("alterarBolsoesDeVagasPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoBolsoesdevagasExcluir(Convert.ToBoolean(row.GetCell("excluirBolsoesDeVagasPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoArquivosseriaismifareCarregar(Convert.ToBoolean(row.GetCell("carregarArquivosSeriaisMifarePerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoEquipamentosConsultar(Convert.ToBoolean(row.GetCell("consultarEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoEquipamentosAlterar(Convert.ToBoolean(row.GetCell("alterarEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoEquipamentosExcluir(Convert.ToBoolean(row.GetCell("excluirEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoEquipamentosIncluir(Convert.ToBoolean(row.GetCell("incluirEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoEstacionamentosConsultar(Convert.ToBoolean(row.GetCell("consultarEstacionamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoEstacionamentosAlterar(Convert.ToBoolean(row.GetCell("alterarEstacionamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoGruposdeequipamentosConsultar(Convert.ToBoolean(row.GetCell("consultarGruposDeEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoGruposdeequipamentosIncluir(Convert.ToBoolean(row.GetCell("consultarGruposDeEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoGruposdeequipamentosAlterar(Convert.ToBoolean(row.GetCell("alterarGruposDeEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoGruposdeequipamentosExcluir(Convert.ToBoolean(row.GetCell("excluirGruposDeEquipamentosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoConsultar(Convert.ToBoolean(row.GetCell("consultarIntegracaoPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAlterar(Convert.ToBoolean(row.GetCell("alterarIntegracaoPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoExcluir(Convert.ToBoolean(row.GetCell("excluirIntegracaoPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoIncluir(Convert.ToBoolean(row.GetCell("incluirIntegracaoPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAplicar(Convert.ToBoolean(row.GetCell("aplicarIntegracaoPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoConsultar(Convert.ToBoolean(row.GetCell("consultarParametrosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoAlterar(Convert.ToBoolean(row.GetCell("alterarParametrosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoExcluir(Convert.ToBoolean(row.GetCell("excluirParametrosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoIncluir(Convert.ToBoolean(row.GetCell("incluirParametrosPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosConsultar(Convert.ToBoolean(row.GetCell("consultarEmissaoDeBilhetesPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAlterar(Convert.ToBoolean(row.GetCell("alterarEmissaoDeBilhetesPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosExcluir(Convert.ToBoolean(row.GetCell("excluirEmissaoDeBilhetesPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosIncluir(Convert.ToBoolean(row.GetCell("incluirEmissaoDeBilhetesPerfilDeAcessoConfig")));
            _page.MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAplicar(Convert.ToBoolean(row.GetCell("aplicarEmissaoDeBilhetesPerfilDeAcessoConfig")));
        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17264]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17264(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomePerfisDeAcessoDoSistema"));
                _page.RetornarConfiguracoesdoestacionamentoBolsoesdevagasConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarBolsoesDeVagasPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoBolsoesdevagasIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirBolsoesDeVagasPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoBolsoesdevagasAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarBolsoesDeVagasPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoBolsoesdevagasExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirBolsoesDeVagasPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoArquivosseriaismifareCarregar().Should().Be(Convert.ToBoolean(row.GetCell("carregarArquivosSeriaisMifarePerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoEquipamentosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoEquipamentosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoEquipamentosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoEquipamentosExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoEstacionamentosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEstacionamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoEstacionamentosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarEstacionamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoGruposdeequipamentosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarGruposDeEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoGruposdeequipamentosExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirGruposDeEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoGruposdeequipamentosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirGruposDeEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoGruposdeequipamentosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarGruposDeEquipamentosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarIntegracaoPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirIntegracaoPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarIntegracaoPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarIntegracaoPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirIntegracaoPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarParametrosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirParametrosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarParametrosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirParametrosPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEmissaoDeBilhetesPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirEmissaoDeBilhetesPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarEmissaoDeBilhetesPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarEmissaoDeBilhetesPerfilDeAcessoConfig")));
                _page.RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirEmissaoDeBilhetesPerfilDeAcessoConfig")));
            }

        }

        [Step("Preencher os campos da tela Criar perfil de acesso - Customizacão [17667] <tabela>")]
        public void PreencherOsCamposDaTelaCriarPerfilDeAcessoCustomizacao17667(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeperfisdeacessodosistema"));
            _page.MarcarCustomizacaoMultimidiaConsultar(Convert.ToBoolean(row.GetCell("consultarMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoConfiguracaoMultimidiaAlterar(Convert.ToBoolean(row.GetCell("alterarMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoConfiguracaodeMultimidiaExcluir(Convert.ToBoolean(row.GetCell("excluirMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoConfiguracaoMultimidiaIncluir(Convert.ToBoolean(row.GetCell("incluirMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoConfiguracaoMultimidiaAplicar(Convert.ToBoolean(row.GetCell("aplicarMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoApresentacaoMultimidiaConsultar(Convert.ToBoolean(row.GetCell("consultarApresentacaoMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoApresentacaoMultimidiaAlterar(Convert.ToBoolean(row.GetCell("alterarApresentacaoMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoApresentacaoMultimidiaExcluir(Convert.ToBoolean(row.GetCell("excluirApresentacaoMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoApresentacaoMultimidiaIncluir(Convert.ToBoolean(row.GetCell("incluirApresentacaoMultimidiaPerfilAcesso")));
            _page.MarcarCustomizacaoApresentacaoMultimidiaAplicar(Convert.ToBoolean(row.GetCell("aplicarApresentacaoMultimidiaPerfilAcesso")));
        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17265]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17265(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeperfisdeacessodosistema"));
                _page.RetornarCustomizacaoMultimidiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoConfiguracaoMultimidiaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoConfiguracaoMultimidiaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoConfiguracaoMultimidiaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoConfiguracaoMultimidiaAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoApresentacaoMultimidiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarApresentacaoMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoApresentacaoMultimidiaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarApresentacaoMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoApresentacaoMultimidiaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirApresentacaoMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoApresentacaoMultimidiaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirApresentacaoMultimidiaPerfilAcesso")));
                _page.RetornarCustomizacaoApresentacaoMultimidiaAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarApresentacaoMultimidiaPerfilAcesso")));
            }

        }

        [Step("Preencher os campos da tela Criar perfil de acesso - Financeiro [17267] <tabela>")]
        public void PreencherOsCamposDaTelaCriarPerfilDeAcessoCustomizacao17267(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeperfisdeacessodosistema"));
            _page.MarcarFinanceiroEmitentefiscalConsultar(Convert.ToBoolean(row.GetCell("consultarEmitenteFiscalperfisdeacessodosistema")));
            _page.MarcarFinanceiroEmitentefiscalAlterar(Convert.ToBoolean(row.GetCell("alterarEmitenteFiscalperfisdeacessodosistema")));
            _page.MarcarFinanceiroEmitentefiscalExcluir(Convert.ToBoolean(row.GetCell("excluirEmitenteFiscalperfisdeacessodosistema")));
            _page.MarcarFinanceiroEmitentefiscalIncluir(Convert.ToBoolean(row.GetCell("incluirEmitenteFiscalperfisdeacessodosistema")));
            _page.MarcarFinanceiroEmitentefiscalAplicar(Convert.ToBoolean(row.GetCell("aplicarEmitenteFiscalperfisdeacessodosistema")));
            _page.MarcarFinanceiroConfiguracaodeintegracaoTEFConsultar(Convert.ToBoolean(row.GetCell("consultarConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
            _page.MarcarFinanceiroConfiguracaodeintegracaoTEFAlterar(Convert.ToBoolean(row.GetCell("alterarConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
            _page.MarcarFinanceiroConfiguracaodeintegracaoTEFExcluir(Convert.ToBoolean(row.GetCell("excluirConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
            _page.MarcarFinanceiroConfiguracaodeintegracaoTEFIncluir(Convert.ToBoolean(row.GetCell("incluirConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
            _page.MarcarFinanceiroConfiguracaodeintegracaoTEFAplicar(Convert.ToBoolean(row.GetCell("aplicarConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdeemissaoderecibosConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdeemissaoderecibosAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdeemissaoderecibosExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdeemissaoderecibosIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdeemissaoderecibosAplicar(Convert.ToBoolean(row.GetCell("aplicarRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdefechamentodosequipamentosConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdefechamentodosequipamentosAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdefechamentodosequipamentosExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdefechamentodosequipamentosIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdefechamentodosequipamentosAplicar(Convert.ToBoolean(row.GetCell("aplicarRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdenumerariodeautoatendimentoConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdenumerariodeautoatendimentoAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdenumerariodeautoatendimentoExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdenumerariodeautoatendimentoIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegrasdenumerariodeautoatendimentoAplicar(Convert.ToBoolean(row.GetCell("aplicarRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegistroCambialConsultar(Convert.ToBoolean(row.GetCell("consultarRegistroCambialperfisdeacessodosistema")));
            _page.MarcarFinanceiroRegistroCambialAlterar(Convert.ToBoolean(row.GetCell("alterarRegistroCambialperfisdeacessodosistema")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17267]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17267(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeperfisdeacessodosistema"));
                _page.RetornarFinanceiroEmitentefiscalConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEmitenteFiscalperfisdeacessodosistema")));
                _page.RetornarFinanceiroEmitentefiscalAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarEmitenteFiscalperfisdeacessodosistema")));
                _page.RetornarFinanceiroEmitentefiscalExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirEmitenteFiscalperfisdeacessodosistema")));
                _page.RetornarFinanceiroEmitentefiscalIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirEmitenteFiscalperfisdeacessodosistema")));
                _page.RetornarFinanceiroEmitentefiscalAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarEmitenteFiscalperfisdeacessodosistema")));
                _page.RetornarFinanceiroConfiguracaodeintegracaoTEFConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
                _page.RetornarFinanceiroConfiguracaodeintegracaoTEFAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
                _page.RetornarFinanceiroConfiguracaodeintegracaoTEFExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
                _page.RetornarFinanceiroConfiguracaodeintegracaoTEFIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
                _page.RetornarFinanceiroConfiguracaodeintegracaoTEFAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarConfiguracaoDeIntegracaoTEFperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdeemissaoderecibosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdeemissaoderecibosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdeemissaoderecibosExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdeemissaoderecibosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdeemissaoderecibosAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarRegrasDeEmissaoDeRecibosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdefechamentodosequipamentosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdefechamentodosequipamentosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdefechamentodosequipamentosExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdefechamentodosequipamentosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdefechamentodosequipamentosAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarRegrasDeFechamentoDosEquipamentosperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdenumerariodeautoatendimentoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdenumerariodeautoatendimentoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdenumerariodeautoatendimentoExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdenumerariodeautoatendimentoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegrasdenumerariodeautoatendimentoAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarRegrasDeNumerariosDeAutoatendimentoperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegistroCambialConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegistroCambialperfisdeacessodosistema")));
                _page.RetornarFinanceiroRegistroCambialAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegistroCambialperfisdeacessodosistema")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [CriarPerfilDeAcessoAInstalacoesEAtualizacoesPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfildeacessoainstalacoeseatualizacoespagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomePerfilDeAcessoAtt"));
            _page.MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosConsultar(Convert.ToBoolean(row.GetCell("consultaragendamentoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosCancelar(Convert.ToBoolean(row.GetCell("cancelaragendamentoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosAlterar(Convert.ToBoolean(row.GetCell("alteraragendamentoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosIncluir(Convert.ToBoolean(row.GetCell("incluiragendamentoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesAplicativoseversoesConsultar(Convert.ToBoolean(row.GetCell("consultarAplicativoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesAplicativoseversoesExcluir(Convert.ToBoolean(row.GetCell("excluirAplicativoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesAplicativoseversoesCarregar(Convert.ToBoolean(row.GetCell("carregarAplicativoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosConsultar(Convert.ToBoolean(row.GetCell("consultarMonitoramentoPerfilDeAcessoAtt")));
            _page.MarcarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosAlterar(Convert.ToBoolean(row.GetCell("alterarMonitoramentoPerfilDeAcessoAtt")));
        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17268]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17268(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomePerfilDeAcessoAtt"));
                _page.RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultaragendamentoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosCancelar().Should().Be(Convert.ToBoolean(row.GetCell("cancelaragendamentoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alteraragendamentoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluiragendamentoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesAplicativoseversoesConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarAplicativoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesAplicativoseversoesExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirAplicativoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesAplicativoseversoesCarregar().Should().Be(Convert.ToBoolean(row.GetCell("carregarAplicativoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarMonitoramentoPerfilDeAcessoAtt")));
                _page.RetornarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarMonitoramentoPerfilDeAcessoAtt")));
            }

        }

        [Step("Preencher os campos da tela <tabela> [CriarPerfilDeAcessoOperacaoPageStep] [17269]")]
        public void PreencherOsCamposDaTelaCriarperfildeacessooperacaopagestep17269(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeperfisdeacessodosistema"));
            _page.MarcarOperacaoAgendamentodetarefasautomatizadasConsultar(Convert.ToBoolean(row.GetCell("consultarAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
            _page.MarcarOperacaoAgendamentodetarefasautomatizadasIncluir(Convert.ToBoolean(row.GetCell("incluirAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
            _page.MarcarOperacaoAgendamentodetarefasautomatizadasAlterar(Convert.ToBoolean(row.GetCell("alterarAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
            _page.MarcarOperacaoAgendamentodetarefasautomatizadasExcluir(Convert.ToBoolean(row.GetCell("excluirAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
            _page.MarcarOperacaoConfiguracaodemododecontingenciaConsultar(Convert.ToBoolean(row.GetCell("consultarConfiguracaodemododecontingenciaperfisdeacessodosistema")));
            _page.MarcarOperacaoConfiguracaodemododecontingenciaIncluir(Convert.ToBoolean(row.GetCell("incluirConfiguracaodemododecontingenciaperfisdeacessodosistema")));
            _page.MarcarOperacaoAlteracaotemporariadotempodetoleranciaConsultar(Convert.ToBoolean(row.GetCell("consultarCargaparavalidadormanualdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoAlteracaotemporariadotempodetoleranciaIncluir(Convert.ToBoolean(row.GetCell("incluirCargaparavalidadormanualdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoCargaparavalidadormanualdeestadiaConsultar(Convert.ToBoolean(row.GetCell("consultarCargaparavalidadormanualdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoCargaparavalidadormanualdeestadiaIncluir(Convert.ToBoolean(row.GetCell("incluirCargaparavalidadormanualdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoClientesdoestacionamentoConsultar(Convert.ToBoolean(row.GetCell("consultarClientesdoestacionamentoperfisdeacessodosistema")));
            _page.MarcarOperacaoClientesdoestacionamentoIncluir(Convert.ToBoolean(row.GetCell("incluirClientesdoestacionamentoperfisdeacessodosistema")));
            _page.MarcarOperacaoClientesdoestacionamentoAlterar(Convert.ToBoolean(row.GetCell("alterarClientesdoestacionamentoperfisdeacessodosistema")));
            _page.MarcarOperacaoClientesdoestacionamentoExcluir(Convert.ToBoolean(row.GetCell("excluirClientesdoestacionamentoperfisdeacessodosistema")));
            _page.MarcarOperacaoContratosdeestadiaConsultar(Convert.ToBoolean(row.GetCell("consultarContratosdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoContratosdeestadiaIncluir(Convert.ToBoolean(row.GetCell("incluirContratosdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoContratosdeestadiaAlterar(Convert.ToBoolean(row.GetCell("alterarContratosdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoContratosdeestadiaExcluir(Convert.ToBoolean(row.GetCell("excluirContratosdeestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoControledeequipamentosConsultar(Convert.ToBoolean(row.GetCell("consultarControledeequipamentosperfisdeacessodosistema")));
            _page.MarcarOperacaoControledeequipamentosAcoesdecancela(Convert.ToBoolean(row.GetCell("acoesdecancelaControledeequipamentosperfisdeacessodosistema")));
            _page.MarcarOperacaoControledeequipamentosComandosauxiliares(Convert.ToBoolean(row.GetCell("comandosauxiliaresControledeequipamentosperfisdeacessodosistema")));
            _page.MarcarOperacaoControledeequipamentosEntradamanual(Convert.ToBoolean(row.GetCell("entradamanualControledeequipamentosperfisdeacessodosistema")));
            _page.MarcarOperacaoControledeequipamentosAssociarMidiaPerdida(Convert.ToBoolean(row.GetCell("associarMidiaPerdidaControledeequipamentosperfisdeacessodosistema")));
            _page.MarcarOperacaoControledeequipamentosSaidamanual(Convert.ToBoolean(row.GetCell("saidamanualControledeequipamentosperfisdeacessodosistema")));
            _page.MarcarOperacaoControledeequipamentosPassagemmanual(Convert.ToBoolean(row.GetCell("passagemmanualControledeequipamentosperfisdeacessodosistema")));
            _page.MarcarOperacaoEstadiasabertasConsultar(Convert.ToBoolean(row.GetCell("consultarEstadiasabertasperfisdeacessodosistema")));
            _page.MarcarOperacaoRegrasdelimpezadepatioautomaticaConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
            _page.MarcarOperacaoRegrasdelimpezadepatioautomaticaIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
            _page.MarcarOperacaoRegrasdelimpezadepatioautomaticaAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
            _page.MarcarOperacaoRegrasdelimpezadepatioautomaticaExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
            _page.MarcarOperacaoMidiasperdidaspreautorizadasConsultar(Convert.ToBoolean(row.GetCell("consultarMidiasperdidaspreautorizadasperfisdeacessodosistema")));
            _page.MarcarOperacaoOperacaodemultiplascancelasConsultar(Convert.ToBoolean(row.GetCell("consultarOperacaodemultiplascancelasperfisdeacessodosistema")));
            _page.MarcarOperacaoTiposdeocorrenciasnasestadiaConsultar(Convert.ToBoolean(row.GetCell("consultarTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoTiposdeocorrenciasnasestadiaIncluir(Convert.ToBoolean(row.GetCell("incluirTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoTiposdeocorrenciasnasestadiaAlterar(Convert.ToBoolean(row.GetCell("alterarTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoTiposdeocorrenciasnasestadiaExcluir(Convert.ToBoolean(row.GetCell("excluirTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
            _page.MarcarOperacaoUsuariosnaoautorizadosConsultar(Convert.ToBoolean(row.GetCell("consultarUsuariosnaoautorizadosperfisdeacessodosistema")));
            _page.MarcarOperacaoUsuariosnaoautorizadosIncluir(Convert.ToBoolean(row.GetCell("incluirUsuariosnaoautorizadosperfisdeacessodosistema")));
            _page.MarcarOperacaoUsuariosnaoautorizadosAlterar(Convert.ToBoolean(row.GetCell("alterarUsuariosnaoautorizadosperfisdeacessodosistema")));
            _page.MarcarOperacaoUsuariosnaoautorizadosExcluir(Convert.ToBoolean(row.GetCell("excluirUsuariosnaoautorizadosperfisdeacessodosistema")));
            _page.MarcarOperacaoCapturasLPRConsultar(Convert.ToBoolean(row.GetCell("consultarCapturasLPRperfisdeacessodosistema")));
            _page.MarcarOperacaoCapturasLPRAlterar(Convert.ToBoolean(row.GetCell("alterarCapturasLPRperfisdeacessodosistema")));
            _page.MarcarOperacaoAnalisarmidiadeoperacaoConsultar(Convert.ToBoolean(row.GetCell("consultarAnalisarmidiadeoperacaoperfisdeacessodosistema")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17269]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17269(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeperfisdeacessodosistema"));
                _page.RetornarOperacaoAgendamentodetarefasautomatizadasConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
                _page.RetornarOperacaoAgendamentodetarefasautomatizadasIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
                _page.RetornarOperacaoAgendamentodetarefasautomatizadasAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
                _page.RetornarOperacaoAgendamentodetarefasautomatizadasExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirAgendamentodetarefasautomatizadasperfisdeacessodosistema")));
                _page.RetornarOperacaoConfiguracaodemododecontingenciaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarConfiguracaodemododecontingenciaperfisdeacessodosistema")));
                _page.RetornarOperacaoConfiguracaodemododecontingenciaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirConfiguracaodemododecontingenciaperfisdeacessodosistema")));
                _page.RetornarOperacaoAlteracaotemporariadotempodetoleranciaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarAlteracaotemporariadotempodetoleranciaperfisdeacessodosistema")));
                _page.RetornarOperacaoAlteracaotemporariadotempodetoleranciaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirAlteracaotemporariadotempodetoleranciaperfisdeacessodosistema")));
                _page.RetornarOperacaoCargaparavalidadormanualdeestadiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarCargaparavalidadormanualdeestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoCargaparavalidadormanualdeestadiaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirCargaparavalidadormanualdeestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoClientesdoestacionamentoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarClientesdoestacionamentoperfisdeacessodosistema")));
                _page.RetornarOperacaoClientesdoestacionamentoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirClientesdoestacionamentoperfisdeacessodosistema")));
                _page.RetornarOperacaoClientesdoestacionamentoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarClientesdoestacionamentoperfisdeacessodosistema")));
                _page.RetornarOperacaoClientesdoestacionamentoExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirClientesdoestacionamentoperfisdeacessodosistema")));
                _page.RetornarOperacaoContratosdeestadiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarContratosdeestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoContratosdeestadiaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirContratosdeestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoContratosdeestadiaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarContratosdeestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoContratosdeestadiaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirContratosdeestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoControledeequipamentosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarControledeequipamentosperfisdeacessodosistema")));
                _page.RetornarOperacaoControledeequipamentosAcoesdecancela().Should().Be(Convert.ToBoolean(row.GetCell("acoesdecancelaControledeequipamentosperfisdeacessodosistema")));
                _page.RetornarOperacaoControledeequipamentosComandosauxiliares().Should().Be(Convert.ToBoolean(row.GetCell("comandosauxiliaresControledeequipamentosperfisdeacessodosistema")));
                _page.RetornarOperacaoControledeequipamentosEntradamanual().Should().Be(Convert.ToBoolean(row.GetCell("entradamanualControledeequipamentosperfisdeacessodosistema")));
                _page.RetornarOperacaoControledeequipamentosAssociarMidiaPerdida().Should().Be(Convert.ToBoolean(row.GetCell("associarMidiaPerdidaControledeequipamentosperfisdeacessodosistema")));
                _page.RetornarOperacaoControledeequipamentosSaidamanual().Should().Be(Convert.ToBoolean(row.GetCell("saidamanualControledeequipamentosperfisdeacessodosistema")));
                _page.RetornarOperacaoControledeequipamentosPassagemmanual().Should().Be(Convert.ToBoolean(row.GetCell("passagemmanualControledeequipamentosperfisdeacessodosistema")));
                _page.RetornarOperacaoEstadiasabertasConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEstadiasabertasperfisdeacessodosistema")));
                _page.RetornarOperacaoRegrasdelimpezadepatioautomaticaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
                _page.RetornarOperacaoRegrasdelimpezadepatioautomaticaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
                _page.RetornarOperacaoRegrasdelimpezadepatioautomaticaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
                _page.RetornarOperacaoRegrasdelimpezadepatioautomaticaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasdelimpezadepatioautomaticaperfisdeacessodosistema")));
                _page.RetornarOperacaoMidiasperdidaspreautorizadasConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarMidiasperdidaspreautorizadasperfisdeacessodosistema")));
                _page.RetornarOperacaoOperacaodemultiplascancelasConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarOperacaodemultiplascancelasperfisdeacessodosistema")));
                _page.RetornarOperacaoTiposdeocorrenciasnasestadiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoTiposdeocorrenciasnasestadiaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoTiposdeocorrenciasnasestadiaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoTiposdeocorrenciasnasestadiaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirTiposdeocorrenciasnasestadiaperfisdeacessodosistema")));
                _page.RetornarOperacaoUsuariosnaoautorizadosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarUsuariosnaoautorizadosperfisdeacessodosistema")));
                _page.RetornarOperacaoUsuariosnaoautorizadosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirUsuariosnaoautorizadosperfisdeacessodosistema")));
                _page.RetornarOperacaoUsuariosnaoautorizadosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarUsuariosnaoautorizadosperfisdeacessodosistema")));
                _page.RetornarOperacaoUsuariosnaoautorizadosExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirUsuariosnaoautorizadosperfisdeacessodosistema")));
                _page.RetornarOperacaoCapturasLPRConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarCapturasLPRperfisdeacessodosistema")));
                _page.RetornarOperacaoCapturasLPRAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarCapturasLPRperfisdeacessodosistema")));
                _page.RetornarOperacaoAnalisarmidiadeoperacaoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarAnalisarmidiadeoperacaoperfisdeacessodosistema")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [CriarPerfilComAcessoAProdutosDeEstadiaStepByStepPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfilcomacessoaprodutosdeestadiastepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeperfisdeacessodosistema"));
            _page.MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaConsultar(Convert.ToBoolean(row.GetCell("consultarEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaIncluir(Convert.ToBoolean(row.GetCell("incluirEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaAlterar(Convert.ToBoolean(row.GetCell("alterarEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaExcluir(Convert.ToBoolean(row.GetCell("excluirEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaProdutosdeestadiaConsultar(Convert.ToBoolean(row.GetCell("consultarProdutosDeEstadiaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaProdutosdeestadiaIncluir(Convert.ToBoolean(row.GetCell("incluirProdutosDeEstadiaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaProdutosdeestadiaAlterar(Convert.ToBoolean(row.GetCell("alterarProdutosDeEstadiaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaProdutosdeestadiaExcluir(Convert.ToBoolean(row.GetCell("excluirProdutosDeEstadiaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaProdutosdeestadiaAplicar(Convert.ToBoolean(row.GetCell("aplicarProdutosDeEstadiaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeacessoConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasDeAcessoperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeacessoIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasDeAcessoperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeacessoAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasDeAcessoperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeacessoExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasDeAcessoperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdecobrancaConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdecobrancaIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdecobrancaAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdecobrancaExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdecobrancaAplicar(Convert.ToBoolean(row.GetCell("aplicarRegrasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeDescontosConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasDeDescontosperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeDescontosIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasDeDescontosperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeDescontosAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasDeDescontosperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeDescontosExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasDeDescontosperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdeDescontosAplicar(Convert.ToBoolean(row.GetCell("aplicarRegrasDeDescontosperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdemidiaperdidaConsultar(Convert.ToBoolean(row.GetCell("consultarRegrasDeMidiaPerdidaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdemidiaperdidaIncluir(Convert.ToBoolean(row.GetCell("incluirRegrasDeMidiaPerdidaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdemidiaperdidaAlterar(Convert.ToBoolean(row.GetCell("alterarRegrasDeMidiaPerdidaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdemidiaperdidaExcluir(Convert.ToBoolean(row.GetCell("excluirRegrasDeMidiaPerdidaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaRegrasdemidiaperdidaAplicar(Convert.ToBoolean(row.GetCell("aplicarRegrasDeMidiaPerdidaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaTabelasdecobrancaConsultar(Convert.ToBoolean(row.GetCell("consultarTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaTabelasdecobrancaIncluir(Convert.ToBoolean(row.GetCell("incluirTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaTabelasdecobrancaAlterar(Convert.ToBoolean(row.GetCell("alterarTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaTabelasdecobrancaExcluir(Convert.ToBoolean(row.GetCell("excluirTabelasDeCobrancaperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaTiposdedescontoConsultar(Convert.ToBoolean(row.GetCell("consultarTipoDeDescontoperfisdeacessodosistema")));
            _page.MarcarProdutosdeestadiaTiposdedescontoAlterar(Convert.ToBoolean(row.GetCell("alterarTipoDeDescontoperfisdeacessodosistema")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17270]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17270(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeperfisdeacessodosistema"));
                _page.RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirEstruturasDeTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaProdutosdeestadiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarProdutosDeEstadiaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaProdutosdeestadiaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirProdutosDeEstadiaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaProdutosdeestadiaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarProdutosDeEstadiaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaProdutosdeestadiaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirProdutosDeEstadiaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaProdutosdeestadiaAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarProdutosDeEstadiaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeacessoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasDeAcessoperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeacessoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasDeAcessoperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeacessoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasDeAcessoperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeacessoExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasDeAcessoperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdecobrancaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdecobrancaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdecobrancaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdecobrancaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdecobrancaAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarRegrasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeDescontosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasDeDescontosperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeDescontosIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasDeDescontosperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeDescontosAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasDeDescontosperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeDescontosExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasDeDescontosperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdeDescontosAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarRegrasDeDescontosperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdemidiaperdidaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarRegrasDeMidiaPerdidaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdemidiaperdidaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirRegrasDeMidiaPerdidaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdemidiaperdidaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarRegrasDeMidiaPerdidaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdemidiaperdidaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirRegrasDeMidiaPerdidaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaRegrasdemidiaperdidaAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarRegrasDeMidiaPerdidaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaTabelasdecobrancaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaTabelasdecobrancaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaTabelasdecobrancaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaTabelasdecobrancaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirTabelasDeCobrancaperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaTiposdedescontoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarTipoDeDescontoperfisdeacessodosistema")));
                _page.RetornarProdutosdeestadiaTiposdedescontoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarTipoDeDescontoperfisdeacessodosistema")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [CriarPerfilComAcessoARelatoriosPadraoPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfilcomacessoarelatoriospadraopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomePerfilDeAcessoRelatorios"));
            _page.MarcarRelatoriospadraoDocumentosfiscaisConsultar(Convert.ToBoolean(row.GetCell("consultarDocumentosFiscaisPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoEstadiasConsultar(Convert.ToBoolean(row.GetCell("consultarEstadiasPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoEventosdeestadiaConsultar(Convert.ToBoolean(row.GetCell("consultarEventosDeEstadiaPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoEventosdesistemaConsultar(Convert.ToBoolean(row.GetCell("consultarEventosDeSistemaPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoFechamentogeralConsultar(Convert.ToBoolean(row.GetCell("consultarFechamentoGeralPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoFluxoporperiodoConsultar(Convert.ToBoolean(row.GetCell("consultarFluxoPorPeriodoPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoIsencoesConsultar(Convert.ToBoolean(row.GetCell("consultarIsencoesPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoLogdeauditoriaConsultar(Convert.ToBoolean(row.GetCell("consultarLogDeAuditoriaPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoLognumerarioautoatendimentoConsultar(Convert.ToBoolean(row.GetCell("consultarLogNumerarioAutoatendimentoPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoPermanenciaConsultar(Convert.ToBoolean(row.GetCell("consultarPermanenciaPerfilDeAcessoRelatorios")));
            _page.MarcarRelatoriospadraoReceitatipodeprodutoestadiaConsultar(Convert.ToBoolean(row.GetCell("consultarReceitaTipoDeProdutoEstadiaPerfilDeAcessoRelatorios")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17271]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17271(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomePerfilDeAcessoRelatorios"));
                _page.RetornarRelatoriospadraoDocumentosfiscaisConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarDocumentosFiscaisPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoEstadiasConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEstadiasPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoEventosdeestadiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEventosDeEstadiaPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoEventosdesistemaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEventosDeSistemaPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoFechamentogeralConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarFechamentoGeralPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoFluxoporperiodoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarFluxoPorPeriodoPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoIsencoesConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarIsencoesPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoLogdeauditoriaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarLogDeAuditoriaPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoLognumerarioautoatendimentoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarLogNumerarioAutoatendimentoPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoPermanenciaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarPermanenciaPerfilDeAcessoRelatorios")));
                _page.RetornarRelatoriospadraoReceitatipodeprodutoestadiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarReceitaTipoDeProdutoEstadiaPerfilDeAcessoRelatorios")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [CriarPerfilDeAcessoSegurancaPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfildeacessosegurancapagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeperfisdeacessodosistema"));
            _page.MarcarSegurancaLicencasdeusoConsultar(Convert.ToBoolean(row.GetCell("consultarLicencasdeusoperfisdeacessodosistema")));
            _page.MarcarSegurancaLicencasdeusoIncluir(Convert.ToBoolean(row.GetCell("incluirLicencasdeusoperfisdeacessodosistema")));
            _page.MarcarSegurancaPerfisdeacessodosistemaConsultar(Convert.ToBoolean(row.GetCell("consultarPerfisdeacessodosistemaperfisdeacessodosistema")));
            _page.MarcarSegurancaPerfisdeacessodosistemaIncluir(Convert.ToBoolean(row.GetCell("incluirPerfisdeacessodosistemaperfisdeacessodosistema")));
            _page.MarcarSegurancaPerfisdeacessodosistemaAlterar(Convert.ToBoolean(row.GetCell("alterarPerfisdeacessodosistemaperfisdeacessodosistema")));
            _page.MarcarSegurancaPerfisdeacessodosistemaExcluir(Convert.ToBoolean(row.GetCell("excluirPerfisdeacessodosistemaperfisdeacessodosistema")));
            _page.MarcarSegurancaUsuariosdosistemaConsultar(Convert.ToBoolean(row.GetCell("consultarUsuariosdosistemaperfisdeacessodosistema")));
            _page.MarcarSegurancaUsuariosdosistemaIncluir(Convert.ToBoolean(row.GetCell("incluirUsuariosdosistemaperfisdeacessodosistema")));
            _page.MarcarSegurancaUsuariosdosistemaAlterar(Convert.ToBoolean(row.GetCell("alterarUsuariosdosistemaperfisdeacessodosistema")));
            _page.MarcarSegurancaUsuariosdosistemaExcluir(Convert.ToBoolean(row.GetCell("excluirUsuariosdosistemaperfisdeacessodosistema")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17272]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17272(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeperfisdeacessodosistema"));
                _page.RetornarSegurancaLicencasdeusoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarLicencasdeusoperfisdeacessodosistema")));
                _page.RetornarSegurancaLicencasdeusoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirLicencasdeusoperfisdeacessodosistema")));
                _page.RetornarSegurancaPerfisdeacessodosistemaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarPerfisdeacessodosistemaperfisdeacessodosistema")));
                _page.RetornarSegurancaPerfisdeacessodosistemaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirPerfisdeacessodosistemaperfisdeacessodosistema")));
                _page.RetornarSegurancaPerfisdeacessodosistemaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarPerfisdeacessodosistemaperfisdeacessodosistema")));
                _page.RetornarSegurancaPerfisdeacessodosistemaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirPerfisdeacessodosistemaperfisdeacessodosistema")));
                _page.RetornarSegurancaUsuariosdosistemaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarUsuariosdosistemaperfisdeacessodosistema")));
                _page.RetornarSegurancaUsuariosdosistemaIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirUsuariosdosistemaperfisdeacessodosistema")));
                _page.RetornarSegurancaUsuariosdosistemaAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarUsuariosdosistemaperfisdeacessodosistema")));
                _page.RetornarSegurancaUsuariosdosistemaExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirUsuariosdosistemaperfisdeacessodosistema")));
            }
        }


        [Step("Preencher os campos da tela <tabela> [CriarPerfilComAcessoARelatoriosCustomizadosStepByStepPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfilcomacessoarelatorioscustomizadosstepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeperfisdeacessodosistema"));
            _page.MarcarRelatorioscustomizadosComumConsultar(Convert.ToBoolean(row.GetCell("consultarperfisdeacessodosistema")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17273]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17273(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeperfisdeacessodosistema"));
                _page.RetornarRelatorioscustomizadosComumConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarperfisdeacessodosistema")));
            }
        }


        [Step("Preencher os campos da tela <tabela> [CriarPerfilComAcessoATodosAsFuncionalidadesStepByStepPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfilcomacessoatodosasfuncionalidadesstepbysteppagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomePerfilDeAcessoTodos"));
            _page.MarcarSeloDescontoConsumodeselodedesconto(Convert.ToBoolean(row.GetCell("consumoSeloDeDescontoPerfilDeAcessoTodos")));
            _page.MarcarSeloDescontoContratosdeintegracao(Convert.ToBoolean(row.GetCell("contratosDeIntegracaoPerfilDeAcessoTodos")));
            _page.MarcarSeloDescontoPedidosdeselosdedesconto(Convert.ToBoolean(row.GetCell("pedidosDeSeloDeDescontoPerfilDeAcessoTodos")));
            _page.MarcarSeloDescontoProdutosdeselosdedesconto(Convert.ToBoolean(row.GetCell("produtosDeSelosDeDescontoPerfilDeAcessoTodos")));
            _page.MarcarSeloDescontoSelosdedescontoconsumidos(Convert.ToBoolean(row.GetCell("selosDeDescontoConsumidosPerfilDeAcessoTodos")));
            _page.MarcarSeloDescontoEstoquedeselosdedesconto(Convert.ToBoolean(row.GetCell("estoqueDeSelosDeDescontoPerfilDeAcessoTodos")));
            _page.MarcarAtendimentoassistido(Convert.ToBoolean(row.GetCell("atendimentoAssistidoPerfilDeAcessoTodos")));
            _page.MarcarAtendimentoValet(Convert.ToBoolean(row.GetCell("atendimentoValetPerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoConfiguracoesdoestacionamentoBolsoesdevagas(Convert.ToBoolean(row.GetCell("bolsoesDeVagasPerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoArquivosseriaismifare(Convert.ToBoolean(row.GetCell("arquivosSeriaisMifarePerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoEquipamentos(Convert.ToBoolean(row.GetCell("equipamentosPerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoEstacionamentos(Convert.ToBoolean(row.GetCell("estacionamentosPerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoGruposdeequipamentos(Convert.ToBoolean(row.GetCell("gruposDeEquipamentosPerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao(Convert.ToBoolean(row.GetCell("integracaoComOperadoraDeArrecadacaoPerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento(Convert.ToBoolean(row.GetCell("parametrosGeraisDoEstacionamentoPerfilDeAcessoTodos")));
            _page.MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeBilhetesImpressosPerfilDeAcessoTodos")));
            _page.MarcarCustomizacaoMultimidiaConsultar(Convert.ToBoolean(row.GetCell("configuracaoDeMensagemDeAudioPerfilDeAcessoTodos")));
            _page.MarcarCustomizacaoApresentacaoMultimidia(Convert.ToBoolean(row.GetCell("configuracaoDaTelaDeVGAPerfilDeAcessoTodos")));
            _page.MarcarFinanceiroEmitentefiscal(Convert.ToBoolean(row.GetCell("emitenteFiscalPerfilDeAcessoTodos")));
            _page.MarcarFinanceiroConfiguracaodeintegracaoTEF(Convert.ToBoolean(row.GetCell("configuracaoDeIntegracaoTEFPerfilDeAcessoTodos")));
            _page.MarcarFinanceiroRegrasdeemissaoderecibos(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeRecibosPerfilDeAcessoTodos")));
            _page.MarcarFinanceiroRegrasdefechamentodosequipamentos(Convert.ToBoolean(row.GetCell("regrasDeFechamentoDosEquipamentosPerfilDeAcessoTodos")));
            _page.MarcarFinanceiroRegrasdenumerariodeautoatendimento(Convert.ToBoolean(row.GetCell("regrasDeNumerarioDeAutoatendimentoPerfilDeAcessoTodos")));
            _page.MarcarFinanceiroRegistroCambial(Convert.ToBoolean(row.GetCell("registroCambialPerfilDeAcessoTodos")));
            _page.MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos(Convert.ToBoolean(row.GetCell("agendamentoDeAtualizacaoDeAplicativosPerfilDeAcessoTodos")));
            _page.MarcarInstalacoeseatualizacoesAplicativoseversoes(Convert.ToBoolean(row.GetCell("aplicativosEVersoesPerfilDeAcessoTodos")));
            _page.MarcarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos(Convert.ToBoolean(row.GetCell("monitoramentoDeInstalacoesDeEquipamentoPerfilDeAcessoTodos")));
            _page.MarcarOperacaoAgendamentodetarefasautomatizadas(Convert.ToBoolean(row.GetCell("agendamentoDeTarefasAutomatizadasPerfilDeAcessoTodos")));
            _page.MarcarOperacaoConfiguracaodemododecontingencia(Convert.ToBoolean(row.GetCell("configuracoesDeModoDeContingenciaPerfilDeAcessoTodos")));
            _page.MarcarOperacaoAlteracaotemporariadotempodetolerancia(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodos")));
            _page.MarcarOperacaoCargaparavalidadormanualdeestadia(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodos")));
            _page.MarcarOperacaoClientesdoestacionamento(Convert.ToBoolean(row.GetCell("clientesDoEstacionamentoPerfilDeAcessoTodos")));
            _page.MarcarOperacaoContratosdeestadia(Convert.ToBoolean(row.GetCell("contratosDeEstadiaPerfilDeAcessoTodos")));
            _page.MarcarOperacaoControledeequipamentos(Convert.ToBoolean(row.GetCell("controleDeEquipamentosPerfilDeAcessoTodos")));
            _page.MarcarOperacaoEstadiasabertas(Convert.ToBoolean(row.GetCell("estadiasAbertasPerfilDeAcessoTodos")));
            _page.MarcarOperacaoRegrasdelimpezadepatioautomatica(Convert.ToBoolean(row.GetCell("regrasDeLimpezaDePatioAutomaticaPerfilDeAcessoTodos")));
            _page.MarcarOperacaoMidiasperdidaspreautorizadas(Convert.ToBoolean(row.GetCell("midiasPerdidasPreAutorizadasPerfilDeAcessoTodos")));
            _page.MarcarOperacaoOperacaodemultiplascancelas(Convert.ToBoolean(row.GetCell("operacaoDeMultiplasCancelasPerfilDeAcessoTodos")));
            _page.MarcarOperacaoTiposdeocorrenciasnasestadia(Convert.ToBoolean(row.GetCell("tiposDeOcorrenciasNasEstadiaPerfilDeAcessoTodos")));
            _page.MarcarOperacaoUsuariosnaoautorizados(Convert.ToBoolean(row.GetCell("usuariosNaoAutorizadosPerfilDeAcessoTodos")));
            _page.MarcarOperacaoCapturasLPR(Convert.ToBoolean(row.GetCell("capturasLPRPerfilDeAcessoTodos")));
            _page.MarcarOperacaoAnalisarmidiadeoperacao(Convert.ToBoolean(row.GetCell("analisarMidiaDeOperacaoPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaEstruturasdetabelasdecobranca(Convert.ToBoolean(row.GetCell("estruturasDeTabelasDeCobrancaPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaProdutosdeestadia(Convert.ToBoolean(row.GetCell("produtosDeEstadiaPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaRegrasdeacesso(Convert.ToBoolean(row.GetCell("regrasDeAcessoPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaRegrasdecobranca(Convert.ToBoolean(row.GetCell("regrasDeCobrancaPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaRegrasdeDescontos(Convert.ToBoolean(row.GetCell("regrasDeDescontosPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaRegrasdemidiaperdida(Convert.ToBoolean(row.GetCell("regrasDeMidiaPerdidaPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaTabelasdecobranca(Convert.ToBoolean(row.GetCell("tabelasDeCobrancaPerfilDeAcessoTodos")));
            _page.MarcarProdutosdeestadiaTiposdedesconto(Convert.ToBoolean(row.GetCell("tiposDeDescontoPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoDocumentosfiscais(Convert.ToBoolean(row.GetCell("documentosFiscaisPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoEstadias(Convert.ToBoolean(row.GetCell("estadiasPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoEventosdeestadia(Convert.ToBoolean(row.GetCell("eventosDeEstadiaPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoEventosdesistema(Convert.ToBoolean(row.GetCell("eventosDeSistemaPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoFechamentogeral(Convert.ToBoolean(row.GetCell("fechamentoGeralPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoFluxoporperiodo(Convert.ToBoolean(row.GetCell("fluxoPorPeriodoPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoIsencoes(Convert.ToBoolean(row.GetCell("isencoesPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoLogdeauditoria(Convert.ToBoolean(row.GetCell("logDeAuditoriaPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoLognumerarioautoatendimento(Convert.ToBoolean(row.GetCell("logNumerarioAutoatendimentoPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoPermanencia(Convert.ToBoolean(row.GetCell("permanenciaPerfilDeAcessoTodos")));
            _page.MarcarRelatoriospadraoReceitatipodeprodutoestadia(Convert.ToBoolean(row.GetCell("receitaTipoDeProdutoEstadiaPerfilDeAcessoTodos")));
            _page.MarcarSegurancaLicencasdeuso(Convert.ToBoolean(row.GetCell("licencasDeUsoPerfilDeAcessoTodos")));
            _page.MarcarSegurancaPerfisdeacessodosistema(Convert.ToBoolean(row.GetCell("perfisDeAcessoDoSistemaPerfilDeAcessoTodos")));
            _page.MarcarSegurancaUsuariosdosistema(Convert.ToBoolean(row.GetCell("usuariosDoSistemaPerfilDeAcessoTodos")));
            _page.MarcarRelatorioscustomizadosComum(Convert.ToBoolean(row.GetCell("comumPerfilDeAcessoTodos")));
            _page.MarcarLocadoraContratoLocadora(Convert.ToBoolean(row.GetCell("contratoLocadoraPerfilDeAcessoTodos")));
            _page.MarcarLocadoraFechamentoFaturaLocadora(Convert.ToBoolean(row.GetCell("fechamentoFaturaLocadoraPerfilDeAcessoTodos")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17274]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17274(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomePerfilDeAcessoTodos"));
                _page.RetornarSeloDescontoConsumodeselodedesconto().Should().Be(Convert.ToBoolean(row.GetCell("consumoSeloDeDescontoPerfilDeAcessoTodos")));
                _page.RetornarSeloDescontoContratosdeintegracao().Should().Be(Convert.ToBoolean(row.GetCell("contratosDeIntegracaoPerfilDeAcessoTodos")));
                _page.RetornarSeloDescontoPedidosdeselosdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("pedidosDeSeloSeDescontoPerfilDeAcessoTodos")));
                _page.RetornarSeloDescontoProdutosdeselosdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("produtosDeSelosDeDescontoPerfilDeAcessoTodos")));
                _page.RetornarSeloDescontoSelosdedescontoconsumidos().Should().Be(Convert.ToBoolean(row.GetCell("selosDeDescontoConsumidosPerfilDeAcessoTodos")));
                _page.RetornarSeloDescontoEstoquedeselosdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("estoqueDeSelosSeDescontoPerfilDeAcessoTodos")));
                _page.RetornarAtendimentoassistido().Should().Be(Convert.ToBoolean(row.GetCell("atendimentoAssistidoPerfilDeAcessoTodos")));
                _page.RetornarAtendimentoValet().Should().Be(Convert.ToBoolean(row.GetCell("atendimentoValetPerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoConfiguracoesdoestacionamentoBolsoesdevagas().Should().Be(Convert.ToBoolean(row.GetCell("bolsoesDeVagasPerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoArquivosseriaismifare().Should().Be(Convert.ToBoolean(row.GetCell("arquivosSeriaisMifarePerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoEquipamentos().Should().Be(Convert.ToBoolean(row.GetCell("equipamentosPerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoEstacionamentos().Should().Be(Convert.ToBoolean(row.GetCell("estacionamentosPerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoGruposdeequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("gruposDeEquipamentosPerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("integracaoComOperadoraDeArrecadacaoPerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento().Should().Be(Convert.ToBoolean(row.GetCell("parametrosGeraisDoEstacionamentoPerfilDeAcessoTodos")));
                _page.RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeBilhetesImpressosPerfilDeAcessoTodos")));
                _page.RetornarCustomizacaoMultimidiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("configuracaoDeMensagemDeAudioPerfilDeAcessoTodos")));
                _page.RetornarCustomizacaoApresentacaoMultimidia().Should().Be(Convert.ToBoolean(row.GetCell("configuracaoDaTelaDeVGAPerfilDeAcessoTodos")));
                _page.RetornarFinanceiroEmitentefiscal().Should().Be(Convert.ToBoolean(row.GetCell("emitenteFiscalPerfilDeAcessoTodos")));
                _page.RetornarFinanceiroConfiguracaodeintegracaoTEF().Should().Be(Convert.ToBoolean(row.GetCell("configuracaoDeIntegracaoTEFPerfilDeAcessoTodos")));
                _page.RetornarFinanceiroRegrasdeemissaoderecibos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeRecibosPerfilDeAcessoTodos")));
                _page.RetornarFinanceiroRegrasdefechamentodosequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeFechamentoDosEquipamentosPerfilDeAcessoTodos")));
                _page.RetornarFinanceiroRegrasdenumerariodeautoatendimento().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeNumerarioDeAutoatendimentoPerfilDeAcessoTodos")));
                _page.RetornarFinanceiroRegistroCambial().Should().Be(Convert.ToBoolean(row.GetCell("registroCambialPerfilDeAcessoTodos")));
                _page.RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos().Should().Be(Convert.ToBoolean(row.GetCell("agendamentoDeAtualizacaoDeAplicativosPerfilDeAcessoTodos")));
                _page.RetornarInstalacoeseatualizacoesAplicativoseversoes().Should().Be(Convert.ToBoolean(row.GetCell("aplicativosEVersoesPerfilDeAcessoTodos")));
                _page.RetornarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("monitoramentoDeInstalacoesDeEquipamentoPerfilDeAcessoTodos")));
                _page.RetornarOperacaoAgendamentodetarefasautomatizadas().Should().Be(Convert.ToBoolean(row.GetCell("agendamentoDeTarefasAutomatizadasPerfilDeAcessoTodos")));
                _page.RetornarOperacaoConfiguracaodemododecontingencia().Should().Be(Convert.ToBoolean(row.GetCell("configuracoesDeModoDeContingenciaPerfilDeAcessoTodos")));
                _page.RetornarOperacaoAlteracaotemporariadotempodetolerancia().Should().Be(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodos")));
                _page.RetornarOperacaoCargaparavalidadormanualdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodos")));
                _page.RetornarOperacaoClientesdoestacionamento().Should().Be(Convert.ToBoolean(row.GetCell("clientesDoEstacionamentoPerfilDeAcessoTodos")));
                _page.RetornarOperacaoContratosdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("contratosDeEstadiaPerfilDeAcessoTodos")));
                _page.RetornarOperacaoControledeequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("controleDeEquipamentosPerfilDeAcessoTodos")));
                _page.RetornarOperacaoEstadiasabertas().Should().Be(Convert.ToBoolean(row.GetCell("estadiasAbertasPerfilDeAcessoTodos")));
                _page.RetornarOperacaoRegrasdelimpezadepatioautomatica().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeLimpezaDePatioAutomaticaPerfilDeAcessoTodos")));
                _page.RetornarOperacaoMidiasperdidaspreautorizadas().Should().Be(Convert.ToBoolean(row.GetCell("midiasPerdidasPreAutorizadasPerfilDeAcessoTodos")));
                _page.RetornarOperacaoOperacaodemultiplascancelas().Should().Be(Convert.ToBoolean(row.GetCell("operacaoDeMultiplasCancelasPerfilDeAcessoTodos")));
                _page.RetornarOperacaoTiposdeocorrenciasnasestadia().Should().Be(Convert.ToBoolean(row.GetCell("tiposDeOcorrenciasNasEstadiaPerfilDeAcessoTodos")));
                _page.RetornarOperacaoUsuariosnaoautorizados().Should().Be(Convert.ToBoolean(row.GetCell("usuariosNaoAutorizadosPerfilDeAcessoTodos")));
                _page.RetornarOperacaoCapturasLPR().Should().Be(Convert.ToBoolean(row.GetCell("capturasLPRPerfilDeAcessoTodos")));
                _page.RetornarOperacaoAnalisarmidiadeoperacao().Should().Be(Convert.ToBoolean(row.GetCell("analisarMidiaDeOperacaoPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaEstruturasdetabelasdecobranca().Should().Be(Convert.ToBoolean(row.GetCell("estruturasDeTabelasDeCobrancaPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaProdutosdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("produtosDeEstadiaPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaRegrasdeacesso().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeAcessoPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaRegrasdecobranca().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeCobrancaPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaRegrasdeDescontos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeDescontosPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaRegrasdemidiaperdida().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeMidiaPerdidaPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaTabelasdecobranca().Should().Be(Convert.ToBoolean(row.GetCell("tabelasDeCobrancaPerfilDeAcessoTodos")));
                _page.RetornarProdutosdeestadiaTiposdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("tiposDeDescontoPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoDocumentosfiscais().Should().Be(Convert.ToBoolean(row.GetCell("documentosFiscaisPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoEstadias().Should().Be(Convert.ToBoolean(row.GetCell("estadiasPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoEventosdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("eventosDeEstadiaPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoEventosdesistema().Should().Be(Convert.ToBoolean(row.GetCell("eventosDeSistemaPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoFechamentogeral().Should().Be(Convert.ToBoolean(row.GetCell("fechamentoGeralPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoFluxoporperiodo().Should().Be(Convert.ToBoolean(row.GetCell("fluxoPorPeriodoPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoIsencoes().Should().Be(Convert.ToBoolean(row.GetCell("isencoesPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoLogdeauditoria().Should().Be(Convert.ToBoolean(row.GetCell("logDeAuditoriaPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoLognumerarioautoatendimento().Should().Be(Convert.ToBoolean(row.GetCell("logNumerarioAutoatendimentoPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoPermanencia().Should().Be(Convert.ToBoolean(row.GetCell("permanenciaPerfilDeAcessoTodos")));
                _page.RetornarRelatoriospadraoReceitatipodeprodutoestadia().Should().Be(Convert.ToBoolean(row.GetCell("receitaTipoDeProdutoEstadiaPerfilDeAcessoTodos")));
                _page.RetornarSegurancaLicencasdeuso().Should().Be(Convert.ToBoolean(row.GetCell("licencasDeUsoPerfilDeAcessoTodos")));
                _page.RetornarSegurancaPerfisdeacessodosistema().Should().Be(Convert.ToBoolean(row.GetCell("perfisDeAcessoDoSistemaPerfilDeAcessoTodos")));
                _page.RetornarSegurancaUsuariosdosistema().Should().Be(Convert.ToBoolean(row.GetCell("usuariosDoSistemaPerfilDeAcessoTodos")));
                _page.RetornarRelatorioscustomizadosComum().Should().Be(Convert.ToBoolean(row.GetCell("comumPerfilDeAcessoTodos")));
                _page.RetornarLocadoraContratoLocadora().Should().Be(Convert.ToBoolean(row.GetCell("contratoLocadoraPerfilDeAcessoTodos")));
                _page.RetornarLocadoraFechamentoFaturaLocadora().Should().Be(Convert.ToBoolean(row.GetCell("fechamentoFaturaLocadoraPerfilDeAcessoTodos")));
            }

        }

        [Step("Preencher os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17275]")]
        public void PreencherOsCamposDaTelaPerfildeacessodosistemapagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomePerfilDeAcessoTodosalterar"));
            _page.MarcarSeloDescontoConsumodeselodedesconto(Convert.ToBoolean(row.GetCell("consumoSeloDeDescontoPerfilDeAcessoTodosalterar")));
            _page.MarcarSeloDescontoContratosdeintegracao(Convert.ToBoolean(row.GetCell("contratosDeIntegracaoPerfilDeAcessoTodosalterar")));
            _page.MarcarSeloDescontoPedidosdeselosdedesconto(Convert.ToBoolean(row.GetCell("pedidosDeSeloDeDescontoPerfilDeAcessoTodosalterar")));
            _page.MarcarSeloDescontoProdutosdeselosdedesconto(Convert.ToBoolean(row.GetCell("produtosDeSelosDeDescontoPerfilDeAcessoTodosalterar")));
            _page.MarcarSeloDescontoSelosdedescontoconsumidos(Convert.ToBoolean(row.GetCell("selosDeDescontoConsumidosPerfilDeAcessoTodosalterar")));
            _page.MarcarSeloDescontoEstoquedeselosdedesconto(Convert.ToBoolean(row.GetCell("estoqueDeSelosDeDescontoPerfilDeAcessoTodosalterar")));
            _page.MarcarAtendimentoassistido(Convert.ToBoolean(row.GetCell("atendimentoAssistidoPerfilDeAcessoTodosalterar")));
            _page.MarcarAtendimentoValet(Convert.ToBoolean(row.GetCell("atendimentoValetPerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoConfiguracoesdoestacionamentoBolsoesdevagas(Convert.ToBoolean(row.GetCell("bolsoesDeVagasPerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoArquivosseriaismifare(Convert.ToBoolean(row.GetCell("arquivosSeriaisMifarePerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoEquipamentos(Convert.ToBoolean(row.GetCell("equipamentosPerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoEstacionamentos(Convert.ToBoolean(row.GetCell("estacionamentosPerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoGruposdeequipamentos(Convert.ToBoolean(row.GetCell("gruposDeEquipamentosPerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao(Convert.ToBoolean(row.GetCell("integracaoComOperadoraDeArrecadacaoPerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento(Convert.ToBoolean(row.GetCell("parametrosGeraisDoEstacionamentoPerfilDeAcessoTodosalterar")));
            _page.MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeBilhetesImpressosPerfilDeAcessoTodosalterar")));
            _page.MarcarCustomizacaoMultimidiaConsultar(Convert.ToBoolean(row.GetCell("configuracaoDeMensagemDeAudioPerfilDeAcessoTodosalterar")));
            _page.MarcarCustomizacaoApresentacaoMultimidia(Convert.ToBoolean(row.GetCell("configuracaoDaTelaDeVGAPerfilDeAcessoTodosalterar")));
            _page.MarcarFinanceiroEmitentefiscal(Convert.ToBoolean(row.GetCell("emitenteFiscalPerfilDeAcessoTodosalterar")));
            _page.MarcarFinanceiroConfiguracaodeintegracaoTEF(Convert.ToBoolean(row.GetCell("configuracaoDeIntegracaoTEFPerfilDeAcessoTodosalterar")));
            _page.MarcarFinanceiroRegrasdeemissaoderecibos(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeRecibosPerfilDeAcessoTodosalterar")));
            _page.MarcarFinanceiroRegrasdefechamentodosequipamentos(Convert.ToBoolean(row.GetCell("regrasDeFechamentoDosEquipamentosPerfilDeAcessoTodosalterar")));
            _page.MarcarFinanceiroRegrasdenumerariodeautoatendimento(Convert.ToBoolean(row.GetCell("regrasDeNumerarioDeAutoatendimentoPerfilDeAcessoTodosalterar")));
            _page.MarcarFinanceiroRegistroCambial(Convert.ToBoolean(row.GetCell("registroCambialPerfilDeAcessoTodosalterar")));
            _page.MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos(Convert.ToBoolean(row.GetCell("agendamentoDeAtualizacaoDeAplicativosPerfilDeAcessoTodosalterar")));
            _page.MarcarInstalacoeseatualizacoesAplicativoseversoes(Convert.ToBoolean(row.GetCell("aplicativosEVersoesPerfilDeAcessoTodosalterar")));
            _page.MarcarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos(Convert.ToBoolean(row.GetCell("monitoramentoDeInstalacoesDeEquipamentoPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoAgendamentodetarefasautomatizadas(Convert.ToBoolean(row.GetCell("agendamentoDeTarefasAutomatizadasPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoConfiguracaodemododecontingencia(Convert.ToBoolean(row.GetCell("configuracoesDeModoDeContingenciaPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoAlteracaotemporariadotempodetolerancia(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoCargaparavalidadormanualdeestadia(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoClientesdoestacionamento(Convert.ToBoolean(row.GetCell("clientesDoEstacionamentoPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoContratosdeestadia(Convert.ToBoolean(row.GetCell("contratosDeEstadiaPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoControledeequipamentos(Convert.ToBoolean(row.GetCell("controleDeEquipamentosPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoEstadiasabertas(Convert.ToBoolean(row.GetCell("estadiasAbertasPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoRegrasdelimpezadepatioautomatica(Convert.ToBoolean(row.GetCell("regrasDeLimpezaDePatioAutomaticaPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoMidiasperdidaspreautorizadas(Convert.ToBoolean(row.GetCell("midiasPerdidasPreAutorizadasPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoOperacaodemultiplascancelas(Convert.ToBoolean(row.GetCell("operacaoDeMultiplasCancelasPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoTiposdeocorrenciasnasestadia(Convert.ToBoolean(row.GetCell("tiposDeOcorrenciasNasEstadiaPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoUsuariosnaoautorizados(Convert.ToBoolean(row.GetCell("usuariosNaoAutorizadosPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoCapturasLPR(Convert.ToBoolean(row.GetCell("capturasLPRPerfilDeAcessoTodosalterar")));
            _page.MarcarOperacaoAnalisarmidiadeoperacao(Convert.ToBoolean(row.GetCell("analisarMidiaDeOperacaoPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaEstruturasdetabelasdecobranca(Convert.ToBoolean(row.GetCell("estruturasDeTabelasDeCobrancaPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaProdutosdeestadia(Convert.ToBoolean(row.GetCell("produtosDeEstadiaPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaRegrasdeacesso(Convert.ToBoolean(row.GetCell("regrasDeAcessoPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaRegrasdecobranca(Convert.ToBoolean(row.GetCell("regrasDeCobrancaPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaRegrasdeDescontos(Convert.ToBoolean(row.GetCell("regrasDeDescontosPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaRegrasdemidiaperdida(Convert.ToBoolean(row.GetCell("regrasDeMidiaPerdidaPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaTabelasdecobranca(Convert.ToBoolean(row.GetCell("tabelasDeCobrancaPerfilDeAcessoTodosalterar")));
            _page.MarcarProdutosdeestadiaTiposdedesconto(Convert.ToBoolean(row.GetCell("tiposDeDescontoPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoDocumentosfiscais(Convert.ToBoolean(row.GetCell("documentosFiscaisPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoEstadias(Convert.ToBoolean(row.GetCell("estadiasPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoEventosdeestadia(Convert.ToBoolean(row.GetCell("eventosDeEstadiaPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoEventosdesistema(Convert.ToBoolean(row.GetCell("eventosDeSistemaPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoFechamentogeral(Convert.ToBoolean(row.GetCell("fechamentoGeralPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoFluxoporperiodo(Convert.ToBoolean(row.GetCell("fluxoPorPeriodoPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoIsencoes(Convert.ToBoolean(row.GetCell("isencoesPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoLogdeauditoria(Convert.ToBoolean(row.GetCell("logDeAuditoriaPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoLognumerarioautoatendimento(Convert.ToBoolean(row.GetCell("logNumerarioAutoatendimentoPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoPermanencia(Convert.ToBoolean(row.GetCell("permanenciaPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatoriospadraoReceitatipodeprodutoestadia(Convert.ToBoolean(row.GetCell("receitaTipoDeProdutoEstadiaPerfilDeAcessoTodosalterar")));
            _page.MarcarSegurancaLicencasdeuso(Convert.ToBoolean(row.GetCell("licencasDeUsoPerfilDeAcessoTodosalterar")));
            _page.MarcarSegurancaPerfisdeacessodosistema(Convert.ToBoolean(row.GetCell("perfisDeAcessoDoSistemaPerfilDeAcessoTodosalterar")));
            _page.MarcarSegurancaUsuariosdosistema(Convert.ToBoolean(row.GetCell("usuariosDoSistemaPerfilDeAcessoTodosalterar")));
            _page.MarcarRelatorioscustomizadosComum(Convert.ToBoolean(row.GetCell("comumPerfilDeAcessoTodosalterar")));
            _page.MarcarLocadoraContratoLocadora(Convert.ToBoolean(row.GetCell("contratoLocadoraPerfilDeAcessoTodosAlterar")));
            _page.MarcarLocadoraFechamentoFaturaLocadora(Convert.ToBoolean(row.GetCell("fechamentoFaturaLocadoraPerfilDeAcessoTodosAlterar")));
        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17275]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17275(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomePerfilDeAcessoTodosalterar"));
                _page.RetornarSeloDescontoConsumodeselodedesconto().Should().Be(Convert.ToBoolean(row.GetCell("consumoSeloDeDescontoPerfilDeAcessoTodosalterar")));
                _page.RetornarSeloDescontoContratosdeintegracao().Should().Be(Convert.ToBoolean(row.GetCell("contratosDeIntegracaoPerfilDeAcessoTodosalterar")));
                _page.RetornarSeloDescontoPedidosdeselosdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("pedidosDeSeloDeDescontoPerfilDeAcessoTodosalterar")));
                _page.RetornarSeloDescontoProdutosdeselosdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("produtosDeSelosDeDescontoPerfilDeAcessoTodosalterar")));
                _page.RetornarSeloDescontoSelosdedescontoconsumidos().Should().Be(Convert.ToBoolean(row.GetCell("selosDeDescontoConsumidosPerfilDeAcessoTodosalterar")));
                _page.RetornarSeloDescontoEstoquedeselosdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("estoqueDeSelosDeDescontoPerfilDeAcessoTodosalterar")));
                _page.RetornarAtendimentoassistido().Should().Be(Convert.ToBoolean(row.GetCell("atendimentoAssistidoPerfilDeAcessoTodosalterar")));
                _page.RetornarAtendimentoValet().Should().Be(Convert.ToBoolean(row.GetCell("atendimentoAssistidoPerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoConfiguracoesdoestacionamentoBolsoesdevagas().Should().Be(Convert.ToBoolean(row.GetCell("bolsoesDeVagasPerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoArquivosseriaismifare().Should().Be(Convert.ToBoolean(row.GetCell("arquivosSeriaisMifarePerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoEquipamentos().Should().Be(Convert.ToBoolean(row.GetCell("equipamentosPerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoEstacionamentos().Should().Be(Convert.ToBoolean(row.GetCell("estacionamentosPerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoGruposdeequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("gruposDeEquipamentosPerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao().Should().Be(Convert.ToBoolean(row.GetCell("integracaoComOperadoraDeArrecadacaoPerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento().Should().Be(Convert.ToBoolean(row.GetCell("parametrosGeraisDoEstacionamentoPerfilDeAcessoTodosalterar")));
                _page.RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeBilhetesImpressosPerfilDeAcessoTodosalterar")));
                _page.RetornarCustomizacaoMultimidiaConsultar().Should().Be(Convert.ToBoolean(row.GetCell("configuracaoDeMensagemDeAudioPerfilDeAcessoTodosalterar")));
                _page.RetornarCustomizacaoApresentacaoMultimidia().Should().Be(Convert.ToBoolean(row.GetCell("configuracaoDaTelaDeVGAPerfilDeAcessoTodosalterar")));
                _page.RetornarFinanceiroEmitentefiscal().Should().Be(Convert.ToBoolean(row.GetCell("emitenteFiscalPerfilDeAcessoTodosalterar")));
                _page.RetornarFinanceiroConfiguracaodeintegracaoTEF().Should().Be(Convert.ToBoolean(row.GetCell("configuracaoDeIntegracaoTEFPerfilDeAcessoTodosalterar")));
                _page.RetornarFinanceiroRegrasdeemissaoderecibos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeEmissaoDeRecibosPerfilDeAcessoTodosalterar")));
                _page.RetornarFinanceiroRegrasdefechamentodosequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeFechamentoDosEquipamentosPerfilDeAcessoTodosalterar")));
                _page.RetornarFinanceiroRegistroCambial().Should().Be(Convert.ToBoolean(row.GetCell("registroCambialPerfilDeAcessoTodosalterar")));
                _page.RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos().Should().Be(Convert.ToBoolean(row.GetCell("agendamentoDeAtualizacaoDeAplicativosPerfilDeAcessoTodosalterar")));
                _page.RetornarInstalacoeseatualizacoesAplicativoseversoes().Should().Be(Convert.ToBoolean(row.GetCell("aplicativosEVersoesPerfilDeAcessoTodosalterar")));
                _page.RetornarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("monitoramentoDeInstalacoesDeEquipamentoPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoAgendamentodetarefasautomatizadas().Should().Be(Convert.ToBoolean(row.GetCell("agendamentoDeTarefasAutomatizadasPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoConfiguracaodemododecontingencia().Should().Be(Convert.ToBoolean(row.GetCell("configuracoesDeModoDeContingenciaPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoAlteracaotemporariadotempodetolerancia().Should().Be(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoCargaparavalidadormanualdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("alteracaoTemporariaDoTempoDeToleranciaPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoClientesdoestacionamento().Should().Be(Convert.ToBoolean(row.GetCell("clientesDoEstacionamentoPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoContratosdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("contratosDeEstadiaPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoControledeequipamentos().Should().Be(Convert.ToBoolean(row.GetCell("controleDeEquipamentosPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoEstadiasabertas().Should().Be(Convert.ToBoolean(row.GetCell("estadiasAbertasPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoRegrasdelimpezadepatioautomatica().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeLimpezaDePatioAutomaticaPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoMidiasperdidaspreautorizadas().Should().Be(Convert.ToBoolean(row.GetCell("midiasPerdidasPreAutorizadasPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoOperacaodemultiplascancelas().Should().Be(Convert.ToBoolean(row.GetCell("operacaoDeMultiplasCancelasPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoTiposdeocorrenciasnasestadia().Should().Be(Convert.ToBoolean(row.GetCell("tiposDeOcorrenciasNasEstadiaPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoUsuariosnaoautorizados().Should().Be(Convert.ToBoolean(row.GetCell("usuariosNaoAutorizadosPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoCapturasLPR().Should().Be(Convert.ToBoolean(row.GetCell("capturasLPRPerfilDeAcessoTodosalterar")));
                _page.RetornarOperacaoAnalisarmidiadeoperacao().Should().Be(Convert.ToBoolean(row.GetCell("analisarMidiaDeOperacaoPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaEstruturasdetabelasdecobranca().Should().Be(Convert.ToBoolean(row.GetCell("estruturasDeTabelasDeCobrancaPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaProdutosdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("produtosDeEstadiaPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaRegrasdeacesso().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeAcessoPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaRegrasdecobranca().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeCobrancaPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaRegrasdeDescontos().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeDescontosPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaRegrasdemidiaperdida().Should().Be(Convert.ToBoolean(row.GetCell("regrasDeMidiaPerdidaPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaTabelasdecobranca().Should().Be(Convert.ToBoolean(row.GetCell("tabelasDeCobrancaPerfilDeAcessoTodosalterar")));
                _page.RetornarProdutosdeestadiaTiposdedesconto().Should().Be(Convert.ToBoolean(row.GetCell("tiposDeDescontoPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoDocumentosfiscais().Should().Be(Convert.ToBoolean(row.GetCell("documentosFiscaisPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoEstadias().Should().Be(Convert.ToBoolean(row.GetCell("estadiasPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoEventosdeestadia().Should().Be(Convert.ToBoolean(row.GetCell("eventosDeEstadiaPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoEventosdesistema().Should().Be(Convert.ToBoolean(row.GetCell("eventosDeSistemaPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoFechamentogeral().Should().Be(Convert.ToBoolean(row.GetCell("fechamentoGeralPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoFluxoporperiodo().Should().Be(Convert.ToBoolean(row.GetCell("fluxoPorPeriodoPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoIsencoes().Should().Be(Convert.ToBoolean(row.GetCell("isencoesPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoLogdeauditoria().Should().Be(Convert.ToBoolean(row.GetCell("logDeAuditoriaPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoLognumerarioautoatendimento().Should().Be(Convert.ToBoolean(row.GetCell("logNumerarioAutoatendimentoPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoPermanencia().Should().Be(Convert.ToBoolean(row.GetCell("permanenciaPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatoriospadraoReceitatipodeprodutoestadia().Should().Be(Convert.ToBoolean(row.GetCell("receitaTipoDeProdutoEstadiaPerfilDeAcessoTodosalterar")));
                _page.RetornarSegurancaLicencasdeuso().Should().Be(Convert.ToBoolean(row.GetCell("licencasDeUsoPerfilDeAcessoTodosalterar")));
                _page.RetornarSegurancaPerfisdeacessodosistema().Should().Be(Convert.ToBoolean(row.GetCell("perfisDeAcessoDoSistemaPerfilDeAcessoTodosalterar")));
                _page.RetornarSegurancaUsuariosdosistema().Should().Be(Convert.ToBoolean(row.GetCell("usuariosDoSistemaPerfilDeAcessoTodosalterar")));
                _page.RetornarRelatorioscustomizadosComum().Should().Be(Convert.ToBoolean(row.GetCell("comumPerfilDeAcessoTodosalterar")));
                _page.RetornarLocadoraContratoLocadora().Should().Be(Convert.ToBoolean(row.GetCell("contratoLocadoraPerfilDeAcessoTodosAlterar")));
                _page.RetornarLocadoraFechamentoFaturaLocadora().Should().Be(Convert.ToBoolean(row.GetCell("fechamentoFaturaLocadoraPerfilDeAcessoTodosAlterar")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [CriarPerfilDeAcessoAtendimentoAssistidoPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfildeacessoatendimentoassistidopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomeperfisdeacessodosistema"));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoInicio(Convert.ToBoolean(row.GetCell("inicioperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoAbrirestadia(Convert.ToBoolean(row.GetCell("abrirestadiaperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoFecharestadia(Convert.ToBoolean(row.GetCell("fecharestadiaperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoPassagemestadia(Convert.ToBoolean(row.GetCell("passagemestadiaperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoValidarestadia(Convert.ToBoolean(row.GetCell("validarestadiaperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoTransferirestadia(Convert.ToBoolean(row.GetCell("transferirestadiaperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoAditarcontrato(Convert.ToBoolean(row.GetCell("aditarcontratoperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoTratarmidiaperdida(Convert.ToBoolean(row.GetCell("tratarmidia")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoChamarveiculo(Convert.ToBoolean(row.GetCell("chamarveiculoperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoDevolverveiculo(Convert.ToBoolean(row.GetCell("devolverveiculoperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoDeixarVeiculo(Convert.ToBoolean(row.GetCell("deixarVeiculoperfisdeacessodosistema")));
            _page.MarcarAtendimentoassistidoAtendimentoassistidoMarcarVeiculoComoPronto(Convert.ToBoolean(row.GetCell("marcarVeiculoComoProntoperfisdeacessodosistema")));

        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17146]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17146(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomeperfisdeacessodosistema"));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoInicio().Should().Be(Convert.ToBoolean(row.GetCell("inicioperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoAbrirestadia().Should().Be(Convert.ToBoolean(row.GetCell("abrirestadiaperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoFecharestadia().Should().Be(Convert.ToBoolean(row.GetCell("fecharestadiaperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoPassagemestadia().Should().Be(Convert.ToBoolean(row.GetCell("passagemestadiaperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoValidarestadia().Should().Be(Convert.ToBoolean(row.GetCell("validarestadiaperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoTransferirestadia().Should().Be(Convert.ToBoolean(row.GetCell("transferirestadiaperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoAditarcontrato().Should().Be(Convert.ToBoolean(row.GetCell("aditarcontratoperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoTratarmidiaperdida().Should().Be(Convert.ToBoolean(row.GetCell("tratarmidia")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoChamarveiculo().Should().Be(Convert.ToBoolean(row.GetCell("chamarveiculoperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoDevolverveiculo().Should().Be(Convert.ToBoolean(row.GetCell("devolverveiculoperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoDeixarVeiculo().Should().Be(Convert.ToBoolean(row.GetCell("deixarVeiculoperfisdeacessodosistema")));
                _page.RetornarAtendimentoassistidoAtendimentoassistidoMarcarVeiculoComoPronto().Should().Be(Convert.ToBoolean(row.GetCell("marcarVeiculoComoProntoperfisdeacessodosistema")));
            }
        }


        [Step("Preencher os campos da tela <tabela> [CriarPerfilComAcessoASeloDeDescontoPageStep]")]
        public void PreencherOsCamposDaTelaCriarperfilcomacessoaselodedescontopagestep(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNome(row.GetCell("nomePerfilDeAcessoSelo"));
            _page.MarcarSeloDescontoConsumodeselodedescontoValidarestadia(Convert.ToBoolean(row.GetCell("validarEstadiaConsumoSeloPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoConsumodeselodedescontoConsultar(Convert.ToBoolean(row.GetCell("consultarConsumoSeloPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoConsumodeselodedescontoAplicar(Convert.ToBoolean(row.GetCell("aplicarConsumoSeloPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoContratosdeintegracaoConsultar(Convert.ToBoolean(row.GetCell("consultarContratosIntegracaoPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoContratosdeintegracaoExcluir(Convert.ToBoolean(row.GetCell("excluirContratosIntegracaoPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoContratosdeintegracaoIncluir(Convert.ToBoolean(row.GetCell("incluirContratosIntegracaoPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoContratosdeintegracaoAlterar(Convert.ToBoolean(row.GetCell("alterarContratosIntegracaoPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoPedidosdeselosdedescontoConsultar(Convert.ToBoolean(row.GetCell("consultarPedidosDeSelosPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoPedidosdeselosdedescontoImprimir(Convert.ToBoolean(row.GetCell("imprimirPedidosDeSelosPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoPedidosdeselosdedescontoIncluir(Convert.ToBoolean(row.GetCell("incluirPedidosDeSelosPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoPedidosdeselosdedescontoAlterar(Convert.ToBoolean(row.GetCell("alterarPedidosDeSelosPerfilDeAcessoSelo")));
            _page.MarcarSeloDescontoProdutosdeselosdedescontoConsultar(Convert.ToBoolean(row.GetCell("consultarProdutosDeSelosPerfilDeAcessoSelos")));
            _page.MarcarSeloDescontoProdutosdeselosdedescontoExcluir(Convert.ToBoolean(row.GetCell("excluirProdutosDeSelosPerfilDeAcessoSelos")));
            _page.MarcarSeloDescontoProdutosdeselosdedescontoIncluir(Convert.ToBoolean(row.GetCell("incluirProdutosDeSelosPerfilDeAcessoSelos")));
            _page.MarcarSeloDescontoProdutosdeselosdedescontoAlterar(Convert.ToBoolean(row.GetCell("alterarProdutosDeSelosPerfilDeAcessoSelos")));
            _page.MarcarSeloDescontoSelosdedescontoconsumidosConsultar(Convert.ToBoolean(row.GetCell("consultarDescontoConsumidosPerfilDeAcessoSelos")));
            _page.MarcarSeloDescontoEstoquedeselosdedescontoConsultar(Convert.ToBoolean(row.GetCell("consultarEstoqueDeSelosPerfilDeAcessoSelos")));
        }

        [Step("Verificar os campos da tela <tabela> [PerfilDeAcessoDoSistemaPageStep] [17147]")]
        public void VerificarOsCamposDaTelaPerfildeacessodosistemapagestep17147(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNome().Should().Be(row.GetCell("nomePerfilDeAcessoSelo"));
                _page.RetornarSeloDescontoConsumodeselodedescontoValidarestadia().Should().Be(Convert.ToBoolean(row.GetCell("validarEstadiaConsumoSeloPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoConsumodeselodedescontoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarConsumoSeloPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoConsumodeselodedescontoAplicar().Should().Be(Convert.ToBoolean(row.GetCell("aplicarConsumoSeloPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoContratosdeintegracaoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarContratosIntegracaoPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoContratosdeintegracaoExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirContratosIntegracaoPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoContratosdeintegracaoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirContratosIntegracaoPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoContratosdeintegracaoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarContratosIntegracaoPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoPedidosdeselosdedescontoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarPedidosDeSelosPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoPedidosdeselosdedescontoImprimir().Should().Be(Convert.ToBoolean(row.GetCell("imprimirPedidosDeSelosPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoPedidosdeselosdedescontoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirPedidosDeSelosPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoPedidosdeselosdedescontoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarPedidosDeSelosPerfilDeAcessoSelo")));
                _page.RetornarSeloDescontoProdutosdeselosdedescontoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarProdutosDeSelosPerfilDeAcessoSelos")));
                _page.RetornarSeloDescontoProdutosdeselosdedescontoExcluir().Should().Be(Convert.ToBoolean(row.GetCell("excluirProdutosDeSelosPerfilDeAcessoSelos")));
                _page.RetornarSeloDescontoProdutosdeselosdedescontoIncluir().Should().Be(Convert.ToBoolean(row.GetCell("incluirProdutosDeSelosPerfilDeAcessoSelos")));
                _page.RetornarSeloDescontoProdutosdeselosdedescontoAlterar().Should().Be(Convert.ToBoolean(row.GetCell("alterarProdutosDeSelosPerfilDeAcessoSelos")));
                _page.RetornarSeloDescontoSelosdedescontoconsumidosConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarDescontoConsumidosPerfilDeAcessoSelos")));
                _page.RetornarSeloDescontoEstoquedeselosdedescontoConsultar().Should().Be(Convert.ToBoolean(row.GetCell("consultarEstoqueDeSelosPerfilDeAcessoSelos")));
            }
        }
    }
}