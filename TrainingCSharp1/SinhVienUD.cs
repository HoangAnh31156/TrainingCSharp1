using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCSharp1
{
    internal class SinhVienUD : SinhVien
    {
        private int KiHoc;
        public SinhVienUD()
        {

        }
        public SinhVienUD(string maSV, string ten, int namSinh, double diem, int kiHoc = 0) : base(maSV, ten, namSinh, diem)
        {
            KiHoc = kiHoc;
        }
        public int kiHoc
        {
            get { return KiHoc; }
            set { KiHoc = value; }
        }
        public override void InThongTin()
        {
            Console.WriteLine($"Mã SV: {maSV} | " +
                $"Tên: {ten} | " +
                $"Năm sinh: {namSinh} | " +
                $"Điểm: {diem} | " +
                $"Kì học: {kiHoc}");
        }
    }
}
