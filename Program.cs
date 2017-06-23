using System;
public class Exercise7
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num1= Convert.ToInt32(Console.ReadLine());//takes user input and converts it to an int from the string
 
        Console.Write("Enter another number: ");
        int num2= Convert.ToInt32(Console.ReadLine());
   
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2); //adds nums
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2); //subtracts nums
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2); //multiplies nums
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2); //divides nums
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2); //modulus nums
   }
}
