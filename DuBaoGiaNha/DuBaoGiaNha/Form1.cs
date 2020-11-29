using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace DuBaoGiaNha
{
    public partial class Form1 : Form
    {
        private PagingData data;

        public Form1()
        {
            InitializeComponent();
            //this.MinimizeBox = false;
            this.MaximizeBox = false;
            data = new PagingData();
            txtPageCurrent.Text = data.GetMaxPageNumber().ToString();
        }
        List<GiaNha> dsCurrent;
        void ShowData(int next)
        {
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
                MessageBox.Show("Thông báo", ret.Massage, MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                InitData(ret, index);

            }
        }
        private void CbbClear()
        {
            dataGridView1.Rows.Clear();
            cbbSTT.Items.Clear();
            cbbArea.Items.Clear();
            cbbAvailabitity.Items.Clear();
            cbbLocation.Items.Clear();
            cbbSize.Items.Clear();
            cbbSociety.Items.Clear();
            cbbTotalSqft.Items.Clear();
            cbbBath.Items.Clear();
            cbbBalcony.Items.Clear();
            cbbPrice.Items.Clear();
        }
        private void DataGridViewAddValue(GiaNha item, int rowIndex)
        {
            dataGridView1.Rows[rowIndex].Cells["STT"].Value = item.STT;
            dataGridView1.Rows[rowIndex].Cells["Aretype"].Value = item.AreaType;
            dataGridView1.Rows[rowIndex].Cells["Availability"].Value = item.Availability;
            dataGridView1.Rows[rowIndex].Cells["Balcony"].Value = item.Balcony;
            dataGridView1.Rows[rowIndex].Cells["Bath"].Value = item.Bath;
            dataGridView1.Rows[rowIndex].Cells["Location"].Value = item.Location;
            dataGridView1.Rows[rowIndex].Cells["Price"].Value = item.Price;
            dataGridView1.Rows[rowIndex].Cells["Size"].Value = item.Size;
            dataGridView1.Rows[rowIndex].Cells["Society"].Value = item.Society;
            dataGridView1.Rows[rowIndex].Cells["TotalSqft"].Value = item.TotalSqft;
        }
        private void CbbAddValue(GiaNha item)
        {
            cbbSTT.Items.Add(item.STT);
            cbbArea.Items.Add(item.AreaType);
            cbbAvailabitity.Items.Add(item.Availability);
            cbbBalcony.Items.Add(item.Balcony);
            cbbBath.Items.Add(item.Bath);
            cbbLocation.Items.Add(item.Location);
            cbbPrice.Items.Add(item.Price);
            cbbSize.Items.Add(item.Size);
            cbbSociety.Items.Add(item.Society);
            cbbTotalSqft.Items.Add(item.TotalSqft);
        }

        private void InitData(Result ret, int index)
        {
            dsCurrent = ret.ListGiaNha;
            CbbClear();
            int stt = 0;
            for (int i = 0; i < dsCurrent.Count; i++)
            {
                stt = index + i;
                dsCurrent[i].STT = stt;
                DataGridViewAddValue(dsCurrent[i], this.dataGridView1.Rows.Add());
                CbbAddValue(dsCurrent[i]);
            }
            txtPageCurrent.Text = data.PageCurrent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            ShowData(1);
        }
        private void SetValueToCbb(int rowIndex)
        {
            txtID.Text = dsCurrent[rowIndex].Id;
            cbbSTT.SelectedText = dataGridView1.Rows[rowIndex].Cells["STT"].Value.ToString();
            cbbArea.SelectedText = dataGridView1.Rows[rowIndex].Cells["Aretype"].Value.ToString();
            cbbAvailabitity.SelectedText = dataGridView1.Rows[rowIndex].Cells["Availability"].Value.ToString();
            cbbBalcony.SelectedText = dataGridView1.Rows[rowIndex].Cells["Balcony"].Value.ToString();
            cbbBath.SelectedText = dataGridView1.Rows[rowIndex].Cells["Bath"].Value.ToString();
            cbbLocation.SelectedText = dataGridView1.Rows[rowIndex].Cells["Location"].Value.ToString();
            cbbPrice.SelectedText = dataGridView1.Rows[rowIndex].Cells["Price"].Value.ToString();
            cbbSize.SelectedText = dataGridView1.Rows[rowIndex].Cells["Size"].Value.ToString();
            cbbSociety.SelectedText = dataGridView1.Rows[rowIndex].Cells["Society"].Value.ToString();
            cbbTotalSqft.SelectedText = dataGridView1.Rows[rowIndex].Cells["TotalSqft"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
            data.InsertData(new GiaNha(txtID.Text, cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text));
            ShowData(0);
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            if (txtID.Text.Length == 0) MessageBox.Show("Thông báo", "Chưa xác định được đối tượng cần xóa.Cần chọn 1 đối tượng để xóa");
            else
            {
                data.DeleteData(new GiaNha(txtID.Text, cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text));
                ShowData(0);
            }
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            if (txtID.Text.Length == 0) MessageBox.Show("Thông báo", "Chưa xác định được đối tượng cần sửa.Cần chọn 1 đối tượng để sửa");
            else
            {
                data.UpdateData(new GiaNha(txtID.Text, cbbArea.Text, cbbAvailabitity.Text, cbbLocation.Text, cbbSize.Text, cbbSociety.Text, cbbTotalSqft.Text, cbbBath.Text, cbbBalcony.Text, cbbPrice.Text));
                ShowData(0);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetValueToCbb(e.RowIndex);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
