import mysql.connector

conn = mysql.connector.connect(user='tiger', password='SQLPassword',
                              host='localhost',
                              database='myapp')
cursor = conn.cursor()
cursor.execute("SELECT 'Hello World!' AS _message")

for row in cursor:
    print(row)

conn.close()