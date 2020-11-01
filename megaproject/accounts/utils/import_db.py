import psycopg2
import pandas as pd
import csv

'''
cursor.execute("""create table catalog(
    id integer primary key,
    doc_id integer,
    author text,
    name text
)
"""
)
conn.commit()
'''

conn = psycopg2.connect(dbname='books', user='postgres', password='postgres', host='localhost')
cur = conn.cursor()

with open('/root/megaproject/accounts/data/catalog.csv', 'r') as f:
    reader = csv.reader(f)
    next(reader)
    for row in reader:
        cur.execute(
        "INSERT INTO catalog VALUES (%s, %s, %s, %s)",
        row
    )
conn.commit()