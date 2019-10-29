using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Linq;


namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // (this will not auto-discover the primary even if it's a member of a replica set)
            var client = new MongoClient();
            var databse = client.GetDatabase("udemy"); //veritabanı ismimiz
            var collection = databse.GetCollection<object>("deneme"); //tablo ismimiz

            #region insertOne
            //insert one

            // var ekle = new  {_id= "ObjectId('"+ ObjectId.GenerateNewId().ToString() + "')", ad="Muki",soyad="baytar",not= new List<object>() { "tuba saday baytarın","kaydı","başarıyla","yapıldı"}};
            // collection.InsertOne(ekle);

            #endregion

            #region insertMany
            //insertmany

            //var document = new 
            //{
            //    ProductName = "JBL T150A",
            //    Price = "11.5",
            //    MadeIn = "japan"
            //};
            //var document2 = new 
            //{
            //    ProductName = "WH-208",
            //    Price = "9.20",
            //    MadeIn = "China"
            //};
            //List<object> objl = new List<object>();
            //objl.Add(document);
            //objl.Add(document2);

            //collection.InsertManyAsync(objl);
            #endregion

            #region updateOne
            //update one
            // var filter = Builders<object>.Filter.Eq("ad", "Muki");
            // var update = Builders<object>.Update.Set("ad", "Mukitttooo");
            // collection.UpdateOneAsync(filter, update);
            #endregion

            #region updateMany
            //update many
            // var filter = Builders<object>.Filter.Eq("ad", "Tuba");
            // var update = Builders<object>.Update.Set("ad", "Mukiş");
            // collection.UpdateMany(filter, update);

            #endregion

            #region deleteOne
            // delete one
            // var delete = Builders<object>.Filter.Eq("ad", "Bobo");
            // collection.DeleteOne(delete);

            #endregion


            #region deleteMany
            //delete many
            //var delete = Builders<object>.Filter.Eq("ad", "Mukiş");
            //collection.DeleteMany(delete);
            #endregion


            #region get
            //var getFilter = Builders<object>.Filter.Eq("ad", "Muki");


            // results will be a collection of your documents matching your filter criteria

            // Sync syntax
            //var results = collection.Find(getFilter).ToList();
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item.ToJson());
            //}
            #endregion

        }

       
    }
}
