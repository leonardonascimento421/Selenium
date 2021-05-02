
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Financeiro.EmitentesFiscais;
using Luminus.Selenium.specs.Shared.Listagem;

namespace Luminus.Selenium.specs.Financeiro.EmitentesFiscais
{
    public class EmitentesFiscaisPageStep
    {
        private EmitentesFiscaisPage _page = new EmitentesFiscaisPage();
    
        [Step("Preencher os campos da tela Criar um emitente fiscal <tabela>")]
        public void PreencherOsCamposDaTelaCriarUmEmitenteFiscal(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarEstado(row.GetCell("estadoSaoPauloEmitenteFiscal"));
            _page.SelecionarMunicipio(row.GetCell("municipioSaoPauloEmitenteFiscal"));
            _page.PreencherRazaoSocial(row.GetCell("razaoSocialEmitenteFiscal"));
            _page.PreencherNomeFantasia(row.GetCell("nomeFantasiaEmitenteFiscal"));
            _page.PreencherCpfCnpj(row.GetCell("cNPJEmitenteFiscal"));
            _page.PreencherLogradouro(row.GetCell("logradouradoEmitenteFiscal"));
            _page.PreencherNumero(row.GetCell("numeroEmitenteFiscal"));
            _page.PreencherComplemento(row.GetCell("complementoEmitenteFiscal"));
            _page.PreencherCep(row.GetCell("cEPEmitenteFiscal"));
            _page.PreencherFone(row.GetCell("foneEmitenteFiscal"));
            _page.PreencherInscricaoMunicipal(row.GetCell("inscricaoMunicipalEmitenteFiscal"));
            _page.PreencherInscricaoEstadual(row.GetCell("inscricaoEstadualEmitenteFiscal"));
            _page.SelecionarRegimeTributario(row.GetCell("regimeTributarioEmitenteFiscal"));
            _page.SelecionarTributacao(row.GetCell("tributacaoEmitenteFiscal"));
            _page.SelecionarOperacao(row.GetCell("operacaoEmitenteFiscal"));
            _page.SelecionarIncentivadorCultural(row.GetCell("incentivardorCulturalEmitenteFiscal"));
            _page.SelecionarTipoDeRecolhimento(row.GetCell("tipoRecolhimentoEmitenteFiscal"));
            _page.PreencherAliquotaISS(row.GetCell("aliquotaISSEmitenteFiscal"));
            _page.PreencherAliquotaPIS(row.GetCell("aliquotaPISEmitenteFiscal"));
            _page.PreencherAliquotaCONFINS(row.GetCell("aliquotaCOFINSEmitenteFiscal"));
            _page.PreencherAliquotaINSS(row.GetCell("aliquotaINSSEmitenteFiscal"));
            _page.PreencherAliquotaICMS(row.GetCell("aliquotaICMSEmitenteFiscal"));
            _page.PreencherAliquotaICMSST(row.GetCell("aliquotaICMSSTEmitenteFiscal"));
            _page.PreencherAliquotaCSLL(row.GetCell("aliquotaCSLLEmitenteFiscal"));
            _page.PreencherAliquotaIR(row.GetCell("aliquotaIREmitenteFiscal"));
            _page.PreencherDadosComplementares(row.GetCell("descricaoDadosComplementaresEmitenteFiscal"));
            _page.PreencherCoodigoSegurancaContribuinte(row.GetCell("cSCEmitenteFiscal"));
            _page.PreencherTokenCSC(row.GetCell("tokenCSCEmitenteFiscal"));
            _page.PreencherNumeroSerieCertificadoDigital(row.GetCell("numeroSerieCertificadoDigitalEmitenteFiscal"));
            _page.PreencherLogin(row.GetCell("loginAutenticacaoEmitenteFiscal"));
            _page.PreencherSenha(row.GetCell("senhaAutenticacaoEmitenteFiscal"));

        }

