using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan.Forms.BaoCao {
	public partial class FormCRTaiKhoan : Form {
		public FormCRTaiKhoan() {
			InitializeComponent();
		}

		private void RPTaiKhoan_Load(object sender, EventArgs e) {
			try {
				string sql = "SELECT TenDangNhap, HoTen, ViTri, Quyen, DienThoai FROM tblTaiKhoan";
				DataTable dtData = Db.LayDuLieu(sql);
				var rpt = new CRTaiKhoan();
				rpt.SetDataSource(dtData);
				crystalReportViewer1.ReportSource = rpt;
				crystalReportViewer1.Refresh();
			} catch(Exception ex) {
				MessageBox.Show("Lỗi: " + ex.Message);
			}
		}
	}
}
