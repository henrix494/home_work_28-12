using System;

namespace DefaultNamespace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // תחילת משימה 1

            int numOfFirstTask;
            Console.WriteLine("Enter a number to find out what his *4 and -2");
            numOfFirstTask = int.Parse(Console.ReadLine());
            Console.WriteLine("The * 4 of the number {0} is : {1}\nThe - 2 of the Number {0} is : {2}\n", numOfFirstTask, numOfFirstTask * 4, numOfFirstTask - 2);

            // סיום משימה 1

            // התחלה של משימה 2

            int firstNumberOfTaskTwo;
            int secoundNumberOfTaskTwo;
            Console.WriteLine("Enter two numbers to calc the perimeter and the area of a squre   ");
            firstNumberOfTaskTwo = int.Parse(Console.ReadLine());
            secoundNumberOfTaskTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("the area of the square is {0} and the perimeter is : {1}", firstNumberOfTaskTwo * secoundNumberOfTaskTwo, 2 * (firstNumberOfTaskTwo + secoundNumberOfTaskTwo));

            //סיום משימה 2


            //התחלה של משימה 3

            //דרך ראשונה

            Console.WriteLine("    1    \n   222   \n  33333  \n 4444444 \n555555555");

            //סיום דרך ראשונה

            //דרך שניה

            int numRows = 5;

            for (int i = 1; i <= numRows; i++)
            {

                for (int j = 0; j < numRows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write(i);

                }

                Console.WriteLine();


            }

            //סיום דרך שנייה
            //סיום משימה 3


            //התחלה של משימה 4
            Console.WriteLine("   *   \n  * *  \n *   * \n*     *\n *   * \n  * *  \n   *   ");

            //סיום של משימה 4


            // התחלה של משימה 5


            int firstNumberOfTaskFive, secoundNumberOfTaskFive, thirdNumberOfTaskFive;

            Console.WriteLine("Enter 3 number to get the sum of them");

            firstNumberOfTaskFive = int.Parse(Console.ReadLine());

            secoundNumberOfTaskFive = int.Parse(Console.ReadLine());

            thirdNumberOfTaskFive = int.Parse(Console.ReadLine());

            Console.WriteLine("the sum of {0}+{1}+{2} = {3}", firstNumberOfTaskFive, secoundNumberOfTaskFive, thirdNumberOfTaskFive, firstNumberOfTaskFive + secoundNumberOfTaskFive + thirdNumberOfTaskFive);

            //סיום של משימה 5


            //התחלה של משימה 6

            int firstNumberOfTaskSix, secoundNumberOfTaskSix, thirdNumberOfTaskSix;

            Console.WriteLine("Enter 3 number to get there ***");

            firstNumberOfTaskSix = int.Parse(Console.ReadLine());
            secoundNumberOfTaskSix = int.Parse(Console.ReadLine());
            thirdNumberOfTaskSix = int.Parse(Console.ReadLine());

            Console.WriteLine("The * of {0} * {1} * {2} = {3}", firstNumberOfTaskSix, secoundNumberOfTaskSix, thirdNumberOfTaskSix, firstNumberOfTaskSix * secoundNumberOfTaskSix * thirdNumberOfTaskSix);

            //סיום של משימה 6


            //התחלה של משימה 7

            int firstNumberOfTaskSeven, secoundNumberOfTaskSeven, thirdNumberOfTaskSeven, fourhNumberOfTaskSeven;
            Console.WriteLine("Enter foure number to get there sum for this task");

            firstNumberOfTaskSeven = int.Parse(Console.ReadLine());
            secoundNumberOfTaskSeven = int.Parse(Console.ReadLine());
            thirdNumberOfTaskSeven = int.Parse(Console.ReadLine());
            fourhNumberOfTaskSeven = int.Parse(Console.ReadLine());

            Console.WriteLine(" the sum of the plus of the number {4} + {6} = {0}\n the sum of - of the number {5} - {7} = {1} \n the sum of / of the number {6} / 8 = {2}\n" +
                "the * of the number {7} * {4} = {3}"
                , firstNumberOfTaskSeven + thirdNumberOfTaskSeven/* index zero */
                , secoundNumberOfTaskSeven - fourhNumberOfTaskSeven /*index one*/
                , thirdNumberOfTaskSeven / 8  /*index two*/
                , fourhNumberOfTaskSeven * fourhNumberOfTaskSeven/*index three*/
                , firstNumberOfTaskSeven /*index four*/
                , secoundNumberOfTaskSeven /*index five*/
                , thirdNumberOfTaskSeven /*index six*/
                , fourhNumberOfTaskSeven /*index seven*/
                );

            //סיום של משימה 7

        }

    }
}
