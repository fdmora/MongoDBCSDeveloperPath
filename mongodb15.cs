--Sort Stage

var matchBalanceStage = Builders<Accounts>.Filter.Lt(user => user.Balance, 1500);

var aggregate = accountsCollection.Aggregate()                        
                    .Match(matchBalanceStage)
                    .SortByDescending(u => u.Balance):

var results = aggregate.ToList();

foreach (var account in results)
{
    Console.WriteLine(account.Balance);
}

--Sort by Using BsonDocument
var matchBalanceStage = Builders<BsonDocument>.Filter.Lt("balance", 1500);
var sort = Builders<BsonDocument>.Sort.Descending("balance");

var aggregate = accountsCollection.Aggregate()
                        .Match(matchBalanceStage)
                        .Sort(sort);
var results = aggregate.ToList();

foreach (var account in results)
{
    Console.WriteLine(account.ToString());
}


---Project Stage
ar matchBalanceStage = Builders<Accounts>.Filter.Lt(user => user.Balance, 1500);
var projectStage = Builders<Accounts>.Projection.Expression(u =>
    new
    {
        AccountId = u.AccountId,
        AccountType = u.AccountType,
        Balance = u.Balance,
        GBP = u.Balance / 1.30M
    });

var aggregate = accountsCollection.Aggregate()
                        .Match(matchBalanceStage)
                        .SortByDescending(u => u.Balance)
                        .Project(projectStage);

var results = aggregate.ToList();

foreach (var account in results)
{
    Console.WriteLine(account.Balance);
}

