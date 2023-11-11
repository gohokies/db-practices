
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=SQLPassword!0" -p 1433:1433 --name mssql1 --hostname sql1 -it --rm  mcr.microsoft.com/mssql/server:2022-latest