using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Students : courses    
    {
       public new void getinfo()
        {
            int a = 4;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c);
        }

        public void getinfo(int a,int b)
        { 
            int c = a + b;
            Console.WriteLine(c);
        }

    }
}
