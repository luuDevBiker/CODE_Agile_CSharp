using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.Model;

namespace QuanLySinhVien.ServicesSinhVien
{
    class ServicesAll
    {
        // file data lưu thông tin sinh viên (FileSV.bin)
        private string pathSinhVien = System.IO.Directory.GetCurrentDirectory() + @"\FileSV.bin";
        // file data lưu thông tin account (DataAccount.bin)
        private string pathAccount = System.IO.Directory.GetCurrentDirectory() + @"\FileAccount.bin";
        // file data lưu thông tin người dùng khi truy cập (FileProfile.bin)
        private string pathProfile = System.IO.Directory.GetCurrentDirectory() + @"\DataProfile.bin";
        //
        // declare value global
        //
        private ServicesSinhVien _SSV = new ServicesSinhVien();
        private ServicesFile _SVF = new ServicesFile();
        private List<Account> _lstAccounts = new List<Account>();
        private Account _acc = new Account();
        private List<SinhVien> _lstSinhViens = new List<SinhVien>();
        private SinhVien _sinhVien = new SinhVien();

        // public void fakeLstAcc()
        // {
        //     Account acc1 = new Account("admin", "123");
        //     _lstAccounts.Add(acc1);
        //     Account acc2 = new Account("admin1", "123");
        //     _lstAccounts.Add(acc2);
        // }

        public void fakeSinhVien()
        {
            SinhVien sv1 = new SinhVien("SV1", "lý thị mầu", "IT16313", new DateTime(2002, 08, 12), "0399187212",
                "lythimau1220@gmail.com");
            _lstSinhViens.Add(sv1);
            SinhVien sv2 = new SinhVien("sv2", "lò vi sóng", "IT16313", new DateTime(2000, 08, 20), "0399187290",
                "lythimau1220@gmail.com");
            _lstSinhViens.Add(sv2);
        }

        #region File method
        public string saveFileAcc()
        {
            try
            {
                return _SVF.saveFile(pathAccount, _lstAccounts);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string saveFileSinhVien()
        {
            try
            {
                return _SVF.saveFile(pathSinhVien, _lstSinhViens);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string saveFileProfile(Account acc)
        {
            List<Account> lstAcc = new List<Account>();
            lstAcc.Add(acc);
            return _SVF.saveFile(pathProfile, lstAcc);
        }

        public List<Account> getLstAcc()
        {
            _lstAccounts = _SVF.openFile<Account>(pathAccount);
            return _lstAccounts;
        }

        public List<SinhVien> getLstSinhVien()
        {
            return _lstSinhViens = _SVF.openFile<SinhVien>(pathSinhVien);
        }

        public Account getProfile()
        {
            _acc = _SVF.openFile<Account>(pathProfile)[0];
            return _acc;
        }
        #endregion
        #region Sinh viên method

        public int findIndexSV(string ma)
        {
            return _lstSinhViens.FindIndex(x => x.Ma.StartsWith(ma));
        }
        public int findIndexAcc(string acc)
        {
            return _lstAccounts.FindIndex(x => x.Acc == acc);
        }
        #endregion
        public void test()
        {
            _SVF.openFile<Account>(pathProfile).ForEach(x => MessageBox.Show(x.Acc + " " + x.Pass));
            MessageBox.Show(_SVF.openFile<Account>(pathProfile).Count.ToString());
        }
    }
}
