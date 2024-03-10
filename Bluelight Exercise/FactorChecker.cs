using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bluelight_Exercise
{
    public class FactorChecker
    {
        // Constructor
        public FactorChecker (int start, int end, int divisor)
        {
            this.Start = start;
            this.End = end;
            this.Divisor = divisor;

            Range = GetRange();
        }

        // Member declarations
        public int Start;
        public int End;
        public int Divisor;
        public List<int> Range;

        // Method to create int collection given start and end ints
        private List<int> GetRange()
        {
            List<int> result = new List<int>();
            int current;

            if (Start < End)
            {
                current = Start;
                while (current <= End)
                {
                    result.Add(current);
                    current++;
                }
            }
            else
            {
                result.Add(Start);
            }

            return result;
        }

        // ================================================================
        // Method 1: Using modulus division
        // ================================================================
        public void Method1 ()
        {
            List<int> result = new List<int>();
            int remainder;

            Console.WriteLine("\nUsing modulus:");

            foreach (int dividend in Range)
            {
                // *** Math is here ***
                remainder = dividend % Divisor;

                // Append and print results
                if (remainder == 0)
                {
                    result.Add(dividend);
                    Console.WriteLine($"{dividend} mod {Divisor} = {remainder}; adding to result");
                }
                else
                {
                    Console.WriteLine($"{dividend} mod {Divisor} = {remainder}; not valid");
                }
            }

            Console.WriteLine("\nFinal result:");
            Console.WriteLine(string.Join(", ", result.ToArray()));
        }

        // ================================================================
        // Method 2: Using non-modulus division
        // ================================================================
        public void Method2 ()
        {
            List<int> result = new List<int>();
            int product;

            Console.WriteLine("\nUsing integer division:");

            foreach (int dividend in Range)
            {
                // *** Math is here ***
                product = (dividend / Divisor) * Divisor;

                // Append and print results
                if (product == dividend)
                {
                    result.Add(dividend);
                    Console.WriteLine($"( {dividend} / {Divisor} ) * {Divisor} = {product}; adding to result");
                }
                else
                {
                    Console.WriteLine($"( {dividend} / {Divisor} ) * {Divisor} = {product}; not valid");
                }
            }

            Console.WriteLine("\nFinal result:");
            Console.WriteLine(string.Join(", ", result.ToArray()));
        }

        // ================================================================
        // Method 3: Using no division at all
        // ================================================================
        public void Method3()
        {
            List<int> result = new List<int>();
            int current = 0;

            Console.WriteLine("\nUsing no division; getting multiples of divisor within range");

            // *** Math is here ***
            // Increment divisor until it reaches the start value
            while (current < Start)
            {
                current += Divisor;
            }
            // Start adding multiples to results until it exceeds the end value
            while (current <= End)
            {
                result.Add(current);
                current += Divisor;
            }

            Console.WriteLine("\nFinal result:");
            Console.WriteLine(string.Join(", ", result.ToArray()));
        }
    }
}
