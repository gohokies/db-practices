import pyodbc

conn = pyodbc.connect("Driver=ODBC Driver 17 for SQL Server;Server=localhost;Uid=sa;Pwd=SQLPassword!0;database=master")
cursor = conn.cursor()
cursor.execute("SELECT 'Hello World!' AS _message")

for row in cursor:
    print(row)

