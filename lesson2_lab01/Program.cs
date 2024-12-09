using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_lab01
{
     internal class Program
    {  /// <summary>
       /// Chương trình minh họa về nhập xuất dữ liệu
       /// nhâoj tên sinh viên,điểm,ngày sinh mã sinh viên
       /// </summary>
       /// <param name="args"></param>
        static void Main(string[] args)
        {
            //input và output 
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
          
            String MSV, tenSV;
                DateTime ngaySinh;
                double diem1, diem2, diem3;
                //yêu cầu người nhập thông tin
                // in ra màn hình yêu cầu nhập mã sinh viên
                Console.Write("Nhap Ma SInh Vien");
                //Đọc Dữ Liệu và gán giá trị bằng msv
                MSV = Console.ReadLine();
                //In Ra Ngoai man Hinh Nhat Ten Sinh Vien
                Console.Write("Nhap ten Sinh Vien");
                tenSV = Console.ReadLine();
                //In Ra Ngoai man Hinh Nhat Ten Sinh Vien
                Console.Write("Nhap Ngày SInh");
                ngaySinh = Convert.ToDateTime(Console.ReadLine());
                //nhap diêm
                Console.Write("Nhap Diem Mon 1");
                diem1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap Diem Mon 2");
                diem2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap Diem Mon 3");
                diem3 = Convert.ToDouble(Console.ReadLine());
                double diemTB = (diem1 + diem2 + diem3) / 3;

            Console.WriteLine("{0}-HoTen{1}-NgaySinh{2:dd/MM/yyyy}-DiemTrungBinh: {3:F2}", MSV, tenSV, ngaySinh, diemTB);

        }
    }
}
