
using System;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.UsuariosDoSistema;
using Luminus.Selenium.specs.Shared.StCriarUmUsuarioDoSistemaTabela17595;

namespace Luminus.Selenium.specs.Shared.StCriarUmUsuarioDoSistemaTabela17595
{
    public class StCriarUmUsuarioDoSistemaTabela17595PageStep
    {
        private UsuariosDoSistemaPageStep _page = new UsuariosDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();


        [Step("ST - Criar um usuário do sistema <tabela> [17595]")]
        public void StCriarUmUsuarioDoSistema17595(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlAlterarUsuarioSDoSistemaClienteDoEstacionamentoPage");
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaUsuariosDoSistema17595(tabela);
            _pageBotoes.ClicarBotaoSalvar();
            _pageBotoes.ClicarBotaoSalvareSair();
            new MensagemSpec().VerificarMensagemCriacaoComSucesso();
        }
    }
}