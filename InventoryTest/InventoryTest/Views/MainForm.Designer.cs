namespace InventoryTest
{
    partial class MainForm
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
            this.pnlProductDetailsContainer = new System.Windows.Forms.Panel();
            this.pnlSearchContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlProductDetailsContainer
            // 
            this.pnlProductDetailsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductDetailsContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlProductDetailsContainer.Location = new System.Drawing.Point(16, 116);
            this.pnlProductDetailsContainer.Name = "pnlProductDetailsContainer";
            this.pnlProductDetailsContainer.Size = new System.Drawing.Size(707, 446);
            this.pnlProductDetailsContainer.TabIndex = 2;
            // 
            // pnlSearchContainer
            // 
            this.pnlSearchContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSearchContainer.Location = new System.Drawing.Point(16, 12);
            this.pnlSearchContainer.Name = "pnlSearchContainer";
            this.pnlSearchContainer.Size = new System.Drawing.Size(707, 98);
            this.pnlSearchContainer.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 574);
            this.Controls.Add(this.pnlSearchContainer);
            this.Controls.Add(this.pnlProductDetailsContainer);
            this.Name = "MainForm";
            this.Text = "The Teaching Toy Box - Inventory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlProductDetailsContainer;
        private System.Windows.Forms.Panel pnlSearchContainer;
    }
}

