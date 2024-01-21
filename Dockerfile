# Use an official Microsoft SQL Server image as the base image
FROM mcr.microsoft.com/mssql/server:2019-latest

# Set the environment variables for SQL Server
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=magic

# Create a directory for SQL scripts
WORKDIR /usr/src/app

# Copy the folders with SQL scripts to the container
COPY ./sql-scripts/Tables /sql-scripts/Tables
COPY ./sql-scripts/View /sql-scripts/View
COPY ./sql-scripts/Stored_Procedures /sql-scripts/Stored_Procedures

# Run SQL Server setup scripts
WORKDIR /sql-scripts/Tables
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -i table.sql
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -i record.sql

WORKDIR /sql-scripts/View
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -i GetBookData.view.sql

WORKDIR /sql-scripts/Stored_Procedures
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -i CreateBook.sp.sql
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -i DeleteBook.sp.sql
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $SA_PASSWORD -i ModifyBook.sp.sql

# Expose the SQL Server port
EXPOSE 1433