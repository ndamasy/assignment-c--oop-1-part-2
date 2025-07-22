namespace assignment_c3_oop_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // project 2
            //updated solution
            //double number1 = 10;
            //double number2 = 5;

            //Console.WriteLine("Add:"+ Maths.Add(number1,number2));
            //Console.WriteLine("Subtract:" + Maths.Subtract(number1, number2));
            //Console.WriteLine("Multiply:" + Maths.Multiply(number1, number2));
            //Console.WriteLine("Divide:" + Maths.Divide(number1, number2));


            // first solution 
            //   Maths Math=new Maths();
            //   double firstNumber;
            //   Console.Write("Enter a number: ");
            //   string input = Console.ReadLine();
            //   if (double.TryParse(input, out firstNumber))
            //   {
            //       Console.WriteLine("You entered: " + firstNumber);
            //   }
            //   else
            //   {
            //       Console.WriteLine("Invalid input. Please enter a valid number.");
            //   }
            //double secondNumber;
            //   Console.Write("Enter another number: ");
            //   string secondInput = Console.ReadLine();
            //   if (double.TryParse(secondInput, out secondNumber))
            //   {
            //       Console.WriteLine("You entered: " + secondNumber);
            //   }
            //   else
            //   {
            //       Console.WriteLine("Invalid input. Please enter a valid number.");
            //       return;
            //   }
            //   Console.WriteLine("Choose an operation: +, -, *,/");
            //   string operation = Console.ReadLine().ToLower();
            //   double result = 0;
            //   switch (operation)
            //   {
            //       case "+":
            //           result = Math.Add(firstNumber, secondNumber);
            //           break;
            //       case "-":
            //           result = Math.Subtract(firstNumber, secondNumber);
            //           break;
            //       case "*":
            //           result = Math.Multiply(firstNumber, secondNumber);
            //           break;
            //       case "/":
            //           if (secondNumber != 0)
            //           {
            //               result = Math.Divide(firstNumber, secondNumber);
            //           }
            //           else
            //           {
            //               Console.WriteLine("Error: Division by zero is not allowed.");
            //               return;
            //           }
            //           break;
            //       default:
            //           Console.WriteLine("Invalid operation selected.");
            //           return;
            //   }
            //   Console.WriteLine($"The result of {operation}ing {firstNumber} and {secondNumber} is: {result}");

            //-----------------------------------------------------
            // project 3
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());


        }
    }
}
