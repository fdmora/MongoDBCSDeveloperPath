// create a multikey index on the `transfers_complete` field:
db.accounts.createIndex({ transfers_complete: 1 })

// use the explain followed by the find method to view the winningPlan for a query that finds a specific `completed_transfers` array element
db.accounts.explain().find({ transfers_complete: { $in: ["TR617907396"] } })