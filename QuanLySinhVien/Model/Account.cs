using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Model
{
    [Serializable]
    class Account
    {
        private string acc;
        private string pass;

        public Account()
        {
        }

        public Account(string acc, string pass)
        {
            this.acc = acc;
            this.pass = pass;
        }

        public string Acc
        {
            get => acc;
            set => acc = value;
        }

        public string Pass
        {
            get => pass;
            set => pass = value;
        }
    }
}
