using C_Training1;
using System.Numerics;

class Hello1

{
    static void Main()
    {
        Intro1 obj = new Intro1();
        obj.Introduction();
       

        NonGenericCollectionWithBoxing nonGenericCollectionWithBoxing = new NonGenericCollectionWithBoxing();
        nonGenericCollectionWithBoxing.action();

        GenericCollectionToAvoidBoxing GenericCollectionToAvoidBoxing = new GenericCollectionToAvoidBoxing();
        GenericCollectionToAvoidBoxing.action2();

        Console.ReadKey();

    }
}


