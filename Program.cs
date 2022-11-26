using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Evens(int b)
        {
            if(b % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                throw new Exception("Number is odd");
            }
        }
        static void Main(string[] args)
        {
            // Exception handling
            // Try, catch and finally block

            int a = 20;
            int b;
            Console.WriteLine("Enter B: ");
            
            try // Problematic code
            {
                b = Convert.ToInt32(Console.ReadLine());
                int answer = a / b;
                Console.WriteLine("Answer: " + answer);
                Evens(b);
            }
            // What exceptions to expect and how to handle them
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't devide by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter numbers!");
            }
            catch(Exception e) // string name 
            {
                Console.WriteLine(e.Message);
            }
            finally // Optional, runs whether there was an exception or not
            {
                Console.WriteLine("Code is done running");
            }
            
        }
    }
}
