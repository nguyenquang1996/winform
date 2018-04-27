namespace QuanLyQuanCaFe
{
    partial class fTableManager
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
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbChuyenBan = new System.Windows.Forms.ComboBox();
            this.bntchuyenban = new System.Windows.Forms.Button();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.bntGiamGia = new System.Windows.Forms.Button();
            this.bntCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.bntThem = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCatogory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(439, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 195);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(4, 4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(386, 188);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.List;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChuyenBan);
            this.panel3.Controls.Add(this.bntchuyenban);
            this.panel3.Controls.Add(this.nmGiamGia);
            this.panel3.Controls.Add(this.bntGiamGia);
            this.panel3.Controls.Add(this.bntCheckOut);
            this.panel3.Location = new System.Drawing.Point(435, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 92);
            this.panel3.TabIndex = 3;
            // 
            // cbChuyenBan
            // 
            this.cbChuyenBan.FormattingEnabled = true;
            this.cbChuyenBan.Location = new System.Drawing.Point(4, 56);
            this.cbChuyenBan.Name = "cbChuyenBan";
            this.cbChuyenBan.Size = new System.Drawing.Size(75, 27);
            this.cbChuyenBan.TabIndex = 7;
            // 
            // bntchuyenban
            // 
            this.bntchuyenban.Location = new System.Drawing.Point(4, 3);
            this.bntchuyenban.Name = "bntchuyenban";
            this.bntchuyenban.Size = new System.Drawing.Size(75, 34);
            this.bntchuyenban.TabIndex = 6;
            this.bntchuyenban.Text = "chuyển bàn";
            this.bntchuyenban.UseVisualStyleBackColor = true;
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Location = new System.Drawing.Point(228, 57);
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(75, 26);
            this.nmGiamGia.TabIndex = 5;
            this.nmGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmGiamGia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bntGiamGia
            // 
            this.bntGiamGia.Location = new System.Drawing.Point(228, 17);
            this.bntGiamGia.Name = "bntGiamGia";
            this.bntGiamGia.Size = new System.Drawing.Size(75, 34);
            this.bntGiamGia.TabIndex = 4;
            this.bntGiamGia.Text = "giảm giá";
            this.bntGiamGia.UseVisualStyleBackColor = true;
            // 
            // bntCheckOut
            // 
            this.bntCheckOut.Location = new System.Drawing.Point(309, 17);
            this.bntCheckOut.Name = "bntCheckOut";
            this.bntCheckOut.Size = new System.Drawing.Size(75, 72);
            this.bntCheckOut.TabIndex = 3;
            this.bntCheckOut.Text = "Thanh Toán";
            this.bntCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.bntThem);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCatogory);
            this.panel4.Location = new System.Drawing.Point(439, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 99);
            this.panel4.TabIndex = 4;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(212, 5);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(43, 26);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFoodCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(131, 4);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 72);
            this.bntThem.TabIndex = 2;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(4, 49);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 27);
            this.cbFood.TabIndex = 1;
            // 
            // cbCatogory
            // 
            this.cbCatogory.FormattingEnabled = true;
            this.cbCatogory.Location = new System.Drawing.Point(4, 4);
            this.cbCatogory.Name = "cbCatogory";
            this.cbCatogory.Size = new System.Drawing.Size(121, 27);
            this.cbCatogory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(13, 32);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(416, 390);
            this.flpTable.TabIndex = 5;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id food";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "count";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 434);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán cà phê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCatogory;
        private System.Windows.Forms.ComboBox cbChuyenBan;
        private System.Windows.Forms.Button bntchuyenban;
        private System.Windows.Forms.NumericUpDown nmGiamGia;
        private System.Windows.Forms.Button bntGiamGia;
        private System.Windows.Forms.Button bntCheckOut;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}