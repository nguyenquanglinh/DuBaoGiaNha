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
    public partial class UpdateOneObj : Form
    {
        private Form1 form1;
        private UpdateObjMng updateObjMng;
        private GiaNha giaNha;
        private InitData initdata;

        public UpdateOneObj()
        {
            InitializeComponent();
        }

        public UpdateOneObj(Form1 form1, UpdateObjMng updateObjMng, GiaNha giaNha) : this()
        {
            this.form1 = form1;
            this.updateObjMng = updateObjMng;
            this.giaNha = giaNha;
            this.initdata = new InitData(cbbArea, cbbAvailabitity, cbbLocation, cbbSize, cbbSociety, cbbTotalSqft, cbbBath, cbbBalcony, cbbPrice);
            initdata.CbbSetValue(giaNha);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btnPrivew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateOneObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            updateObjMng.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (giaNha.Id.Length < 1)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quáy trình truyền dữ liêu.Không thể xác định được đối tượng cần cập nhật", "Cảnh báo lỗi", MessageBoxButtons.OK);
                    return;
                }
                new PagingData().UpdateData(new GiaNha(giaNha.Id, cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text));
                if (MessageBox.Show("Cập nhật dữ liệu thành công.Bạn có muốn thêm tiếp không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.initdata.CbbClear();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật dữ liệu. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
