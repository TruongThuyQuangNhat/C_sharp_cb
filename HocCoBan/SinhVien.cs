using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocCoBan
{
    public class SinhVien
    {
        #region đặc điểm
        private int masv;
        private string ten;
        private double diem;
        #endregion
        public SinhVien() 
        {
            this.masv = 0;
            this.ten = "Trương Thụy Quang Nhật";
            this.diem = 9.0;
        }
        public SinhVien(int masv, string ten, double diem)
        {
            this.masv = masv;
            this.ten = ten;
            this.diem = diem; 
        }
        public int Masv
        {
            get { return this.masv; }
            set { this.masv = value; }
        }
        public string Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }
        public double Diem
        {
            set { this.diem = value; }
            get { return this.diem; }
        }
    }
}
