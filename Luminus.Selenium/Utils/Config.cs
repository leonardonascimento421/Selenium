namespace Luminus.Selenium.Utils
{
    public static class Config
    {
        public static ConfigInstance Instance;
        public static Aplicacao Aplicacao;
        public static Url Url;
        public static Constantes Constantes;

        public static void Initialize(ConfigInstance configInstance)
        {
            Instance = configInstance;
            Aplicacao = configInstance.aplicacao;
            Url = configInstance.Url;
            Constantes = configInstance.Constantes;
        }
    }
}
