using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Constants
    {
        public const string x = "a";
    }

    class Variable_Declaration
    { 
      /*Variable Declaration
        * <access specifier> <access modifier> <data type> <variable name>
      */
        
        static int a;
        static long b;
        static float c;
        static double d;
        static decimal Dec;
        
        static void Main(string[] args) {

            Console.WriteLine(Constants.x);

            string guru123;
            /*Assignment Operator
             * variable = value
             */
            guru123 = args[0];
            
            //Implicit Converter
            b = 10;
            c = 10f;
            d = 25.24868763847658437564385d;
            Dec = 25.24868763847658437564385M;

            //Explicit Type Converter
            a =(int)b;
            c = (float)Dec;
            Dec = (decimal)d;
            a = (int)Dec;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(Dec);
            Console.WriteLine(guru123);
            Console.ReadLine();
        }
    }
}
