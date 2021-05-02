# Bolsao Vagas [13708]
Criado pelo gerador 11/11/2019 15:09:45

## Permitir código de bolsão de 1 até 14 [13720]
* Navegar para "UrlBolsaoListarPage"
* Clicar no botão Criar
* Preencher os campos da tela Bolsao Vagas [13720] <table:resources/PermitirCodigoDeBolsaoDe1Ate1413720.csv>
Preencher o campo Codigo com o valor "15"
Preencher o campo Nome com o valor "Bolsão código invalido"
Preencher o campo Quantidade de Vagas com o valor "110"
Marcar o campo "true" quando lotado
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Código' deve ter um valor entre 1 e 14."

## Número de vagas deve ser no máximo 999999 [13723]
* Navegar para "UrlBolsaoListarPage"
* Clicar no botão Criar
* Preencher os campos da tela Bolsao Vagas [13723] <table:resources/NumeroDeVagasDeveSerNoMaximo99999913723.csv>
Preencher o campo Codigo com o valor "14"
Preencher o campo Nome com o valor "Teste números de vagas"
Preencher o campo Quantidade de Vagas maior que permitido com o valor "0"
Marcar o campo "false" quando lotado
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Quantidade de vagas' deve ter um valor entre 1 e 999999."

## Validar campos obrigatórios da tela de bolsão de vagas [16270]
* Navegar para "UrlBolsaoListarPage"
* Clicar no botão Criar
* Clicar no botão Salvar
* Verificar mensagem de erro do campo "O campo 'Código' é obrigatório" 
* Verificar mensagem de erro do campo "O campo 'Nome' é obrigatório"
* Verificar mensagem de erro do campo "O campo 'Quantidade de vagas' é obrigatório"

## Validar se o código do Bolsão de vagas é único" [13719]
* ST - Criar um bolsão de vagas <table:resources/ValidarSeOCodigoDoBolsaoDeVagasEUnico13719.csv> [16266]
* Navegar para "UrlBolsaoListarPage"
* Clicar no botão Criar
* Preencher os campos da tela Bolsao Vagas [13719] <table:resources/ValidarSeOCodigoDoBolsaoDeVagasEUnico13719.csv>
Na seção Criar bolsão de vagas preencher o campo Codigo com o valor "1"
Na seção Criar bolsão de vagas preencher o campo Nome com o valor "Bolsão principal"
Na seção Criar bolsão de vagas preencher o campo Quantidade de vagas com o valor "100"
Na seção Criar bolsão de vagas marcar o checkbox Bloquear acesso quando lotado "true"
Na seção Criar bolsão de vagas marcar o checkbox Habilitar Controle de Vagas por Setor "true"
* Clicar no botão Salvar
* Validar mensagem "O Código informado já está sendo utilizado por outro bolsão."

## Alterar um bolsão de vagas [13709]
* ST - Criar um bolsão de vagas <table:resources/AlterarUmBolsaoDeVagas13709.csv> [16266]
* Clicar no menu de contexto (...) na linha contendo o valor "Bolsão para alterar" na tabela
* Clicar no botão Alterar na listagem
* Preencher os campos da tela Bolsao Vagas [13709] <table:resources/AlterarUmBolsaoDeVagas13709.csv>
Preencher o campo Nome com o valor "Bolsão alterado"
Preencher o campo Quantidade de vagas com o valor "200"
Marcar o checkbox Bloquear acesso quando lotado "false"
Marcar o checkbox Habilitar Controle de Vagas por Setor "false"
* Clicar no botão Salvar
* Verificar mensagem alteracao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Bolsão alterado" na tabela
* Clicar no botão Detalhar na listagem
* Verificar campos da tela Bolsao de Vagas <table:resources/AlterarUmBolsaoDeVagas13709.csv> [13709]

## Excluir um bolsão de vagas [13710]
* ST - Criar um bolsão de vagas <table:resources/ExcluirUmBolsaoDeVagas13710.csv> [16266]
* Clicar no menu de contexto (...) na linha contendo o valor "Bolsão para exclusão" na tabela
* Clicar no botão Excluir na listagem
* Clicar no botão Excluir
* Verificar mensagem exclusao com sucesso

## Criar um bolsão de vagas [13707]
* ST - Criar um bolsão de vagas <table:resources/CriarUmBolsaoDeVagas13707.csv> [16266]
* Verificar mensagem criacao com sucesso
* Clicar no menu de contexto (...) na linha contendo o valor "Bolsão principal" na tabela
* Clicar no botão Detalhar na listagem
* Verificar campos da tela Bolsao de Vagas <table:resources/CriarUmBolsaoDeVagas13707.csv> [13707]
