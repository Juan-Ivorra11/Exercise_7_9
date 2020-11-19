/*
 * (c) Juan Ivorra
 *
 * Program that asks the user to enter 3 marks and calculates the
 * average
 */


using System;
public class Average
{
    public static void Main()
    {
        double mark1 = 0, mark2, mark3 = 0, average;
        string s;
        Console.Write("Insert a mark: ");
        s = Console.ReadLine(); // we read the mark as string to check the word "end"	 
        while (s != "end")
        {  // if the mark isn't an end then we pass it to double to work with it
            mark2 = Convert.ToDouble(s);
            mark3++;   //counter of marks
            mark1 += mark2;  // sum of all the notes
            Console.Write("Insert a mark: ");
            s = Console.ReadLine();
        }
        if (mark3 != 0)
        {
            average = mark1 / mark3;  //calculate the average
            Console.WriteLine("The average is {0}.", average);
        }
    }
}
