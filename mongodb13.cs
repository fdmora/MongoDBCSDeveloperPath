--Match by Using C# Class
var matchStage = Builders<Accounts>.Filter.Lte(u => u.Balance, 1000);
var aggregate = accountsCollection.Aggregate()
                          .Match(matchStage);
var results = aggregate.ToList();

foreach (var account in results)
{
    Console.WriteLine(account.Balance);
}


--Match by Using BsonDocument
var matchStage = Builders<BsonDocument>.Filter.Lte("balance", 1000);
var aggregate = accountsCollection.Aggregate()
                          .Match(matchStage);
var results = aggregate.ToList();

foreach (var account in results)
{
    Console.WriteLine(account.Balance);
}


--Group Stage
var matchStage = Builders<BsonDocument>.Filter.Lte("balance", 1000);
var aggregate = accountCollection.Aggregate()
   .Match(matchStage)
   .Group(
       a => a.AccountType,
       r => new
       {
           accountType = r.Key,
           total = r.Sum(a => 1)
       }
   );

var results = aggregate.ToList();

foreach (var account in results)
{
    Console.WriteLine(account.Balance);
}