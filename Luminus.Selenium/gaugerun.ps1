function Run-Test {
	Param (
			[string]$pathSelenium,
			[string]$pathAssociador,
			[string[]]$gaugeSpec,
			[string[]]$associadorArgs
		  )

cd $pathSelenium
Write-Host "#######################"
Write-Host "gauge run $gaugeSpec"
Write-Host "$pathAssociador $associadorArgs"
Write-Host "#######################"
Invoke-Expression "gauge run $gaugeSpec"
Invoke-Expression "$pathAssociador $associadorArgs"
}

cd $env:seleniumPath

if($env:executarEmParalelo -eq "true"){

	Write-Host "Execução dos testes em paralelo"

	$paraleloNumeroThreads = $env:paraleloNumeroThreads
	Write-Host "Número de threads: $paraleloNumeroThreads"

	if($paraleloNumeroThreads -eq ""){
		$argNumeroThreads = ""
	}
	else {
		$argNumeroThreads = "-n=$paraleloNumeroThreads"
	}

	Write-Host "Argumento número de threads: $argNumeroThreads"

	gauge run -e "parallel.phase1,default" `
	specs/Shared/Login/Login.spec `

	gauge run -p "$argNumeroThreads" -e "parallel.phase2,default" `
	specs/Seguranca/LicensaDeUso/LicencaDeUso.spec `
	specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema1.spec `
	specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema2.spec `
	specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema3.spec `
	specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema4.spec `
	specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema5.spec `
	specs/ConfiguracaoDoEstacionamento/BolsaoVagas/bolsaoVagas.spec `
	specs/ConfiguracaoDoEstacionamento/ParametrosGeraisDoEstacionamento `
	specs/InstalacoesAtualizacoes/AplicativosEVersoes/AplicativosEVersoes.spec `
	specs/Financeiro/TaxasCambiais/TaxasCambiais.spec `
	specs/ConfiguracaoDoEstacionamento/Estacionamento/Estacionamento.spec `
	specs/Financeiro/IntegracaoTef/IntegracaoTef.spec `
	specs/Operacao/TiposDeOcorrenciasNasEstadias/TiposDeOcorrenciasNasEstadias.spec `
	specs/Financeiro/EmitentesFiscais/EmitentesFiscais.spec `
	specs/Operacao/ClientesDoEstacionamento/ClientesDoEstacionamento.spec `
	specs/Financeiro/RegrasDeNumerarioDeAutoatendimento/RegrasDeNumerarioDeAutoatendimento.spec `
	specs/ProdutoDeEstadia/RegrasDeAcesso/RegrasDeAcesso.spec `
	specs/seguranca/UsuariosDoSistema/UsuariosDoSistema.spec `
	specs/ConfiguracaoDoEstacionamento/IntegracoesComOperadorasDeArrecadacao/IntegracoesComOperadorasDeArrecadacao.spec `
	specs/ConfiguracaoDoEstacionamento/ArquivoSeriaisMifare/ArquivoSeriaisMifare.spec `
	specs/ProdutoDeEstadia/RegrasDeCobranca/RegrasDeCobranca.spec `
	specs/ProdutoDeEstadia/EstruturaDeTabelaDeCobranca/EstruturasDeTabelasDeCobranca.spec `
	specs/Operacao/OperacaoDeMultiplasCancelas/OperacaoDeMultiplasCancelas.spec `
	specs/Operacao/OperacaoDeMultiplasCancelas/OperacaoDeMultiplasCancelas2.spec `
	specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia1.spec `
	specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia2.spec `
	specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia3.spec `
	specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia4.spec `
	specs/Operacao/ContratosDeEstadia/ContratosDeEstadiaDiaDoMes.spec `
	specs/Operacao/ContratosDeEstadia/ContratosDeEstadiaPrePago.spec `
	specs/Operacao/ContratosDeEstadia/ContratosDeEstadiaQuantidadeDeDias.spec `
	specs/Operacao/ContratosDeEstadia/ContratoDeEstadiaQueDependeDeEquipamento.spec `
	specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos1.spec `
	specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos2.spec `
	specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos3.spec `
	specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos4.spec `
	specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos5.spec `
	specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos6.spec `
	specs/Locadora/Contrato/Contrato.spec `
	specs/Locadora/FechamentoFatura/FechamentoFatura.spec `
	specs/Customizacao/Multimidia/Multimidia.spec `
	specs/Customizacao/ApresentacoesDeMultimidias/ApresentacoesDeMultimidias.spec 
	
}
else {

	Write-Host "Execução dos testes em série"

#Bloco de parâmetros para o associador de testes
$associadorArgs = @(
    "$env:testPlanId",
    "$env:buildId",
    "$env:releaseId",
    "$env:testRunName",
    "$env:System_DefaultWorkingDirectory\Luminus.Selenium\Luminus.Selenium\result\reports\xml-report",
    "$env:System_DefaultWorkingDirectory\Luminus.Selenium\Luminus.Selenium\result\prints",
    "$env:System_DefaultWorkingDirectory\Luminus.Selenium\Luminus.Selenium",
    "$env:artefactsPath",
    "mgwv5wnlbbmcpysauk4hl5gqoluv6nhhihyr4o2lq6ril4ghvbcq",
    "$env:organizacao",
    "nepos"
)

#path dos executaveis
$pathSelenium = "$env:System_DefaultWorkingDirectory\Luminus.Selenium\Luminus.Selenium"
$pathAssociador = "$env:System_DefaultWorkingDirectory\AssociadorTestResultTestCase.Console\AssociadorTestResultTestCase.Console.exe"


#Base
$associadorArgs[3]="Selenium.Gauge-Base"
$gaugeSpec = @(
	" -e ""synchronous.phase1,default"" ",
    "specs/Seguranca/LicensaDeUso/LicencaDeUso.spec",
    "specs/InstalacoesAtualizacoes/AplicativosEVersoes/AplicativosEVersoes.spec"	
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Configuração do estacionamento
$associadorArgs[3]="Selenium.Gauge-Configurações-do-estacionamento"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ConfiguracaoDoEstacionamento/BolsaoVagas/bolsaoVagas.spec",
	"specs/ConfiguracaoDoEstacionamento/ParametrosGeraisDoEstacionamento/ParametrosGeraisDoEstacionamento.spec",
	"specs/ConfiguracaoDoEstacionamento/Estacionamento/Estacionamento.spec",
	"specs/ConfiguracaoDoEstacionamento/IntegracoesComOperadorasDeArrecadacao/IntegracoesComOperadorasDeArrecadacao.spec",
	"specs/ConfiguracaoDoEstacionamento/ArquivoSeriaisMifare/ArquivoSeriaisMifare.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Perfil Acesso 1
$associadorArgs[3]="Selenium.Gauge-Perfil-Acesso-1"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema1.spec"
)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Perfil Acesso 2
$associadorArgs[3]="Selenium.Gauge-Perfil-Acesso-2"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Seguranca/PerfilDeAcessoDoSistema/PerfilDeAcessoDoSistema2.spec"
)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Segurança
$associadorArgs[3]="Selenium.Gauge-Segurança"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/seguranca/UsuariosDoSistema/UsuariosDoSistema.spec"
)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Financeiro
$associadorArgs[3]="Selenium.Gauge-Financeiro"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",	
	"specs/Financeiro/TaxasCambiais/TaxasCambiais.spec",
	"specs/Financeiro/IntegracaoTef/IntegracaoTef.spec",
	"specs/Financeiro/EmitentesFiscais/EmitentesFiscais.spec",
	"specs/Financeiro/RegrasDeNumerarioDeAutoatendimento/RegrasDeNumerarioDeAutoatendimento.spec"
)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Produto-Estadia 1
$associadorArgs[3]="Selenium.Gauge-Produto-Estadia-1"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ProdutoDeEstadia/RegrasDeAcesso/RegrasDeAcesso.spec",
	"specs/ProdutoDeEstadia/RegrasDeCobranca/RegrasDeCobranca.spec",
	"specs/ProdutoDeEstadia/EstruturaDeTabelaDeCobranca/EstruturasDeTabelasDeCobranca.spec"

)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Produto-Estadia 2
$associadorArgs[3]="Selenium.Gauge-Produto-Estadia-2"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia1.spec"

)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Produto-Estadia 3
$associadorArgs[3]="Selenium.Gauge-Produto-Estadia-3"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia2.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Produto-Estadia 4
$associadorArgs[3]="Selenium.Gauge-Produto-Estadia-4"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia3.spec"

)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Produto-Estadia 5
$associadorArgs[3]="Selenium.Gauge-Produto-Estadia-5"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ProdutoDeEstadia/ProdutoDeEstadia/ProdutoDeEstadia4.spec"

)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Operação
$associadorArgs[3]="Selenium.Gauge-Operação"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Operacao/TiposDeOcorrenciasNasEstadias/TiposDeOcorrenciasNasEstadias.spec",
	"specs/Operacao/ClientesDoEstacionamento/ClientesDoEstacionamento.spec",
	"specs/Operacao/OperacaoDeMultiplasCancelas/OperacaoDeMultiplasCancelas.spec"

)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Contrato Estadia 1
$associadorArgs[3]="Selenium.Gauge-Contrato-Estadia-1"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Operacao/ContratosDeEstadia/ContratosDeEstadiaDiaDoMes.spec"

)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Contrato Estadia 2
$associadorArgs[3]="Selenium.Gauge-Contrato-Estadia-2"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Operacao/ContratosDeEstadia/ContratosDeEstadiaQuantidadeDeDias.spec"

)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Contrato Estadia 3
$associadorArgs[3]="Selenium.Gauge-Contrato-Estadia-3"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Operacao/ContratosDeEstadia/ContratosDeEstadiaPrePago.spec"

)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Contrato Estadia 4
$associadorArgs[3]="Selenium.Gauge-Contrato-Estadia-4"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Operacao/ContratosDeEstadia/ContratoDeEstadiaQueDependeDeEquipamento.spec"

)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Customizacao
$associadorArgs[3]="Selenium.Gauge-Multimidia"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Customizacao/ApresentacoesDeMultimidias/ApresentacoesDeMultimidias.spec",
	"specs/Customizacao/Multimidia/Multimidia.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Locadora
