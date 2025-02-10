--Find a Document with FirstOrDefault
var account = accountsCollection
   .Find(a => a.AccountId == "MDB829001337")
   .FirstOrDefault();

--Find a Document with FindAsync and FirstOrDefault

var accounts = await accountsCollection
   .FindAsync(a => a.AccountId == "MDB829001337");

var account = accounts.FirstOrDefault();

--Find a Document with ToList
var accounts = accountsCollection.Find(_ => true).ToList();

--Find a Document with Multiple LINQ Methods
accountsCollection
   .Find(a => a.AccountType == "checking")
   .SortByDescending(a => a.Balance)
   .Skip(5)
   .Limit(20);

--Find a Document with the Builders Class
var filter = Builders<BsonDocument>
   .Filter
   .Eq("_id", new    
      ObjectId("62d6e04ecab6d8e1304974ae"));

var document = accountsCollection
   .Find(filter)
   .FirstOrDefault();

var filter = Builders<BsonDocument>
   .Filter
   .Gt("balance", 1000);

var documents = await accountsCollection
   .FindAsync(filter);