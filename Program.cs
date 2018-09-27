using System;
using System.Text;


namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
          StringBuilder amountMsg = new StringBuilder("Your total amount is ");
amountMsg.AppendFormat("{0:C} ", 60);

Console.WriteLine(amountMsg);
            Console.WriteLine("Hello World!");
        }
    }
}
