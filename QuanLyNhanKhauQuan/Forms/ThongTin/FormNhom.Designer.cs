namespace QuanLyNhanKhauQuan {
	partial class FormNhom {
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTieuDe;
		private System.Windows.Forms.Label lblMaPhuong;

		protected override void Dispose(bool disposing) {
			if(disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent() {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaPhuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblTieuDe.Location = new System.Drawing.Point(285, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(214, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÔNG TIN NHÓM";
            // 
            // lblMaPhuong
            // 
            this.lblMaPhuong.Location = new System.Drawing.Point(94, 88);
            this.lblMaPhuong.Name = "lblMaPhuong";
            this.lblMaPhuong.Size = new System.Drawing.Size(205, 25);
            this.lblMaPhuong.TabIndex = 1;
            this.lblMaPhuong.Text = "Nhóm 09 - Đại học Mở Hà Nội:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(177, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Hoàng Hồ Nam - 24C1002H6187";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(177, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Nguyễn Quang Hưng - 24C1002H7018";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(177, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "- Vũ Tuấn Anh - 24C1002H7019";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(177, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "- Nguyễn Thế Phong - 24C1002H7020\t";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(177, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "- Nguyễn Duy Hưởng - 24C1002H7021";
            // 
            // FormNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(820, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaPhuong);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Nhóm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}
