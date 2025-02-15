using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using mongodb_classes.Models;

BsonSerializer.RegisterSerializer(new DecimalSerializer(BsonType.Decimal128));

DotNetEnv.Env.TraversePath().Load();
var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
var settings = MongoClientSettings.FromConnectionString(connectionString);
var client = new MongoClient(settings);
var database = client.GetDatabase("bank");
var accountsCollection = database.GetCollection<Account>("accounts");
var transfersCollection = database.GetCollection<Transfer>("transfers");

// TODO: Create a new variable named `filter`below:
var filter = Builders<Account>
   .Filter
   .Gt("balance", 4700);

// TODO: Create a new variable named `documents`below:
var documents = accountsCollection
   .Find(filter).ToList();

foreach (Account doc in documents)
{
    Console.WriteLine(doc.Balance.ToString());
}
