namespace DuBaoGiaNha
{
    partial class VisualDataMng
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
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.cbBalcony = new System.Windows.Forms.CheckBox();
            this.cbBath = new System.Windows.Forms.CheckBox();
            this.cbTotalSqft = new System.Windows.Forms.CheckBox();
            this.cbSociety = new System.Windows.Forms.CheckBox();
            this.cbSize = new System.Windows.Forms.CheckBox();
            this.cbLoacation = new System.Windows.Forms.CheckBox();
            this.cbAvail = new System.Windows.Forms.CheckBox();
            this.cbArea = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbAddOne
            // 
            this.cbAddOne.AutoSize = true;
            this.cbAddOne.Location = new System.Drawing.Point(44, 64);
            this.cbAddOne.Name = "cbAddOne";
            this.cbAddOne.Size = new System.Drawing.Size(114, 17);
            this.cbAddOne.TabIndex = 10;
            this.cbAddOne.Text = "Biểu đồ tổng quan";
            this.cbAddOne.UseVisualStyleBackColor = true;
            this.cbAddOne.CheckedChanged += new System.EventHandler(this.cbAddOne_CheckedChanged);
            // 
            // cbPrice
            // 
            this.cbPrice.AutoSize = true;
            this.cbPrice.Location = new System.Drawing.Point(268, 248);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(50, 17);
            this.cbPrice.TabIndex = 73;
            this.cbPrice.Text = "Price";
            this.cbPrice.UseVisualStyleBackColor = true;
            // 
            // cbBalcony
            // 
            this.cbBalcony.AutoSize = true;
            this.cbBalcony.Location = new System.Drawing.Point(268, 202);
            this.cbBalcony.Name = "cbBalcony";
            this.cbBalcony.Size = new System.Drawing.Size(64, 17);
            this.cbBalcony.TabIndex = 72;
            this.cbBalcony.Text = "Balcony";
            this.cbBalcony.UseVisualStyleBackColor = true;
            this.cbBalcony.CheckedChanged += new System.EventHandler(this.cbBalcony_CheckedChanged);
            // 
            // cbBath
            // 
            this.cbBath.AutoSize = true;
            this.cbBath.Location = new System.Drawing.Point(268, 159);
            this.cbBath.Name = "cbBath";
            this.cbBath.Size = new System.Drawing.Size(48, 17);
            this.cbBath.TabIndex = 71;
            this.cbBath.Text = "Bath";
            this.cbBath.UseVisualStyleBackColor = true;
            this.cbBath.CheckedChanged += new System.EventHandler(this.cbBath_CheckedChanged);
            // 
            // cbTotalSqft
            // 
            this.cbTotalSqft.AutoSize = true;
            this.cbTotalSqft.Location = new System.Drawing.Point(268, 108);
            this.cbTotalSqft.Name = "cbTotalSqft";
            this.cbTotalSqft.Size = new System.Drawing.Size(72, 17);
            this.cbTotalSqft.TabIndex = 70;
            this.cbTotalSqft.Text = "TotalSqft ";
            this.cbTotalSqft.UseVisualStyleBackColor = true;
            this.cbTotalSqft.CheckedChanged += new System.EventHandler(this.cbTotalSqft_CheckedChanged);
            // 
            // cbSociety
            // 
            this.cbSociety.AutoSize = true;
            this.cbSociety.Location = new System.Drawing.Point(268, 66);
            this.cbSociety.Name = "cbSociety";
            this.cbSociety.Size = new System.Drawing.Size(61, 17);
            this.cbSociety.TabIndex = 69;
            this.cbSociety.Text = "Society";
            this.cbSociety.UseVisualStyleBackColor = true;
            this.cbSociety.CheckedChanged += new System.EventHandler(this.cbSociety_CheckedChanged);
            // 
            // cbSize
            // 
            this.cbSize.AutoSize = true;
            this.cbSize.Location = new System.Drawing.Point(44, 248);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(46, 17);
            this.cbSize.TabIndex = 68;
            this.cbSize.Text = "Size";
            this.cbSize.UseVisualStyleBackColor = true;
            this.cbSize.CheckedChanged += new System.EventHandler(this.cbSize_CheckedChanged);
            // 
            // cbLoacation
            // 
            this.cbLoacation.AutoSize = true;
            this.cbLoacation.Location = new System.Drawing.Point(44, 202);
            this.cbLoacation.Name = "cbLoacation";
            this.cbLoacation.Size = new System.Drawing.Size(67, 17);
            this.cbLoacation.TabIndex = 67;
            this.cbLoacation.Text = "Location";
            this.cbLoacation.UseVisualStyleBackColor = true;
            this.cbLoacation.CheckedChanged += new System.EventHandler(this.cbLoacation_CheckedChanged);
            // 
            // cbAvail
            // 
            this.cbAvail.AutoSize = true;
            this.cbAvail.Location = new System.Drawing.Point(44, 159);
            this.cbAvail.Name = "cbAvail";
            this.cbAvail.Size = new System.Drawing.Size(75, 17);
            this.cbAvail.TabIndex = 66;
            this.cbAvail.Text = "Availability";
            this.cbAvail.UseVisualStyleBackColor = true;
            this.cbAvail.CheckedChanged += new System.EventHandler(this.cbAvail_CheckedChanged);
            // 
            // cbArea
            // 
            this.cbArea.AutoSize = true;
            this.cbArea.Location = new System.Drawing.Point(44, 108);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(75, 17);
            this.cbArea.TabIndex = 56;
            this.cbArea.Text = "Area Type";
            this.cbArea.UseVisualStyleBackColor = true;
            this.cbArea.CheckedChanged += new System.EventHandler(this.cbArea_CheckedChanged);
            // 
            // VisualDataMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 392);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.cbBalcony);
            this.Controls.Add(this.cbBath);
            this.Controls.Add(this.cbTotalSqft);
            this.Controls.Add(this.cbSociety);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbLoacation);
            this.Controls.Add(this.cbAvail);
            this.Controls.Add(this.cbArea);
            this.Controls.Add(this.cbAddOne);
            this.Name = "VisualDataMng";
            this.Text = "VisualDataMng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbAddOne;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.CheckBox cbBalcony;
        private System.Windows.Forms.CheckBox cbBath;
        private System.Windows.Forms.CheckBox cbTotalSqft;
        private System.Windows.Forms.CheckBox cbSociety;
        private System.Windows.Forms.CheckBox cbSize;
        private System.Windows.Forms.CheckBox cbLoacation;
        private System.Windows.Forms.CheckBox cbAvail;
        private System.Windows.Forms.CheckBox cbArea;
    }
}