using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Customizacao.ApresentacoesDeMultimidias;

namespace Luminus.Selenium.specs.Shared.SsCriarUmaApresentacaoMultimidiaDeAudio26422
{
    public class SsCriarUmaApresentacaoMultimidiaDeAudio26422PageStep
    {
        private ApresentacoesDeMultimidiasPageStep _page = new ApresentacoesDeMultimidiasPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Criar uma Apresentação Multimídia de Audio <tabela> [26422]")]
        public void SsCriarUmaApresentacaoMultimidiaDeAudio26422(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlApresentacaoMultimidiaListarPage");
            _pageBotoesCRUD.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaApresentacoesdemultimidiasaudiopagestep26422(tabela);
            _pageBotoesCRUD.ClicarBotaoSalvar();
            _pageMensagem.VerificarMensagemCriacaoComSucesso();
        }
    }
}