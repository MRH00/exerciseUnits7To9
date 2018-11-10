//Manuel Rojas Henarejos
/* This is a program that asks the user to enter three marks and shows
 * the average.
 */
 
using System;

public class CheckFinalMark
{
    public static void Main()
    {
        int mark1, mark2, mark3;
        
        Console.Write("Enter the first mark: ");
        mark1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second mark: ");
        mark2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third mark: ");
        mark3 = Convert.ToInt32(Console.ReadLine());
        
        int average = ((mark1 + mark2 + mark3) / 3);
        
        if ((mark1 >= 4) && (mark2 >= 4) && (mark3 >= 4) && 
            (average >= 5))
            {
                Console.WriteLine("The final average is "+ average);
            }
        else if ((mark1 >= 4) && (mark2 >= 4) && (mark3 >= 4) && 
            (average < 5))
            {
                Console.WriteLine("The final average is 4");
            }
        else if ((mark1 < 4) || (mark2 < 4) || (mark3 < 4) && 
            (average == 5))
            {
                Console.WriteLine("The average is 3");
            }
        else if ((mark1 < 4) || (mark2 < 4) || (mark3 < 4) && 
            (average == 2))
            {
                Console.WriteLine("The average is 2");
            }
    }
}
