namespace bai3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
            lblMaVT = new Label();
            txtMaVT = new TextBox();
            lblTenVT = new Label();
            txtTenVT = new TextBox();
            lblDonVi = new Label();
            cboDonVi = new ComboBox();
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoaDong = new Button();
            btnXoaTatCa = new Button();
            grpDanhSach = new GroupBox();
            lvVatTu = new ListView();
            colMaVT = new ColumnHeader();
            colTenVT = new ColumnHeader();
            colDonVi = new ColumnHeader();
            colDonGia = new ColumnHeader();
            grpThongTin.SuspendLayout();
            grpDanhSach.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblMaVT);
            grpThongTin.Controls.Add(txtMaVT);
            grpThongTin.Controls.Add(lblTenVT);
            grpThongTin.Controls.Add(txtTenVT);
            grpThongTin.Controls.Add(lblDonVi);
            grpThongTin.Controls.Add(cboDonVi);
            grpThongTin.Controls.Add(lblDonGia);
            grpThongTin.Controls.Add(txtDonGia);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(285, 180);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin vật tư";
            // 
            // lblMaVT
            // 
            lblMaVT.AutoSize = true;
            lblMaVT.Location = new Point(6, 30);
            lblMaVT.Name = "lblMaVT";
            lblMaVT.Size = new Size(75, 20);
            lblMaVT.TabIndex = 0;
            lblMaVT.Text = "Mã vật tư:";
            // 
            // txtMaVT
            // 
            txtMaVT.Location = new Point(105, 30);
            txtMaVT.Name = "txtMaVT";
            txtMaVT.Size = new Size(165, 27);
            txtMaVT.TabIndex = 1;
            // 
            // lblTenVT
            // 
            lblTenVT.AutoSize = true;
            lblTenVT.Location = new Point(6, 71);
            lblTenVT.Name = "lblTenVT";
            lblTenVT.Size = new Size(77, 20);
            lblTenVT.TabIndex = 2;
            lblTenVT.Text = "Tên vật tư:";
            // 
            // txtTenVT
            // 
            txtTenVT.Location = new Point(105, 68);
            txtTenVT.Name = "txtTenVT";
            txtTenVT.Size = new Size(165, 27);
            txtTenVT.TabIndex = 3;
            // 
            // lblDonVi
            // 
            lblDonVi.AutoSize = true;
            lblDonVi.Location = new Point(0, 109);
            lblDonVi.Name = "lblDonVi";
            lblDonVi.Size = new Size(84, 20);
            lblDonVi.TabIndex = 4;
            lblDonVi.Text = "Đơn vị tính:";
            // 
            // cboDonVi
            // 
            cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Location = new Point(105, 106);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(165, 28);
            cboDonVi.TabIndex = 5;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(-3, 147);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(102, 20);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn giá nhập:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(105, 144);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(165, 27);
            txtDonGia.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 205);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(137, 35);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(160, 205);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 35);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(12, 250);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(137, 35);
            btnXoaDong.TabIndex = 3;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnXoaTatCa
            // 
            btnXoaTatCa.Location = new Point(160, 250);
            btnXoaTatCa.Name = "btnXoaTatCa";
            btnXoaTatCa.Size = new Size(137, 35);
            btnXoaTatCa.TabIndex = 4;
            btnXoaTatCa.Text = "Xóa toàn bộ";
            btnXoaTatCa.UseVisualStyleBackColor = true;
            btnXoaTatCa.Click += btnXoaTatCa_Click;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(lvVatTu);
            grpDanhSach.Location = new Point(310, 12);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(495, 273);
            grpDanhSach.TabIndex = 5;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách vật tư";
            // 
            // lvVatTu
            // 
            lvVatTu.Columns.AddRange(new ColumnHeader[] { colMaVT, colTenVT, colDonVi, colDonGia });
            lvVatTu.Dock = DockStyle.Fill;
            lvVatTu.FullRowSelect = true;
            lvVatTu.GridLines = true;
            lvVatTu.Location = new Point(3, 23);
            lvVatTu.MultiSelect = false;
            lvVatTu.Name = "lvVatTu";
            lvVatTu.Size = new Size(489, 247);
            lvVatTu.TabIndex = 0;
            lvVatTu.UseCompatibleStateImageBehavior = false;
            lvVatTu.View = View.Details;
            lvVatTu.SelectedIndexChanged += lvVatTu_SelectedIndexChanged;
            // 
            // colMaVT
            // 
            colMaVT.Text = "Mã VT";
            colMaVT.Width = 80;
            // 
            // colTenVT
            // 
            colTenVT.Text = "Tên VT";
            colTenVT.Width = 175;
            // 
            // colDonVi
            // 
            colDonVi.Text = "Đơn vị tính";
            colDonVi.Width = 85;
            // 
            // colDonGia
            // 
            colDonGia.Text = "Đơn giá";
            colDonGia.TextAlign = HorizontalAlignment.Right;
            colDonGia.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 297);
            Controls.Add(grpDanhSach);
            Controls.Add(btnXoaTatCa);
            Controls.Add(btnXoaDong);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(grpThongTin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục Vật tư / Linh kiện";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaVT;
        private TextBox txtMaVT;
        private Label lblTenVT;
        private TextBox txtTenVT;
        private Label lblDonVi;
        private ComboBox cboDonVi;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoaDong;
        private Button btnXoaTatCa;
        private GroupBox grpDanhSach;
        private ListView lvVatTu;
        private ColumnHeader colMaVT;
        private ColumnHeader colTenVT;
        private ColumnHeader colDonVi;
        private ColumnHeader colDonGia;
    }
}
