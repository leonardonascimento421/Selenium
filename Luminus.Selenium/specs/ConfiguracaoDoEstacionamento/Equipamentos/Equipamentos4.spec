# Equipamentos 4 [17570]
Criado pelo gerador 26/12/2019 09:44:51

 Carregar dependências Equipamentos <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv>
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [16266]
ST - Criar perfil com acesso a todos as funcionalidades <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [17684]

## Criar um equipamento de saída barcode(EAS) [16633]
ST - Adicionar aplicativo <table:resources/CriarUmEquipamentoDeSaidaBarcodeEas16633.csv> [16273]
ST - Criar um bolsão de vagas <table:resources/CriarUmEquipamentoDeSaidaBarcodeEas16633.csv> [16266]
* SS - Criar Equipamento de Saída Barcode <table:resources/CriarUmEquipamentoDeSaidaBarcodeEas16633.csv> [16936]
* Clicar no menu de contexto (...) na linha contendo o valor "Saída Barcode" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoDeSaidaBarcodeEas16633.csv> [EquipamentosPageStep] [16633]
Na seção Informações gerais o campo Número do equipamento deve constar o valor "200"
Na seção Informações gerais o campo Nome deve constar o valor ""
Na seção Informações gerais o campo Endereço IP deve constar o valor "192.168.0.200"
Na seção Informações gerais o campo IP do gateway deve constar o valor "192.168.0.200"
Na seção Informações gerais o checkbox Habilitado deve constar o valor "true"
Na seção Operação geral o combobox Aplicativo do equipamento deve constar o valor "EAE_V0.9.0.8b.zip"
Na seção Operação geral no rótulo Funções de operação o checkbox Saída deve constar o valor "true"
Na seção Operação geral o checkbox Sem limite deve constar o valor "true"
Na seção Operação geral o campo Número do setor spacenet deve constar o valor "1"
Na seção Operação de acesso o campo das do rótulo Período de funcionamento deve constar o valor "0800"
Na seção Operação de acesso o campo as do rótulo Período de funcionamento deve constar o valor "2200"
Na seção Operação de acesso o combobox Modo de acionamento do equipamento deve constar o valor "2 - Semiautomatico"
Na seção Operação de acesso o checkbox Detecção de moto deve constar o valor "true"
Na seção Operação de acesso o checkbox Somente tag Nepos deve constar o valor "true"
Na seção Operação de acesso o checkbox Possui escape/gate mode deve constar o valor "true"
Na seção Operação de acesso o checkbox Múltiplos equipamentos por acesso (3 ou mais equipamentos) deve constar o valor "true"
Na seção Operação de acesso o combobox Tipo de escape/gate mode deve constar o valor "1 - Simples"
Na seção Operação de acesso o combobox Sentido do escape/gate mode deve constar o valor "1 - Direita"
Na seção Operação de acesso o combobox Acesso bolsão principal deve constar o valor "Bolsão principal"
Na seção Operação de acesso o combobox Acesso bolsão secundário deve constar o valor "Bolsão principal"
Na seção Operação de acesso o combobox Equipamento Escape/GateMode vínculado deve constar o valor "Pensar em colocar shared step aqui"
Na seção Configuração da cancela de saída o checkbox Possui cancela deve constar o valor "true"
Na seção Configuração da cancela de saída o checkbox Auto parada deve constar o valor "true"
Na seção Configuração da cancela de saída o checkbox Inicia nova transação com veículos sobre o laço de fechamento deve constar o valor "true"
Na seção Configuração da cancela de saída o checkbox Inicia nova transação após fechamento total da cancela deve constar o valor "true"
Na seção Configuração da cancela de saída o checkbox Existe laço para acionamento do equipamento deve constar o valor "true"
Na seção Configuração da cancela de saída o checkbox Existe laço de fechamento da cancela deve constar o valor "true"
Na seção Configuração da cancela de saída o checkbox Aguardar sinal de cancela fechada deve constar o valor "true"
Na seção Configuração da cancela de saída o campo Tempo limite para resposta da cancela (seg) deve constar o valor "3"
Na seção Configurações de suporte o checkbox Mostrar detalhes de espera após tecla acionada deve constar o valor "true"
Na seção Configurações de suporte o checkbox Alternar entre mensagem e detalhes de espera deve constar o valor "true"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de erro (seg) deve constar o valor "3"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de espera (seg) deve constar o valor "3"
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor 1D2D <table:resources/CriarUmEquipamentoDeSaidaBarcodeEas16633.csv> [EquipamentosPageStep] [16633]
No popup Adicionar periférico o combobox Tipo do periférico deve constar o valor "0 - Leitor Mifare"
No popup Adicionar periférico o checkbox Periférico principal deve constar o valor "true"
No popup Adicionar periférico o checkbox Habilitar deve constar o valor "true"
Na seção Leitor 1D/2D o combobox Modelo do leitor deve constar o valor ""
Na seção Leitor 1D/2D o campo Porta serial deve constar o valor ""
Na seção Leitor 1D/2D o checkbox Habilitar laser contínuo deve constar o valor ""
Na seção Leitor 1D/2D o checkbox Habilitar leitura de selo de desconto deve constar o valor ""
Na seção Leitor 1D/2D o checkbox Habilitar verificação do digito verificador de mídias código de barras deve constar o valor ""
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "5 - Leitor Tag" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor tag <table:resources/CriarUmEquipamentoDeSaidaBarcodeEas16633.csv> [EquipamentosPageStep] [16633]
Na seção Leitor tag Nepos o combobox Modelo da Tag deve constar o valor ""
Na seção Leitor tag Nepos o campo Endereço IP deve constar o valor ""
Na seção Leitor tag Nepos o campo Máscara IP deve constar o valor ""
Na seção Leitor tag Nepos o campo IP do gateway deve constar o valor ""
Na seção Leitor tag Nepos o combobox Tipo de instalação operação da leitora/antena deve constar o valor ""
Na seção Leitor tag Nepos o campo Canal da antena conectado ao leitor deve constar o valor ""
Na seção Leitor tag Nepos o campo Ignorar leitura da mesma tag por (seg) deve constar o valor ""
Na seção Leitor tag Nepos o campo Considerar leituras realizadas há até (décimos de seg) deve constar o valor ""
* Clicar no botão Fechar

