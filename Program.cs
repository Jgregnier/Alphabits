using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! Your challenge is to write every letter in a row, one by one from a to z");
            Console.WriteLine("Once you have entered the next charecter press enter");

            for(int i = 97; i < 123; i++)
            {
                Console.WriteLine("\r\nEnter The next letter in the alphabet \r\n");
                byte Charecter = Convert.ToByte(Console.ReadKey().KeyChar);
                
                if(Charecter == i)
                {
                    Console.WriteLine("\r\nGood job!");
                } else
                {
                    Console.WriteLine("That was wrong, Game Over");
                    break;
                }
            }
        }
    }
}
