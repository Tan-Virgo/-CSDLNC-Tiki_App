using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_TIKI.DTO
{
    public class TaiKhoan
    {
        private string userName;
        private string passWord;
        private string vaiTro;


        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        public string VaiTro { get => vaiTro; set => vaiTro = value; }

        public TaiKhoan(string userName, string vaiTro, string passWord = null)
        {
            this.UserName = userName;
            this.VaiTro = vaiTro;
            this.PassWord = passWord;
        }

        public TaiKhoan(DataRow row)
        {
            this.UserName = (string)row["userName"];
            this.PassWord = (string)row["passWord"];
            this.VaiTro = (string)row["vaiTro"];
        }
    }
}
