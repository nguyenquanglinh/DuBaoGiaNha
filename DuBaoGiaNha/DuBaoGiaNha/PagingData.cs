using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace DuBaoGiaNha
{
    public class PagingData
    {
        private static IMongoCollection<BsonDocument> Collection;
        private static int pageCurrent = 0;
        private static int pageSize = 15;
        private static int maxPageNumber = 0;

        public List<BsonDocument> DataIList { get; private set; }

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
            this.DataIList = Collection.Find(new BsonDocument()).ToList();
            new Statistical(DataIList,true);
            maxPageNumber = DataIList.Count / pageSize + 1;
        }
        public PagingData()
        {
            if (Collection == null)
            {
                InitData();
            }

        }
        public int InsertDatas(string path, TextBox txtValue)
        {
            var lines = File.ReadAllLines(path);
            lines.ToList().RemoveAt(0);
            foreach (var item in lines)
            {
                InsertData(new GiaNha(item));
                txtValue.AppendText(item);
            }
            maxPageNumber = Collection.Find(new BsonDocument()).ToList().Count / pageSize + 1;
            return lines.Length;
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
        public Result UpdateData(GiaNha item, string filer = "_id", string value = null, bool updateOne = true)
        {
            try
            {
                FilterDefinition<BsonDocument> filter;
                if (value == null)
                    filter = Builders<BsonDocument>.Filter.Eq(filer, ObjectId.Parse(item.Id));
                else filter = Builders<BsonDocument>.Filter.Eq(filer, value);
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
                if (updateOne)
                    Collection.UpdateOne(filter, update);
                else Collection.UpdateMany(filter, update);
                return new Result(false, "UpdateData Successful");
            }
            catch (Exception e)
            {
                return new Result(true, e.ToString());
            }
        }
        public Result UpdateData(GiaNha item, GiaNha giaNha)
        {
            try
            {
                if (item.AreaType != giaNha.AreaType)
                    UpdateData(giaNha, "area_type", item.AreaType, false);
                if (item.Availability != giaNha.Availability)
                    UpdateData(giaNha, "availability", item.Availability, false);
                if (item.Location != giaNha.Location)
                    UpdateData(giaNha, "location", item.Location, false);
                if (item.Size != giaNha.Size)
                    UpdateData(giaNha, "size", item.Size, false);
                if (item.Society != giaNha.Society)
                    UpdateData(giaNha, "society", item.Society, false);
                if (item.TotalSqft != giaNha.TotalSqft)
                    UpdateData(giaNha, "total_sqft", item.TotalSqft, false);
                if (item.Bath != giaNha.Bath)
                    UpdateData(giaNha, "bath", item.Bath, false);
                if (item.Balcony != giaNha.Balcony)
                    UpdateData(giaNha, "balcony", item.Balcony, false);
                if (item.Price != giaNha.Price)
                    UpdateData(giaNha, "price", item.Price, false);
                return new Result(false, "UpdateData Successful");
            }
            catch (Exception e)
            {
                return new Result(true, e.ToString());
            }
        }
        public Result DeleteData(GiaNha giaCu, string filer = "_id", string value = null, bool updateOne = true)
        {
            try
            {
                FilterDefinition<BsonDocument> filter;
                if (value == null)
                    filter = Builders<BsonDocument>.Filter.Eq(filer, ObjectId.Parse(giaCu.Id));
                else filter = Builders<BsonDocument>.Filter.Eq(filer, value);
                if (updateOne)
                    Collection.DeleteOne(filter);
                else Collection.DeleteMany(filter);
                return new Result(false, "DeleteData Successful");
            }
            catch (Exception e)
            {
                return new Result(true, e.ToString());
            }
        }
        public Result DeleteDatas(GiaNha giaCu, GiaNha giaMoi)
        {
            try
            {
                if (giaCu.AreaType != giaMoi.AreaType)
                    DeleteData(giaCu, "area_type", giaCu.AreaType, false);
                if (giaCu.Availability != giaMoi.Availability)
                    DeleteData(giaCu, "availability", giaCu.Availability, false);
                if (giaCu.Location != giaMoi.Location)
                    DeleteData(giaCu, "location", giaCu.Location, false);
                if (giaCu.Size != giaMoi.Size)
                    DeleteData(giaCu, "size", giaCu.Size, false);
                if (giaCu.Society != giaMoi.Society)
                    DeleteData(giaCu, "society", giaCu.Society, false);
                if (giaCu.TotalSqft != giaMoi.TotalSqft)
                    DeleteData(giaCu, "total_sqft", giaCu.TotalSqft, false);
                if (giaCu.Bath != giaMoi.Bath)
                    DeleteData(giaCu, "bath", giaCu.Bath, false);
                if (giaCu.Balcony != giaMoi.Balcony)
                    DeleteData(giaCu, "balcony", giaCu.Balcony, false);
                if (giaCu.Price != giaMoi.Price)
                    DeleteData(giaCu, "price", giaCu.Price, false);
                return new Result(false, "Delete Successful");
            }
            catch (Exception e)
            {
                return new Result(true, e.ToString());
            }
        }
    }
}
