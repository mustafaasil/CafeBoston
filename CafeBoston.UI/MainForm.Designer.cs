namespace CafeBoston.UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.tsmiProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwTables = new System.Windows.Forms.ListView();
            this.ımlTables = new System.Windows.Forms.ImageList(this.components);
            this.msTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTop
            // 
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProduct,
            this.tsmiOrderHistory});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(600, 24);
            this.msTop.TabIndex = 0;
            this.msTop.Text = "menuStrip1";
            // 
            // tsmiProduct
            // 
            this.tsmiProduct.BackColor = System.Drawing.Color.GreenYellow;
            this.tsmiProduct.Name = "tsmiProduct";
            this.tsmiProduct.Size = new System.Drawing.Size(61, 20);
            this.tsmiProduct.Text = "Product";
            this.tsmiProduct.Click += new System.EventHandler(this.tsmiProduct_Click);
            // 
            // tsmiOrderHistory
            // 
            this.tsmiOrderHistory.BackColor = System.Drawing.Color.GreenYellow;
            this.tsmiOrderHistory.Name = "tsmiOrderHistory";
            this.tsmiOrderHistory.Size = new System.Drawing.Size(90, 20);
            this.tsmiOrderHistory.Text = "Order History";
            this.tsmiOrderHistory.Click += new System.EventHandler(this.tsmiOrderHistory_Click);
            // 
            // lvwTables
            // 
            this.lvwTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTables.LargeImageList = this.ımlTables;
            this.lvwTables.Location = new System.Drawing.Point(0, 24);
            this.lvwTables.Name = "lvwTables";
            this.lvwTables.Size = new System.Drawing.Size(600, 469);
            this.lvwTables.TabIndex = 1;
            this.lvwTables.UseCompatibleStateImageBehavior = false;
            this.lvwTables.DoubleClick += new System.EventHandler(this.lvwTables_DoubleClick);
            // 
            // ımlTables
            // 
            this.ımlTables.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımlTables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımlTables.ImageStream")));
            this.ımlTables.TransparentColor = System.Drawing.Color.Transparent;
            this.ımlTables.Images.SetKeyName(0, "empty");
            this.ımlTables.Images.SetKeyName(1, "full");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 493);
            this.Controls.Add(this.lvwTables);
            this.Controls.Add(this.msTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.msTop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(616, 532);
            this.Name = "MainForm";
            this.Text = "Cafe Boston";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msTop;
        private ToolStripMenuItem tsmiProduct;
        private ToolStripMenuItem tsmiOrderHistory;
        private ListView lvwTables;
        private ImageList ımlTables;
    }
}