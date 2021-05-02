
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.AtendimentoAssistido.AbrirEstadia
{
    public class AbrirEstadiaPage : BasePage
    {

        public void MarcarCartaoCodDeBarras(bool check)
        {
            _driver.Click_(By.CssSelector("img[title='3 - Cartão código de barras com horário de entrada']"), check);
        }

        public bool RetornarCartaoCodDeBarras()
        {
            return _driver.GetCheck(By.CssSelector("img[title='3 - Cartão código de barras com horário de entrada']"));
        }
        public void SelecionarProdutoEstadia(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdProdutoEstadia']"), valor);
        }

        public string RetornarProdutoEstadia()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdProdutoEstadia']"));
        }

        public void SelecionarBolsaoVagas(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='IdBolsaoVagas']"), valor);
        }

        public string RetornarBolsaoVagas()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='IdBolsaoVagas']"));
        }

        public void SelecionarTipoVeiculo(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Veiculo.TipoVeiculo']"), valor);
        }

        public string RetornarTipoVeiculo()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='Veiculo.TipoVeiculo']"));
        }

    }
}