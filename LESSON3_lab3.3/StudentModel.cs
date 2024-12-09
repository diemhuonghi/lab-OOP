using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_lab3._3
{
    class StudentModel
    {
        //khai báo danh tập hợp chứa các sinh viên
        List<Student> liststudent;

        // phương thức khởi tạo
        public StudentModel()
        {
            //khởi tạo danh sách sinh viên
            this.liststudent = new List<Student>
        {
            new Student(){Id=1,Name="Hương",Age=20},
            new Student(){Id=2,Name="Diễm",Age=19},
            new Student(){Id=3,Name="Thị",Age=18},
            new Student(){Id=4,Name="Nguyễn",Age=17},
            new Student(){Id=5,Name="Giang",Age=16},
        };
        }
    }
}
