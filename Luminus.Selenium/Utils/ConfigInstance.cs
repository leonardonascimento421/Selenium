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
        public Browser Browser { get; set; }
        public string pathBrowser { get; set; }
        public string pathEvidencia { get; set; }
        public string PathPrints { get; set; }
        public string PathBrowserSession { get; set; }
        public string headless { get; set; }
        public string CaminhoDriverFirefox { get; set; }
        public string CaminhoDriverChrome { get; set; }
        public TimeSpan TimeoutSelenium { get; set; }
        public TimeSpan TimeoutAposClick { get; set; }
        public string LogChromeDriver { get; set; }
        public bool LogBrowserVerbose { get; set; }
        public bool LimparCache { get; set; }
        public string BaseResultPath { get; set; }
    }

    public class Constantes
    {
        public string MensagemTabelaVazia { get; set; }

    }

    public class Url
    {
        public string UrlManipulae { get; set; }
        public string UrlManipulaeEntrar { get; set; }

    }
}
