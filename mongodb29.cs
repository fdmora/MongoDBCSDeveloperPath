--Replacing a Document in MongoDB
db.books.replaceOne(
  {
    _id: ObjectId("6282afeb441a74a98dbbec4e"),
  },
  {
    title: "Data Science Fundamentals for Python and MongoDB",
    isbn: "1484235967",
    publishedDate: new Date("2018-5-10"),
    thumbnailUrl:
      "https://m.media-amazon.com/images/I/71opmUBc2wL._AC_UY218_.jpg",
    authors: ["David Paper"],
    categories: ["Data Science"],
  }
)

db.birds.replaceOne(
  { _id: ObjectId("6286809e2f3fa87b7d86dccd") },
  {
    common_name: "Morning Dove",
    scientific_name: "Zenaida macroura",
    wingspan_cm: 37.23,
    habitat: ["urban areas", "farms", "grassland"],
    diet: ["seeds"],
  }
)


{ _id: ObjectId("6286809e2f3fa87b7d86dccd") },
  {
    common_name: "Morning Dove",
    habitat: ["urban areas", "farms", "grassland"],
    diet: ["seeds"]
  }
