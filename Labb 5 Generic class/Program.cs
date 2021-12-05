using System;

namespace Labb_5_Generic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCheck<string> Stringchecker = new StringCheck<string>();
            
            Stringchecker.ToCheck("Anas", "Anas");
            Stringchecker.ToCheck("Anas", "Annanas");

            IntCheck<int> Intchecker = new IntCheck<int>();

            Intchecker.ToCheck(123, 123);
            Intchecker.ToCheck(123, 321);
        }
    }
}
