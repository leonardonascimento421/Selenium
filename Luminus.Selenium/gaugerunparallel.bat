@ECHO OFF
ECHO - 
ECHO -
ECHO --------------------------
ECHO EXECUTAR O LUMINUS APONTANDO PARA http://test.app.localhost:4200. PARA EXECUTAR PELO VISUALSTUDIO, USE OS ARQUIVOS DE CONFIGURAÇÃO DO CAMINHO ..\luminusConfigParalelo E COPIE NA PASTA src NA RAÍZ DA SOLUTION. VERIFIQUE O ARQUIVO HOSTS E EXECUTE NOVAMENTE O LUMINUS. NÃO FAÇA COMMIT DOS ARQUIVOS ALTERADOS.
ECHO --------------------------
ECHO -
ECHO -

call gauge run -e "parallel.phase1,default" ^
specs/Shared/Login/Login.spec ^
specs/Seguranca/LicensaDeUso/LicencaDeUso.spec

call gauge run -p -n=6 -e "parallel.phase2,default" ^
specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema.spec ^
specs/ConfiguracaoDoEstacionamento/BolsaoVagas/bolsaoVagas.spec ^
specs/InstalacoesAtualizacoes/AplicativosEVersoes/AplicativosEVersoes.spec ^
specs/ConfiguracaoDoEstacionamento/Estacionamento/Estacionamento.spec ^
specs/Financeiro/IntegracaoTef/IntegracaoTef.spec ^
specs/Operacao/TiposDeOcorrenciasNasEstadias/TiposDeOcorrenciasNasEstadias.spec ^
specs/Customizacao/MensagensDeAudio/MensagensDeAudio.spec ^
specs/Customizacao/TelasVga/TelasVga.spec ^
specs/Financeiro/EmitentesFiscais/EmitentesFiscais.spec ^
specs/seguranca/UsuariosDoSistema/UsuariosDoSistema.spec ^
specs/ConfiguracaoDoEstacionamento/IntegracoesComOperadorasDeArrecadacao/IntegracoesComOperadorasDeArrecadacao.spec ^
specs/Financeiro/TaxasCabiais/TaxasCambiais.spec

pause