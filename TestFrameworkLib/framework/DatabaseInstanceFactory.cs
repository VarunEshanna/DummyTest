using MongoDB.Driver;
using System;
using System.Security.Authentication;
using TestFrameworkLib.utility;

namespace TestFrameworkLib.framework
{
    public class DatabaseInstanceFactory
    {

        public static MongoDatabase getMongoDBConnection(String databaseInstance)
        {
            MongoDatabase database = null;
            if (TestConstants.DATABASE_INSTANCE.Equals("ADOBE"))
            {
                String connectionString = "mongodb://SLTESTFW:pA_r3MP1023@sapote-b:27021/SLTESTFW?connect=replicaSet";
                MongoClient client = new MongoClient(connectionString);
                MongoServer server = client.GetServer();
                database = server.GetDatabase("SLTESTFW");
            }
            else if (TestConstants.DATABASE_INSTANCE.Equals("AZURE"))
            {
                String connectionString = @"mongodb://adobetestframework:wquhDXAF0zYe6uTUHSRBY560DdVAO2z3clvewixkT0ccwnOoCzVQfm2k3mEbEfhnTnlWvVbiOGV8WgJObg3kDw==@adobetestframework.documents.azure.com:10255/testframework?ssl=true&replicaSet=globaldb";
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
                settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
                MongoClient mongoClient = new MongoClient(settings);
                MongoServer server = mongoClient.GetServer();
                database = server.GetDatabase("testframework");
            }
            return database;
        }

    }
}
