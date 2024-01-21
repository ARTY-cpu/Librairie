# Use an official Microsoft SQL Server image as the base image
FROM mcr.microsoft.com/mssql/server:2019-latest

# Set the environment variables for SQL Server
ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=Magixtime!To75

# Create a directory for SQL scripts
WORKDIR /usr/src/app

# Copy the folders with SQL scripts to the container
COPY ./sql-scripts/run-scripts.sh sql-scripts/
COPY ./sql-scripts sql-scripts

# Expose the SQL Server port
EXPOSE 1433

CMD [ "bash", "/usr/src/app/sql-scripts/entry-scripts.sh"]