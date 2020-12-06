using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using System.Drawing;

namespace DuBaoGiaNha
{
    public partial class Form1 : Form
    {
        private PagingData data;
        private InitData initData;

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            data = new PagingData();
           
        }
        public List<GiaNha> dsCurrent { get; set; }
       public void ShowData(int next)
        {
            txtPageCurrent.Text = data.GetMaxPageNumber().ToString();
            var ret = data.GetListPageGia(next);
            int index = (data.GetPageCurrent() - 1) * data.GetPageSize() + 1;
            if (index == 1)
            {
                btnTruoc.Enabled = false;
            }
            else
            {
                btnTruoc.Enabled = true;
                if (index == data.GetMaxPageNumber())
                {
                    btnSau.Enabled = false;
                }
                else
                {
                    btnSau.Enabled = true;
                }
            }
            if (ret.ErrCode)
            {
                MessageBox.Show(ret.Massage, "Thông báo",  MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                InitData(ret, index);

            }
        }
        private void InitData(Result ret, int index)
        {
            dsCurrent = ret.ListGiaNha;
            this.initData = new InitData(dsCurrent, dataGridView1, cbbArea, cbbAvailabitity, cbbLocation, cbbSize, cbbSociety, cbbTotalSqft, cbbBath, cbbBalcony, cbbPrice, cbbSTT);
            initData.InitDataGridView(index);
            txtPageCurrent.Text = data.PageCurrent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ShowData(1);
        }
        private void SetValueToCbb(int rowIndex)
        {
            if (rowIndex < 0) return;
            try
            {
                txtID.Text = dsCurrent[rowIndex].Id.ToString();
                initData.CbbSetValue(dsCurrent[rowIndex]);
            }
            catch
            {
            }
        }

        private void btnTruoc_Click(object sender, System.EventArgs e)
        {
            ShowData(-1);
        }

        private void btnSau_Click(object sender, System.EventArgs e)
        {
            ShowData(1);
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            Hide();
            new AddObjMng(this).Show();
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            if (txtID.Text.Length == 0) MessageBox.Show("Thông báo", "Chưa xác định được đối tượng cần xóa.Cần chọn 1 đối tượng để xóa");
            else
            {
                Hide();
                new DeleteObjMng(this, new GiaNha(txtID.Text, cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text)).Show();
            }
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            if (txtID.Text.Length>0)
                new UpdateObjMng(this, new GiaNha(txtID.Text, cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text)).Show();
            else MessageBox.Show("Cần chọn 1 giá trị để sửa.", "Hướng dẫn", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetValueToCbb(e.RowIndex);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void Form1_Shown(object sender, System.EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Find"));
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));

            }
        }

        private void btnTrucQuan_Click(object sender, System.EventArgs e)
        {
            //this.Hide();
            new VisualDataMng(this).Show();
        }
    }
}
