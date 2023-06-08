using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 소멸자 실습
            Product product = new Product("과자", 1000);
            Product product2 = new Product("빼빼로", 1000);
            Product product3 = new Product("닭꼬치", 1000);
            Product product4 = new Product("탕후루", 1000);
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");

            Box box = new Box(10, 10);

            box.Width = 100;
            try
            {
                box.Height = -190;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
