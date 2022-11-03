using System;

namespace CalcRoom // area cost calculation. 
{
    class pgm
    {
        public static void Main()
        {
            int length, width, area, cost, price;
            Console.Write("Enter length of room in feet: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width of room in feet:");
            width = Convert.ToInt32(Console.ReadLine());
            area = length * width;
            Console.Write("Enter price of square feet: ");
            price = Convert.ToInt32(Console.ReadLine());
            cost = (length * width) * price;
            Console.WriteLine("Floor is " + area + " square feet.");
            Console.WriteLine("Cost for room is " + cost + ".");
            Console.ReadLine();
        }
    }
}