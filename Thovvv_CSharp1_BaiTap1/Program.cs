using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thovvv_CSharp1_BaiTap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Menu();
         
        }
        static void Menu()
        {
            SERVICE s = new SERVICE();
            int chon;
            do
            {
                Console.WriteLine("--------Menu-------");
                Console.WriteLine("1. Nhập danh sách");
                Console.WriteLine("2. Xuất danh sách");
                Console.WriteLine("3. Danh sách sv được tặng vé HappyBee(Điểm => 8)");
                Console.WriteLine("4. Xóa sv không tham gia HappyBee (Tuổi > 25)");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("-------------------");
                Console.WriteLine("Nhập lựa chọn: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:{
                            s.NhapDS();
                            break;
                           }
                    case 2:
                        {
                            s.XuatDS();
                            break;
                        }
                    case 3:
                        {
                            s.InHappyBee();
                            break;
                        }
                    case 4:
                        {
                            s.OutHappyBee();
                            break;
                        }
                    case 5:
                        {
                            s.KeThua();
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nhập sai, vui lòng nhập lại!!!");
                            break;
                        }

                }
            } while (chon!=0);

        }
    }
}