## Criar um equipamento de passagem barcode (EAP) [16634]
ST - Adicionar aplicativo <table:resources/CriarUmEquipamentoDePassagemBarcodeEap16634.csv> [16273]
ST - Criar um bolsão de vagas <table:resources/CriarUmEquipamentoDePassagemBarcodeEap16634.csv> [16266]
* SS - Criar um equipamento de passagem barcode (EAP) <table:resources/CriarUmEquipamentoDePassagemBarcodeEap16634.csv> [16918]
* Clicar no menu de contexto (...) na linha contendo o valor "Passagem Barcode" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoDePassagemBarcodeEap16634.csv> [EquipamentosPageStep] [16634]
Na seção Informações gerais o campo Número do equipamento deve conter o valor ""
Na seção Informações gerais o campo Nome deve conter o valor ""
Na seção Informações gerais o campo Endereço IP deve conter o valor ""
Na seção Informações gerais o campo Máscara IP deve conter o valor ""
Na seção Informações gerais o campo IP do gateway deve conter o valor ""
Na seção Operação geral o combobox Aplicativo do equipamento deve conter o valor ""
Na seção Operação geral o checkbox Passagem do rótulo Funções de operação deve conter o valor ""
Na seção Operação geral o checkbox Sem limite do campo Limite de transações off-line deve conter o valor ""
Na seção Operação geral o campo Número do setor spacenet deve conter o valor ""
Na seção Operação de acesso o campo Das do rótulo Período de funcionamento deve conter o valor ""
Na seção Operação de acesso o campo As do rótulo Período de funcionamento deve conter o valor ""
Na seção Operação de acesso o combobox Modo de acionamento do equipamento deve conter o valor ""
Na seção Operação de acesso o checkbox deve conter o valor ""
Na seção Operação de acesso o checkbox deve conter o valor ""
Na seção Operação de acesso o checkbox deve conter o valor ""
Na seção Operação de acesso no combobox Acesso bolsão principal deve conter o valor ""
Na seção Configurações de suporte no checkbox Mostrar detalhes de espera após tecla acionada deve conter o valor ""
Na seção Configurações de suporte no checkbox Alternar entre mensagem e detalhes de espera deve conter o valor ""
Na seção Configurações de suporte no campo Tempo para mostrar detalhes de erro(seg) deve conter o valor ""
Na seção Configurações de suporte no campo Tempo para mostrar detalhes de espera(seg) deve conter o valor ""
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor 1D2D <table:resources/CriarUmEquipamentoDePassagemBarcodeEap16634.csv> [EquipamentosPageStep] [16634]
No popup Adicionar periférico o combobox Tipo do periférico deve constar o valor "0 - Leitor Mifare"
No popup Adicionar periférico o checkbox Periférico principal deve constar o valor "true"
No popup Adicionar periférico o checkbox Habilitar deve constar o valor "true"
Na seção Leitor 1D/2D o combobox Modelo do leitor deve constar o valor ""
Na seção Leitor 1D/2D o campo Porta serial deve constar o valor ""
Na seção Leitor 1D/2D o checkbox Habilitar laser contínuo deve constar o valor ""
Na seção Leitor 1D/2D o checkbox Habilitar leitura de selo de desconto deve constar o valor ""
Na seção Leitor 1D/2D o checkbox Habilitar verificação do digito verificador de mídias código de barras deve constar o valor ""
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "5 - Leitor Tag" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor tag <table:resources/CriarUmEquipamentoDePassagemBarcodeEap16634.csv> [EquipamentosPageStep] [16634]
Na seção Leitor tag Nepos o combobox Modelo da Tag deve constar o valor ""
Na seção Leitor tag Nepos o campo Endereço IP deve constar o valor ""
Na seção Leitor tag Nepos o campo Máscara IP deve constar o valor ""
Na seção Leitor tag Nepos o campo IP do gateway deve constar o valor ""
Na seção Leitor tag Nepos o combobox Tipo de instalação operação da leitora/antena deve constar o valor ""
Na seção Leitor tag Nepos o campo Canal da antena conectado ao leitor deve constar o valor ""
Na seção Leitor tag Nepos o campo Ignorar leitura da mesma tag por (seg) deve constar o valor ""
Na seção Leitor tag Nepos o campo Considerar leituras realizadas há até (décimos de seg) deve constar o valor ""
* Clicar no botão Fechar

