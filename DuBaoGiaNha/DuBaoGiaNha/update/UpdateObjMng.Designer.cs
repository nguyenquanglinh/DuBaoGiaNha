namespace DuBaoGiaNha
{
    partial class UpdateObjMng
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbAddMany = new System.Windows.Forms.CheckBox();
            this.cbAddOne = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(19, 22);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Quay lại";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(173, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbAddMany
            // 
            this.cbAddMany.AutoSize = true;
            this.cbAddMany.Location = new System.Drawing.Point(253, 62);
            this.cbAddMany.Name = "cbAddMany";
            this.cbAddMany.Size = new System.Drawing.Size(165, 17);
            this.cbAddMany.TabIndex = 6;
            this.cbAddMany.Text = "Cập nhật nhiều trường dữ liệu";
            this.cbAddMany.UseVisualStyleBackColor = true;
            this.cbAddMany.CheckedChanged += new System.EventHandler(this.cbAddMany_CheckedChanged);
            // 
            // cbAddOne
            // 
            this.cbAddOne.AutoSize = true;
            this.cbAddOne.Location = new System.Drawing.Point(65, 62);
            this.cbAddOne.Name = "cbAddOne";
            this.cbAddOne.Size = new System.Drawing.Size(139, 17);
            this.cbAddOne.TabIndex = 5;
            this.cbAddOne.Text = "Cập nhật 1 bảng dữ liệu";
            this.cbAddOne.UseVisualStyleBackColor = true;
            this.cbAddOne.CheckedChanged += new System.EventHandler(this.cbAddOne_CheckedChanged);
            // 
            // UpdateObjMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 190);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbAddMany);
            this.Controls.Add(this.cbAddOne);
            this.Name = "UpdateObjMng";
            this.Text = "Quản lý cập nhật dữ liệu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateObjMng_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbAddMany;
        private System.Windows.Forms.CheckBox cbAddOne;
    }
}