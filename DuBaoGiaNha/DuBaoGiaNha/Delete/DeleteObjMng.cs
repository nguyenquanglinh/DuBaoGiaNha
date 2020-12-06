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
    public partial class DeleteObjMng : Form
    {
        private Form1 form1;
        private GiaNha giaNha;

        public DeleteObjMng()
        {
            InitializeComponent();
        }

        public DeleteObjMng(Form1 form1):this()
        {
            this.form1 = form1;
        }

        public DeleteObjMng(Form1 form1, GiaNha giaNha) : this(form1)
        {
            this.giaNha = giaNha;
        }

        private void cbAddOne_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteObjMng_Load(object sender, EventArgs e)
        {

        }

        private void cbAddMany_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddOne.Checked)
                cbAddOne.Checked = true;
        }

        private void cbAddOne_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbAddMany.Checked)
                cbAddMany.Checked = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteObjMng_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ShowData(0);
            form1.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbAddOne.Checked)
            {
                new DeleteOneObj(form1, this, giaNha).Show();
                Hide();
            }
            else if (cbAddMany.Checked)
            {
                new DeleteManyObj(form1, this, giaNha).Show();
                Hide();
            }
            else MessageBox.Show("Chọn 1 phương thức hiển thị", "Hướng dẫn", MessageBoxButtons.OK);

        }
    }
}
