using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade: 10
namespace Cook_QuadInheritance1
{
    class TestQuad
    {
        static void Main(string[] args)
        {
            Quad quad = new Quad(1.1F, 1.2F, 6.6F, 2.8F, 6.2F, 9.9F, 2.2F, 7.4F);

            Trapezoid trap = new Trapezoid(0.0F, 0.0F, 10.0F, 0.0F, 8.0F, 5.0F, 3.3F, 5.0F);

            Para para = new Para(5F, 5F, 11F, 5F, 12F, 20F, 6F, 20F);

            Rectangle rect = new Rectangle(17F, 14F, 30F, 14F, 30F, 28F, 17F, 28F);

            Square square = new Square(4F, 0F, 8F, 0F, 8F, 4F, 4F, 4F);

            Console.WriteLine(quad + " ");
            Console.WriteLine(trap + " ");
            Console.WriteLine(para + " ");
            Console.WriteLine(rect + " ");
            Console.WriteLine(square);

            Console.ReadKey();
        }
    }
}
