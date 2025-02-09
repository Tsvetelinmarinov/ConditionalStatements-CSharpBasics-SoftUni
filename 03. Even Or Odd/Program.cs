/**
 * Even or odd number
 */


/**
 * 
 * 2	even		3	odd		25	odd		1024	even
 */



int inputNumber = int.Parse(Console.ReadLine());


if (inputNumber % 2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}
