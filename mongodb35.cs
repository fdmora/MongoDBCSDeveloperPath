--Deleting Documents in MongoDB
--To delete documents, use the deleteOne() or deleteMany() methods. Both methods accept a filter --document and an options object.

--Delete One Document
The following code shows an example of the deleteOne() method:

db.podcasts.deleteOne({ _id: Objectid("6282c9862acb966e76bbf20a") })

--Delete Many Documents
The following code shows an example of the deleteMany() method:

db.podcasts.deleteMany({category: “crime”})


db.birds.deleteOne({ _id: ObjectId("62cddf53c1d62bc45439bebf") })

db.birds.deleteMany({ sightings_count: { $lte: 10 } })