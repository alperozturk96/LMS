using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LMS_160706300.Models
{
    public class Book
    {
        [BsonId]
        public BsonObjectId BookID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string ISBN { get; set; }

        public int Year { get; set; }

        public string Edition { get; set; }

        public int BorrowedCount { get; set; }

        public int Quantity { get; set; }
    }
}
