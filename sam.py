import sqlite3
import pandas as pd

#ADD Path to SQLite File
conn = sqlite3.connect('C:\\Users\\Dell\\vscode\\contactclient\\contactsql.db')

#selected table in datafram
client_id = 1  # replace with the desired client ID (1 - 6)
df = pd.read_sql_query(f"SELECT * FROM sysdateprice WHERE clientID = {client_id}", conn)

# calculate time weighted return from the table
df['return'] = df['fundprice'].pct_change()
df['return'].fillna(0, inplace=True)
df['return'] = df['return'] + 1
df['treturn'] = df['return'].cumprod()
print(df)

IC_Holding = df['IC_holding'].iloc[-1]
print(IC_Holding)

# selected table in datafram table fundprice mostrecent result
df_marketvalue = pd.read_sql_query("SELECT pricedate, fundprice FROM fundprice ORDER BY pricedate DESC LIMIT 1", conn)
print(df_marketvalue)

market_price = df_marketvalue['fundprice'].iloc[-1]
market_date = df_marketvalue['pricedate'].iloc[-1]
market_value = market_price * IC_Holding

df['pricedate'] = pd.to_datetime(df['pricedate'])
df_marketvalue['pricedate'] = pd.to_datetime(df_marketvalue['pricedate'])
tenor = (df_marketvalue['pricedate'].max() - df['pricedate'].min()).days
annualized_return = (((market_value / df['Market_Value'].iloc[-1]) * df['treturn'].iloc[-1]) -1) *(365/tenor)

print("Days of Investment: " + str(tenor))
print("IC Holding: " + str(IC_Holding))
print("Annualized Return is: " + str(round(annualized_return * 100, 2)) + " %")


#API for front end
from flask import Flask
from flask_restful import Resource, Api

app = Flask(__name__)
api = Api(app)

class ReturnResource(Resource):
    def get(self):
        return {
            'Days of Investment': int(tenor),
            'IC Holding': int(IC_Holding),
            'annualized_return': round(annualized_return * 100, 2)
        }

api.add_resource(ReturnResource, '/')

if __name__ == '__main__':
    app.run(debug=True)