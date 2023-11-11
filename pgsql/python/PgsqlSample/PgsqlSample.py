import psycopg2

conn = psycopg2.connect(database="postgres",
                        host="localhost",
                        user="postgres",
                        password="SQLPassword",
                        port="5432")

cursor = conn.cursor()
cursor.execute("SELECT 'Hello World!' AS _message")

for row in cursor:
    print(row)

