using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Thovvv_CSharp2_BaiTap1
{
    internal class SERVICE
    {
       
        public void NhapDS(List<Bike> lstBike) 
        {
            int id = 1;
            string tieptuc;
            do
            {
                Bike bikes = new Bike();
                while (lstBike.Any(b => b.ID1 == id))
                {
                    id++;
                }
                Console.WriteLine("Nhap ID: ");
                bikes.ID1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap ten: ");
                bikes.Ten1 = Console.ReadLine();    
                Console.WriteLine("Nhap HSX: ");
                bikes.HSX1 = Console.ReadLine();
                lstBike.Add(bikes);
                Console.WriteLine("Ban co muon tiep tuc nhap hay khong (y or n): ");
                tieptuc = Console.ReadLine();   
            } while (tieptuc.Equals("y"));
        }
        public void XuatDS(List<Bike> lstBike)
        {
            if (lstBike.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!");
            }
            foreach (var item in lstBike)
            {
                item.InThongTin();
            }
        }
        public void GhiFile(string path, List<Bike> lstBike)
        {
            if (File.Exists(path))
            {
                foreach (var item in lstBike)
                {
                    string lines = item.ObjToString();
                    File.AppendAllText(path, lines);
                }
                Console.WriteLine("ghi file thanh cong!!!");
            }
            else
            {
                Console.WriteLine("File khong ton tai!!!");
            }
        }
        public List<Bike> DocFile(string path)
        {
            List<Bike> result = new List<Bike>();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                if (line.Trim().Length == 0)
                {
                    continue;
                }
                else
                {
                    string[] attributes = line.Split('|');
                    Bike s = new Bike();
                    s.ID1 = Convert.ToInt32(attributes[0]);
                    s.Ten1 = attributes[1];
                    s.HSX1 = attributes[2];
                    result.Add(s);
                }
            }
            return result;

        }
        public void XoaTheoId(List<Bike> lstBike)
        {
            Console.WriteLine("Nhap id can xoa");
            int id = Convert.ToInt32(Console.ReadLine());
            var bike = (from s in lstBike
                        where s.ID1 == id
                        select s).FirstOrDefault();
            if (bike != null)
            {
                lstBike.Remove(bike);
                Console.WriteLine("da xoa thanh cong!!!");
            }
            else { Console.WriteLine("Danh sach trong!!!"); }
        }
    }
}

    

