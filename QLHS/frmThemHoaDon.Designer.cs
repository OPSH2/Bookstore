
namespace QLHS
{
    partial class frmThemHoaDon
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
            this.sanPhamTableAdapter1 = new QLHS.BookstoreDataSetTableAdapters.SanPhamTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrdvwSP_HD = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangMucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet = new QLHS.BookstoreDataSet();
            this.txtTimKiemSPHD = new System.Windows.Forms.TextBox();
            this.sanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter1 = new QLHS.BookstoreDataSet1TableAdapters.KhachHangTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgridvwCTHD = new System.Windows.Forms.DataGridView();
            this.colMaSPCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTienCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.btnLoaiBo = new System.Windows.Forms.Button();
            this.numericSoLuong = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemCTHD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSP_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvwCTHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sanPhamTableAdapter1
            // 
            this.sanPhamTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dtgrdvwSP_HD);
            this.groupBox1.Controls.Add(this.txtTimKiemSPHD);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 684);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // dtgrdvwSP_HD
            // 
            this.dtgrdvwSP_HD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdvwSP_HD.AutoGenerateColumns = false;
            this.dtgrdvwSP_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwSP_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.hangMucDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.donViDataGridViewTextBoxColumn});
            this.dtgrdvwSP_HD.DataSource = this.sanPhamBindingSource2;
            this.dtgrdvwSP_HD.Location = new System.Drawing.Point(15, 24);
            this.dtgrdvwSP_HD.Name = "dtgrdvwSP_HD";
            this.dtgrdvwSP_HD.Size = new System.Drawing.Size(527, 579);
            this.dtgrdvwSP_HD.TabIndex = 2;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "maSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.Width = 21;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "tenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.Width = 21;
            // 
            // hangMucDataGridViewTextBoxColumn
            // 
            this.hangMucDataGridViewTextBoxColumn.DataPropertyName = "hangMuc";
            this.hangMucDataGridViewTextBoxColumn.HeaderText = "Hạng mục";
            this.hangMucDataGridViewTextBoxColumn.Name = "hangMucDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "donGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.Width = 21;
            // 
            // donViDataGridViewTextBoxColumn
            // 
            this.donViDataGridViewTextBoxColumn.DataPropertyName = "donVi";
            this.donViDataGridViewTextBoxColumn.HeaderText = "Đơn vị";
            this.donViDataGridViewTextBoxColumn.Name = "donViDataGridViewTextBoxColumn";
            // 
            // sanPhamBindingSource2
            // 
            this.sanPhamBindingSource2.DataMember = "SanPham";
            this.sanPhamBindingSource2.DataSource = this.bookstoreDataSet;
            // 
            // bookstoreDataSet
            // 
            this.bookstoreDataSet.DataSetName = "BookstoreDataSet";
            this.bookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTimKiemSPHD
            // 
            this.txtTimKiemSPHD.Location = new System.Drawing.Point(14, 628);
            this.txtTimKiemSPHD.Name = "txtTimKiemSPHD";
            this.txtTimKiemSPHD.Size = new System.Drawing.Size(529, 26);
            this.txtTimKiemSPHD.TabIndex = 1;
            this.txtTimKiemSPHD.Text = "Tìm kiếm sản phẩm muốn tìm";
            this.txtTimKiemSPHD.TextChanged += new System.EventHandler(this.txtTimKiemSPHD_TextChanged);
            // 
            // sanPhamBindingSource1
            // 
            this.sanPhamBindingSource1.DataMember = "SanPham";
            this.sanPhamBindingSource1.DataSource = this.bookstoreDataSet;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.bookstoreDataSet;
            // 
            // khachHangTableAdapter1
            // 
            this.khachHangTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(548, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 684);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtgridvwCTHD);
            this.groupBox3.Location = new System.Drawing.Point(3, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1215, 296);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm đã chọn";
            // 
            // dtgridvwCTHD
            // 
            this.dtgridvwCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtgridvwCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridvwCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSPCTHD,
            this.colSoLuongCTHD,
            this.colDonGiaCTHD,
            this.colTongTienCT});
            this.dtgridvwCTHD.Location = new System.Drawing.Point(4, 25);
            this.dtgridvwCTHD.Name = "dtgridvwCTHD";
            this.dtgridvwCTHD.RowTemplate.ReadOnly = true;
            this.dtgridvwCTHD.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridvwCTHD.Size = new System.Drawing.Size(693, 259);
            this.dtgridvwCTHD.TabIndex = 1;
            // 
            // colMaSPCTHD
            // 
            this.colMaSPCTHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaSPCTHD.HeaderText = "Mã sản phẩm";
            this.colMaSPCTHD.Name = "colMaSPCTHD";
            this.colMaSPCTHD.ReadOnly = true;
            this.colMaSPCTHD.Width = 130;
            // 
            // colSoLuongCTHD
            // 
            this.colSoLuongCTHD.HeaderText = "Số lượng";
            this.colSoLuongCTHD.Name = "colSoLuongCTHD";
            // 
            // colDonGiaCTHD
            // 
            this.colDonGiaCTHD.HeaderText = "Đơn giá";
            this.colDonGiaCTHD.Name = "colDonGiaCTHD";
            // 
            // colTongTienCT
            // 
            this.colTongTienCT.HeaderText = "Tổng tiền";
            this.colTongTienCT.Name = "colTongTienCT";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.btnHoanThanh);
            this.groupBox2.Controls.Add(this.btnLoaiBo);
            this.groupBox2.Controls.Add(this.numericSoLuong);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.txtmaHD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnThemCTHD);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.txtMaKH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 386);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHoanThanh.Location = new System.Drawing.Point(422, 316);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(170, 43);
            this.btnHoanThanh.TabIndex = 19;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // btnLoaiBo
            // 
            this.btnLoaiBo.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLoaiBo.Location = new System.Drawing.Point(226, 316);
            this.btnLoaiBo.Name = "btnLoaiBo";
            this.btnLoaiBo.Size = new System.Drawing.Size(170, 43);
            this.btnLoaiBo.TabIndex = 18;
            this.btnLoaiBo.Text = "Loại bỏ";
            this.btnLoaiBo.UseVisualStyleBackColor = false;
            this.btnLoaiBo.Click += new System.EventHandler(this.btnLoaiBo_Click);
            // 
            // numericSoLuong
            // 
            this.numericSoLuong.BackColor = System.Drawing.Color.PowderBlue;
            this.numericSoLuong.Location = new System.Drawing.Point(244, 251);
            this.numericSoLuong.Name = "numericSoLuong";
            this.numericSoLuong.Size = new System.Drawing.Size(120, 26);
            this.numericSoLuong.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(21, 276);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 1);
            this.panel4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(15, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số lượng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::QLHS.Properties.Resources.random_icon;
            this.pictureBox1.Location = new System.Drawing.Point(366, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(17, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 1);
            this.panel3.TabIndex = 12;
            // 
            // txtmaHD
            // 
            this.txtmaHD.BackColor = System.Drawing.Color.PowderBlue;
            this.txtmaHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmaHD.Location = new System.Drawing.Point(144, 216);
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(212, 19);
            this.txtmaHD.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(14, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã hóa đơn";
            // 
            // btnThemCTHD
            // 
            this.btnThemCTHD.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnThemCTHD.Location = new System.Drawing.Point(31, 316);
            this.btnThemCTHD.Name = "btnThemCTHD";
            this.btnThemCTHD.Size = new System.Drawing.Size(170, 43);
            this.btnThemCTHD.TabIndex = 9;
            this.btnThemCTHD.Text = "Chọn sản phẩm";
            this.btnThemCTHD.UseVisualStyleBackColor = false;
            this.btnThemCTHD.Click += new System.EventHandler(this.btnThemCTHD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(15, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 1);
            this.panel2.TabIndex = 8;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.PowderBlue;
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenKH.Location = new System.Drawing.Point(143, 139);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(212, 19);
            this.txtTenKH.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên khách hàng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Location = new System.Drawing.Point(13, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 1);
            this.panel5.TabIndex = 5;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.PowderBlue;
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKH.Location = new System.Drawing.Point(140, 94);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(212, 19);
            this.txtMaKH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã khách hàng";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::QLHS.Properties.Resources.add_icon_png_2471_Windows;
            this.button1.Location = new System.Drawing.Point(358, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SDT khách hàng:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // frmThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLHS.Properties.Resources._1633280963_920_Hinh_anh_PowerPoint_dep;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemHoaDon";
            this.Text = "frmThemHoaDon";
            this.Load += new System.EventHandler(this.frmThemHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSP_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridvwCTHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookstoreDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private BookstoreDataSet bookstoreDataSet;
        private BookstoreDataSet1TableAdapters.KhachHangTableAdapter khachHangTableAdapter1;
        private System.Windows.Forms.TextBox txtTimKiemSPHD;
        private System.Windows.Forms.BindingSource sanPhamBindingSource1;
        private System.Windows.Forms.DataGridView dtgrdvwSP_HD;
        private System.Windows.Forms.BindingSource sanPhamBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangMucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgridvwCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSPCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTienCT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericSoLuong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemCTHD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Button btnLoaiBo;
    }
}