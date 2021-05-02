
using System;
using System.Threading;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAAtedimentovaletTabela17676;

namespace Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoAAtedimentovaletTabela17676
{
    public class StCriarPerfilComAcessoAAtedimentovaletTabela17676Spec 
    {       
        private PerfilDeAcessoDoSistemaPageStep _page = new PerfilDeAcessoDoSistemaPageStep();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDSpec _pageBotoes = new BotoesCRUDSpec();

        [Step("ST - Criar perfil com acesso a AtedimentoValet <tabela> [17676]")]
        public void StCriarPerfilComAcessoAAtedimentovalet17676(Table tabela)
        {
            _pageNavegacao.NavegarParaUrl("UrlPerfisDeAcessoDoSistemaPage");          
            _pageBotoes.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarPerfilComAcessoAAtedimentovalet17676(tabela);
            _pageBotoes.ClicarBotaoSalvar();      
        }
    }
}