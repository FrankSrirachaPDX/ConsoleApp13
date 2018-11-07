using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 holder = new Class1();
            string temp;
            int i;

            Console.WriteLine("Enter a number that corresponds to the Class's array index");

            temp = Console.ReadLine();
            i = Convert.ToInt16(temp);

            Console.WriteLine(holder.Index[i]);

            
            holder =  Class1.Half(holder, i);
            Console.WriteLine("Halved");
            Console.WriteLine(holder.Num);

            holder = Class1.Double(holder, i);
            Console.WriteLine("Doubled");
            Console.WriteLine(holder.Num);

            holder = Class1.Power(holder, i);
            Console.WriteLine("Squared");
            Console.WriteLine(holder.Num);


            Console.ReadLine();
        }


    }
}
