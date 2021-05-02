
using Luminus.Selenium.Implementation.Pages;
using OpenQA.Selenium;
using Selenium.Utils;

namespace Luminus.Selenium.specs.Seguranca.PerfilDeAcessoDoSistema
{
    public class PerfilDeAcessoDoSistemaPage : BasePage
    {
        public void PreencherNome(string valor)
        {
            _driver.SetText(By.CssSelector("input[formcontrolname='Nome']"), valor.ToString());
        }

        public string RetornarNome()
        {
            return _driver.GetText(By.CssSelector("input[formcontrolname='Nome']"));
        }

        public void MarcarSeloDesconto(bool checkSeloDesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDesconto']"), checkSeloDesconto);
        }

        public bool RetornarSeloDesconto()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDesconto']"));
        }

        public void MarcarSeloDescontoConsumodeselodedesconto(bool checkSeloDescontoConsumodeselodedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDesconto']"), checkSeloDescontoConsumodeselodedesconto);
        }

        public bool RetornarSeloDescontoConsumodeselodedesconto()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDesconto']"));
        }

        public void MarcarSeloDescontoConsumodeselodedescontoValidarestadia(bool checkSeloDescontoConsumodeselodedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDescontoValidarEstadia']"), checkSeloDescontoConsumodeselodedesconto);
        }

        public bool RetornarSeloDescontoConsumodeselodedescontoValidarestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDescontoValidarEstadia']"));
        }

        public void MarcarSeloDescontoConsumodeselodedescontoConsultar(bool checkSeloDescontoConsumodeselodedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDescontoConsultar']"), checkSeloDescontoConsumodeselodedesconto);
        }

        public bool RetornarSeloDescontoConsumodeselodedescontoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDescontoConsultar']"));
        }

        public void MarcarSeloDescontoConsumodeselodedescontoAplicar(bool checkSeloDescontoConsumodeselodedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDescontoAplicar']"), checkSeloDescontoConsumodeselodedesconto);
        }

        public bool RetornarSeloDescontoConsumodeselodedescontoAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoConsumoSeloDescontoAplicar']"));
        }

        public void MarcarSeloDescontoContratosdeintegracao(bool checkSeloDescontoContratosdeintegracao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoContratosIntegracao']"), checkSeloDescontoContratosdeintegracao);
        }

        public bool RetornarSeloDescontoContratosdeintegracao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoContratosIntegracao']"));
        }

        public void MarcarSeloDescontoContratosdeintegracaoConsultar(bool checkSeloDescontoContratosdeintegracao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoConsultar']"), checkSeloDescontoContratosdeintegracao);
        }

        public bool RetornarSeloDescontoContratosdeintegracaoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoConsultar']"));
        }

        public void MarcarSeloDescontoContratosdeintegracaoIncluir(bool checkSeloDescontoContratosdeintegracao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoIncluir']"), checkSeloDescontoContratosdeintegracao);
        }

        public bool RetornarSeloDescontoContratosdeintegracaoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoIncluir']"));
        }

        public void MarcarSeloDescontoContratosdeintegracaoAlterar(bool checkSeloDescontoContratosdeintegracao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoAlterar']"), checkSeloDescontoContratosdeintegracao);
        }

        public bool RetornarSeloDescontoContratosdeintegracaoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoAlterar']"));
        }

        public void MarcarSeloDescontoContratosdeintegracaoExcluir(bool checkSeloDescontoContratosdeintegracao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoExcluir']"), checkSeloDescontoContratosdeintegracao);
        }

        public bool RetornarSeloDescontoContratosdeintegracaoExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoContratosIntegracaoExcluir']"));
        }

        public void MarcarSeloDescontoPedidosdeselosdedesconto(bool checkSeloDescontoPedidosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDesconto']"), checkSeloDescontoPedidosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoPedidosdeselosdedesconto()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDesconto']"));
        }

        public void MarcarSeloDescontoPedidosdeselosdedescontoConsultar(bool checkSeloDescontoPedidosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoConsultar']"), checkSeloDescontoPedidosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoPedidosdeselosdedescontoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoConsultar']"));
        }

        public void MarcarSeloDescontoPedidosdeselosdedescontoIncluir(bool checkSeloDescontoPedidosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoIncluir']"), checkSeloDescontoPedidosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoPedidosdeselosdedescontoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoIncluir']"));
        }

        public void MarcarSeloDescontoPedidosdeselosdedescontoAlterar(bool checkSeloDescontoPedidosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoAlterar']"), checkSeloDescontoPedidosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoPedidosdeselosdedescontoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoAlterar']"));
        }

        public void MarcarSeloDescontoPedidosdeselosdedescontoImprimir(bool checkSeloDescontoPedidosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoImprimir']"), checkSeloDescontoPedidosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoPedidosdeselosdedescontoImprimir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoPedidoSeloDescontoImprimir']"));
        }

        public void MarcarSeloDescontoProdutosdeselosdedesconto(bool checkSeloDescontoProdutosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDesconto']"), checkSeloDescontoProdutosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoProdutosdeselosdedesconto()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDesconto']"));
        }

        public void MarcarSeloDescontoProdutosdeselosdedescontoConsultar(bool checkSeloDescontoProdutosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoConsultar']"), checkSeloDescontoProdutosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoProdutosdeselosdedescontoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoConsultar']"));
        }

        public void MarcarSeloDescontoProdutosdeselosdedescontoIncluir(bool checkSeloDescontoProdutosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoIncluir']"), checkSeloDescontoProdutosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoProdutosdeselosdedescontoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoIncluir']"));
        }

        public void MarcarSeloDescontoProdutosdeselosdedescontoAlterar(bool checkSeloDescontoProdutosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoAlterar']"), checkSeloDescontoProdutosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoProdutosdeselosdedescontoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoAlterar']"));
        }

        public void MarcarSeloDescontoProdutosdeselosdedescontoExcluir(bool checkSeloDescontoProdutosdeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoExcluir']"), checkSeloDescontoProdutosdeselosdedesconto);
        }

        public bool RetornarSeloDescontoProdutosdeselosdedescontoExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoProdutoSeloDescontoExcluir']"));
        }

        public void MarcarSeloDescontoSelosdedescontoconsumidos(bool checkSeloDescontoSelosdedescontoconsumidos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoSelosDescontosConsumidos']"), checkSeloDescontoSelosdedescontoconsumidos);
        }

        public bool RetornarSeloDescontoSelosdedescontoconsumidos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoSelosDescontosConsumidos']"));
        }

        public void MarcarSeloDescontoSelosdedescontoconsumidosConsultar(bool checkSeloDescontoSelosdedescontoconsumidos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoSelosDescontosConsumidosConsultar']"), checkSeloDescontoSelosdedescontoconsumidos);
        }

        public bool RetornarSeloDescontoSelosdedescontoconsumidosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoSelosDescontosConsumidosConsultar']"));
        }

        public void MarcarSeloDescontoEstoquedeselosdedesconto(bool checkSeloDescontoEstoquedeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoEstoqueSelosDesconto']"), checkSeloDescontoEstoquedeselosdedesconto);
        }

        public bool RetornarSeloDescontoEstoquedeselosdedesconto()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoEstoqueSelosDesconto']"));
        }

        public void MarcarSeloDescontoEstoquedeselosdedescontoConsultar(bool checkSeloDescontoEstoquedeselosdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeloDescontoEstoqueSelosDescontoConsultar']"), checkSeloDescontoEstoquedeselosdedesconto);
        }

        public bool RetornarSeloDescontoEstoquedeselosdedescontoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeloDescontoEstoqueSelosDescontoConsultar']"));
        }


        public void MarcarAtendimentoassistido(bool checkAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistido']"), checkAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistido()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistido']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistido(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistido']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistido()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistido']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoInicio(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoHome']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoInicio()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoHome']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoAbrirestadia(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoAbrirEstadia']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoAbrirestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoAbrirEstadia']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoFecharestadia(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoFecharEstadia']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoFecharestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoFecharEstadia']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoPassagemestadia(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoPassagemEstadia']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoPassagemestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoPassagemEstadia']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoValidarestadia(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoValidarEstadia']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoValidarestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoValidarEstadia']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoTransferirestadia(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoTransferirEstadia']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoTransferirestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoTransferirEstadia']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoAditarcontrato(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoAditarContrato']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoAditarcontrato()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoAditarContrato']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoTratarmidiaperdida(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoTratarMidiaPerdida']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoTratarmidiaperdida()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoTratarMidiaPerdida']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoChamarveiculo(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoChamarVeiculo']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoChamarveiculo()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoChamarVeiculo']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoDevolverveiculo(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoDevolverVeiculo']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoDevolverveiculo()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoDevolverVeiculo']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoDeixarVeiculo(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoDeixarVeiculo']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoDeixarVeiculo()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoDeixarVeiculo']"));
        }

        public void MarcarAtendimentoassistidoAtendimentoassistidoMarcarVeiculoComoPronto(bool checkAtendimentoassistidoAtendimentoassistido)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoMarcarVeiculoComoPronto']"), checkAtendimentoassistidoAtendimentoassistido);
        }

        public bool RetornarAtendimentoassistidoAtendimentoassistidoMarcarVeiculoComoPronto()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoAssistidoAtendimentoAssistidoMarcarVeiculoComoPronto']"));
        }

        public void MarcarAtendimentoValet(bool checkAtendimentoValet)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoValet']"), checkAtendimentoValet);
        }

        public bool RetornarAtendimentoValet()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoValet']"));
        }

        public void MarcarAtendimentoValetAtendimentoValetConsultarVeiculos(bool checkAtendimentoValetAtendimentoValet)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkAtendimentoValetAtendimentoValetConsultarVeiculos']"), checkAtendimentoValetAtendimentoValet);
        }

        public bool RetornarAtendimentoValetAtendimentoValetConsultarVeiculos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkAtendimentoValetAtendimentoValetConsultarVeiculos']"));
        }

        public void MarcarConfiguracoesdoestacionamento(bool checkConfiguracoesdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamento']"), checkConfiguracoesdoestacionamento);
        }

        public bool RetornarConfiguracoesdoestacionamento()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamento']"));
        }

        public void MarcarConfiguracoesdoestacionamentoConfiguracoesdoestacionamentoBolsoesdevagas(bool checkConfiguracoesdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagas']"), checkConfiguracoesdoestacionamento);
        }

        public bool RetornarConfiguracoesdoestacionamentoConfiguracoesdoestacionamentoBolsoesdevagas()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagas']"));
        }

        public void MarcarConfiguracoesdoestacionamentoBolsoesdevagasConsultar(bool checkConfiguracoesdoestacionamentoBolsoesdevagasConsultar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasConsultar']"), checkConfiguracoesdoestacionamentoBolsoesdevagasConsultar);
        }

        public bool RetornarConfiguracoesdoestacionamentoBolsoesdevagasConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasConsultar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoBolsoesdevagasAlterar(bool checkConfiguracoesdoestacionamentoBolsoesdevagasAlterar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasAlterar']"), checkConfiguracoesdoestacionamentoBolsoesdevagasAlterar);
        }

        public bool RetornarConfiguracoesdoestacionamentoBolsoesdevagasAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasAlterar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoBolsoesdevagasExcluir(bool checkConfiguracoesdoestacionamentoBolsoesdevagasExcluir)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasExcluir']"), checkConfiguracoesdoestacionamentoBolsoesdevagasExcluir);
        }

        public bool RetornarConfiguracoesdoestacionamentoBolsoesdevagasExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasExcluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoBolsoesdevagasIncluir(bool checkConfiguracoesdoestacionamentoBolsoesdevagasIncluir)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasIncluir']"), checkConfiguracoesdoestacionamentoBolsoesdevagasIncluir);
        }

        public bool RetornarConfiguracoesdoestacionamentoBolsoesdevagasIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoBolsoesdeVagasIncluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoArquivosseriaismifare(bool checkConfiguracoesdoestacionamentoArquivosseriaismifareCarregar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoArquivosSeriaisMifare']"), checkConfiguracoesdoestacionamentoArquivosseriaismifareCarregar);
        }

        public bool RetornarConfiguracoesdoestacionamentoArquivosseriaismifare()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoArquivosSeriaisMifare']"));
        }

        public void MarcarConfiguracoesdoestacionamentoArquivosseriaismifareCarregar(bool checkConfiguracoesdoestacionamentoArquivosseriaismifareCarregar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoArquivosSeriaisMifareCarregar']"), checkConfiguracoesdoestacionamentoArquivosseriaismifareCarregar);
        }

        public bool RetornarConfiguracoesdoestacionamentoArquivosseriaismifareCarregar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoArquivosSeriaisMifareCarregar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEquipamentos(bool checkConfiguracoesdoestacionamentoEquipamentosConsultar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentos']"), checkConfiguracoesdoestacionamentoEquipamentosConsultar);
        }

        public bool RetornarConfiguracoesdoestacionamentoEquipamentos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentos']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEquipamentosConsultar(bool checkConfiguracoesdoestacionamentoEquipamentosConsultar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosConsultar']"), checkConfiguracoesdoestacionamentoEquipamentosConsultar);
        }

        public bool RetornarConfiguracoesdoestacionamentoEquipamentosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosConsultar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEquipamentosAlterar(bool checkConfiguracoesdoestacionamentoEquipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosAlterar']"), checkConfiguracoesdoestacionamentoEquipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoEquipamentosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosAlterar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEquipamentosExcluir(bool checkConfiguracoesdoestacionamentoEquipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosExcluir']"), checkConfiguracoesdoestacionamentoEquipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoEquipamentosExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosExcluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEquipamentosIncluir(bool checkConfiguracoesdoestacionamentoEquipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosIncluir']"), checkConfiguracoesdoestacionamentoEquipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoEquipamentosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEquipamentosIncluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEstacionamentos(bool checkConfiguracoesdoestacionamentoEstacionamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEstacionamento']"), checkConfiguracoesdoestacionamentoEstacionamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoEstacionamentos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEstacionamento']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEstacionamentosConsultar(bool checkConfiguracoesdoestacionamentoEstacionamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEstacionamentoConsultar']"), checkConfiguracoesdoestacionamentoEstacionamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoEstacionamentosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEstacionamentoConsultar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoEstacionamentosAlterar(bool checkConfiguracoesdoestacionamentoEstacionamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEstacionamentoAlterar']"), checkConfiguracoesdoestacionamentoEstacionamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoEstacionamentosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoEstacionamentoAlterar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoGruposdeequipamentos(bool checkConfiguracoesdoestacionamentoGruposdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentos']"), checkConfiguracoesdoestacionamentoGruposdeequipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoGruposdeequipamentos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentos']"));
        }

        public void MarcarConfiguracoesdoestacionamentoGruposdeequipamentosConsultar(bool checkConfiguracoesdoestacionamentoGruposdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosConsultar']"), checkConfiguracoesdoestacionamentoGruposdeequipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoGruposdeequipamentosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosConsultar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoGruposdeequipamentosIncluir(bool checkConfiguracoesdoestacionamentoGruposdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosIncluir']"), checkConfiguracoesdoestacionamentoGruposdeequipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoGruposdeequipamentosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosIncluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoGruposdeequipamentosAlterar(bool checkConfiguracoesdoestacionamentoGruposdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosAlterar']"), checkConfiguracoesdoestacionamentoGruposdeequipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoGruposdeequipamentosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosAlterar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoGruposdeequipamentosExcluir(bool checkConfiguracoesdoestacionamentoGruposdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosExcluir']"), checkConfiguracoesdoestacionamentoGruposdeequipamentos);
        }

        public bool RetornarConfiguracoesdoestacionamentoGruposdeequipamentosExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoGrupoEquipamentosExcluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao(bool checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacao']"), checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao);
        }

        public bool RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacao']"));
        }

        public void MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoConsultar(bool checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoConsultar']"), checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao);
        }

        public bool RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoConsultar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAlterar(bool checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoAlterar']"), checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao);
        }

        public bool RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoAlterar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoExcluir(bool checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoExcluir']"), checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao);
        }

        public bool RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoExcluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoIncluir(bool checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoIncluir']"), checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao);
        }

        public bool RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoIncluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAplicar(bool checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoAplicar']"), checkConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacao);
        }

        public bool RetornarConfiguracoesdoestacionamentoIntegracaocomoperadoradearrecadacaoAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoIntegracaoOperadoraArrecadacaoAplicar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento(bool checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamento']"), checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento);
        }

        public bool RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamento']"));
        }

        public void MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoConsultar(bool checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoConsultar']"), checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento);
        }

        public bool RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoConsultar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoAlterar(bool checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoAlterar']"), checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento);
        }

        public bool RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoAlterar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoExcluir(bool checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoExcluir']"), checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento);
        }

        public bool RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoExcluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoIncluir(bool checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoIncluir']"), checkConfiguracoesdoestacionamentoParametrosgeraisdoestacionamento);
        }

        public bool RetornarConfiguracoesdoestacionamentoParametrosgeraisdoestacionamentoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoParametrosGeraisEstacionamentoIncluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos(bool checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressos']"), checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos);
        }

        public bool RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressos']"));
        }

        public void MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosConsultar(bool checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosConsultar']"), checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos);
        }

        public bool RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosConsultar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAlterar(bool checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosAlterar']"), checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos);
        }

        public bool RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosAlterar']"));
        }

        public void MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosExcluir(bool checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosExcluir']"), checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos);
        }

        public bool RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosExcluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosIncluir(bool checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosIncluir']"), checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos);
        }

        public bool RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosIncluir']"));
        }

        public void MarcarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAplicar(bool checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosAplicar']"), checkConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressos);
        }

        public bool RetornarConfiguracoesdoestacionamentoRegrasdeemissaodebilhetesimpressosAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkConfiguracoesdoEstacionamentoRegrasEmissaoBilhetesImpressosAplicar']"));
        }

        public void MarcarCustomizacao(bool checkCustomizacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacao']"), checkCustomizacao);
        }

        public bool RetornarCustomizacao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacao']"));
        }

        public void MarcarCustomizacaoMultimidiaConsultar(bool checkCustomizacaoConfiguracaoMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaConsultar']"), checkCustomizacaoConfiguracaoMultimidia);
        }

        public bool RetornarCustomizacaoMultimidiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaConsultar']"));
        }

        public void MarcarCustomizacaoConfiguracaoMultimidiaAlterar(bool checkCustomizacaoConfiguracaoMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaAlterar']"), checkCustomizacaoConfiguracaoMultimidia);
        }

        public bool RetornarCustomizacaoConfiguracaoMultimidiaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaAlterar']"));
        }

        public void MarcarCustomizacaoConfiguracaodeMultimidiaExcluir(bool checkCustomizacaoConfiguracaoMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaExcluir']"), checkCustomizacaoConfiguracaoMultimidia);
        }

        public bool RetornarCustomizacaoConfiguracaoMultimidiaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaExcluir']"));
        }

        public void MarcarCustomizacaoConfiguracaoMultimidiaIncluir(bool checkCustomizacaoConfiguracaoMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaIncluir']"), checkCustomizacaoConfiguracaoMultimidia);
        }

        public bool RetornarCustomizacaoConfiguracaoMultimidiaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaIncluir']"));
        }

        public void MarcarCustomizacaoConfiguracaoMultimidiaAplicar(bool checkCustomizacaoConfiguracaoMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaAplicar']"), checkCustomizacaoConfiguracaoMultimidia);
        }

        public bool RetornarCustomizacaoConfiguracaoMultimidiaAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoConfiguracaoMultimidiaAplicar']"));
        }

        public void MarcarCustomizacaoApresentacaoMultimidia(bool checkCustomizacaoConfiguracaoApresentacoesMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidia']"), checkCustomizacaoConfiguracaoApresentacoesMultimidia);
        }

        public bool RetornarCustomizacaoApresentacaoMultimidia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidia']"));
        }

        public void MarcarCustomizacaoApresentacaoMultimidiaConsultar(bool checkCustomizacaoConfiguracaoApresentacoesMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaConsultar']"), checkCustomizacaoConfiguracaoApresentacoesMultimidia);
        }

        public bool RetornarCustomizacaoApresentacaoMultimidiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaConsultar']"));
        }

        public void MarcarCustomizacaoApresentacaoMultimidiaAlterar(bool checkCustomizacaoConfiguracaoApresentacoesMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaAlterar']"), checkCustomizacaoConfiguracaoApresentacoesMultimidia);
        }

        public bool RetornarCustomizacaoApresentacaoMultimidiaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaAlterar']"));
        }

        public void MarcarCustomizacaoApresentacaoMultimidiaExcluir(bool checkCustomizacaoConfiguracaoApresentacoesMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaExcluir']"), checkCustomizacaoConfiguracaoApresentacoesMultimidia);
        }

        public bool RetornarCustomizacaoApresentacaoMultimidiaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaExcluir']"));
        }

        public void MarcarCustomizacaoApresentacaoMultimidiaIncluir(bool checkCustomizacaoConfiguracaoApresentacoesMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaIncluir']"), checkCustomizacaoConfiguracaoApresentacoesMultimidia);
        }

        public bool RetornarCustomizacaoApresentacaoMultimidiaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaIncluir']"));
        }

        public void MarcarCustomizacaoApresentacaoMultimidiaAplicar(bool checkCustomizacaoConfiguracaoApresentacoesMultimidia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaAplicar']"), checkCustomizacaoConfiguracaoApresentacoesMultimidia);
        }

        public bool RetornarCustomizacaoApresentacaoMultimidiaAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkCustomizacaoApresentacaoMultimidiaAplicar']"));
        }

        public void MarcarFinanceiro(bool checkFinanceiro)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiro']"), checkFinanceiro);
        }

        public bool RetornarFinanceiro()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiro']"));
        }

        public void MarcarFinanceiroEmitentefiscal(bool checkFinanceiroEmitentefiscal)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroEmitenteFiscal']"), checkFinanceiroEmitentefiscal);
        }

        public bool RetornarFinanceiroEmitentefiscal()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroEmitenteFiscal']"));
        }

        public void MarcarFinanceiroEmitentefiscalConsultar(bool checkFinanceiroEmitentefiscal)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalConsultar']"), checkFinanceiroEmitentefiscal);
        }

        public bool RetornarFinanceiroEmitentefiscalConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalConsultar']"));
        }

        public void MarcarFinanceiroEmitentefiscalAlterar(bool checkFinanceiroEmitentefiscal)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalAlterar']"), checkFinanceiroEmitentefiscal);
        }

        public bool RetornarFinanceiroEmitentefiscalAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalAlterar']"));
        }

        public void MarcarFinanceiroEmitentefiscalExcluir(bool checkFinanceiroEmitentefiscal)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalExcluir']"), checkFinanceiroEmitentefiscal);
        }

        public bool RetornarFinanceiroEmitentefiscalExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalExcluir']"));
        }

        public void MarcarFinanceiroEmitentefiscalIncluir(bool checkFinanceiroEmitentefiscal)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalIncluir']"), checkFinanceiroEmitentefiscal);
        }

        public bool RetornarFinanceiroEmitentefiscalIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalIncluir']"));
        }

        public void MarcarFinanceiroEmitentefiscalAplicar(bool checkFinanceiroEmitentefiscal)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalAplicar']"), checkFinanceiroEmitentefiscal);
        }

        public bool RetornarFinanceiroEmitentefiscalAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroEmitenteFiscalAplicar']"));
        }

        public void MarcarFinanceiroConfiguracaodeintegracaoTEF(bool checkFinanceiroConfiguracaodeintegracaoTEF)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEF']"), checkFinanceiroConfiguracaodeintegracaoTEF);
        }

        public bool RetornarFinanceiroConfiguracaodeintegracaoTEF()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEF']"));
        }

        public void MarcarFinanceiroConfiguracaodeintegracaoTEFConsultar(bool checkFinanceiroConfiguracaodeintegracaoTEF)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFConsultar']"), checkFinanceiroConfiguracaodeintegracaoTEF);
        }

        public bool RetornarFinanceiroConfiguracaodeintegracaoTEFConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFConsultar']"));
        }

        public void MarcarFinanceiroConfiguracaodeintegracaoTEFAlterar(bool checkFinanceiroConfiguracaodeintegracaoTEF)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFAlterar']"), checkFinanceiroConfiguracaodeintegracaoTEF);
        }

        public bool RetornarFinanceiroConfiguracaodeintegracaoTEFAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFAlterar']"));
        }

        public void MarcarFinanceiroConfiguracaodeintegracaoTEFExcluir(bool checkFinanceiroConfiguracaodeintegracaoTEF)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFExcluir']"), checkFinanceiroConfiguracaodeintegracaoTEF);
        }

        public bool RetornarFinanceiroConfiguracaodeintegracaoTEFExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFExcluir']"));
        }

        public void MarcarFinanceiroConfiguracaodeintegracaoTEFIncluir(bool checkFinanceiroConfiguracaodeintegracaoTEF)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFIncluir']"), checkFinanceiroConfiguracaodeintegracaoTEF);
        }

        public bool RetornarFinanceiroConfiguracaodeintegracaoTEFIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFIncluir']"));
        }

        public void MarcarFinanceiroConfiguracaodeintegracaoTEFAplicar(bool checkFinanceiroConfiguracaodeintegracaoTEF)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFAplicar']"), checkFinanceiroConfiguracaodeintegracaoTEF);
        }

        public bool RetornarFinanceiroConfiguracaodeintegracaoTEFAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroConfiguracaoIntegracaoTEFAplicar']"));
        }

        public void MarcarFinanceiroRegrasdeemissaoderecibos(bool checkFinanceiroRegrasdeemissaoderecibos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoRecibo']"), checkFinanceiroRegrasdeemissaoderecibos);
        }

        public bool RetornarFinanceiroRegrasdeemissaoderecibos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoRecibo']"));
        }

        public void MarcarFinanceiroRegrasdeemissaoderecibosConsultar(bool checkFinanceiroRegrasdeemissaoderecibos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboConsultar']"), checkFinanceiroRegrasdeemissaoderecibos);
        }

        public bool RetornarFinanceiroRegrasdeemissaoderecibosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboConsultar']"));
        }

        public void MarcarFinanceiroRegrasdeemissaoderecibosAlterar(bool checkFinanceiroRegrasdeemissaoderecibos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboAlterar']"), checkFinanceiroRegrasdeemissaoderecibos);
        }

        public bool RetornarFinanceiroRegrasdeemissaoderecibosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboAlterar']"));
        }

        public void MarcarFinanceiroRegrasdeemissaoderecibosExcluir(bool checkFinanceiroRegrasdeemissaoderecibos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboExcluir']"), checkFinanceiroRegrasdeemissaoderecibos);
        }

        public bool RetornarFinanceiroRegrasdeemissaoderecibosExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboExcluir']"));
        }

        public void MarcarFinanceiroRegrasdeemissaoderecibosIncluir(bool checkFinanceiroRegrasdeemissaoderecibos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboIncluir']"), checkFinanceiroRegrasdeemissaoderecibos);
        }

        public bool RetornarFinanceiroRegrasdeemissaoderecibosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboIncluir']"));
        }

        public void MarcarFinanceiroRegrasdeemissaoderecibosAplicar(bool checkFinanceiroRegrasdeemissaoderecibos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboAplicar']"), checkFinanceiroRegrasdeemissaoderecibos);
        }

        public bool RetornarFinanceiroRegrasdeemissaoderecibosAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasEmissaoReciboAplicar']"));
        }

        public void MarcarFinanceiroRegrasdefechamentodosequipamentos(bool checkFinanceiroRegrasdefechamentodosequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentos']"), checkFinanceiroRegrasdefechamentodosequipamentos);
        }

        public bool RetornarFinanceiroRegrasdefechamentodosequipamentos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentos']"));
        }

        public void MarcarFinanceiroRegrasdefechamentodosequipamentosConsultar(bool checkFinanceiroRegrasdefechamentodosequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosConsultar']"), checkFinanceiroRegrasdefechamentodosequipamentos);
        }

        public bool RetornarFinanceiroRegrasdefechamentodosequipamentosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosConsultar']"));
        }

        public void MarcarFinanceiroRegrasdefechamentodosequipamentosAlterar(bool checkFinanceiroRegrasdefechamentodosequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosAlterar']"), checkFinanceiroRegrasdefechamentodosequipamentos);
        }

        public bool RetornarFinanceiroRegrasdefechamentodosequipamentosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosAlterar']"));
        }

        public void MarcarFinanceiroRegrasdefechamentodosequipamentosExcluir(bool checkFinanceiroRegrasdefechamentodosequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosExcluir']"), checkFinanceiroRegrasdefechamentodosequipamentos);
        }

        public bool RetornarFinanceiroRegrasdefechamentodosequipamentosExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosExcluir']"));
        }

        public void MarcarFinanceiroRegrasdefechamentodosequipamentosIncluir(bool checkFinanceiroRegrasdefechamentodosequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosIncluir']"), checkFinanceiroRegrasdefechamentodosequipamentos);
        }

        public bool RetornarFinanceiroRegrasdefechamentodosequipamentosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosIncluir']"));
        }

        public void MarcarFinanceiroRegrasdefechamentodosequipamentosAplicar(bool checkFinanceiroRegrasdefechamentodosequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosAplicar']"), checkFinanceiroRegrasdefechamentodosequipamentos);
        }

        public bool RetornarFinanceiroRegrasdefechamentodosequipamentosAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegrasDeFechamentoDosEquipamentosAplicar']"));
        }

        public void MarcarFinanceiroRegrasdenumerariodeautoatendimento(bool checkFinanceiroRegrasdenumerariodeautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimento']"), checkFinanceiroRegrasdenumerariodeautoatendimento);
        }

        public bool RetornarFinanceiroRegrasdenumerariodeautoatendimento()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimento']"));
        }

        public void MarcarFinanceiroRegrasdenumerariodeautoatendimentoConsultar(bool checkFinanceiroRegrasdenumerariodeautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoConsultar']"), checkFinanceiroRegrasdenumerariodeautoatendimento);
        }

        public bool RetornarFinanceiroRegrasdenumerariodeautoatendimentoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoConsultar']"));
        }

        public void MarcarFinanceiroRegrasdenumerariodeautoatendimentoAlterar(bool checkFinanceiroRegrasdenumerariodeautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoAlterar']"), checkFinanceiroRegrasdenumerariodeautoatendimento);
        }

        public bool RetornarFinanceiroRegrasdenumerariodeautoatendimentoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoAlterar']"));
        }

        public void MarcarFinanceiroRegrasdenumerariodeautoatendimentoExcluir(bool checkFinanceiroRegrasdenumerariodeautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoExcluir']"), checkFinanceiroRegrasdenumerariodeautoatendimento);
        }

        public bool RetornarFinanceiroRegrasdenumerariodeautoatendimentoExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoExcluir']"));
        }

        public void MarcarFinanceiroRegrasdenumerariodeautoatendimentoIncluir(bool checkFinanceiroRegrasdenumerariodeautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoIncluir']"), checkFinanceiroRegrasdenumerariodeautoatendimento);
        }

        public bool RetornarFinanceiroRegrasdenumerariodeautoatendimentoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoIncluir']"));
        }

        public void MarcarFinanceiroRegrasdenumerariodeautoatendimentoAplicar(bool checkFinanceiroRegrasdenumerariodeautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoAplicar']"), checkFinanceiroRegrasdenumerariodeautoatendimento);
        }

        public bool RetornarFinanceiroRegrasdenumerariodeautoatendimentoAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegraNumerarioAutoatendimentoAplicar']"));
        }

        public void MarcarFinanceiroRegistroCambial(bool checkFinanceiroRegistroCambial)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegistroCambial']"), checkFinanceiroRegistroCambial);
        }

        public bool RetornarFinanceiroRegistroCambial()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegistroCambial']"));
        }

        public void MarcarFinanceiroRegistroCambialConsultar(bool checkFinanceiroRegistroCambial)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegistroCambialConsultar']"), checkFinanceiroRegistroCambial);
        }

        public bool RetornarFinanceiroRegistroCambialConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegistroCambialConsultar']"));
        }

        public void MarcarFinanceiroRegistroCambialAlterar(bool checkFinanceiroRegistroCambial)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkFinanceiroRegistroCambialAlterar']"), checkFinanceiroRegistroCambial);
        }

        public bool RetornarFinanceiroRegistroCambialAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkFinanceiroRegistroCambialAlterar']"));
        }

        public void MarcarInstalacoeseatualizacoes(bool checkInstalacoeseatualizacoes)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoes']"), checkInstalacoeseatualizacoes);
        }

        public bool RetornarInstalacoeseatualizacoes()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoes']"));
        }

        public void MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos(bool checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacao']"), checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos);
        }

        public bool RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacao']"));
        }

        public void MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosConsultar(bool checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoConsultar']"), checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos);
        }

        public bool RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoConsultar']"));
        }

        public void MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosAlterar(bool checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoAlterar']"), checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos);
        }

        public bool RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoAlterar']"));
        }

        public void MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosIncluir(bool checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoIncluir']"), checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos);
        }

        public bool RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoIncluir']"));
        }

        public void MarcarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosCancelar(bool checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoCancelar']"), checkInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativos);
        }

        public bool RetornarInstalacoeseatualizacoesAgendamentodeatualizacaodeaplicativosCancelar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAgendamentoAtualizacaoCancelar']"));
        }

        public void MarcarInstalacoeseatualizacoesAplicativoseversoes(bool checkInstalacoeseatualizacoesAplicativoseversoes)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoes']"), checkInstalacoeseatualizacoesAplicativoseversoes);
        }

        public bool RetornarInstalacoeseatualizacoesAplicativoseversoes()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoes']"));
        }

        public void MarcarInstalacoeseatualizacoesAplicativoseversoesConsultar(bool checkInstalacoeseatualizacoesAplicativoseversoes)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoesConsultar']"), checkInstalacoeseatualizacoesAplicativoseversoes);
        }

        public bool RetornarInstalacoeseatualizacoesAplicativoseversoesConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoesConsultar']"));
        }

        public void MarcarInstalacoeseatualizacoesAplicativoseversoesExcluir(bool checkInstalacoeseatualizacoesAplicativoseversoes)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoesExcluir']"), checkInstalacoeseatualizacoesAplicativoseversoes);
        }

        public bool RetornarInstalacoeseatualizacoesAplicativoseversoesExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoesExcluir']"));
        }

        public void MarcarInstalacoeseatualizacoesAplicativoseversoesCarregar(bool checkInstalacoeseatualizacoesAplicativoseversoes)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoesCarregar']"), checkInstalacoeseatualizacoesAplicativoseversoes);
        }

        public bool RetornarInstalacoeseatualizacoesAplicativoseversoesCarregar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesAplicativosVersoesCarregar']"));
        }

        public void MarcarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos(bool checkInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesMonitoramentoInstalacao']"), checkInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos);
        }

        public bool RetornarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesMonitoramentoInstalacao']"));
        }

        public void MarcarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosConsultar(bool checkInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesMonitoramentoInstalacaoConsultar']"), checkInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos);
        }

        public bool RetornarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesMonitoramentoInstalacaoConsultar']"));
        }

        public void MarcarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosAlterar(bool checkInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkInstalacoesEAtualizacoesMonitoramentoInstalacaoAlterar']"), checkInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentos);
        }

        public bool RetornarInstalacoeseatualizacoesMonitoramentodeinstalacoesdeequipamentosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkInstalacoesEAtualizacoesMonitoramentoInstalacaoAlterar']"));
        }

        public void MarcarOperacao(bool checkOperacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacao']"), checkOperacao);
        }

        public bool RetornarOperacao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacao']"));
        }

        public void MarcarOperacaoAgendamentodetarefasautomatizadas(bool checkOperacaoAgendamentodetarefasautomatizadas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadas']"), checkOperacaoAgendamentodetarefasautomatizadas);
        }

        public bool RetornarOperacaoAgendamentodetarefasautomatizadas()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadas']"));
        }

        public void MarcarOperacaoAgendamentodetarefasautomatizadasConsultar(bool checkOperacaoAgendamentodetarefasautomatizadas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasConsultar']"), checkOperacaoAgendamentodetarefasautomatizadas);
        }

        public bool RetornarOperacaoAgendamentodetarefasautomatizadasConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasConsultar']"));
        }

        public void MarcarOperacaoAgendamentodetarefasautomatizadasIncluir(bool checkOperacaoAgendamentodetarefasautomatizadas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasIncluir']"), checkOperacaoAgendamentodetarefasautomatizadas);
        }

        public bool RetornarOperacaoAgendamentodetarefasautomatizadasIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasIncluir']"));
        }

        public void MarcarOperacaoAgendamentodetarefasautomatizadasAlterar(bool checkOperacaoAgendamentodetarefasautomatizadas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasAlterar']"), checkOperacaoAgendamentodetarefasautomatizadas);
        }

        public bool RetornarOperacaoAgendamentodetarefasautomatizadasAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasAlterar']"));
        }

        public void MarcarOperacaoAgendamentodetarefasautomatizadasExcluir(bool checkOperacaoAgendamentodetarefasautomatizadas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasExcluir']"), checkOperacaoAgendamentodetarefasautomatizadas);
        }

        public bool RetornarOperacaoAgendamentodetarefasautomatizadasExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTarefasAutomatizadasExcluir']"));
        }

        public void MarcarOperacaoConfiguracaodemododecontingencia(bool checkOperacaoConfiguracaodemododecontingencia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoConfiguracaoModoContingencia']"), checkOperacaoConfiguracaodemododecontingencia);
        }

        public bool RetornarOperacaoConfiguracaodemododecontingencia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoConfiguracaoModoContingencia']"));
        }

        public void MarcarOperacaoConfiguracaodemododecontingenciaConsultar(bool checkOperacaoConfiguracaodemododecontingencia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoConfiguracaoModoContingenciaConsultar']"), checkOperacaoConfiguracaodemododecontingencia);
        }

        public bool RetornarOperacaoConfiguracaodemododecontingenciaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoConfiguracaoModoContingenciaConsultar']"));
        }

        public void MarcarOperacaoConfiguracaodemododecontingenciaIncluir(bool checkOperacaoConfiguracaodemododecontingencia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoConfiguracaoModoContingenciaIncluir']"), checkOperacaoConfiguracaodemododecontingencia);
        }

        public bool RetornarOperacaoConfiguracaodemododecontingenciaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoConfiguracaoModoContingenciaIncluir']"));
        }

        public void MarcarOperacaoAlteracaotemporariadotempodetolerancia(bool checkOperacaoAlteracaotemporariadotempodetolerancia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoAlteracaoTemporariaTempoTolerancia']"), checkOperacaoAlteracaotemporariadotempodetolerancia);
        }

        public bool RetornarOperacaoAlteracaotemporariadotempodetolerancia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoAlteracaoTemporariaTempoTolerancia']"));
        }

        public void MarcarOperacaoAlteracaotemporariadotempodetoleranciaConsultar(bool checkOperacaoAlteracaotemporariadotempodetolerancia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoAlteracaoTemporariaTempoToleranciaConsultar']"), checkOperacaoAlteracaotemporariadotempodetolerancia);
        }

        public bool RetornarOperacaoAlteracaotemporariadotempodetoleranciaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoAlteracaoTemporariaTempoToleranciaConsultar']"));
        }

        public void MarcarOperacaoAlteracaotemporariadotempodetoleranciaIncluir(bool checkOperacaoAlteracaotemporariadotempodetolerancia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoAlteracaoTemporariaTempoToleranciaIncluir']"), checkOperacaoAlteracaotemporariadotempodetolerancia);
        }

        public bool RetornarOperacaoAlteracaotemporariadotempodetoleranciaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoAlteracaoTemporariaTempoToleranciaIncluir']"));
        }

        public void MarcarOperacaoCargaparavalidadormanualdeestadia(bool checkOperacaoCargaparavalidadormanualdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoCargaValidadorManualEstadia']"), checkOperacaoCargaparavalidadormanualdeestadia);
        }

        public bool RetornarOperacaoCargaparavalidadormanualdeestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoCargaValidadorManualEstadia']"));
        }

        public void MarcarOperacaoCargaparavalidadormanualdeestadiaConsultar(bool checkOperacaoCargaparavalidadormanualdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoCargaValidadorManualEstadiaConsultar']"), checkOperacaoCargaparavalidadormanualdeestadia);
        }

        public bool RetornarOperacaoCargaparavalidadormanualdeestadiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoCargaValidadorManualEstadiaConsultar']"));
        }

        public void MarcarOperacaoCargaparavalidadormanualdeestadiaIncluir(bool checkOperacaoCargaparavalidadormanualdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoCargaValidadorManualEstadiaIncluir']"), checkOperacaoCargaparavalidadormanualdeestadia);
        }

        public bool RetornarOperacaoCargaparavalidadormanualdeestadiaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoCargaValidadorManualEstadiaIncluir']"));
        }

        public void MarcarOperacaoClientesdoestacionamento(bool checkOperacaoClientesdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoClienteEstacionamento']"), checkOperacaoClientesdoestacionamento);
        }

        public bool RetornarOperacaoClientesdoestacionamento()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoClienteEstacionamento']"));
        }

        public void MarcarOperacaoClientesdoestacionamentoConsultar(bool checkOperacaoClientesdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoConsultar']"), checkOperacaoClientesdoestacionamento);
        }

        public bool RetornarOperacaoClientesdoestacionamentoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoConsultar']"));
        }

        public void MarcarOperacaoClientesdoestacionamentoIncluir(bool checkOperacaoClientesdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoIncluir']"), checkOperacaoClientesdoestacionamento);
        }

        public bool RetornarOperacaoClientesdoestacionamentoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoIncluir']"));
        }

        public void MarcarOperacaoClientesdoestacionamentoAlterar(bool checkOperacaoClientesdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoAlterar']"), checkOperacaoClientesdoestacionamento);
        }

        public bool RetornarOperacaoClientesdoestacionamentoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoAlterar']"));
        }

        public void MarcarOperacaoClientesdoestacionamentoExcluir(bool checkOperacaoClientesdoestacionamento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoExcluir']"), checkOperacaoClientesdoestacionamento);
        }

        public bool RetornarOperacaoClientesdoestacionamentoExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoClienteEstacionamentoExcluir']"));
        }

        public void MarcarOperacaoContratosdeestadia(bool checkOperacaoContratosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoContratosEstadia']"), checkOperacaoContratosdeestadia);
        }

        public bool RetornarOperacaoContratosdeestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoContratosEstadia']"));
        }

        public void MarcarOperacaoContratosdeestadiaConsultar(bool checkOperacaoContratosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoContratosEstadiaConsultar']"), checkOperacaoContratosdeestadia);
        }

        public bool RetornarOperacaoContratosdeestadiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoContratosEstadiaConsultar']"));
        }

        public void MarcarOperacaoContratosdeestadiaIncluir(bool checkOperacaoContratosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoContratosEstadiaIncluir']"), checkOperacaoContratosdeestadia);
        }

        public bool RetornarOperacaoContratosdeestadiaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoContratosEstadiaIncluir']"));
        }

        public void MarcarOperacaoContratosdeestadiaAlterar(bool checkOperacaoContratosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoContratosEstadiaAlterar']"), checkOperacaoContratosdeestadia);
        }

        public bool RetornarOperacaoContratosdeestadiaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoContratosEstadiaAlterar']"));
        }

        public void MarcarOperacaoContratosdeestadiaExcluir(bool checkOperacaoContratosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoContratosEstadiaExcluir']"), checkOperacaoContratosdeestadia);
        }

        public bool RetornarOperacaoContratosdeestadiaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoContratosEstadiaExcluir']"));
        }

        public void MarcarOperacaoControledeequipamentos(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControle']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControle']"));
        }

        public void MarcarOperacaoControledeequipamentosConsultar(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControleConsultar']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControleConsultar']"));
        }

        public void MarcarOperacaoControledeequipamentosAcoesdecancela(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControleOperacoesCancela']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentosAcoesdecancela()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControleOperacoesCancela']"));
        }

        public void MarcarOperacaoControledeequipamentosComandosauxiliares(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControleComandosAuxiliares']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentosComandosauxiliares()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControleComandosAuxiliares']"));
        }

        public void MarcarOperacaoControledeequipamentosEntradamanual(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControleEntradaManual']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentosEntradamanual()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControleEntradaManual']"));
        }

        public void MarcarOperacaoControledeequipamentosAssociarMidiaPerdida(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControleAssociarMidiaPerdida']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentosAssociarMidiaPerdida()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControleAssociarMidiaPerdida']"));
        }

        public void MarcarOperacaoControledeequipamentosSaidamanual(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControleSaidaManual']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentosSaidamanual()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControleSaidaManual']"));
        }

        public void MarcarOperacaoControledeequipamentosPassagemmanual(bool checkOperacaoControledeequipamentos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControlePassagemManual']"), checkOperacaoControledeequipamentos);
        }

        public bool RetornarOperacaoControledeequipamentosPassagemmanual()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControlePassagemManual']"));
        }

        public void MarcarOperacaoControledeequipamentosCancelarValidacao(bool checkOperacaoControleCancelarValidacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoControleCancelarValidacao']"), checkOperacaoControleCancelarValidacao);
        }

        public bool RetornarOperacaoControledeequipamentosCancelarValidacao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoControleCancelarValidacao']"));
        }

        public void MarcarOperacaoEstadiasabertas(bool checkOperacaoEstadiasabertas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoEstadiasAbertas']"), checkOperacaoEstadiasabertas);
        }

        public bool RetornarOperacaoEstadiasabertas()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoEstadiasAbertas']"));
        }

        public void MarcarOperacaoEstadiasabertasConsultar(bool checkOperacaoEstadiasabertas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoEstadiasAbertasConsultar']"), checkOperacaoEstadiasabertas);
        }

        public bool RetornarOperacaoEstadiasabertasConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoEstadiasAbertasConsultar']"));
        }

        public void MarcarOperacaoRegrasdelimpezadepatioautomatica(bool checkOperacaoRegrasdelimpezadepatioautomatica)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomatica']"), checkOperacaoRegrasdelimpezadepatioautomatica);
        }

        public bool RetornarOperacaoRegrasdelimpezadepatioautomatica()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomatica']"));
        }

        public void MarcarOperacaoRegrasdelimpezadepatioautomaticaConsultar(bool checkOperacaoRegrasdelimpezadepatioautomatica)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaConsultar']"), checkOperacaoRegrasdelimpezadepatioautomatica);
        }

        public bool RetornarOperacaoRegrasdelimpezadepatioautomaticaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaConsultar']"));
        }

        public void MarcarOperacaoRegrasdelimpezadepatioautomaticaIncluir(bool checkOperacaoRegrasdelimpezadepatioautomatica)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaIncluir']"), checkOperacaoRegrasdelimpezadepatioautomatica);
        }

        public bool RetornarOperacaoRegrasdelimpezadepatioautomaticaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaIncluir']"));
        }

        public void MarcarOperacaoRegrasdelimpezadepatioautomaticaAlterar(bool checkOperacaoRegrasdelimpezadepatioautomatica)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaAlterar']"), checkOperacaoRegrasdelimpezadepatioautomatica);
        }

        public bool RetornarOperacaoRegrasdelimpezadepatioautomaticaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaAlterar']"));
        }

        public void MarcarOperacaoRegrasdelimpezadepatioautomaticaExcluir(bool checkOperacaoRegrasdelimpezadepatioautomatica)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaExcluir']"), checkOperacaoRegrasdelimpezadepatioautomatica);
        }

        public bool RetornarOperacaoRegrasdelimpezadepatioautomaticaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoRegrasLimpezaPatioAutomaticaExcluir']"));
        }

        public void MarcarOperacaoMidiasperdidaspreautorizadas(bool checkOperacaoMidiasperdidaspreautorizadas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoMidiasPerdidasPreAutorizadas']"), checkOperacaoMidiasperdidaspreautorizadas);
        }

        public bool RetornarOperacaoMidiasperdidaspreautorizadas()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoMidiasPerdidasPreAutorizadas']"));
        }

        public void MarcarOperacaoMidiasperdidaspreautorizadasConsultar(bool checkOperacaoMidiasperdidaspreautorizadas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoMidiasPerdidasPreAutorizadasConsultar']"), checkOperacaoMidiasperdidaspreautorizadas);
        }

        public bool RetornarOperacaoMidiasperdidaspreautorizadasConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoMidiasPerdidasPreAutorizadasConsultar']"));
        }

        public void MarcarOperacaoOperacaodemultiplascancelas(bool checkOperacaoOperacaodemultiplascancelas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoOperacaoMultiplasCancelas']"), checkOperacaoOperacaodemultiplascancelas);
        }

        public bool RetornarOperacaoOperacaodemultiplascancelas()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoOperacaoMultiplasCancelas']"));
        }

        public void MarcarOperacaoOperacaodemultiplascancelasConsultar(bool checkOperacaoOperacaodemultiplascancelas)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoOperacaoMultiplasCancelasConsultar']"), checkOperacaoOperacaodemultiplascancelas);
        }

        public bool RetornarOperacaoOperacaodemultiplascancelasConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoOperacaoMultiplasCancelasConsultar']"));
        }

        public void MarcarOperacaoTiposdeocorrenciasnasestadia(bool checkOperacaoTiposdeocorrenciasnasestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadia']"), checkOperacaoTiposdeocorrenciasnasestadia);
        }

        public bool RetornarOperacaoTiposdeocorrenciasnasestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadia']"));
        }

        public void MarcarOperacaoTiposdeocorrenciasnasestadiaConsultar(bool checkOperacaoTiposdeocorrenciasnasestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaConsultar']"), checkOperacaoTiposdeocorrenciasnasestadia);
        }

        public bool RetornarOperacaoTiposdeocorrenciasnasestadiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaConsultar']"));
        }

        public void MarcarOperacaoTiposdeocorrenciasnasestadiaIncluir(bool checkOperacaoTiposdeocorrenciasnasestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaIncluir']"), checkOperacaoTiposdeocorrenciasnasestadia);
        }

        public bool RetornarOperacaoTiposdeocorrenciasnasestadiaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaIncluir']"));
        }

        public void MarcarOperacaoTiposdeocorrenciasnasestadiaAlterar(bool checkOperacaoTiposdeocorrenciasnasestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaAlterar']"), checkOperacaoTiposdeocorrenciasnasestadia);
        }

        public bool RetornarOperacaoTiposdeocorrenciasnasestadiaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaAlterar']"));
        }

        public void MarcarOperacaoTiposdeocorrenciasnasestadiaExcluir(bool checkOperacaoTiposdeocorrenciasnasestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaExcluir']"), checkOperacaoTiposdeocorrenciasnasestadia);
        }

        public bool RetornarOperacaoTiposdeocorrenciasnasestadiaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoTipoOcorrenciaEstadiaExcluir']"));
        }

        public void MarcarOperacaoUsuariosnaoautorizados(bool checkOperacaoUsuariosnaoautorizados)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizados']"), checkOperacaoUsuariosnaoautorizados);
        }

        public bool RetornarOperacaoUsuariosnaoautorizados()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizados']"));
        }

        public void MarcarOperacaoUsuariosnaoautorizadosConsultar(bool checkOperacaoUsuariosnaoautorizados)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosConsultar']"), checkOperacaoUsuariosnaoautorizados);
        }

        public bool RetornarOperacaoUsuariosnaoautorizadosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosConsultar']"));
        }

        public void MarcarOperacaoUsuariosnaoautorizadosIncluir(bool checkOperacaoUsuariosnaoautorizados)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosIncluir']"), checkOperacaoUsuariosnaoautorizados);
        }

        public bool RetornarOperacaoUsuariosnaoautorizadosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosIncluir']"));
        }

        public void MarcarOperacaoUsuariosnaoautorizadosAlterar(bool checkOperacaoUsuariosnaoautorizados)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosAlterar']"), checkOperacaoUsuariosnaoautorizados);
        }

        public bool RetornarOperacaoUsuariosnaoautorizadosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosAlterar']"));
        }

        public void MarcarOperacaoUsuariosnaoautorizadosExcluir(bool checkOperacaoUsuariosnaoautorizados)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosExcluir']"), checkOperacaoUsuariosnaoautorizados);
        }

        public bool RetornarOperacaoUsuariosnaoautorizadosExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoUsuariosNaoAutorizadosExcluir']"));
        }

        public void MarcarOperacaoCapturasLPR(bool checkOperacaoCapturasLPR)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoCapturasLPR']"), checkOperacaoCapturasLPR);
        }

        public bool RetornarOperacaoCapturasLPR()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoCapturasLPR']"));
        }

        public void MarcarOperacaoCapturasLPRConsultar(bool checkOperacaoCapturasLPR)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoCapturasLPRConsultar']"), checkOperacaoCapturasLPR);
        }

        public bool RetornarOperacaoCapturasLPRConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoCapturasLPRConsultar']"));
        }

        public void MarcarOperacaoCapturasLPRAlterar(bool checkOperacaoCapturasLPR)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoCapturasLPRAlterar']"), checkOperacaoCapturasLPR);
        }

        public bool RetornarOperacaoCapturasLPRAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoCapturasLPRAlterar']"));
        }

        public void MarcarOperacaoAnalisarmidiadeoperacao(bool checkOperacaoAnalisarmidiadeoperacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoAnalisarMidiaOperacao']"), checkOperacaoAnalisarmidiadeoperacao);
        }

        public bool RetornarOperacaoAnalisarmidiadeoperacao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoAnalisarMidiaOperacao']"));
        }

        public void MarcarOperacaoAnalisarmidiadeoperacaoConsultar(bool checkOperacaoAnalisarmidiadeoperacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkOperacaoAnalisarMidiaOperacaoConsultar']"), checkOperacaoAnalisarmidiadeoperacao);
        }

        public bool RetornarOperacaoAnalisarmidiadeoperacaoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkOperacaoAnalisarMidiaOperacaoConsultar']"));
        }

        public void MarcarProdutosdeestadia(bool checkProdutosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadia']"), checkProdutosdeestadia);
        }

        public bool RetornarProdutosdeestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadia']"));
        }

        public void MarcarProdutosdeestadiaEstruturasdetabelasdecobranca(bool checkProdutosdeestadiaEstruturasdetabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobranca']"), checkProdutosdeestadiaEstruturasdetabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaEstruturasdetabelasdecobranca()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobranca']"));
        }

        public void MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaConsultar(bool checkProdutosdeestadiaEstruturasdetabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaConsultar']"), checkProdutosdeestadiaEstruturasdetabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaConsultar']"));
        }

        public void MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaIncluir(bool checkProdutosdeestadiaEstruturasdetabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaIncluir']"), checkProdutosdeestadiaEstruturasdetabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaIncluir']"));
        }

        public void MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaAlterar(bool checkProdutosdeestadiaEstruturasdetabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaAlterar']"), checkProdutosdeestadiaEstruturasdetabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaAlterar']"));
        }

        public void MarcarProdutosdeestadiaEstruturasdetabelasdecobrancaExcluir(bool checkProdutosdeestadiaEstruturasdetabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaExcluir']"), checkProdutosdeestadiaEstruturasdetabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaEstruturasdetabelasdecobrancaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaEstruturaTabelaCobrancaExcluir']"));
        }

        public void MarcarProdutosdeestadiaProdutosdeestadia(bool checkProdutosdeestadiaProdutosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadia']"), checkProdutosdeestadiaProdutosdeestadia);
        }

        public bool RetornarProdutosdeestadiaProdutosdeestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadia']"));
        }

        public void MarcarProdutosdeestadiaProdutosdeestadiaConsultar(bool checkProdutosdeestadiaProdutosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaConsultar']"), checkProdutosdeestadiaProdutosdeestadia);
        }

        public bool RetornarProdutosdeestadiaProdutosdeestadiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaConsultar']"));
        }

        public void MarcarProdutosdeestadiaProdutosdeestadiaIncluir(bool checkProdutosdeestadiaProdutosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaIncluir']"), checkProdutosdeestadiaProdutosdeestadia);
        }

        public bool RetornarProdutosdeestadiaProdutosdeestadiaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaIncluir']"));
        }

        public void MarcarProdutosdeestadiaProdutosdeestadiaAlterar(bool checkProdutosdeestadiaProdutosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaAlterar']"), checkProdutosdeestadiaProdutosdeestadia);
        }

        public bool RetornarProdutosdeestadiaProdutosdeestadiaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaAlterar']"));
        }

        public void MarcarProdutosdeestadiaProdutosdeestadiaExcluir(bool checkProdutosdeestadiaProdutosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaExcluir']"), checkProdutosdeestadiaProdutosdeestadia);
        }

        public bool RetornarProdutosdeestadiaProdutosdeestadiaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaExcluir']"));
        }

        public void MarcarProdutosdeestadiaProdutosdeestadiaAplicar(bool checkProdutosdeestadiaProdutosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaAplicar']"), checkProdutosdeestadiaProdutosdeestadia);
        }

        public bool RetornarProdutosdeestadiaProdutosdeestadiaAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaProdutoEstadiaAplicar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeacesso(bool checkProdutosdeestadiaRegrasdeacesso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcesso']"), checkProdutosdeestadiaRegrasdeacesso);
        }

        public bool RetornarProdutosdeestadiaRegrasdeacesso()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcesso']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeacessoConsultar(bool checkProdutosdeestadiaRegrasdeacesso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoConsultar']"), checkProdutosdeestadiaRegrasdeacesso);
        }

        public bool RetornarProdutosdeestadiaRegrasdeacessoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoConsultar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeacessoIncluir(bool checkProdutosdeestadiaRegrasdeacesso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoIncluir']"), checkProdutosdeestadiaRegrasdeacesso);
        }

        public bool RetornarProdutosdeestadiaRegrasdeacessoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoIncluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeacessoAlterar(bool checkProdutosdeestadiaRegrasdeacesso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoAlterar']"), checkProdutosdeestadiaRegrasdeacesso);
        }

        public bool RetornarProdutosdeestadiaRegrasdeacessoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoAlterar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeacessoExcluir(bool checkProdutosdeestadiaRegrasdeacesso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoExcluir']"), checkProdutosdeestadiaRegrasdeacesso);
        }

        public bool RetornarProdutosdeestadiaRegrasdeacessoExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasAcessoExcluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdecobranca(bool checkProdutosdeestadiaRegrasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobranca']"), checkProdutosdeestadiaRegrasdecobranca);
        }

        public bool RetornarProdutosdeestadiaRegrasdecobranca()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobranca']"));
        }

        public void MarcarProdutosdeestadiaRegrasdecobrancaConsultar(bool checkProdutosdeestadiaRegrasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaConsultar']"), checkProdutosdeestadiaRegrasdecobranca);
        }

        public bool RetornarProdutosdeestadiaRegrasdecobrancaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaConsultar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdecobrancaIncluir(bool checkProdutosdeestadiaRegrasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaIncluir']"), checkProdutosdeestadiaRegrasdecobranca);
        }

        public bool RetornarProdutosdeestadiaRegrasdecobrancaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaIncluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdecobrancaAlterar(bool checkProdutosdeestadiaRegrasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaAlterar']"), checkProdutosdeestadiaRegrasdecobranca);
        }

        public bool RetornarProdutosdeestadiaRegrasdecobrancaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaAlterar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdecobrancaExcluir(bool checkProdutosdeestadiaRegrasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaExcluir']"), checkProdutosdeestadiaRegrasdecobranca);
        }

        public bool RetornarProdutosdeestadiaRegrasdecobrancaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaExcluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdecobrancaAplicar(bool checkProdutosdeestadiaRegrasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaAplicar']"), checkProdutosdeestadiaRegrasdecobranca);
        }

        public bool RetornarProdutosdeestadiaRegrasdecobrancaAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasCobrancaAplicar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeDescontos(bool checkProdutosdeestadiaRegrasdeDescontos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasDesconto']"), checkProdutosdeestadiaRegrasdeDescontos);
        }

        public bool RetornarProdutosdeestadiaRegrasdeDescontos()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasDesconto']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeDescontosConsultar(bool checkProdutosdeestadiaRegrasdeDescontos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoConsultar']"), checkProdutosdeestadiaRegrasdeDescontos);
        }

        public bool RetornarProdutosdeestadiaRegrasdeDescontosConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoConsultar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeDescontosIncluir(bool checkProdutosdeestadiaRegrasdeDescontos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoIncluir']"), checkProdutosdeestadiaRegrasdeDescontos);
        }

        public bool RetornarProdutosdeestadiaRegrasdeDescontosIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoIncluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeDescontosAlterar(bool checkProdutosdeestadiaRegrasdeDescontos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoAlterar']"), checkProdutosdeestadiaRegrasdeDescontos);
        }

        public bool RetornarProdutosdeestadiaRegrasdeDescontosAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoAlterar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeDescontosExcluir(bool checkProdutosdeestadiaRegrasdeDescontos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoExcluir']"), checkProdutosdeestadiaRegrasdeDescontos);
        }

        public bool RetornarProdutosdeestadiaRegrasdeDescontosExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoExcluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdeDescontosAplicar(bool checkProdutosdeestadiaRegrasdeDescontos)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoAplicar']"), checkProdutosdeestadiaRegrasdeDescontos);
        }

        public bool RetornarProdutosdeestadiaRegrasdeDescontosAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegrasDescontoAplicar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdemidiaperdida(bool checkProdutosdeestadiaRegrasdemidiaperdida)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdida']"), checkProdutosdeestadiaRegrasdemidiaperdida);
        }

        public bool RetornarProdutosdeestadiaRegrasdemidiaperdida()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdida']"));
        }

        public void MarcarProdutosdeestadiaRegrasdemidiaperdidaConsultar(bool checkProdutosdeestadiaRegrasdemidiaperdida)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaConsultar']"), checkProdutosdeestadiaRegrasdemidiaperdida);
        }

        public bool RetornarProdutosdeestadiaRegrasdemidiaperdidaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaConsultar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdemidiaperdidaIncluir(bool checkProdutosdeestadiaRegrasdemidiaperdida)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaIncluir']"), checkProdutosdeestadiaRegrasdemidiaperdida);
        }

        public bool RetornarProdutosdeestadiaRegrasdemidiaperdidaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaIncluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdemidiaperdidaAlterar(bool checkProdutosdeestadiaRegrasdemidiaperdida)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaAlterar']"), checkProdutosdeestadiaRegrasdemidiaperdida);
        }

        public bool RetornarProdutosdeestadiaRegrasdemidiaperdidaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaAlterar']"));
        }

        public void MarcarProdutosdeestadiaRegrasdemidiaperdidaExcluir(bool checkProdutosdeestadiaRegrasdemidiaperdida)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaExcluir']"), checkProdutosdeestadiaRegrasdemidiaperdida);
        }

        public bool RetornarProdutosdeestadiaRegrasdemidiaperdidaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaExcluir']"));
        }

        public void MarcarProdutosdeestadiaRegrasdemidiaperdidaAplicar(bool checkProdutosdeestadiaRegrasdemidiaperdida)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaAplicar']"), checkProdutosdeestadiaRegrasdemidiaperdida);
        }

        public bool RetornarProdutosdeestadiaRegrasdemidiaperdidaAplicar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaRegraMidiaPerdidaAplicar']"));
        }

        public void MarcarProdutosdeestadiaTabelasdecobranca(bool checkProdutosdeestadiaTabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobranca']"), checkProdutosdeestadiaTabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaTabelasdecobranca()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobranca']"));
        }

        public void MarcarProdutosdeestadiaTabelasdecobrancaConsultar(bool checkProdutosdeestadiaTabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaConsultar']"), checkProdutosdeestadiaTabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaTabelasdecobrancaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaConsultar']"));
        }

        public void MarcarProdutosdeestadiaTabelasdecobrancaIncluir(bool checkProdutosdeestadiaTabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaIncluir']"), checkProdutosdeestadiaTabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaTabelasdecobrancaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaIncluir']"));
        }

        public void MarcarProdutosdeestadiaTabelasdecobrancaAlterar(bool checkProdutosdeestadiaTabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaAlterar']"), checkProdutosdeestadiaTabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaTabelasdecobrancaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaAlterar']"));
        }

        public void MarcarProdutosdeestadiaTabelasdecobrancaExcluir(bool checkProdutosdeestadiaTabelasdecobranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaExcluir']"), checkProdutosdeestadiaTabelasdecobranca);
        }

        public bool RetornarProdutosdeestadiaTabelasdecobrancaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTabelaCobrancaExcluir']"));
        }

        public void MarcarProdutosdeestadiaTiposdedesconto(bool checkProdutosdeestadiaTiposdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTipoDesconto']"), checkProdutosdeestadiaTiposdedesconto);
        }

        public bool RetornarProdutosdeestadiaTiposdedesconto()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTipoDesconto']"));
        }

        public void MarcarProdutosdeestadiaTiposdedescontoConsultar(bool checkProdutosdeestadiaTiposdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTipoDescontoConsultar']"), checkProdutosdeestadiaTiposdedesconto);
        }

        public bool RetornarProdutosdeestadiaTiposdedescontoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTipoDescontoConsultar']"));
        }

        public void MarcarProdutosdeestadiaTiposdedescontoAlterar(bool checkProdutosdeestadiaTiposdedesconto)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkProdutoEstadiaTipoDescontoAlterar']"), checkProdutosdeestadiaTiposdedesconto);
        }

        public bool RetornarProdutosdeestadiaTiposdedescontoAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkProdutoEstadiaTipoDescontoAlterar']"));
        }

        public void MarcarRelatoriospadrao(bool checkRelatoriospadrao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroes']"), checkRelatoriospadrao);
        }

        public bool RetornarRelatoriospadrao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroes']"));
        }

        public void MarcarRelatoriospadraoDocumentosfiscais(bool checkRelatoriospadraoDocumentosfiscais)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesDocumentosFiscais']"), checkRelatoriospadraoDocumentosfiscais);
        }

        public bool RetornarRelatoriospadraoDocumentosfiscais()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesDocumentosFiscais']"));
        }

        public void MarcarRelatoriospadraoDocumentosfiscaisConsultar(bool checkRelatoriospadraoDocumentosfiscais)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesDocumentosFiscaisConsultar']"), checkRelatoriospadraoDocumentosfiscais);
        }

        public bool RetornarRelatoriospadraoDocumentosfiscaisConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesDocumentosFiscaisConsultar']"));
        }

        public void MarcarRelatoriospadraoEstadias(bool checkRelatoriospadraoEstadias)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesEstadias']"), checkRelatoriospadraoEstadias);
        }

        public bool RetornarRelatoriospadraoEstadias()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesEstadias']"));
        }

        public void MarcarRelatoriospadraoEstadiasConsultar(bool checkRelatoriospadraoEstadias)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesEstadiasConsultar']"), checkRelatoriospadraoEstadias);
        }

        public bool RetornarRelatoriospadraoEstadiasConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesEstadiasConsultar']"));
        }

        public void MarcarRelatoriospadraoEventosdeestadia(bool checkRelatoriospadraoEventosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesEventosEstadia']"), checkRelatoriospadraoEventosdeestadia);
        }

        public bool RetornarRelatoriospadraoEventosdeestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesEventosEstadia']"));
        }

        public void MarcarRelatoriospadraoEventosdeestadiaConsultar(bool checkRelatoriospadraoEventosdeestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesEventosEstadiaConsultar']"), checkRelatoriospadraoEventosdeestadia);
        }

        public bool RetornarRelatoriospadraoEventosdeestadiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesEventosEstadiaConsultar']"));
        }

        public void MarcarRelatoriospadraoEventosdesistema(bool checkRelatoriospadraoEventosdesistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesEventosSistema']"), checkRelatoriospadraoEventosdesistema);
        }

        public bool RetornarRelatoriospadraoEventosdesistema()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesEventosSistema']"));
        }

        public void MarcarRelatoriospadraoEventosdesistemaConsultar(bool checkRelatoriospadraoEventosdesistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesEventosSistemaConsultar']"), checkRelatoriospadraoEventosdesistema);
        }

        public bool RetornarRelatoriospadraoEventosdesistemaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesEventosSistemaConsultar']"));
        }

        public void MarcarRelatoriospadraoFechamentogeral(bool checkRelatoriospadraoFechamentogeral)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesFechamentoGeral']"), checkRelatoriospadraoFechamentogeral);
        }

        public bool RetornarRelatoriospadraoFechamentogeral()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesFechamentoGeral']"));
        }

        public void MarcarRelatoriospadraoFechamentogeralConsultar(bool checkRelatoriospadraoFechamentogeral)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesFechamentoGeralConsultar']"), checkRelatoriospadraoFechamentogeral);
        }

        public bool RetornarRelatoriospadraoFechamentogeralConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesFechamentoGeralConsultar']"));
        }

        public void MarcarRelatoriospadraoFluxoporperiodo(bool checkRelatoriospadraoFluxoporperiodo)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesFluxoPorPeriodo']"), checkRelatoriospadraoFluxoporperiodo);
        }

        public bool RetornarRelatoriospadraoFluxoporperiodo()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesFluxoPorPeriodo']"));
        }

        public void MarcarRelatoriospadraoFluxoporperiodoConsultar(bool checkRelatoriospadraoFluxoporperiodo)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesFluxoPorPeriodoConsultar']"), checkRelatoriospadraoFluxoporperiodo);
        }

        public bool RetornarRelatoriospadraoFluxoporperiodoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesFluxoPorPeriodoConsultar']"));
        }

        public void MarcarRelatoriospadraoIsencoes(bool checkRelatoriospadraoIsencoes)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesIsencoes']"), checkRelatoriospadraoIsencoes);
        }

        public bool RetornarRelatoriospadraoIsencoes()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesIsencoes']"));
        }

        public void MarcarRelatoriospadraoIsencoesConsultar(bool checkRelatoriospadraoIsencoes)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesIsencoesConsultar']"), checkRelatoriospadraoIsencoes);
        }

        public bool RetornarRelatoriospadraoIsencoesConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesIsencoesConsultar']"));
        }

        public void MarcarRelatoriospadraoLogdeauditoria(bool checkRelatoriospadraoLogdeauditoria)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesLogAuditoria']"), checkRelatoriospadraoLogdeauditoria);
        }

        public bool RetornarRelatoriospadraoLogdeauditoria()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesLogAuditoria']"));
        }

        public void MarcarRelatoriospadraoLogdeauditoriaConsultar(bool checkRelatoriospadraoLogdeauditoria)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesLogAuditoriaConsultar']"), checkRelatoriospadraoLogdeauditoria);
        }

        public bool RetornarRelatoriospadraoLogdeauditoriaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesLogAuditoriaConsultar']"));
        }

        public void MarcarRelatoriospadraoLognumerarioautoatendimento(bool checkRelatoriospadraoLognumerarioautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesLogNumerarioAutoatendimento']"), checkRelatoriospadraoLognumerarioautoatendimento);
        }

        public bool RetornarRelatoriospadraoLognumerarioautoatendimento()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesLogNumerarioAutoatendimento']"));
        }

        public void MarcarRelatoriospadraoLognumerarioautoatendimentoConsultar(bool checkRelatoriospadraoLognumerarioautoatendimento)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesLogNumerarioAutoatendimentoConsultar']"), checkRelatoriospadraoLognumerarioautoatendimento);
        }

        public bool RetornarRelatoriospadraoLognumerarioautoatendimentoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesLogNumerarioAutoatendimentoConsultar']"));
        }

        public void MarcarRelatoriospadraoPermanencia(bool checkRelatoriospadraoPermanencia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesPermanencia']"), checkRelatoriospadraoPermanencia);
        }

        public bool RetornarRelatoriospadraoPermanencia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesPermanencia']"));
        }

        public void MarcarRelatoriospadraoPermanenciaConsultar(bool checkRelatoriospadraoPermanencia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesPermanenciaConsultar']"), checkRelatoriospadraoPermanencia);
        }

        public bool RetornarRelatoriospadraoPermanenciaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesPermanenciaConsultar']"));
        }

        public void MarcarRelatoriospadraoReceitatipodeprodutoestadia(bool checkRelatoriospadraoReceitatipodeprodutoestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesReceitaTipoProdutoEstadia']"), checkRelatoriospadraoReceitatipodeprodutoestadia);
        }

        public bool RetornarRelatoriospadraoReceitatipodeprodutoestadia()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesReceitaTipoProdutoEstadia']"));
        }

        public void MarcarRelatoriospadraoReceitatipodeprodutoestadiaConsultar(bool checkRelatoriospadraoReceitatipodeprodutoestadia)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesReceitaTipoProdutoEstadiaConsultar']"), checkRelatoriospadraoReceitatipodeprodutoestadia);
        }

        public bool RetornarRelatoriospadraoReceitatipodeprodutoestadiaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesReceitaTipoProdutoEstadiaConsultar']"));
        }

        public void MarcarRelatoriospadraoReceitatipodeprodutoestadiaCancelamentoValidacao(bool checkRelatoriosPadroesCancelamentoValidacao)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesCancelamentoValidacao']"), checkRelatoriosPadroesCancelamentoValidacao);
        }

        public bool RetornarRelatoriospadraoReceitatipodeprodutoestadiaCancelamentoValidacao()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesCancelamentoValidacao']"));
        }

        public void MarcarRelatoriospadraoReceitatipodeprodutoestadiaCancelarValidacaoConsultar(bool checkRelatoriosPadroesCancelamentoValidacaoConsultar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosPadroesCancelamentoValidacaoConsultar']"), checkRelatoriosPadroesCancelamentoValidacaoConsultar);
        }

        public bool RetornarRelatoriospadraoReceitatipodeprodutoestadiaCancelarValidacaoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosPadroesCancelamentoValidacaoConsultar']"));
        }

        public void MarcarSeguranca(bool checkSeguranca)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSeguranca']"), checkSeguranca);
        }

        public bool RetornarSeguranca()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSeguranca']"));
        }

        public void MarcarSegurancaLicencasdeuso(bool checkSegurancaLicencasdeuso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaLicencasUso']"), checkSegurancaLicencasdeuso);
        }

        public bool RetornarSegurancaLicencasdeuso()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaLicencasUso']"));
        }

        public void MarcarSegurancaLicencasdeusoConsultar(bool checkSegurancaLicencasdeuso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaLicencasUsoConsultar']"), checkSegurancaLicencasdeuso);
        }

        public bool RetornarSegurancaLicencasdeusoConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaLicencasUsoConsultar']"));
        }

        public void MarcarSegurancaLicencasdeusoIncluir(bool checkSegurancaLicencasdeuso)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaLicencasUsoIncluir']"), checkSegurancaLicencasdeuso);
        }

        public bool RetornarSegurancaLicencasdeusoIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaLicencasUsoIncluir']"));
        }

        public void MarcarSegurancaPerfisdeacessodosistema(bool checkSegurancaPerfisdeacessodosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistema']"), checkSegurancaPerfisdeacessodosistema);
        }

        public bool RetornarSegurancaPerfisdeacessodosistema()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistema']"));
        }

        public void MarcarSegurancaPerfisdeacessodosistemaConsultar(bool checkSegurancaPerfisdeacessodosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaConsultar']"), checkSegurancaPerfisdeacessodosistema);
        }

        public bool RetornarSegurancaPerfisdeacessodosistemaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaConsultar']"));
        }

        public void MarcarSegurancaPerfisdeacessodosistemaIncluir(bool checkSegurancaPerfisdeacessodosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaIncluir']"), checkSegurancaPerfisdeacessodosistema);
        }

        public bool RetornarSegurancaPerfisdeacessodosistemaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaIncluir']"));
        }

        public void MarcarSegurancaPerfisdeacessodosistemaAlterar(bool checkSegurancaPerfisdeacessodosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaAlterar']"), checkSegurancaPerfisdeacessodosistema);
        }

        public bool RetornarSegurancaPerfisdeacessodosistemaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaAlterar']"));
        }

        public void MarcarSegurancaPerfisdeacessodosistemaExcluir(bool checkSegurancaPerfisdeacessodosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaExcluir']"), checkSegurancaPerfisdeacessodosistema);
        }

        public bool RetornarSegurancaPerfisdeacessodosistemaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaPerfisAcessoSistemaExcluir']"));
        }

        public void MarcarSegurancaUsuariosdosistema(bool checkSegurancaUsuariosdosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaUsuariosSistema']"), checkSegurancaUsuariosdosistema);
        }

        public bool RetornarSegurancaUsuariosdosistema()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaUsuariosSistema']"));
        }

        public void MarcarSegurancaUsuariosdosistemaConsultar(bool checkSegurancaUsuariosdosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaUsuariosSistemaConsultar']"), checkSegurancaUsuariosdosistema);
        }

        public bool RetornarSegurancaUsuariosdosistemaConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaUsuariosSistemaConsultar']"));
        }

        public void MarcarSegurancaUsuariosdosistemaIncluir(bool checkSegurancaUsuariosdosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaUsuariosSistemaIncluir']"), checkSegurancaUsuariosdosistema);
        }

        public bool RetornarSegurancaUsuariosdosistemaIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaUsuariosSistemaIncluir']"));
        }

        public void MarcarSegurancaUsuariosdosistemaAlterar(bool checkSegurancaUsuariosdosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaUsuariosSistemaAlterar']"), checkSegurancaUsuariosdosistema);
        }

        public bool RetornarSegurancaUsuariosdosistemaAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaUsuariosSistemaAlterar']"));
        }

        public void MarcarSegurancaUsuariosdosistemaExcluir(bool checkSegurancaUsuariosdosistema)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkSegurancaUsuariosSistemaExcluir']"), checkSegurancaUsuariosdosistema);
        }

        public bool RetornarSegurancaUsuariosdosistemaExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkSegurancaUsuariosSistemaExcluir']"));
        }

        public void MarcarRelatorioscustomizadosComum(bool checkRelatorioscustomizadosComum)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosCustomizadosComum']"), checkRelatorioscustomizadosComum);
        }

        public bool RetornarRelatorioscustomizadosComum()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosCustomizadosComum']"));
        }

        public void MarcarRelatorioscustomizadosComumConsultar(bool checkRelatorioscustomizadosComum)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkRelatoriosCustomizadosComumConsultar']"), checkRelatorioscustomizadosComum);
        }

        public bool RetornarRelatorioscustomizadosComumConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkRelatoriosCustomizadosComumConsultar']"));
        }


        public void MarcarLocadora(bool checkLocadora)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadora']"), checkLocadora);
        }

        public bool RetornarLocadora()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadora']"));
        }

        public void MarcarLocadoraContratoLocadora(bool checkLocadoraContratoLocadora)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraContratoLocadora']"), checkLocadoraContratoLocadora);
        }

        public bool RetornarLocadoraContratoLocadora()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraContratoLocadora']"));
        }

        public void MarcarLocadoraContratoLocadoraConsultar(bool checkLocadoraContratoLocadoraConsultar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraContratoLocadoraConsultar']"), checkLocadoraContratoLocadoraConsultar);
        }

        public bool RetornarLocadoraContratoLocadoraConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraContratoLocadoraConsultar']"));
        }

        public void MarcarLocadoraContratoLocadoraIncluir(bool checkLocadoraContratoLocadoraIncluir)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraContratoLocadoraIncluir']"), checkLocadoraContratoLocadoraIncluir);
        }

        public bool RetornarLocadoraContratoLocadoraIncluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraContratoLocadoraIncluir']"));
        }

        public void MarcarLocadoraContratoLocadoraAlterar(bool checkLocadoraContratoLocadoraAlterar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraContratoLocadoraAlterar']"), checkLocadoraContratoLocadoraAlterar);
        }

        public bool RetornarLocadoraContratoLocadoraAlterar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraContratoLocadora']"));
        }

        public void MarcarLocadoraContratoLocadoraExcluir(bool checkLocadoraContratoLocadoraExcluir)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraContratoLocadoraExcluir']"), checkLocadoraContratoLocadoraExcluir);
        }

        public bool RetornarLocadoraContratoLocadoraExcluir()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraContratoLocadoraExcluir']"));
        }

        public void MarcarLocadoraFechamentoFaturaLocadora(bool checkLocadoraFechamentoFaturaLocadora)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadora']"), checkLocadoraFechamentoFaturaLocadora);
        }

        public bool RetornarLocadoraFechamentoFaturaLocadora()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadora']"));
        }

        public void MarcarLocadoraFechamentoFaturaLocadoraConsultar(bool checkLocadoraFechamentoFaturaLocadoraConsultar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadoraConsultar']"), checkLocadoraFechamentoFaturaLocadoraConsultar);
        }

        public bool RetornarLocadoraFechamentoFaturaLocadoraConsultar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadoraConsultar']"));
        }

        public void MarcarLocadoraFechamentoFaturaLocadoraCriar(bool checkLocadoraFechamentoFaturaLocadoraCriar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadoraCriar']"), checkLocadoraFechamentoFaturaLocadoraCriar);
        }

        public bool RetornarLocadoraFechamentoFaturaLocadoraCriar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadoraCriar']"));
        }

        public void MarcarLocadoraFechamentoFaturaLocadoraLiquidar(bool checkLocadoraFechamentoFaturaLocadoraLiquidar)
        {
            _driver.MarcarCheckBox(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadoraLiquidar']"), checkLocadoraFechamentoFaturaLocadoraLiquidar);
        }

        public bool RetornarLocadoraFechamentoFaturaLocadoraLiquidar()
        {
            return _driver.GetCheck(By.CssSelector("input[name='checkLocadoraFechamentoFaturaLocadoraLiquidar']"));
        }

    }
}