using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("4+4 is");

        Console.WriteLine("1. 8");
        Console.WriteLine("2. 7");
        Console.WriteLine("3. 11");
  
        Console.WriteLine("4. 12");

        Console.WriteLine("Enter the correct choice");

        int opt = Convert.ToInt32(Console.ReadLine());

        if (opt == 1)
        {
            Console.WriteLine("Correct");
        }
      else
      {
                Console.WriteLine("Incorrect");
        }







    }
}
