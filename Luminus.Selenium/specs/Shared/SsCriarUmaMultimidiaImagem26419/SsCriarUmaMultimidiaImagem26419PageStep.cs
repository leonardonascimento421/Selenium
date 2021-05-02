using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Pages.Shared.Form;
using Luminus.Selenium.Implementation.Pages.Shared.Listagem;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.Implementation.Shared.Navegacao;
using Luminus.Selenium.specs.Customizacao.Multimidia;

namespace Luminus.Selenium.specs.Shared.SsCriarUmaMultimidiaImagem26419
{
    public class SsCriarUmaMultimidiaImagem26419PageStep
    {
        private MultimidiaPageStep _page = new MultimidiaPageStep();
        private ListagemPage _pageListagem = new ListagemPage();
        private NavegacaoSpec _pageNavegacao = new NavegacaoSpec();
        private BotoesCRUDPage _pageBotoesCRUD = new BotoesCRUDPage();
        private MensagemSpec _pageMensagem = new MensagemSpec();

        [Step("SS - Criar uma Multimídia (imagem) <tabela> [26419]")]
        public void SsCriarUmaMultimidiaImagem26419(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _pageNavegacao.NavegarParaUrl("UrlMultimidiaListarPage");
            _pageBotoesCRUD.ClicarBotaoCriar();
            _page.PreencherOsCamposDaTelaCriarumamultimidiaimagemtepbysteppagestep26419(tabela);
            _pageBotoesCRUD.ClicarBotaoSalvar();
            _pageMensagem.VerificarMensagemCriacaoComSucesso();
        }
    }
}