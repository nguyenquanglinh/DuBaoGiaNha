using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace DuBaoGiaNha
{
    public class Statistical
    {
        //public Statistical(List<>bool update=false)
        //{
        //    if(update)

        //}
        public static List<BsonDocument> DataIList { get; set; }

        public Statistical(List<BsonDocument> dataIList,bool update=false)
        {
            if (update)
            {
                DataIList = dataIList;
               
            }
          
        }

        public Statistical()
        {
            if(DataIList!=null) ConvertListDocToListGia();
        }

        public List<GiaNha> DataGList { get; private set; }
        public StatisticalEntity ListAre { get; private set; }
        public StatisticalEntity ListAvailability { get; private set; }
        public StatisticalEntity ListPrice { get; private set; }
        public StatisticalEntity LisBalcony { get; private set; }
        public StatisticalEntity ListBath { get; private set; }
        public StatisticalEntity ListSociety { get; private set; }
        public StatisticalEntity ListLocation { get; private set; }
        public StatisticalEntity ListSize { get; private set; }
        public StatisticalEntity ListTotalSqft { get; private set; }

        public void ConvertListDocToListGia()
        {
            this.DataGList = new List<GiaNha>();
            this.ListAre = new StatisticalEntity("Area type");
            this.ListAvailability = new StatisticalEntity("Availability");
            this.ListLocation = new StatisticalEntity("Location");
            this.ListSize = new StatisticalEntity("Size");
            this.ListSociety = new StatisticalEntity("Society");
            this.ListTotalSqft = new StatisticalEntity("Total Sqft");
            this.ListBath = new StatisticalEntity("Bath");
            this.LisBalcony = new StatisticalEntity("Balcony");
            foreach (var item in DataIList)
            {
                var giaNha = new GiaNha(item);
                DataGList.Add(giaNha);
                int price = 0;
                try
                {
                    price = int.Parse(giaNha.Price);
                }
                catch
                {

                }
                //are
                if (!ListAre.Dic.ContainsKey(giaNha.AreaType))
                {
                    ListAre.Dic.Add(giaNha.AreaType, price);
                }
                else ListAre.Dic[giaNha.AreaType] += price;
                //avai
                if (!ListAvailability.Dic.ContainsKey(giaNha.Availability))
                {
                    ListAvailability.Dic.Add(giaNha.Availability, price);
                }
                else ListAvailability.Dic[giaNha.Availability] += price;
                //are
                if (!ListLocation.Dic.ContainsKey(giaNha.Location))
                {
                    ListLocation.Dic.Add(giaNha.Location, price);
                }
                else ListLocation.Dic[giaNha.Location] += price;
                //avai
                if (!ListSize.Dic.ContainsKey(giaNha.Size))
                {
                    ListSize.Dic.Add(giaNha.Size, price);
                }
                else ListSize.Dic[giaNha.Size] += price;
                //are
                if (!ListSociety.Dic.ContainsKey(giaNha.Society))
                {
                    ListSociety.Dic.Add(giaNha.Society, price);
                }
                else ListSociety.Dic[giaNha.Society] += price;
                //avai
                if (!ListTotalSqft.Dic.ContainsKey(giaNha.TotalSqft))
                {
                    ListTotalSqft.Dic.Add(giaNha.TotalSqft, price);
                }
                else ListTotalSqft.Dic[giaNha.TotalSqft] += price;
                //are
                if (!ListBath.Dic.ContainsKey(giaNha.Bath))
                {
                    ListBath.Dic.Add(giaNha.Bath, price);
                }
                else ListBath.Dic[giaNha.Bath] += price;
                //avai
                if (!LisBalcony.Dic.ContainsKey(giaNha.Balcony))
                {
                    LisBalcony.Dic.Add(giaNha.Balcony, price);
                }
                else LisBalcony.Dic[giaNha.Balcony] += price;
            }
        }
        public int GetPrice()
        {
            return ListAre.GetPrice() + ListAvailability.GetPrice() + ListLocation.GetPrice()
                + ListSize.GetPrice() + ListSociety.GetPrice() + ListTotalSqft.GetPrice()
                + ListBath.GetPrice() + LisBalcony.GetPrice();
        }
    }
    public class StatisticalEntity
    {
        public StatisticalEntity(string name)
        {
            this.Name = name;
            Dic = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Dic { get;  set; }
        public string Name { get; private set; }
        public int GetPrice()
        {
            int price = 0;
            foreach (var item in Dic)
            {
                price += item.Value;
            }
            return price;
        }
    }
}
