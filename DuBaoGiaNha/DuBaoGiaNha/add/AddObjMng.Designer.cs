namespace DuBaoGiaNha
{
    partial class AddObjMng
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
            this.cbAddOne = new System.Windows.Forms.CheckBox();
            this.cbAddMany = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAddOne
            // 
            this.cbAddOne.AutoSize = true;
            this.cbAddOne.Location = new System.Drawing.Point(59, 53);
            this.cbAddOne.Name = "cbAddOne";
            this.cbAddOne.Size = new System.Drawing.Size(123, 17);
            this.cbAddOne.TabIndex = 0;
            this.cbAddOne.Text = "Thêm 1 bảng dữ liệu";
            this.cbAddOne.UseVisualStyleBackColor = true;
            this.cbAddOne.CheckedChanged += new System.EventHandler(this.cbAddOne_CheckedChanged);
            // 
            // cbAddMany
            // 
            this.cbAddMany.AutoSize = true;
            this.cbAddMany.Location = new System.Drawing.Point(247, 53);
            this.cbAddMany.Name = "cbAddMany";
            this.cbAddMany.Size = new System.Drawing.Size(143, 17);
            this.cbAddMany.TabIndex = 1;
            this.cbAddMany.Text = "Thêm nhiều bảng dữ liệu";
            this.cbAddMany.UseVisualStyleBackColor = true;
            this.cbAddMany.CheckedChanged += new System.EventHandler(this.cbAddMany_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(13, 13);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Quay lại";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(360, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddObjMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 166);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAddMany);
            this.Controls.Add(this.cbAddOne);
            this.Name = "AddObjMng";
            this.Text = "Thêm dữ liệu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddObjMng_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAddOne;
        private System.Windows.Forms.CheckBox cbAddMany;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnClose;
    }
}