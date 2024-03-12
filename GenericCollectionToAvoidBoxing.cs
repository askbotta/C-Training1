using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training1
{
    public class GenericCollectionToAvoidBoxing
    {
        public void action2()
        {
            List<int> list = new List<int>();
            int number = 10;

            list.Add(number);

            int retriveNumber = list[0];
            Console.WriteLine(retriveNumber);

        }
    }
}
