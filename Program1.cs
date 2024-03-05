using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training1
{
    class Program1
    {
        public void BoxingAndUnboxing()
        {
            // Boxing
            int num = 123; // num is a value type
            object obj = num; // Boxing: num is converted to object type and stored in obj
            Console.WriteLine($"Boxed object: {obj}");

            // Unboxing
            int numAgain = (int)obj; // Unboxing: object obj is explicitly cast back to int
            Console.WriteLine($"Unboxed value: {numAgain}");

            // Demonstrating boxing with a collection
            Console.WriteLine("\nBoxing and Unboxing with a collection:");
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(456); // Boxing: int is automatically boxed to be stored in the ArrayList

            // Accessing the value requires unboxing
            int valueFromList = (int)myArrayList[0]; // Unboxing: object is explicitly cast back to int
            Console.WriteLine($"Value from ArrayList: {valueFromList}");
        }
    }
}
