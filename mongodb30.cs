--Updating MongoDB Documents by Using updateOne()
The updateOne() method accepts a filter document, an update document, and an optional options object. MongoDB provides update operators and options to help you update documents. In this section, we'll cover three of them: $set, upsert, and $push.

$set
The $set operator replaces the value of a field with the specified value, as shown in the following code:

db.podcasts.updateOne(
  {
    _id: ObjectId("5e8f8f8f8f8f8f8f8f8f8f8"),
  },

  {
    $set: {
      subscribers: 98562,
    },
  }
)

--upsert
The upsert option creates a new document if no documents match the filtered criteria. Here's an example:

db.podcasts.updateOne(
  { title: "The Developer Hub" },
  { $set: { topics: ["databases", "MongoDB"] } },
  { upsert: true }
)


--$push
The $push operator adds a new value to the hosts array field. Here's an example:

db.podcasts.updateOne(
  { _id: ObjectId("5e8f8f8f8f8f8f8f8f8f8f8") },
  { $push: { hosts: "Nic Raboy" } }
)


db.birds.findOne({_id: ObjectId("6268413c613e55b82d7065d2")})

{
  _id: ObjectId('6268413c613e55b82d7065d2'),
  common_name: 'Canada Goose',
  scientific_name: 'Branta canadensis',
  wingspan_cm: 152.4,
  habitat: 'wetlands',
  diet: [ 'grass', 'algae' ],
  last_seen: ISODate('2022-05-19T20:20:44.083Z')
}




db.birds.updateOne(
  {
    common_name: "Canada Goose",
  },
  {
    $set: {
      tags: ["geese", "herbivore", "migration"],
    },
  }
)


db.birds.updateOne(
 {
    _id: ObjectId("6268471e613e55b82d7065d7"),
  },
  {
    $set: {
      diet: ["newts", "opossum", "skunks", "squirrels"],
    },
  }
  )


db.birds.updateOne(
  {
   common_name: "Robin Redbreast",
  },
  { 
      $inc: { "sightings" : 1, 
      },
      $set : {
      last_updated: new Date(),
      },
  },
    { 
      upsert: true,
  }
)


db.birds.updateOne(
  {
    common_name: "Robin Redbreast",
  },
  {
      $inc: {"sightings": 1,
      },
    $set: {
      last_updated: new Date(),
    },
  },
  {
    upsert: true,
  }
)
