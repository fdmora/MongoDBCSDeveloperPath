db.transfers.getIndexes()

db.accounts.createIndex({ account_id: 1 }, { unique: true })

db.accounts.explain().find({ account_id: "MDB829000996" })