using System;

namespace Cloning_Cats_924
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string a = "hello";
            string b = a;
            a = "goodbye";
            // Strings are objects treated like values
            Console.WriteLine(a == b);



            Owner davis = new Owner("Davis", 23);
            Cat dez = new Cat("Dez", davis);
            Cat hammy1 = dez;
            Cat hammy2 = dez.ShallowClone();
            Cat hammy3 = dez.DeepClone();
            Cat hammy4 = new Cat("Dez", davis);

            // returns true since they refer to the same object
            Console.WriteLine(dez == hammy1);

            // returns false, because it is a new object but with the same references
            Console.WriteLine(dez == hammy2);
            // returns true because the owners are still passed as references
            Console.WriteLine(dez.Owner == hammy2.Owner);

            // returns false, they are two separate objects
            Console.WriteLine(dez == hammy3);
            // returns false, because the owners are new objects as well
            Console.WriteLine(dez.Owner == hammy3.Owner);

            // false because it is a new object
            Console.WriteLine(dez == hammy4);
            // returns true because the owners are still passed as references
            Console.WriteLine(dez.Owner == hammy4.Owner);
            // will return true if the values are the same, otherwise they should not be attached
            dez.NumberOfLives = 15;
            Console.WriteLine(dez.NumberOfLives == hammy4.NumberOfLives);

            // '==' returns true if the variables reference the same place in memory
        }
    }
}
