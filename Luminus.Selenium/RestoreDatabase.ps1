$env:backup='C:\LuminusBackup\Luminus'
Invoke-Sqlcmd -Username sa -Password spnsw2002 -InputFile c:\Selenium\RestoreDatabase.sql