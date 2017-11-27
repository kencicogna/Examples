namespace InventoryTest.Views
{
    partial class ProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.button1 = new System.Windows.Forms.Button();
            this.clbVariations = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbBinRack = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbSKU = new System.Windows.Forms.TextBox();
            this.iboxProduct = new System.Windows.Forms.PictureBox();
            this.lblPicturURL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iboxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 68);
            this.button1.TabIndex = 24;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clbVariations
            // 
            this.clbVariations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbVariations.FormattingEnabled = true;
            this.clbVariations.Location = new System.Drawing.Point(249, 150);
            this.clbVariations.Name = "clbVariations";
            this.clbVariations.Size = new System.Drawing.Size(244, 259);
            this.clbVariations.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Variations";
            // 
            // tbCost
            // 
            this.tbCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCost.Location = new System.Drawing.Point(249, 110);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(244, 20);
            this.tbCost.TabIndex = 20;
            // 
            // tbBinRack
            // 
            this.tbBinRack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinRack.Location = new System.Drawing.Point(249, 78);
            this.tbBinRack.Name = "tbBinRack";
            this.tbBinRack.Size = new System.Drawing.Size(244, 20);
            this.tbBinRack.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "BinRack";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "SKU";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 20);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Product title goes here";
            // 
            // tbSKU
            // 
            this.tbSKU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSKU.Location = new System.Drawing.Point(249, 40);
            this.tbSKU.Name = "tbSKU";
            this.tbSKU.Size = new System.Drawing.Size(244, 20);
            this.tbSKU.TabIndex = 15;
            // 
            // iboxProduct
            // 
            this.iboxProduct.Image = ((System.Drawing.Image)(resources.GetObject("iboxProduct.Image")));
            this.iboxProduct.InitialImage = ((System.Drawing.Image)(resources.GetObject("iboxProduct.InitialImage")));
            this.iboxProduct.Location = new System.Drawing.Point(9, 40);
            this.iboxProduct.Name = "iboxProduct";
            this.iboxProduct.Size = new System.Drawing.Size(175, 175);
            this.iboxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iboxProduct.TabIndex = 14;
            this.iboxProduct.TabStop = false;
            // 
            // lblPicturURL
            // 
            this.lblPicturURL.AutoSize = true;
            this.lblPicturURL.Location = new System.Drawing.Point(10, 241);
            this.lblPicturURL.Name = "lblPicturURL";
            this.lblPicturURL.Size = new System.Drawing.Size(72, 13);
            this.lblPicturURL.TabIndex = 25;
            this.lblPicturURL.Text = "lblPictureURL";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPicturURL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clbVariations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbBinRack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbSKU);
            this.Controls.Add(this.iboxProduct);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(496, 412);
            ((System.ComponentModel.ISupportInitialize)(this.iboxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox clbVariations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbBinRack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbSKU;
        private System.Windows.Forms.PictureBox iboxProduct;
        private System.Windows.Forms.Label lblPicturURL;
    }
}
