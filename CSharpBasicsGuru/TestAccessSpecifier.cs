using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class TestAccessSpecifier
    {
        public static void Main(string[] args)
        {
            Student dt = new Student();
            
        }
    }

    class Testprotected : Student
    {
        private void sample()
        {
            base.display();//Able to access since it is protected which means we can access it within the same class
                           // and the inheriting class.  You cannot access this with the base class object. 
        }
        public static void Main(string[] args)
        {
            Testprotected dt = new Testprotected();
            dt.display();//Able to access because it is protected and within the child class of Student.
        }
    }
}
