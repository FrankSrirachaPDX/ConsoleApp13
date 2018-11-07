using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Class1 : Program
    {
        public int[] Index = { 2, 4, 6, 8 };
        public int Num;

        public static Class1 Half(Class1 holder, int i)
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