        [Step("Verificar os campos da tela Emitentes Fiscais <tabela>")]
        public void VerificarOsCamposDaTelaEmitentesFiscais(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarEstado().Should().Be(row.GetCell("estadoSaoPauloEmitenteFiscal"));
               _page.RetornarMunicipio().Should().Be(row.GetCell("municipioSaoPauloEmitenteFiscal"));
               _page.RetornarRazaoSocial().Should().Be(row.GetCell("razaoSocialEmitenteFiscal"));
               _page.RetornarNomeFantasia().Should().Be(row.GetCell("nomeFantasiaEmitenteFiscal"));
               _page.RetornarCpfCnpj().Should().Be(row.GetCell("cNPJEmitenteFiscal"));
               _page.RetornarLogradouro().Should().Be(row.GetCell("logradouradoEmitenteFiscal"));
               _page.RetornarNumero().Should().Be(row.GetCell("numeroEmitenteFiscal"));
               _page.RetornarComplemento().Should().Be(row.GetCell("complementoEmitenteFiscal"));
               _page.RetornarCep().Should().Be(row.GetCell("cEPEmitenteFiscal"));
               _page.RetornarFone().Should().Be(row.GetCell("foneEmitenteFiscal"));
               _page.RetornarInscricaoMunicipal().Should().Be(row.GetCell("inscricaoMunicipalEmitenteFiscal"));
               _page.RetornarInscricaoEstadual().Should().Be(row.GetCell("inscricaoEstadualEmitenteFiscal"));
               _page.RetornarRegimeTributario().Should().Be(row.GetCell("regimeTributarioEmitenteFiscal"));
               _page.RetornarTributacao().Should().Be(row.GetCell("tributacaoEmitenteFiscal"));
               _page.RetornarOperacao().Should().Be(row.GetCell("operacaoEmitenteFiscal"));
               _page.RetornarIncentivadorCultural().Should().Be(row.GetCell("incentivardorCulturalEmitenteFiscal"));
               _page.RetornarTipoDeRecolhimento().Should().Be(row.GetCell("tipoRecolhimentoEmitenteFiscal"));
               _page.RetornarAliquotaISS().Should().Be(row.GetCell("aliquotaISSEmitenteFiscal"));
               _page.RetornarAliquotaPIS().Should().Be(row.GetCell("aliquotaPISEmitenteFiscal"));
               _page.RetornarAliquotaCONFINS().Should().Be(row.GetCell("aliquotaCOFINSEmitenteFiscal"));
               _page.RetornarAliquotaINSS().Should().Be(row.GetCell("aliquotaINSSEmitenteFiscal"));
               _page.RetornarAliquotaICMS().Should().Be(row.GetCell("aliquotaICMSEmitenteFiscal"));
               _page.RetornarAliquotaICMSST().Should().Be(row.GetCell("aliquotaICMSSTEmitenteFiscal"));
               _page.RetornarAliquotaCSLL().Should().Be(row.GetCell("aliquotaCSLLEmitenteFiscal"));
               _page.RetornarAliquotaIR().Should().Be(row.GetCell("aliquotaIREmitenteFiscal"));
               _page.RetornarDadosComplementares().Should().Be(row.GetCell("descricaoDadosComplementaresEmitenteFiscal"));
               _page.RetornarCoodigoSegurancaContribuinte().Should().Be(row.GetCell("cSCEmitenteFiscal"));
               _page.RetornarTokenCSC().Should().Be(row.GetCell("tokenCSCEmitenteFiscal"));
               _page.RetornarNumeroSerieCertificadoDigital().Should().Be(row.GetCell("numeroSerieCertificadoDigitalEmitenteFiscal"));
               _page.RetornarLogin().Should().Be(row.GetCell("loginAutenticacaoEmitenteFiscal"));
            }
        
        }

        [Step("Na seção Informações gerais alterar o campo Estado com o valor <estadoEmitenteFiscal>")]
        public void NaSecaoInformacoesGeraisAlterarOCampoEstadoComOValor(string estadoEmitenteFiscal)
        {
            _page.SelecionarEstado(estadoEmitenteFiscal);
        }

        [Step("Na seção Informações gerais alterar o campo Municipio com o valor <municipioEmitenteFiscal>")]
        public void NaSecaoInformacoesGeraisAlterarOCampoMunicipioComOValor(string municipioEmitenteFiscal)
        {
            _page.SelecionarMunicipio(municipioEmitenteFiscal);
        }

