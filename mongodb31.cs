--Updating MongoDB Documents by Using findAndModify()
The findAndModify() method is used to find and replace a single document in MongoDB. It accepts a filter document, a replacement document, and an optional options object. The following code shows an example:

db.podcasts.findAndModify({
  query: { _id: ObjectId("6261a92dfee1ff300dc80bf1") },
  update: { $inc: { subscribers: 1 } },
  new: true,
})

db.birds.findAndModify({
  query: { "common_name": "Blue Jay"},
  update: { $inc: { sightings_count : 1 } },
  new: true,
})

db.birds.findAndModify({
  query: { common_name: "Blue Jay" },
  update: { $inc: { sightings_count: 1 }},
  new: true,
})