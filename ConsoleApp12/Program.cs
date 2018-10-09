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

            temp = Console.ReadLine();
            i = Convert.ToInt16(temp);

            Console.WriteLine("Enter a number that corresponds to the Class's array index");
            Console.WriteLine(holder.Index[i]);

            
            holder =  Half(holder, i);
            Console.WriteLine("Halved");
            Console.WriteLine(holder.Num);

            holder = Double(holder, i);
            Console.WriteLine("Doubled");
            Console.WriteLine(holder.Num);

            holder = Power(holder, i);
            Console.WriteLine("Squared");
            Console.WriteLine(holder.Num);


            Console.ReadLine();
        }

        public static Class1 Half (Class1 holder, int i)
        {
            
            holder.Num = holder.Index[i] / 2;


            return holder;
        }

        public static Class1 Double(Class1 holder, int i)
        {
            holder.Num = holder.Index[i] * 2;

            return holder;
        }

        public static Class1 Power(Class1 holder, int i)
        {
            holder.Num = holder.Index[i] * holder.Index[i];

            return holder;
        }
    }
}
