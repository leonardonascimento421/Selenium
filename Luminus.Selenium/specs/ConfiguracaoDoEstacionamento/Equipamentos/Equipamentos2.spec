# Equipamentos 2 [17570]
Criado pelo gerador 26/12/2019 09:44:51

 Carregar dependências Equipamentos <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv>
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [16266]
ST - Criar perfil com acesso a todos as funcionalidades <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [17684]

## Alterar um equipamento de saída (EAS) Mifare [16612]
 ST - Adicionar aplicativo <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> [16273]
 ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> [16266]
* SS - Criar equipamento de Saída (EAS) Mifare <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> [16928]
* Clicar no menu de contexto (...) na linha contendo o valor "Saida Mifare para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> [EquipamentosPageStep] [16612]
Na seção Informações gerais alterar o campo Número do equipamento com o valor "220"
Na seção Informações gerais alterar o campo Nome com o valor "Saída Mifare alterada"
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
Na seção Configurações de suporte desmarcar o checkbox Mostrar detalhes de espera após tecla acionada "false"
Na seção Configurações de suporte desmarcar o checkbox Alternar entre mensagem e detalhes de espera "false"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de erro (seg) com o valor "4"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de espera (seg) com o valor "4"
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> ["portaserialperiferico1equipamentosalterar"] [EquipamentosPageStep]
Na seção Leitor mifare alterar o campo Porta serial com o valor "3"
* Clicar no botão Alterar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "1 - Leitor Proximidade" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> ["portaserialperiferico2equipamentosalterar"] [EquipamentosPageStep]
Na seção Leitor de proximidade alterar o campo Porta serial com o valor "1"
* Clicar no botão Alterar Pop Up
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Saída Mifare alterada" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> [EquipamentosPageStep] [16612]
Na seção Informações gerais o campo Número do equipamento deve constar o valor "220"
Na seção Informações gerais o campo Nome deve constar o valor "Saída Mifare alterada quimicamente"
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
Na seção Periféricos na coluna Tipo do periférico clicar no menu de contexto (...) deve constar o valor "0 - Leitor Mifare"
Na seção Configurações de suporte o checkbox Mostrar detalhes de espera após tecla acionada deve constar o valor "false"
Na seção Configurações de suporte o checkbox Alternar entre mensagem e detalhes de espera deve constar o valor "false"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de erro (seg) deve constar o valor "4"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de espera (seg) deve constar o valor "4"
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor mifare <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> [EquipamentosPageStep] [16612]
Na seção Leitor mifare o campo Porta serial deve constar o valor "3"
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "1 - Leitor Proximidade" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor de proximidade <table:resources/AlterarUmEquipamentoDeSaidaEasMifare16612.csv> [EquipamentosPageStep] [16612]
Na seção Leitor de proximidade o campo Porta serial deve constar o valor "1"
* Clicar no botão Fechar

