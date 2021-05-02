# Operação de múltiplas cancelas [17614]
Criado pelo gerador 17/12/2019 18:18:04

* Carregar dependências Operação de múltiplas cancelas <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv>
ST - Criar um bolsão de vagas <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [16266]
SS - Criar um equipamento entrada(EAE-Informatizado) <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [17936]
ST - Criar um usuário do sistema <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [17595]
SS - Criar um equipamento saída EAS (informatizado) <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [17633]
ST - Criar tipos de ocorrências nas estadias <table:resources/EnviarComandoAbrirOperacaoDeMultiplasCancelas17278.csv> [16272]

## Enviar comando fechar (Operação de múltiplas cancelas) [17279]
* Navegar para "UrlOperarMultiplasCancelasPage"
* Na seção Ação acionar o radiobutton Fechar <table:resources/EnviarComandoFecharOperacaoDeMultiplasCancelas17279.csv> [OperacaoDeMultiplasCancelasPageStep]
* Preencher os campos da tela <table:resources/EnviarComandoFecharOperacaoDeMultiplasCancelas17279.csv> [OperacaoDeMultiplasCancelasPageStep] [17279]
Na seção Registro de ocorrência clicar no combobox Tipo de ocorrência e selecionar o valor "Obrigatório"
Na seção Registro de ocorrência preencher o textbox Justificativa com o valor "Justificando a operação"
* Clicar no botão Enviar
* Clicar no menu de contexto (...) na linha contendo o valor "1 - Fechar" na tabela
* Clicar no botão Detalhar na listagem
* Verificar campos da tela <table:resources/EnviarComandoFecharOperacaoDeMultiplasCancelas17279.csv> [OperacaoDeMultiplasCancelasPageStep] [17279]
Na seção Ação o radiobutton deve conter o valor "Fechar"
Na seção Registro de ocorrência combobox Tipo de ocorrência deve conter o valor "Obrigatório"
Na seção Registro de ocorrência textbox Justificativa deve conter o valor "Justificando a operação"

## Validar campos obrigatórios (Operação de múltiplas cancelas) [17280]
* Navegar para "UrlOperarMultiplasCancelasPage"
* Preencher os campos da tela <table:resources/ValidarCamposObrigatoriosOperacaoDeMultiplasCancelas17280.csv> [OperacaoDeMultiplasCancelasPageStep] [17280]
Na seção Equipamentos desmarcar o checkbox Entrada "false"
Na seção Equipamentos desmarcar o checkbox Passagem "false"
Na seção Equipamentos desmarcar o checkbox Saída "false"
* Clicar no botão Enviar
* Verificar mensagem de erro do campo "É obrigatório selecionar ao menos uma opção", na seção de Ação [OperacaoDeMultiplasCancelasPageStep]
* Verificar mensagem de erro do campo "É obrigatório selecionar ao menos uma opção", na seção de Equipamentos [OperacaoDeMultiplasCancelasPageStep]
* Verificar mensagem de erro do campo "O campo 'Tipo de ocorrência' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Justificativa' é obrigatório"

