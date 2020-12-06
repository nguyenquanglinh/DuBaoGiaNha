using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuBaoGiaNha
{
    public partial class AddManyObj : Form
    {
        private AddObjMng addObjMng;
        private Form1 form1;
        private Thread thread;
        private int index;

        public AddManyObj()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        public AddManyObj(Form1 form1, AddObjMng addObjMng) : this()
        {
            this.form1 = form1;
            this.addObjMng = addObjMng;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            txtFileName.Text = open.FileName;
            this.thread = new Thread(ThreadInsert);
        }
        public void ThreadInsert()
        {
            this.index = new PagingData().InsertDatas(txtFileName.Text, txtValue);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            this.thread = new Thread(ThreadInsert);
            thread.Start();
            timer1.Start();
            btnbackground.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thread.Join(50))
            {
                timer1.Stop();
                if (MessageBox.Show("Đã thêm được " + index + " bản ghi thành công.Bạn có muốn tiếp tục thêm không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Show();
                    txtFileName.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void AddManyObj_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                addObjMng.Show();

            }
            catch
            {

            }
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

        private void btnbackground_Click(object sender, EventArgs e)
        {
            this.Hide();
            addObjMng.Show();
        }
    }
}
