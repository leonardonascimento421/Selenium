# Equipamentos 3 [17570]
Criado pelo gerador 26/12/2019 09:44:51

 Carregar dependências Equipamentos <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv>
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [16266]
ST - Criar perfil com acesso a todos as funcionalidades <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [17684]

## Excluir um equipamento de validação (EAC) [16624]
ST - Adicionar aplicativo <table:resources/ExcluirUmEquipamentoDeValidacaoEac16624.csv> [16273]
* SS - Criar um Equipamentos de validação (EAC) <table:resources/ExcluirUmEquipamentoDeValidacaoEac16624.csv> [16871]
* Clicar no menu de contexto (...) na linha contendo o valor "EAC para excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Excluir um equipamento de validação automática (EAP) [16625]
ST - Adicionar aplicativo <table:resources/ExcluirUmEquipamentoDeValidacaoAutomaticaEap16625.csv> [16273]
* SS - Criar equipamento de validação automática (EAP) <table:resources/ExcluirUmEquipamentoDeValidacaoAutomaticaEap16625.csv> [16921]
* Clicar no menu de contexto (...) na linha contendo o valor "EAP para excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Excluir um equipamento de VME [16626]
ST - Adicionar aplicativo <table:resources/ExcluirUmEquipamentoDeVme16626.csv> [16273]
ST - Criar um bolsão de vagas <table:resources/ExcluirUmEquipamentoDeVme16626.csv> [16266]
* SS - Criar equipamento de VME <table:resources/ExcluirUmEquipamentoDeVme16626.csv> [16915]
* Clicar no menu de contexto (...) na linha contendo o valor "Equipamento VME para excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Validar campos de um Equipamentos de Entrada (EAE) [16627]
ST - Adicionar aplicativo <table:resources/ValidarCamposDeUmEquipamentosDeEntradaEae16627.csv> [16273]
* Navegar para "UrlEquipamentoPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposDeUmEquipamentosDeEntradaEae16627.csv> [EquipamentosPageStep] [16627]
Na seção Operação geral no combobox Aplicativo do Equipamento selecionar o valor "EAE/P/S 09.09"
Na seção Operação geral marcar o CheckBox Entrada com o valor "true"
Na seção Operação geral preencher o campo Limite de transações off-line com o valor ""
Na seção Operação geral preencher o campo Número do setor spacenet com o valor ""
Na seção Operação de acesso preencher o campo Período de funcionamento 'das' com o valor ""
Na seção Operação de acesso preencher o campo Período de funcionamento 'ás' com o valor ""
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Limite de transações off-line' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Número do setor spacenet' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'das' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'às' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Modo de acionamento do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Acesso bolsão principal' é obrigatório"
* Clicar no botão Adicionar
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Tipo do periférico' é obrigatório"
* No combobox Tipo do periférico selecionar a opção de leitora Mifare <table:resources/ValidarCamposDeUmEquipamentosDeEntradaEae16627.csv> [EquipamentosPageStep] [16627]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção leitor de Proximidade <table:resources/ValidarCamposDeUmEquipamentosDeEntradaEae16627.csv> [EquipamentosPageStep] [16627]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção Tela VGA <table:resources/ValidarCamposDeUmEquipamentosDeEntradaEae16627.csv> [EquipamentosPageStep] [16627]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Resolução' é obrigatório"
* Clicar no botão Fechar
* Clicar no botão Voltar

,## Validar campos obrigatórios de um Equipamentos de Saída (EAS) Mifare [16628]
 ST - Adicionar aplicativo <table:resources/ValidarCamposObrigatoriosDeUmEquipamentosDeSaidaEasMifare16628.csv> [16273]
