SQL_SERVER="localhost"
SQL_USERNAME="sa"
SQL_PASSWORD="Magixtime!To75"
SQL_QUERY="SELECT 1"

# Function to check if SQL Server is up
check_sql_server() {
    echo "Checking SQL Server status..."
    /opt/mssql-tools/bin/sqlcmd -S $SQL_SERVER -U $SQL_USERNAME -P $SQL_PASSWORD -Q "$SQL_QUERY" > /dev/null 2>&1
    return $?
}

# Wait for SQL Server to be up
while ! check_sql_server; do
    echo "SQL Server is not yet available. Waiting..."
    sleep 1
done

/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Magixtime!To75 -d master -i sql-scripts/Tables/table.sql
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Magixtime!To75 -d master -i sql-scripts/Tables/record.sql
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Magixtime!To75 -d master -i sql-scripts/View/GetBookData.view.sql
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Magixtime!To75 -d master -i sql-scripts/Stored_Procedures/CreateBook.sp.sql
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Magixtime!To75 -d master -i sql-scripts/Stored_Procedures/DeleteBook.sp.sql
/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P Magixtime!To75 -d master -i sql-scripts/Stored_Procedures/UpdateBook.sp.sql