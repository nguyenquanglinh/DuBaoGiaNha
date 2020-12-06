namespace DuBaoGiaNha
{
    partial class DeleteObjMng
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbAddMany = new System.Windows.Forms.CheckBox();
            this.cbAddOne = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(363, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(16, 18);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Quay lại";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbAddMany
            // 
            this.cbAddMany.AutoSize = true;
            this.cbAddMany.Location = new System.Drawing.Point(250, 58);
            this.cbAddMany.Name = "cbAddMany";
            this.cbAddMany.Size = new System.Drawing.Size(141, 17);
            this.cbAddMany.TabIndex = 11;
            this.cbAddMany.Text = "Xóa nhiều trường dữ liệu";
            this.cbAddMany.UseVisualStyleBackColor = true;
            this.cbAddMany.CheckedChanged += new System.EventHandler(this.cbAddMany_CheckedChanged);
            // 
            // cbAddOne
            // 
            this.cbAddOne.AutoSize = true;
            this.cbAddOne.Location = new System.Drawing.Point(62, 58);
            this.cbAddOne.Name = "cbAddOne";
            this.cbAddOne.Size = new System.Drawing.Size(115, 17);
            this.cbAddOne.TabIndex = 10;
            this.cbAddOne.Text = "Xóa 1 bảng dữ liệu";
            this.cbAddOne.UseVisualStyleBackColor = true;
            this.cbAddOne.CheckedChanged += new System.EventHandler(this.cbAddOne_CheckedChanged_1);
            // 
            // DeleteObjMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 165);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbAddMany);
            this.Controls.Add(this.cbAddOne);
            this.Name = "DeleteObjMng";
            this.Text = "Xóa dữ liệu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteObjMng_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbAddMany;
        private System.Windows.Forms.CheckBox cbAddOne;
    }
}