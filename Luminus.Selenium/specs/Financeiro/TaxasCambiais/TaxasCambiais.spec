# Taxas cambiais [15792]
Criado pelo gerador 17/12/2019 15:49:02

## Excluir Moeda da Taxa Cambial [15971]
* SS - Alterar Taxas cambiais <table:resources/ExcluirMoedaDaTaxaCambial15971.csv> [16018]
* Clicar no botão Alterar
* O checkBox Imediatamente deve estar marcado <table:resources/AlterarMoedaDaTaxaCambial15972.csv> [TaxasCambiaisPageStep]
* Clicar no menu de contexto (...) na linha contendo o valor "Dólar australiano" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Salvar
* Validar na seção Taxas cambiais por moeda <table:resources/ExcluirMoedaDaTaxaCambial15971.csv> [TaxasCambiaisPageStep]

## Alterar Moeda da Taxa Cambial [15972]
* SS - Alterar Taxas cambiais <table:resources/AlterarMoedaDaTaxaCambial15972.csv> [16018]
* Clicar no botão Alterar
* Clicar no menu de contexto (...) na linha contendo o valor "Dólar canadense" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela <table:resources/AlterarMoedaDaTaxaCambial15972.csv> [TaxasCambiaisPageStep] [15972]
Selecionar a opção "" no Combobox 'Moeda para'
Preencher o textbox Valor taxa direta com o valor ""
* Clicar no botão Alterar Pop Up
* O checkBox Imediatamente deve estar marcado <table:resources/AlterarMoedaDaTaxaCambial15972.csv> [TaxasCambiaisPageStep]
* Clicar no botão Salvar
* Verificar os campos da tela <table:resources/AlterarMoedaDaTaxaCambial15972.csv> [TaxasCambiaisPageStep] [15972]

## Alterar taxa cambial [15793]
* Navegar para "UrlTaxasCambiaisPage"
* Clicar no botão Alterar
* Preencher os campos da tela <table:resources/AlterarTaxaCambial15973.csv> [TaxasCambiaisPageStep] [15793]
* Clicar no botão Adicionar
* Preencher os campos da tela <table:resources/AlterarTaxaCambial15973.csv> [TaxasCambiaisPageStep]
* Clicar no botão Adicionar Pop Up
Na seção (seção) marcar o checkbox Imediatamente ""
Na seção Informações Gerais preencher o campo Vigente até com o valor ""
Na seção Informações Gerais preencher o campo hora e minuto com valor ""
Na seção Informações Gerais clicar no combobox Moeda base, selecionar o valor ""
Preencher o campo Valor taxa direta com o valor ""
Validar na seção Taxas cambiais por moeda se o campo Moeda para está com o valor ""
Validar na seção Taxas cambiais por moeda se o campo Valor taxa direta está com o valor ""
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Verificar os campos da tela <table:resources/AlterarTaxaCambial15973.csv> [TaxasCambiaisPageStep]

## Validar campos obrigatórios [15969]
* Navegar para "UrlTaxasCambiaisPage"
* Clicar no botão Alterar
* Preencher os campos da tela <table:resources/ValidarORangeDeValorDaTaxaDiretaDeUmaTaxaCambial15970.csv> [TaxasCambiaisPageStep] [15970]
Apagar o valor do campo Vigente a partir de (data/hora)
O checkBox Imediatamente deve estar desmarcado
Apagar o valor do campo Vigente até (data/hora)
O combobox Moeda base deve estar com o campo vazio
Selecionar no comboBox Moeda para a opção "Dólar americano"
No campo Valor taxa direta preencher com o valor "0,00"
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Vigente a partir de' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Vigente até' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Vigente até' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Moeda base' é obrigatório"
* Clicar no botão Adicionar
* Preencher os campos da tela <table:resources/ValidarORangeDeValorDaTaxaDiretaDeUmaTaxaCambial15970.csv> [TaxasCambiaisPageStep]
* Clicar no botão Adicionar Pop Up
* Verificar mensagem de erro do campo "O campo 'Moeda para' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Valor taxa direta' deve ter um valor entre 0,01 e 99999999,99."
* Clicar no botão Fechar




