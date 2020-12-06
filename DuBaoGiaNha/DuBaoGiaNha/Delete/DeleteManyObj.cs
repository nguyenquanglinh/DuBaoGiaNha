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
    public partial class DeleteManyObj : Form
    {
        private Form1 form1;
        private DeleteObjMng deleteObjMng;
        private GiaNha giaNha;
        private InitData initdata;

        public DeleteManyObj()
        {
            InitializeComponent();
        }

        public DeleteManyObj(Form1 form1, DeleteObjMng deleteObjMng, GiaNha giaNha) : this()
        {
            this.form1 = form1;
            this.deleteObjMng = deleteObjMng;
            this.giaNha = giaNha;
            this.initdata = new InitData(form1.dsCurrent, cbbArea, cbbAvailabitity, cbbLocation, cbbSize, cbbSociety, cbbTotalSqft, cbbBath, cbbBalcony, cbbPrice);
            initdata.InitDataGridView();
            initdata.CbbSetValue(giaNha);
        }

        private void DeleteManyObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            deleteObjMng.Show();
        }

        private void btnPrivew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            form1.ShowData(0);
            form1.Show();
        }

        private void cbArea_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArea.Checked)
                cbbArea.Visible = true;
            else cbbArea.Visible = false;
        }

        private void cbAvail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAvail.Checked)
                cbbAvailabitity.Visible = true;
            else cbbAvailabitity.Visible = false;
        }

        private void cbLoacation_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoacation.Checked)
                cbbLocation.Visible = true;
            else cbbLocation.Visible = false;
        }

        private void cbSize_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSize.Checked)
                cbbSize.Visible = true;
            else cbbSize.Visible = false;
        }

        private void cbSociety_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSociety.Checked)
                cbbSociety.Visible = true;
            else cbbSociety.Visible = false;
        }

        private void cbTotalSqft_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTotalSqft.Checked)
                cbbTotalSqft.Visible = true;
            else cbbTotalSqft.Visible = false;
        }

        private void cbBath_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBath.Checked)
                cbbBath.Visible = true;
            else cbbBath.Visible = false;
        }

        private void cbBalcony_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBalcony.Checked)
                cbbBalcony.Visible = true;
            else cbbBalcony.Visible = false;
        }

        private void cbPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPrice.Checked)
                cbbPrice.Visible = true;
            else cbbPrice.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var giaMoi = new GiaNha();
            if (cbArea.Checked)
                giaMoi.AreaType = "";
            if (cbAvail.Checked)
                giaMoi.Availability = "";
            if (cbLoacation.Checked)
                giaMoi.Location = "";
            if (cbSize.Checked)
                giaMoi.Size = "";
            if (cbSociety.Checked)
                giaMoi.Society = "";
            if (cbTotalSqft.Checked)
                giaMoi.TotalSqft = "";
            if (cbBath.Checked)
                giaMoi.Bath = "";
            if (cbBalcony.Checked)
                giaMoi.Balcony = "";
            if (cbPrice.Checked)
                giaMoi.Price = "";
            var ret = new PagingData().DeleteDatas(giaNha, giaMoi);
            if (MessageBox.Show(ret.Massage + ".Ban có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();

        }
    }
}
