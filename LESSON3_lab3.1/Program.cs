using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_LAB3._1
{
    class Program
    {
        ///<summary>
        ///minh họa việc khởi tạo đối tương truy cấp các trường và phương thức
        /// </summary>
        /// 

        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            //3. tạo đối tượng car
            Car myCar = new Car();

            // gán giá trị cho các trường của đối tượng
            myCar.make = "toyota";
            myCar.model = "MR2";
            myCar.color = "red";
            myCar.year = "2004";

            //hiển thị thông tin về đối tượng mycar
            Console.WriteLine("Thông tin chi tiết: ");
            Console.WriteLine("make: " + myCar.make);
            Console.WriteLine("model: " + myCar.model);
            Console.WriteLine("color: " + myCar.color);
            Console.WriteLine("year release: " + myCar.year);

            //goi các phương thức
            myCar.Start();
            myCar.Stop();
            Console.ReadLine();
        }
    }
}