## Alterar um equipamento de entrada barcode(EAE) [16635]
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [16266]
ST - Adicionar aplicativo <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [16273]
* SS - Criar um equipamento de entrada Barcode(EAE) step by step <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [16632]
* Clicar no menu de contexto (...) na linha contendo o valor "Entrada Barcode para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [EquipamentosPageStep] [16635]
Na seção Informações gerais alterar o campo Número do equipamento com o valor "666"
Na seção Informações gerais alterar o campo Nome com o valor "entrada barcode (EAE) alterado"
Na seção Informações gerais alterar o campo Endereço IP com o valor "2.2.2.2"
Na seção Informações gerais alterar o campo Máscara IP com o valor "2.2.2.2"
Na seção Informações gerais alterar o campo IP do gateway com o valor "2.2.2.2"
Na seção Informações gerais desmarcar o checkbox Habilitado do campo Modelo do equipamento com o valor "false"
Na seção Operação geral no campo Limite de transações off-line desmarcar o checkbox Sem limite com o valor "false"
Na seção Operação geral alterar o campo Limite de transações off-line com o valor "10"
Na seção Operação geral alterar o campo Número do setor spacenet com o valor "3"
Na seção Operação de acesso marcar o checkbox Sem período definido "true"
Na seção Operação de acesso no combobox Modo de acionamento do equipamento selecionar a opção "3 - Manual"
Na seção Operação de acesso desmarcar o checkbox Detecção de moto com o valor "false"
Na seção Operação de acesso desmarcar o checkbox Somente tag Nepos com o valor "false"
Na seção Operação de acesso marcar o checkbox Possui escape/gate mode com o valor "true"
Na seção Operação de acesso marcar o checkbox Múltiplos equipamentos por acesso (3 ou mais equipamentos) "true"
Na seção Operação de acesso clicar no combobox Tipo de escape/gate mode e selecionar o valor "4 - Multipla\bloqeuada"
Na seção Operação de acesso clicar no combobox Sentido do escape/gate mode e selecionar o valor "2 - Esquerda"
Na seção Operação de acesso clicar no combobox Acesso bolsão secundário e selecionar o valor "BOLSÃO EXTERNO"
Na seção Configuração da cancela de entrada marcar o checkbox Possui cancela "true"
Na seção Configuração da cancela de entrada marcar o checkbox Auto parada "true"
Na seção Configuração da cancela de entrada marcar o checkbox Inicia nova transação com veículos sobre o laço de fechamento "true"
Na seção Configuração da cancela de entrada marcar o checkbox Inicia nova transação após fechamento total da cancela "true"
Na seção Configuração da cancela de entrada marcar o checkbox Existe laço para acionamento do equipamento "true"
Na seção Configuração da cancela de entrada marcar o checkbox Existe laço de fechamento da cancela "true"
Na seção Configuração da cancela de entrada marcar o checkbox Aguardar sinal de cancela fechada "true"
Na seção Configuração da cancela de entrada alterar o campo Tempo limite para resposta da cancela (seg) com o valor ""
Na seção Periféricos clicar na coluna Tipo periférico clicar no menu de contexto do valor "4 - Leitor 1D/2D"
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> ["portaSerialLeitor1D2DEquipamentoEAEBarcodealterar"] [EquipamentosPageStep]
Na seção Leitor 1D/2D alterar o campo Porta serial com o valor "3"
* Clicar no botão Alterar Pop Up
Na seção Periféricos clicar na coluna Tipo periférico clicar no menu de contexto do valor "2 - Impressora"
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> ["portaSerialImpressoraEquipamentoEAEBarcodealterar"] [EquipamentosPageStep]
Na seção Leitor Impressora no campo Porta serial alterar o valor "5"
* Clicar no botão Alterar Pop Up
* Preencher os campos da tela, na seção de configurações de suporte <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [EquipamentosPageStep] [16635]
Na seção Configurações de suporte desmarcar o checkbox Mostrar detalhes de espera após tecla acionada com o valor "false"
Na seção Configurações de suporte desmarcar o checkbox Alternar entre mensagem e detalhes de espera com o valor "false"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de erro (seg) com o valor "4"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de espera (seg) com o valor "4"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "entrada barcode (EAE) alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [EquipamentosPageStep] [16635]
Na seção Informações gerais o campo Número do equipamento deve constar o valor "666"
Na seção Informações gerais o campo Nome deve constar o valor "entrada barcode (EAE) alterado"
Na seção Informações gerais o campo Endereço IP deve constar o valor "2.2.2.2"
Na seção Informações gerais o campo Máscara IP deve constar o valor "2.2.2.2"
Na seção Informações gerais o campo IP do gateway deve constar o valor "2.2.2.2"
Na seção Informações gerais o checkbox Habilitado do campo Modelo do equipamento deve constar o valor "false"
Na seção Operação geral no campo Limite de transações off-line o checkbox Sem limite deve constar o valor "false"
Na seção Operação geral o campo Limite de transações off-line deve constar o valor "10"
Na seção Operação geral o campo Número do setor spacenet deve constar o valor "3"
Na seção Operação de acesso o checkbox Sem período definido deve constar o valor "true"
Na seção Operação de acesso o combobox Modo de acionamento do equipamento deve constar o valor ""
Na seção Operação de acesso o checkbox Detecção de moto deve constar o valor "false"
Na seção Operação de acesso o checkbox Somente tag Nepos deve constar o valor "false"
Na seção Operação de acesso o checkbox Possui escape/gate mode deve constar o valor "true"
Na seção Operação de acesso o checkbox Múltiplos equipamentos por acesso (3 ou mais equipamentos) deve constar o valor "true"
Na seção Operação de acesso o combobox Tipo de escape/gate mode deve constar o valor "4 - Multipla\bloqeuada"
Na seção Operação de acesso o combobox Sentido do escape/gate mode deve constar o valor "2 - Esquerda"
Na seção Operação de acesso o combobox Acesso bolsão secundário deve constar o valor "BOLSÃO EXTERNO"
Na seção Configuração da cancela de entrada o checkbox Possui cancela deve constar o valor "true"
Na seção Configuração da cancela de entrada o checkbox Auto parada deve constar o valor "true"
Na seção Configuração da cancela de entrada o checkbox Inicia nova transação com veículos sobre o laço de fechamento deve constar o valor "true"
Na seção Configuração da cancela de entrada o checkbox Inicia nova transação após fechamento total da cancela deve constar o valor "true"
Na seção Configuração da cancela de entrada o checkbox Existe laço para acionamento do equipamento deve constar o valor "true"
Na seção Configuração da cancela de entrada o checkbox Existe laço de fechamento da cancela deve constar o valor "true"
Na seção Configuração da cancela de entrada o checkbox Aguardar sinal de cancela fechada deve constar o valor "true"
Na seção Configuração da cancela de entrada o campo Tempo limite para resposta da cancela (seg) deve constar o valor ""
Na seção Configurações de suporte o checkbox Mostrar detalhes de espera após tecla acionada deve constar o valor "false"
Na seção Configurações de suporte o checkbox Alternar entre mensagem e detalhes de espera deve constar o valor "false"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de erro (seg) deve constar o valor "4"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de espera (seg) deve constar o valor "4"
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor 1D/2D <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [EquipamentosPageStep] [16635]
Na seção Leitor 1D/2D alterar o campo Porta serial com o valor "3"
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de impressora <table:resources/AlterarUmEquipamentoDeEntradaBarcodeEae16635.csv> [EquipamentosPageStep] [16635]
Na seção Leitor Impressora no campo Porta serial alterar o valor "5"
* Clicar no botão Fechar
* Clicar no botão Voltar


