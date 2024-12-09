using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON3_lab3._2
{
    class Contact
    {
        //1. khai báo các trường
        private int id;
        private string firstname;
        private string lastname;
        private string address;
        private string phone;
        private string email;

        //constructor k tham số
        public Contact()
        {
        }
        //constructor có tham số 
        public Contact(int id, string firstname, string lastname, string address, string phone, string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }
        // 2. tạo thuộc tính cho các trường. 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //3. định nghĩa phương thức display
         public void Display()
        {
            Console.WriteLine(" Mã Số: " + id);
            Console.WriteLine(" Họ và tên:{0} {1} ", firstname, lastname);
            Console.WriteLine("Địa chỉ: " + address);
            Console.WriteLine("Điện thoại: " + phone);
            Console.WriteLine("Email: " + Email);
        }
    }
}
