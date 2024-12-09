using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            // tạo đối tượng contact với constructor  tham số ( NGƯỜI 1)
            Contact ct1 = new Contact();
            // gán giá trị cho ct1
            ct1.Id = 1;
            ct1.FirstName = " Nguyễn Thị";
            ct1.LastName = "Hương";
            ct1.Address = " Ha Noi";
            ct1.Phone = " 0383520274";
            ct1.Email = "huongntd1810@gmail.com";

            // tạo đối tượng contact với constructor có tham số ( NGƯỜI 2)
            Contact ct2 = new Contact(2, "Nguyễn Diễm", "Hương", "Nghệ An", "0354514608", "Nguyendiemhuong2911@gmail.com");
            ct1.Display();
            ct2.Display();
            Console.ReadLine();
        }
    }
}
