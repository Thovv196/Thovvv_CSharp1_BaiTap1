using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Thovvv_CSharp2_BaiTap1
{
    internal class Program
    {
        public delegate void chDelegate<T>(T lstB);

        static void Main(string[] args)
        {

            int chon;
            SERVICE s = new SERVICE();
            List<Bike> lstdsBike = new List<Bike>();
            string path = @"E:\Training c#\Thovvv_CSharp1_BaiTap1\Thovvv_CSharp2_BaiTap1\TextBike.txt";
            do
            {
                Console.WriteLine("--------menu--------");
                Console.WriteLine("1. Nhap danh sach");
                Console.WriteLine("2. Xuat danh sach ");
                Console.WriteLine("3. Ghi file danh sach");
                Console.WriteLine("4. Doc file danh sach");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Nhap lua chon: ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            chDelegate < List < Bike >> Nhap = s.NhapDS;
                            Nhap(lstdsBike);
                            break;
                        }
                    case 2:
                        {
                            s.XuatDS(lstdsBike);
                            break;
                        }
                    case 3:
                        {
                            File.WriteAllText(path, "") ;
                            s.GhiFile(path, lstdsBike);
                            break;
                        }
                    case 4:
                        {
                            List<Bike> lstDocfile = s.DocFile(path);
                            foreach (var item in lstDocfile)
                            {
                                item.InThongTin();
                            }
                            break;
                        }
                    case 5:
                        {
                            s.XoaTheoId(lstdsBike);
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nhap sai, Vui long nhap lai");
                            break;
                        }
                }
            } while (chon != 0);

        }
       
    }
}
