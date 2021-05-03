using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Abstractions;
using Luminus.Selenium.Implementation;
using Luminus.Selenium.Implementation.Shared.Login;
using Luminus.Selenium.Utils;
using Luminus.Selenium.Utils.Barramento;
using Newtonsoft.Json;
using Selenium.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium
{
    public static class Initializer
    {
        public static void Initialize()
        {
            ConfigInstance config = JsonConvert.DeserializeObject<ConfigInstance>(File.ReadAllText("config.json"));

            if (config == null)
                throw new InvalidOperationException("O arquivo de configuração 'config.json' não foi encontrado");

            Config.Initialize(config);

            RepositoryHelper.Register<IRepository<KeyValueEntity>, KeyValueRepository>(new KeyValueRepository(Config.Aplicacao.DbConnectionString));

            WebDriverExtensions.Timeout = Config.Aplicacao.TimeoutSelenium;
            WebDriverExtensions.TimeoutAposClick = Config.Aplicacao.TimeoutAposClick;

            bool limparCache = Config.Aplicacao.LimparCache;
            bool headless = Config.Aplicacao.headless == "1";

            DriverFactory.Initialize(new DriverCacheSingletonStrategy(), Config.Aplicacao.Browser, Config.Aplicacao.pathBrowser, headless, Config.Aplicacao.LogChromeDriver, Config.Aplicacao.LogBrowserVerbose, limparCache, Config.Aplicacao.PathBrowserSession, Config.Url.UrlManipulae);

            Luminus.Selenium.Utils.ScreenshotHelper.Initialize(Config.Aplicacao.PathPrints);

            string parallelPhase = Environment.GetEnvironmentVariable("testtools_gauge_run_parallel_phase");
            Console.WriteLine($"Fase da execução em paralelo (testtools_gauge_run_parallel_phase): {parallelPhase}");

            string synchronousPhase = Environment.GetEnvironmentVariable("testtools_gauge_run_synchronous_phase");
            Console.WriteLine($"Fase da execução em serial (testtools_gauge_run_synchronous_phase): {synchronousPhase}");            

            if (string.IsNullOrWhiteSpace(parallelPhase) || parallelPhase == "1" || synchronousPhase == "1")
                CriarPastasLimpando(
                    Config.Aplicacao.BaseResultPath,
                    Config.Aplicacao.LogChromeDriver,
                    Environment.GetEnvironmentVariable("gauge_reports_dir"),
                    Config.Aplicacao.PathPrints,
                    Config.Aplicacao.PathBrowserSession);
            else
                limparCache = false;
                       
            if (string.IsNullOrWhiteSpace(parallelPhase))
                new LoginSpec().EfetuarLogin();
        }

        public static void CleanUp()
        {
            DriverFactory.Dispose(DriverFactory.Driver);
        }

        private static void CriarPastasLimpando(params string[] paths)
        {
            foreach (var path in paths)
            {
                if (string.IsNullOrWhiteSpace(path))
                    continue;

                Console.WriteLine($"Caminho informado para criação/limpeza: {path}");

                string directory = Path.HasExtension(path) ? Path.GetDirectoryName(path) : path;

                try
                {
                    if (Directory.Exists(directory))
                    {
                        Directory.Delete(directory, true);
                        Console.WriteLine($"Excluindo a pasta: {directory}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao excluir o diretório {directory} Ex: {ex.Message} - StackTrace: {ex.StackTrace}");
                }

                try
                {
                    Directory.CreateDirectory(directory);
                    Console.WriteLine($"Criando a pasta: {directory}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao criar o diretório {directory} Ex: {ex.Message} - StackTrace: {ex.StackTrace}");
                }
            }
        }
    }
}
