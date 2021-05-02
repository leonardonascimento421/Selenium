# Regras de Emissão de Bilhetes Impressos [14304]
Criado pelo gerador 28/10/2020 15:50:03

* Carregar dependências Regras de Emissao de Bilhetes Impressos <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv>
 ST - Adicionar aplicativo <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [16273]
 ST - Criar um bolsão de vagas <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [16266]
 SS - Criar equipamento de entrada (EAE) Mifare step by step <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [16899]

## Criar Regra de emissão de bilhetes [17511]
* SS - Criar regra de emissão de bilhetes impressos <table:resources/CriarRegraDeEmissaoDeBilhetes17511.csv> [17562]
* Clicar no menu de contexto (...) na linha contendo o valor "Regras de emissão de bilhetes impressos" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela <table:resources/CriarRegraDeEmissaoDeBilhetes17511.csv> [RegrasDeEmissaoDeBilhetesImpressosPageStep]
Na seção Informações gerais o campo Versão deve conter o valor "1"
Na seção Informações gerais o campo Nome deve conter o valor "Regras de emissão de bilhetes impressos"
Na seção Cabeçalho o campo Linha 1 deve conter o valor "Linha 1 cabeçalho"
Na seção Cabeçalho o campo Linha 2 deve conter o valor "Linha 2 cabeçalho""
Na seção Rodapé o campo Linha 1 deve conter o valor "Linha 1 rodapé"
Na seção Rodapé o campo Linha 2 deve conter o valor "Linha 2 rodapé"
* Clicar no botão Voltar

## Validar campos obrigatórios [17512]
* Navegar para "UrlRegraDeEmissaoDeBilhetesImpressos"
* Clicar no botão Criar
* Preencher os campos da tela de Regras de emissão de recibo <table:resources/ValidarCamposObrigatorios17512.csv> [RegrasDeEmissaoDeBilhetesImpressosPageStep] [17512]
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Vigente a partir de' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"


## Alterar uma Regra de emissão de bilhetes [17513]
* SS - Criar regra de emissão de bilhetes impressos <table:resources/AlterarUmaRegraDeEmissaoDeBilhetes17513.csv> [17562]
* Clicar no menu de contexto (...) na linha contendo o valor "Regras de emissão para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela Alterar regras de emissão de recibo <table:resources/AlterarUmaRegraDeEmissaoDeBilhetes17513.csv> [RegrasDeEmissaoDeBilhetesImpressosPageStep]
Na seção Informações gerais marcar o checkbox Imediatamente do campo vigente a partir de com o valor "true"
Na seção Informações gerais preencher o campo Nome com o valor "Regras de emissão de bilhetes impressos alterado"
Na seção Cabeçalho preencher o campo Linha 1 com o valor "alterado 1 cabeçalho"
Na seção Cabeçalho preencher o campo Linha 2 com o valor "alterado 2 cabeçalho"
Na seção Rodapé preencher o campo Linha 1 com o valor "alterado 1 rodapé"
Na seção Rodapé preencher o campo Linha 2 com o valor "alterado 2 rodapé"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Regras de emissão de bilhetes impressos alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar os campos da tela alterado <table:resources/AlterarUmaRegraDeEmissaoDeBilhetes17513.csv> [RegrasDeEmissaoDeBilhetesImpressosPageStep] [17513]
Na seção Informações gerais o campo Versão deve conter o valor "2"
Na seção Informações gerais o campo Nome deve conter o valor "Regras de emissão de bilhetes impressos alterado"
Na seção Cabeçalho o campo Linha 1 deve conter o valor "alterado 1 cabeçalho"
Na seção Cabeçalho o campo Linha 2 deve conter o valor "alterado 2 cabeçalho"
Na seção Rodapé o campo Linha 1 deve conter o valor "alterado 1 rodapé"
Na seção Rodapé o campo Linha 2 deve conter o valor "alterado 2 rodapé"
* Clicar no botão Voltar

## Excluir uma Regra de emissão de bilhetes [17514]
* SS - Criar regra de emissão de bilhetes impressos <table:resources/ExcluirUmaRegraDeEmissaoDeBilhetes17514.csv> [17562]
* Clicar no menu de contexto (...) na linha contendo o valor "Regras de emissão excluir" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso


## Aplicar uma regra de emissão de bilhetes impressos [14307]
 ST - Adicionar aplicativo <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [16273]
 ST - Criar um bolsão de vagas <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [16266]
 SS - Criar equipamento de entrada (EAE) Mifare step by step <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [16899]
* SS - Criar regra de emissão de bilhetes impressos <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [17562]
* SS - Aplicar uma regra de emissão de bilhetes impressos <table:resources/AplicarUmaRegraDeEmissaoDeBilhetesImpressos14307.csv> [26714]