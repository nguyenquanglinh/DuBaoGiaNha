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
    public partial class UpdateManyObj : Form
    {
        private Form1 form1;
        private UpdateObjMng updateObjMng;
        private InitData initdata;
        private GiaNha giaNhaCurrent;

        public UpdateManyObj()
        {
            InitializeComponent();
        }

        public UpdateManyObj(Form1 form1, UpdateObjMng updateObjMng,GiaNha item):this()
        {
            this.form1 = form1;
            this.updateObjMng = updateObjMng;
            this.initdata = new InitData(form1.dsCurrent, cbbArea, cbbAvailabitity, cbbLocation, cbbSize, cbbSociety, cbbTotalSqft, cbbBath, cbbBalcony, cbbPrice);
            initdata.InitDataGridView();
            this.giaNhaCurrent = item;
            initdata.CbbSetValue(item);
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

        private void btnPrivew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateManyObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateObjMng.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbArea.Checked || cbAvail.Checked || cbLoacation.Checked || cbSize.Checked || cbSociety.Checked || cbTotalSqft.Checked || cbBath.Checked || cbBalcony.Checked || cbPrice.Checked)
            {
                var ret = new PagingData().UpdateData(giaNhaCurrent, new GiaNha("", cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text));

                if (MessageBox.Show(ret.Massage + ".Ban có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
            }
            else MessageBox.Show("Chọn trường để thay đổi");
        }
    }
}
