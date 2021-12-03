
namespace QLHS
{
    partial class frmThemCa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgridviewNhanVien = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viTriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookstoreDataSet2 = new QLHS.BookstoreDataSet2();
            this.nhanVienTableAdapter = new QLHS.BookstoreDataSet2TableAdapters.NhanVienTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.btnThemCa = new System.Windows.Forms.Button();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLamViecNV = new System.Windows.Forms.DateTimePicker();
            this.panel19 = new System.Windows.Forms.Panel();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtEmailNV = new System.Windows.Forms.TextBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtGioiTinhNV = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvwEveningShift = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.lvwAfternoonShift = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.lvwMorningShift = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimeOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgridviewNhanVien);
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 458);
            this.panel1.TabIndex = 0;
            // 
            // dtgridviewNhanVien
            // 
            this.dtgridviewNhanVien.AllowUserToOrderColumns = true;
            this.dtgridviewNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridviewNhanVien.AutoGenerateColumns = false;
            this.dtgridviewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridviewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.viTriDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.matkhauDataGridViewTextBoxColumn});
            this.dtgridviewNhanVien.DataSource = this.nhanVienBindingSource;
            this.dtgridviewNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dtgridviewNhanVien.Name = "dtgridviewNhanVien";
            this.dtgridviewNhanVien.Size = new System.Drawing.Size(841, 456);
            this.dtgridviewNhanVien.TabIndex = 50;
            this.dtgridviewNhanVien.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgridviewNhanVien_RowHeaderMouseClick);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "maNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "tenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "Tên nhân viên";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // viTriDataGridViewTextBoxColumn
            // 
            this.viTriDataGridViewTextBoxColumn.DataPropertyName = "viTri";
            this.viTriDataGridViewTextBoxColumn.HeaderText = "Vị trí";
            this.viTriDataGridViewTextBoxColumn.Name = "viTriDataGridViewTextBoxColumn";
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // matkhauDataGridViewTextBoxColumn
            // 
            this.matkhauDataGridViewTextBoxColumn.DataPropertyName = "matkhau";
            this.matkhauDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
            this.matkhauDataGridViewTextBoxColumn.Name = "matkhauDataGridViewTextBoxColumn";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.bookstoreDataSet2;
            // 
            // bookstoreDataSet2
            // 
            this.bookstoreDataSet2.DataSetName = "BookstoreDataSet2";
            this.bookstoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.txtTimKiemNhanVien);
            this.panel2.Controls.Add(this.btnThemCa);
            this.panel2.Controls.Add(this.cbbCa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateLamViecNV);
            this.panel2.Controls.Add(this.panel19);
            this.panel2.Controls.Add(this.txtViTri);
            this.panel2.Controls.Add(this.panel18);
            this.panel2.Controls.Add(this.panel17);
            this.panel2.Controls.Add(this.txtEmailNV);
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.txtGioiTinhNV);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.txtSDTNV);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.txtTenNV);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label39);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.label36);
            this.panel2.Controls.Add(this.label37);
            this.panel2.Location = new System.Drawing.Point(849, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 454);
            this.panel2.TabIndex = 1;
            // 
            // txtTimKiemNhanVien
            // 
            this.txtTimKiemNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTimKiemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemNhanVien.Location = new System.Drawing.Point(0, 428);
            this.txtTimKiemNhanVien.Name = "txtTimKiemNhanVien";
            this.txtTimKiemNhanVien.Size = new System.Drawing.Size(342, 26);
            this.txtTimKiemNhanVien.TabIndex = 107;
            this.txtTimKiemNhanVien.TextChanged += new System.EventHandler(this.txtTimKiemNhanVien_TextChanged);
            // 
            // btnThemCa
            // 
            this.btnThemCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCa.Location = new System.Drawing.Point(51, 324);
            this.btnThemCa.Name = "btnThemCa";
            this.btnThemCa.Size = new System.Drawing.Size(254, 33);
            this.btnThemCa.TabIndex = 106;
            this.btnThemCa.Text = "Thêm";
            this.btnThemCa.UseVisualStyleBackColor = true;
            this.btnThemCa.Click += new System.EventHandler(this.btnThemCa_Click);
            // 
            // cbbCa
            // 
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Items.AddRange(new object[] {
            "Sáng",
            "Chiều",
            "Tối"});
            this.cbbCa.Location = new System.Drawing.Point(129, 297);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(120, 21);
            this.cbbCa.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 104;
            this.label1.Text = "Ca:";
            // 
            // dateLamViecNV
            // 
            this.dateLamViecNV.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLamViecNV.Location = new System.Drawing.Point(130, 209);
            this.dateLamViecNV.Name = "dateLamViecNV";
            this.dateLamViecNV.Size = new System.Drawing.Size(179, 20);
            this.dateLamViecNV.TabIndex = 103;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Black;
            this.panel19.Location = new System.Drawing.Point(129, 268);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(178, 1);
            this.panel19.TabIndex = 102;
            // 
            // txtViTri
            // 
            this.txtViTri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.Location = new System.Drawing.Point(129, 249);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(179, 16);
            this.txtViTri.TabIndex = 101;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Black;
            this.panel18.Location = new System.Drawing.Point(130, 230);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(178, 1);
            this.panel18.TabIndex = 100;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Location = new System.Drawing.Point(129, 190);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(178, 1);
            this.panel17.TabIndex = 99;
            // 
            // txtEmailNV
            // 
            this.txtEmailNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNV.Location = new System.Drawing.Point(130, 171);
            this.txtEmailNV.Name = "txtEmailNV";
            this.txtEmailNV.Size = new System.Drawing.Size(179, 16);
            this.txtEmailNV.TabIndex = 98;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Black;
            this.panel16.Location = new System.Drawing.Point(127, 149);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(178, 1);
            this.panel16.TabIndex = 97;
            // 
            // txtGioiTinhNV
            // 
            this.txtGioiTinhNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGioiTinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinhNV.Location = new System.Drawing.Point(130, 130);
            this.txtGioiTinhNV.Name = "txtGioiTinhNV";
            this.txtGioiTinhNV.Size = new System.Drawing.Size(179, 16);
            this.txtGioiTinhNV.TabIndex = 96;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Black;
            this.panel15.Location = new System.Drawing.Point(128, 111);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(178, 1);
            this.panel15.TabIndex = 95;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSDTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNV.Location = new System.Drawing.Point(130, 92);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(179, 16);
            this.txtSDTNV.TabIndex = 94;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Location = new System.Drawing.Point(129, 75);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(178, 1);
            this.panel14.TabIndex = 93;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(129, 56);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(179, 16);
            this.txtTenNV.TabIndex = 92;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Location = new System.Drawing.Point(130, 40);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(178, 1);
            this.panel13.TabIndex = 91;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(130, 21);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(179, 16);
            this.txtMaNV.TabIndex = 90;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(25, 247);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(40, 18);
            this.label39.TabIndex = 89;
            this.label39.Text = "Vị trí:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(25, 209);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 18);
            this.label27.TabIndex = 88;
            this.label27.Text = "Ngày làm việc:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(25, 169);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(54, 18);
            this.label33.TabIndex = 87;
            this.label33.Text = "E-mail:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(25, 128);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(66, 18);
            this.label34.TabIndex = 86;
            this.label34.Text = "Giới tính:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(25, 90);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 18);
            this.label35.TabIndex = 85;
            this.label35.Text = "SDT:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(25, 54);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(103, 18);
            this.label36.TabIndex = 84;
            this.label36.Text = "Tên nhân viên:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(25, 19);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(99, 18);
            this.label37.TabIndex = 83;
            this.label37.Text = "Mã nhân viên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvwEveningShift);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lvwAfternoonShift);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lvwMorningShift);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(3, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1188, 376);
            this.panel3.TabIndex = 2;
            // 
            // lvwEveningShift
            // 
            this.lvwEveningShift.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwEveningShift.HideSelection = false;
            this.lvwEveningShift.Location = new System.Drawing.Point(793, 62);
            this.lvwEveningShift.Name = "lvwEveningShift";
            this.lvwEveningShift.Size = new System.Drawing.Size(256, 268);
            this.lvwEveningShift.TabIndex = 12;
            this.lvwEveningShift.UseCompatibleStateImageBehavior = false;
            this.lvwEveningShift.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 3;
            this.columnHeader9.Text = " ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 0;
            this.columnHeader4.Text = "Tên";
            this.columnHeader4.Width = 64;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 1;
            this.columnHeader5.Text = "Giờ kết ca";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 2;
            this.columnHeader6.Text = "Ghi chú";
            this.columnHeader6.Width = 84;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(899, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Ca tối";
            // 
            // lvwAfternoonShift
            // 
            this.lvwAfternoonShift.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwAfternoonShift.HideSelection = false;
            this.lvwAfternoonShift.Location = new System.Drawing.Point(469, 62);
            this.lvwAfternoonShift.Name = "lvwAfternoonShift";
            this.lvwAfternoonShift.Size = new System.Drawing.Size(256, 268);
            this.lvwAfternoonShift.TabIndex = 10;
            this.lvwAfternoonShift.UseCompatibleStateImageBehavior = false;
            this.lvwAfternoonShift.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 3;
            this.columnHeader8.Text = " ";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Tên";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Giờ kết ca";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Ghi chú";
            this.columnHeader3.Width = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(575, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Ca chiều";
            // 
            // lvwMorningShift
            // 
            this.lvwMorningShift.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.colName,
            this.colTimeOut,
            this.colNote});
            this.lvwMorningShift.HideSelection = false;
            this.lvwMorningShift.Location = new System.Drawing.Point(140, 62);
            this.lvwMorningShift.Name = "lvwMorningShift";
            this.lvwMorningShift.Size = new System.Drawing.Size(256, 268);
            this.lvwMorningShift.TabIndex = 8;
            this.lvwMorningShift.UseCompatibleStateImageBehavior = false;
            this.lvwMorningShift.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 3;
            this.columnHeader7.Text = " ";
            // 
            // colName
            // 
            this.colName.DisplayIndex = 0;
            this.colName.Text = "Tên";
            this.colName.Width = 64;
            // 
            // colTimeOut
            // 
            this.colTimeOut.DisplayIndex = 1;
            this.colTimeOut.Text = "Giờ kết ca";
            this.colTimeOut.Width = 93;
            // 
            // colNote
            // 
            this.colNote.DisplayIndex = 2;
            this.colNote.Text = "Ghi chú";
            this.colNote.Width = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ca sáng";
            // 
            // frmThemCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 839);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemCa";
            this.Text = "frmThemCa";
            this.Load += new System.EventHandler(this.frmThemCa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridviewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgridviewNhanVien;
        private BookstoreDataSet2 bookstoreDataSet2;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private BookstoreDataSet2TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viTriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateLamViecNV;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtEmailNV;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtGioiTinhNV;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemCa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvwEveningShift;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lvwAfternoonShift;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView lvwMorningShift;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colTimeOut;
        private System.Windows.Forms.ColumnHeader colNote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTimKiemNhanVien;
    }
}