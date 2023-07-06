using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Thovvv_CSharp1_BaiTap1
{
    internal class SinhVien 
    {
        private string Masv;
        private string Ten;
        private int NamSinh;
        private double Diem;

        public SinhVien()
        {
            
        }

        public SinhVien(string masv, string ten, int namSinh, double diem)
        {
            Masv = masv;
            Ten = ten;
            NamSinh = namSinh;
            Diem = diem;
        }

        public string Masv1 { get => Masv; set => Masv = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public double Diem1 { get => Diem; set => Diem = value; }
        
        public virtual void InThongTin()
        {
            Console.WriteLine($"{Masv} | {Ten} | {NamSinh} | {Diem}");
        }
    }
}
