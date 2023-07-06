using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Thovvv_CSharp1_BaiTap1
{
    internal class SERVICE
    {
        List<SinhVien> lstSV;
        // khởi tạo danh sách mẫu
        public SERVICE()
        {
            lstSV = new List<SinhVien>()
            {
                new SinhVien("ph1", "Tho", 2004, 9),
                new SinhVien("ph4", "Anh", 2003, 4),
                new SinhVien("ph2", "Phuc", 2004, 6),
                new SinhVien("ph5", "Hieu", 2003, 8),
                new SinhVien("ph3", "Oanh", 2002, 10),
                new SinhVien("ph7", "Giang", 1998, 8),
                new SinhVien("ph6", "Mai", 1996, 7),
            };
        }
        public void NhapDS()
        {
            string continues;
            do
            {
                SinhVien st = new SinhVien();
                Console.WriteLine("Nhập mã sinh viên: ");
                st.Masv1 = Console.ReadLine();
                Console.WriteLine("Nhập tên: ");
                st.Ten1 = Console.ReadLine();
                Console.WriteLine("Nhập năm sinh: ");
                st.NamSinh1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập điểm: ");
                st.Diem1 = Convert.ToDouble(Console.ReadLine());
                lstSV.Add(st);//gán dữ liệu vào
                Console.WriteLine("có muốn tiếp tục nhập(y/n): ");
                continues = Console.ReadLine();

            } while (continues.Equals("y"));
            
        }
        public void XuatDS()
        {
            if (lstSV.Count == 0)
            {
                Console.WriteLine("Danh sách trống!!");
            }
            foreach (var item in lstSV)
            {
                item.InThongTin();
            }
        }
        public void InHappyBee()
        {
            if(lstSV.Count == 0)
            {
                Console.WriteLine("Danh sách trống!!");
            }
            var lists = lstSV.Where(s => s.Diem1>=8); 
            foreach (var item in lists)
            {
                item.InThongTin();
            }
        }
        private int TinhTuoi(int NamSinh)
        {
            int namHienTai = DateTime.Now.Year;
            return namHienTai - NamSinh;
        }
        public void OutHappyBee()
        {
            var listKhongDiHB = lstSV.Where(s => TinhTuoi(s.NamSinh1) > 25 || s.Diem1 < 8).ToList();
            if (listKhongDiHB.Count() == 0)
            {
                Console.WriteLine("không có sinh viên nào tham gia HB");
            }
            else
            {
                Console.WriteLine("Danh sách cần được xóa!!!");
                foreach (var item in listKhongDiHB)
                {
                    item.InThongTin();
                    lstSV.Remove(item);
                }
                Console.WriteLine("Đã xoa thành công!!!");
            }
        }
        public void KeThua()
        {
            SinhVienUD svUD = new SinhVienUD("ph31698","Yuki",2000,9,3);
            svUD.InThongTin();
        }
    }
}
    