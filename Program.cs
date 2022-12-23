using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            float height;
            float radius;
            float widht;
       
            float Area;

            Console.WriteLine("                        ***********************************************************");
            Console.WriteLine("                        *********  WELCOME TO THE DIMENSION CALCULATOR  ***********");
            Console.WriteLine("                        ***********************************************************");
            Console.WriteLine("For a rectangle please enter 'r' ");
            Console.WriteLine("For a Circle please enter 'c' ");
            Console.WriteLine("For a Cylinder please enter any other letter ");

            answer = Console.ReadLine();

            if (answer == "r")
            {
                Console.WriteLine("Please enter the height of the rectangle.");
                height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the widht.");
                widht = float.Parse(Console.ReadLine());
                Area = height * widht;

            }
            else if (answer == "c")
            {
                Console.WriteLine("Please enter the radius of the circle.");
                radius = float.Parse(Console.ReadLine());

                Area = (float)Math.PI * (radius * radius);
            }

            else
            {
                Console.WriteLine("Please enter the height of the cylinder.");
                height = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the radius of the cylinder");
                radius = float.Parse(Console.ReadLine());

                Area = (float)Math.PI * (radius * radius) * height;
            }

            Console.WriteLine("Area  = " + Area + " meters squared");

            Console.ReadKey();
        }
    }

}

