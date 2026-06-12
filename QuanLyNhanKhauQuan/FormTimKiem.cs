using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuanLyNhanKhauQuan
{
    public partial class FormTimKiem : Form
    {
        private int dongDangIn = 0;
        private DataTable duLieuIn;

        public FormTimKiem()
        {
            InitializeComponent();
        }

        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            cboTieuChi.Items.Clear();
            cboTieuChi.Items.AddRange(new object[]
            {
                "Họ tên chủ hộ",
                "CCCD",
                "Điện thoại",
                "Tình trạng"
            });

            cboTieuChi.SelectedIndex = 0;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Db.KiemTraTrong(txtTuKhoa, "từ khóa tìm kiếm"))
                {
                    return;
                }

                dgvKetQua.DataSource = Db.LayDuLieuSP(
                    "sp_NhanKhau_TimKiem",
                    new SqlParameter("@TieuChi", cboTieuChi.Text),
                    new SqlParameter("@TuKhoa", txtTuKhoa.Text.Trim()));

                DinhDangBangKetQua();

                if (dgvKetQua.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Không tìm thấy nhân khẩu phù hợp với từ khóa đã nhập.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                Db.ThongBao("Tìm kiếm hoàn tất. Có " + dgvKetQua.Rows.Count + " dòng dữ liệu.");
            }
            catch (Exception ex)
            {
                Db.BaoLoi(ex);
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            try
            {
                dgvKetQua.DataSource = Db.LayDuLieu(
                    "SELECT MaNhanKhau, HoTenChuHo, NgaySinh, GioiTinh, CCCD, DiaChi, DienThoai, TinhTrang " +
                    "FROM tblNhanKhau ORDER BY MaNhanKhau");

                DinhDangBangKetQua();
            }
            catch (Exception ex)
            {
                Db.BaoLoi(ex);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKetQua.DataSource == null || dgvKetQua.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Không có dữ liệu để in. Vui lòng tìm kiếm hoặc bấm Xem tất cả trước.",
                        "Không có dữ liệu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                duLieuIn = LayBangDangHienThi();

                if (duLieuIn == null || duLieuIn.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Bảng hiện tại không có dòng dữ liệu hợp lệ để in.",
                        "Không có dữ liệu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                dongDangIn = 0;

                printDocument.DefaultPageSettings.Landscape = true;
                printDocument.DefaultPageSettings.Margins = new Margins(35, 35, 45, 45);

                printPreviewDialog.Document = printDocument;
                printPreviewDialog.Width = 1200;
                printPreviewDialog.Height = 800;
                printPreviewDialog.StartPosition = FormStartPosition.CenterScreen;
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                Db.BaoLoi(ex);
            }
        }

        private void DinhDangBangKetQua()
        {
            if (dgvKetQua.Columns.Count == 0)
            {
                return;
            }

            DatTieuDeCot("MaNhanKhau", "Mã NK", 80);
            DatTieuDeCot("HoTenChuHo", "Họ tên chủ hộ", 170);
            DatTieuDeCot("NgaySinh", "Ngày sinh", 105);
            DatTieuDeCot("GioiTinh", "Giới tính", 80);
            DatTieuDeCot("CCCD", "CCCD", 120);
            DatTieuDeCot("DiaChi", "Địa chỉ", 210);
            DatTieuDeCot("DienThoai", "Điện thoại", 110);
            DatTieuDeCot("TinhTrang", "Tình trạng", 110);

            if (dgvKetQua.Columns.Contains("NgaySinh"))
            {
                dgvKetQua.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            dgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvKetQua.AllowUserToAddRows = false;
            dgvKetQua.RowHeadersVisible = false;
            dgvKetQua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKetQua.MultiSelect = false;
            dgvKetQua.ReadOnly = true;
        }

        private void DatTieuDeCot(string tenCot, string tieuDe, int doRong)
        {
            if (!dgvKetQua.Columns.Contains(tenCot))
            {
                return;
            }

            dgvKetQua.Columns[tenCot].HeaderText = tieuDe;
            dgvKetQua.Columns[tenCot].Width = doRong;
        }

        private DataTable LayBangDangHienThi()
        {
            DataTable table = new DataTable();

            foreach (DataGridViewColumn column in dgvKetQua.Columns)
            {
                if (column.Visible)
                {
                    table.Columns.Add(column.HeaderText);
                }
            }

            foreach (DataGridViewRow row in dgvKetQua.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                DataRow dataRow = table.NewRow();
                int index = 0;

                foreach (DataGridViewColumn column in dgvKetQua.Columns)
                {
                    if (!column.Visible)
                    {
                        continue;
                    }

                    object value = row.Cells[column.Index].Value;
                    dataRow[index] = DinhDangGiaTriIn(value, column.HeaderText);
                    index++;
                }

                table.Rows.Add(dataRow);
            }

            return table;
        }

        private string DinhDangGiaTriIn(object value, string tenCot)
        {
            if (value == null || value == DBNull.Value)
            {
                return "";
            }

            if (value is DateTime)
            {
                return ((DateTime)value).ToString("dd/MM/yyyy");
            }

            DateTime ngay;
            if (tenCot.ToLower().Contains("ngày") && DateTime.TryParse(value.ToString(), out ngay))
            {
                return ngay.ToString("dd/MM/yyyy");
            }

            return value.ToString();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (Font fontTieuDe = new Font("Arial", 15, FontStyle.Bold))
            using (Font fontNgay = new Font("Arial", 9, FontStyle.Regular))
            using (Font fontCot = new Font("Arial", 8, FontStyle.Bold))
            using (Font fontNoiDung = new Font("Arial", 8, FontStyle.Regular))
            using (Pen pen = new Pen(Color.Black, 1))
            {
                Brush brush = Brushes.Black;
                Rectangle vungIn = e.MarginBounds;

                int y = vungIn.Top;
                int rowHeight = 30;
                int tongDoRong = vungIn.Width;

                int[] columnWidths = TinhDoRongCot(tongDoRong, duLieuIn.Columns.Count);

                StringFormat canGiua = new StringFormat();
                canGiua.Alignment = StringAlignment.Center;
                canGiua.LineAlignment = StringAlignment.Center;
                canGiua.Trimming = StringTrimming.EllipsisCharacter;

                StringFormat canTrai = new StringFormat();
                canTrai.Alignment = StringAlignment.Near;
                canTrai.LineAlignment = StringAlignment.Center;
                canTrai.Trimming = StringTrimming.EllipsisCharacter;
                canTrai.FormatFlags = StringFormatFlags.NoWrap;

                Rectangle titleRect = new Rectangle(vungIn.Left, y, tongDoRong, 32);
                e.Graphics.DrawString(
                    "DANH SÁCH NHÂN KHẨU TÌM KIẾM",
                    fontTieuDe,
                    brush,
                    titleRect,
                    canGiua);

                y += 42;

                e.Graphics.DrawString(
                    "Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                    fontNgay,
                    brush,
                    vungIn.Left,
                    y);

                y += 28;

                VeDongBang(e, pen, brush, fontCot, canGiua, y, rowHeight, columnWidths, true);
                y += rowHeight;

                while (dongDangIn < duLieuIn.Rows.Count)
                {
                    if (y + rowHeight > vungIn.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    VeDongBang(e, pen, brush, fontNoiDung, canTrai, y, rowHeight, columnWidths, false);

                    y += rowHeight;
                    dongDangIn++;
                }

                e.HasMorePages = false;
                dongDangIn = 0;
            }
        }

        private int[] TinhDoRongCot(int tongDoRong, int soCot)
        {
            int[] tyLeMacDinh = new int[]
            {
                8,
                18,
                10,
                8,
                13,
                23,
                11,
                9
            };

            int[] columnWidths = new int[soCot];

            if (soCot == 0)
            {
                return columnWidths;
            }

            int tongTyLe = 0;

            for (int i = 0; i < soCot; i++)
            {
                if (i < tyLeMacDinh.Length)
                {
                    tongTyLe += tyLeMacDinh[i];
                }
                else
                {
                    tongTyLe += 10;
                }
            }

            int daDung = 0;

            for (int i = 0; i < soCot; i++)
            {
                int tyLe = i < tyLeMacDinh.Length ? tyLeMacDinh[i] : 10;
                columnWidths[i] = tongDoRong * tyLe / tongTyLe;
                daDung += columnWidths[i];
            }

            if (soCot > 0)
            {
                columnWidths[soCot - 1] += tongDoRong - daDung;
            }

            return columnWidths;
        }

        private void VeDongBang(
            PrintPageEventArgs e,
            Pen pen,
            Brush brush,
            Font font,
            StringFormat dinhDang,
            int y,
            int rowHeight,
            int[] columnWidths,
            bool laDongTieuDe)
        {
            int x = e.MarginBounds.Left;

            for (int i = 0; i < duLieuIn.Columns.Count; i++)
            {
                Rectangle rect = new Rectangle(x, y, columnWidths[i], rowHeight);
                Rectangle rectChu = new Rectangle(x + 3, y + 1, columnWidths[i] - 6, rowHeight - 2);

                string text = laDongTieuDe
                    ? duLieuIn.Columns[i].ColumnName
                    : duLieuIn.Rows[dongDangIn][i].ToString();

                e.Graphics.DrawRectangle(pen, rect);
                e.Graphics.DrawString(text, font, brush, rectChu, dinhDang);

                x += columnWidths[i];
            }
        }
    }
}
