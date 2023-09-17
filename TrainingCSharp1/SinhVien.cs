using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCSharp1
{
    internal class SinhVien
    {
        private string MaSV;
        private string Ten;
        private int NamSinh;
        private double Diem;

        public SinhVien()
        {

        }
        public SinhVien(string maSV, string ten, int namSinh, double diem)
        {
            MaSV = maSV;
            Ten = ten;
            NamSinh = namSinh;
            Diem = diem;
        }
        public string maSV
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        public string ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        public int namSinh
        {
            get { return NamSinh; }
            set { NamSinh = value; }
        }
        public double diem
        {
            get { return Diem; }
            set { Diem = value; }
        }
        public virtual void InThongTin()
        {
            Console.WriteLine($"Mã SV: {MaSV} | " +
                $"Tên: {Ten} | " +
                $"Năm sinh: {NamSinh} | " +
                $"Điểm: {Diem} | ");
        }
    }
}
