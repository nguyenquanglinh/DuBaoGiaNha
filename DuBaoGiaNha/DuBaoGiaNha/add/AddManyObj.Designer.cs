namespace DuBaoGiaNha
{
    partial class AddManyObj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnbackground = new System.Windows.Forms.Button();
            this.btnPrivew = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(24, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Mở file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(156, 226);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Thêm dữ liệu";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(24, 41);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(440, 164);
            this.txtValue.TabIndex = 2;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(122, 15);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(342, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnbackground
            // 
            this.btnbackground.Location = new System.Drawing.Point(279, 226);
            this.btnbackground.Name = "btnbackground";
            this.btnbackground.Size = new System.Drawing.Size(75, 23);
            this.btnbackground.TabIndex = 4;
            this.btnbackground.Text = "Ẩn";
            this.btnbackground.UseVisualStyleBackColor = true;
            this.btnbackground.Visible = false;
            this.btnbackground.Click += new System.EventHandler(this.btnbackground_Click);
            // 
            // btnPrivew
            // 
            this.btnPrivew.Location = new System.Drawing.Point(24, 226);
            this.btnPrivew.Name = "btnPrivew";
            this.btnPrivew.Size = new System.Drawing.Size(75, 23);
            this.btnPrivew.TabIndex = 5;
            this.btnPrivew.Text = "Trang trước";
            this.btnPrivew.UseVisualStyleBackColor = true;
            this.btnPrivew.Click += new System.EventHandler(this.btnPrivew_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(389, 226);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AddManyObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPrivew);
            this.Controls.Add(this.btnbackground);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnOpen);
            this.Name = "AddManyObj";
            this.Text = "AddManyObj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddManyObj_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnbackground;
        private System.Windows.Forms.Button btnPrivew;
        private System.Windows.Forms.Button btnHome;
    }
}