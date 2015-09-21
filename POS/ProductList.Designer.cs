namespace POS
{
    partial class ProductList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridProductlist = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductlist)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.addProductToStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Image = global::POS.Properties.Resources.add;
            this.addNewProductToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(136, 52);
            this.addNewProductToolStripMenuItem.Text = "เพิ่มข้อมูลสินค้า";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // addProductToStoreToolStripMenuItem
            // 
            this.addProductToStoreToolStripMenuItem.Image = global::POS.Properties.Resources.add_page;
            this.addProductToStoreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addProductToStoreToolStripMenuItem.Name = "addProductToStoreToolStripMenuItem";
            this.addProductToStoreToolStripMenuItem.Size = new System.Drawing.Size(148, 52);
            this.addProductToStoreToolStripMenuItem.Text = "เพิ่มสินค้าในสต๊อก";
            
            // 
            // datagridProductlist
            // 
            this.datagridProductlist.AllowUserToAddRows = false;
            this.datagridProductlist.AllowUserToDeleteRows = false;
            this.datagridProductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProductlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridProductlist.Location = new System.Drawing.Point(0, 0);
            this.datagridProductlist.Name = "datagridProductlist";
            this.datagridProductlist.ReadOnly = true;
            this.datagridProductlist.Size = new System.Drawing.Size(705, 339);
            this.datagridProductlist.TabIndex = 1;
            this.datagridProductlist.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClick);
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 339);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.datagridProductlist);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductList";
            this.Text = "รายการสินค้า";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView datagridProductlist;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToStoreToolStripMenuItem;
    }
}