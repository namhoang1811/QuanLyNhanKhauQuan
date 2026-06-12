using System;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan {
	public partial class FormMenu : Form {
		private string tenNguoiDung;
		public FormMenu(string taiKhoan) {
			InitializeComponent();
			tenNguoiDung = taiKhoan;
			Load += FormMenu_Load;
		}
		private void FormMenu_Load(object sender, EventArgs e) {
			// Mở FormPhuong mặc định ngay khi FormMenu vừa tải xong
			helloUser.Text = $"Xin chào, {tenNguoiDung}";
			MoFormCon(typeof(FormPhuong));
		}
		private void MoFormCon(Type loaiForm) {
			// 1. Kiểm tra xem Form đã mở trong danh sách MdiChildren chưa
			foreach(Form f in MdiChildren) {
				if(f.GetType() == loaiForm) {
					f.Activate(); // Nếu đã mở rồi thì đưa nó lên trên cùng (focus)
					return;
				}
			}
			// 2. Nếu chưa mở, dùng Reflection để khởi tạo và hiển thị Form mới
			Form formMoi = (Form)Activator.CreateInstance(loaiForm);
			formMoi.MdiParent = this; // Chỉ định frmMain là form cha
																
			// --- Tối ưu hiển thị cho Form con ---
			formMoi.FormBorderStyle = FormBorderStyle.None; // Xóa viền và thanh tiêu đề
			formMoi.Dock = DockStyle.Fill;                  // Tự động lấp đầy FormMenu
			formMoi.Show();
		}


		private void MenuPhuong_Click(object sender, EventArgs e) {
			MoFormCon(typeof(FormPhuong));
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

		}
	}
}
