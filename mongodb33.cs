Three computer science classes, 
with the class_ids of 377, 259, and 350, 
have earned 100 extra credit points by competing in a hackathon. 

You need to update the database so that 
all students who are in these classes receive extra credit points. 
Note that you will use the grades collection, 
which is in the sample_training database.

db.grades.updateMany(
  {
    class_id: {
$in: [ 377, 259, 350 ]
    },
   },
  {
    $push: {
      scores: [ 
{ type : 'extra credit', score: 100 }
]
    }
  }
)


