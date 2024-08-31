using System;

public class NumberPattern
{
    public static void Main()
    {
        int Cols = 9;
        int whiteCols = Cols+1;

        int RedCount = 1;
        int WhiteCount = 1;

        for (int i = 1; i <= (Cols / 2)+1; i++)
        {
            Console.WriteLine();
            whiteCols -= 2;
            for (int j = 1; j <= i; j++)
            {
                Console.Write(RedCount + " ");
                RedCount++;
            }
            for (int j = 1; j <= whiteCols; j++)
            {
                Console.Write(" " + WhiteCount + " ");
                WhiteCount++;
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" " + RedCount);
                RedCount++;
            }
        }
        for (int i = Cols/2; i >= 1; i--)
        {
            Console.WriteLine();
            whiteCols += 2;
            for (int j = 1; j <= i; j++)
            {
                Console.Write(RedCount + " ");
                RedCount++;
            }
            for (int j = 1; j <= whiteCols; j++)
            {
                Console.Write(" " + WhiteCount + " ");
                WhiteCount++;
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(" " + RedCount);
                RedCount++;
            }
            
        }
    }
}
