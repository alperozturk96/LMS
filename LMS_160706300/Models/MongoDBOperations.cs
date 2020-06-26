using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LMS_160706300.Models
{
    public class MongoDBOperations
    {
        //database > collection > document > fields

        private readonly IMongoDatabase mongoDatabase;

        public MongoDBOperations()
        {
            try
            {
                var client = new MongoClient();
                mongoDatabase = client.GetDatabase("LMS");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> SelectRecordsByToList<T>(string collection, int inputField, string column)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);
                var filter = Builders<T>.Filter.Eq(column, inputField);

                return col.Find(filter).ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<T> SelectRecordsByToList<T>(string collection, string inputField, string column)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);
                var filter = Builders<T>.Filter.Regex(column, inputField);

                return col.Find(filter).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Obsolete]
        public List<User> SelectSpecificUserRecords()
        {
            try
            {
                var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false");
                var server = client.GetServer();
                var database = server.GetDatabase("LMS");
                var users = database.GetCollection("Users");
                var user = users.FindAllAs<User>().SetFields(Fields.Include("Name", "Surname", "Age", "BorrowedBookCount").Exclude("_id")).ToList();

                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> SelectRecords<T>(string collection)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);
                return col.Find(new BsonDocument()).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public T SelectRecordsBy<T>(string collection, string inputField, string column)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);
                var filter = Builders<T>.Filter.Eq(column, inputField);

                return col.Find(filter).First();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public T SelectRecordsById<T>(string collection, BsonObjectId inputField, string column)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);
                var filter = Builders<T>.Filter.Eq(column, inputField);

                return col.Find(filter).First();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void DeleteRecord<T>(string collection, string inputField, string column)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);
                var filter = Builders<T>.Filter.Eq(column, inputField);
                col.DeleteOne(filter);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void InsertRecord<T>(string collection, T document)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);
                col.InsertOne(document);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [Obsolete]
        public void UpdateRecord<T>(string collection, BsonObjectId id, T record)
        {
            try
            {
                var col = mongoDatabase.GetCollection<T>(collection);

                var result = col.ReplaceOne(
                    new BsonDocument("_id", id),
                    record,
                    new UpdateOptions { IsUpsert = true });
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
