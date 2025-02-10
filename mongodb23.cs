--Find a Document with Equality
db.zips.find({ _id: ObjectId("5c8eccc1caa187d17ca6ed16") })
db.sales.find({ _id: ObjectId("5bd761dcae323e45a93ccff4")})


--Find a Document by Using the $in Operator
db.zips.find({ city: { $in: ["PHOENIX", "CHICAGO"] } })

db.zips.find({ storeLocation: { $in: ["London", "New York"] } })


db.zips.find({ storeLocation: { $in: ["London", "New York"] } })