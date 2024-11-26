using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    using System;
    class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        //hiển thị thông tin
        public void Hienthithongtin ()
        {
            Console.WriteLine("Mã Nhân Viên: " + MaNhanVien);
            Console.WriteLine("Họ Tên Nhân Viên: " + HoTenNhanVien);
            Console.WriteLine("Ngày Sinh: " + NgaySinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("Địa Chỉ: " + DiaChi);
            Console.WriteLine("Điện Thoại: " + DienThoai);
            Console.WriteLine("Email: " + Email);
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //tạo đối tương nv
            NhanVien nhanVien = new NhanVien();
            //gán gtri cho các thuộc tính
            nhanVien.MaNhanVien = "NV1";
            nhanVien.HoTenNhanVien = "Nguyễn Văn Cùi";
            nhanVien.NgaySinh = new DateTime(2004, 10, 18);
            nhanVien.DienThoai = "Yên Nghĩa, Hà Nội";
            nhanVien.Email = "hihi@gmail.com";
            //hiển thị ttin
            nhanVien.Hienthithongtin();
            Console.ReadLine();
        }
    }
}