## Alterar um equipamento de saída barcode (EAS) [16636]
ST - Adicionar aplicativo <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> [16273]
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> [16266]
* SS - Criar Equipamento de Saída Barcode <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> [16936]
* Clicar no menu de contexto (...) na linha contendo o valor "Saída Barcode Alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> [EquipamentosPageStep] [16636]
Na seção Informações gerais alterar o campo Número do equipamento com o valor "220"
Na seção Informações gerais alterar o campo Nome com o valor "alterado barcode saída"
Na seção Informações gerais alterar o campo Endereço IP com o valor "192.168.0.201"
Na seção Informações gerais alterar o campo Máscara IP com o valor "192.168.0.202"
Na seção Informações gerais alterar o campo IP do gateway com o valor "192.168.0.203"
Na seção Informações gerais desmarcar o checkbox Habilitado "false"
Na seção Operação geral desmarcar o checkbox Sem limite "false"
Na seção Operação geral alterar o campo Limite de transações off-line com o valor "10"
Na seção Operação geral alterar o campo Número do setor spacenet com o valor "17"
Na seção Operação de acesso marcar o checkbox Sem período definido "true"
Na seção Operação de acesso clicar no combobox Modo de acionamento do equipamento e selecionar o valor "1 - Automático"
Na seção Operação de acesso desmarcar o checkbox Detecção de moto "false"
Na seção Operação de acesso desmarcar o checkbox Somente tag Nepos "false"
Na seção Operação de acesso desmarcar o checkbox Possui escape/gate mode "false"
Na seção Configuração da cancela de saída desmarcar o checkbox Possui cancela "false"
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> ["portaserialperiferico1equipamentosalterar"] [EquipamentosPageStep]
Na seção Leitor 1D/2D alterar o campo Porta serial com o valor "18" [EquipamentosPageStep]
* Clicar no botão Alterar Pop Up
* Preencher os campos da tela, na seção de configurações de suporte <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> [EquipamentosPageStep] [16636]
Na seção Configurações de suporte desmarcar o checkbox Mostrar detalhes de espera após tecla acionada "false"
Na seção Configurações de suporte desmarcar o checkbox Alternar entre mensagem e detalhes de espera "false"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de erro (seg) com o valor "4"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de espera (seg) com o valor "4"
* Clicar no botão Salvar
* Clicar no menu de contexto (...) na linha contendo o valor "Saida Barcode Alterada" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> [EquipamentosPageStep] [16636]
Na seção Informações gerais o campo Número do equipamento deve constar o valor "220"
Na seção Informações gerais o campo Nome deve constar o valor "alterado barcode saída"
Na seção Informações gerais o campo Endereço IP deve constar o valor "192.168.0.201"
Na seção Informações gerais o campo Máscara IP deve constar o valor "192.168.0.202"
Na seção Informações gerais o campo IP do gateway deve constar o valor "192.168.0.203"
Na seção Informações gerais o checkbox Habilitado deve constar o valor "false"
Na seção Operação geral o checkbox Sem limite deve constar o valor "false"
Na seção Operação geral o campo Limite de transações off-line deve constar o valor "10"
Na seção Operação geral o campo Número do setor spacenet deve constar o valor "17"
Na seção Operação de acesso o checkbox Sem período definido deve constar o valor "true"
Na seção Operação de acesso o combobox Modo de acionamento do equipamento deve constar o valor "1 - Automático"
Na seção Operação de acesso o checkbox Detecção de moto deve constar o valor "false"
Na seção Operação de acesso o checkbox Somente tag Nepos deve constar o valor "false"
Na seção Operação de acesso o checkbox Possui escape/gate mode deve constar o valor "false"
Na seção Configuração da cancela de saída o checkbox Possui cancela deve constar o valor "false"
Na seção Configurações de suporte o checkbox Mostrar detalhes de espera após tecla acionada deve constar o valor "false"
Na seção Configurações de suporte o checkbox Alternar entre mensagem e detalhes de espera deve constar o valor "false"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de erro (seg) deve constar o valor "4"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de espera (seg) deve constar o valor "4"
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor 1D2D <table:resources/AlterarUmEquipamentoDeSaidaBarcodeEas16636.csv> [EquipamentosPageStep] [16636]
Na seção Leitor Leitor 1D2D o campo Porta serial deve constar o valor "3" [EquipamentosPageStep]
* Clicar no botão Fechar
* Clicar no botão Voltar

