using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuBaoGiaNha
{
    public class Result
    {
        public Result(bool errCode,string massage)
        {
            this.ErrCode = errCode;
            this.Massage = massage;
        }
        public List<BsonDocument> ListBson { get; set; }
        public bool ErrCode { get;  set; }
        public List<GiaNha> ListGiaNha { get;  set; }
        public string Massage { get;  set; }
    }
}
