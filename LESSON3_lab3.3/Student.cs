using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_lab3._3
{
   internal class Student
    {
        //1, tạo các thuộc tính
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        //2, phương thức hiển thị
        public void Display()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