## Alterar um equipamento de passagem barcode (EAP) [16637]
ST - Adicionar aplicativo <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> [16273]
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> [16266]
* SS - Criar um equipamento de passagem barcode (EAP) <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> [16918]
* Clicar no menu de contexto (...) na linha contendo o valor "Passagem Barcode Alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> [EquipamentosPageStep] [16637]
Na seção Informações gerais  alterar o campo Número do equipamento com o valor "10"
Na seção Informações gerais alterar o campo Nome para o valor "Passagem barcode Alterado"
Na seção Informações gerais alterar o campo Endereço IP para o valor "192.168.20.102"
Na seção Informações gerais alterar o campo Mascara IP para o valor "255.255.0.0"
Na seção Informações gerais alterar o campo IP do gateway para o valor "192.168.10.10"
Na seção Informações gerais desmarcar o checkbox Habilitado para o valor "false"
Na seção Operação geral desmarcar o checkbox Sem limite para o valor "false"
Na seção Operação geral alterar o campo Limite de transações off-line para o valor "10"
Na seção Operação geral alterar o campo Número do setor spacenet para o valor "2"
Na seção Operação de acesso no campo Período de funcionamento marcar o checkbox Sem período de funcionamento com o valor "true"
Na seção Operação de acesso no combobox Modo de acionamento do equipamento selecionar a opção "2 - Semiautomatico"
Na seção Operação de acesso desmarcar o checkbox Detecção de moto para o valor "false"
Na seção Operação de acesso desmarcar o checkbox Somente tag Nepos para o valor "false"
Na seção Operação de acesso marcar o checkbox Possui escape/gate mode com o valor "true"
Na seção Operação de acesso marcar o checkbox Múltiplos equipamentos por acesso (3 ou mais equipamentos com o valor "true"
Na seção Operação de acesso no combobox Tipo de escape/gate mode selecionar a opção "3 - Multipla\comporta"
Na seção Operação de acesso no combobox Sentido do escape/gate mode selecionar a opção "1 - Direita"
Na seção Operação de acesso no combobox Acesso bolsão secundário selecionar a opção "Bolsão principal"
Na seção Configuração da cancela de saída marcar o checkbox Possui cancela com o valor "true"
Na seção Configuração da cancela de saída marcar o checkbox Auto parada com o valor "true"
Na seção Configuração da cancela de saída marcar o checkbox Inicia nova transação com veículo sobre o laço de fechamento com o valor "true"
Na seção Configuração da cancela de saída marcar o checkbox Inicia nova transação após fechamento total da cancela com o valor "true"
Na seção Configuração da cancela de saída marcar o checkbox 'Existe laço para acionamento do equipamento com o valor "true"
Na seção Configuração da cancela de saída marcar o checkbox Existe laço de fechamento da cancela com o valor "true"
Na seção Configuração da cancela de entrada marcar o checkbox Aguardar sinal de cancela fechada com o valor "true"
Na seção Configuração da cancela de entrada preencher o campo Tempo limite para resposta da cancela(seg) com o valor "5"
Na seção Configurações de suporte desmarcar o checkbox Mostrar detalhes de espera após tecla acionada com o valor "false"
Na seção Configurações de suporte desmarcar o checkbox Alternar entre mensagens e detalhes de espera com o valor "false"
Na seção Configurações de suporte desmarcar o checkbox Alternar entre mensagens e detalhes de espera com o valor "6"
Na seção Configurações de suporte altera o campo Tempo para mostrar detalhes de erro(seg) para o valor "6" 
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> ["alterarPortaSerialLeitor1D2DEquipamento"] [EquipamentosPageStep]
Na seção Leitor 1D2D alterar o campo Porta serial para o valor "2" 
* Clicar no botão Alterar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "5 - Leitor Tag" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Endereço IP com o valor <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> ["alterarEnderecoIPLeitorTagEquipamento"] [EquipamentosPageStep]
Na seção Leitor de Tag alterar o campo Endereço de Ip para o valor "3" 
* Clicar no botão Alterar Pop Up
* Clicar no botão Salvar
* Clicar no menu de contexto (...) na linha contendo o valor "Passagem barcode Alterada" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> [EquipamentosPageStep] [16637]
Na seção Informações gerais o campo Número do equipamento deve conter o valor "10"
Na seção Informações gerais o campo Nome deve conter o valor "Passagem Barcode Alterada"
Na seção Informações gerais o campo 'Endereço IP deve conter o valor "192.168.20.102"
Na seção Informações gerais o campo Máscara IP deve conter o valor "255.255.0.0"
Na seção Informações gerais o campo IP do gateway deve conter o valor "192.168.10.10"
Na seção Informações gerais o campo Habilitado deve conter o valor "false"
Na seção Operação geral o campo Sem limite deve conter o valor "false"
Na seção Operação geral o campo Limite de transações off-line deve conter o valor "10"
Na seção Operação geral o campo Número do setor spacenet deve conter o valor "2"
Na seção Operação de acesso o campo Sem período definido deve conter "true"
Na seção Operação de acesso o campo Modo de acionamento deve conter o valor "2 - Semiautomatico"
Na seção Operação de acesso o campo Detecção de moto deve conter o valor "false"
Na seção Operação de acesso o campo Somente tag Nepos deve conter o valor "false"
Na seção Operação de acesso o campo Possui escape/gate mode deve conter o valor "true"
Na seção Operação de acesso o campo Múltiplos equipamentos por acesso (3 ou mais equipamentos) deve conter o valor "true"
Na seção Operação de acesso o campo Tipo de escape/gate mode deve conter o valor "3 - Multipla\comporta"
Na seção Operação de acesso o campo Sentido do escape/gate mode deve conter o valor "1 - Direita"
Na seção Operação de acesso o campo Acesso bolsão secundário deve conter o valor "Bolsão principal"
Na seção Configuração da cancela de entrada o campo Possui cancela deve conter o valor "true"
Na seção Configuração da cancela de entrada o campo Auto parada deve conter o valor "true"
Na seção Configuração da cancela de entrada o campo Inicia nova transação com veículo sobre o laço de fechamento deve conter o valor "true"
Na seção Configuração da cancela de entrada o campo Inicia nova transação após o fechamento total da cancela deve conter o valor "true"
Na seção Configuração da cancela de entrada o campo Existe laço para acionamento do equipamento deve conter o valor "true"
Na seção Configuração da cancela de entrada o campo Existe laço de fechamento da cancela deve conter o valor "true"
Na seção Configuração da cancela de entrada o campo Aguardar sinal de cancela fechada deve conter o valor "true"
Na seção Configuração da cancela de entrada o campo Tempo limite para resposta da cancela(seg) deve conter o valor "5"
Na seção Configurações de suporte no campo Mostrar detalhes de espera após tecla acionada deve conter o valor "false"
Na seção Configurações de suporte no campo Alternar entre mensagem e detalhes de espera deve conter o valor "false"
Na seção Configurações de suporte no campo Tempo para mostrar detalhes de erro(seg) deve conter o valor "6"
Na seção Configurações de suporte no campo Tempo para mostrar detalhes de espera(seg) deve conter o valor "6"
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor 1D2D <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> [EquipamentosPageStep] [16637]
Na seção Periférico deve conter o valor "2" no periférico "4 - Leitor 1D/2D"
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "5 - Leitor Tag" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor tag <table:resources/AlterarUmEquipamentoDePassagemBarcodeEap16637.csv> [EquipamentosPageStep] [16637]
Na seção Periférico deve conter a coluna Tipo de periférico deve conter o valor "5 - Leitor Tag"
* Clicar no botão Fechar
* Clicar no botão Voltar