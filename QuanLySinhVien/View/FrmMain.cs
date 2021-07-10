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
    public partial class frmMain : Form
    {
        private ServicesAll _servicesAll = new ServicesAll();
        private bool status = false;
        public frmMain()
        {
            InitializeComponent();
            grbInputAcc.Hide();
            dgAcc.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mniQLTK_Click(object sender, EventArgs e)
        {
            grbInputSV.Hide();
            dgSV.Hide();
            grbInputAcc.Show();
            dgAcc.Show();
            dgAcc.DataSource = _servicesAll.getLstAcc();
        }

        private void mniQLSV_Click(object sender, EventArgs e)
        {
            grbInputAcc.Hide();
            dgAcc.Hide();
            grbInputSV.Show();
            dgSV.Show();
            dgSV.DataSource = _servicesAll.getLstSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkTBSinhVien() == true)
            {
                status = true;
                _servicesAll.getLstSinhVien().Add(resultSinhVien());
                _servicesAll.saveFileSinhVien();
                dgSV.DataSource = _servicesAll.getLstSinhVien();
            }

            txtMa.Text = "";
            txtTen.Text = "";
            txtLop.Text = "";
            dtpYearOfBirth.Text = default;
            txtSoDT.Text = "";
            txtMail.Text = "";
        }

        SinhVien resultSinhVien()
        {
            SinhVien sv = new SinhVien();
            sv.Ma = txtMa.Text;
            sv.Name = txtTen.Text;
            sv.ClassName = txtLop.Text;
            sv.NSinh = DateTime.Parse(dtpYearOfBirth.Text);
            sv.NumberPhone = txtSoDT.Text;
            sv.Email = txtMail.Text;
            return sv;
        }

        private void dgSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMa.ReadOnly = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSV.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                txtTen.Text = row.Cells[1].Value.ToString();
                txtLop.Text = row.Cells[2].Value.ToString();
                dtpYearOfBirth.Text = row.Cells[3].Value.ToString();
                txtSoDT.Text = row.Cells[4].Value.ToString();
                txtMail.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dgAcc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgAcc.Rows[e.RowIndex];
                txtTK.Text = row.Cells[0].Value.ToString();
                txtMk.Text = row.Cells[1].Value.ToString();
                txtTK.ReadOnly = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = _servicesAll.findIndexSV(txtMa.Text);
            _servicesAll.getLstSinhVien()[index] = resultSinhVien();
            _servicesAll.saveFileSinhVien();
            dgSV.DataSource = _servicesAll.getLstSinhVien();
            txtMa.ReadOnly = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if (status == true)
            // {
            //     Environment.Exit(0);
            // }
            // DialogResult mess;
            // mess = MessageBox.Show("bạn muốn lưu thay đổi ?", "Dữ liệu chưa được lưu .", MessageBoxButtons.YesNo,
            //     MessageBoxIcon.Warning);
            //
            // if (mess == DialogResult.Yes)
            // {
            //     // point error
            //     _servicesAll.saveFileAcc();
            //     MessageBox.Show(_servicesAll.saveFileSinhVien());
            //     Environment.Exit(0);
            // }
            // else
            // {
            //     Environment.Exit(0);
            // }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = _servicesAll.findIndexSV(txtMa.Text);
            _servicesAll.getLstSinhVien().RemoveAt(index);
            _servicesAll.saveFileSinhVien();
            dgSV.DataSource = _servicesAll.getLstSinhVien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkAcc() == false)
            {
                MessageBox.Show("Tài khoản đã tồn tại .");
                txtTK.Text = "";
                txtMk.Text = "";
            }
            else
            {
                _servicesAll.getLstAcc().Add(resultAccount());
                _servicesAll.saveFileAcc();
            }

        }

        Account resultAccount()
        {
            Account acc = new Account(txtTK.Text, txtMk.Text);
            return acc;
        }

        public bool checkAcc()
        {
            int status = 0;
            _servicesAll.getLstAcc().ForEach(x =>
            {
                if (x.Acc == txtTK.Text)
                {
                    status =  1;
                    return;
                }
            });
            if (status == 1)
            {
                return false;
            }

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = _servicesAll.findIndexAcc(txtTK.Text);
            _servicesAll.getLstAcc()[index] = resultAccount();
            _servicesAll.saveFileAcc();
            txtTK.ReadOnly = false;
            dgAcc.DataSource = _servicesAll.getLstAcc();
            txtTK.Text = "";
            txtMk.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _servicesAll.getLstAcc().RemoveAt(_servicesAll.findIndexAcc(txtTK.Text));
            _servicesAll.saveFileAcc();
            dgAcc.DataSource = _servicesAll.getLstAcc();
        }
    }
}
