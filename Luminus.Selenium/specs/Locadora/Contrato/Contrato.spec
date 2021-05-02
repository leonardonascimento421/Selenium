# Contrato [26565]
Criado pelo gerador 03/11/2020 16:15:10

 Dependências Contrato Locadora
 ST - Criar perfil com acesso a todos as funcionalidades <tabela> [17684]
 ST - Criar um usuário do sistema <tabela> [17595]
 SS - Criar uma Estrutura de cobrança <tabela> [16003]
 SS - Criar regras de cobrança <tabela> [16135]
 SS - Criar tabelas de cobrança <tabela> [16091]

## Criar contrato de locadora [23161]
* SS - Criar contrato de locadora <table:resources/CriarContratoDeLocadora23161.csv> [26617]
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Locadora 23161" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarContratoDeLocadora23161.csv> [ContratoPageStep] [23161]
Na seção Informações gerais o campo Nome do contrato deve conter o valor "ADMINISTRADOR"
Na seção Informações gerais o campo Tipo de calculo de excedente deve conter o valor "1 - Estadia Individual"
Na seção Informações gerais o campo Valor de mensalidade deve conter o valor "201,01"
Na seção Informações gerais o campo Dia de Vencimento deve conter o valor "5"
Na seção Informações gerais o campo Quantidade de vagas deve conter o valor "1"
Na seção Informações gerais o campo Tabela de cobrança deve conter o valor "Produto Estadia Tabela"
Na seção Informações gerais o checkbox Selecionado deve conter o valor "ADMINISTRADOR"
* Clicar no botão Voltar

## Alterar contrato de locadora [23163]
* SS - Criar contrato de locadora <table:resources/AlterarContratoDeLocadora23163.csv> [26617]
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Locadora 23163" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarContratoDeLocadora23163.csv> [ContratoPageStep] [23163]
Na seção informações gerais marcar o checkbox Imediatamente em Vigente a partir de "true"
Na seção Informações gerais preencher o campo Nome do contrato com o valor "Contrato Locadora 23163 Alterado"
Na seção Informações gerais preencher o campo Valor de mensalidade com o valor "200,00"
Na seção Informações gerais preencher o campo Dia de vencimento com o valor "4"
Na seção Informações gerais preencher o campo Quantidade de vagas com o valor "2"
Na seção Informações gerais clicar no combobox Tabela de cobrança e selecionar o valor "Produto Estadia Tabela"
* Clicar no botão Salvar
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Locadora 23163 Alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/AlterarContratoDeLocadora23163.csv> [ContratoPageStep] [23163]
Na seção Informações gerais o campo Nome do contrato deve conter o valor "Contrato Locadora 23163 Alterado"
Na seção Informações gerais o campo Tipo de calculo de excedente deve conter o valor "1 - Estadia Individual"
Na seção Informações gerais o campo Valor de mensalidade deve conter o valor "200,00"
Na seção Informações gerais o campo Dia de Vencimento deve conter o valor "4"
Na seção Informações gerais o campo Quantidade de vagas deve conter o valor "2"
Na seção Informações gerais o campo Tabela de cobrança deve conter o valor "Produto Estadia Tabela"
Na seção Informações gerais o checkbox Selecionado deve conter o valor "Usuario Contrato Locadora"
* Clicar no botão Voltar

## Excluir contrato de locadora [23165]
* SS - Criar contrato de locadora <table:resources/ExcluirContratoDeLocadora23165.csv> [26617]
* Clicar no menu de contexto (...) na linha contendo o valor "Contrato Locadora 23165 Excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Validar campos obrigatórios [23167]
* Navegar para "UrlContratoLocadoraPage"
* Clicar no botão Criar
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome do contrato' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tipo de calculo de excedente' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Valor de mensalidade' deve ter um valor entre 0,01 e 9999999."
* Verificar mensagem de erro do campo "O campo 'Dia de Vencimento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de vagas' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tabela de cobrança para Excedente' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tabela de cobrança para Checkin' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Tabela de cobrança para Checkout' é obrigatório"
* Verificar mensagem de erro do campo "É necessário pelo menos 1 usuário associado ao contrato"
* Clicar no botão Voltar

