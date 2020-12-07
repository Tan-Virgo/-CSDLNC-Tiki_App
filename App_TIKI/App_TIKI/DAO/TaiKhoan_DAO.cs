using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_TIKI.DAO
{
    public class TaiKhoan_DAO
    {
        private static TaiKhoan_DAO instance;
        public static TaiKhoan_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoan_DAO();
                return instance;
            }
            private set => instance = value;
        }

        private TaiKhoan_DAO() { }
    }
}