## Alterar um equipamento de passagem (EAP) [16614]
ST - Adicionar aplicativo <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [16273]
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [16266]
* SS - Criar um Equipamento de passagem (EAP) <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [16922]
* Clicar no menu de contexto (...) na linha contendo o valor "Passagem Mifare" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [EquipamentosPageStep] [16614]
Na seção Informações gerais alterar o campo Número do equipamento para o valor "40"
Na seção Informações gerais alterar o campo Nome para o valor "EAPassagem Alterado"
Na seção Informações gerais alterar o campo Endereço IP para o valor "192.168.0.2"
Na seção Informações gerais alterar o campo Mascara IP para o valor "255.255.255.0"
Na seção Informações gerais alterar o campo IP do gateway para o valor "192.168.0.1"
Na seção Informações gerais desmarcar o checkbox Habilitado para o valor "false"
Na seção Operação geral desmarcar o checkbox Sem limite para o valor "false"
Na seção Operação geral alterar o campo Limite de transações off-line para o valor "100"
Na seção Operação geral alterar o campo Número do setor spacenet para o valor "3"
Na seção Operação de acesso no campo Período de funcionamento marcar o checkbox 'Sem período definido' com o valor "true"
Na seção Operação de acesso no combobox Modo de acionamento do equipamento selecionar a opção "1 - Automático"
Na seção Operação de acesso desmarcar o checkbox Detecção de moto com o valor "false"
Na seção Operação de acesso desmarcar o checkbox Acesso como passagem especial com o valor "false"
Na seção Operação de acesso desmarcar o checkbox Somente tag Nepos com o valor "false"
Na seção Operação de acesso marcar o checkbox Possui escape/gate mode com o valor "true"
Na seção Operação de acesso marcar o checkbox Múltiplos equipamentos por acesso (3 ou mais equipamentos) com o valor "true"
Na seção Operação de acesso no combobox Tipo de escape/gate mode selecionar o valor "1 - Simples"
Na seção Operação de acesso no combobox Sentido do escape/gate mode selecionar o valor "2 - Esquerda"
Na seção Operação de acesso no combobox Acesso bolsão secundário selecionar o valor "BOLSÃO EXTERNO"
Na seção Configuração da cancela de saída desmarcar o checkbox Possui cancela com o valor "false"
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> ["portaSerialLeitorMifareEquipamentosEAPassagemalterado"] [EquipamentosPageStep]
No Pop-Up alterar o campo Porta serial para o valor "8" 
* Clicar no botão Alterar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "1 - Leitor Proximidade" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> ["portaSerailLeitorProximidadeEquipamentosEAPassagemalterado"] [EquipamentosPageStep]
No Pop-Up alterar o campo Porta serial para o valor "6" 
* Clicar no botão Alterar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "12 - Interfone Voip" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos do pop-up de periférico de interfone voip <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [EquipamentosPageStep] [16614]
Na seção Interfone Voip alterar o campo Endereço IP com o valor "192.168.1.3"
Na seção Interfone Voip alterar o campo Código com o valor "30"
* Clicar no botão Alterar Pop Up
* Preencher os campos da tela, na seção de configurações de suporte <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [EquipamentosPageStep] [16614]
Na seção Configurações de suporte desmarcar o checkbox Mostrar detalhes de espera após tecla acionada com o valor "false"
Na seção Configurações de suporte marcar o checkbox Alternar entre mensagem e detalhes de espera com o valor "true"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de erro (seg) com o valor "8"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de espera (seg) com o valor "9"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "EAPassagem Alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [EquipamentosPageStep] [16614]
Na seção Informações gerais o campo Número do equipamento deve conter o valor na seção "4"
Na seção Informações gerais o campo Nome deve conter o valor "EAPassagem Alterado"
Na seção Informações gerais o campo Endereço IP deve conter o valor "192.168.0.2"
Na seção Informações gerais o campo Máscara IP deve conter o valor "255.255.255.0"
Na seção Informações gerais o campo IP do gateway deve conter o valor "192.168.0.1"
Na seção Operação geral o checkbox Habilitado deve conter o valor "false"
Na seção Operação geral o combobox Aplicativo do equipamento deve conter o valor "EAE_V0.9.0.8b.zip"
Na seção Operação geral o checkbox Passagem do rótulo Funções de operação deve conter o valor "true"
Na seção Operação geral o checkbox Sem limite do campo Limite de transações off-line deve conter o valor "false"
Na seção Operação geral o campo Limite de transações off-line deve conter o valor "100"
Na seção Operação geral o campo Número do setor spacenet deve conter o valor "3"
Na seção Operação de acesso no campo Período de funcionamento marcar o checkbox 'Sem período definido' com o valor "true"
Na seção Operação de acesso o campo Das do rótulo Período de funcionamento deve conter o valor ""   ""
Na seção Operação de acesso o campo As do rótulo Período de funcionamento deve conter o valor ""   ""
Na seção Operação de acesso o combobox Modo de acionamento do equipamento deve conter o valor "1 - Automático"
Na seção Operação de acesso o checkbox Detecção de moto deve conter o valor "false"
Na seção Operação de acesso o checkbox Acesso como passagem especial deve conter o valor "false"
Na seção Operação de acesso o checkbox Somente tag Nepos deve conter o valor "false"
Na seção Operação de acesso o checkbox Possui escape/gate mode deve conter o valor "true"
Na seção Operação de acesso o checkbox Múltiplos equipamentos por acesso (3 ou mais equipamentos) deve conter o valor "true"
Na seção Operação de acesso o combobox Tipo de escape/gate mode deve conter o valor "1 - Simples"
Na seção Operação de acesso o combobox Sentido do escape/gate mode deve conter o valor "2 - Esquerda"
Na seção Operação de acesso o combobox Acesso bolsão secundário deve conter o valor "BOLSÃO EXTERNO"
Na seção Configuração da cancela de saída o checkbox Possui cancela deve conter o valor "false"
Na seção Configuração da cancela de saída o checkbox Auto parada deve conter o valor "false"
Na seção Configuração da cancela de saída o checkbox Inicia nova transação com veículos sobre o laço de fechamento deve conter o valor "false"
Na seção Configuração da cancela de saída o checkbox Inicia nova transação após fechamento total da cancela deve conter o valor "false"
Na seção Configuração da cancela de saída o checkbox Existe laço para acionamento do equipamento deve conter o valor "false"
Na seção Configuração da cancela de saída o checkbox Existe laço de fechamento da cancela deve conter o valor "false"
Na seção Configuração da cancela de saída o checkbox Aguardar sinal de cancela fechada deve conter o valor "false"
Na seção Configuração da cancela de saída o campo Tempo limite para resposta da cancela (seg) deve conter o valor "20"
Na seção Configurações de suporte no checkbox Mostrar detalhes de espera após tecla acionada deve conter o valor "false"
Na seção Configurações de suporte no checkbox Alternar entre mensagem e detalhes de espera deve conter o valor "true"
Na seção Configurações de suporte no campo Tempo para mostrar detalhes de erro(seg) deve conter o valor "8"
Na seção Configurações de suporte no campo Tempo para mostrar detalhes de espera(seg) deve conter o valor "9"
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor mifare <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [EquipamentosPageStep] [16614]
Na seção Periférico deve conter o valor "8" no periférico "0 - Leitor Mifare"
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "1 - Leitor Proximidade" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor proximidade <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [EquipamentosPageStep] [16614]
Na seção Periférico deve conter o valor "3" no periférico "1 - Leitor Proximidade"
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "12 - Interfone Voip" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de interfone voip <table:resources/AlterarUmEquipamentoDePassagemEap16614.csv> [EquipamentosPageStep] [16614]
Na seção Interfone Voip alterar o campo Endereço IP com o valor "192.168.1.3"
Na seção Interfone Voip alterar o campo Código com o valor "30"
* Clicar no botão Fechar

