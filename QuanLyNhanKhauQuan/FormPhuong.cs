using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan
{
    public partial class FormPhuong : Form
    {
        public FormPhuong()
        {
            InitializeComponent();
        }

        private void FormPhuong_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            dgvPhuong.DataSource = Db.LayDuLieu("SELECT MaPhuong, TenPhuong, DienThoai, DiaChi, GhiChu FROM tblPhuong ORDER BY MaPhuong");
        }

        private bool KiemTraDuLieu()
        {
            if (!Db.KiemTraTrong(txtMaPhuong, "mã phường")) return false;
            if (!Db.KiemTraTrong(txtTenPhuong, "tên phường")) return false;
            if (!Db.KiemTraTrong(txtDienThoai, "điện thoại")) return false;
            if (!Db.KiemTraSoDienThoai(txtDienThoai)) return false;
            if (!Db.KiemTraTrong(txtDiaChi, "địa chỉ")) return false;
            return true;
        }

        private void XoaTrang()
        {
            txtMaPhuong.Clear();
            txtTenPhuong.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtGhiChu.Clear();
            txtMaPhuong.Enabled = true;
            txtMaPhuong.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu()) return;
                Db.ThucThiSP("sp_Phuong_Them", new SqlParameter("@MaPhuong", txtMaPhuong.Text.Trim()), new SqlParameter("@TenPhuong", txtTenPhuong.Text.Trim()), new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()), new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()), new SqlParameter("@GhiChu", txtGhiChu.Text.Trim()));
                Db.ThongBao("Thêm phường thành công.");
                TaiDuLieu();
                XoaTrang();
            }
            catch (Exception ex)
            {
                Db.BaoLoi(ex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu()) return;
                Db.ThucThiSP("sp_Phuong_Sua", new SqlParameter("@MaPhuong", txtMaPhuong.Text.Trim()), new SqlParameter("@TenPhuong", txtTenPhuong.Text.Trim()), new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()), new SqlParameter("@DiaChi", txtDiaChi.Text.Trim()), new SqlParameter("@GhiChu", txtGhiChu.Text.Trim()));
                Db.ThongBao("Cập nhật phường thành công.");
                TaiDuLieu();
            }
            catch (Exception ex)
            {
                Db.BaoLoi(ex);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Db.KiemTraTrong(txtMaPhuong, "mã phường cần xóa")) return;
                if (!Db.Hoi("Xóa phường sẽ bị chặn nếu đã có tổ dân phố. Bạn muốn tiếp tục?")) return;
                Db.ThucThiSP("sp_Phuong_Xoa", new SqlParameter("@MaPhuong", txtMaPhuong.Text.Trim()));
                Db.ThongBao("Xóa phường thành công.");
                TaiDuLieu();
                XoaTrang();
            }
            catch (Exception ex)
            {
                Db.BaoLoi(ex);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrang();
            TaiDuLieu();
        }

        private void dgvPhuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPhuong.Rows[e.RowIndex];
            txtMaPhuong.Text = Convert.ToString(row.Cells["MaPhuong"].Value);
            txtTenPhuong.Text = Convert.ToString(row.Cells["TenPhuong"].Value);
            txtDienThoai.Text = Convert.ToString(row.Cells["DienThoai"].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            txtGhiChu.Text = Convert.ToString(row.Cells["GhiChu"].Value);
            txtMaPhuong.Enabled = false;
        }
    }
}
