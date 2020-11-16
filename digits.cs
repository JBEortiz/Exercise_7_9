using System;

class digits
{
    /**We have organized the code so that it remains clean, using a more optimal and standardized comment format, we have also placed
     * the parentheses in the logical conditions to make it easier to read the code,
     * finally we have declared all the variables at the beginning of our program */
    static void Main()
 {
        /**counters of number of digits a is for one digit, b is for 2 digits, c is for 3 digits and d is for more than 3 digits*/
        int a = 0, b = 0, c = 0, d = 0, input;
        string e; 
        Console.Write("Insert a number: ");
        /** read the number as string to check the word "end"*/
        e = Console.ReadLine();
        while (e != "end")
        {
            input = Convert.ToInt32(e);
            if (input != 0)
            {
                if (input / 10 == 0)
                {
                    a++;   /** it only has one digit*/
                }
                else
                {
                    if (input / 100 == 0)
                    {
                        b++;   /** the number has 2 digits*/
                    }
                    else if (input / 1000 == 0)
                    {
                        c++;   /** the number has 3 digits*/
                    }
                    else
                    {
                        d++;   /** the number has more than 3 digits*/
                    }
                }
            }
            e = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", a, b, c, d);
    }

}