[FEITO] Navegar para "UrlEquipamentoPage"
[FEITO] Clicar no botão Criar
[FEITO] Preencher os campos da tela na seção Funções de operação <table:resources/ValidarCamposObrigatoriosDeUmEquipamentosDeSaidaEasMifare16628.csv> [EquipamentosPageStep] [16628]
Na seção Operação geral no campo Limite de transações off-line apagar o conteúdo do campo 
Na seção Operação geral no campo Número do setor spacenet apagar o conteúdo do campo 
[FEITO] Clicar no botão Salvar
[FEITO] Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Aplicativo do equipamento' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Limite de transações off-line' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Número do setor spacenet' é obrigatório"
[FEITO] Preencher os campos da tela geral <table:resources/ValidarCamposObrigatoriosDeUmEquipamentosDeSaidaEasMifare16628.csv> [EquipamentosPageStep] [16628]
Na seção Operação geral clicar no combobox Aplicativo do equipamento e selecionar o valor "EAE/P/S 09.09"
Na seção Operação geral no rótulo Funções de operação marcar o checkbox Saída com o valor "true"
Na seção Operação de acesso no campo das do rótulo Período de funcionamento apagar o conteúdo do campo 
Na seção Operação de acesso no campo as do rótulo Período de funcionamento apagar o conteúdo do campo
Na seção Operação de acesso marcar o checkbox Possui escape/gate mode ""
Na seção Configuração da cancela de saída marcar o checkbox Possui cancela ""
[FEITO] Clicar no botão Salvar
[FEITO] Verificar mensagem de erro do campo "O campo 'das' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'às' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Modo de acionamento do equipamento' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Tipo de escape/gate mode' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Sentido do escape/gate mode' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Acesso bolsão principal' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Acesso bolsão secundário' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Tempo limite para resposta da cancela (seg)' é obrigatório"
[FEITO] Clicar no botão Adicionar
[FEITO] Clicar no botão Adicionar Pop Up
No popup Adicionar periférico clicar no combobox Tipo do periférico e selecionar o valor "" 
[FEITO] Verificar mensagem de erro do campo "O campo 'Tipo do periférico' é obrigatório"
[FEITO] No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentosDeSaidaEasMifare16628.csv> ["tipodoperifericoperiferico1equipamentos"] [EquipamentosPageStep]
Na seção Leitor mifare clicar no combobox Modelo do leitor e selecionar o valor "0 - Leitor Mifare" 
[FEITO] Clicar no botão Adicionar Pop Up
[FEITO] Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
[FEITO] No combobox Modelo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentosDeSaidaEasMifare16628.csv> ["modelodoleitorperiferico1equipamentos"] [EquipamentosPageStep]
No popup Adicionar periférico clicar no combobox Modelo do leitor e selecionar o valor "0 - Mifare AM10"
[FEITO] Clicar no botão Adicionar Pop Up
[FEITO] Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Modelo do bocal' é obrigatório"
[FEITO] No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentosDeSaidaEasMifare16628.csv> ["tipodoperifericoperiferico2equipamentos"] [EquipamentosPageStep]
No popup Adicionar periférico clicar no combobox Tipo do periférico e selecionar o valor "1 - Leitor Proximidade" 
[FEITO] Clicar no botão Adicionar Pop Up
[FEITO] Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
[FEITO] Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
[FEITO] No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentosDeSaidaEasMifare16628.csv> ["tipodoperifericoperiferico3equipamentos"] [EquipamentosPageStep]
No popup Adicionar periférico clicar no combobox Tipo do periférico e selecionar o valor "7 - Placa de Som" 
[FEITO] Clicar no botão Adicionar Pop Up
[FEITO] Verificar mensagem de erro do campo "O campo 'Modelo da placa de som' é obrigatório"
[FEITO] Clicar no botão Fechar
[FEITO] Clicar no botão Voltar

