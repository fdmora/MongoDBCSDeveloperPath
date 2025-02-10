db.routes.find({
  $and: [
    { $or: [{ dst_airport: "IST" }, { src_airport: "IST" }] },
    { $or: [{ stops: 0 }, { airline.name: "Turkish Airlines"}] },
  ]
})

CRUD 1 - Inserting and Finding Documents
In this unit, we learned how to insert and find documents in a collection with MongoDB. We also built queries with the following comparison operators:

$gt (Greater Than)

$lt (Less Than)

$lte ( Less Than or Equal To)

$gte (Greater Than or Equal To)

We also used the following logical operators:

$and

$or

Finally, we learned how to query elements in an array and how to use the $elemMatch operator.

Resources
Use the following resources to learn more about inserting and finding documents in MongoDB:

Lesson 1 - Inserting Documents
MongoDB Docs: insertOne()

MongoDB Docs: insertMany()

Lesson 2 - Finding Documents
MongoDB Docs: find()

MongoDB Docs: $in

Lesson 3 - Finding Documents Using Comparison Operators
MongoDB Docs: Comparison Operators
Lesson 4 - Querying on Array Elements
MongoDB Docs: $elemMatch

MongoDB Docs: Querying Arrays

Lesson 5 - Finding Documents Using Logical Operators
MongoDB Docs: Logical Operators
Associate Certification Course
Did you know that by completing this unit you've finished 30% of the CRUD content necessary for the Associate Developer Certification exam?

If you're interested in continuing, your next step would be:

Unit 05 - CRUD 2