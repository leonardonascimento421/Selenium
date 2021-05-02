# Licença de uso [17175]
Criado pelo gerador 11/11/2019 16:43:38

## O Carregar licença de uso [17176]
* ST - Carregar licença de uso <table:resources/CarregarLicencaDeUso17176.csv> [17559]
* Navegar para "UrlLicencaListarPage"
* Clicar no botão Detalhar na listagem
* Clicar no botão Voltar

## O Carregar uma licença já existente no sistema [17177]
* ST - Carregar licença de uso <table:resources/CarregarUmaLicencaJaExistenteNoSistema17177.csv> [17559]
* Navegar para "UrlLicencaListarPage"
* Clicar no botão carregar da tela de consultar licença de uso
* Clicar no arquivo com o nome de <table:resources/CarregarUmaLicencaJaExistenteNoSistema17177.csv> e clicar no botão Abrir Licenca
* Clicar no botão carregar da tela de carregar licença de uso 
* Validar mensagem "Licença de uso já instalada neste estacionamento"

## O Validar se a licença é valida [17560]
* Navegar para "UrlLicencaListarPage"
* Clicar no botão carregar da tela de consultar licença de uso
* Clicar no botão carregar da tela de carregar licença de uso
* Validar mensagem "A licença informada é inválida"

## Validar quantidade de equipamentos [17574]
* ST - Carregar licença de uso <table:resources/ValidarQuantidadeDeEquipamentos17574.csv> [17559]
* ST - Criar um equipamento validação (Informatizado) <table:resources/ValidarQuantidadeDeEquipamentos17574.csv> [17616]
* Clicar no botão Criar
* Preencher os campos da tela <table:resources/ValidarQuantidadeDeEquipamentos17574.csv> [EquipamentosPageStep2]
Na seção Informações gerais  preencher o campo Número do equipamento com o valor "2"
Na seção Informações gerais  preencher o campo Nome com o valor "Validação Informatizada 2"
Na seção Operação geral no combobox Aplicativo do equipamento selecionar a opção "Informatizado"
Na seção Configurações de suporte marcar o checkbox Mostrar detalhes de espera após tecla acionada com o valor "true"
Na seção Configurações de suporte marcar o checkbox Alternar entre mensagem e detalhes de espera com o valor "true"
Na seção Configurações de suporte preencher o campo Tempo para mostrar detalhes de erro (seg) com o valor "5"
Na seção Configurações de suporte preencher o campo Tempo para mostrar detalhes de espera (seg) com o valor "8"
* Clicar no botão Salvar
* Validar mensagem "Excedida a quantidade de equipamentos licenciados para o aplicativo Informatizado"
* ST - Carregar licença de uso <table:resources/TrocarLicencaDeUso.csv> [17559]






