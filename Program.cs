using System;

namespace GitPractice
{
    abstract class practice {

        public abstract int sum(int a,int b);
    }

    class SubPractice : practice
    {
        public override int sum(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of two intgers: ");
        }
    }
}
