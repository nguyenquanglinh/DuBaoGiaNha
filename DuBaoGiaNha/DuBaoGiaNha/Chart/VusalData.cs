using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DuBaoGiaNha
{
    public partial class VusalData : Form
    {

        public VusalData()
        {
            InitializeComponent();
        }
        public void AddChart(Statistical statistical,string title)
        {
            chart1.Series["Price"].Points.AddXY("Tổng", statistical.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.ListSociety.Name, statistical.ListSociety.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.ListAvailability.Name, statistical.ListAvailability.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.ListLocation.Name, statistical.ListLocation.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.ListSize.Name, statistical.ListSize.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.ListSociety.Name, statistical.ListSociety.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.ListTotalSqft.Name, statistical.ListTotalSqft.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.ListBath.Name, statistical.ListBath.GetPrice());
            chart1.Series["Price"].Points.AddXY(statistical.LisBalcony.Name, statistical.LisBalcony.GetPrice());

            //chart title  
            chart1.Titles.Add(title);
        }

        internal void AddChart(StatisticalEntity listAre, string v)
        {
            chart1.Series["Price"].Points.AddXY("Tổng", listAre.GetPrice());
            foreach (var item in listAre.Dic)
            {
                chart1.Series["Price"].Points.AddXY(item.Key, item.Value);
            }
            chart1.Titles.Add(v);
        }
    }
}
