using helperLibrary7264;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contralup
{
    class Program
    {
        static void Main(string[] args)
        {
            PPerson aUser = new PPerson();//非本專案類別庫引用
            Maperson amap = new Maperson();//本專案類別庫引用
           
            amap.hight = "5.7";
            aUser.FirstName = "tim";
            var asd = aUser.FirstName.ToString();
            Console.WriteLine($"{ asd } {amap.hight}");

            Console.WriteLine($"{ aUser.FirstName.ToString() }");

            Console.ReadLine();


        }
    }
}
