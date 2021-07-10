
using System.Windows.Forms;

namespace QuanLySinhVien.View
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDesign = new System.Windows.Forms.GroupBox();
            this.grbInputAcc = new System.Windows.Forms.GroupBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbInputSV = new System.Windows.Forms.GroupBox();
            this.dtpYearOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.grbListData = new System.Windows.Forms.GroupBox();
            this.dgAcc = new System.Windows.Forms.DataGridView();
            this.dgSV = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grbDesign.SuspendLayout();
            this.grbInputAcc.SuspendLayout();
            this.grbInputSV.SuspendLayout();
            this.grbListData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniQLTK,
            this.mniQLSV,
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniQLTK
            // 
            this.mniQLTK.Name = "mniQLTK";
            this.mniQLTK.Size = new System.Drawing.Size(258, 34);
            this.mniQLTK.Text = "Quản Lý Tài Khoản";
            this.mniQLTK.Click += new System.EventHandler(this.mniQLTK_Click);
            // 
            // mniQLSV
            // 
            this.mniQLSV.Name = "mniQLSV";
            this.mniQLSV.Size = new System.Drawing.Size(258, 34);
            this.mniQLSV.Text = "Quản Lý Sinh Viên";
            this.mniQLSV.Click += new System.EventHandler(this.mniQLSV_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(258, 34);
            this.mniExit.Text = "exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // grbDesign
            // 
            this.grbDesign.Controls.Add(this.grbInputAcc);
            this.grbDesign.Controls.Add(this.grbInputSV);
            this.grbDesign.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbDesign.Location = new System.Drawing.Point(0, 33);
            this.grbDesign.Name = "grbDesign";
            this.grbDesign.Size = new System.Drawing.Size(616, 286);
            this.grbDesign.TabIndex = 1;
            this.grbDesign.TabStop = false;
            // 
            // grbInputAcc
            // 
            this.grbInputAcc.Controls.Add(this.txtMk);
            this.grbInputAcc.Controls.Add(this.lblMK);
            this.grbInputAcc.Controls.Add(this.txtTK);
            this.grbInputAcc.Controls.Add(this.lblTK);
            this.grbInputAcc.Controls.Add(this.btnRemove);
            this.grbInputAcc.Controls.Add(this.btnUpdate);
            this.grbInputAcc.Controls.Add(this.btnAdd);
            this.grbInputAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbInputAcc.Location = new System.Drawing.Point(313, 22);
            this.grbInputAcc.Name = "grbInputAcc";
            this.grbInputAcc.Size = new System.Drawing.Size(302, 261);
            this.grbInputAcc.TabIndex = 2;
            this.grbInputAcc.TabStop = false;
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(132, 51);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(150, 26);
            this.txtMk.TabIndex = 1;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Location = new System.Drawing.Point(14, 54);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(77, 20);
            this.lblMK.TabIndex = 0;
            this.lblMK.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(132, 19);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(150, 26);
            this.txtTK.TabIndex = 0;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(14, 22);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(80, 20);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "Tài Khoản";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(207, 214);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 35);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(113, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbInputSV
            // 
            this.grbInputSV.Controls.Add(this.dtpYearOfBirth);
            this.grbInputSV.Controls.Add(this.btnXoa);
            this.grbInputSV.Controls.Add(this.btnSua);
            this.grbInputSV.Controls.Add(this.btnThem);
            this.grbInputSV.Controls.Add(this.txtMail);
            this.grbInputSV.Controls.Add(this.txtLop);
            this.grbInputSV.Controls.Add(this.lblMail);
            this.grbInputSV.Controls.Add(this.lblLop);
            this.grbInputSV.Controls.Add(this.txtSoDT);
            this.grbInputSV.Controls.Add(this.lblSoDT);
            this.grbInputSV.Controls.Add(this.txtTen);
            this.grbInputSV.Controls.Add(this.lblTen);
            this.grbInputSV.Controls.Add(this.lblNamSinh);
            this.grbInputSV.Controls.Add(this.txtMa);
            this.grbInputSV.Controls.Add(this.lblMa);
            this.grbInputSV.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbInputSV.Location = new System.Drawing.Point(3, 22);
            this.grbInputSV.Name = "grbInputSV";
            this.grbInputSV.Size = new System.Drawing.Size(310, 261);
            this.grbInputSV.TabIndex = 0;
            this.grbInputSV.TabStop = false;
            // 
            // dtpYearOfBirth
            // 
            this.dtpYearOfBirth.Location = new System.Drawing.Point(128, 118);
            this.dtpYearOfBirth.Name = "dtpYearOfBirth";
            this.dtpYearOfBirth.Size = new System.Drawing.Size(145, 26);
            this.dtpYearOfBirth.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(210, 214);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(116, 214);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 214);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(128, 181);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(145, 26);
            this.txtMail.TabIndex = 5;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(128, 83);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(145, 26);
            this.txtLop.TabIndex = 2;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(9, 184);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 20);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(9, 86);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(36, 20);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(128, 149);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(145, 26);
            this.txtSoDT.TabIndex = 4;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Location = new System.Drawing.Point(9, 152);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(102, 20);
            this.lblSoDT.TabIndex = 0;
            this.lblSoDT.Text = "Số điện thoại";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(128, 51);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(145, 26);
            this.txtTen.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(9, 54);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 20);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(9, 118);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(75, 20);
            this.lblNamSinh.TabIndex = 0;
            this.lblNamSinh.Text = "Năm sinh";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(128, 19);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(145, 26);
            this.txtMa.TabIndex = 0;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(9, 22);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(35, 20);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã ";
            // 
            // grbListData
            // 
            this.grbListData.Controls.Add(this.dgAcc);
            this.grbListData.Controls.Add(this.dgSV);
            this.grbListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbListData.Location = new System.Drawing.Point(0, 319);
            this.grbListData.Name = "grbListData";
            this.grbListData.Size = new System.Drawing.Size(616, 330);
            this.grbListData.TabIndex = 0;
            this.grbListData.TabStop = false;
            this.grbListData.Text = "Danh Sách Sinh Viên";
            // 
            // dgAcc
            // 
            this.dgAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAcc.Location = new System.Drawing.Point(3, 22);
            this.dgAcc.Name = "dgAcc";
            this.dgAcc.RowHeadersWidth = 62;
            this.dgAcc.RowTemplate.Height = 28;
            this.dgAcc.Size = new System.Drawing.Size(610, 305);
            this.dgAcc.TabIndex = 11;
            this.dgAcc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAcc_CellMouseClick);
            // 
            // dgSV
            // 
            this.dgSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSV.ColumnHeadersVisible = false;
            this.dgSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSV.Location = new System.Drawing.Point(3, 22);
            this.dgSV.Name = "dgSV";
            this.dgSV.RowHeadersWidth = 62;
            this.dgSV.RowTemplate.Height = 28;
            this.dgSV.Size = new System.Drawing.Size(610, 305);
            this.dgSV.TabIndex = 10;
            this.dgSV.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgSV_CellMouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 649);
            this.Controls.Add(this.grbListData);
            this.Controls.Add(this.grbDesign);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbDesign.ResumeLayout(false);
            this.grbInputAcc.ResumeLayout(false);
            this.grbInputAcc.PerformLayout();
            this.grbInputSV.ResumeLayout(false);
            this.grbInputSV.PerformLayout();
            this.grbListData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region ALL toolbox ìnform,
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.GroupBox grbDesign;
        private System.Windows.Forms.GroupBox grbInputSV;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.GroupBox grbListData;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.ToolStripMenuItem mniQLTK;
        private System.Windows.Forms.ToolStripMenuItem mniQLSV;
        private System.Windows.Forms.GroupBox grbInputAcc;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.DataGridView dgSV;
        private System.Windows.Forms.DateTimePicker dtpYearOfBirth;
        #endregion

        #region Form method
        // check toolbox
        public bool checkTBSinhVien()
        {
            int check = 0;
            _servicesAll.getLstSinhVien().ForEach(x =>
            {
                if (check == 1)
                {
                    return;
                }

                if (txtMa.Text == "" || txtLop.Text == "" || txtTen.Text == "" || txtMail.Text == "" || txtSoDT.Text == "")
                {
                    MessageBox.Show("Không được để trống thông tin.", "dữ liệu trùng lặp !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = 1;
                    return;
                }
                if (x.Ma.Equals(txtMa.Text))
                {
                    MessageBox.Show("Mã Sinh viên đã tồn tại .","dữ liệu trùng lặp !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    check = 1;
                    return;
                }

                if (x.Email == txtMail.Text)
                {
                    MessageBox.Show("Mail đã tồn tại .", "dữ liệu trùng lặp !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = 1;
                    return;
                }

                if (x.NumberPhone == txtSoDT.Text)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại .", "dữ liệu trùng lặp !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = 1;
                    return;
                }
            });
            if (check == 1)
            {
                return false;
            }

            return true;
        }
        #endregion

        private DataGridView dgAcc;
    }
}