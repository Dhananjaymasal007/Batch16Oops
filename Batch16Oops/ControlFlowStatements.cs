using System.ComponentModel.Design;

namespace Batch16Oops
{
    internal class ControlFlowStatements
    {
        static void Main()
        {

            //if statement

            int Age = 45;

            if (Age == 65)
            {
                Console.WriteLine("The Person is in Senior citizionship");
            }




            //if-else statement

            string username = "Test1";
            if (username == "Test")
            {
                Console.WriteLine("This is a Active User");
            }
            else
            {
                Console.WriteLine("This is Invalid User");
            }

            //IF-else -if or nested 

            int Number = 110;

            if (Number == 0)
            {
                Console.WriteLine("THis number is positive");
            }
            else if (Number < 0)
            {
                Console.WriteLine("This number is Negative");
            }
            else if (Number > 100 && Number <200)
            {
                Console.WriteLine("The number between 100 to 200");
            }

            else
            {
                Console.WriteLine("The number below 100");
            }

            //Looping Statement
            //Switch 

            int Day = 3;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;

            }

            //for Loop


            int n = 5;

            //<variableiniitlization;iterationconditions;iteration increment/decrement>
            for (n=0; n<5; n++)
            {
                Console.WriteLine("Iteration:"+n);
            }


            //while loop-- entry control loop


            int i = 0;
            while (i<0)
            {
                Console.WriteLine("iterations in while loop  "+ i);
                i++;

            }


            //do while loop -Exit control loop

            int j = 0;
            do
            {
                Console.WriteLine("Iteration in do while loop: "+ j);
                j++;
            } while (j<0);



            //For Each Loop

            string[] Fruits = { "Apple", "Mango", "Orange", "Banana", "Pineapple", "Strawberry", "kivi" };



            foreach (string fruit in Fruits)
            {
                Console.WriteLine("THe fruit is " + fruit);

            }


            //3 Junmping statment


            //continue


            for (i = 0; i < 5; i++)
            {
                if (i ==3)
                {
                    continue;
                }

                Console.WriteLine("Iteratin:"+ i);

            }

            //go to

            int count = 0;
        startloop:

            if (count < 5)
            {

                Console.WriteLine($"Count is {count}");
                count++;
                goto startloop;




                Console.WriteLine($"after go to count is {count}");
            }
                Console.WriteLine("loop with go to finished ");




            //}


















        }
    }
}