## Validar campos obrigatórios de um equipamento de Passagem (EAP) Mifare [16629]
ST - Adicionar aplicativo <table:resources/ValidarCamposObrigatoriosDeUmEquipamentoDePassagemEapMifare16629.csv> [16273]
* Navegar para "UrlEquipamentoPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosDeUmEquipamentoDePassagemEapMifare16629.csv> [EquipamentosPageStep] [16629]
Na seção Operação geral clicar no combobox Aplicativo do equipamento e selecionar o valor "EAE/P/S 09.08"
Na seção Operação geral no campo Funções de operação marcar o checkbox Passagem com o valor "Passagem"
Na seção Operação de acesso no campo Periodo de funcionamento - das apagar o conteúdo do campo
Na seção Operação de acesso no campo Periodo de funcionamento - as apagar o conteúdo do campo
Na seção Operação de acesso marcar o checkbox Possui escape/gate mode ""
Na seção Configuração da cancela de saída marcar o checkbox Possui cancela ""
Na seção Operação geral preencher o campo Limite de transações off-line com o valor ""
Na seção Operação geral preencher o campo Número do setor spacenet com o valor ""
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Limite de transações off-line' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Número do setor spacenet' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'das' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'às' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Modo de acionamento do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tipo de escape/gate mode' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Sentido do escape/gate mode' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Acesso bolsão principal' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Acesso bolsão secundário' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tempo limite para resposta da cancela (seg)' é obrigatório"
* Movimentar barra de rolagem até o botão Adicionar [EquipamentosPageStep]
* Clicar no botão Adicionar
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Tipo do periférico' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentoDePassagemEapMifare16629.csv> ["leitorMifareEquipamentosEAPassagem"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "0 - Leitor Mifare"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Modelo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentoDePassagemEapMifare16629.csv> ["modeloLeitorMifareEquipamentosEAPassagem"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "0 - Mifare AM10"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Modelo do bocal' é obrigatório"
* No combobox Modelo do Bocal selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentoDePassagemEapMifare16629.csv> ["modeloBocalLeitorMifareEquipamentosEAPassagem"] [EquipamentosPageStep]
No combobox Modelo do periférico selecionar a opção "0 - Novo"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tempo de espera na esteira (ciclos/seg)' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tempo de aguardo para emissão (ciclos/seg)' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentoDePassagemEapMifare16629.csv> ["leitorProximidadeEquipamentosEAPassagem"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "1 - Leitor Proximidade"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposObrigatoriosDeUmEquipamentoDePassagemEapMifare16629.csv> ["interfoneVoipEquipamentosEAPassagem"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "12 - Interfone Voip"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Interfone Voip' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Código' é obrigatório"
* Clicar no botão Fechar
* Clicar no botão Voltar

## Validar campos de um Equipamentos de Validação (EAC) [16630]
 ST - Adicionar aplicativo <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoEac16630.csv> [16273]
* Navegar para "UrlEquipamentoPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoEac16630.csv> [EquipamentosPageStep] [16630]
Na seção Operação geral  selecionar no combobox Aplicativo do equipamento o valor "EAC_V08.14.zip"
Na seção Operação geral no campo Funções de operação marcar o CheckBox Validação com o valor "true"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Clicar no botão Adicionar
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoEac16630.csv> ["leitorMifareEquipamentoEACMifare"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "0 - Leitor Mifare"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoEac16630.csv> ["impressoraEquipamentoEACMifare"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "2 - Impressora"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo da impressora' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoEac16630.csv> ["leitor1d2dEquipamentoEACMifare"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "4 - Leitor 1D/2D"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoEac16630.csv> ["leitorTarjaMagneticaEquipamentoEACMifare"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "6 - Leitor Tarja magnética"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* Clicar no botão Fechar
* Clicar no botão Voltar

## Validar campos de um Equipamentos de Validação automática (EAP) [16631]
ST - Adicionar aplicativo <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoAutomaticaEap16631.csv> [16273]
* Navegar para "UrlEquipamentoPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoAutomaticaEap16631.csv> [EquipamentosPageStep] [16631]
Na seção Operação geral  selecionar no combobox Aplicativo do equipamento o valor "EAP V.2.2.8.17"
Na seção Operação geral no campo Funções de operação marcar o CheckBox Validação com o valor "true"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Movimentar barra de rolagem até o botão Adicionar [EquipamentosPageStep]
* Clicar no botão Adicionar
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoAutomaticaEap16631.csv> ["leitorMifareEquipamentosEAP"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "0 - Leitor Mifare"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoAutomaticaEap16631.csv> ["impressoraEquioamentosEAP"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "2 - Impressora"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo da impressora' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoAutomaticaEap16631.csv> ["leitor1D2DEquioamentosEAP"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "4 - Leitor 1D/2D"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeValidacaoAutomaticaEap16631.csv> ["modulosFinanceirosEquipamentosEAP"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "9 - Módulos Financeiros"
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo dos módulos financeiros' é obrigatório"
* Clicar no botão Fechar
* Clicar no botão Voltar

## Criar um equipamento de entrada barcode(EAE) [16632]
ST - Criar um bolsão de vagas <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [16266]
ST - Adicionar aplicativo <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [16273]
* SS - Criar um equipamento de entrada Barcode(EAE) step by step <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [16632]
* Clicar no menu de contexto (...) na linha contendo o valor "Entrada Barcode" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [EquipamentosPageStep] [16632]
Na seção Informações gerais o campo Número do equipamento deve conter o valor ""
Na seção Informações gerais o campo Nome deve conter o valor ""
Na seção Informações gerais o campo Endereço IP deve conter o valor ""
Na seção Informações gerais o campo Máscara IP deve conter o valor ""
Na seção Informações gerais o campo IP do gateway deve conter o valor ""
Na seção Informações gerais o checkbox Habilitado deve conter o valor ""
Na seção Operação geral o campo Aplicativo do equipamento deve conter o valor ""
Na seção Operação geral com o rótulo Funções de operação o checkbox Entrada deve conter o valor ""
Na seção Operação geral o checkbox Sem limite deve conter o valor ""
Na seção Operação geral o campo Número do setor spacenet deve conter o valor ""
Na seção Operação de acesso com o rótulo Período de funcionamento no campo Das deve conter o valor ""
Na seção Operação de acesso com o rótulo Período de funcionamento no campo ás deve conter o valor ""
Na seção Operaçao de acesso no combobox Modo de acionamento deve conter o valor ""
Na seção Operação de acesso no checkbox Detecção de moto deve conter o valor ""
Na seção Operação de acesso no checkbox Somente tag Nepos deve conter o valor ""
Na seção Operação de acesso no checkbox Possui escape/gate mode deve conter o valor ""
Na seção Operação de acesso no combobox Acesso bolsão principal deve conter o valor ""
Na seção Configurações de suporte no checkbox Mostrar detalhes de espera após tecla acionada deve conter o valor ""
Na seção Configurações de suporte no checkbox Alternar entre mensagem e detalhes de espera deve conter o valor ""
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de erro(seg) deve conter o valor ""
Na seção Configurações de suporte o campo Tempo para mostrar detalhes de espera(seg) deve conter o valor ""
* Clicar no menu de contexto (...) na linha contendo o valor "4 - Leitor 1D/2D" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de Leitora 1D/2D <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [EquipamentosPageStep] [16632]
No popup Adicionar periférico o combobox Tipo do periférico deve constar o valor ""
No popup Adicionar periférico o checkbox Habilitar deve constar o valor ""
Na popup, o combobox Modelo do leitor deve constar o valor ""
Na popup, o campo Porta serial deve constar o valor ""
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "5 - Leitor Tag" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de leitor tag <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [EquipamentosPageStep] [16632]
No popup Adicionar periférico o combobox Tipo do periférico deve constar o valor ""
No popup Adicionar periférico o checkbox Habilitar deve constar o valor ""
Na popup, o combobox Modelo do leitor deve constar o valor ""
Na popup, o campo Porta serial deve constar o valor ""
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de impressora <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [EquipamentosPageStep] [16632]
No popup Adicionar periférico o combobox Tipo do periférico deve constar o valor ""
No popup Adicionar periférico o checkbox Habilitar deve constar o valor ""
Na popup, o combobox Modelo do leitor deve constar o valor ""
Na popup, o campo Porta serial deve constar o valor ""
* Clicar no botão Fechar
* Clicar no menu de contexto (...) na linha contendo o valor "7 - Placa de Som" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de placa de som <table:resources/CriarUmEquipamentoDeEntradaBarcodeEae16632.csv> [EquipamentosPageStep] [16632]
No popup Adicionar periférico o combobox Tipo do periférico deve constar o valor "7 - Placa de Som"
No popup Adicionar periférico o checkbox Habilitar deve constar o valor "true"
Na popup, o campo Modelo da placa de som deve constar o valor "1 - USB"
* Clicar no botão Fechar
* Clicar no botão Voltar