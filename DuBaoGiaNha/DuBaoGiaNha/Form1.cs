using MongoDB.Bson;
using MongoDB.Driver;
using System.Windows.Forms;

namespace DuBaoGiaNha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("QuanLySanPham");
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("Product");
        }
    }
}
