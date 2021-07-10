
namespace QuanLySinhVien.View
{
    partial class frmBackPass
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
            this.grbDatLaiMk = new System.Windows.Forms.GroupBox();
            this.grbTim = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblTkTim = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.grbDatLaiMk.SuspendLayout();
            this.grbTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatLaiMk
            // 
            this.grbDatLaiMk.Controls.Add(this.grbTim);
            this.grbDatLaiMk.Controls.Add(this.btnLuu);
            this.grbDatLaiMk.Controls.Add(this.txtMk);
            this.grbDatLaiMk.Controls.Add(this.lblMK);
            this.grbDatLaiMk.Controls.Add(this.txtTK);
            this.grbDatLaiMk.Controls.Add(this.lblTK);
            this.grbDatLaiMk.Location = new System.Drawing.Point(0, 0);
            this.grbDatLaiMk.Name = "grbDatLaiMk";
            this.grbDatLaiMk.Size = new System.Drawing.Size(370, 188);
            this.grbDatLaiMk.TabIndex = 0;
            this.grbDatLaiMk.TabStop = false;
            this.grbDatLaiMk.Text = "đặt lại mật khẩu";
            // 
            // grbTim
            // 
            this.grbTim.Controls.Add(this.btnTim);
            this.grbTim.Controls.Add(this.txtTim);
            this.grbTim.Controls.Add(this.lblTkTim);
            this.grbTim.Location = new System.Drawing.Point(0, 0);
            this.grbTim.Name = "grbTim";
            this.grbTim.Size = new System.Drawing.Size(370, 188);
            this.grbTim.TabIndex = 5;
            this.grbTim.TabStop = false;
            this.grbTim.Text = "Tìm Tài Khoản";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(248, 119);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 38);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(173, 43);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(150, 26);
            this.txtTim.TabIndex = 0;
            // 
            // lblTkTim
            // 
            this.lblTkTim.AutoSize = true;
            this.lblTkTim.Location = new System.Drawing.Point(55, 46);
            this.lblTkTim.Name = "lblTkTim";
            this.lblTkTim.Size = new System.Drawing.Size(80, 20);
            this.lblTkTim.TabIndex = 4;
            this.lblTkTim.Text = "Tài Khoản";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(248, 119);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(173, 75);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(150, 26);
            this.txtMk.TabIndex = 1;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(55, 78);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(77, 20);
            this.lblMK.TabIndex = 2;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(173, 43);
            this.txtTK.Name = "txtTK";
            this.txtTK.ReadOnly = true;
            this.txtTK.Size = new System.Drawing.Size(150, 26);
            this.txtTK.TabIndex = 0;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(55, 46);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(80, 20);
            this.lblTK.TabIndex = 4;
            this.lblTK.Text = "Tài Khoản";
            // 
            // frmBackPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 190);
            this.Controls.Add(this.grbDatLaiMk);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackPass";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmBackPass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackPass_FormClosing);
            this.grbDatLaiMk.ResumeLayout(false);
            this.grbDatLaiMk.PerformLayout();
            this.grbTim.ResumeLayout(false);
            this.grbTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatLaiMk;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.GroupBox grbTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblTkTim;
    }
}