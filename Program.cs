using System;
using System.Collections.Generic;

namespace DelegateYield
{
    public delegate void MyDelegate(string msg);
    public class Program
    {
        /* example for yield*/
        /*static void Main(string[] args)
        {
            foreach (int i in Power(2, 8))
            {
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine("Hello World!");
        }
        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
    }*/


    /* example for Delegate*/

     static void Main(string[] args)
     {
         MyDelegate del = ClassA.MethodA;
         InvokeDelegate(del);

         del = ClassB.MethodB;
         InvokeDelegate(del);

         del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
         InvokeDelegate(del);
     }

     static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
     {
         del("Hello World");
     }
 }

public class ClassA
 {
    public static void MethodA(string message)
     {
         Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
     }
 }

 class ClassB
 {
    public static void MethodB(string message)
     {
         Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
     }
 } 

}
