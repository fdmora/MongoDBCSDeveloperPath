--Finding Documents by Using Logical Operators

db.routes.find({ "airline.name": "Southwest Airlines", stops: { $gte: 1 } })
Find a Document by Using the $or Operator
Use the $or operator to select documents that match at least one of the included expressions. For example:

db.routes.find({
  $or: [{ dst_airport: "SEA" }, { src_airport: "SEA" }],
})
Find a Document by Using the $and Operator
Use the $and operator to use multiple $or expressions in your query.

db.routes.find({
  $and: [
    { $or: [{ dst_airport: "SEA" }, { src_airport: "SEA" }] },
    { $or: [{ "airline.name": "American Airlines" }, { airplane: 320 }] },
  ]
})


db.sales.sales({
  $and: [
   {$or {}}
  ]
  })

db.sales.find({
  couponUsed: true,
  purchaseMethod: "Online",
  "customer.age": {$lte: 25}}
)


db.sales.find({
  $or: [
  {"items.name": "pens"}, {"items.tags": "writing"}
  ],
})

db.sales.find({
  $or: [{ "items.name": "pens" }, { "items.tags": "writing" }],
})



db.sales.find({ couponUsed: true,  purchaseMethod: "Online", "customer.age": { $lte: 25 } })


db.sales.find()

  {
    _id: ObjectId('5bd761dcae323e45a93ccffe'),
    saleDate: ISODate('2013-03-20T16:36:39.112Z'),
    items: [
      {
        name: 'notepad',
        tags: [ 'office', 'writing', 'school' ],
        price: Decimal128('25.83'),
        quantity: 5
      },
      {
        name: 'printer paper',
        tags: [ 'office', 'stationary' ],
        price: Decimal128('14.6'),
        quantity: 2
      },
      {
        name: 'pens',
        tags: [ 'writing', 'office', 'school', 'stationary' ],
        price: Decimal128('7.49'),
        quantity: 1
      },
      {
        name: 'backpack',
        tags: [ 'school', 'travel', 'kids' ],
        price: Decimal128('149.09'),
        quantity: 4
      },
      {
        name: 'laptop',
        tags: [ 'electronics', 'school', 'office' ],
        price: Decimal128('898.84'),
        quantity: 1
      },
      {
        name: 'binder',
        tags: [ 'school', 'general', 'organization' ],
        price: Decimal128('21.01'),
        quantity: 2
      },
      {
        name: 'notepad',
        tags: [ 'office', 'writing', 'school' ],
        price: Decimal128('21.06'),
        quantity: 4
      },
      {
        name: 'envelopes',
        tags: [ 'stationary', 'office', 'general' ],
        price: Decimal128('21.48'),
        quantity: 8
      },
      {
        name: 'notepad',
        tags: [ 'office', 'writing', 'school' ],
        price: Decimal128('39.38'),
        quantity: 3
      },
      {
        name: 'binder',
        tags: [ 'school', 'general', 'organization' ],
        price: Decimal128('13.07'),
        quantity: 4
      }
    ],
    storeLocation: 'San Diego',
    customer: {
      gender: 'M',
      age: 61,
      email: 'ucikosusu@sid.uz',
      satisfaction: 1
    },
    couponUsed: false,
    purchaseMethod: 'Online'
  },


