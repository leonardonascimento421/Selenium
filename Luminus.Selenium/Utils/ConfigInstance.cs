using Selenium.Utils;
using System;

namespace Luminus.Selenium.Utils
{
    public class ConfigInstance
    {
        public Aplicacao aplicacao { get; set; }
        public Url Url { get; set; }
        public Constantes Constantes { get; set; }
    }

    public class Aplicacao
    {
        public string DbConnectionString { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public Browser Browser { get; set; }
        public string pathBrowser { get; set; }
        public string pathEvidencia { get; set; }
        public string PathPrints { get; set; }
        public string PathBrowserSession { get; set; }
        public string headless { get; set; }
        public string CaminhoDriverFirefox { get; set; }
        public string CaminhoDriverChrome { get; set; }
        public string CaminhoLicenca { get; set; }
        public TimeSpan TimeoutSelenium { get; set; }
        public TimeSpan TimeoutAposClick { get; set; }
        public string LogChromeDriver { get; set; }
        public bool LogBrowserVerbose { get; set; }
        public bool LimparCache { get; set; }
        public string PortaLoginIdentityServer { get; set; }
        public string BaseResultPath { get; set; }
        public string UrlBarramento { get; set; }
    }

    public class Constantes
    {
        public string MensagemTabelaVazia { get; set; }

    }

    public class Url
    {
        public string UrlManipulae { get; set; }
        public string UrlManipulaeEntrar { get; set; }
        public string UrlLuminus { get; set; }
        public string UrlLicencaPage { get; set; }
        public string UrlLicencaListarPage { get; set; }
        public string UrlLicencaInformarPage { get; set; }
        public string UrlTelasVgaPage { get; set; }
        public string UrlBolsaoListarPage { get; set; }
        public string UrlBolsaoManterPage { get; set; }
        public string UrlEstacionamentosPage { get; set; }
        public string UrlEquipamentoPage { get; set; }
        public string UrlAplicativoVersaoPage { get; set; }
        public string UrlGrupoEquipamentoPage { get; set; }
        public string UrlParametrosGeraisPage { get; set; }
        public string UrlEstruturaTabelaCobrancaPage { get; set; }
        public string UrlProdutoEstadiaPage { get; set; }
        public string UrlRegraDeAcessoPage { get; set; }
        public string UrlRegraDeCobrancaPage { get; set; }
        public string UrlTabelaDeCobrancaPage { get; set; }
        public string UrlControlePage { get; set; }
        public string UrlRegrasDeMidiasPerdidasPage { get; set; }
        public string UrlRegraDeDescontoPage { get; set; }
        public string UrlClientesDoEstacionamentoPage { get; set; }
        public string UrlAgendamentoDeTarefasAutomatizadasPage { get; set; }
        public string UrlAlteracaoDoModoDeContingenciaPage { get; set; }
        public string UrlTipoDeOcorrenciaNasEstadiasPage { get; set; }
        public string UrlEmitentesFiscaisPage { get; set; }
        public string UrlRegraEmissaoDeBilhetesImpressosPage { get; set; }
        public string UrlIntegracoesComOperadorasDeArrecadacaoPage { get; set; }
        public string UrlProdutoEstadiaCredenciadoDiaristaPage { get; set; }
        public string UrlProdutoEstadiaPrePagoPage { get; set; }
        public string UrlProdutoEstadiaPosPagoPage { get; set; }
        public string UrlAlteracaoTemporariaDoTempoDeToleranciaPage { get; set; }
        public string UrlRegrasDeLimpezaDePatioAutomaticaPage { get; set; }
        public string UrlIntegracaoTEFPage { get; set; }
        public string UrlRegrasDeFechamentoDosEquipamentosPage { get; set; }
        public string UrlTaxasCambiaisPage { get; set; }
        public string UrlRegraDeEmissaoDeRecibosPage { get; set; }
        public string UrlRegrasDeNumerarioDeAutoAtendimentoPage { get; set; }
        public string UrlProdutoSeloDeDescontoPage { get; set; }
        public string UrlAlterarUsuarioSDoSistemaClienteDoEstacionamentoPage { get; set; }
        public string UrlOperarMultiplasCancelasPage { get; set; }
        public string UrlContratosDeEstadiaPage { get; set; }
        public string UrlContratosDeIntegracaoPage { get; set; }
        public string UrlSelosDeDescontoConsumidosPage { get; set; }
        public string UrlEstoqueDeSelosDeDescontoPage { get; set; }
        public string UrlPedidoDeSeloDesconto { get; set; }
        public string UrlPerfisDeAcessoDoSistemaPage { get; set; }
        public string UrlAgendamentosDeAtualizacaoDeAplicativos { get; set; }
        public string UrlMensagensDeAudio { get; set; }
        public string UrlArquivosSeriais { get; set; }
        public string UrlRegraDeEmissaoDeBilhetesImpressos { get; set; }
        public string UrlContratoLocadoraPage { get; set; }
        public string UrlFechamentoFaturaPage { get; set; }
        public string UrlLuminusPortalDoConveniado { get; set; }
        public string UrlAtendimentoAssistidoAbertura { get; set; }
        public string UrlApresentacaoMultimidiaListarPage { get; set; }
        public string UrlMultimidiaListarPage { get; set; }

    }
}
