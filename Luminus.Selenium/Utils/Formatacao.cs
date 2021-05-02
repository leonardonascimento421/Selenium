using System;


namespace Luminus.Selenium.Utils
{
    public static class Formatacao
    {
        public static string AdicionarCasasDecimais(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return valor;

            return valor.IndexOf(',') != -1 ? valor : valor + ",00";
        }
    }
}