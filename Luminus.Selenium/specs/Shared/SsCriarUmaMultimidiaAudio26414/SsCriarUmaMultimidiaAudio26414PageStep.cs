using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Customizacao.Multimidia;

namespace Luminus.Selenium.specs.Shared.SsCriarUmaMultimidiaAudio26414
{
    public class SsCriarUmaMultimidiaAudio26414PageStep
    {
        private MultimidiaPageStep _page = new MultimidiaPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Criar uma Multimídia (áudio) <tabela> [26414]")]
        public void SsCriarUmaMultimidiaAudio26414(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlMultimidiaListarPage");
            _pageBotoesCRUD.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarumamultimidiaaudiostepbysteppagestep26414(tabela);
            _pageBotoesCRUD.ClicarBotaoSalvar();
            _pageMensagem.VerificarMensagemCriacaoComSucesso();
        }
    }
}