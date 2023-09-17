using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCSharp1
{
    internal class SERVICE
    {
        List<SinhVien> _lstSinhViens = new List<SinhVien>();
        SinhVien _sinhVien;
        SinhVienUD _sinhVienUD;
        public void FakeData()
        {
            _lstSinhViens.Add(new SinhVien("PH31156", "Vanh", 2000, 8));
            _lstSinhViens.Add(new SinhVien("PH56", "Venom", 1999, 9));
            _lstSinhViens.Add(new SinhVien("PH311", "Tuấn", 1995, 10));
            _lstSinhViens.Add(new SinhVien("PH31111", "Hải", 2004, 4));
            _lstSinhViens.Add(new SinhVien("PH40000", "Tùng", 2002, 5));
            _lstSinhViens.Add(new SinhVien("PH40001", "Hưng", 1990, 8.8));
        }
        public SERVICE()
        {
            FakeData();
        }
        public void NhapDS()
        {
            string tiepTuc;
            do
            {
                _sinhVien = new SinhVien();
                Console.Write("Nhập mã sinh viên:  ");
                _sinhVien.maSV = Console.ReadLine();
                Console.Write("\nNhập tên:  ");
                _sinhVien.ten = Console.ReadLine();
                Console.Write("\nNhập năm sinh:  ");
                _sinhVien.namSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nNhập điểm:  ");
                _sinhVien.diem = Convert.ToDouble(Console.ReadLine());
                _lstSinhViens.Add(_sinhVien);
                Console.WriteLine("Bạn có muốn tiếp tục nhập thông tin không ? (co/ko)");
                tiepTuc = Console.ReadLine();
            } while (tiepTuc.Equals("co"));
        }
        public void XuatDS()
        {
            if (_lstSinhViens.Count == 0)
            {
                Console.WriteLine("Chưa có thông tin !");
                return;
            }
            foreach (var item in _lstSinhViens)
            {
                item.InThongTin();
            }
        }
        public void TangVeVip()
        {
            if (_lstSinhViens.Count == 0)
            {
                Console.WriteLine("Chưa có thông tin !");
                return;
            }
            foreach (var item in _lstSinhViens)
            {
                if (item.diem >= 8)
                {
                    item.InThongTin();
                }
            }
        }
        public void Xoa()
        {
            // Tạo 1 list mới thêm đối tượng cần xóa
            List<SinhVien> DSCanXoa = new List<SinhVien>();

            foreach (var item in _lstSinhViens)
            {
                int tuoi = DateTime.Now.Year - item.namSinh;
                if (tuoi > 25 && item.diem < 8)
                {
                    DSCanXoa.Add(item);
                    item.InThongTin();
                }
            }
            if (DSCanXoa.Count == 0)
            {
                Console.WriteLine("Không có đối tượng nào cần xóa !");
            }
            else
            {
                foreach (var item in DSCanXoa)
                {
                    _lstSinhViens.Remove(item); // Xóa các đối tượng trong DSCanXoa
                }
                Console.WriteLine("Xóa thành công !");
            }
        }
        public void KeThua()
        {
            _sinhVienUD = new SinhVienUD();
            Console.Write("Nhập mã sinh viên: ");
            _sinhVienUD.maSV = Console.ReadLine();
            Console.Write("Nhập tên: ");
            _sinhVienUD.ten = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            _sinhVienUD.namSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập điểm: ");
            _sinhVienUD.diem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập kì học: ");
            _sinhVienUD.kiHoc = Convert.ToInt32(Console.ReadLine());

            _sinhVienUD.InThongTin();
        }
    }
}
