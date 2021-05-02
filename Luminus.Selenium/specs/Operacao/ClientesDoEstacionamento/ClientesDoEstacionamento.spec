'# Clientes do estacionamento [15979]
Criado pelo gerador 28/11/2019 15:37:33

## Criar cliente do estacionamento com 'CNPJ' [16844]
* ST - Criar um Clientes do estacionamento com CNPJ <table:resources/CriarClienteDoEstacionamentoComCnpj16844.csv> [16845]
* Clicar no menu de contexto (...) na linha contendo o valor "Cliente Com CNPJ" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela Clientes do estacionamento com CNPJ <table:resources/CriarClienteDoEstacionamentoComCnpj16844.csv> [15980]
Na seção Informações gerais o campo Nome deve estar preenchido com o valor ""
Na seção Informações gerais o campo Email deve estar preenchido com o valor ""
Na seção Informações gerais o campo Documento deve estar preenchido com o valor ""
Na seção Informações gerais o campo Número documento deve estar preenchido com o valor ""
Na seção Informações de contato o campo Telefone deve estar preenchido com o valor ""
Na seção Informações de contato o campo Logradouro deve estar preenchido com o valor ""
Na seção Informações de contato o campo Número deve estar preenchido com o valor ""
Na seção Informações de contato o campo CEP deve estar preenchido com o valor ""
Na seção Informações de contato o campo Cidade deve estar preenchido com o valor ""
Na seção Informações de contato o campo UF deve estar preenchido com o valor ""
* Clicar no botão Voltar

## Criar clientes do estacionamento [15980]
* ST - Criar clientes do estacionamento <table:resources/CriarClientesDoEstacionamento15980.csv> [16128]
* Clicar no menu de contexto (...) na linha contendo o valor "Selenium" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela Clientes do estacionamento <table:resources/CriarClientesDoEstacionamento15980.csv> [15980]
Na seção Informações gerais o campo Nome deve estar preenchido com o valor "Selenium"
Na seção Informações gerais o campo Email deve estar preenchido com o valor "Selenium@Nepos.com.br"
Na seção Informações gerais o campo Documento deve estar preenchido com o valor "2 - RG"
Na seção Informações gerais o campo Número documento deve estar preenchido com o valor "01234567891011"
Na seção Informações gerais o campo Número documento deve estar preenchido com o valor "1 - CNPJ"
Na seção Informações gerais o campo Número documento deve estar preenchido com o valor "01234567891011"
Na seção Informações de contato o campo Telefone deve estar preenchido com o valor "1130185400"
Na seção Informações de contato o campo Celular deve estar preenchido com o valor "1191929394"
Na seção Informações de contato o campo Logradouro deve estar preenchido com o valor "Rua Carmo do Rio Verde"
Na seção Informações de contato o campo Número deve estar preenchido com o valor "245"
Na seção Informações de contato o campo Complemento deve estar preenchido com o valor "Nepos"
Na seção Informações de contato o campo CEP deve estar preenchido com o valor "04729010"
Na seção Informações de contato o campo Cidade deve estar preenchido com o valor "São Paulo"
Na seção Informações de contato o campo UF deve estar preenchido com o valor "SP"
Na seção Informações complementares o campo Observação 1 deve estar preenchido com o valor "Teste realizado pelo selenium"
Na seção Informações complementares o campo Observacao 2 deve estar preenchido com o valor "Teste realizado pelo selenium"
Na seção Veículo o campo Placa deve estar preenchido com o valor "CRI2019"
Na seção Veículo o campo Modelo deve estar preenchido com o valor "Chevete"
Na seção Veículo o campo Cor deve estar preenchido com o valor "Vinho"
* Clicar no botão Voltar

## Alterar clientes do estacionamento [15981]
* ST - Criar clientes do estacionamento <table:resources/AlterarClientesDoEstacionamento15981.csv> [16128]
* Clicar no menu de contexto (...) na linha contendo o valor "AlteraçãoDeNome" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela Alterar clientes do estacionamento <table:resources/AlterarClientesDoEstacionamento15981.csv> [16128]
Na seção Informações gerais no campo Nome alterar o valor "Nome" para "AlterarNome"
Na seção Informações gerais no campo Email alterar o valor "email@email.com.br" para "Alteraremail@email.com.br"
Na seção Informações gerais no Combobox Documento alterar a opção "0 - CPF" para "1 - CNPJ"
Na seção Informações gerais no campo Número documento alterar o valor "11111111111111" para "22222222222222"
Na seção Informações gerais no Combobox Documento alterar a opção "2 - RG" para "0 - CPF"
Na seção Informações gerais no campo Número documento alterar o valor "11111111111111" para "88888888888888"
Na seção Informações de contato no campo Telefone alterar o valor "1130185400" para "9130185454"
Na seção Informações de contato no campo Celular alterar o valor "11991979197" para "11981878187"
Na seção Informações de contato no campo Logradouro alterar o valor "Logradouro" para "AlterarLogradouro"
Na seção Informações de contato no campo Número alterar o valor "123" para "456"
Na seção Informações de contato no campo Complemento alterar o valor "Complemento" para "AlterarComplemento"
Na seção Informações de contato no campo CEP alterar o valor "30303030" para "40404040"
Na seção Informações de contato no campo Cidade alterar o valor "Cidade" para "AlterarCidade"
Na seção Informações de contato no campo UF alterar o valor "UF" para "SP"
Na seção Informações complementares no campo Observação 1 alterar o valor "Observação 1" para "AlterarObservação 1"
Na seção Informações complementares no campo Observação 2 alterar o valor "Observação 2" para "AlterarObservação 2"
Clicar no botão Alterar
No campo Placa alterar o valor "ALT2019" para "ALT2020"
No ComboBox Modelo alterar a opção "Chevete" para "Golf"
No ComboBox Cor alterar a opção "Vinho" para "Azul"
* Clicar no botão Salvar

## Validar campos obrigatórios de clientes do estacionamento [15982]
* Navegar para "UrlClientesDoEstacionamentoPage"
* Clicar no botão Criar
Na seção Informações gerais o campo Nome deve estar sem valor
Na seção Informações gerais o ComboBox Documento deve estar sem valor
Na seção Informações gerais o campo Número documento deve estar sem valor
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Documento' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Número documento' é obrigatório"
* Clicar no botão Adicionar
O campo Placa deve estar sem valor
O ComboBox Modelo deve estar sem valor
O ComboBox Cor deve estar sem valor
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Placa' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Modelo' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Cor' é obrigatório"

## Excluir clientes do estacionamento [15983]
* ST - Criar clientes do estacionamento <table:resources/ExcluirClientesDoEstacionamento15983.csv> [16128]
* Clicar no menu de contexto (...) na linha contendo o valor "Cliente Exclusão" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir

