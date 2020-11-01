import pandas as pd
from sklearn.neighbors import NearestNeighbors
import psycopg2


def recommend(name, k):
    processed_orders = pd.read_csv('/root/megaproject/accounts/data/processed_orders.csv')
    processed_orders = processed_orders.drop(columns='Unnamed: 0')

    '''
    valuable_books = processed_orders.groupby('book_id').count()[processed_orders.groupby('book_id').count()['user_id'] > 10].index.values
    valuable_orders = processed_orders[processed_orders['book_id'].isin(valuable_books)].drop(columns='Unnamed: 0')
    '''

    model_knn = NearestNeighbors(metric='cosine', algorithm='brute', n_neighbors=k, n_jobs=-1)
    model_knn.fit(processed_orders)

    conn = psycopg2.connect(dbname='books', user='postgres', password='postgres', host='localhost')
    cur = conn.cursor()

    cur.execute('select doc_id from catalog where name = {}'.format("'" + name + "'"))

    records = cur.fetchall()
    bid = records[0][0]

    indices = model_knn.kneighbors([[processed_orders.shape[0], bid, 1]], k*3, return_distance=False)
    indices = indices[0]

    response = {'names': [], 'authors': []}
 
    for i in indices:
        cur.execute('select name, author from catalog where doc_id = {}'.format(i))
        recs = cur.fetchall()
        for rec in recs:
            if len(rec) > 0:
                response['names'].append(rec[0])
                response['authors'].append(rec[1])
        if len(response['names']) == k:
            break

    return response

