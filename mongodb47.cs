// create a compound index using the `account_holder`, `balance` and `account_type` fields:
db.accounts.createIndex({
  account_holder: 1,
  balance: 1,
  account_type: 1
})

// Use the explain method to view the winning plan for a query
db.accounts.explain().find(
  { account_holder: "Andrea", balance: { $gt: 5 } },
  { account_holder: 1, balance: 1, account_type: 1, _id: 0 }
).sort({ balance: 1 });