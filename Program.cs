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
            int v1 = 5;
            int v2 = 10;
            SubPractice o = new SubPractice();
            Console.WriteLine("Sum of two intgers: "+o.sum(v1,v2));
        }
    }
}
