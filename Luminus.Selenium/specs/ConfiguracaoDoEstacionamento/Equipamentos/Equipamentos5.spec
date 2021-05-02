# Equipamentos 5 [17570]
Criado pelo gerador 26/12/2019 09:44:51

 Carregar dependências Equipamentos <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv>
ST - Criar um bolsão de vagas <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [16266]
ST - Criar perfil com acesso a todos as funcionalidades <table:resources/AlterarUmEquipamentoDeEntradaEaeInformatizado17187.csv> [17684]

## Validar campos de um Equipamentos de Entrada Barcode(EAE) [16638]
ST - Adicionar aplicativo <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> [16273]
* Navegar para "UrlEquipamentoPage"
* Clicar no botão Criar
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Aplicativo do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O tipo de função do equipamento é obrigatório"
* Preencher os campos da tela <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> [EquipamentosPageStep] [16638]
Na seção Operação geral no combobox Aplicativo do Equipamento selecionar o valor "EAE/P/S 09.09"
Na seção Operação geral no rótulo Funções de operação marcar o checkbox Entrada com o valor "true"
* Movimentar barra de rolagem até o botão Adicionar [EquipamentosPageStep]
* Clicar no botão Adicionar
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> ["leitor1D2DEntradaEAEBarcode"] [EquipamentosPageStep]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* No combobox Modelo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> ["modeloDoLeitor1D2DEntradaEAEBarcode"] [EquipamentosPageStep]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> ["leitorTagEntradaEAEBarcode"] [EquipamentosPageStep]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tipo de instalação operação da leitora/antena' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Canal da antena conectado ao leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Ignorar leitura da mesma tag por (seg)' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Considerar leituras realizadas há até (décimos de seg)' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> ["impressoraEntradaEAEBarcode"] [EquipamentosPageStep]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo da impressora' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Modelo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> ["modeloDaImpressoraEntradaEAEBarcode"] [EquipamentosPageStep]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Porta serial' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeEntradaBarcodeEae16638.csv> ["placaDeSomEntradaEAEBarcode"] [EquipamentosPageStep]
* Clicar no botão Adicionar Pop Up
* Clicar no botão Fechar

## Validar campos de um Equipamentos de Saída Barcode(EAS) [16639]
ST - Adicionar aplicativo <table:resources/ValidarCamposDeUmEquipamentosDeSaidaBarcodeEas16639.csv> [16273]
* Navegar para "UrlEquipamentoPage"
* Clicar no botão Criar
* Preencher os campos da tela, na seção função de operação <table:resources/ValidarCamposDeUmEquipamentosDeSaidaBarcodeEas16639.csv> [EquipamentosPageStep] [16639]
Na seção Operação geral no campo Limite de transações off-line apagar o conteúdo do campo 
Na seção Operação geral no campo Número do setor spacenet apagar o conteúdo do campo 
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Aplicativo do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O tipo de função do equipamento é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Limite de transações off-line' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Número do setor spacenet' é obrigatório"
* Preencher os campos da tela <table:resources/ValidarCamposDeUmEquipamentosDeSaidaBarcodeEas16639.csv> [EquipamentosPageStep] [16639]
Na seção Operação geral clicar no combobox Aplicativo do equipamento e selecionar o valor "EAE/P/S 09.08"
Na seção Operação geral no rótulo Funções de operação marcar o checkbox Saída com o valor "true"
Na seção Operação de acesso no campo das do rótulo Período de funcionamento apagar o conteúdo do campo
Na seção Operação de acesso no campo as do rótulo Período de funcionamento apagar o conteúdo do campo
Na seção Operação de acesso marcar o checkbox Possui escape/gate mode ""
Na seção Configuração da cancela de saída marcar o checkbox Possui cancela ""
* Clicar no botão Salvar
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
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeSaidaBarcodeEas16639.csv> ["tipodoperifericoperiferico1equipamentos"] [EquipamentosPageStep]
No popup Adicionar periférico clicar no combobox Tipo do periférico e selecionar o valor "4 - Leitor 1D/2D" 
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentosDeSaidaBarcodeEas16639.csv> ["tipodoperifericoperiferico2equipamentos"] [EquipamentosPageStep]
No popup Adicionar periférico clicar no combobox Tipo do periférico e selecionar o valor "5 - Leitor Tag" 
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tipo de instalação operação da leitora/antena' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Canal da antena conectado ao leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Ignorar leitura da mesma tag por (seg)' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Considerar leituras realizadas há até (décimos de seg)' é obrigatório"
* Clicar no botão Fechar

