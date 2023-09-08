using System;

namespace testClicknext.src
{
    public class DrawTriangle
    {
        public void drawTriangle4(int height)
        {
            for (int i = height; i >= 1; i--)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void drawTriangle5(int num)
        {
            int counter = 1;
            int maxWidth = num * 2 - 1;
            int spaces = maxWidth / 2;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= spaces; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write(counter % 10 + " ");

                    counter++;
                }

                Console.WriteLine();
                spaces--;
            }
        }

        public void drawTriangle10(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }


    }
}

