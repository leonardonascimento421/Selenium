# Fechamento fatura [26564]
Criado pelo gerador 05/11/2020 09:40:54

Dependências Fechamento Fatura
SS - Criar perfil com acesso a todos as funcionalidades <table:resources/CriarUmFechamentoDeFatura23169.csv> [17684]
SS - Criar um usuário do sistema <table:resources/CriarUmFechamentoDeFatura23169.csv> [17595]
SS - Criar uma Estrutura de cobrança <table:resources/CriarUmFechamentoDeFatura23169.csv> [16003]
SS - Criar regras de cobrança <table:resources/CriarUmFechamentoDeFatura23169.csv> [16135]
SS - Criar tabelas de cobrança <table:resources/CriarUmFechamentoDeFatura23169.csv> [16091]

## Criar um fechamento de fatura [23169]
* SS - Criar contrato de locadora <table:resources/CriarUmFechamentoDeFatura23169.csv> [26617]
* SS - Criar um fechamento de fatura <table:resources/CriarUmFechamentoDeFatura23169.csv> [26619]
* Clicar no menu de contexto (...) na linha contendo o valor "1" na tabela
* Clicar na opção liquidar na listagem [FechamentoFaturaPageStep]
* Na seção Dados fatura preencher o campo Data pagamento com o valor DateTime.Now [FechamentoFaturaPageStep]
* Na seção Dados fatura preencher o campo Hora Liquidação com o valor DateTime.Now [FechamentoFaturaPageStep]
* Clicar no botão liquidar [FechamentoFaturaPageStep]
* Clicar no menu de contexto (...) na linha contendo o valor "1" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarUmFechamentoDeFatura23169.csv> [FechamentoFaturaPageStep] [23172]
Na seção Informações gerais o campo Contrato deve conter o valor ""
Na seção Dados fatura o campo Número fatura deve conter o valor "2"
Na seção Dados fatura o campo Data pagamento deve conter o valor de "DateTime.Now"
Na seção Dados fatura o campo Valor parcial deve conter o valor "0"
Na seção Dados fatura o campo Valor mensalidade deve conter o valor ""
Na seção Dados fatura o campo Tipo cálculo excedente deve conter o valor "1"
* Clicar no botão Voltar

## Validar campos obrigatórios [23179]
* Navegar para "UrlFechamentoFaturaPage"
* Clicar no botão Criar
* Na seção Dados fatura preencher o campo Hora fechamento com o valor "" [FechamentoFaturaPageStep]
* Clicar no botão Criar
* Verificar mensagem de erro do campo "O campo 'Contrato' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Data fechamento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Hora fechamento' é obrigatório"
* Clicar no botão Voltar

