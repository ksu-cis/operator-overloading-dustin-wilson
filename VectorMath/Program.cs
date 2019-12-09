using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine($"Object Method Add: {one.Addition(two)}");
            Console.WriteLine($"Operator Addition: {one + two}");
            Console.WriteLine($"Operator Subtraction: {one - two}");
            Console.WriteLine($"Scalar Operation: {2 * one}");
            Console.WriteLine($"Should not be equal: {one == two}");
            Console.WriteLine($"Should be equal: {one == new Vector3(3, 4, 5)}");
            Console.WriteLine($"Increment it: {one++}");
            Console.WriteLine($"The magnitude is: {~one}");

            if (one)
            {
                Console.WriteLine($"{one} is Truth");
            }
            else
            {
                Console.WriteLine($"{one} is False");
            }
        }
    }
}