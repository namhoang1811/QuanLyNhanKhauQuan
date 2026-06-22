namespace QuanLyNhanKhauQuan
{
    partial class FormBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Button btnThongKe;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.dgvThongKe = new System.Windows.Forms.DataGridView(); this.btnThongKe = new System.Windows.Forms.Button(); ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit(); this.SuspendLayout();
            System.Windows.Forms.Label title = new System.Windows.Forms.Label(); title.Text = "BÁO CÁO THỐNG KÊ NHÂN KHẨU"; title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); title.ForeColor = System.Drawing.Color.FromArgb(35, 78, 112); title.AutoSize = true; title.Location = new System.Drawing.Point(220, 18); this.Controls.Add(title);
            this.btnThongKe.Location = new System.Drawing.Point(35, 70); this.btnThongKe.Size = new System.Drawing.Size(150, 35); this.btnThongKe.Text = "Tải thống kê"; this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            this.dgvThongKe.AllowUserToAddRows = false; this.dgvThongKe.AllowUserToDeleteRows = false; this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvThongKe.BackgroundColor = System.Drawing.Color.White; this.dgvThongKe.Location = new System.Drawing.Point(35, 125); this.dgvThongKe.ReadOnly = true; this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvThongKe.Size = new System.Drawing.Size(745, 350);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; this.BackColor = System.Drawing.Color.FromArgb(235, 240, 245); this.ClientSize = new System.Drawing.Size(820, 505); this.Controls.Add(this.btnThongKe); this.Controls.Add(this.dgvThongKe); this.Font = new System.Drawing.Font("Segoe UI", 10F); this.Name = "FormBaoCao"; this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; this.Text = "Báo cáo thống kê"; this.Load += new System.EventHandler(this.FormBaoCao_Load); ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit(); this.ResumeLayout(false); this.PerformLayout();
        }
    }
}
