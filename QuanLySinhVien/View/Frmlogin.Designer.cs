
namespace QuanLySinhVien.View
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbContain = new System.Windows.Forms.GroupBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.llQuenMK = new System.Windows.Forms.LinkLabel();
            this.llDangKy = new System.Windows.Forms.LinkLabel();
            this.btbDangNhap = new System.Windows.Forms.Button();
            this.cbNhoMatKhau = new System.Windows.Forms.CheckBox();
            this.gbContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbContain
            // 
            this.gbContain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbContain.Controls.Add(this.lblTK);
            this.gbContain.Controls.Add(this.lblMK);
            this.gbContain.Controls.Add(this.txtMK);
            this.gbContain.Controls.Add(this.txtTK);
            this.gbContain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbContain.Location = new System.Drawing.Point(0, 0);
            this.gbContain.Name = "gbContain";
            this.gbContain.Size = new System.Drawing.Size(383, 165);
            this.gbContain.TabIndex = 0;
            this.gbContain.TabStop = false;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(12, 48);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(86, 20);
            this.lblTK.TabIndex = 1;
            this.lblTK.Text = "Tài khoản :";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(12, 104);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(83, 20);
            this.lblMK.TabIndex = 1;
            this.lblMK.Text = "Mật khẩu :";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(122, 101);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(232, 26);
            this.txtMK.TabIndex = 1;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(122, 45);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(232, 26);
            this.txtTK.TabIndex = 0;
            // 
            // llQuenMK
            // 
            this.llQuenMK.AutoSize = true;
            this.llQuenMK.Location = new System.Drawing.Point(236, 178);
            this.llQuenMK.Name = "llQuenMK";
            this.llQuenMK.Size = new System.Drawing.Size(118, 20);
            this.llQuenMK.TabIndex = 4;
            this.llQuenMK.TabStop = true;
            this.llQuenMK.Text = "Quên mật khẩu";
            this.llQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llQuenMK_LinkClicked);
            // 
            // llDangKy
            // 
            this.llDangKy.AutoSize = true;
            this.llDangKy.Location = new System.Drawing.Point(287, 217);
            this.llDangKy.Name = "llDangKy";
            this.llDangKy.Size = new System.Drawing.Size(67, 20);
            this.llDangKy.TabIndex = 3;
            this.llDangKy.TabStop = true;
            this.llDangKy.Text = "Đăng ký";
            this.llDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDangKy_LinkClicked);
            // 
            // btbDangNhap
            // 
            this.btbDangNhap.Location = new System.Drawing.Point(251, 253);
            this.btbDangNhap.Name = "btbDangNhap";
            this.btbDangNhap.Size = new System.Drawing.Size(103, 33);
            this.btbDangNhap.TabIndex = 2;
            this.btbDangNhap.Text = "Đăng nhập";
            this.btbDangNhap.UseVisualStyleBackColor = true;
            this.btbDangNhap.Click += new System.EventHandler(this.btbDangNhap_Click);
            // 
            // cbNhoMatKhau
            // 
            this.cbNhoMatKhau.AutoSize = true;
            this.cbNhoMatKhau.Location = new System.Drawing.Point(16, 178);
            this.cbNhoMatKhau.Name = "cbNhoMatKhau";
            this.cbNhoMatKhau.Size = new System.Drawing.Size(132, 24);
            this.cbNhoMatKhau.TabIndex = 5;
            this.cbNhoMatKhau.Text = "khẩunhớ mật ";
            this.cbNhoMatKhau.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(383, 298);
            this.Controls.Add(this.cbNhoMatKhau);
            this.Controls.Add(this.btbDangNhap);
            this.Controls.Add(this.llDangKy);
            this.Controls.Add(this.llQuenMK);
            this.Controls.Add(this.gbContain);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.gbContain.ResumeLayout(false);
            this.gbContain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContain;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.LinkLabel llQuenMK;
        private System.Windows.Forms.LinkLabel llDangKy;
        private System.Windows.Forms.Button btbDangNhap;
        private System.Windows.Forms.CheckBox cbNhoMatKhau;
    }
}