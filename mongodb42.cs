Using $project, $count, and $set Stages in a MongoDB Aggregation Pipeline
Review the following sections, which show the code for the $project, $set, and $count aggregation stages.

$project
The $project stage specifies the fields of the output documents. 1 means that the field should be included, and 0 means that the field should be supressed. The field can also be assigned a new value.

{
    $project: {
        state:1, 
        zip:1,
        population:"$pop",
        _id:0
    }
}
$set
The $set stage creates new fields or changes the value of existing fields, and then outputs the documents with the new fields.

{
    $set: {
        place: {
            $concat:["$city",",","$state"]
        },
        pop:10000
     }
  }
$count
The $count stage creates a new document, with the number of documents at that stage in the aggregation pipeline assigned to the specified field name.

{
  $count: "total_zips"
}


db.sightings.aggregate([
  {
    $project: {
        _id: 0,
        species_common: 1,
        date: 1
    }
  }
])


db.birds.aggregate([
  {
    $set: {
      'class': 'bird'
    }
  }
])

db.sightings.aggregate([
{
  $match: {
    date: {
      $gt: ISODate('2022-01-01T00:00:00.000Z'),
      $lt: ISODate('2023-01-01T00:00:00.000Z')
    },
    species_common: 'Eastern Bluebird'
  }
}, {
  $count: 'bluebird_sightings_2022'
}
])