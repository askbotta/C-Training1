using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training1
{
    public class Types1
    {
        public void DifferentTypes1()
        {
            //Value types
            int a = 10;
            Console.WriteLine("integer" + a);
            
            float b = 10.56f;
            Console.WriteLine("Float" + b);

            string c = "test";
            Console.WriteLine("String" + c);

            //Ref Type
            string d = "10";
            object e = d;
            string f = (string)e;
            Console.WriteLine("Unboxing:" + f);

            string q = "15";
            int w = int.Parse(q);
            Console.WriteLine("Unboxing opt:"+ w);

        }
    }
}
