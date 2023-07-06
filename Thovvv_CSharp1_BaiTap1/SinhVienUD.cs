using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thovvv_CSharp1_BaiTap1
{
    internal class SinhVienUD : SinhVien
    {
        private int Kihoc;
        public SinhVienUD()
        {
            
        }

        public SinhVienUD(string masv, string ten, int namSinh, double diem, int kihoc = 0) : base(masv, ten, namSinh, diem)
        {
            Kihoc1 = kihoc;
        }

        public int Kihoc1 { get => Kihoc; set => Kihoc = value; }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Ki hoc: {Kihoc}");
        }

    }
}
    