## Alterar um equipamentos de validação (EAC) [16618]
 ST - Adicionar aplicativo <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> [16273]
* SS - Criar um Equipamentos de validação (EAC) <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> [16871]
* Clicar no menu de contexto (...) na linha contendo o valor "EAC para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> [EquipamentosPageStep] [16618]
Na seção Informações gerais alterar o campo Número do equipamento com o valor "30"
Na seção Informações gerais alterar o campo Nome com o valor "EAC alterar "
Na seção Informações gerais alterar o campo Endereço IP com o valor "100.100.100.0"
Na seção Informações gerais alterar o campo Máscara IP com o valor "0.0.0.0"
Na seção Informações gerais alterar o campo IP do gateway com o valor "0.0.0.0"
Na seção Informações gerais desemarcar o CheckBox Habilitado com o valor "false"
Na seção Operação geral no campo Limites de transações off-line desmarcar o CheckBox Sem limite com o valor "false"
Na seção Operação geral preencher o campo Limites de transações off-line com o valor "500"
Na seção Operação de atendimento assistido desmarcar o CheckBox Permitir digitação de número da mídia com o valor "false"
Na seção Operação de atendimento assistido desmarcar o CheckBox Utilizar múltiplas moedas com o valor "false"
Na seção Operação de atendimento assistido desmarcar o CheckBox Bloquear Pagamentos com o valor "true"
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> ["portaSerialCRT288EquipamentosEACalterado"] [EquipamentosPageStep]
Na seção Leitor mifare alterar o campo Porta serial deve conter o valor "4"  
* Clicar no botão Alterar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> ["portaSerialImpressorEquipamentosEACalterado"] [EquipamentosPageStep]
 Na seção Impressora alterar o campo 'Porta serial com o valor "1"  
