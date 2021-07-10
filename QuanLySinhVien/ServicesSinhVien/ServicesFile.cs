using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySinhVien.IServicesSinhVien;

namespace QuanLySinhVien.ServicesSinhVien
{
    class ServicesFile : IServicesFile
    {
        // declare value
        private FileStream _fs;
        private BinaryFormatter _bf;

        // mở file
        public List<T> openFile<T>(string path)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                List<T> lst = (List<T>)data;
                _fs.Close();
                return lst;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        // ghi file
        public string saveFile<T>(string path , List<T> lst)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, lst);
                _fs.Close();
                return "Done";
            }
            catch (Exception e)
            {
                return "erro " + e.Message;
            }
        }
    }
}
