using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;

            Menu();
        }
        static void Menu()
        {
            SERVICE service = new SERVICE();
            int chon;
            do
            {
                Console.WriteLine("\n--------------------");
                Console.WriteLine("1. Nhập 1 DS đối tượng");
                Console.WriteLine("2. Xuất DS đối tượng");
                Console.WriteLine("3. Xuất DS các SV được tặng vé vip HappyBee");
                Console.WriteLine("4. Xóa những SV không được tham gia HappyBee nếu không được tăng.");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("----------------------");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        service.NhapDS();
                        break;
                    case 2:
                        service.XuatDS();
                        break;
                    case 3:
                        service.TangVeVip();
                        break;
                    case 4:
                        service.Xoa();
                        break;
                    case 5:
                        service.KeThua();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("Không có CT này mời bạn chọn lại !");
                        break;
                }
            } while (chon != 0);
        }
    }
}