## Validar campos de um Equipamento de Passagem Barcode(EAP) [16643]
ST - Adicionar aplicativo <table:resources/ValidarCamposDeUmEquipamentoDePassagemBarcodeEap16643.csv> [16273]
* Navegar para "UrlEquipamentoPage"
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarCamposDeUmEquipamentoDePassagemBarcodeEap16643.csv> [EquipamentosPageStep] [16643]
Na seção Operação geral no combobox Aplicativo do Equipamento selecionar o valor "EAE/P/S 09.09"
Na seção Operação geral marcar o Checkbox Passagem com o valor "true"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Número do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Modo de acionamento do equipamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Acesso bolsão principal' é obrigatório"
* Movimentar barra de rolagem até o botão Adicionar [EquipamentosPageStep]
* Clicar no botão Adicionar
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentoDePassagemBarcodeEap16643.csv> ["leitorBarcode1D2DEquipamento"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "4 - Leitor 1D/2D" 
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Modelo do leitor' é obrigatório"
* No combobox Tipo do periférico selecionar a opção <table:resources/ValidarCamposDeUmEquipamentoDePassagemBarcodeEap16643.csv> ["leitorTagEquipamento"] [EquipamentosPageStep]
No combobox Tipo do periférico selecionar a opção "5 - Leitor Tag" 
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Endereço IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Máscara IP' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'IP do gateway' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tipo de instalação operação da leitora/antena' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Canal da antena conectado ao leitor' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Ignorar leitura da mesma tag por (seg)' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Considerar leituras realizadas há até (décimos de seg)' é obrigatório"
* Clicar no botão Fechar

## Criar um equipamento entrada (EAE - Informatizado) [17182]
ST - Criar um bolsão de vagas <table:resources/CriarUmEquipamentoEntradaEaeInformatizado17182.csv> [16266]
* SS - Criar um equipamento entrada(EAE-Informatizado) <table:resources/CriarUmEquipamentoEntradaEaeInformatizado17182.csv> [17936]
* Clicar no menu de contexto (...) na linha contendo o valor "informatizado EAE" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoEntradaEaeInformatizado17182.csv> [EquipamentosPageStep] [17182]
Na seção Informações gerais o campo Número do equipamento deve conter o valor ""
Na seção Informações gerais  o campo Nome deve conter o valor ""
Na seção Informações gerais  o campo Endereço IP deve conter o valor ""
Na seção Informações gerais  o campo Máscara IP deve conter o valor ""
Na seção Informações gerais  o campo IP do gateway deve conter o valor ""
Na seção Informações gerais o checkbox Habilitado do campo Modelo do equipamento deve conter o valor ""
Na seção Operação geral no combobox Aplicativo do equipamento deve conter o valor ""
Na seção Operação geral no rótulo Funções de operação o checkbox Entrada deve conter o valor ""
Na seção Configuração do informatizado o combobox Tipo do informatizado deve conter o valor ""
Na seção Operação de acesso o campo das do rótulo Período de funcionamento deve conter o valor ""
Na seção Operação de acesso o campo ás do rótulo Período de funcionamento deve conter o valor ""
Na seção Operação de acesso o checkbox Possui escape/gate mode deve conter o valor ""
Na seção Operação de acesso no combobox Acesso bolsão principal deve conter o valor ""
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de impressora <table:resources/CriarUmEquipamentoEntradaEaeInformatizado17182.csv> [EquipamentosPageStep] [17182]
Na seção Periféricos na coluna Tipo do periférico deve conter o valor "" seção Periféricos na coluna Periférico principal deve conter o valor "" seção Periféricos na coluna Habilitar deve conter o valor "" seção Periféricos na coluna Modelo deve conter o valor "" seção Periféricos na coluna Porta serial deve conter o valor ""
* Clicar no botão Fechar
* Clicar no botão Voltar

## Criar um equipamento saída (EAS- Informatizado) [17183]
ST - Criar um bolsão de vagas <table:resources/CriarUmEquipamentoSaidaEasInformatizado17183.csv> [16266]
ST - Criar perfil de acesso - Operação <table:resources/CriarUmEquipamentoSaidaEasInformatizado17183.csv> [17610]
* ST - Criar um usuário do sistema <table:resources/CriarUmEquipamentoSaidaEasInformatizado17183.csv> [17595]
* SS - Criar um equipamento saída EAS (informatizado) <table:resources/CriarUmEquipamentoSaidaEasInformatizado17183.csv> [17633]
* Clicar no menu de contexto (...) na linha contendo o valor "EAS Informatizado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoSaidaEasInformatizado17183.csv> [EquipamentosPageStep] [17183]
Na seção Informações gerais o campo Número do equipamento deve conter o valor "303"
Na seção Informações gerais o campo Nome deve conter o valor "EAS Informatizado"
Na seção Informações gerais o checkbox Habilitado deve conter o valor "true"
Na seção Operação geral o combobox Aplicativo do equipamento deve conter o valor "Informatizado"
Na seção Operação geral o campo Funções de operação o CheckBox Saída deve conter o valor "Saída"
Na seção Configurações de informatizado o combobox Tipo de informatizado deve conter o valor "2 - Volante"
Na seção Configurações de informatizado o combobox Usuário dos sistema responsável deve conter o valor "Operacional"
Na seção Operação de acesso o campo Período de funcionamento das deve conter o valor "00:00"
Na seção Operação de acesso o campo Período de funcionamento das deve conter o valor "23:59"
Na seção Operação de acesso o checkbox Possui escape/gate mode deve conter o valor "true"
Na seção Operação de acesso o combobox Acesso bolsão principal deve conter o valor "Bolsão principal"
Na seção Operação de acesso o combobox Acesso bolsão principal deve conter o valor "BOLSÃO EXTERNO"
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos do pop-up de periférico de impressora <table:resources/CriarUmEquipamentoSaidaEasInformatizado17183.csv> [EquipamentosPageStep] [17183]
No pop-up Adicionar periférico o combobox Tipo do periférico deve conter o valor "2 - Impressora"
No pop-up Adicionar periférico o checkbox Periférico principal deve conter o valor "true"
No pop-up Adicionar periférico o checkbox Habilitar deve conter o valor "true"
No pop-up Adicionar periférico na seção Impressora o combobox Modelo da impressora deve conter o valor "1 - Engworks"
No pop-up Adicionar periférico na seção Impressora o campo Porta serial deve conter o valor "1"
* Clicar no botão Fechar
* Clicar no botão Voltar

## Criar um equipamento validação (Informatizado) [17185]
* ST - Criar um equipamento validação (Informatizado) <table:resources/CriarUmEquipamentoValidacaoInformatizado17185.csv> [17616]
* Clicar no menu de contexto (...) na linha contendo o valor "Validações Informatizadas" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoValidacaoInformatizado17185.csv> [EquipamentosPageStep] [17185]
Na seção Informações gerais o campo Número do equipamento deve conter o valor ""
Na seção Informações gerais o campo Nome deve conter ""
Na seção Informações gerais o campo Endereço IP deve conter o valor ""
Na seção Informações gerais o campo Máscara IP deve conter o valor ""
Na seção Informações gerais o campo IP do gateway deve conter o valor ""
Na seção Informações gerais o checkbox Habilitado deve conter o valor ""
Na seção Operação geral o combobox Aplicativo do equipamento deve conter o valor ""
Na seção Operação geral no campo Funções de operação o checkbox Validação deve conter o valor ""
Na seção Configuração de informatizado o combobox Tipo de informatizado deve conter o valor ""
Na seção Operação de atendimento assistido o checkbox Utilizar múltiplas moedas deve conter o valor ""
Na seção Operação de atendimento assistido o checkbox Bloquear pagamentos deve conter o valor ""
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoValidacaoInformatizado17185.csv> [EquipamentosPageStep] [17185]
No pop-up Adicionar periférico o combobox Tipo do periférico deve conter o valor ""
No pop-up Adicionar periférico o checkbox Periférico principal deve conter o valor ""
No pop-up Adicionar periférico o checkbox Habilitar deve conter o valor ""
Na seção Impressora o combobox Modelo Impressora Equipamentos deve conter o valor ""
Na seção Impressora o campo Porta serial deve conter o valor ""
* Clicar no botão Fechar
* Clicar no botão Voltar

## Criar um equipamento passagem (EAP - Informatizado) [17186]
ST - Criar um bolsão de vagas <table:resources/CriarUmEquipamentoPassagemEapInformatizado17186.csv> [16266]
* SS - Criar um equipamento passagem (EAP -Informatizado) <table:resources/CriarUmEquipamentoPassagemEapInformatizado17186.csv> [17939]
* Clicar no menu de contexto (...) na linha contendo o valor "Informatizado EAP" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoPassagemEapInformatizado17186.csv> [EquipamentosPageStep] [17186]
Na seção Informações gerais o campo Número do equipamento deve conter o valor ""
Na seção Informações gerais  o campo Nome deve conter o valor ""
Na seção Informações gerais  o campo Endereço IP deve conter o valor ""
Na seção Informações gerais  o campo Máscara IP deve conter o valor ""
Na seção Informações gerais  o campo IP do gateway deve conter o valor ""
Na seção Informações gerais o checkbox Habilitado do campo Modelo do equipamento deve conter o valor ""
Na seção Operação geral no combobox Aplicativo do equipamento deve conter o valor ""
Na seção Operação geral no rótulo Funções de operação o checkbox Passagem deve conter o valor ""
Na seção Configuração do informatizado o combobox Tipo do informatizado deve conter o valor ""
Na seção Operação de acesso o campo das do rótulo Período de funcionamento deve conter o valor ""
Na seção Operação de acesso o campo ás do rótulo Período de funcionamento deve conter o valor ""
Na seção Operação de acesso o checkbox Possui escape/gate mode deve conter o valor ""
Na seção Operação de acesso no combobox Acesso bolsão principal deve conter o valor ""
* Clicar no menu de contexto (...) na linha contendo o valor "2 - Impressora" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmEquipamentoPassagemEapInformatizado17186.csv> [EquipamentosPageStep] [17186]
No pop-up Adicionar periférico o combobox Tipo do periférico deve conter o valor ""
No pop-up Adicionar periférico o checkbox Periférico principal deve conter o valor ""
No pop-up Adicionar periférico o checkbox Habilitar deve conter o valor ""
Na seção Impressora o combobox Modelo Impressora Equipamentos deve conter o valor ""
Na seção Impressora o campo Porta serial deve conter o valor ""
* Clicar no botão Fechar
* Clicar no botão Voltar