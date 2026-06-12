using System;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan
{
    public partial class FormMain : Form
    {
        private readonly string tenDangNhap;

        public FormMain(string tenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = tenDangNhap;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblXinChao.Text = "Xin chào: " + tenDangNhap;
        }

        private void MoForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnPhuong_Click(object sender, EventArgs e)
        {
            MoForm(new FormPhuong());
        }

        private void btnToDanPho_Click(object sender, EventArgs e)
        {
            MoForm(new FormToDanPho());
        }

        private void btnNhanKhau_Click(object sender, EventArgs e)
        {
            MoForm(new FormNhanKhau());
        }

        private void btnNguoiPhuThuoc_Click(object sender, EventArgs e)
        {
            MoForm(new FormNguoiPhuThuoc());
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            MoForm(new FormNghiepVu());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            MoForm(new FormTimKiem());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            MoForm(new FormBaoCao());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (Db.Hoi("Bạn có chắc muốn đăng xuất không?"))
            {
                Hide();
                FormDangNhap form = new FormDangNhap();
                form.ShowDialog();
                Close();
            }
        }
    }
}
