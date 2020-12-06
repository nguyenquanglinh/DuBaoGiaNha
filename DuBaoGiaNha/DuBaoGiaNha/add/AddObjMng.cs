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
    public partial class AddObjMng : Form
    {
        private Form1 form1;

        public AddObjMng()
        {
            InitializeComponent();
        }

        public AddObjMng(Form1 form1) : this()
        {
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbAddOne.Checked)
            {
                new AddOneObj(form1, this).Show();
                Hide();
            }
            else if (cbAddMany.Checked)
            {
                new AddManyObj(form1, this).Show();
                Hide();
            }
            else MessageBox.Show("Chọn 1 phương thức xử lý.", "Hướng dẫn", MessageBoxButtons.OK);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbAddOne_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddMany.Checked)
                cbAddMany.Checked = false;
        }

        private void cbAddMany_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddOne.Checked)
                cbAddOne.Checked = false;
        }

        private void AddObjMng_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ShowData(0);
            form1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
