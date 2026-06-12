using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan
{
    public partial class FormToDanPho : Form
    {
        public FormToDanPho()
        {
            InitializeComponent();
        }

        private void FormToDanPho_Load(object sender, EventArgs e)
        {
            Db.NapComboBox(
                cboPhuong,
                "SELECT MaPhuong, TenPhuong FROM tblPhuong ORDER BY TenPhuong",
                "TenPhuong",
                "MaPhuong");

            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            dgvToDanPho.DataSource = Db.LayDuLieu(
                "SELECT " +
                "t.MaToDanPho, " +
                "t.TenToDanPho, " +
                "p.TenPhuong, " +
                "t.CSKV, " +
                "t.ToTruong, " +
                "t.DienThoai, " +
                "t.GhiChu " +
                "FROM tblToDanPho t " +
                "INNER JOIN tblPhuong p ON t.MaPhuong = p.MaPhuong " +
                "ORDER BY t.MaToDanPho");
        }

        private bool KiemTraDuLieu()
        {
            if (!Db.KiemTraTrong(txtMaToDanPho, "mã tổ dân phố"))
            {
                return false;
            }

            if (!Db.KiemTraTrong(txtTenToDanPho, "tên tổ dân phố"))
            {
                return false;
            }

            if (!Db.KiemTraChon(cboPhuong, "phường"))
            {
                return false;
            }

            if (!Db.KiemTraTrong(txtCSKV, "cảnh sát khu vực"))
            {
                return false;
            }

            if (!Db.KiemTraTrong(txtToTruong, "tổ trưởng"))
            {
                return false;
            }

            if (!Db.KiemTraTrong(txtDienThoai, "điện thoại"))
            {
                return false;
            }

            if (!Db.KiemTraSoDienThoai(txtDienThoai))
            {
                return false;
            }

            return true;
        }

        private void XoaTrang()
        {
            txtMaToDanPho.Clear();
            txtTenToDanPho.Clear();

            if (cboPhuong.Items.Count > 0)
            {
                cboPhuong.SelectedIndex = -1;
            }

            txtCSKV.Clear();
            txtToTruong.Clear();
            txtDienThoai.Clear();
            txtGhiChu.Clear();

            txtMaToDanPho.Enabled = true;
            txtMaToDanPho.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu())
                {
                    return;
                }

                Db.ThucThiSP(
                    "sp_ToDanPho_Them",
                    new SqlParameter("@MaToDanPho", txtMaToDanPho.Text.Trim()),
                    new SqlParameter("@TenToDanPho", txtTenToDanPho.Text.Trim()),
                    new SqlParameter("@MaPhuong", cboPhuong.SelectedValue.ToString()),
                    new SqlParameter("@CSKV", txtCSKV.Text.Trim()),
                    new SqlParameter("@ToTruong", txtToTruong.Text.Trim()),
                    new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()),
                    new SqlParameter("@GhiChu", txtGhiChu.Text.Trim()));

                MessageBox.Show(
                    "Thêm tổ dân phố thành công.",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDuLieu();
                XoaTrang();
            }
            catch (SqlException ex)
            {
                Db.BaoLoi(ex);
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
                if (!KiemTraDuLieu())
                {
                    return;
                }

                Db.ThucThiSP(
                    "sp_ToDanPho_Sua",
                    new SqlParameter("@MaToDanPho", txtMaToDanPho.Text.Trim()),
                    new SqlParameter("@TenToDanPho", txtTenToDanPho.Text.Trim()),
                    new SqlParameter("@MaPhuong", cboPhuong.SelectedValue.ToString()),
                    new SqlParameter("@CSKV", txtCSKV.Text.Trim()),
                    new SqlParameter("@ToTruong", txtToTruong.Text.Trim()),
                    new SqlParameter("@DienThoai", txtDienThoai.Text.Trim()),
                    new SqlParameter("@GhiChu", txtGhiChu.Text.Trim()));

                MessageBox.Show(
                    "Cập nhật tổ dân phố thành công.",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDuLieu();
            }
            catch (SqlException ex)
            {
                Db.BaoLoi(ex);
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
                if (!Db.KiemTraTrong(txtMaToDanPho, "mã tổ dân phố cần xóa"))
                {
                    return;
                }

                bool xacNhan = MessageBox.Show(
                    "Xóa tổ dân phố sẽ bị chặn nếu đã có nhân khẩu. Bạn muốn tiếp tục?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

                if (!xacNhan)
                {
                    return;
                }

                Db.ThucThiSP(
                    "sp_ToDanPho_Xoa",
                    new SqlParameter("@MaToDanPho", txtMaToDanPho.Text.Trim()));

                MessageBox.Show(
                    "Xóa tổ dân phố thành công.",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TaiDuLieu();
                XoaTrang();
            }
            catch (SqlException ex)
            {
                Db.BaoLoi(ex);
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

        private void dgvToDanPho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dgvToDanPho.Rows[e.RowIndex];

            txtMaToDanPho.Text = Convert.ToString(row.Cells["MaToDanPho"].Value);
            txtTenToDanPho.Text = Convert.ToString(row.Cells["TenToDanPho"].Value);
            cboPhuong.Text = Convert.ToString(row.Cells["TenPhuong"].Value);
            txtCSKV.Text = Convert.ToString(row.Cells["CSKV"].Value);
            txtToTruong.Text = Convert.ToString(row.Cells["ToTruong"].Value);
            txtDienThoai.Text = Convert.ToString(row.Cells["DienThoai"].Value);
            txtGhiChu.Text = Convert.ToString(row.Cells["GhiChu"].Value);

            txtMaToDanPho.Enabled = false;
        }
    }
}