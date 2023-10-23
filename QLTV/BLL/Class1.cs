using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Class1
    {
        private static string _taiKhoan;

        public static void GhiNhanTaiKhoan(string taiKhoan)
        {
            _taiKhoan = taiKhoan;
        }
        public static string LayTaiKhoan()
        {
            return _taiKhoan;
        }
    }
}
