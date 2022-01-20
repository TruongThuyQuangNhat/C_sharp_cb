using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocCoBan
{
    public class SinhVienCNTT:SinhVien
    {
        private String monhoc { set; get; }
        public new double Diem
        {
            get
            {
                return base.Diem;
            }
            set
            {
                base.Diem = 11.0;
            }
        }
    }
}
