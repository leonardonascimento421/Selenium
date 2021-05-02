
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.Operacao.ContratosDeEstadia;
using Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePa4;

namespace Luminus.Selenium.specs.Shared.SsCriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePa4
{
    public class SsCriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePa4PageStep
    {
        private ContratosDeEstadiaPageStep _page = new ContratosDeEstadiaPageStep();
    
        [Step("SS - Criar contrato de estadia 'Pré-pago' pelo equipamento de validação EAC (Pré-pago) -Step by Step <tabela> [18014]")]
        public void SsCriarContratoDeEstadiaPrePagoPeloEquipamentoDeValidacaoEacPrePagoStepByStep18014(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
           //_page.NaSecaoConsultarContratosDeEstadiaPreencherOCampoPesquisaComOValorCriarcontratodeestadiaprepagopeloequipamentodevalidacaoeacprepagostepbysteppagestep(row.GetCell("codigoDoCartaoContratoEstadia"));
           //_page.NaSecaoConsultarContratosDeEstadiaClicarNoMenuDeContextoDaColunaProdutoDeEstadiaComOValorCriarcontratodeestadiaprepagopeloequipamentodevalidacaoeacprepagostepbysteppagestep(row.GetCell("nomeprePagoprodutosdeestadia"));
           //_page.VerificarOsCamposDaTelaCriarcontratodeestadiaprepagopeloequipamentodevalidacaoeacprepagostepbysteppagestep(tabela);

            
        }      
    }
}