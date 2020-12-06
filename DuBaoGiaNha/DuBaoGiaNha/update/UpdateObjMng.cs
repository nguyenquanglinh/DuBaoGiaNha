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
    public partial class UpdateObjMng : Form
    {
        private Form1 form1;
        private GiaNha giaNha;

        public UpdateObjMng()
        {
            InitializeComponent();
        }

        public UpdateObjMng(Form1 form1, GiaNha giaNha):this()
        {
            this.form1 = form1;
            this.giaNha = giaNha;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void UpdateObjMng_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.ShowData(0);
            form1.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbAddOne.Checked)
            {
                new UpdateOneObj(form1, this,giaNha).Show();
                Hide();
            }
            else if (cbAddMany.Checked)
            {
                new UpdateManyObj(form1, this,giaNha).Show();
                Hide();
            }
            else MessageBox.Show("Chọn 1 phương thức hiển thị", "Hướng dẫn", MessageBoxButtons.OK);

        }
    }
}
