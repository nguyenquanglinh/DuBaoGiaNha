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
    public partial class VisualDataMng : Form
    {
        private Form1 form1;

        public VisualDataMng()
        {
            InitializeComponent();
        }

        public VisualDataMng(Form1 form1):this()
        {
            this.form1 = form1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void cbAddOne_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddOne.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical(), "General chart");
                chart1.Show();
            }
        }

        private void cbAddMany_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddOne.Checked)
                cbAddOne.Checked = false;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
         

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void cbArea_CheckedChanged(object sender, EventArgs e)
        {
             if (cbArea.Checked)
            {
                var chart1=new VusalData();
                chart1.AddChart(new Statistical().ListAre, "Area type chart");
                chart1.Show();
            }
        }

        private void cbAvail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAvail.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical().ListAvailability, "Availability chart");
                chart1.Show();
            }
        }

        private void cbLoacation_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoacation.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical().ListLocation, "Location chart");
                chart1.Show();
            }
        }

        private void cbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSize.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical().ListSize, "Size chart");
                chart1.Show();
            }
        }

        private void cbSociety_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSociety.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical().ListSociety, "Society chart");
                chart1.Show();
            }
        }

        private void cbTotalSqft_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotalSqft.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical().ListTotalSqft, "Total Sqft chart");
                chart1.Show();
            }
        }

        private void cbBath_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBath.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical().ListBath, "Bath chart");
                chart1.Show();
            }
        }

        private void cbBalcony_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBalcony.Checked)
            {
                var chart1 = new VusalData();
                chart1.AddChart(new Statistical().LisBalcony, "Balcony chart");
                chart1.Show();
            }
        }
    }
}
