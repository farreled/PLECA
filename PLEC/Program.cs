using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PLEC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic demonstration
            //Constructor
            BPrime bPrime = new BPrime();
            Console.WriteLine("bPrime's value is: {0}", bPrime.primeNum);

            bPrime.primeNum = 11;

            //Copy constructor
            BPrime bPrime2 = new BPrime(bPrime);
            Console.WriteLine("bPrime's value is: {0} and bPrime2's value is {1}", bPrime.primeNum, bPrime2.primeNum);

            //Initialize constructor
            BPrime bPrime3 = new BPrime("17");
            Console.WriteLine("bPrime3's value is: {0}", bPrime3.primeNum);

            //Increment
            Console.WriteLine("\nbPrime's value before incrementing is: {0}", bPrime.primeNum);
            bPrime.Increment();
            Console.WriteLine("bPrime's value after incrementing is: {0}", bPrime.primeNum);

            //Decrement
            Console.WriteLine("\nbPrime2's value before decrementing is: {0}", bPrime2.primeNum);
            bPrime2.Decrement();
            Console.WriteLine("bPrime2's value after decrementing is: {0}", bPrime2.primeNum);

            //Add
            Console.WriteLine("\nbPrime3's value before adding 5 is: {0}", bPrime3.primeNum);
            bPrime3.Add(5);
            Console.WriteLine("bPrime3's value after adding 5 is: {0}", bPrime3.primeNum);

            //Assign
            BigInteger prev = bPrime.primeNum;
            bPrime.Assign(bPrime3);
            Console.WriteLine("\nbPrime used to be {0} but is now {1}", prev, bPrime.primeNum);

            //ToString
            string primeStr = bPrime.toString();
            Console.WriteLine("\nProving this is a string by padding left");
            Console.WriteLine(primeStr.PadLeft(5));

            //Demonstrating that BPrime can handle 50 digits
            string strBigPrime = "29907534584936057305785597301561692929713247109403";
            Console.WriteLine("\nbigPrime is {0} digits long", strBigPrime.Length);
            BPrime bigPrime = new BPrime(strBigPrime);
            Console.WriteLine("bigPrime's value is: {0}", bigPrime.primeNum);
        }
    }
}
