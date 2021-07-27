using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PLEC
{
    class BPrime
    {
        public BigInteger primeNum;

        public BPrime()
        {
            primeNum = new BigInteger(2);
        }

        public BPrime(BPrime b)
        {
            primeNum = b.primeNum;
        }

        public BPrime(String s)
        {
            try
            {
                BigInteger temp = new BigInteger();
                temp = BigInteger.Parse(s);

                if (!isPrime(temp))
                {
                    throw new Exception(s + " is not a prime number");
                }
                else
                {
                    primeNum = temp;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An integer must be entered!");
                return;
            }
        }

        public bool isPrime(BigInteger prime)
        {
            if (prime <= 1)
            {
                return false;
            }
            if (prime == 2)
            {
                return true;
            }
            if (prime % 2 == 0)
            {
                return false;
            }

            int root = (int)Math.Floor(Math.Sqrt((double)prime));

            for (int i = 3; i <= root; i += 2)
            {
                if (prime % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public BPrime Increment()
        {
            BigInteger nextPrime = primeNum + 1;

            while (!isPrime(nextPrime))
            {
                nextPrime++;
            }

            primeNum = nextPrime;
            return this;
        }

        public BPrime Decrement()
        {
            if (primeNum == 2)
            {
                throw new Exception("Prime number cannot be decremented any more");
            }

            BigInteger nextPrime = primeNum - 1;

            while (!isPrime(nextPrime))
            {
                nextPrime--;
            }

            primeNum = nextPrime;
            return this;
        }

        public BPrime Add(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Increment();
            }

            return this;
        }

        public BPrime Assign(BPrime b)
        {
            primeNum = b.primeNum;
            return this;
        }

        public String toString()
        {
            return primeNum.ToString();
        }
    }
}