        [Step("Na seção Informações gerais alterar o campo Razão social com o valor <razaoSocialEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesGeraisAlterarOCampoRazaoSocialComOValor(string razaoSocialEmitenteFiscalalterado)
        {
            _page.PreencherRazaoSocial(razaoSocialEmitenteFiscalalterado);
        }

        [Step("Na seção Informações gerais alterar o campo Nome Fantasia com o valor <nomeFantasiaEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesGeraisAlterarOCampoNomeFantasiaComOValor(string nomeFantasiaEmitenteFiscalalterado)
        {
            _page.PreencherNomeFantasia(nomeFantasiaEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias alterar o campo Inscrição municipal com o valor <inscricaoMunicipalEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasAlterarOCampoInscricaoMunicipalComOValor(string inscricaoMunicipalEmitenteFiscalalterado)
        {
            _page.PreencherInscricaoMunicipal(inscricaoMunicipalEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias no combobox Regime tributário alterar para o valor <regimeTributarioEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasNoComboboxRegimeTributarioAlterarParaOValor(string regimeTributarioEmitenteFiscalalterado)
        {
            _page.SelecionarRegimeTributario(regimeTributarioEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias no combobox Tributação alterar para o valor <tributacaoEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasNoComboboxTributacaoAlterarParaOValor(string tributacaoEmitenteFiscalalterado)
        {
            _page.SelecionarTributacao(tributacaoEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias no combobox Operação alterar para o valor <operacaoEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasNoComboboxOperacaoAlterarParaOValor(string operacaoEmitenteFiscalalterado)
        {
            _page.SelecionarOperacao(operacaoEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias no combobox Incentivador cultural alterar para o valor <incentivardorCulturalEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasNoComboboxIncentivadorCulturalAlterarParaOValor(string incentivardorCulturalEmitenteFiscalalterado)
        {
            _page.SelecionarIncentivadorCultural(incentivardorCulturalEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias no combobox Tipo de recolhimento alterar para o valor <tipoRecolhimentoEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasNoComboboxTipoDeRecolhimentoAlterarParaOValor(string tipoRecolhimentoEmitenteFiscalalterado)
        {
            _page.SelecionarTipoDeRecolhimento(tipoRecolhimentoEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias alterar o campo Alíquota de ISS com o valor <aliquotaISSEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasAlterarOCampoAliquotaDeIssComOValor(string aliquotaISSEmitenteFiscalalterado)
        {
            _page.PreencherAliquotaISS(aliquotaISSEmitenteFiscalalterado);
        }

        [Step("Na seção Informações tributárias alterar o campo Alíquota de PIS com o valor <aliquotaPISEmitenteFiscalalterado>")]
        public void NaSecaoInformacoesTributariasAlterarOCampoAliquotaDePisComOValor(string aliquotaPISEmitenteFiscalalterado)
        {
            _page.PreencherAliquotaPIS(aliquotaPISEmitenteFiscalalterado);
        }

        [Step("Verificar os campos da tela Emitentes Fiscais <tabela> [16496]")]
        public void VerificarOsCamposDaTelaEmitentesFiscais16496(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
               _page.RetornarEstado().Should().Be(row.GetCell("estadoParanaEmitenteFiscalalterado"));
               _page.RetornarMunicipio().Should().Be(row.GetCell("municipioCuritibaEmitenteFiscalalterado"));
               _page.RetornarRazaoSocial().Should().Be(row.GetCell("razaoSocialEmitenteFiscalalterado"));
               _page.RetornarNomeFantasia().Should().Be(row.GetCell("nomeFantasiaEmitenteFiscalalterado"));
               _page.RetornarInscricaoMunicipal().Should().Be(row.GetCell("inscricaoMunicipalEmitenteFiscalalterado"));
               _page.RetornarRegimeTributario().Should().Be(row.GetCell("regimeTributarioEmitenteFiscalalterado"));
               _page.RetornarTributacao().Should().Be(row.GetCell("tributacaoEmitenteFiscalalterado"));
               _page.RetornarOperacao().Should().Be(row.GetCell("operacaoEmitenteFiscalalterado"));
               _page.RetornarIncentivadorCultural().Should().Be(row.GetCell("incentivardorCulturalEmitenteFiscalalterado"));
               _page.RetornarTipoDeRecolhimento().Should().Be(row.GetCell("tipoRecolhimentoEmitenteFiscalalterado"));
               _page.RetornarAliquotaISS().Should().Be(row.GetCell("aliquotaISSEmitenteFiscalalterado"));
               _page.RetornarAliquotaPIS().Should().Be(row.GetCell("aliquotaPISEmitenteFiscalalterado"));
            }
        
        }


    }
}