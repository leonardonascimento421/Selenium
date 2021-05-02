
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.UsuariosDoSistema;
using Luminus.Selenium.specs.Shared.Listagem;
using Luminus.Selenium.specs.Shared.StAlterarUsuarioDoSistemaIncluindoClienteDoEstacionamentoTabela16985;

namespace Luminus.Selenium.specs.Shared.StAlterarUsuarioDoSistemaIncluindoClienteDoEstacionamentoTabela16985
{
    public class StAlterarUsuarioDoSistemaIncluindoClienteDoEstacionamentoTabela16985PageStep
    {       
        [Step("ST - Alterar usuário do sistema incluindo cliente do estacionamento <tabela> [16985]")]
        public void StAlterarUsuarioDoSistemaIncluindoClienteDoEstacionamento16985(Table tabela)
        {
            new UsuariosDoSistemaPageStep().PreencherOsCamposDaTelaAlterarUsuariosDoSistema16985(tabela);
        }
    }
}