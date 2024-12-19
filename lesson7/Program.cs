using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronic.Sony;
using samsung = Electronic.Samsung;
using Electronic;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //sử dụng namespace
            //C1: sdung using tên_namespace, bên ngoài namespace sử dụng đến nó
            XperiaZ xperiaZ = new XperiaZ();
            // C2: sdung tên namespace .class sử dụng
            Electronic.Tivi tivi = new Electronic.Tivi();
            //C3: tên cho namespace -> sử dụng alias.tên_class
            samsung.GalaxyA galaxyA = new samsung.GalaxyA();
            samsung.GalaxyS galaxyS = new samsung.GalaxyS();
            samsung.Maygiat maygiay = new samsung.Maygiat();
        }
    }
}
