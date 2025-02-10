db.sales.find({ "items.price": { $gt: 200}})

db.sales.find({ "items.price": { $lt: 25}})

db.sales.find({ "items.quantity": { $gte: 10}})

db.sales.find({ "customer.age": { $lte: 45 } })

--Querying on Array Elements in MongoDB

db.accounts.find({ products: "InvestmentFund"})

--Find a Document by Using the $elemMatch Operator
db.sales.find({
  items: {
    $elemMatch: { name: "laptop", price: { $gt: 800 }, quantity: { $gte: 1 } },
  },
})

db.accounts.find({ products: "CurrencyService" })

--Create a query that matches all documents with a transactions sub document that contains an amount less than or equal to $4500 and a transaction_code of "sell" in the transactions collection. (Forgot the command? Check the hint below!)
Note

db.transactions.find({
    transactions: {
      $elemMatch: { amount: { $gte: 4500 }, transaction_code: "sell" },
    },
  })


db.books.find({ genre: "Historical" })
