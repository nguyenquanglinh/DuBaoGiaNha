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
    public partial class AddOneObj : Form
    {
        private AddObjMng addObjMng;
        private Form1 form1;
        private InitData initdata;

        public AddOneObj()
        {
            InitializeComponent();
        }

        public AddOneObj(Form1 form1) : this()
        {
            this.form1 = form1;
        }

        public AddOneObj(Form1 form1, AddObjMng addObjMng) : this(form1)
        {
            this.addObjMng = addObjMng;
            this.initdata = new InitData(form1.dsCurrent, cbbArea, cbbAvailabitity, cbbLocation, cbbSize, cbbSociety, cbbTotalSqft, cbbBath, cbbBalcony, cbbPrice);
            initdata.InitDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtID.Text.Length == 0&& cbbArea.Text.Length == 0&& cbbAvailabitity.Text.Length == 0&& cbbLocation.Text.Length == 0&& cbbSize.Text.Length == 0&& cbbSociety.Text.Length == 0&& cbbTotalSqft.Text.Length == 0&& cbbBath.Text.Length == 0&& cbbBalcony.Text.Length == 0&& cbbPrice.Text.Length==0)
                {
                    MessageBox.Show("Tất cả các trường không được để trống", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                new PagingData().InsertData(new GiaNha(txtID.Text, cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text));
                if (MessageBox.Show("Thêm dữ liệu thành công.Bạn có muốn thêm tiếp không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.initdata.CbbClear();
                    return;
                }

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình thêm dữ liệu. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void AddOneObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            addObjMng.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowData(0);
            form1.Show();

        }

        private void btnPrivew_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
