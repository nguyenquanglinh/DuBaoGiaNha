using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace DuBaoGiaNha
{
    public class PagingData
    {
        private static IMongoCollection<BsonDocument> Collection;
        private static int pageCurrent = 0;
        private static int pageSize = 15;
        private static int maxPageNumber = 0;
        public int GetPageSize()
        {
            return pageSize;
        }
        public int GetMaxPageNumber()
        {
            return maxPageNumber;
        }
        public int GetPageCurrent()
        {
            return pageCurrent;
        }
        public string PageCurrent()
        {
            return GetPageCurrent().ToString() + "/" + GetMaxPageNumber().ToString();
        }

        private void InitData()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("BaoGiaNha");
            Collection = database.GetCollection<BsonDocument>("BaoGiaNha");
            maxPageNumber = Collection.Find(new BsonDocument()).ToList().Count / pageSize+1;
        }
        public PagingData()
        {
            if (Collection == null)
            {
                InitData();
            }
        }
        public Result GetListpageBson(int next)
        {
            if (next == 1) pageCurrent++;
            else if (next == -1) pageCurrent--;
            if (maxPageNumber > 0 && maxPageNumber >= pageCurrent && pageCurrent > 0)
            {
                var ret = new Result(false, "Successful data retrieval");
                ret.ListBson = Collection.Find(new BsonDocument()).Skip((pageCurrent - 1) * pageSize).Limit(pageSize).ToList();
                return ret;
            }
            else return new Result(true, "The current page is not available");
        }
        public Result GetListPageGia(int next)
        {
            var ret = GetListpageBson(next);
            if (ret.ErrCode) return ret;
            List<GiaNha> dsGia = new List<GiaNha>();
            foreach (BsonDocument document in ret.ListBson)
            {
                dsGia.Add(new GiaNha(document));
            }
            ret.ErrCode = false;
            ret.Massage = "Successful convert data bson to GiaNha ";
            ret.ListGiaNha = dsGia;
            return ret;
        }


        public Result InsertData(GiaNha item)
        {
            try
            {
                BsonDocument doc = new BsonDocument{
                {"area_type",item.AreaType  },
                { "availability",item.Availability },
                {"location",item.Location },
                {"size",item.Size },
                {"society",item.Society },
                {"total_sqft",item.TotalSqft },
                {"bath",item.Bath },
                { "balcony",item.Balcony },
                { "price",item.Price }
            };
                Collection.InsertOne(doc);
                return new Result(false, "InsertData Successful");
            }
            catch (Exception e)
            {
                return new Result(true, e.ToString());
            }
        }

        public Result UpdateData(GiaNha item)
        {
            try
            {
                FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(item.Id));
                UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update
                                                            .Set("area_type", item.AreaType)
                                                            .Set("availability", item.Availability)
                                                            .Set("location", item.Location)
                                                            .Set("size", item.Size)
                                                            .Set("society", item.Society)
                                                            .Set("total_sqft", item.TotalSqft)
                                                            .Set("bath", item.Bath)
                                                            .Set("balcony", item.Balcony)
                                                            .Set("price", item.Price);

                Collection.UpdateOne(filter, update);
                return new Result(false, "UpdateData Successful");
            }
            catch (Exception e)
            {
                return new Result(true, e.ToString());
            }
        }

        public Result DeleteData(GiaNha item)
        {
            try
            {
                FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(item.Id) );
                Collection.DeleteOne(filter);
                return new Result(false, "DeleteData Successful");
            }
            catch (Exception e)
            {
                return new Result(true, e.ToString());
            }
        }
    }
}
