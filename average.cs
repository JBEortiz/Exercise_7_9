using System;
public class Average{
    static void Main(string[] args)
    /**we have changed the while structure to make it with a do while and we have formatted the code to make it more readable*/
    {
        double a = 0, b, c = 0, d;
        string s;
        Console.Write("Insert a mark: ");
        s = Console.ReadLine(); /** we read the mark as string to check the word "end"	*/

        do
        {
            b = Convert.ToDouble(s);
            c++;   /**counter of numbers*/
            a += b;  /** sum of all the notes*/
            Console.Write("Insert a mark: ");
            s = Console.ReadLine();
        }
        while (s != "end");
        if (c != 0)
        {
            d = a / c;  /**calculate the average*/
            Console.WriteLine("The average is {0}.", d);
        }
    }
}
