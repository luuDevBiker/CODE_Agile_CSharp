using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Model;
using QuanLySinhVien.ServicesSinhVien;

namespace QuanLySinhVien.View
{
    public partial class frmDangKy : Form
    {
        #region Declare value global

        private ServicesAll _svAll = new ServicesAll();
        #endregion
        public frmDangKy()
        {
            InitializeComponent();
            _svAll.getLstAcc();
        }

        #region events form
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
            {
                txtMK1.PasswordChar = '\0';
                txtMK2.PasswordChar = '\0';
            }
            else
            {
                txtMK1.PasswordChar = '*';
                txtMK2.PasswordChar = '*';
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (check() == false )
            {
                return;
            }
            _svAll.getLstAcc().Add(new Account(txtTK.Text, txtMK1.Text));
            _svAll.saveFileAcc();
            MessageBox.Show("Tạo tài khoản thành công");
        }
        #endregion
        #region form methods
        public bool check()
        {
            int check = 0;
            // tài khoản phải dài hơn 5 ký tự
            #region check tài khoản

            if (txtTK.Text.Length < 6)
            {
                MessageBox.Show("Tài khoản phải lớn hơn 5 ký tự.");
                return false;
            }
            #endregion
            // mật khẩu phải lớn hơn 5 ký tự và 2 ô phải trùng mật khẩu
            #region check mật khẩu

            if (txtMK1.Text != txtMK2.Text || txtMK1.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu không khớp \n Hoặc độ dài mật khẩu phải lớn hơn 5 ký tự.");
                return false;
            }
            // check tài khoản tồn tại
            _svAll.getLstAcc().ForEach(x =>
                {
                    if (check == 1)
                    {
                        return;
                    }
                    if (txtTK.Text == x.Acc)
                    {
                        MessageBox.Show("tài khoản đã tồn tại");
                        check = 1;
                    }
                });
            #endregion
            return check == 0 ? true : false;
        }
        #endregion
    }
}