* Clicar no botão Alterar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "6 - Leitor Tarja magnética" na tabela
* Clicar no botão Excluir na listagem 
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Excluir na listagem
* Preencher os campos da tela, na seção de configurações de suporte <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> [EquipamentosPageStep] [16618]
Na seção Configurações de suporte desmarcar o CheckBox Mostrar detalhes de espera após tecla acionada com o valor "false"
Na seção Configurações de suporte desmarcar o CheckBox Alternar entre mensagem e detalhes de espera com o valor "false"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de erro (seg) com o valor "100"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de espera (seg) com o valor "10"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "EAC alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> [EquipamentosPageStep] [16618]
Na seção Informações gerais o campo Número do equipamento deve conter o valor ""
Na seção Informações gerais o campo Nome deve conter ""
Na seção Informações gerais o campo Endereço IP deve conter o valor ""
Na seção Informações gerais o campo Máscara IP deve conter o valor ""
Na seção Informações gerais o campo IP do gateway deve conter o valor ""
Na seção Informações gerais o CheckBox Habilitado deve conter o valor ""
Na seção Operação geral  o combobox Aplicativo do equipamento deve conter o valor ""
Na seção Operação geral no campo Funções de operação marcar o CheckBox Validação deve conter o valor ""
Na seção Operação geral no campo Limites de transações off-line marcar o CheckBox Sem limite deve conter o valor ""
Na seção Operação geral no campo Número setor spacenet deve conter o valor ""
Na seção Operação de atendimento assistido o CheckBox Permitir digitação de número da mídia deve conter o valor ""
Na seção Operação de atendimento assistido o CheckBox Utilizar múltiplas moedas deve conter o valor ""
Na seção Operação de atendimento assistido o CheckBox Bloquear Pagamentos deve conter o valor ""
Na seção Configurações de suporte o CheckBox Mostrar detalhes de espera após tecla acionada deve conter o valor ""
Na seção Configurações de suporte o CheckBox Alternar entre mensagem e detalhes de espera deve conter o valor ""
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de erro (seg) deve conter o valor ""
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de espera (seg) deve conter o valor ""
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor mifare <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> [EquipamentosPageStep] [16618]
No campo 'Tipo do periférico' deve conter o valor ""
No campo Periférico principal deve conter o valor ""
No campo Habilitar deve conter o valor ""
Na seção Leitor mifare no combobox 'Modelo do leitor deve conter o valor ""
Na seção Leitor mifare no campo Porta serial deve conter o valor ""
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem 
* Verificar os campos do pop-up de periférico de impressora <table:resources/AlterarUmEquipamentosDeValidacaoEac16618.csv> [EquipamentosPageStep] [16618]
No campo 'Tipo do periférico' deve conter o valor ""
No campo Periférico principal deve conter o valor ""
No campo Habilitar deve conter o valor ""
Na seção Impressora no combobox 'Modelo da impressora' deve conter o valor ""
Na seção Impressora no campo Porta serial deve conter o valor ""
* Clicar no botão Fechar
* Clicar no botão Voltar

