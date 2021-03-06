﻿using MongoDB.Bson;

namespace DuBaoGiaNha
{
    public class GiaNha
    {
        public GiaNha() { }
        public GiaNha(string _id, string area_type, string availability, string location, string size, string society, string total_sqft, string bath, string balcony, string price)
        {
            Id = _id;
            AreaType = area_type;
            Availability = availability;
            Location = location;
            Size = size; this.Society = society;
            TotalSqft = total_sqft;
            Bath = bath;
            Balcony = balcony;
            Price = price;
        }
        public int STT { get; set; }
        public GiaNha(BsonDocument document) :
            this(document["_id"].ToString(),
                document["area_type"].ToString(),
                document["availability"].ToString(),
                document["location"].ToString(),
                document["size"].ToString(),
                document["society"].ToString(),
                document["total_sqft"].ToString(),
                document["bath"].ToString(),
                document["balcony"].ToString(),
                document["price"].ToString())
        {
        }

        public GiaNha(string item)
        {
            var pro = item.Split(',');
            if (pro.Length != 9) return;
            AreaType = pro[0];
            Availability = pro[1];
            Location = pro[2];
            Size = pro[3];
            Society = pro[4];
            TotalSqft = pro[5];
            Bath = pro[6];
            Balcony = pro[7];
            Price = pro[8];
        }

        public string AreaType { get; set; }
        public string Availability { get; set; }
        public string Balcony { get; set; }
        public string Bath { get; set; }
        public string Id { get; private set; }
        public string Location { get; set; }
        public string Price { get; set; }
        public string Size { get; set; }
        public string Society { get; set; }
        public string TotalSqft { get; set; }
    }
}