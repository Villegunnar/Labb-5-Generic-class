using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_5_Generic_class
{
    public class Check<T>
    {

        public virtual void ToCheck(T x, T y)
        {
            if (x.Equals(y))
            {
                Console.WriteLine(x+" and " + y + " are equal");
            }
            else
            {
                Console.WriteLine(x + " and " + y + " are not equal");
            }
            


        }

    }
}
