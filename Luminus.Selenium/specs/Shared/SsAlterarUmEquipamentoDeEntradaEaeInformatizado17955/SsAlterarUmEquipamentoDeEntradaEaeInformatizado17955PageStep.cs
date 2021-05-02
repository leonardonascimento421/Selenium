
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.SsAlterarUmEquipamentoDeEntradaEaeInformatizado17955;

namespace Luminus.Selenium.specs.Shared.SsAlterarUmEquipamentoDeEntradaEaeInformatizado17955
{
    public class SsAlterarUmEquipamentoDeEntradaEaeInformatizado17955PageStep
    {
        private EquipamentosPageStep _page = new EquipamentosPageStep();
    
        [Step("SS - Alterar um equipamento de entrada (EAE - Informatizado) <tabela> [17955]")]
        public void SsAlterarUmEquipamentoDeEntradaEaeInformatizado17955(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
           _page.PreencherOsCamposDaTelaEquipamentosPageStep17187(tabela);
        }       

    }
}