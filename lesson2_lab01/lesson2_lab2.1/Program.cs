using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sodien = 51;
            float tongTien=0;
            if (sodien <= 30)
            {
                tongTien = 30;
            }     
            else if ( sodien > 30 && sodien <= 50)
            {
                tongTien = 30 + (sodien - 30) * 1.2f;
            }else if (sodien > 50)
            {
                tongTien = 30 + (50-30) * 1.2f + (sodien - 50)*1.5f;
            }
            Console.WriteLine("Số điện đã dùng là {0} với cước phí phải trả là {1}", sodien, tongTien);
            Console.Read();
        }
    }
}
