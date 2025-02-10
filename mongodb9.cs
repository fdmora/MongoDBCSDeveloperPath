--Delete a Single Document

var accountsCollection = 
  database.GetCollection<Account>("Account");

var result  = accountsCollection
   .DeleteOne(a => a.AccountId == "MDB333829449");

Console.WriteLine(result.DeletedCount);


---Delete a Single Document Asynchronously

var filter = Builders<BsonDocument>
   .Filter
   .Eq("_id", new    
      ObjectId("63050518546c1e9d2d16ce4d"));

var accounts = await accountsCollection
   .DeleteOneAsync(filter);

--Delete Multiple Documents
var deleteResult = accountCollection
   .DeleteMany(a => a.Balance < 500);

Console.WriteLine(result.DeleteCount)


--Delete Multiple Documents Asynchronously
var filter = Builders<BsonDocument>
   .Filter
   .Eq("account_type", "checking");

var deleteResult = await accountsCollection
   .DeleteManyAsync(filter);

Console.WriteLine(deleteResult.DeletedCount);