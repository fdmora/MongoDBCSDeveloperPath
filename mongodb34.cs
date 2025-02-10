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
