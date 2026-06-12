using System;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormBaoCao : Form {
		public FormBaoCao() {
			InitializeComponent();
		}

		private void FormBaoCao_Load(object sender, EventArgs e) {
			TaiThongKe();
		}

		private void TaiThongKe() {
			dgvThongKe.DataSource = Db.LayDuLieu(@"
                SELECT 
                    p.TenPhuong,
                    COUNT(DISTINCT t.MaToDanPho) AS SoToDanPho,
                    COUNT(DISTINCT n.MaNhanKhau) AS SoHoKhau,
                    COUNT(pt.MaPhuThuoc) AS SoNguoiPhuThuoc
                FROM tblPhuong p
                LEFT JOIN tblToDanPho t ON p.MaPhuong = t.MaPhuong
                LEFT JOIN tblNhanKhau n ON t.MaToDanPho = n.MaToDanPho
                LEFT JOIN tblNguoiPhuThuoc pt ON n.MaNhanKhau = pt.MaNhanKhau
                GROUP BY p.TenPhuong
                ORDER BY p.TenPhuong");
		}

		private void btnThongKe_Click(object sender, EventArgs e) {
			TaiThongKe();
			Db.ThongBao("Đã tải thống kê mới nhất.");
		}
	}
}
