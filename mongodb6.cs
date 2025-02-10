---Update a Single Document
var filter = Builders<Account>
   .Filter
   .Eq(a => a.AccountId, "MDB951086017");

var update = Builders<Account>
   .Update
   .Set(a=>a.Balance, 5000);

var result = accountCollection.UpdateOne(filter, update);

Console.WriteLine(result.ModifiedCount);
----------------

---Update a Single Document Asynchronously
var result = await accountsCollection.UpdateOneAsync(filter, update);

Console.WriteLine(result.ModifiedCount);
-------------------------------------


--Update Multiple Documents
var filter = Builders<Account>
   .Filter
   .Eq(a => a.AccountType, "checking");

var update = Builders<Account>
   .Update
   .Inc(a => a.Balance, 5);

var updateResult = accountCollection
   .UpdateMany(filter, update);

Console.WriteLine(updateResult.ModifiedCount);
---------------------------------


--Update Multiple Documents Asynchronously
var filter = Builders<BsonDocument>
   .Filter
   .Lt("balance", 500);

var update = Builders<BsonDocument>
   .Update
   .Inc("balance", 10);

var result = await accountsCollection
   .UpdateManyAsync(filter, update);

Console.WriteLine(result.ModifiedCount);
