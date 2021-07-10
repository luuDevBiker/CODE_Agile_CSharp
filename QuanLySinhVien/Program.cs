using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.ServicesSinhVien;
using QuanLySinhVien.View;

namespace QuanLySinhVien
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ServicesAll _all = new ServicesAll();
            // _all.fakeSinhVien();
            // _all.saveFileSinhVien();
            // MessageBox.Show(_all.getLstSinhVien().Count.ToString());
            Application.Run(new frmLogin());
        }
    }
}
