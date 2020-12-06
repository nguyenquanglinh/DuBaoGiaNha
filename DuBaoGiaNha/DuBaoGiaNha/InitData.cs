using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuBaoGiaNha
{
    public class InitData
    {
        public List<GiaNha> dsCurrent { get; set; }
        public DataGridView DataGridView1 { get; set; }
        public ComboBox cbbSTT { get; set; }
        public ComboBox cbbArea { get; set; }
        public ComboBox cbbAvailabitity { get; set; }
        public ComboBox cbbLocation { get; set; }
        public ComboBox cbbSize { get; set; }
        public ComboBox cbbSociety { get; set; }
        public ComboBox cbbTotalSqft { get; set; }
        public ComboBox cbbBath { get; set; }
        public ComboBox cbbBalcony { get; set; }
        public ComboBox cbbPrice { get; set; }

        public InitData(List<GiaNha> dsCurrent)
        {
            this.dsCurrent = dsCurrent;
        }

        public InitData(List<GiaNha> dsCurrent, DataGridView dataGridView1) : this(dsCurrent)
        {
            this.DataGridView1 = dataGridView1;
        }

        public InitData(List<GiaNha> dsCurrent, ComboBox cbbSTT, ComboBox cbbArea, ComboBox cbbAvailabitity, ComboBox cbbLocation, ComboBox cbbSize, ComboBox cbbSociety, ComboBox cbbTotalSqft, ComboBox cbbBath, ComboBox cbbBalcony, ComboBox cbbPrice) : this(dsCurrent)
        {
            this.cbbSTT = cbbSTT;
            this.cbbArea = cbbArea;
            this.cbbAvailabitity = cbbAvailabitity;
            this.cbbLocation = cbbLocation;
            this.cbbSize = cbbSize;
            this.cbbSociety = cbbSociety;
            this.cbbTotalSqft = cbbTotalSqft;
            this.cbbBath = cbbBath;
            this.cbbBalcony = cbbBalcony;
            this.cbbPrice = cbbPrice;
        }


        public InitData(List<GiaNha> dsCurrent, ComboBox cbbArea, ComboBox cbbAvailabitity, ComboBox cbbLocation, ComboBox cbbSize, ComboBox cbbSociety, ComboBox cbbTotalSqft, ComboBox cbbBath, ComboBox cbbBalcony, ComboBox cbbPrice) : this(dsCurrent)
        {
            this.cbbArea = cbbArea;
            this.cbbAvailabitity = cbbAvailabitity;
            this.cbbLocation = cbbLocation;
            this.cbbSize = cbbSize;
            this.cbbSociety = cbbSociety;
            this.cbbTotalSqft = cbbTotalSqft;
            this.cbbBath = cbbBath;
            this.cbbBalcony = cbbBalcony;
            this.cbbPrice = cbbPrice;
        }

        public InitData(List<GiaNha> dsCurrent, DataGridView dataGridView1, ComboBox cbbArea, ComboBox cbbAvailabitity, ComboBox cbbLocation, ComboBox cbbSize, ComboBox cbbSociety, ComboBox cbbTotalSqft, ComboBox cbbBath, ComboBox cbbBalcony, ComboBox cbbPrice, ComboBox cbbSTT) : this(dsCurrent, dataGridView1)
        {
            this.cbbArea = cbbArea;
            this.cbbAvailabitity = cbbAvailabitity;
            this.cbbLocation = cbbLocation;
            this.cbbSize = cbbSize;
            this.cbbSociety = cbbSociety;
            this.cbbTotalSqft = cbbTotalSqft;
            this.cbbBath = cbbBath;
            this.cbbBalcony = cbbBalcony;
            this.cbbPrice = cbbPrice;
            this.cbbSTT = cbbSTT;
        }

        public InitData(ComboBox cbbArea, ComboBox cbbAvailabitity, ComboBox cbbLocation, ComboBox cbbSize, ComboBox cbbSociety, ComboBox cbbTotalSqft, ComboBox cbbBath, ComboBox cbbBalcony, ComboBox cbbPrice)
        {
            this.cbbArea = cbbArea;
            this.cbbAvailabitity = cbbAvailabitity;
            this.cbbLocation = cbbLocation;
            this.cbbSize = cbbSize;
            this.cbbSociety = cbbSociety;
            this.cbbTotalSqft = cbbTotalSqft;
            this.cbbBath = cbbBath;
            this.cbbBalcony = cbbBalcony;
            this.cbbPrice = cbbPrice;
        }

        public void CbbClear()
        {
            if (DataGridView1 != null)
                DataGridView1.Rows.Clear();
            if (cbbSTT != null)
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

        private void DataGridViewAddValue(GiaNha item)
        {
            if (DataGridView1 != null)
            {
                int rowIndex = DataGridView1.Rows.Add();
                DataGridView1.Rows[rowIndex].Cells["STT"].Value = item.STT;
                DataGridView1.Rows[rowIndex].Cells["Aretype"].Value = item.AreaType;
                DataGridView1.Rows[rowIndex].Cells["Availability"].Value = item.Availability;
                DataGridView1.Rows[rowIndex].Cells["Balcony"].Value = item.Balcony;
                DataGridView1.Rows[rowIndex].Cells["Bath"].Value = item.Bath;
                DataGridView1.Rows[rowIndex].Cells["Location"].Value = item.Location;
                DataGridView1.Rows[rowIndex].Cells["Price"].Value = item.Price;
                DataGridView1.Rows[rowIndex].Cells["Size"].Value = item.Size;
                DataGridView1.Rows[rowIndex].Cells["Society"].Value = item.Society;
                DataGridView1.Rows[rowIndex].Cells["TotalSqft"].Value = item.TotalSqft;
            }
        }
        private void CheckValueAddCbb(ComboBox cb, object j)
        {
            if (!cb.Items.Contains(j))
                cb.Items.Add(j);
        }
        public void CbbSetValue(GiaNha item)
        {
            if (cbbSTT != null)
                cbbSTT.Text = item.STT.ToString();
            cbbArea.Text = item.AreaType;
            cbbAvailabitity.Text = item.Availability.ToString();
            cbbBalcony.Text = item.Balcony.ToString();
            cbbBath.Text = item.Bath.ToString();
            cbbLocation.Text = item.Location.ToString();
            cbbPrice.Text = item.Price.ToString();
            cbbSize.Text = item.Size.ToString();
            cbbSociety.Text = item.Society.ToString();
            cbbTotalSqft.Text = item.TotalSqft.ToString();
        }
        public void CbbAddValue(GiaNha item)
        {
            if (cbbSTT != null)
                CheckValueAddCbb(cbbSTT, item.STT);
            CheckValueAddCbb(cbbArea, item.AreaType);
            CheckValueAddCbb(cbbAvailabitity, item.Availability);
            CheckValueAddCbb(cbbBalcony, item.Balcony);
            CheckValueAddCbb(cbbBath, item.Bath);
            CheckValueAddCbb(cbbLocation, item.Location);
            CheckValueAddCbb(cbbPrice, item.Price);
            CheckValueAddCbb(cbbSize, item.Size);
            CheckValueAddCbb(cbbSociety, item.Society);
            CheckValueAddCbb(cbbTotalSqft, item.TotalSqft);
        }
        internal void InitDataGridView(int index = 0)
        {
            CbbClear();
            int stt = 0;
            for (int i = 0; i < dsCurrent.Count; i++)
            {
                stt = index + i;
                dsCurrent[i].STT = stt;
                DataGridViewAddValue(dsCurrent[i]);
                CbbAddValue(dsCurrent[i]);
            }
        }
    }
}
