
using System;
using System.Threading;
using FluentAssertions;
using FluentAssertions.Execution;
using Gauge.CSharp.Lib;
using Gauge.CSharp.Lib.Attribute;
using Luminus.Selenium.Implementation.Shared.Form;
using Luminus.Selenium.specs.ConfiguracaoDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos;
using Luminus.Selenium.specs.Shared.StCriarUmBolsaoDeVagas16266;
using Luminus.Selenium.specs.Shared.StCriarPerfilComAcessoATodosAsFuncionalidades17684;
using Luminus.Selenium.Utils;

namespace Luminus.Selenium.specs.ConfiguracoesDoEstacionamento.Equipamentos
{
    public class EquipamentosPageStep
    {
        private EquipamentosPage _page = new EquipamentosPage();

        [Step("Carregar dependências Equipamentos <tabela>")]
        public void CarregarDependenciasEquipamentos(Table tabela)
        {
            WorkflowHelper.ContinueIfFirstExecution(() =>
            {
                // steps de dependências
                new StCriarUmBolsaoDeVagas16266PageStep().StCriarUmBolsaoDeVagas16266(tabela);
                new StCriarPerfilComAcessoATodosAsFuncionalidades17684PageStep().StCriarPerfilComAcessoATodosAsFuncionalidades17684(tabela);
            });
        }

