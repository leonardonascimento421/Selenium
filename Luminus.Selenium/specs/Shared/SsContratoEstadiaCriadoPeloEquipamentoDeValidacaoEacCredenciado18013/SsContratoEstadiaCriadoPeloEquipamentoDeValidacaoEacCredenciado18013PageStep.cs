
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsContratoEstadiaCriadoPeloEquipamentoDeValidacaoEacCredenciado18013;

namespace Luminus.Selenium.specs.Shared.SsContratoEstadiaCriadoPeloEquipamentoDeValidacaoEacCredenciado18013
{
    public class SsContratoEstadiaCriadoPeloEquipamentoDeValidacaoEacCredenciado18013PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
    
        [Step("SS - Contrato estadia criado pelo equipamento de validação EAC (Credenciado) <tabela> [18013]")]
        public void SsContratoEstadiaCriadoPeloEquipamentoDeValidacaoEacCredenciado18013(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            //_page.NaSecaoConsultarContratosDeEstadiaPreencherOCampoPesquisaComOValorContratoestadiacriadopeloequipamentodevalidacaoeaccredenciadostepbysteppagestep(row.GetCell("codigoDoCartaoContratoEstadia"));
            //_page.NaSecaoConsultarContratosDeEstadiaClicarNoMenuDeContextoDaColunaProdutoDeEstadiaComOValorContratoestadiacriadopeloequipamentodevalidacaoeaccredenciadostepbysteppagestep(row.GetCell("nomeProdutoEstadiaDiaDoMes"));
            //_page.VerificarOsCamposDaTelaContratosDeEstadiaPageStep18013(tabela);


        }
    }
}