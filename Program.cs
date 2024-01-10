using System;
//Reverse the number 

class Program
{

    static void Main(String[] args)
    {
        Console.WriteLine("Enter the number here");

        int Number = int.Parse(Console.ReadLine());
        int Reverse = 0;
        while (Number > 0)
        {
            int remainder = Number % 10;
            Reverse = (Reverse * 10) + remainder;
            Number = Number / 10;


        }

        Console.WriteLine("Your reverse number is  "+Reverse);
        Console.ReadLine();
    }
}
