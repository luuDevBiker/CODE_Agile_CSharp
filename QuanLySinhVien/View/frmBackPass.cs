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
    public partial class frmBackPass : Form
    {
        private ServicesAll _servicesAll = new ServicesAll();
        public frmBackPass()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            _servicesAll.getLstAcc().ForEach(x =>
            {
                if (x.Acc == txtTim.Text)
                {
                    txtTK.Text = x.Acc;
                    grbTim.Hide();
                }
            });
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkPass() == false)
            {
                return;
            }
            _servicesAll.getLstAcc()[_servicesAll.findIndexAcc(txtTK.Text)] = new Account(txtTK.Text, txtMk.Text);
            _servicesAll.saveFileAcc();
            MessageBox.Show("Đổi mâtk khẩu thành công");
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        bool checkPass()
        {
            if (txtMk.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu dài hơn 5 ký tự.", "Lỗi độ dài mật khẩu");
                return false;
            }

            return true;
        }

        private void frmBackPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Hide();
        }
    }
}
