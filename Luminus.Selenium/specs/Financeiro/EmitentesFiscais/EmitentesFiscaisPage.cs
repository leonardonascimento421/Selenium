
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Financeiro.EmitentesFiscais
{
    public class EmitentesFiscaisPage : BasePage
    {
        public void SelecionarEstado(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Estado.Id']"), valor.ToString());
        }

        public string RetornarEstado()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='Estado.Id']"));
        }

        public void SelecionarMunicipio(string valor)
        {
            _driver.SelecionarCombo(By.CssSelector("select[formcontrolname='Municipio.Id']"), valor.ToString());
        }

        public string RetornarMunicipio()
        {
            return _driver.GetSelect(By.CssSelector("select[formcontrolname='Municipio.Id']"));
        }

        public void PreencherRazaoSocial(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='RazaoSocial']"), valor.ToString());
        }

        public string RetornarRazaoSocial()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='RazaoSocial']"));
        }

        public void PreencherNomeFantasia(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NomeFantasia']"), valor.ToString());
        }

        public string RetornarNomeFantasia()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='NomeFantasia']"));
        }

        public void PreencherCpfCnpj(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CpfCnpj']"), valor.ToString());
        }

        public string RetornarCpfCnpj()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='CpfCnpj']"));
        }

        public void PreencherLogradouro(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Logradouro']"), valor.ToString());
        }

        public string RetornarLogradouro()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Logradouro']"));
        }

        public void PreencherNumero(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Numero']"), valor.ToString());
        }

        public string RetornarNumero()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Numero']"));
        }

        public void PreencherComplemento(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Complemento']"), valor.ToString());
        }

        public string RetornarComplemento()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Complemento']"));
        }

        public void PreencherCep(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Cep']"), valor.ToString());
        }

        public string RetornarCep()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Cep']"));
        }

        public void PreencherFone(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Fone']"), valor.ToString());
        }

        public string RetornarFone()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Fone']"));
        }

        public void PreencherInscricaoMunicipal(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='InscricaoMunicipal']"), valor.ToString());
        }

        public string RetornarInscricaoMunicipal()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='InscricaoMunicipal']"));
        }

        public void PreencherInscricaoEstadual(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='InscricaoEstadual']"), valor.ToString());
        }

        public string RetornarInscricaoEstadual()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='InscricaoEstadual']"));
        }

        public void SelecionarRegimeTributario(string valor)
        {
            _driver.SelecionarCombo(new ByChained(By.CssSelector("np-select-enum[controlname='IndexRegimeTributario']"), By.CssSelector("select")), valor.ToString());
        }

        public string RetornarRegimeTributario()
        {
            return _driver.GetSelect(new ByChained(By.CssSelector("np-select-enum[controlname='IndexRegimeTributario']"), By.CssSelector("select")));
        }

        public void SelecionarTributacao(string valor)
        {
            _driver.SelecionarCombo(new ByChained(By.CssSelector("np-select-enum[controlname='IndexTributacao']"),By.CssSelector("select")),valor.ToString());
        }

        public string RetornarTributacao()
        {
            return _driver.GetSelect(new ByChained(By.CssSelector("np-select-enum[controlname='IndexTributacao']"), By.CssSelector("select")));
        }

        public void SelecionarOperacao(string valor)
        {
            _driver.SelecionarCombo(
                new ByChained(
                    By.CssSelector("np-select-enum[controlname='IndexOperacao']"),
                    By.CssSelector("select")),
                valor.ToString());
        }

        public string RetornarOperacao()
        {
            return _driver.GetSelect(new ByChained(
                    By.CssSelector("np-select-enum[controlname='IndexOperacao']"),
                    By.CssSelector("select")));
        }

        public void SelecionarIncentivadorCultural(string valor)
        {
            _driver.SelecionarCombo(new ByChained(By.CssSelector("np-select-enum[controlname='IndexIncentivadorCultural']"), By.CssSelector("select")), valor.ToString());
        }

        public string RetornarIncentivadorCultural()
        {
            return _driver.GetSelect(new ByChained(By.CssSelector("np-select-enum[controlname='IndexIncentivadorCultural']"), By.CssSelector("select")));
        }

        public void SelecionarTipoDeRecolhimento(string valor)
        {
            _driver.SelecionarCombo(new ByChained(By.CssSelector("np-select-enum[controlname='IndexTipoRecolhimento']"), By.CssSelector("select")), valor.ToString());
        }

        public string RetornarTipoDeRecolhimento()
        {
            return _driver.GetSelect(new ByChained(By.CssSelector("np-select-enum[controlname='IndexTipoRecolhimento']"), By.CssSelector("select")));
        }

        public void PreencherAliquotaISS(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaISS']"), valor.ToString());
        }

        public string RetornarAliquotaISS()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaISS']"));
        }

        public void PreencherAliquotaPIS(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaPIS']"), valor.ToString());
        }

        public string RetornarAliquotaPIS()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaPIS']"));
        }

        public void PreencherAliquotaCONFINS(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaCONFINS']"), valor.ToString());
        }

        public string RetornarAliquotaCONFINS()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaCONFINS']"));
        }

        public void PreencherAliquotaINSS(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaINSS']"), valor.ToString());
        }

        public string RetornarAliquotaINSS()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaINSS']"));
        }

        public void PreencherAliquotaICMS(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaICMS']"), valor.ToString());
        }

        public string RetornarAliquotaICMS()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaICMS']"));
        }

        public void PreencherAliquotaICMSST(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaICMSST']"), valor.ToString());
        }

        public string RetornarAliquotaICMSST()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaICMSST']"));
        }

        public void PreencherAliquotaCSLL(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaCSLL']"), valor.ToString());
        }

        public string RetornarAliquotaCSLL()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaCSLL']"));
        }

        public void PreencherAliquotaIR(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='AliquotaIR']"), valor.ToString());
        }

        public string RetornarAliquotaIR()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='AliquotaIR']"));
        }

        public void PreencherDadosComplementares(string valor)
        {
            _driver.SetText(By.CssSelector("textarea[formcontrolname='DadosComplementares']"), valor.ToString());
        }

        public string RetornarDadosComplementares()
        {
            return _driver.GetText(By.CssSelector("textarea[formcontrolname='DadosComplementares']"));
        }

        public void PreencherCoodigoSegurancaContribuinte(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='CoodigoSegurancaContribuinte']"), valor.ToString());
        }

        public string RetornarCoodigoSegurancaContribuinte()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='CoodigoSegurancaContribuinte']"));
        }

        public void PreencherTokenCSC(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='TokenCSC']"), valor.ToString());
        }

        public string RetornarTokenCSC()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='TokenCSC']"));
        }

        public void PreencherNumeroSerieCertificadoDigital(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='NumeroSerieCertificadoDigital']"), valor.ToString());
        }

        public string RetornarNumeroSerieCertificadoDigital()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='NumeroSerieCertificadoDigital']"));
        }

        public void PreencherLogin(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Login']"), valor.ToString());
        }

        public string RetornarLogin()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Login']"));
        }

        public void PreencherSenha(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Senha']"), valor.ToString());
        }

        public void MarcarImediatamente(bool Imediatamente)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[formcontrolname='Imediatamente']"), Imediatamente);
        }
    }
}