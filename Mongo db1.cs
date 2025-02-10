Mongo db
fdmora, kMwmI69OfUea3yx4

using MongoDB.Driver;

var mongoURL = new MongoUrl("<your connection string>");
var client = new MongoClient(mongoURL);

var dbList = client.ListDatabases().ToList();

Console.WriteLine("The list of databases on this server is: ");
foreach (var db in dbList)
{
    Console.WriteLine(db);
}

mongodb+srv://fdmora:kMwmI69OfUea3yx4@cluster0.sju8s.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0


var accountsCollection = database.GetCollection<Account>("account");

var accountsCollection = database.GetCollection<Account>("account");

var newAccount = new Account
{
    AccountId = "MDB829001337",
    AccountHolder = "Linus Torvalds",
    AccountType = "checking",
    Balance = 50352434
};

accountsCollection.InsertOne(newAccount);

var accountsCollection = database.GetCollection<BsonDocument>("account");

var document = new BsonDocument
{
   { "account_id", "MDB829001337" },
   { "account_holder", "Linus Torvalds" },
   { "account_type", "checking" },
   { "balance", 50352434 }
};

accountsCollection.InsertOne(document);


public async Task AddAccount()
{
   var newAccount = new Account
   {
       AccountId = "MDB829001337",
       AccountHolder = "Linus Torvalds",
       AccountType = "checking",
       Balance = 50352434
   };

   await accountsCollection.InsertOneAsync(document);
}


var accountsCollection = database.GetCollection<Account>("accounts");

var accountA = new Account
{
    AccountId = "MDB829001337",
    AccountHolder = "Linus Torvalds",
    AccountType = "checking",
    Balance = 50352434
};

var accountB = new Account
{
    AccountId = "MDB011235813",
    AccountHolder = "Ada Lovelace",
    AccountType = "checking",
    Balance = 60218
};

accountsCollection.InsertMany(new List<Account>() { accountA, accountB });


var accountsCollection = database.GetCollection<BsonDocument>("account");

var documents = new[]
{
    new BsonDocument
            {
                { "account_id", "MDB011235813" },
                { "account_holder", "Ada Lovelace" },
                { "account_type", "checking" },
                { "balance", 60218 }
            },
    new BsonDocument
            {
                { "account_id", "MDB829000001" },
                { "account_holder", "Muhammad ibn Musa al-Khwarizmi" },
                { "account_type", "savings" },
                { "balance", 267914296 }
            }
};

accountsCollection.InsertMany(documents);


public async Task AddAccounts()
{
   var accountA = new Account
{
    AccountId = "MDB829001337",
    AccountHolder = "Linus Torvalds",
    AccountType = "checking",
    Balance = 50352434
};

var accountB = new Account
{
    AccountId = "MDB011235813",
    AccountHolder = "Ada Lovelace",
    AccountType = "checking",
    Balance = 60218
};

   await accountsCollection.InsertManyAsync(new List<Account>() { accountA, accountB });

}