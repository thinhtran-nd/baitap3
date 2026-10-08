namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboDonVi.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonVi.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapLieu(out decimal donGia))
                return;

            if (TimTheoMa(txtMaVT.Text.Trim()) != null)
            {
                MessageBox.Show("Mã vật tư đã tồn tại trong danh sách!",
                    "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            ListViewItem item = new(txtMaVT.Text.Trim());
            item.SubItems.Add(txtTenVT.Text.Trim());
            item.SubItems.Add(cboDonVi.Text);
            item.SubItems.Add(donGia.ToString("N0"));
            lvVatTu.Items.Add(item);

            XoaNhapLieu();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!KiemTraNhapLieu(out decimal donGia))
                return;

            ListViewItem item = lvVatTu.SelectedItems[0];
            string maMoi = txtMaVT.Text.Trim();

            ListViewItem? trung = TimTheoMa(maMoi);
            if (trung != null && !ReferenceEquals(trung, item))
            {
                MessageBox.Show("Mã vật tư đã tồn tại trong danh sách!",
                    "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            item.Text = maMoi;
            item.SubItems[1].Text = txtTenVT.Text.Trim();
            item.SubItems[2].Text = cboDonVi.Text;
            item.SubItems[3].Text = donGia.ToString("N0");
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvVatTu.Items.Remove(lvVatTu.SelectedItems[0]);
                XoaNhapLieu();
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lvVatTu.Items.Count == 0)
                return;

            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ danh sách?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvVatTu.Items.Clear();
                XoaNhapLieu();
            }
        }

        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvVatTu.SelectedItems[0];
            txtMaVT.Text = item.Text;
            txtTenVT.Text = item.SubItems[1].Text;
            cboDonVi.Text = item.SubItems[2].Text;
            txtDonGia.Text = item.SubItems[3].Text;
        }

        private ListViewItem? TimTheoMa(string maVT)
        {
            foreach (ListViewItem item in lvVatTu.Items)
            {
                if (string.Equals(item.Text, maVT, StringComparison.OrdinalIgnoreCase))
                    return item;
            }
            return null;
        }

        private bool KiemTraNhapLieu(out decimal donGia)
        {
            donGia = 0;

            if (string.IsNullOrWhiteSpace(txtMaVT.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã vật tư!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên vật tư!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return false;
            }

            if (cboDonVi.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Đơn vị tính!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDonVi.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDonGia.Text.Replace(",", "").Replace(".", ""), out donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm!",
                    "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }

            return true;
        }

        private void XoaNhapLieu()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cboDonVi.SelectedIndex = 0;
            txtDonGia.Clear();
            txtMaVT.Focus();
        }
    }
}
