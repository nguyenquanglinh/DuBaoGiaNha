using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuBaoGiaNha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("QuanLySanPham");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("Product");
        }
    }
}
