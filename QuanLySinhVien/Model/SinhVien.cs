using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    [Serializable]
    class SinhVien
    {
        private string ma;
        private string name;
        private string className;
        private DateTime nSinh;
        private string numberPhone;
        private string email;

        public SinhVien()
        {
        }

        public SinhVien(string ma, string name, string className, DateTime nSinh, string numberPhone, string email)
        {
            this.ma = ma;
            this.name = name;
            this.className = className;
            this.nSinh = nSinh;
            this.numberPhone = numberPhone;
            this.email = email;
        }
        public string Ma
        {
            get => ma;
            set => ma = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string ClassName
        {
            get => className;
            set => className = value;
        }

        public DateTime NSinh
        {
            get => nSinh;
            set => nSinh = value;
        }

        public string NumberPhone
        {
            get => numberPhone;
            set => numberPhone = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}
