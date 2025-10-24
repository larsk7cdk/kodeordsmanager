# Kodeordsmanager


## Docker

For at oprette/starte SQL Server med Docker, bruges følgende kommando:

```bash
    docker run -d -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=P@ssword2025' -p 1433:1433 --name db_kodeordsmanager -v sql_data:/var/opt/mssql mcr.microsoft.com/mssql/server:2022-latest
```