$associadorArgs[3]="Selenium.Gauge-Locadora"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/Locadora/Contrato/Contrato.spec",
	"specs/Locadora/FechamentoFatura/FechamentoFatura.spec"

)

Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Equipamentos 1
$associadorArgs[3]="Selenium.Gauge-Equipamentos-1"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos1.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Equipamentos 2
$associadorArgs[3]="Selenium.Gauge-Equipamentos-2"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos2.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Equipamentos 3
$associadorArgs[3]="Selenium.Gauge-Equipamentos-3"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos3.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Equipamentos 4
$associadorArgs[3]="Selenium.Gauge-Equipamentos-4"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos4.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Equipamentos 5
$associadorArgs[3]="Selenium.Gauge-Equipamentos-5"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos5.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

#Equipamentos 6
$associadorArgs[3]="Selenium.Gauge-Equipamentos-6"
$gaugeSpec = @(
	" -e ""synchronous,default"" ",
	"specs/ConfiguracaoDoEstacionamento/Equipamentos/Equipamentos6.spec"
)
Run-Test -pathSelenium $pathSelenium -pathAssociador $pathAssociador -gaugeSpec $gaugeSpec -associadorArgs $associadorArgs

}

$data = [datetime]::Now.ToString('yyyy-MM-dd HH:mm:ss')
Write-Host "##vso[task.setvariable variable=dataFimExecucaoTestes]$data"