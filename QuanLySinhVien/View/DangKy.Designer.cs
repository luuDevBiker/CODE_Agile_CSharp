
namespace QuanLySinhVien.View
{
    partial class frmDangKy
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
            this.gbDangKy = new System.Windows.Forms.GroupBox();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMK1 = new System.Windows.Forms.TextBox();
            this.lblMK1 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.gbDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDangKy
            // 
            this.gbDangKy.Controls.Add(this.cbHienMK);
            this.gbDangKy.Controls.Add(this.txtMK2);
            this.gbDangKy.Controls.Add(this.label3);
            this.gbDangKy.Controls.Add(this.txtMK1);
            this.gbDangKy.Controls.Add(this.lblMK1);
            this.gbDangKy.Controls.Add(this.txtTK);
            this.gbDangKy.Controls.Add(this.lblTK);
            this.gbDangKy.Location = new System.Drawing.Point(12, 12);
            this.gbDangKy.Name = "gbDangKy";
            this.gbDangKy.Size = new System.Drawing.Size(304, 250);
            this.gbDangKy.TabIndex = 0;
            this.gbDangKy.TabStop = false;
            // 
            // txtMK2
            // 
            this.txtMK2.Location = new System.Drawing.Point(140, 159);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.PasswordChar = '*';
            this.txtMK2.Size = new System.Drawing.Size(150, 26);
            this.txtMK2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "xác nhận\r\nmật khẩu";
            // 
            // txtMK1
            // 
            this.txtMK1.Location = new System.Drawing.Point(142, 98);
            this.txtMK1.Name = "txtMK1";
            this.txtMK1.PasswordChar = '*';
            this.txtMK1.Size = new System.Drawing.Size(150, 26);
            this.txtMK1.TabIndex = 1;
            // 
            // lblMK1
            // 
            this.lblMK1.AutoSize = true;
            this.lblMK1.Location = new System.Drawing.Point(6, 101);
            this.lblMK1.Name = "lblMK1";
            this.lblMK1.Size = new System.Drawing.Size(75, 20);
            this.lblMK1.TabIndex = 0;
            this.lblMK1.Text = "Mật khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(142, 33);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(150, 26);
            this.txtTK.TabIndex = 0;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(6, 36);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(78, 20);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(12, 274);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(108, 32);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(208, 274);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(108, 32);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(140, 209);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(140, 24);
            this.cbHienMK.TabIndex = 3;
            this.cbHienMK.Text = "Hiện Mật Khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 318);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.gbDangKy);
            this.Name = "frmDangKy";
            this.Text = "DangKy";
            this.gbDangKy.ResumeLayout(false);
            this.gbDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDangKy;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtMK1;
        private System.Windows.Forms.Label lblMK1;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbHienMK;
    }
}