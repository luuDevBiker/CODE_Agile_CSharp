using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Model;
using QuanLySinhVien.ServicesSinhVien;

namespace QuanLySinhVien.View
{
    public partial class frmLogin : Form
    {
        #region declare value form

        private ServicesAll _SVAll = new ServicesAll();
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            _SVAll.getProfile();
            loadAccount();
        }
        private void llQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBackPass backPass = new frmBackPass();
            backPass.Show();
            this.Hide();
        }
        private void llDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.Show();
            this.Hide();
        }

        private void btbDangNhap_Click(object sender, EventArgs e)
        {
            bool checklogin = false;
            _SVAll.getLstAcc().ForEach(x =>
            {
                if (txtTK.Text == x.Acc && txtMK.Text == x.Pass)
                {
                    checkNhoMatKhau();
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    this.Hide();
                    checklogin = true;
                }
            });
            if (checklogin == false)
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #region button đăng nhập method

        public void checkNhoMatKhau()
        {
            if (cbNhoMatKhau.Checked == true)
            {
                _SVAll.saveFileProfile(new Account(txtTK.Text, txtMK.Text));
            }
            else
            {
                _SVAll.saveFileProfile(new Account());
            }
        }

        public void loadAccount()
        {
            if (_SVAll.getProfile().Acc == "")
            {
                return;
            }

            cbNhoMatKhau.Checked = true;
            txtTK.Text = _SVAll.getProfile().Acc;
            txtMK.Text = _SVAll.getProfile().Pass;

        }
        #endregion

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