## Alterar um equipamento de validação automatica (EAP) [16619]
ST - Adicionar aplicativo <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> [16273]
* SS - Criar equipamento de validação automática (EAP) <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> [16921]
* Clicar no menu de contexto (...) na linha contendo o valor "EAPC Mifare Alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> [EquipamentosPageStep] [16619]
Na seção Informações gerais preencher o campo Número do equipamento com o valor "114"
Na seção Informações gerais preencher o campo Nome com o valor "EAP Alterado"
Na seção Informações gerais preencher o campo Endereço IP com o valor "192.168.1.1"
Na seção Informações gerais preencher o campo Máscara IP com o valor "255.255.255.0"
Na seção Informações gerais preencher o campo IP do gateway com o valor "192.168.0.1"
Na seção Informações gerais desmarcar o CheckBox Habilitado com o valor "false"
Na seção Operação geral no campo Limites de transações off-line desmarcar o CheckBox Sem limite com o valor "false"
Na seção Operação geral preencher o campo Limites de transações off-line com o valor "100"
Na seção Operação geral preencher o campo Número setor spacenet com o valor "2"
Na seção Operação de autoatendimento desmarcar o CheckBox Habilitar validação com cartão de débito com o valor "false"
Na seção Operação de autoatendimento desmarcar o CheckBox Habilitar validação em dinheiro com o valor "false"
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> ["portaSerialCRT288EquipamentosEAPalterar"] [EquipamentosPageStep]
No Pop-Up alterar o campo Porta serial para o valor "5"
* Clicar no botão Alterar Pop Up
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Alterar na listagem
* Preencher o campo Porta serial com o valor <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> ["portaSerialImpressoraEquipamentosEAPalterar"] [EquipamentosPageStep]
No Pop-Up alterar o campo Porta serial para o valor "4"
* Clicar no botão Alterar Pop Up
* Preencher os campos da tela, na seção de configurações de suporte <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> [EquipamentosPageStep] [16619]
Na seção Configurações de suporte desmarcar o CheckBox Mostrar detalhes de espera após tecla acionada com o valor "false"
Na seção Configurações de suporte desmarcar o CheckBox Alternar entre mensagem e detalhes de espera com o valor "false"
Na seção Configurações de suporte preencher o campo Tempo para mostrar detalhes de erro (seg) com o valor "5"
Na seção Configurações de suporte preencher o campo Tempo para mostrar detalhes de espera (seg) com o valor "3"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "EAPC Mifare Alterada" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> [EquipamentosPageStep] [16619]
Na seção Informações gerais o campo Número do equipamento deve conter o valor "115"
Na seção Informações gerais o campo Nome deve conter "EAP Alterado"
Na seção Informações gerais o campo Endereço IP deve conter o valor "192.168.1.1"
Na seção Informações gerais o campo Máscara IP deve conter o valor "255.255.255.0"
Na seção Informações gerais o campo IP do gateway deve conter o valor "192.168.0.1"
Na seção Informações gerais o CheckBox Habilitado deve conter o valor "false"
Na seção Operação geral no campo Limites de transações off-line marcar o CheckBox Sem limite deve conter o valor "false"
Na seção Operação geral no campo Número setor spacenet deve conter o valor "2"
Na seção Operação de autoatendimento o CheckBox Habilitar validação com cartão de débito deve conter o valor "false"
Na seção Operação de autoatendimento o CheckBox Habilitar validação em dinheiro deve conter o valor "false"
Na seção Configurações de suporte o CheckBox Mostrar detalhes de espera após tecla acionada deve conter o valor "false"
Na seção Configurações de suporte o CheckBox Alternar entre mensagem e detalhes de espera deve conter o valor "false"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de erro (seg) deve conter o valor "5"
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de espera (seg) deve conter o valor "3"
* Clicar no menu de contexto (...) na linha contendo o valor "0 - Leitor Mifare" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor mifare <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> [EquipamentosPageStep] [16619]
Na seção Leitor mifare no campo Porta serial deve conter o valor "5"
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de impressora <table:resources/AlterarUmEquipamentoDeValidacaoAutomaticaEap16619.csv> [EquipamentosPageStep] [16619]
Na seção Impressora no campo 'Porta serial deve conter o valor "4"
* Clicar no botão Fechar
* Clicar no botão Voltar

