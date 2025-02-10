db.birds.updateMany(
  {
    common_name: {
      $in: ["Blue Jay", "Grackle"],
    },
  },
  {
    $set: {
      last_seen: ISODate("2022-01-01"),
    },
  }
)