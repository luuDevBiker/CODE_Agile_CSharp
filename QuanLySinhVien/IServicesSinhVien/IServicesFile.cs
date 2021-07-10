using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.IServicesSinhVien
{
    interface IServicesFile
    {
        // genneric mở file trả về một list
        List<T> openFile<T>(string path);
        // genneric lưu file 
        string saveFile<T>(string path , List<T> lst);
    }
}