## Alterar um equipamento de VME [16620]
* SS - Criar equipamento de VME <table:resources/AlterarUmEquipamentoDeVme16620.csv> [16915]
* Clicar no menu de contexto (...) na linha contendo o valor "Equipamento VME para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarUmEquipamentoDeVme16620.csv> [EquipamentosPageStep] [16620]
Na seção Informações gerais  alterar o campo Número do equipamento com o valor "2"
Na seção Informações gerais  alterar o campo Nome com o valor "Equipamento VME Alterado"
Na seção Configurações de suporte alterar o checkbox Mostrar detalhes de espera após tecla acionada para o valor "false"
Na seção Configurações de suporte alterar o checkbox Alternar entre mensagem e detalhes de espera para o valor "false"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de erro (seg) para o valor "3"
Na seção Configurações de suporte alterar o campo Tempo para mostrar detalhes de espera (seg) para o valor "6"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Equipamento VME Alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarUmEquipamentoDeVme16620.csv> [EquipamentosPageStep] [16620]
Na seção Informações gerais o campo Número do equipamento deve conter o valor "2"
Na seção Informações gerais o campo Nome deve conter o valor "Equipamento VME Alterado"
Na seção Configurações de suporte marcar o checkbox Mostrar detalhes de espera após tecla acionada deve conter o valor "false"
Na seção Configurações de suporte marcar o checkbox Alternar entre mensagem e detalhes de espera deve conter o valor "false"
Na seção Configurações de suporte preencher o campo Tempo para mostrar detalhes de erro (seg) deve conter o valor "3"
Na seção Configurações de suporte preencher o campo Tempo para mostrar detalhes de espera (seg) conter o valor "6"
* Clicar no botão Voltar

## Excluir um equipamento de entrada (EAE) Mifare [16621]
ST - Adicionar aplicativo <table:resources/ExcluirUmEquipamentoDeEntradaEaeMifare16621.csv> [16273]
ST - Criar um bolsão de vagas <table:resources/ExcluirUmEquipamentoDeEntradaEaeMifare16621.csv> [16266]
* SS - Criar equipamento de entrada (EAE) Mifare step by step <table:resources/ExcluirUmEquipamentoDeEntradaEaeMifare16621.csv> [16899]
* Clicar no menu de contexto (...) na linha contendo o valor "Entrada Mifare para excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Excluir um equipamentos de saída (EAS) Mifare [16622]
ST - Criar um bolsão de vagas <table:resources/ExcluirUmEquipamentosDeSaidaEasMifare16622.csv> [16266]
ST - Adicionar aplicativo <table:resources/ExcluirUmEquipamentosDeSaidaEasMifare16622.csv> [16273]
* SS - Criar equipamento de Saída (EAS) Mifare <table:resources/ExcluirUmEquipamentosDeSaidaEasMifare16622.csv> [16928]
* Clicar no menu de contexto (...) na linha contendo o valor "Saida Mifare para excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Excluir um equipamentos de passagem (EAP) Mifare [16623]
ST - Criar um Bolsão de Vagas <table:resources/ExcluirUmEquipamentosDePassagemEapMifare16623.csv> [16152]
ST - Adicionar aplicativo <table:resources/ExcluirUmEquipamentosDePassagemEapMifare16623.csv> [16273]
* SS - Criar um Equipamento de passagem (EAP) <table:resources/ExcluirUmEquipamentosDePassagemEapMifare16623.csv> [16922]
* Clicar no menu de contexto (...) na linha contendo o valor "Passagem Mifare para excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso