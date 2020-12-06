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
    public partial class DeleteOneObj : Form
    {
        private Form1 form1;
        private DeleteObjMng deleteObjMng;
        private GiaNha giaNha;
        private InitData initdata;

        public DeleteOneObj()
        {
            InitializeComponent();
        }

        public DeleteOneObj(Form1 form1, DeleteObjMng deleteObjMng, GiaNha giaNha):this()
        {
            this.form1 = form1;
            this.deleteObjMng = deleteObjMng;
            this.giaNha = giaNha;
            this.initdata = new InitData(cbbArea, cbbAvailabitity, cbbLocation, cbbSize, cbbSociety, cbbTotalSqft, cbbBath, cbbBalcony, cbbPrice);
            initdata.CbbSetValue(giaNha);
        }

        private void btnPrivew_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowData(0);
            form1.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           var ret= new PagingData().DeleteData(giaNha);
            MessageBox.Show(ret.Massage, "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void DeleteOneObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            deleteObjMng.Show();
        }
    }
}