        [Step("No combobox Tipo do periférico selecionar a opção <tabela> [<nomeColuna>] [EquipamentosPageStep]")]
        public void NoComboboxTipoDoPerifericoSelecionarAOpcaoEquipamentospagestep(Table tabela, string nomeColuna)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell(nomeColuna));
        }

        [Step("No combobox Modelo do periférico selecionar a opção <tabela> [<nomeColuna>] [EquipamentosPageStep]")]
        public void NoComboboxModeloDoPerifericoSelecionarAOpcaoEquipamentospagestep(Table tabela, string nomeColuna)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell(nomeColuna));
        }

        [Step("Preencher o campo Porta serial com o valor <tabela> [<nomeColuna>] [EquipamentosPageStep]")]
        public void NoComboboxPreencherOCampoPortaSerialParaOValorEquipamentospagestep(Table tabela, string nomeColuna)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherPortaSerialEquipamento(row.GetCell(nomeColuna));
        }

        [Step("Preencher o campo Endereço IP com o valor <tabela> [<nomeColuna>] [EquipamentosPageStep]")]
        public void NoComboboxPreencherOCampoEndereçoDeIpComOValorEquipamentospagestep(Table tabela, string nomeColuna)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell(nomeColuna));
        }

        [Step("No combobox Modelo do Bocal selecionar a opção <tabela> [<nomeColuna>] [EquipamentosPageStep]")]
        public void NoComboboxModeloDoBocalSelecionarAOpcaoEquipamentospagestep(Table tabela, string nomeColuna)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarModeloDoBocalEquipamento(row.GetCell(nomeColuna));
        }

        [Step("Movimentar barra de rolagem até o botão Adicionar [EquipamentosPageStep]")]
        public void MovimentarBarraRolagemAteBotaoAdicionar()
        {
            _page.MovimentarBarraRolagemAteBotaoAdicionar();
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16899]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16899(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEquipamentoEAEMifare"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoEAEMifare"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEquipamentoEAEMifare"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentoEAEMifare"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPDoGatewayEquipamentoEAEMifare"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamentoEAEMifare")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoDoEquipamentoEquipamentoEAEMifare"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEquipamentoEAEMifare")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentoEAEMifare")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenetEquipamentoEAEMifare"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDasEquipamentoEAEMifare"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAsEquipamentoEAEMifare"));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamentoEAEMifare"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamentoEAEMifare")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamentoEAEMifare")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoEAEMifare")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16899]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16899(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorMifareEquipamentoEAEMifare"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentoEAEMifare")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoPrincipalLeitorMifareEquipamentoEAEMifare")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitorMifareEquipamentoEAEMifare"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialLeitorMifareEquipamentoEAEMifare"));
            _page.SelecionarModeloDoBocalEquipamento(row.GetCell("modeloDoBocalLeitorMifareEquipamentoEAEMifare"));
            _page.PreencherTempoDeEsperaNaEsteiraEquipamento(row.GetCell("tempoDeEsperaNaEsteiraEquipamentoEAEMifare"));
            _page.PreencherTempoDeAguardoParaEmissaoEquipamento(row.GetCell("tempoDeAguardoParaEmissaoEquipamentoEAEMifare"));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor de proximidade <tabela> [EquipamentosPageStep] [16899]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16899(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorProximidadeEquipamentoEAEMifare"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarLeitorProximidadeEquipamentoEAEMifare")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitorProximidadeEquipamentoEAEMifare"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialLeitorProximidadeEquipamentoEAEMifare"));

        }

        [Step("Preencher os campos do pop-up de periférico de tela vga <tabela> [EquipamentosPageStep] [16899]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeTelaVgaEquipamentosPageStep16899(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("telaVgaEquipamentoEAEMifare"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarTelaVgaEquipamentoEAEMifare")));
            _page.SelecionarTelaVgaResolucaoEquipamento(row.GetCell("telaVgaResolucaoEquipamentoEAEMifare"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16899]")]
        public void PreencherOsCamposDaTelaNaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16899(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEMifare")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEMifare")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoEAEMifare"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoEAEMifare"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16596]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16596(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAEMifare"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEquipamentoEAEMifare"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentoEAEMifare"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayEquipamentoEAEMifare"));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarFuncaoDeOperacaoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEquipamentoEAEMifare")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentoEAEMifare")));
                _page.RetornarLimiteDeTransacoesOffLineEquipamento().Should().Be(row.GetCell("limiteDeTransacoesOffLineEquipamentoEAEMifare"));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numeroDoSetorSpacenetEquipamentoEAEMifare"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoDasEquipamentoEAEMifare"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoAsEquipamentoEAEMifare"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamentoEAEMifare")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamentoEAEMifare")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoEAEMifare")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEMifare")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEMifare")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoEAEMifare"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoEAEMifare"));
            }

        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16596]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16596(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorMifareEquipamentoEAEMifare"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentoEAEMifare")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoPrincipalLeitorMifareEquipamentoEAEMifare")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorMifareEquipamentoEAEMifare"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitorMifareEquipamentoEAEMifare"));
                _page.RetornarModeloDoBocalEquipamento().Should().Be(row.GetCell("modeloDoBocalLeitorMifareEquipamentoEAEMifare"));
                _page.RetornarTempoDeEsperaNaEsteiraEquipamento().Should().Be(row.GetCell("tempoDeEsperaNaEsteiraEquipamentoEAEMifare"));
                _page.RetornarTempoDeAguardoParaEmissaoEquipamento().Should().Be(row.GetCell("tempoDeAguardoParaEmissaoEquipamentoEAEMifare"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor proximidade <tabela> [EquipamentosPageStep] [16596]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorProximidadeEquipamentosPageStep16596(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorProximidadeEquipamentoEAEMifare"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLeitorProximidadeEquipamentoEAEMifare")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorProximidadeEquipamentoEAEMifare"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitorProximidadeEquipamentoEAEMifare"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de tela vga <tabela> [EquipamentosPageStep] [16596]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeTelaVgaEquipamentosPageStep16596(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("telaVgaEquipamentoEAEMifare"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarTelaVgaEquipamentoEAEMifare")));
                _page.RetornarTelaVgaResolucaoEquipamento().Should().Be(row.GetCell("telaVgaResolucaoEquipamentoEAEMifare"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16599]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numerodoequipamentoequipamentos"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEASMifareequipamentos"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPequipamentos"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPequipamentos"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPdogatewayequipamentos"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoequipamentos")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoDoEquipamentoEquipamentoEASMifare"));
            _page.MarcarFuncaoDeOperacaoSaidaEquipamento(Convert.ToBoolean(row.GetCell("saidaequipamentos")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semlimiteequipamentos")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numerodosetorspacenetequipamentos"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("dasequipamentos"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("asequipamentos"));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("mododeacionamentodoequipamentoequipamentos"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentos")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentos")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentos")));
            _page.MarcarMultiplosequipamentosporacesso3oumaisEquipamento(Convert.ToBoolean(row.GetCell("multiplosequipamentosporacesso3oumaisequipamentosequipamentos")));
            _page.SelecionarTipodeescapegatemodeEquipamentos(row.GetCell("tipodeescapegatemodeequipamentos"));
            _page.SelecionarSentidodoescapegatemodeEquipamentos(row.GetCell("sentidodoescapegatemodeequipamentos"));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarEquipamentoEscapeGateModevinculadoEquipamento(row.GetCell("equipamentoEscapeGateModevinculadoequipamentos"));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentos")));
            _page.MarcarAutoparadaEquipamento(Convert.ToBoolean(row.GetCell("autoparadaequipamentos")));
            _page.MarcarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento(Convert.ToBoolean(row.GetCell("inicianovatransacaocomveiculossobreolacodefechamentoequipamentos")));
            _page.MarcarInicianovatransacaoaposfechamentototaldacancelaEquipamento(Convert.ToBoolean(row.GetCell("inicianovatransacaoaposfechamentototaldacancelaequipamentos")));
            _page.MarcarExistelacoparaacionamentodoequipamentoEquipamento(Convert.ToBoolean(row.GetCell("existelacoparaacionamentodoequipamentoequipamentos")));
            _page.MarcarExistelacodefechamentodacancelaEquipamento(Convert.ToBoolean(row.GetCell("existelacodefechamentodacancelaequipamentos")));
            _page.MarcarAguardarsinaldecancelafechadaEquipamento(Convert.ToBoolean(row.GetCell("aguardarsinaldecancelafechadaequipamentos")));
            _page.PreencherTempolimitepararespostadacancelasegEquipamento(row.GetCell("tempolimitepararespostadacancelasegequipamentos"));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16599]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipodoperifericoperiferico1equipamentos"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoprincipalperiferico1equipamentos")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarperiferico1equipamentos")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modelodoleitorperiferico1equipamentos"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaserialperiferico1equipamentos"));
            _page.SelecionarModeloDoBocalEquipamento(row.GetCell("modelodobocalperiferico1equipamentos"));
            _page.PreencherTempoDeEsperaNaEsteiraEquipamento(row.GetCell("tempodeesperanaesteiraciclossegperiferico1equipamentos"));
            _page.PreencherTempoDeAguardoParaEmissaoEquipamento(row.GetCell("tempodeaguardoparaemissaociclossegperiferico1equipamentos"));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor de proximidade <tabela> [EquipamentosPageStep] [16599]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipodoperifericoperiferico2equipamentos"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarperiferico2equipamentos")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modelodoleitorperiferico2equipamentos"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaserialperiferico2equipamentos"));

        }

        [Step("Preencher os campos do pop-up de periférico de placa de som <tabela> [EquipamentosPageStep] [16599]")]
        public void PreencherOsCampoDoPopupDePerifericoDePlacaDeSomEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipodoperifericoperiferico3equipamentos"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarperiferico3equipamentos")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modelodaplacadesomperiferico3equipamentos"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16599]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentos")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentos")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentos"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentos"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16599]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numerodoequipamentoequipamentos"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEASMifareequipamentos"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPequipamentos"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPequipamentos"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPdogatewayequipamentos"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoequipamentos")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEquipamentoEASMifare"));
                _page.RetornarFuncaoDeOperacaoSaidaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("saidaequipamentos")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semlimiteequipamentos")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numerodosetorspacenetequipamentos"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("dasequipamentos"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("asequipamentos"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("mododeacionamentodoequipamentoequipamentos"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentos")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentos")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentos")));
                _page.RetornarMultiplosequipamentosporacesso3oumaisEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("multiplosequipamentosporacesso3oumaisequipamentosequipamentos")));
                _page.RetornarTipodeescapegatemodeEquipamentos().Should().Be(row.GetCell("tipodeescapegatemodeequipamentos"));
                _page.RetornarSentidodoescapegatemodeEquipamentos().Should().Be(row.GetCell("sentidodoescapegatemodeequipamentos"));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarEquipamentoEscapeGateModevinculadoEquipamento().Should().Be(row.GetCell("equipamentoEscapeGateModevinculadoequipamentos"));
                _page.RetornarPossuicancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuicancelaequipamentos")));
                _page.RetornarAutoparadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("autoparadaequipamentos")));
                _page.RetornarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("inicianovatransacaocomveiculossobreolacodefechamentoequipamentos")));
                _page.RetornarInicianovatransacaoaposfechamentototaldacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("inicianovatransacaoaposfechamentototaldacancelaequipamentos")));
                _page.RetornarExistelacoparaacionamentodoequipamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existelacoparaacionamentodoequipamentoequipamentos")));
                _page.RetornarExistelacodefechamentodacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existelacodefechamentodacancelaequipamentos")));
                _page.RetornarAguardarsinaldecancelafechadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("aguardarsinaldecancelafechadaequipamentos")));
                _page.RetornarTempolimitepararespostadacancelasegEquipamento().Should().Be(row.GetCell("tempolimitepararespostadacancelasegequipamentos"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentos")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentos")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentos"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentos"));
            }

        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16599]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipodoperifericoperiferico1equipamentos"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoprincipalperiferico1equipamentos")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarperiferico1equipamentos")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modelodoleitorperiferico1equipamentos"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaserialperiferico1equipamentos"));
                _page.RetornarModeloDoBocalEquipamento().Should().Be(row.GetCell("modelodobocalperiferico1equipamentos"));
                _page.RetornarTempoDeEsperaNaEsteiraEquipamento().Should().Be(row.GetCell("tempodeesperanaesteiraciclossegperiferico1equipamentos"));
                _page.RetornarTempoDeAguardoParaEmissaoEquipamento().Should().Be(row.GetCell("tempodeaguardoparaemissaociclossegperiferico1equipamentos"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor de proximidade <tabela> [EquipamentosPageStep] [16599]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipodoperifericoperiferico2equipamentos"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarperiferico2equipamentos")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modelodoleitorperiferico2equipamentos"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaserialperiferico2equipamentos"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de placa de som <tabela> [EquipamentosPageStep] [16599]")]
        public void VerificarOsCamposDoPopUpDePerifericoDePlacaDeSomEquipamentosPageStep16599(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipodoperifericoperiferico3equipamentos"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarperiferico3equipamentos")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modelodaplacadesomperiferico3equipamentos"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16922]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16922(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEAPassagem"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentosEAPassagem"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEquipamentosEAPassagem"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentosEAPassagem"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayEquipamentosEAPassagem"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAPassagem")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoEquipamentoEAPassagem")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentosEAPassagem")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroSetorSpacenetEquipamentosEAPassagem"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoFuncionamentoDasEquipamentosEAPassagem"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoFuncionamentoAsEquipamentosEAPassagem"));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoAcionamanetoEquipamentoEquipamentosEAPassagem"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaoMotoEquipamentosEAPassagem")));
            _page.MarcarAcessoPassagemEspecialEquipamento(Convert.ToBoolean(row.GetCell("acessoPassagemEspecialEquipamentosEAPassagem")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somenteTAGNeposEquipamentosEAPassagem")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentosEAPassagem")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuiCancelaEquipamentosEAPassagem")));
            _page.MarcarAutoparadaEquipamento(Convert.ToBoolean(row.GetCell("autoParadaEquipamentosEAPassagem")));
            _page.MarcarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento(Convert.ToBoolean(row.GetCell("iniciaNovaTransacaoVeiculoSobreLacoEquipamentosEAPassagem")));
            _page.MarcarInicianovatransacaoaposfechamentototaldacancelaEquipamento(Convert.ToBoolean(row.GetCell("iniciaNovaAposFechamentoTotalCancelaEquipamentosEAPassagem")));
            _page.MarcarExistelacoparaacionamentodoequipamentoEquipamento(Convert.ToBoolean(row.GetCell("existeLacoAcionamentoEquipamentoEquipamentosEAPassagem")));
            _page.MarcarExistelacodefechamentodacancelaEquipamento(Convert.ToBoolean(row.GetCell("existeLacoFechamentoCancelaEquipamentosEAPassagem")));
            _page.MarcarAguardarsinaldecancelafechadaEquipamento(Convert.ToBoolean(row.GetCell("aguardarSinalCancelaFechadaEquipamentosEAPassagem")));
            _page.PreencherTempolimitepararespostadacancelasegEquipamento(row.GetCell("tempoLimiteRespostaCancelaEquipamentosEAPassagem"));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16922]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16922(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorMifareEquipamentosEAPassagem"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentosEAPassagem")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorMifareEquipamentoEAPassagem")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitorMifareEquipamentosEAPassagem"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialLeitorMifareEquipamentosEAPassagem"));
            _page.SelecionarModeloDoBocalEquipamento(row.GetCell("modeloBocalLeitorMifareEquipamentosEAPassagem"));
            _page.PreencherTempoDeEsperaNaEsteiraEquipamento(row.GetCell("tempoEsperaEsteiraEquipamentosEAPassagem"));
            _page.PreencherTempoDeAguardoParaEmissaoEquipamento(row.GetCell("tempoAguardoEmissaoEquipamentosEAPassagem"));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor de proximidade <tabela> [EquipamentosPageStep] [16922]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16922(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorProximidadeEquipamentosEAPassagem"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarLeitorProximidadeEquipamentosEAPassagem")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitorProximidadeEquipamentosEAPassagem"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerailLeitorProximidadeEquipamentosEAPassagem"));

        }

        [Step("Preencher os campos do pop-up de periférico de interfone voip <tabela> [EquipamentosPageStep] [16922]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeInterfoneVoipEquipamentosPageStep16922(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("interfoneVoipEquipamentosEAPassagem"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarInterfoneVoipEquipamentosEAPassagem")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloInterfoneVoipEquipamentosEAPassagem"));
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell("enderecoIPLeitorProximidadeEquipamentosEAPassagem"));
            _page.PreencherCodigoInterfoneVoipEquipamento(row.GetCell("codigoLeitorProximidadeEquipamentosEAPassagem"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16922]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16922(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesEsperaAposTeclaAcionadaEquipamentosEAPassagem")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarMensagemDetalhesEsperaEquipamentosEAPassagem")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoMostrarDetalhesErroEquipamentosEAPassagem"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoMostrarDetalhesEsperaEquipamentosEAPassagem"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16601]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16601(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEAPassagem"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentosEAPassagem"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEquipamentosEAPassagem"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentosEAPassagem"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPGatewayEquipamentosEAPassagem"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAPassagem")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoPassagemEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoEquipamentoEAPassagem")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentosEAPassagem")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numeroSetorSpacenetEquipamentosEAPassagem"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoFuncionamentoDasEquipamentosEAPassagem"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoFuncionamentoAsEquipamentosEAPassagem"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("modoAcionamanetoEquipamentoEquipamentosEAPassagem"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaoMotoEquipamentosEAPassagem")));
                _page.RetornarAcessoPassagemEspecialEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("acessoPassagemEspecialEquipamentosEAPassagem")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somenteTAGNeposEquipamentosEAPassagem")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentosEAPassagem")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarPossuicancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiCancelaEquipamentosEAPassagem")));
                _page.RetornarAutoparadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("autoParadaEquipamentosEAPassagem")));
                _page.RetornarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("iniciaNovaTransacaoVeiculoSobreLacoEquipamentosEAPassagem")));
                _page.RetornarInicianovatransacaoaposfechamentototaldacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("iniciaNovaAposFechamentoTotalCancelaEquipamentosEAPassagem")));
                _page.RetornarExistelacoparaacionamentodoequipamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existeLacoAcionamentoEquipamentoEquipamentosEAPassagem")));
                _page.RetornarExistelacodefechamentodacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existeLacoFechamentoCancelaEquipamentosEAPassagem")));
                _page.RetornarAguardarsinaldecancelafechadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("aguardarSinalCancelaFechadaEquipamentosEAPassagem")));
                _page.RetornarTempolimitepararespostadacancelasegEquipamento().Should().Be(row.GetCell("tempoLimiteRespostaCancelaEquipamentosEAPassagem"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesEsperaAposTeclaAcionadaEquipamentosEAPassagem")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarMensagemDetalhesEsperaEquipamentosEAPassagem")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoMostrarDetalhesErroEquipamentosEAPassagem"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoMostrarDetalhesEsperaEquipamentosEAPassagem"));
            }

        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16601]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16601(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorMifareEquipamentosEAPassagem"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentosEAPassagem")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorMifareEquipamentoEAPassagem")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorMifareEquipamentosEAPassagem"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitorMifareEquipamentosEAPassagem"));
                _page.RetornarModeloDoBocalEquipamento().Should().Be(row.GetCell("modeloBocalLeitorMifareEquipamentosEAPassagem"));
                _page.RetornarTempoDeEsperaNaEsteiraEquipamento().Should().Be(row.GetCell("tempoEsperaEsteiraEquipamentosEAPassagem"));
                _page.RetornarTempoDeAguardoParaEmissaoEquipamento().Should().Be(row.GetCell("tempoAguardoEmissaoEquipamentosEAPassagem"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor de proximidade <tabela> [EquipamentosPageStep] [16601]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16601(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorProximidadeEquipamentosEAPassagem"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLeitorProximidadeEquipamentosEAPassagem")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorProximidadeEquipamentosEAPassagem"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerailLeitorProximidadeEquipamentosEAPassagem"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de interfone voip <tabela> [EquipamentosPageStep] [16601]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeinterfonevoipEquipamentosPageStep16601(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("interfoneVoipEquipamentosEAPassagem"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarInterfoneVoipEquipamentosEAPassagem")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloInterfoneVoipEquipamentosEAPassagem"));
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("enderecoIPLeitorProximidadeEquipamentosEAPassagem"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16603]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEAC"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquinpamentosEAC"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderencoIPEquipamentosEAC"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentosEAC"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayEquipamentosEAC"));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEAC")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEAC")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("setorSpacenetEquipamentosEAC"));
            _page.MarcarDigitarMidiaEquipamento(Convert.ToBoolean(row.GetCell("digitarMidiaEquipamentosEAC")));
            _page.MarcarMultiplasMedasEquipamento(Convert.ToBoolean(row.GetCell("multiplasMedasEquipamentosEAC")));
            _page.MarcarBloquearPagamentosEquipamento(Convert.ToBoolean(row.GetCell("bloquearPagamentosEquipamentosEAC")));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16603]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorMifareEquioamentosEAC"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentosEAC")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorMifareEquipamentosEAC")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitorMifareEquipamentosEAC"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialCRT288EquipamentosEAC"));

        }

        [Step("Preencher os campos do pop-up de periférico de Impressor <tabela> [EquipamentosPageStep] [16603]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeImpressorEquipamentosPageStep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("impressorEquioamentosEAC"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressorEquipamentosEAC")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressorEquipamentosEAC")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloImpressorEquipamentosEAC"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialImpressorEquipamentosEAC"));

        }

        [Step("Preencher os campos do pop-up de periférico de Leitor 1D2D <tabela> [EquipamentosPageStep] [16603]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentosPageStep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitor1D2DEquioamentosEAC"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitor1D2DEquipamentosEAC")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitor1D2DEquipamentosEAC"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerial1D2DEquipamentosEAC"));
            _page.MarcarLaserContinuo1D2DEquipamento(Convert.ToBoolean(row.GetCell("laserContinuo1D2DEquipamentosEAC")));
            _page.MarcarLeituraSeloDescontoEquipamento(Convert.ToBoolean(row.GetCell("leituraSeloDescontoEquipamentosEAC")));
            _page.MarcarVerificarDigitoVerificador1D2DEquipamento(Convert.ToBoolean(row.GetCell("verificarDigitoVerificador1D2DEquipamentosEAC")));

        }

        [Step("Preencher os campos do pop-up de periférico de Tarja Magnética <tabela> [EquipamentosPageStep] [16603]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeTarjaMagneticaEquipamentosPageStep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tarjaMagneticaEquipamentosEAC"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoTarjaEquipamentosEAC")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloTarjaMagnetciaEquipamentosEAC"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialLeitorTarjaEquipamentosEAC"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16603]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostarDetalhesAposTeclaAcionadaEquipamentosEAC")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarMensagemEsperaEquipamentosEAC")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesErroEquipamentosEAC"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesEsperaEquipamentosEAC"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16603]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEAC"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquinpamentosEAC"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderencoIPEquipamentosEAC"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentosEAC"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPGatewayEquipamentosEAC"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAC")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("nomeAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoValidacaoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEAC")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEAC")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("setorSpacenetEquipamentosEAC"));
                _page.RetornarDigitarMidiaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("digitarMidiaEquipamentosEAC")));
                _page.RetornarMultiplasMedasEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("multiplasMedasEquipamentosEAC")));
                _page.RetornarBloquearPagamentosEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("bloquearPagamentosEquipamentosEAC")));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostarDetalhesAposTeclaAcionadaEquipamentosEAC")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarMensagemEsperaEquipamentosEAC")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesErroEquipamentosEAC"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesEsperaEquipamentosEAC"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16603]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentospagestep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorMifareEquioamentosEAC"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentosEAC")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorMifareEquipamentosEAC")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorMifareEquipamentosEAC"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialCRT288EquipamentosEAC"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressor <tabela> [EquipamentosPageStep] [16603]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressorEquipamentospagestep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("impressorEquioamentosEAC"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressorEquipamentosEAC")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressorEquipamentosEAC")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloImpressorEquipamentosEAC"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialImpressorEquipamentosEAC"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor 1D2D <tabela> [EquipamentosPageStep] [16603]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitor1D2DEquioamentosEAC"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitor1D2DEquipamentosEAC")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitor1D2DEquipamentosEAC")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitor1D2DEquipamentosEAC"));
                _page.RetornarLaserContinuo1D2DEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("laserContinuo1D2DEquipamentosEAC")));
                _page.RetornarLeituraSeloDescontoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("leituraSeloDescontoEquipamentosEAC")));
                _page.RetornarVerificarDigitoVerificador1D2DEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("verificarDigitoVerificador1D2DEquipamentosEAC")));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de Tarja Magnética <tabela> [EquipamentosPageStep] [16603]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeTarjaMagneticaEquipamentospagestep16603(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tarjaMagneticaEquipamentosEAC"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalTarjaEquipamentosEAC")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoTarjaEquipamentosEAC")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloTarjaMagnetciaEquipamentosEAC"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16608]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16608(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEquipamento"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamento"));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoDoEquipamentoEquipamento"));
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamento")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamento"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamento"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16608]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16608(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEquipamento"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamento"));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEquipamento"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamento")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamento"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamento"));
            }

        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16610]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16610(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("alterarNumeroDoEquipamentoEquipamentoEAEMifare"));
            _page.PreencherNomeEquipamento(row.GetCell("alterarNomeEquipamentoEAEMifare"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("alterarEnderecoIPEquipamentoEAEMifare"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("alterarMascaraIPEquipamentoEAEMifare"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("alterarIPDoGatewayEquipamentoEAEMifare"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("alterarHabilitadoEquipamentoEAEMifare")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("alterarSemLimiteTransacoesOffLineEquipamentoEAEMifare")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("alterarLimiteDeTransacoesOffLineEquipamentoEAEMifare"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("alterarNumeroDoSetorSpacenetEquipamentoEAEMifare"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("alterarPeriodoDeFuncionamentoEquipamentoEAEMifare")));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("alterarModoDeAcionamentoDoEquipamentoEquipamentoEAEMifare"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("alterarDeteccaoDeMotoEquipamentoEAEMifare")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("alterarSomenteTagNeposEquipamentoEAEMifare")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("alterarPossuiEscapeGateModeEquipamentoEAEMifare")));
            _page.MarcarMultiplosequipamentosporacesso3oumaisEquipamento(Convert.ToBoolean(row.GetCell("alterarMultiplosEquipamentosPorAcessoEquipamentoEAEMifare")));
            _page.SelecionarTipodeescapegatemodeEquipamentos(row.GetCell("tipoDeEscapeGateModeEquipamentoEAEMifare"));
            _page.SelecionarSentidodoescapegatemodeEquipamentos(row.GetCell("sentidoDoEscapeGateModeEquipamentoEAEMifare"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("acessoBolsaoSecundarioEquipamentoEAEMifare"));
            _page.SelecionarEquipamentoEscapeGateModevinculadoEquipamento(row.GetCell("equipamentoEscapeGateModevinculadoequipamentos"));
            _page.MarcarPossuicancelaEntradaEquipamento(Convert.ToBoolean(row.GetCell("alterarPossuiCancelaEquipamentoEAEMifare")));
            _page.MarcarAutoparadaEntradaEquipamento(Convert.ToBoolean(row.GetCell("alterarAutoParadaEquipamentoEAEMifare")));
            _page.MarcarInicianovatransacaocomveiculossobreolacodefechamentoEntradaEquipamento(Convert.ToBoolean(row.GetCell("iniciaNovaTransacaoComVeiculoSobreOLacoDeFechamentoEquipamentoEAEMifare")));
            _page.MarcarInicianovatransacaoaposfechamentototaldacancelaEntradaEquipamento(Convert.ToBoolean(row.GetCell("alterarIniciaNovaTransacaoAposFechamentototalDaCancelaEquipamentoEAEMifare")));
            _page.MarcarExistelacoparaacionamentodoequipamentoEntradaEquipamento(Convert.ToBoolean(row.GetCell("alterarExisteLacoParaAcionamentoDoEquipamentoEquipamentoEAEMifare")));
            _page.MarcarExistelacodefechamentodacancelaEntradaEquipamento(Convert.ToBoolean(row.GetCell("alterarExisteLacoDeFechamentoDaCancelaEquipamentoEAEMifare")));
            _page.MarcarAguardarsinaldecancelafechadaEntradaEquipamento(Convert.ToBoolean(row.GetCell("alterarAguardarSinalDeCancelaFechadaEquipamentoEAEMifare")));
            _page.PreencherTempolimitepararespostadacancelasegEntradaEquipamento(row.GetCell("alterarTempoLimiteParaRepostaDaCancelaEquipamentoEAEMifare"));
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("alterarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEMifare")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alterarAlternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEMifare")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("alterarTempoParaMostrarDetalhesDeErroEquipamentoEAEMifare"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("alterarTempoParaMostrarDetalhesDeEsperaEquipamentoEAEMifare"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16610]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16610(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("alterarNumeroDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("alterarNomeEquipamentoEAEMifare"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("alterarEnderecoIPEquipamentoEAEMifare"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("alterarMascaraIPEquipamentoEAEMifare"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("alterarIPDoGatewayEquipamentoEAEMifare"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarHabilitadoEquipamentoEAEMifare")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarSemLimiteTransacoesOffLineEquipamentoEAEMifare")));
                _page.RetornarPreenchimentoDeLimiteDeTransacoesOffLineEquipamento().Should().Be(row.GetCell("alterarLimiteDeTransacoesOffLineEquipamentoEAEMifare"));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("alterarNumeroDoSetorSpacenetEquipamentoEAEMifare"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarPeriodoDeFuncionamentoEquipamentoEAEMifare")));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("alterarModoDeAcionamentoDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarDeteccaoDeMotoEquipamentoEAEMifare")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarSomenteTagNeposEquipamentoEAEMifare")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarPossuiEscapeGateModeEquipamentoEAEMifare")));
                _page.RetornarMultiplosequipamentosporacesso3oumaisEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarMultiplosEquipamentosPorAcessoEquipamentoEAEMifare")));
                _page.RetornarTipodeescapegatemodeEquipamentos().Should().Be(row.GetCell("tipoDeEscapeGateModeEquipamentoEAEMifare"));
                _page.RetornarSentidodoescapegatemodeEquipamentos().Should().Be(row.GetCell("sentidoDoEscapeGateModeEquipamentoEAEMifare"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("acessoBolsaoSecundarioEquipamentoEAEMifare"));
                _page.RetornarPossuicancelaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarPossuiCancelaEquipamentoEAEMifare")));
                _page.RetornarAutoparadaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarAutoParadaEquipamentoEAEMifare")));
                _page.RetornarInicianovatransacaocomveiculossobreolacodefechamentoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("iniciaNovaTransacaoComVeiculoSobreOLacoDeFechamentoEquipamentoEAEMifare")));
                _page.RetornarInicianovatransacaoaposfechamentototaldacancelaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarIniciaNovaTransacaoAposFechamentototalDaCancelaEquipamentoEAEMifare")));
                _page.RetornarExistelacoparaacionamentodoequipamentoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarExisteLacoParaAcionamentoDoEquipamentoEquipamentoEAEMifare")));
                _page.RetornarExistelacodefechamentodacancelaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarExisteLacoDeFechamentoDaCancelaEquipamentoEAEMifare")));
                _page.RetornarAguardarsinaldecancelafechadaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarAguardarSinalDeCancelaFechadaEquipamentoEAEMifare")));
                _page.RetornarTempolimitepararespostadacancelasegEntradaEquipamento().Should().Be(row.GetCell("alterarTempoLimiteParaRepostaDaCancelaEquipamentoEAEMifare"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEMifare")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarAlternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEMifare")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("alterarTempoParaMostrarDetalhesDeErroEquipamentoEAEMifare"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("alterarTempoParaMostrarDetalhesDeEsperaEquipamentoEAEMifare"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16610]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentospagestep16610(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("alterarPortaSerialLeitorMifareEquipamentoEAEMifare"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor proximidade <tabela> [EquipamentosPageStep] [16610]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorProximidadeEquipamentospagestep16610(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("alterarPortaSerialLeitorProximidadeEquipamentoEAEMifare"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep2]")]
        public void PreencherOsCamposDaTelaCriarumequipamentovalidacaoinformatizadostepbysteppagestep2(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numerodoequipamentoequipamentos2"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeValidacaoInformatizadoEquipamentos2"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderencoIPEquipamentosInformatizado2"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPValidacaoInformatizadoEquipamentos2"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayValidacaoInformatizadoEquipamentos2"));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("listaAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValidacaoInformatizadoEquipamentos")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDeInformatizadoValidacaoEquipamentos"));
            _page.MarcarutilizarMutiplasMoedasInformatizadoValidacaoEquipamentos(Convert.ToBoolean(row.GetCell("utilizarMutiplasMoedasInformatizadoValidacaoEquipamentos")));
            _page.MarcarbloquearPagamentosInformatizadoValidacaoEquipamentos(Convert.ToBoolean(row.GetCell("bloquearPagamentosInformatizadoValidacaoEquipamentos")));

        }


        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17616]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep17616(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numerodoequipamentoequipamentos"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeValidacaoInformatizadoEquipamentos"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderencoIPEquipamentosInformatizado"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPValidacaoInformatizadoEquipamentos"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayValidacaoInformatizadoEquipamentos"));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("listaAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValidacaoInformatizadoEquipamentos")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDeInformatizadoValidacaoEquipamentos"));
            _page.MarcarutilizarMutiplasMoedasInformatizadoValidacaoEquipamentos(Convert.ToBoolean(row.GetCell("utilizarMutiplasMoedasInformatizadoValidacaoEquipamentos")));
            _page.MarcarbloquearPagamentosInformatizadoValidacaoEquipamentos(Convert.ToBoolean(row.GetCell("bloquearPagamentosInformatizadoValidacaoEquipamentos")));
        }

        [Step("Preencher os campos do pop-up de periférico de Impressor <tabela> [EquipamentosPageStep] [17616]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeImpressorEquipamentosPageStep17616(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipoDoPerifericoValidacaoInformatizado"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraValidacaoInformatizado")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressoraValidacaoInformatizado")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloImpressoraValidacaoInformatizado"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialImpressoraValidacaoInformatizadoEquipamentos"));
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17633]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep17633(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEASInformatizado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquinpamentosEASInformatizado"));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoInformatizadoEquipamento"));
            _page.MarcarFuncaoDeOperacaoSaidaEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEASInformatizado")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoInformatizadoEquipamento"));
            _page.SelecionarNomeUsuarioSistemaEquipamento(row.GetCell("nomeUsuarioSistema"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoFuncionamentoDasEquipamento"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoFuncionamentoAsEquipamento"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamento")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("acessoBolsaoSecundarioEquipamento"));

        }

        [Step("Preencher os campos do pop-up de periférico de Impressor <tabela> [EquipamentosPageStep] [17633]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeImpressorEquipamentosPageStep17633(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipoPerifericoInformatizadoEquipamento"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalInformatizadoEquipamento")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarInformatizadoEquipamento")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloImpressoraInformatizadoEquipamento"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialInformatizadoEquipamento"));

        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16918]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16918(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEquipamento"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamento"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEquipamento"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamento"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPDoGatewayEquipamento"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamento")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoDoEquipamentoEquipamento"));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemAplicativoDoEquipamentoEquipamento")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamento")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenetEquipamento"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDasEquipamento"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAsEquipamento"));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamento"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamento")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamento")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamento")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));

        }

        [Step("Preencher os campos do pop-up de periférico de Leitor 1D2D <tabela> [EquipamentosPageStep] [16918]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentosPageStep16918(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorBarcode1D2DEquipamento"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitor1D2DEquipamento")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoPrincipalLeitor1D2DEquipamento")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitor1D2DEquipamento"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialLeitor1D2DEquipamento"));
            _page.MarcarLaserContinuo1D2DEquipamento(Convert.ToBoolean(row.GetCell("habilitarLaserContinuoEquipamento")));
            _page.MarcarLeituraSeloDescontoEquipamento(Convert.ToBoolean(row.GetCell("habilitarLeituraDeSeloDeDescontoEquipamento")));
            _page.MarcarVerificarDigitoVerificador1D2DEquipamento(Convert.ToBoolean(row.GetCell("habilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarrasEquipamento")));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor tag <tabela> [EquipamentosPageStep] [16918]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorTagEquipamentosPageStep16918(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorTagEquipamento"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorTagEquipamento")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorTagEquipamento")));
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell("enderecoIPLeitorTagEquipamento"));
            _page.PreencherMascaraIpPopUpEquipamento(row.GetCell("mascaraIPLeitorTagEquipamento"));
            _page.PreencherGatewayIpPopUpEquipamento(row.GetCell("iPDoGatewayLeitorTagEquipamento"));
            _page.SelecionarTipodeinstalacaooperacaodaleitoraantenatagequipamento(row.GetCell("tipoDeInstalacaoOperacaoLeitoraAntenaLeitorTagEquipamento"));
            _page.PreencherCanaldaantenaconectadoaoleitoraantenaequipamento(row.GetCell("canalDaAntenaConectadoAoLeitorTagEquipamento"));
            _page.PreencherIgnorarleituradamesmatagporsegequipamentos(row.GetCell("ignorarLeituraDaMesmaTagLeitorTagEquipamento"));
            _page.PreencherConsiderarleiturasrealizadashaatedecimosdesegequipamento(row.GetCell("considerarLeiturasRealizadasHaAteDecimosTagLeitorTagEquipamento"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16918]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16918(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamento")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamento"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamento"));

        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16921]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16921(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEAP"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentosEAP"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderencoIPEquipamentosEAP"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentosEAP"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayEquipamentosEAP"));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("listaAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEAP")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEAP")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("setorSpacenetEquipamentosEAP"));
            _page.MarcarHabilitarValidacaoComCartaoDebito(Convert.ToBoolean(row.GetCell("habilitarValidacaoComCartaoDeDebitoEquipamentosEAP")));
            _page.MarcarHabilitarValidacaoEmDinheiro(Convert.ToBoolean(row.GetCell("habilitarValidacaoEmDinheiroEquipamentosEAP")));
        }

        [Step("Preencher os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16921]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16921(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorMifareEquioamentosEAP"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentosEAP")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorMifareEquipamentosEAP")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitorMifareEquipamentosEAP"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialCRT288EquipamentosEAP"));

        }

        [Step("Preencher os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [16921]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeImpressoraEquipamentosPageStep16921(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("impressoraEquipamentosEAP"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEquipamentosEAP")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressoraEquipamentosEAP")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloImpressoraEquipamentosEAP"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialImpressoraEquipamentosEAP"));
        }

        [Step("Preencher os campos do pop-up de periférico de leitora 1D2D <tabela> [EquipamentosPageStep] [16921]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitora1D2DEquipamentosPageStep16921(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitor1D2DEquioamentosEAP"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitor1D2DEquipamentosEAP")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitor1D2DEquipamentosEAP"));
            _page.MarcarHabilitarLaserContinuo(Convert.ToBoolean(row.GetCell("laserContinuo1D2DEquipamentosEAP")));
            _page.MarcarHabilitarLeituraDeSeloDeDesconto(Convert.ToBoolean(row.GetCell("leituraSeloDescontoEquipamentosEAP")));
            _page.MarcarHabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras(Convert.ToBoolean(row.GetCell("verificarDigitoVerificador1D2DEquipamentosEAP")));

        }

        [Step("Preencher os campos do pop-up de periférico de módulo financeiro <tabela> [EquipamentosPageStep] [16921]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeModuloFinanceiroEquipamentosPageStep16921(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("modulosFinanceirosEquipamentosEAP"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoModulosFinanceirosEquipamentosEAP")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloDosModulosFinanceirosEquipamentosEAP"));
            _page.MarcarPermitirPagamentoComDinheiroNaTelaConsulta(Convert.ToBoolean(row.GetCell("permitirPagamentoComDinheiroNaTelaDeConsultaEquipamentosEAP")));
            _page.MarcarHabilitarSinalizacaoPorLed(Convert.ToBoolean(row.GetCell("habilitarSinalizacaoPorLedEquipamentosEAP")));
            _page.PreencherPortaSerialDoAceitadorCedulas(row.GetCell("portaSerialDoAceitadorDeCedulasEquipamentosEAP"));
            _page.PreencherPortaSerialDoDispensadorCedulas(row.GetCell("portaSerialDoDispensadorDeCedulasEquipamentosEAP"));
            _page.PreencherPortaSerialDoAceitadorMoedas(row.GetCell("portaSerialDoAceitadorDeMoedasEquipamentosEAP"));
            _page.PreencherPortaSerialDoDispensadorMoedas(row.GetCell("portaSerialDoDispensadorDeMoedasEquipamentosEAP"));
        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16921]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16921(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostarDetalhesAposTeclaAcionadaEquipamentosEAP")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarMensagemEsperaEquipamentosEAP")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesErroEquipamentosEAP"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesEsperaEquipamentosEAP"));

        }


        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16936]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16936(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numerodoequipamentoequipamentos"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEASBarcodeequipamentos"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPequipamentos"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPequipamentos"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPdogatewayequipamentos"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoequipamentos")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoSaidaEquipamento(Convert.ToBoolean(row.GetCell("saidaequipamentos")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semlimiteequipamentos")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numerodosetorspacenetequipamentos"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("dasequipamentos"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("asequipamentos"));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("mododeacionamentodoequipamentoequipamentos"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentos")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentos")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentos")));
            _page.MarcarMultiplosequipamentosporacesso3oumaisEquipamento(Convert.ToBoolean(row.GetCell("multiplosequipamentosporacesso3oumaisequipamentosequipamentos")));
            _page.SelecionarTipodeescapegatemodeEquipamentos(row.GetCell("tipodeescapegatemodeequipamentos"));
            _page.SelecionarSentidodoescapegatemodeEquipamentos(row.GetCell("sentidodoescapegatemodeequipamentos"));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarEquipamentoEscapeGateModevinculadoEquipamento(row.GetCell("equipamentoEscapeGateModevinculadoequipamentos"));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentos")));
            _page.MarcarAutoparadaEquipamento(Convert.ToBoolean(row.GetCell("autoparadaequipamentos")));
            _page.MarcarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento(Convert.ToBoolean(row.GetCell("inicianovatransacaocomveiculossobreolacodefechamentoequipamentos")));
            _page.MarcarInicianovatransacaoaposfechamentototaldacancelaEquipamento(Convert.ToBoolean(row.GetCell("inicianovatransacaoaposfechamentototaldacancelaequipamentos")));
            _page.MarcarExistelacoparaacionamentodoequipamentoEquipamento(Convert.ToBoolean(row.GetCell("existelacoparaacionamentodoequipamentoequipamentos")));
            _page.MarcarExistelacodefechamentodacancelaEquipamento(Convert.ToBoolean(row.GetCell("existelacodefechamentodacancelaequipamentos")));
            _page.MarcarAguardarsinaldecancelafechadaEquipamento(Convert.ToBoolean(row.GetCell("aguardarsinaldecancelafechadaequipamentos")));
            _page.PreencherTempolimitepararespostadacancelasegEquipamento(row.GetCell("tempolimitepararespostadacancelasegequipamentos"));

        }

        [Step("Preencher os campos do pop-up de periférico de Leitor 1D2D <tabela> [EquipamentosPageStep] [16936]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentosPageStep16936(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipodoperifericoperiferico1equipamentos"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoprincipalperiferico1equipamentos")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarperiferico1equipamentos")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modelodoleitorperiferico1equipamentos"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaserialperiferico1equipamentos"));
            _page.MarcarLaserContinuo1D2DEquipamento(Convert.ToBoolean(row.GetCell("habilitarlasercontinuoperiferico1equipamentos")));
            _page.MarcarLeituraSeloDescontoEquipamento(Convert.ToBoolean(row.GetCell("habilitarleituradeselodedescontoperiferico1equipamentos")));
            _page.MarcarVerificarDigitoVerificador1D2DEquipamento(Convert.ToBoolean(row.GetCell("habilitarverificacaododigitoverificadordemidiascodigodebarrasperiferico1equipamentos")));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor tag <tabela> [EquipamentosPageStep] [16936]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorTagEquipamentosPageStep16936(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipodoperifericoperiferico2equipamentos"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoprincipalperiferico2equipamentos")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarperiferico2equipamentos")));
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell("enderecoIPperiferico2equipamentos"));
            _page.PreencherMascaraIpPopUpEquipamento(row.GetCell("mascaraIPperiferico2equipamentos"));
            _page.PreencherGatewayIpPopUpEquipamento(row.GetCell("iPdogatewayperiferico2equipamentos"));
            _page.SelecionarTipodeinstalacaooperacaodaleitoraantenatagequipamento(row.GetCell("tipodeinstalacaooperacaodaleitoraantenaperiferico2equipamentos"));
            _page.PreencherCanaldaantenaconectadoaoleitoraantenaequipamento(row.GetCell("canaldaantenaconectadoaoleitorperiferico2equipamentos"));
            _page.PreencherIgnorarleituradamesmatagporsegequipamentos(row.GetCell("ignorarleituradamesmatagporsegperiferico2equipamentos"));
            _page.PreencherConsiderarleiturasrealizadashaatedecimosdesegequipamento(row.GetCell("considerarleiturasrealizadashaatedecimosdesegperiferico2equipamentos"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16936]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16936(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentos")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentos")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentos"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentos"));

        }

        [Step("Preencher os campos do pop-up de periférico LPR <tabela> [EquipamentosPageStep] [17847]")]
        public void PreencherOsCamposDoPopUpDePerifericoLPREquipamentosPageStep17847(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorLPRPerifericoEquipamentos"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarLPRPerifericoEquipamento")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLPRPerifericoEquipamento"));
            _page.PreencherNumeroLPRPerifericoEquipamento(row.GetCell("numeroLPRPerifericoEquipamento"));
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell("enderecoIPPerifericoEquipamento"));
            _page.PreencherPortaLPRPerifericoEquipamento(row.GetCell("portaLPRPerifericoEquipamento"));
            _page.PreencherPortaLPRSerialPerifericoEquipamento(row.GetCell("portaEquipamentoPerifericoEquipamento"));
            _page.SelecionarPontoCapturaPerifericoEquipamento(row.GetCell("pontoCapturaPerifericoEquipamento"));
            _page.PreencherTempoLimiteRespostaCameraPerifericoEquipamento(row.GetCell("tempoLimiteRespostaCameraPerifericoEquipamento"));
            _page.PreencherNumeroCapturasPerifericoEquipamento(row.GetCell("numeroCapturasPerifericoEquipamento"));
            _page.MarcarVerificaDivergenciaEntradaPerifericoEquipamento(Convert.ToBoolean(row.GetCell("verificaDivergenciaEntradaPerifericoEquipamento")));
            _page.MarcarReconhecimentoCameraListaNegraPerifericoEquipamento(Convert.ToBoolean(row.GetCell("reconhecimentoCameraListaNegraPerifericoEquipamento")));
            _page.PreencherQuantidadeMinimaCaracteresCoincidenciaPerifericoEquipamento(row.GetCell("quantidadeMinimaCaracteresCoincidenciaPerifericoEquipamento"));
            _page.MarcarHabilitaConfiguracaoAutomatica(Convert.ToBoolean(row.GetCell("HabilitaConfiguracaoAutomatica")));
            _page.PreencherHabilitaConfiguracaoAutomaticaSenha(row.GetCell("HabilitaConfiguracaoAutomaticaSenha"));
            _page.PreencherHabilitaConfiguracaoAutomaticaPortaConfiguracao(row.GetCell("HabilitaConfiguracaoAutomaticaPorta"));


        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17847]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17847(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAEMifare"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEquipamentoEAEMifare"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentoEAEMifare"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayEquipamentoEAEMifare"));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarFuncaoDeOperacaoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEquipamentoEAEMifare")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentoEAEMifare")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numeroDoSetorSpacenetEquipamentoEAEMifare"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoDasEquipamentoEAEMifare"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoAsEquipamentoEAEMifare"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamentoEAEMifare"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamentoEAEMifare")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamentoEAEMifare")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoEAEMifare")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEMifare")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEMifare")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoEAEMifare"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoEAEMifare"));
            }

        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [17847]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep17847(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorMifareEquipamentoEAEMifare"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentoEAEMifare")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoPrincipalLeitorMifareEquipamentoEAEMifare")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorMifareEquipamentoEAEMifare"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitorMifareEquipamentoEAEMifare"));
                _page.RetornarModeloDoBocalEquipamento().Should().Be(row.GetCell("modeloDoBocalLeitorMifareEquipamentoEAEMifare"));
                _page.RetornarTempoDeEsperaNaEsteiraEquipamento().Should().Be(row.GetCell("tempoDeEsperaNaEsteiraEquipamentoEAEMifare"));
                _page.RetornarTempoDeAguardoParaEmissaoEquipamento().Should().Be(row.GetCell("tempoDeAguardoParaEmissaoEquipamentoEAEMifare"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor proximidade <tabela> [EquipamentosPageStep] [17847]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorProximidadeEquipamentosPageStep17847(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorProximidadeEquipamentoEAEMifare"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLeitorProximidadeEquipamentoEAEMifare")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorProximidadeEquipamentoEAEMifare"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitorProximidadeEquipamentoEAEMifare"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de tela vga <tabela> [EquipamentosPageStep] [17847]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeTelaVgaEquipamentosPageStep17847(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("telaVgaEquipamentoEAEMifare"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarTelaVgaEquipamentoEAEMifare")));
                _page.RetornarTelaVgaResolucaoEquipamento().Should().Be(row.GetCell("telaVgaResolucaoEquipamentoEAEMifare"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de LPR <tabela> [EquipamentosPageStep] [17847]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLPREquipamentosPageStep17847(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorLPRPerifericoEquipamentos"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLPRPerifericoEquipamento")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLPRPerifericoEquipamento"));
                _page.RetornarPortaLPRSerialPerifericoEquipamento().Should().Be(row.GetCell("portaEquipamentoPerifericoEquipamento"));
                _page.RetornarNumeroLPRPerifericoEquipamento().Should().Be(row.GetCell("numeroLPRPerifericoEquipamento"));
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("enderecoIPPerifericoEquipamento"));
                _page.RetornarPortaLPRPerifericoEquipamento().Should().Be(row.GetCell("portaLPRPerifericoEquipamento"));
                _page.RetornarTempoLimiteRespostaCameraPerifericoEquipamento().Should().Be(row.GetCell("tempoLimiteRespostaCameraPerifericoEquipamento"));
                _page.RetornarNumeroCapturasPerifericoEquipamento().Should().Be(row.GetCell("numeroCapturasPerifericoEquipamento"));
                _page.RetornarQuantidadeMinimaCaracteresCoincidenciaPerifericoEquipamento().Should().Be(row.GetCell("quantidadeMinimaCaracteresCoincidenciaPerifericoEquipamento"));
                _page.RetornarPontoCapturaPerifericoEquipamento().Should().Be(row.GetCell("pontoCapturaPerifericoEquipamento"));
                _page.RetornarVerificaDivergenciaEntradaPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("verificaDivergenciaEntradaPerifericoEquipamento")));
                _page.RetornarReconhecimentoCameraListaNegraPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("reconhecimentoCameraListaNegraPerifericoEquipamento")));
                _page.RetornarHabilitaConfiguracaoAutomatica().Should().Be(Convert.ToBoolean(row.GetCell("HabilitaConfiguracaoAutomatica")));
                _page.RetornarHabilitaConfiguracaoAutomaticaSenha().Should().Be(row.GetCell("HabilitaConfiguracaoAutomaticaSenha"));
                _page.RetornarHabilitaConfiguracaoAutomaticaPortaConfiguracao().Should().Be(row.GetCell("HabilitaConfiguracaoAutomaticaPorta"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16606]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16606(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEAP"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquinpamentosEAP"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderencoIPEquipamentosEAP"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentosEAP"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPGatewayEquipamentosEAP"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAP")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("listaAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoValidacaoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEAP")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEAP")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("setorSpacenetEquipamentosEAP"));
                _page.RetornarHabilitarValidacaoComCartaoDebito().Should().Be(Convert.ToBoolean(row.GetCell("habilitarValidacaoComCartaoDeDebitoEquipamentosEAP")));
                _page.RetornarHabilitarValidacaoEmDinheiro().Should().Be(Convert.ToBoolean(row.GetCell("habilitarValidacaoEmDinheiroEquipamentosEAP")));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostarDetalhesAposTeclaAcionadaEquipamentosEAP")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarMensagemEsperaEquipamentosEAP")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesErroEquipamentosEAP"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesEsperaEquipamentosEAP"));
            }
        }


        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16606]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentospagestep16606(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorMifareEquioamentosEAP"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorMifareEquipamentosEAP")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorMifareEquipamentosEAP")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitorMifareEquipamentosEAP"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialCRT288EquipamentosEAP"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [16606]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep16606(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("impressoraEquipamentosEAP"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEquipamentosEAP")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressoraEquipamentosEAP")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloImpressoraEquipamentosEAP"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialImpressoraEquipamentosEAP"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitora 1D/2D <tabela> [EquipamentosPageStep] [16606]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16606(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitor1D2DEquioamentosEAP"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitor1D2DEquipamentosEAP")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitor1D2DEquipamentosEAP")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitor1D2DEquipamentosEAP"));
                _page.RetornarHabilitarLaserContinuo().Should().Be(Convert.ToBoolean(row.GetCell("laserContinuo1D2DEquipamentosEAP")));
                _page.RetornarHabilitarLeituraDeSeloDeDesconto().Should().Be(Convert.ToBoolean(row.GetCell("leituraSeloDescontoEquipamentosEAP")));
                _page.RetornarHabilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarras().Should().Be(Convert.ToBoolean(row.GetCell("verificarDigitoVerificador1D2DEquipamentosEAP")));
            }

        }

        [Step("Verificar os campos do pop-up de periférico de módulo financeiro <tabela> [EquipamentosPageStep] [16606]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeModulosFinanceiroEquipamentospagestep16606(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoModulosFinanceirosEquipamentosEAP")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloDosModulosFinanceirosEquipamentosEAP"));
                _page.RetornarPermitirPagamentoComDinheiroNaTelaConsulta().Should().Be(Convert.ToBoolean(row.GetCell("permitirPagamentoComDinheiroNaTelaDeConsultaEquipamentosEAP")));
                _page.RetornarHabilitarSinalizacaoPorLed().Should().Be(Convert.ToBoolean(row.GetCell("habilitarSinalizacaoPorLedEquipamentosEAP")));
                _page.RetornarPortaSerialDoAceitadorCedulas().Should().Be(row.GetCell("portaSerialDoAceitadorDeCedulasEquipamentosEAP"));
                _page.RetornarPortaSerialDoDispensadorCedulas().Should().Be(row.GetCell("portaSerialDoDispensadorDeCedulasEquipamentosEAP"));
                _page.RetornarPortaSerialDoAceitadorMoedas().Should().Be(row.GetCell("portaSerialDoAceitadorDeMoedasEquipamentosEAP"));
                _page.RetornarPortaSerialDoDispensadorMoedas().Should().Be(row.GetCell("portaSerialDoDispensadorDeMoedasEquipamentosEAP"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16612]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16612(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numerodoequipamentoequipamentosalterar"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEASMifareequipamentosalterar"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPequipamentosalterar"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPequipamentosalterar"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPdogatewayequipamentosalterar"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoequipamentosalterar")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semlimiteequipamentosalterar")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limitedetransacoesofflineequipamentosalterar"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numerodosetorspacenetequipamentosalterar"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("semperiododefinidoequipamentosalterar")));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("mododeacionamentodoequipamentoequipamentosalterar"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentosalterar")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentosalterar")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentosalterar")));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentosalterar")));
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentosalterar")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentosalterar")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentosalterar"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentosalterar"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16612]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16612(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numerodoequipamentoequipamentosalterar"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEASMifareequipamentosalterar"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPequipamentosalterar"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPequipamentosalterar"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPdogatewayequipamentosalterar"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoequipamentosalterar")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semlimiteequipamentosalterar")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numerodosetorspacenetequipamentosalterar"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semperiododefinidoequipamentosalterar")));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("mododeacionamentodoequipamentoequipamentosalterar"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentosalterar")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentosalterar")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentosalterar")));
                _page.RetornarPossuicancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuicancelaequipamentosalterar")));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentosalterar")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentosalterar")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentosalterar"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentosalterar"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16612]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16612(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaserialperiferico1equipamentosalterar"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor de proximidade <tabela> [EquipamentosPageStep] [16612]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorDeProximidadeEquipamentosPageStep16612(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaserialperiferico2equipamentosalterar"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16614]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16614(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEAPassagemalterado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentosEAPassagemalterado"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEquipamentosEAPassagemalterado"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentosEAPassagemalterado"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayEquipamentosEAPassagemalterado"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAPassagemalterado")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentosEAPassagemalterado")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limiteTransacoesOffLineEquipamentosEAPassagem"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroSetorSpacenetEquipamentosEAPassagemalterado"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("semPeriodoDefinidoEquipamentosEAPassagem")));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoAcionamanetoEquipamentoEquipamentosEAPassagemalterado"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaoMotoEquipamentosEAPassagemalterado")));
            _page.MarcarAcessoPassagemEspecialEquipamento(Convert.ToBoolean(row.GetCell("acessoPassagemEspecialEquipamentosEAPassagemalterado")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somenteTAGNeposEquipamentosEAPassagemalterado")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentosEAPassagemalterado")));
            _page.MarcarMultiplosequipamentosporacesso3oumaisEquipamento(Convert.ToBoolean(row.GetCell("multiplosEquipamentosAcessoEquipamentosEAPassagem")));
            _page.SelecionarTipodeescapegatemodeEquipamentos(row.GetCell("tipoEscapeGateModeEquipamentosEAPassagem"));
            _page.SelecionarSentidodoescapegatemodeEquipamentos(row.GetCell("sentidoEscapeGateModeEquipamentosEAPassagem"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("acessoBolsaoSecundarioEquipamentosEAPassagem"));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuiCancelaEquipamentosEAPassagemalterado")));

        }

        [Step("Preencher os campos do pop-up de periférico de interfone voip <tabela> [EquipamentosPageStep] [16614]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeInterfoneVoipEquipamentosPageStep16614(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell("enderecoIPInterfoneVoipEquipamentosEAPassagemalterado"));
            _page.PreencherCodigoInterfoneVoipEquipamento(row.GetCell("codigoLeitorProximidadeEquipamentosEAPassagemalterado"));

        }


        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16614]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentosPageStep16614(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesEsperaAposTeclaAcionadaEquipamentosEAPassagemalterado")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarMensagemDetalhesEsperaEquipamentosEAPassagemalterado")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoMostrarDetalhesErroEquipamentosEAPassagemalterado"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoMostrarDetalhesEsperaEquipamentosEAPassagemalterado"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16614]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16614(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEAPassagemalterado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentosEAPassagemalterado"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEquipamentosEAPassagemalterado"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentosEAPassagemalterado"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPGatewayEquipamentosEAPassagemalterado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAPassagemalterado")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("nomeAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoPassagemEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoEquipamentoEAPassagem")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numeroSetorSpacenetEquipamentosEAPassagemalterado"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoFuncionamentoDasEquipamentosEAPassagemalterado"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoFuncionamentoAsEquipamentosEAPassagemalterado"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("modoAcionamanetoEquipamentoEquipamentosEAPassagemalterado"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaoMotoEquipamentosEAPassagemalterado")));
                _page.RetornarAcessoPassagemEspecialEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("acessoPassagemEspecialEquipamentosEAPassagemalterado")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somenteTAGNeposEquipamentosEAPassagemalterado")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentosEAPassagemalterado")));
                _page.RetornarMultiplosequipamentosporacesso3oumaisEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("multiplosEquipamentosAcessoEquipamentosEAPassagem")));
                _page.RetornarTipodeescapegatemodeEquipamentos().Should().Be(row.GetCell("tipoEscapeGateModeEquipamentosEAPassagem"));
                _page.RetornarSentidodoescapegatemodeEquipamentos().Should().Be(row.GetCell("sentidoEscapeGateModeEquipamentosEAPassagem"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("acessoBolsaoSecundarioEquipamentosEAPassagem"));
                _page.RetornarPossuicancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiCancelaEquipamentosEAPassagemalterado")));
                _page.RetornarAutoparadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("autoParadaEquipamentosEAPassagemalterado")));
                _page.RetornarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("iniciaNovaTransacaoVeiculoSobreLacoEquipamentosEAPassagemalterado")));
                _page.RetornarInicianovatransacaoaposfechamentototaldacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("iniciaNovaAposFechamentoTotalCancelaEquipamentosEAPassagemalterado")));
                _page.RetornarExistelacoparaacionamentodoequipamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existeLacoAcionamentoEquipamentoEquipamentosEAPassagemalterado")));
                _page.RetornarExistelacodefechamentodacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existeLacoFechamentoCancelaEquipamentosEAPassagemalterado")));
                _page.RetornarAguardarsinaldecancelafechadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("aguardarSinalCancelaFechadaEquipamentosEAPassagemalterado")));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesEsperaAposTeclaAcionadaEquipamentosEAPassagemalterado")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarMensagemDetalhesEsperaEquipamentosEAPassagemalterado")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoMostrarDetalhesErroEquipamentosEAPassagemalterado"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoMostrarDetalhesEsperaEquipamentosEAPassagemalterado"));
            }

        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16614]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentospagestep16614(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitorMifareEquipamentosEAPassagemalterado"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor proximidade <tabela> [EquipamentosPageStep] [16614]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorProximidadeEquipamentospagestep16614(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerailLeitorProximidadeEquipamentosEAPassagemalterado"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de interfone voip <tabela> [EquipamentosPageStep] [16614]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeinterfonevoipEquipamentosPageStep16614(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("enderecoIPInterfoneVoipEquipamentosEAPassagemalterado"));
                _page.RetornarCodigoInterfoneVoipEquipamento().Should().Be(row.GetCell("codigoLeitorProximidadeEquipamentosEAPassagemalterado"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16618]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16618(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEACalterado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquinpamentosEACalterado"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderencoIPEquipamentosEACalterado"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentosEACalterado"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayEquipamentosEACalterado"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEACalterado")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEACalterado")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limiteTransacoesOffLineEquipamentosEAC"));
            _page.MarcarDigitarMidiaEquipamento(Convert.ToBoolean(row.GetCell("digitarMidiaEquipamentosEACalterado")));
            _page.MarcarMultiplasMedasEquipamento(Convert.ToBoolean(row.GetCell("multiplasMedasEquipamentosEACalterado")));
            _page.MarcarBloquearPagamentosEquipamento(Convert.ToBoolean(row.GetCell("bloquearPagamentosEquipamentosEAC")));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16618]")]
        public void PreencherOsCamposDaTelaNaSecaoDeConfiguracoesDeSuporteEquipamentospagestep166182(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostarDetalhesAposTeclaAcionadaEquipamentosEACalterado")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarMensagemEsperaEquipamentosEACalterado")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesErroEquipamentosEACalterado"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesEsperaEquipamentosEACalterado"));
        }

        [Step("Verificar os campos do pop-up de periférico de Tarja Magnética <tabela> [EquipamentosPageStep] [16618]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeTarjaMagneticaEquipamentosPageStep16618(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitorTarjaEquipamentosEACalterado"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16618]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentosPageStep16618(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialCRT288EquipamentosEACalterado"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [16618]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraPageStep16618(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialImpressorEquipamentosEACalterado"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16618]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16618(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEACalterado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquinpamentosEACalterado"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderencoIPEquipamentosEACalterado"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentosEACalterado"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPGatewayEquipamentosEACalterado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEACalterado")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("nomeAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoValidacaoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEAC")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEACalterado")));
                _page.RetornarPreenchimentoDeLimiteDeTransacoesOffLineEquipamento().Should().Be(row.GetCell("limiteTransacoesOffLineEquipamentosEAC"));
                _page.RetornarDigitarMidiaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("digitarMidiaEquipamentosEACalterado")));
                _page.RetornarMultiplasMedasEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("multiplasMedasEquipamentosEACalterado")));
                _page.RetornarBloquearPagamentosEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("bloquearPagamentosEquipamentosEAC")));


            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16619]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16619(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEAPalterar"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentosEAPalterar"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderencoIPEquipamentosEAPalterar"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentosEAPalterar"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPGatewayEquipamentosEAPalterar"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAPalterar")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEAPalterar")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limitesDeTransacoesOffLineEquipamentosEAPalterar"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("setorSpacenetEquipamentosEAPalterar"));
            _page.MarcarHabilitarValidacaoComCartaoDebito(Convert.ToBoolean(row.GetCell("habilitarValidacaoComCartaoDeDebitoEquipamentosEAPalterar")));
            _page.MarcarHabilitarValidacaoEmDinheiro(Convert.ToBoolean(row.GetCell("habilitarValidacaoEmDinheiroEquipamentosEAPalterar")));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16619]")]
        public void PreencherOsCamposDaTelaNaSecaoDeConfiguracoesDeSuporteEquipamentospagestep16619(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostarDetalhesAposTeclaAcionadaEquipamentosEAPalterar")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarMensagemEsperaEquipamentosEAPalterar")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesErroEquipamentosEAPalterar"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesEsperaEquipamentosEAPalterar"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16619]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16619(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEAPalterar"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentosEAPalterar"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderencoIPEquipamentosEAPalterar"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentosEAPalterar"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPGatewayEquipamentosEAPalterar"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentosEAPalterar")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacaoOffLineEquipamentosEAPalterar")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("setorSpacenetEquipamentosEAPalterar"));
                _page.RetornarHabilitarValidacaoComCartaoDebito().Should().Be(Convert.ToBoolean(row.GetCell("habilitarValidacaoComCartaoDeDebitoEquipamentosEAPalterar")));
                _page.RetornarHabilitarValidacaoEmDinheiro().Should().Be(Convert.ToBoolean(row.GetCell("habilitarValidacaoEmDinheiroEquipamentosEAPalterar")));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostarDetalhesAposTeclaAcionadaEquipamentosEAPalterar")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarMensagemEsperaEquipamentosEAPalterar")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesErroEquipamentosEAPalterar"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesEsperaEquipamentosEAPalterar"));
            }
        }


        [Step("Verificar os campos do pop-up de periférico de leitor mifare <tabela> [EquipamentosPageStep] [16619]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorMifareEquipamentospagestep16619(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialCRT288EquipamentosEAPalterar"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [16619]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep16619(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialImpressoraEquipamentosEAPalterar"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16620]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16620(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEquipamentoAlterar"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoAlterar"));
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoAlterar")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoAlterar")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoAlterar"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoAlterar"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16620]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16620(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEquipamentoAlterar"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoAlterar"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoAlterar")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoAlterar")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoAlterar"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoAlterar"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16627]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16627(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEquipamentoEAEMifare")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limiteDeTransacaoOffline"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenet"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDas"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAs"));
        }

        [Step("No combobox Tipo do periférico selecionar a opção de leitora Mifare <leitorMifareEquipamentoEAEMifare> [EquipamentosPageStep] [16627]")]
        public void NoComboboxTipoDoPerifericoSelecionarAOpcaoLeitorMifareEquipamentospagestep16627(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorMifareEquipamentoEAEMifare"));
        }

        [Step("No combobox Tipo do periférico selecionar a opção leitor de Proximidade <leitorProximidadeEquipamentoEAEMifare> [EquipamentosPageStep] [16627]")]
        public void NoComboboxTipoDoPerifericoSelecionarAOpcaoLeitorProximidadeEquipamentospagestep16627(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorProximidadeEquipamentoEAEMifare"));
        }

        [Step("No combobox Tipo do periférico selecionar a opção Tela VGA <telaVgaEquipamentoEAEMifare> [EquipamentosPageStep] [16627]")]
        public void NoComboboxTipoDoPerifericoSelecionarAOpcaoTelaVgaEquipamentospagestep16627(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("telaVgaEquipamentoEAEMifare"));
        }

        [Step("Preencher os campos da tela na seção Funções de operação <tabela> [EquipamentosPageStep] [16628]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16628(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limiteDeTransacaoOffline"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenet"));

        }

        [Step("Preencher os campos da tela geral <tabela> [EquipamentosPageStep] [16628]")]
        public void PreencherOsCamposDaTelaGeralEquipamentospagestep16628(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoSaidaEquipamento(Convert.ToBoolean(row.GetCell("saidaequipamentos")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limiteDeTransacaoOffline"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenet"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDas"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAs"));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoDeAcionamentoDoEquipamento"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentos")));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentos")));
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16629]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16629(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoPassagemEquipamentos")));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDas"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAs"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentos")));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentos")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limiteTransacoesOffLineEquipamentosEAPassagem"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroSetorSpacenetEquipamentosEAPassagem"));

        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16630]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16630(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEAC")));
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16631]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16631(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEAP")));
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16632]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEquipamentoEAEBarcode"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoEAEBarcode"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEquipamentoEAEBarcode"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentoEAEBarcode"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPDoGatewayEquipamentoEAEBarcode"));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEquipamentoEAEBarcode")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentoEAEBarcode")));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenetEquipamentoEAEBarcode"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDasEquipamentoEAEBarcode"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAsEquipamentoEAEBarcode"));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamentoEAEBarcode"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamentoEAEBarcode")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamentoEAEBarcode")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoEAEBarcode")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
        }

        [Step("Preencher os campos do pop-up de periférico de leitora 1D2D <tabela> [EquipamentosPageStep] [16632]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitora1D2DEquipamentosPageStep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitor1D2DEquipamentoEAEBarcode"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitor1D2DEquipamentoEAEBarcode")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarLeitor1D2DEquipamentoEAEBarcode")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloLeitor1D2DEquipamentoEAEBarcode"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialLeitor1D2DEquipamentoEAEBarcode"));

        }

        [Step("Preencher os campos do pop-up de periférico de leitor Tag <tabela> [EquipamentosPageStep] [16632]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitorDeTagEquipamentosPageStep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("leitorTagEquipamentoEAEBarcode"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarLeitorTagEquipamentoEAEBarcode")));
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell("enderecoIPLeitorTagEquipamentoEAEBarcode"));
            _page.PreencherMascaraIpPopUpEquipamento(row.GetCell("mascaraIPLeitorTagEquipamentoEAEBarcode"));
            _page.PreencherGatewayIpPopUpEquipamento(row.GetCell("iPDoGatewayLeitorTagEquipamentoEAEBarcode"));
            _page.SelecionarTipodeinstalacaooperacaodaleitoraantenatagequipamento(row.GetCell("tipoDeInstalacaoOperacaoDaLeitoraAntenaLeitorTagEquipamentoEAEBarcode"));
            _page.PreencherCanaldaantenaconectadoaoleitoraantenaequipamento(row.GetCell("canalDaAntenaConectadoAoLeitorLeitorTagEquipamentoEAEBarcode"));
            _page.PreencherIgnorarleituradamesmatagporsegequipamentos(row.GetCell("ignorarLeituraDaMesmaTagLeitorTagEquipamentoEAEBarcode"));
            _page.PreencherConsiderarleiturasrealizadashaatedecimosdesegequipamento(row.GetCell("considerarLeiturasRealizadasHaAteLeitorTagEquipamentoEAEBarcode"));
        }

        [Step("Preencher os campos do pop-up de periférico de Impressora <tabela> [EquipamentosPageStep] [16632]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitoraImpressoraEquipamentosPageStep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("impressoraEquipamentoEAEBarcode"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEquipamentoEAEBarcode")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarImpressoraEquipamentoEAEBarcode")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloDaImpressoraEquipamentoEAEBarcode"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialImpressoraEquipamentoEAEBarcode"));
        }

        [Step("Preencher os campos do pop-up de periférico de placa de som <tabela> [EquipamentosPageStep] [16632]")]
        public void PreencherOsCampoDoPopupDePerifericoDePlacaDeSomEquipamentosPageStep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("placaDeSomEquipamentoEAEBarcode"));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPlacaDeSomEquipamentoEAECodex")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloDaPlacaDeSomEquipamentoEAECodex"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16632]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentospagestep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEBarcode")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEBarcode")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoEAEBarcode"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoEAEBarcode"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16632]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEquipamentoEAEBarcode"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAEBarcode"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEquipamentoEAEBarcode"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentoEAEBarcode"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayEquipamentoEAEBarcode"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentoEAEBarcode")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("nomeAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEquipamentoEAEBarcode")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentoEAEBarcode")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numeroDoSetorSpacenetEquipamentoEAEBarcode"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoDasEquipamentoEAEBarcode"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoAsEquipamentoEAEBarcode"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamentoEAEBarcode"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamentoEAEBarcode")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamentoEAEBarcode")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoEAEBarcode")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEBarcode")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEBarcode")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoEAEBarcode"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoEAEBarcode"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de Leitora 1D/2D <tabela> [EquipamentosPageStep] [16632]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitor1D2DEquipamentoEAEBarcode"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitor1D2DEquipamentoEAEBarcode")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLeitor1D2DEquipamentoEAEBarcode")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitor1D2DEquipamentoEAEBarcode"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitor1D2DEquipamentoEAEBarcode"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [16632]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeEquipamentospagestep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("impressoraEquipamentoEAEBarcode"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEquipamentoEAEBarcode")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarImpressoraEquipamentoEAEBarcode")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloDaImpressoraEquipamentoEAEBarcode"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialImpressoraEquipamentoEAEBarcode"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor tag <tabela> [EquipamentosPageStep] [16632]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorTagEquipamentospagestep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorTagEquipamentoEAEBarcode"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorTagEquipamentoEAEBarcode")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLeitorTagEquipamentoEAEBarcode")));
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("enderecoIPLeitorTagEquipamentoEAEBarcode"));
                _page.RetornarMascaraIpPopUpEquipamento().Should().Be(row.GetCell("mascaraIPLeitorTagEquipamentoEAEBarcode"));
                _page.RetornarGatewayIpPopUpEquipamento().Should().Be(row.GetCell("iPDoGatewayLeitorTagEquipamentoEAEBarcode"));
                _page.RetornarTipodeinstalacaooperacaodaleitoraantenatagequipamento().Should().Be(row.GetCell("tipoDeInstalacaoOperacaoDaLeitoraAntenaLeitorTagEquipamentoEAEBarcode"));
                _page.RetornarCanaldaantenaconectadoaoleitoraantenaequipamento().Should().Be(row.GetCell("canalDaAntenaConectadoAoLeitorLeitorTagEquipamentoEAEBarcode"));
                _page.RetornarIgnorarleituradamesmatagporsegequipamentos().Should().Be(row.GetCell("ignorarLeituraDaMesmaTagLeitorTagEquipamentoEAEBarcode"));
                _page.RetornarConsiderarleiturasrealizadashaatedecimosdesegequipamento().Should().Be(row.GetCell("considerarLeiturasRealizadasHaAteLeitorTagEquipamentoEAEBarcode"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de placa de som <tabela> [EquipamentosPageStep] [16632]")]
        public void VerificarOsCamposDoPopUpDePerifericoDePlacaDeSomEquipamentospagestep16632(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("placaDeSomEquipamentoEAEBarcode"));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPlacaDeSomEquipamentoEAECodex")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloDaPlacaDeSomEquipamentoEAECodex"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16633]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16633(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numerodoequipamentoequipamentos"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEASBarcodeequipamentos"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPequipamentos"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPequipamentos"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPdogatewayequipamentos"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoequipamentos")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("nomeAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoSaidaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("saidaequipamentos")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semlimiteequipamentos")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numerodosetorspacenetequipamentos"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("dasequipamentos"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("asequipamentos"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("mododeacionamentodoequipamentoequipamentos"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentos")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentos")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentos")));
                _page.RetornarMultiplosequipamentosporacesso3oumaisEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("multiplosequipamentosporacesso3oumaisequipamentosequipamentos")));
                _page.RetornarTipodeescapegatemodeEquipamentos().Should().Be(row.GetCell("tipodeescapegatemodeequipamentos"));
                _page.RetornarSentidodoescapegatemodeEquipamentos().Should().Be(row.GetCell("sentidodoescapegatemodeequipamentos"));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarEquipamentoEscapeGateModevinculadoEquipamento().Should().Be(row.GetCell("equipamentoEscapeGateModevinculadoequipamentos"));
                _page.RetornarPossuicancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuicancelaequipamentos")));
                _page.RetornarAutoparadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("autoparadaequipamentos")));
                _page.RetornarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("inicianovatransacaocomveiculossobreolacodefechamentoequipamentos")));
                _page.RetornarInicianovatransacaoaposfechamentototaldacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("inicianovatransacaoaposfechamentototaldacancelaequipamentos")));
                _page.RetornarExistelacoparaacionamentodoequipamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existelacoparaacionamentodoequipamentoequipamentos")));
                _page.RetornarExistelacodefechamentodacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existelacodefechamentodacancelaequipamentos")));
                _page.RetornarAguardarsinaldecancelafechadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("aguardarsinaldecancelafechadaequipamentos")));
                _page.RetornarTempolimitepararespostadacancelasegEquipamento().Should().Be(row.GetCell("tempolimitepararespostadacancelasegequipamentos"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentos")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentos")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentos"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentos"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor 1D2D <tabela> [EquipamentosPageStep] [16633]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16633(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipodoperifericoperiferico1equipamentos"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoprincipalperiferico1equipamentos")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarperiferico1equipamentos")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modelodoleitorperiferico1equipamentos"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaserialperiferico1equipamentos"));
                _page.RetornarLaserContinuo1D2DEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarlasercontinuoperiferico1equipamentos")));
                _page.RetornarLeituraSeloDescontoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarleituradeselodedescontoperiferico1equipamentos")));
                _page.RetornarVerificarDigitoVerificador1D2DEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarverificacaododigitoverificadordemidiascodigodebarrasperiferico1equipamentos")));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor tag <tabela> [EquipamentosPageStep] [16633]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorTagEquipamentospagestep16633(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipodoperifericoperiferico2equipamentos"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoprincipalperiferico2equipamentos")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarperiferico2equipamentos")));
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("enderecoIPperiferico2equipamentos"));
                _page.RetornarMascaraIpPopUpEquipamento().Should().Be(row.GetCell("mascaraIPperiferico2equipamentos"));
                _page.RetornarGatewayIpPopUpEquipamento().Should().Be(row.GetCell("iPdogatewayperiferico2equipamentos"));
                _page.RetornarTipodeinstalacaooperacaodaleitoraantenatagequipamento().Should().Be(row.GetCell("tipodeinstalacaooperacaodaleitoraantenaperiferico2equipamentos"));
                _page.RetornarCanaldaantenaconectadoaoleitoraantenaequipamento().Should().Be(row.GetCell("canaldaantenaconectadoaoleitorperiferico2equipamentos"));
                _page.RetornarIgnorarleituradamesmatagporsegequipamentos().Should().Be(row.GetCell("ignorarleituradamesmatagporsegperiferico2equipamentos"));
                _page.RetornarConsiderarleiturasrealizadashaatedecimosdesegequipamento().Should().Be(row.GetCell("considerarleiturasrealizadashaatedecimosdesegperiferico2equipamentos"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16634]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16634(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEquipamento"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamento"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEquipamento"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamento"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayEquipamento"));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEquipamento"));
                _page.RetornarFuncaoDeOperacaoPassagemEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemAplicativoDoEquipamentoEquipamento")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamento")));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numeroDoSetorSpacenetEquipamento"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoDasEquipamento"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoAsEquipamento"));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamento"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamento")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamento")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamento")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamento")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamento"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamento"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor 1D2D <tabela> [EquipamentosPageStep] [16634]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16634(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorBarcode1D2DEquipamento"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitor1D2DEquipamento")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoPrincipalLeitor1D2DEquipamento")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloLeitor1D2DEquipamento"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitor1D2DEquipamento"));
                _page.RetornarLaserContinuo1D2DEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLaserContinuoEquipamento")));
                _page.RetornarLeituraSeloDescontoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarLeituraDeSeloDeDescontoEquipamento")));
                _page.RetornarVerificarDigitoVerificador1D2DEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarVerificacaoDoDigitoVerificadorDeMidiasCodigoDeBarrasEquipamento")));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor tag <tabela> [EquipamentosPageStep] [16634]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorTagEquipamentospagestep16634(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("leitorTagEquipamento"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalLeitorTagEquipamento")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoLeitorTagEquipamento")));
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("enderecoIPLeitorTagEquipamento"));
                _page.RetornarMascaraIpPopUpEquipamento().Should().Be(row.GetCell("mascaraIPLeitorTagEquipamento"));
                _page.RetornarGatewayIpPopUpEquipamento().Should().Be(row.GetCell("iPDoGatewayLeitorTagEquipamento"));
                _page.RetornarTipodeinstalacaooperacaodaleitoraantenatagequipamento().Should().Be(row.GetCell("tipoDeInstalacaoOperacaoLeitoraAntenaLeitorTagEquipamento"));
                _page.RetornarCanaldaantenaconectadoaoleitoraantenaequipamento().Should().Be(row.GetCell("canalDaAntenaConectadoAoLeitorTagEquipamento"));
                _page.RetornarIgnorarleituradamesmatagporsegequipamentos().Should().Be(row.GetCell("ignorarLeituraDaMesmaTagLeitorTagEquipamento"));
                _page.RetornarConsiderarleiturasrealizadashaatedecimosdesegequipamento().Should().Be(row.GetCell("considerarLeiturasRealizadasHaAteDecimosTagLeitorTagEquipamento"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16635]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16635(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEquipamentoEAEBarcodealterar"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoEAEBarcodealterar"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEquipamentoEAEBarcodealterar"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEquipamentoEAEBarcodealterar"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPDoGatewayEquipamentoEAEBarcodealterar"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamentoEAEBarcodealterar")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentoEAEBarcodealterar")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limitedetransacoesofflineequipamentosalterar"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenetEquipamentoEAEBarcodealterar"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("semperiododefinidoequipamentosalterar")));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoDeAcionamentoDoEquipamentoEquipamentoEAEBarcodealterar"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamentoEAEBarcodealterar")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamentoEAEBarcodealterar")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoEAEBarcodealterar")));
            _page.MarcarMultiplosequipamentosporacesso3oumaisEquipamento(Convert.ToBoolean(row.GetCell("multiplosequipamentosporacesso3oumaisequipamentosequipamentosalterar")));
            _page.SelecionarTipodeescapegatemodeEquipamentos(row.GetCell("tipodeescapegatemodeequipamentosalterar"));
            _page.SelecionarSentidodoescapegatemodeEquipamentos(row.GetCell("sentidodoescapegatemodeequipamentosalterar"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("acessobolsaosecundarioequipamentosalterar"));
            _page.MarcarPossuicancelaEntradaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentosalterar")));
            _page.MarcarAutoparadaEntradaEquipamento(Convert.ToBoolean(row.GetCell("autoparadaequipamentosalterar")));
            _page.MarcarInicianovatransacaocomveiculossobreolacodefechamentoEntradaEquipamento(Convert.ToBoolean(row.GetCell("inicianovatransacaocomveiculossobreolacodefechamentoequipamentosalterar")));
            _page.MarcarInicianovatransacaoaposfechamentototaldacancelaEntradaEquipamento(Convert.ToBoolean(row.GetCell("inicianovatransacaoaposfechamentototaldacancelaequipamentosalterar")));
            _page.MarcarExistelacoparaacionamentodoequipamentoEntradaEquipamento(Convert.ToBoolean(row.GetCell("existelacoparaacionamentodoequipamentoequipamentosalterar")));
            _page.MarcarExistelacodefechamentodacancelaEntradaEquipamento(Convert.ToBoolean(row.GetCell("existelacodefechamentodacancelaequipamentosalterar")));
            _page.MarcarAguardarsinaldecancelafechadaEntradaEquipamento(Convert.ToBoolean(row.GetCell("aguardarsinaldecancelafechadaequipamentosalterar")));
            _page.PreencherTempolimitepararespostadacancelasegEntradaEquipamento(row.GetCell("tempolimitepararespostadacancelasegequipamentosalterar"));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16635]")]
        public void PreencherOsCamposDaTelaSecaoDeConfiguracaoDeSuporteEquipamentospagestep16635(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEBarcodealterar")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEBarcodealterar")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoEAEBarcodealterar"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoEAEBarcodealterar"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16635]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16635(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEquipamentoEAEBarcodealterar"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAEBarcodealterar"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEquipamentoEAEBarcodealterar"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEquipamentoEAEBarcodealterar"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayEquipamentoEAEBarcodealterar"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentoEAEBarcodealterar")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semLimiteTransacoesOffLineEquipamentoEAEBarcodealterar")));
                _page.RetornarLimiteDeTransacoesOffLineEquipamento().Should().Be(row.GetCell("limitedetransacoesofflineequipamentosalterar"));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numeroDoSetorSpacenetEquipamentoEAEBarcodealterar"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semperiododefinidoequipamentosalterar")));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaoDeMotoEquipamentoEAEBarcodealterar")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somenteTagNeposEquipamentoEAEBarcodealterar")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoEAEBarcodealterar")));
                _page.RetornarMultiplosequipamentosporacesso3oumaisEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("multiplosequipamentosporacesso3oumaisequipamentosequipamentosalterar")));
                _page.RetornarTipodeescapegatemodeEquipamentos().Should().Be(row.GetCell("tipodeescapegatemodeequipamentosalterar"));
                _page.RetornarSentidodoescapegatemodeEquipamentos().Should().Be(row.GetCell("sentidodoescapegatemodeequipamentosalterar"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("acessobolsaosecundarioequipamentosalterar"));
                _page.RetornarPossuicancelaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuicancelaequipamentosalterar")));
                _page.RetornarAutoparadaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("autoparadaequipamentosalterar")));
                _page.RetornarInicianovatransacaocomveiculossobreolacodefechamentoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("inicianovatransacaocomveiculossobreolacodefechamentoequipamentosalterar")));
                _page.RetornarInicianovatransacaoaposfechamentototaldacancelaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("inicianovatransacaoaposfechamentototaldacancelaequipamentosalterar")));
                _page.RetornarExistelacoparaacionamentodoequipamentoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existelacoparaacionamentodoequipamentoequipamentosalterar")));
                _page.RetornarExistelacodefechamentodacancelaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("existelacodefechamentodacancelaequipamentosalterar")));
                _page.RetornarAguardarsinaldecancelafechadaEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("aguardarsinaldecancelafechadaequipamentosalterar")));
                _page.RetornarTempolimitepararespostadacancelasegEntradaEquipamento().Should().Be(row.GetCell("tempolimitepararespostadacancelasegequipamentosalterar"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrarDetalhesDeEsperaAposTeclaAcionadaEquipamentoEAEBarcodealterar")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarEntreMensagemEDetalhesDeEsperaEquipamentoEAEBarcodealterar")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeErroEquipamentoEAEBarcodealterar"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoParaMostrarDetalhesDeEsperaEquipamentoEAEBarcodealterar"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor 1D/2D <tabela> [EquipamentosPageStep] [16635]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16635(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialLeitor1D2DEquipamentoEAEBarcodealterar"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [16635]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorImpressoraEquipamentospagestep16635(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialImpressoraEquipamentoEAEBarcodealterar"));
            }
        }


        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16636]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16636(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numerodoequipamentoequipamentosalterar"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEASBarcodeequipamentosalterar"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPequipamentosalterar"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPequipamentosalterar"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPdogatewayequipamentosalterar"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoequipamentosalterar")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("semlimiteequipamentosalterar")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limitedetransacoesofflineequipamentosalterar"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numerodosetorspacenetequipamentosalterar"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("semperiododefinidoequipamentosalterar")));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("mododeacionamentodoequipamentoequipamentosalterar"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentosalterar")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentosalterar")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentosalterar")));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentosalterar")));

        }

        [Step("Preencher os campos da tela, na seção de configurações de suporte <tabela> [EquipamentosPageStep] [16636]")]
        public void PreencherOsCamposDaTelanaSecaoDeConfiguracoesDeSuporteEquipamentospagestep16636(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentosalterar")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentosalterar")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentosalterar"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentosalterar"));

        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16636]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16636(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numerodoequipamentoequipamentosalterar"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEASBarcodeequipamentosalterar"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPequipamentosalterar"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPequipamentosalterar"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPdogatewayequipamentosalterar"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoequipamentosalterar")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semlimiteequipamentosalterar")));
                _page.RetornarPreenchimentoDeLimiteDeTransacoesOffLineEquipamento().Should().Be(row.GetCell("limitedetransacoesofflineequipamentosalterar"));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("numerodosetorspacenetequipamentosalterar"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semperiododefinidoequipamentosalterar")));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("mododeacionamentodoequipamentoequipamentosalterar"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("deteccaodemotoequipamentosalterar")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("somentetagNeposequipamentosalterar")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentosalterar")));
                _page.RetornarPossuicancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuicancelaequipamentosalterar")));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("mostrardetalhesdeesperaaposteclaacionadaequipamentosalterar")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alternarentremensagemedetalhesdeesperaequipamentosalterar")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeerrosegequipamentosalterar"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("tempoparamostrardetalhesdeesperasegequipamentosalterar"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor 1D2D <tabela> [EquipamentosPageStep] [16636]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16636(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaserialperiferico1equipamentosalterar"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16637]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16637(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("alterarNumeroDoEquipamentoEquipamento"));
            _page.PreencherNomeEquipamento(row.GetCell("alterarNomeEquipamento"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("alterarEnderecoIPEquipamento"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("alterarMascaraIPEquipamento"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("alterarIPDoGatewayEquipamento"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("alterarHabilitadoEquipamento")));
            _page.MarcarSemLimiteTransacoesOffLineEquipamento(Convert.ToBoolean(row.GetCell("alterarSemLimiteTransacoesOffLineEquipamento")));
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("alterarLimiteDeTransacoesOffLineEquipamento"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("alterarNumeroDoSetorSpacenetEquipamento"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("alterarSemPeriodoDeFuncionamentoEquipamento")));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("alterarModoDeAcionamentoDoEquipamentoEquipamento"));
            _page.MarcarDeteccaoDeMotoEquipamento(Convert.ToBoolean(row.GetCell("alterarDeteccaoDeMotoEquipamento")));
            _page.MarcarSomenteTagNeposEquipamento(Convert.ToBoolean(row.GetCell("alterarSomenteTagNeposEquipamento")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("alterarPossuiEscapeGateModeEquipamento")));
            _page.MarcarMultiplosequipamentosporacesso3oumaisEquipamento(Convert.ToBoolean(row.GetCell("alterarMultiplosEquipamentosPorAcessoEquipamento")));
            _page.SelecionarTipodeescapegatemodeEquipamentos(row.GetCell("tipoDeEscapeGateModeEquipamento"));
            _page.SelecionarSentidodoescapegatemodeEquipamentos(row.GetCell("sentidoDoEscapeGateModeEquipamento"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("acessoBolsaoSecundarioEquipamento"));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("alterarPossuiCancelaEquipamento")));
            _page.MarcarAutoparadaEquipamento(Convert.ToBoolean(row.GetCell("alterarAutoParadaEquipamento")));
            _page.MarcarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento(Convert.ToBoolean(row.GetCell("alterarIniciaNovaTransacaoComVeiculoSobreOLacoDeFechamentoEquipamento")));
            _page.MarcarInicianovatransacaoaposfechamentototaldacancelaEquipamento(Convert.ToBoolean(row.GetCell("alterarIniciaNovaTransacaoAposFechamentototalDaCancelaEquipamento")));
            _page.MarcarExistelacoparaacionamentodoequipamentoEquipamento(Convert.ToBoolean(row.GetCell("alterarExisteLacoParaAcionamentoDoEquipamentoEquipamento")));
            _page.MarcarExistelacodefechamentodacancelaEquipamento(Convert.ToBoolean(row.GetCell("alterarExisteLacoDeFechamentoDaCancelaEquipamento")));
            _page.MarcarAguardarsinaldecancelafechadaEquipamento(Convert.ToBoolean(row.GetCell("alterarAguardarSinalDeCancelaFechadaEquipamento")));
            _page.PreencherTempolimitepararespostadacancelasegEquipamento(row.GetCell("alterarTempoLimiteParaRepostaDaCancelaEquipamento"));
            _page.MarcarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento(Convert.ToBoolean(row.GetCell("alterarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento")));
            _page.MarcarAlternarEntreMensagemEDetalhesDeEsperaEquipamento(Convert.ToBoolean(row.GetCell("alterarAlternarEntreMensagemEDetalhesDeEsperaEquipamento")));
            _page.PreencherTempoParaMostrarDetalhesDeErroEquipamento(row.GetCell("alterarTempoParaMostrarDetalhesDeErroEquipamento"));
            _page.PreencherTempoParaMostrarDetalhesDeEsperaEquipamento(row.GetCell("alterarTempoParaMostrarDetalhesDeEsperaEquipamento"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [16637]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep16637(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("alterarNumeroDoEquipamentoEquipamento"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("alterarNomeEquipamento"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("alterarEnderecoIPEquipamento"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("alterarMascaraIPEquipamento"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("alterarIPDoGatewayEquipamento"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarHabilitadoEquipamento")));
                _page.RetornarSemLimiteTransacoesOffLineEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarSemLimiteTransacoesOffLineEquipamento")));
                _page.RetornarPreenchimentoDeLimiteDeTransacoesOffLineEquipamento().Should().Be(row.GetCell("alterarLimiteDeTransacoesOffLineEquipamento"));
                _page.RetornarNumeroDoSetorSpacenetEquipamento().Should().Be(row.GetCell("alterarNumeroDoSetorSpacenetEquipamento"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarPeriodoDeFuncionamentoEquipamento")));
                _page.RetornarModoDeAcionamentoDoEquipamento().Should().Be(row.GetCell("alterarModoDeAcionamentoDoEquipamentoEquipamento"));
                _page.RetornarDeteccaoDeMotoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarDeteccaoDeMotoEquipamento")));
                _page.RetornarSomenteTagNeposEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarSomenteTagNeposEquipamento")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarPossuiEscapeGateModeEquipamento")));
                _page.RetornarMultiplosequipamentosporacesso3oumaisEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarMultiplosEquipamentosPorAcessoEquipamento")));
                _page.RetornarTipodeescapegatemodeEquipamentos().Should().Be(row.GetCell("tipoDeEscapeGateModeEquipamento"));
                _page.RetornarSentidodoescapegatemodeEquipamentos().Should().Be(row.GetCell("sentidoDoEscapeGateModeEquipamento"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("acessoBolsaoSecundarioEquipamento"));
                _page.RetornarPossuicancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarPossuiCancelaEquipamento")));
                _page.RetornarAutoparadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarAutoParadaEquipamento")));
                _page.RetornarInicianovatransacaocomveiculossobreolacodefechamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarIniciaNovaTransacaoComVeiculoSobreOLacoDeFechamentoEquipamento")));
                _page.RetornarInicianovatransacaoaposfechamentototaldacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarIniciaNovaTransacaoAposFechamentototalDaCancelaEquipamento")));
                _page.RetornarExistelacoparaacionamentodoequipamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarExisteLacoParaAcionamentoDoEquipamentoEquipamento")));
                _page.RetornarExistelacodefechamentodacancelaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarExisteLacoDeFechamentoDaCancelaEquipamento")));
                _page.RetornarAguardarsinaldecancelafechadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarAguardarSinalDeCancelaFechadaEquipamento")));
                _page.RetornarTempolimitepararespostadacancelasegEquipamento().Should().Be(row.GetCell("alterarTempoLimiteParaRepostaDaCancelaEquipamento"));
                _page.RetornarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarMostrarDetalhesDeEsperaAposTeclaAcionadaEquipamento")));
                _page.RetornarAlternarEntreMensagemEDetalhesDeEsperaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("alterarAlternarEntreMensagemEDetalhesDeEsperaEquipamento")));
                _page.RetornarTempoParaMostrarDetalhesDeErroEquipamento().Should().Be(row.GetCell("alterarTempoParaMostrarDetalhesDeErroEquipamento"));
                _page.RetornarTempoParaMostrarDetalhesDeEsperaEquipamento().Should().Be(row.GetCell("alterarTempoParaMostrarDetalhesDeEsperaEquipamento"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor 1D2D <tabela> [EquipamentosPageStep] [16637]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitor1D2DEquipamentospagestep16637(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("alterarPortaSerialLeitor1D2DEquipamento"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de leitor tag <tabela> [EquipamentosPageStep] [16637]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeLeitorTagEquipamentospagestep16637(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("alterarEnderecoIPLeitorTagEquipamento"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16638]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16638(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaEAE")));
        }

        [Step("Preencher os campos da tela, na seção função de operação <tabela> [EquipamentosPageStep] [16639]")]
        public void PreencherOsCamposDaTelaSecaoFuncaoDeOperacaoEquipamentospagestep16639(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherLimiteDeTransacoesOffLineEquipamento(row.GetCell("limiteDeTransacaoOffline"));
            _page.PreencherNumeroDoSetorSpacenetEquipamento(row.GetCell("numeroDoSetorSpacenet"));

        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16639]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16639(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoSaidaEquipamento(Convert.ToBoolean(row.GetCell("saidaequipamentos")));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDas"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAs"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiescapegatemodeequipamentos")));
            _page.MarcarPossuicancelaEquipamento(Convert.ToBoolean(row.GetCell("possuicancelaequipamentos")));
            _page.SelecionarModoDeAcionamentoDoEquipamento(row.GetCell("modoDeAcionamentoDoEquipamento"));
        }


        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [16643]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep16643(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("nomeAplicativoVersao"));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemAplicativoDoEquipamentoEquipamento")));

        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17182]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep17182(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEAEInformatizado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoEAEInformatizado"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEAEInformatizado"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEAEInformatizado"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPDoGatewayEAEInformatizado"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEAEInformatizado")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoDoEquipamentoEAEInformatizado"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEAEInformatizado")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDoInformatizadoEAEInformatizado"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDasEAEInformatizado"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAsEAEInformatizado"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAEInformatizado")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
        }

        [Step("Preencher os campos do pop-up de periférico de Impressora <tabela> [EquipamentosPageStep] [17182]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitoraImpressoraEquipamentosPageStep17182(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("impressoraEAEInformatizado"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEAEInformatizado")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarImpressoraEAEInformatizado")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloDaImpressoraEAEInformatizado"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialEAEInformatizado"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17182]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17182(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEAEInformatizado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAEInformatizado"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEAEInformatizado"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEAEInformatizado"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayEAEInformatizado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEAEInformatizado")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEAEInformatizado"));
                _page.RetornarFuncaoDeOperacaoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEAEInformatizado")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoDoInformatizadoEAEInformatizado"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoDasEAEInformatizado"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoAsEAEInformatizado"));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAEInformatizado")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17182]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17182(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("impressoraEAEInformatizado"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEAEInformatizado")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarImpressoraEAEInformatizado")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloDaImpressoraEAEInformatizado"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialEAEInformatizado"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17183]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17183(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEASInformatizado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquinpamentosEASInformatizado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoInformatizadoEquipamento")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoInformatizadoEquipamento"));
                _page.RetornarFuncaoDeOperacaoSaidaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEASInformatizado")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoInformatizadoEquipamento"));
                _page.RetornarNomeUsuarioSistemaEquipamento().Should().Be(row.GetCell("nomeUsuarioSistema"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoFuncionamentoDasEquipamento"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoFuncionamentoAsEquipamento"));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamento")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("acessoBolsaoSecundarioEquipamento"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17183]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17183(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipoPerifericoInformatizadoEquipamento"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalInformatizadoEquipamento")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarInformatizadoEquipamento")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloImpressoraInformatizadoEquipamento"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialInformatizadoEquipamento"));
            }
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17185]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17185(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numerodoequipamentoequipamentos"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeValidacaoInformatizadoEquipamentos"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderencoIPEquipamentosInformatizado"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPValidacaoInformatizadoEquipamentos"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPGatewayValidacaoInformatizadoEquipamentos"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoValidacaoInformatizadoEquipamentos")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("listaAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoValidacaoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValidacaoInformatizadoEquipamentos")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoDeInformatizadoValidacaoEquipamentos"));
                _page.RetornarMultiplasMedasEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("utilizarMutiplasMoedasInformatizadoValidacaoEquipamentos")));
                _page.RetornarBloquearPagamentosEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("bloquearPagamentosInformatizadoValidacaoEquipamentos")));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17185]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17185(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipoDoPerifericoValidacaoInformatizado"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraValidacaoInformatizado")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressoraValidacaoInformatizado")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloImpressoraValidacaoInformatizado"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialImpressoraValidacaoInformatizadoEquipamentos"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17186]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep17186(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEAPInformatizado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoEAPInformatizado"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIPEAPInformatizado"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIPEAPInformatizado"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPDoGatewayEAPInformatizado"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEAPInformatizado")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoDoEquipamentoEAPInformatizado"));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemAplicativoDoEquipamentoEAPInformatizado")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDoInformatizadoEAPInformatizado"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDasEAPInformatizado"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAsEAPInformatizado"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAPInformatizado")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
        }

        [Step("Preencher os campos do pop-up de periférico de Impressora <tabela> [EquipamentosPageStep] [17186]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitoraImpressoraEquipamentosPageStep17186(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("impressoraEAPInformatizado"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEAPInformatizado")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarImpressoraEAPInformatizado")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloDaImpressoraEAPInformatizado"));
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialEAPInformatizado"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17186]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17186(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEAPInformatizado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAPInformatizado"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIPEAPInformatizado"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIPEAPInformatizado"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayEAPInformatizado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEAPInformatizado")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEAPInformatizado"));
                _page.RetornarFuncaoDeOperacaoPassagemEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemAplicativoDoEquipamentoEAPInformatizado")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoDoInformatizadoEAPInformatizado"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoDasEAPInformatizado"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoAsEAPInformatizado"));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAPInformatizado")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
            }

        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17186]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17186(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("impressoraEAEInformatizado"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEAEInformatizado")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarImpressoraEAEInformatizado")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloDaImpressoraEAEInformatizado"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialEAEInformatizado"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17187]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep17187(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEAEInformatizadoalterado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoEAEInformatizadoalterado"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEAEInformatizado")));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEAEInformatizado")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDoInformatizadoEAEInformatizadoalterado"));
            _page.SelecionarNomeUsuarioSistemaEquipamento(row.GetCell("usuarioSistemaResponsavelEAEInformatizado"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoDeFuncionamentoDasEAEInformatizadoalterado"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoDeFuncionamentoAsEAEInformatizadoalterado"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAEInformatizadoalterado")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("nomeBolsaoDeVagasSecundario"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17187]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17187(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEAEInformatizadoalterado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAEInformatizadoalterado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEAEInformatizado")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEAEInformatizado"));
                _page.RetornarFuncaoDeOperacaoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaAplicativoDoEquipamentoEAEInformatizado")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoDoInformatizadoEAEInformatizadoalterado"));
                _page.RetornarNomeUsuarioSistemaEquipamento().Should().Be(row.GetCell("usuarioSistemaResponsavelEAEInformatizado"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoDasEAEInformatizadoalterado"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoDeFuncionamentoAsEAEInformatizadoalterado"));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAEInformatizadoalterado")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagasSecundario"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17187]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17187(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("impressoraEAEInformatizado"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEAEInformatizado")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarImpressoraEAEInformatizado")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloDaImpressoraEAEInformatizado"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialEAEInformatizado"));
            }
        }


        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17188]")]
        public void PreencherOsCamposDaTelaEquipamentosPageStep17188(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentosEASInformatizadoAlterado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentosEASInformatizadoAlterado"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoInformatizadoEquipamento")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoInformatizadoEquipamento"));
            _page.SelecionarNomeUsuarioSistemaEquipamento(row.GetCell("nomeUsuarioSistema"));
            _page.PreencherPeriodoDeFuncionamentoDasEquipamento(row.GetCell("periodoFuncionamentoDasEquipamentoAlterado"));
            _page.PreencherPeriodoDeFuncionamentoAsEquipamento(row.GetCell("periodoFuncionamentoAsEquipamentoAlterado"));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoAlterado")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoDeVagas"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17188]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17188(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentosEASInformatizadoAlterado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentosEASInformatizadoAlterado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoInformatizadoEquipamento")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoInformatizadoEquipamento"));
                _page.RetornarFuncaoDeOperacaoSaidaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValicadaoEquipamentosEASInformatizado")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoInformatizadoEquipamento"));
                _page.RetornarNomeUsuarioSistemaEquipamento().Should().Be(row.GetCell("nomeUsuarioSistema"));
                _page.RetornarPeriodoDeFuncionamentoDasEquipamento().Should().Be(row.GetCell("periodoFuncionamentoDasEquipamentoAlterado"));
                _page.RetornarPeriodoDeFuncionamentoAsEquipamento().Should().Be(row.GetCell("periodoFuncionamentoAsEquipamentoAlterado"));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamentoAlterado")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));

            }

        }


        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17188]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17188(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalInformatizadoEquipamento")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarInformatizadoEquipamento")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloImpressoraInformatizadoEquipamento"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialInformatizadoEquipamentoAlterado"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17189]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep17189(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoEAPInformatizadoalterar"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoEAPInformatizadoalterar"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEAPInformatizadoalterar")));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemAplicativoDoEquipamentoEAPInformatizado")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDoInformatizadoEAPInformatizadoalterar"));
            _page.SelecionarNomeUsuarioSistemaEquipamento(row.GetCell("usuarioDoSistemaResponsavelEAPInformatizadoalterar"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("semPeriodoDefinidoEAPInformatizadoalterar")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAPInformatizadoalterar")));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("nomeBolsaoDeVagas"));
        }

        [Step("Preencher os campos do pop-up de periférico de Impressora <tabela> [EquipamentosPageStep] [17189]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeLeitoraImpressoraEquipamentosPageStep17189(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherPortaSerialEquipamento(row.GetCell("portaSerialEAPInformatizadoalterar"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17189]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17189(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoEAPInformatizadoalterar"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoEAPInformatizadoalterar"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEAPInformatizadoalterar")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoDoEquipamentoEAPInformatizado"));
                _page.RetornarFuncaoDeOperacaoPassagemEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemAplicativoDoEquipamentoEAPInformatizado")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoDoInformatizadoEAPInformatizadoalterar"));
                _page.RetornarNomeUsuarioSistemaEquipamento().Should().Be(row.GetCell("usuarioDoSistemaResponsavelEAPInformatizadoalterar"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semPeriodoDefinidoEAPInformatizadoalterar")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEAPInformatizadoalterar")));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be(row.GetCell("nomeBolsaoDeVagas"));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17189]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17189(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("impressoraEAPInformatizado"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraEAPInformatizado")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarImpressoraEAPInformatizado")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloDaImpressoraEAPInformatizado"));
                _page.RetornarPortaSerialEquipamento().Should().Be(row.GetCell("portaSerialEAPInformatizadoalterar"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17190]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep17190(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNomeEquipamento(row.GetCell("nomeValidacaoInformatizadoEquipamentosalterado"));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDeInformatizadoValidacaoEquipamentosalterado"));
            _page.SelecionarNomeUsuarioSistemaEquipamento(row.GetCell("usuarioSistemaResponsavelInformatizadoEquipamentos"));
            _page.MarcarMultiplasMedasEquipamento(Convert.ToBoolean(row.GetCell("utilizarMutiplasMoedasInformatizadoValidacaoEquipamentosalterado")));
            _page.MarcarBloquearPagamentosEquipamento(Convert.ToBoolean(row.GetCell("bloquearPagamentosInformatizadoValidacaoEquipamentosalterado")));
        }

        [Step("Preencher os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17190]")]
        public void PreencherOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17190(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarTipoDePerifericoEquipamento(row.GetCell("tipoDoPerifericoValidacaoInformatizadoalterado"));
            _page.MarcarPerifericoPrincipalEquipamento(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraValidacaoInformatizadoalterado")));
            _page.MarcarHabilitarPerifericoEquipamento(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressoraValidacaoInformatizadoalterado")));
            _page.SelecionarModeloPerifericoEquipamento(row.GetCell("modeloImpressoraValidacaoInformatizadoalterado"));
            _page.PreencherEnderecoIPPopUpEquipamento(row.GetCell("enderecoIPImpressoraRemotaEquipamentos"));
            _page.RPreencherEnderecoMACImpressoraRemotaEquipamento(row.GetCell("enderecoMACImpressoraRemotaEquipamentos"));

        }


        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [17190]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep17190(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numerodoequipamentoequipamentos"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeValidacaoInformatizadoEquipamentosalterado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoValidacaoInformatizadoEquipamentos")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("listaAplicativoVersao"));
                _page.RetornarFuncaoDeOperacaoValidacaoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValidacaoInformatizadoEquipamentos")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoDeInformatizadoValidacaoEquipamentosalterado"));
                _page.RetornarNomeUsuarioSistemaEquipamento().Should().Be(row.GetCell("usuarioSistemaResponsavelInformatizadoEquipamentos"));
                _page.RetornarMultiplasMedasEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("utilizarMutiplasMoedasInformatizadoValidacaoEquipamentosalterado")));
                _page.RetornarBloquearPagamentosEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("bloquearPagamentosInformatizadoValidacaoEquipamentosalterado")));
            }
        }

        [Step("Verificar os campos do pop-up de periférico de impressora <tabela> [EquipamentosPageStep] [17190]")]
        public void VerificarOsCamposDoPopUpDePerifericoDeImpressoraEquipamentospagestep17190(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarTipoDePerifericoEquipamento().Should().Be(row.GetCell("tipoDoPerifericoValidacaoInformatizadoalterado"));
                _page.RetornarPerifericoPrincipalEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("perifericoPrincipalImpressoraValidacaoInformatizadoalterado")));
                _page.RetornarHabilitarPerifericoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitarPerifericoImpressoraValidacaoInformatizadoalterado")));
                _page.RetornarModeloPerifericoEquipamento().Should().Be(row.GetCell("modeloImpressoraValidacaoInformatizadoalterado"));
                _page.RetornarEnderecoIPPopUpEquipamento().Should().Be(row.GetCell("enderecoIPImpressoraRemotaEquipamentos"));
                _page.RetornarEnderecoMACImpressoraRemotaEquipamento().Should().Be(row.GetCell("enderecoMACImpressoraRemotaEquipamentos"));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [17194]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep17194(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoInformatizadoEquipamento"));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoInformatizadoEquipamento"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoEntradaEquipamento")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeEquipamento")));

        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [26676]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep26676(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroEquipamentoVolanteInformatizado"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoVolanteInformatizado"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoEquipamentoVolanteInformatizado")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoEquipamentoVolanteInformatizado"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoEntradaVolanteInformatizado")));
            _page.MarcarFuncaoDeOperacaoSaidaEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoSaidaVolanteInformatizado")));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoPassagemVolanteInformatizado")));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoOperacaoValidacaoVolanteInformatizado")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoInformatizadoVolanteInformatizado"));
            _page.SelecionarNomeUsuarioSistemaEquipamento(row.GetCell("nomeUsuarioSistemaVolanteInformatizado"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("semPeriodoDefinidoVolanteInformatizado")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeVolanteInformatizado")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("acessoBolsaoPrincipalVolanteInformatizado"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("acessoBolsaoSecundarioVolanteInformatizado"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [26676]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep26676(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroEquipamentoVolanteInformatizado"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoVolanteInformatizado"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoEquipamentoVolanteInformatizado")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoEquipamentoVolanteInformatizado"));
                _page.RetornarFuncaoDeOperacaoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoEntradaVolanteInformatizado")));
                _page.RetornarFuncaoDeOperacaoSaidaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoSaidaVolanteInformatizado")));
                _page.RetornarFuncaoDeOperacaoPassagemEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoPassagemVolanteInformatizado")));
                _page.RetornarFuncaoDeOperacaoValidacaoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoOperacaoValidacaoVolanteInformatizado")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoInformatizadoVolanteInformatizado"));
                _page.RetornarNomeUsuarioSistemaEquipamento().Should().Be(row.GetCell("nomeUsuarioSistemaVolanteInformatizado"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semPeriodoDefinidoVolanteInformatizado")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeVolanteInformatizado")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be((row.GetCell("acessoBolsaoPrincipalVolanteInformatizado")));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be((row.GetCell("acessoBolsaoSecundarioVolanteInformatizado")));
            }
        }

        [Step("Preencher os campos da tela <tabela> [EquipamentosPageStep] [26677]")]
        public void PreencherOsCamposDaTelaEquipamentospagestep26677(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            _page.PreencherNumeroDoEquipamento(row.GetCell("numeroDoEquipamentoInformatizadoFixo"));
            _page.PreencherNomeEquipamento(row.GetCell("nomeEquipamentoInformatizadoFixo"));
            _page.PreencherEnderecoIPEquipamento(row.GetCell("enderecoIpInformatizadoFixo"));
            _page.PreencherMascaraIPEquipamento(row.GetCell("mascaraIpInformatizadoFixo"));
            _page.PreencherIPDoGatewayEquipamento(row.GetCell("iPDoGatewayInformatizadoFixo"));
            _page.MarcarHabilitadoEquipamento(Convert.ToBoolean(row.GetCell("habilitadoInformatizadoFixo")));
            _page.SelecionarAplicativoDoEquipamento(row.GetCell("aplicativoInformatizadoFixo"));
            _page.MarcarFuncaoDeOperacaoEntradaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaInformatizadoFixo")));
            _page.MarcarFuncaoDeOperacaoSaidaEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoSaidaInformatizadoFixo")));
            _page.MarcarFuncaoDeOperacaoPassagemEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemInformatizadoFixo")));
            _page.MarcarFuncaoDeOperacaoValidacaoEquipamento(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoValidacaoInformatizadoFixo")));
            _page.SelecionartipoDeInformatizadoEquipamentos(row.GetCell("tipoDoInformatizadoInformatizadoFixo"));
            _page.MarcarPeriodoDeFuncionamentoEquipamento(Convert.ToBoolean(row.GetCell("semPeriodoDeFuncionamentoInformatizadoFixo")));
            _page.MarcarPossuiEscapeGateModeEquipamento(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeInformatizadoFixo")));
            _page.SelecionarNomeBolsaoDeVagasPrincipalEquipamento(row.GetCell("nomeBolsaoPrincipalInformatizadoFixo"));
            _page.SelecionarNomeBolsaoDeVagasSecundarioEquipamento(row.GetCell("nomeBolsaoSecundarioInformatizadoFixo"));
        }

        [Step("Verificar os campos da tela <tabela> [EquipamentosPageStep] [26677]")]
        public void VerificarOsCamposDaTelaEquipamentospagestep26677(Table tabela)
        {
            var row = tabela.GetTableRows()[0];
            using (new AssertionScope())
            {
                _page.RetornarNumeroDoEquipamento().Should().Be(row.GetCell("numeroDoEquipamentoInformatizadoFixo"));
                _page.RetornarNomeEquipamento().Should().Be(row.GetCell("nomeEquipamentoInformatizadoFixo"));
                _page.RetornarEnderecoIPEquipamento().Should().Be(row.GetCell("enderecoIpInformatizadoFixo"));
                _page.RetornarMascaraIPEquipamento().Should().Be(row.GetCell("mascaraIpInformatizadoFixo"));
                _page.RetornarIPDoGatewayEquipamento().Should().Be(row.GetCell("iPDoGatewayInformatizadoFixo"));
                _page.RetornarHabilitadoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("habilitadoInformatizadoFixo")));
                _page.RetornarAplicativoDoEquipamento().Should().Be(row.GetCell("aplicativoInformatizadoFixo"));
                _page.RetornarFuncaoDeOperacaoEntradaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoEntradaInformatizadoFixo")));
                _page.RetornarFuncaoDeOperacaoSaidaEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoSaidaInformatizadoFixo")));
                _page.RetornarFuncaoDeOperacaoPassagemEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoPassagemInformatizadoFixo")));
                _page.RetornarFuncaoDeOperacaoValidacaoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("funcaoDeOperacaoValidacaoInformatizadoFixo")));
                _page.RetornartipoDeInformatizadoEquipamentos().Should().Be(row.GetCell("tipoDoInformatizadoInformatizadoFixo"));
                _page.RetornarMarcarPeriodoDeFuncionamentoEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("semPeriodoDeFuncionamentoInformatizadoFixo")));
                _page.RetornarPossuiEscapeGateModeEquipamento().Should().Be(Convert.ToBoolean(row.GetCell("possuiEscapeGateModeInformatizadoFixo")));
                _page.RetornarNomeBolsaoDeVagasPrincipalEquipamento().Should().Be((row.GetCell("nomeBolsaoPrincipalInformatizadoFixo")));
                _page.RetornarNomeBolsaoDeVagasSecundarioEquipamento().Should().Be((row.GetCell("nomeBolsaoSecundarioInformatizadoFixo")));
            }
        }
    }
}