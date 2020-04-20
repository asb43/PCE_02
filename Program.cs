using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone and welcome to another Five nights at Freddy's episode, Today we are gonna become THE KING OF FIVE NIGHTS AT FREDDY's");

             Conditional_Statements cs = new Conditional_Statements();
             cs.RunExercise();

             Comparison_Operators co = new Comparison_Operators();
             co.RunExercise();

             IO_Operators ioo = new IO_Operators();
             ioo.RunExercise();
            
             Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            /ivrd.RunExercise();

            // Clearly, you will need to uncomment these to test them...
             Modulus_Operator mo = new Modulus_Operator();
             mo.RunExercise();

             Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
             ftc.RunExercise();
         }
    }

    class Conditional_Statements
    {
        public void RunExercise()
        {
            Console.WriteLine("About to do the \"Conditional Statements\" exercise");
            Conditional_Methods cm = new Conditional_Methods();
            cm.UsingIf();
            cm.UsingIfElse();
            cm.UsingSwitch();
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {
           // Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
            Console.WriteLine("please input a number");
            int numOne = 0;
            string input1 = "";
            input1 = Console.ReadLine();
            Int32.TryParse(input1,out  numOne);
            Console.WriteLine("please input a second number");
            int numTwo = 0;
            string input2 = "";
            input2 = Console.ReadLine();
            Int32.TryParse(input2, out numTwo);
            if ((numOne - numTwo <=5 && numOne - numTwo >= 0 )|| (numTwo - numOne <= 5 && numTwo - numOne >= 0))
            {
                Console.WriteLine("both inputs are within 5 integers of each other");

            }
            else
            {
                Console.WriteLine("The inputs are not within 5 integers of each other");
            }
        }
    }


    class IO_Operators
    {
        public void RunExercise()
        {
        }
    }

    class Conditional_Methods
    {
        public void UsingIf()
        {
            Console.WriteLine("please input a number");
            int x = 0;
            string szInput;
            szInput = Console.ReadLine();
            if (Int32.TryParse(szInput, out x) == true)
            {
                Console.WriteLine("The number you typed is: {0}", x);
            }


        }

        public void UsingIfElse()
        {
            Console.WriteLine("please input a number");
            int x = 0;
            string szInput;
            szInput = Console.ReadLine();
            if (Int32.TryParse(szInput, out x) == true)
            {
                Console.WriteLine("The number you typed is: {0}", x);
            }
            else
            {
                Console.WriteLine("You failed to type a number");
            }
        }
        public void UsingSwitch()
        {
            Console.WriteLine("please input a number");
            int x = 0;
            string szInput;
            szInput = Console.ReadLine();
            switch (Int32.TryParse(szInput, out x))
            {
                case true:
                    Console.WriteLine("You wrote {0}",x);
                    break;
                default:
                    Console.WriteLine("Input a valid NUMBER!!!");
                    break;
            }
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
            int x = 6;
            int y = 3;
            int z = x / y;
            Console.WriteLine(z);

            int a = 7;
            int c = 3;
            double b = a / c;
            Console.WriteLine(b);

            float e = 7f / 3f;
            Console.WriteLine(e);

            float j = 6f / 3f;
            Console.WriteLine(j);

            double f = 6;
            double g = 3;
            double k = f / g;
            Console.WriteLine(k);

            double h = 7;
            double i = 3;
            double l = h / i;
            Console.WriteLine(l);

            //floats and doubles can be used for decimal expressions floats are 32bit and double is 64 bit floats wont hold thus floats are for smaller expressions but you should end your number with an f

        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
            int x = 10;
            int y = 3;
            int z = x / y;
            Console.WriteLine(z);
            Console.WriteLine(x % y);

            Console.WriteLine("please input a number");
            int numOne = 0;
            string input1 = "";
            input1 = Console.ReadLine();
            Int32.TryParse(input1, out numOne);

            Console.WriteLine("please input a second number");
            int numTwo = 0;
            string input2 = "";
            input2 = Console.ReadLine();
            Int32.TryParse(input2, out numTwo);

            int outPut = numOne / numTwo;
            Console.WriteLine("Your output is" + outPut);
            Console.WriteLine("And the Mod for this is" + (numOne % numTwo));
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
            int Fahrenheit = 0;
            Console.WriteLine("Please input a Fahrenheit number that will be converted to celsius");
            string input1 ="";
            input1 = Console.ReadLine();
            Int32.TryParse(input1, out Fahrenheit);

            int Celsius = (5 / 9) * (Fahrenheit - 32);
            Console.WriteLine("Congrats your calculation is" + Celsius + "degrees Celsius");
        }
    }

    class Logical_Operators
    {
        // Your answer goes here,in a comment like this one
        //1. true y is > 1
        //2. false 
        //3. true z is > than 8
        //4. false z is > 8
        //5. false zis >  and y is < 3
        //6.false 
        //7. true
        //8. true
        //9. false
        //10.false
        // Side-Note: Notice that this class has NO methods, and that it still compiles :)
    }
}