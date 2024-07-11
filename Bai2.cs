using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9
{
    public class Bai2
    {

        //tạo lớp học sinh
        public class HocSinh
        {
            public string Ten { get; set; }
            public double DiemToan { get; set; }
            
            //tạo hàm nhận 2 tham số là tên và điển
            public HocSinh(string ten, double diemToan) 
            {
                DiemToan = diemToan;
                Ten = ten;
            }
        }
        public class Programm
        {
            public void B2()
            {
                List<HocSinh> danhSachHocSinh = new List<HocSinh>
                {
                    //thêm học sinh
                    new HocSinh("Nguyen Van A", 7),
                    new HocSinh("Tran Thi B", 8),
                    new HocSinh("Pham Quang C", 8.5),
                    new HocSinh("Nguyen Van A", 9)
                };         
            }
        }         
    }
}
