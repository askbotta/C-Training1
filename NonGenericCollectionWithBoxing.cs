using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training1
{
    public class NonGenericCollectionWithBoxing
    {
        public void action()
        {
            ArrayList nonGenericList = new ArrayList();
            int number = 10;

            nonGenericList.Add(number);

            int newNmuber = (int)nonGenericList[0];

            Console.WriteLine($"Retrive Number: {newNmuber}");

        }
    }
}
