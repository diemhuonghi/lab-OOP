using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_LAB3._1
{
    class Car
    {
        //1.khai báo các trường với phạm vi public
        public string make;
        public string model;
        public string color;
        public string year;

        //2.định nghĩa phương thức start
        public void Start()
        {
            Console.WriteLine(model + " Khởi động");
        }
        // định nghĩa phương thức stop
        public void Stop()
        {
            Console.WriteLine(model + " Dừng");
        }

    }
}
