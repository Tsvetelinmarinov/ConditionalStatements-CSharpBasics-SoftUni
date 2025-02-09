/**
 * 06. Speed Info
 */


/**
•	При скорост до 10 (включително) отпечатайте "slow"
•	При скорост над 10 и до 50 (включително) отпечатайте "average" 
•	При скорост над 50 и до 150 (включително) отпечатайте "fast"
•	При скорост над 150 и до 1000 (включително) отпечатайте "ultra fast" 
•	При по-висока скорост отпечатайте "extremely fast"
*/


/**
 * 8	slow		49.5	average		126	fast		160	ultra fast		3500	extremely fast
 */



double speed = double.Parse(Console.ReadLine());
string outputMessage = "";


if (speed <= 10)
{
    outputMessage = "slow";
}
else if (speed > 10 && speed <= 50)
{
    outputMessage = "average";
}
else if (speed > 50 && speed <= 150)
{
    outputMessage = "fast";
}
else if (speed > 150 && speed <= 1000)
{
    outputMessage = "ultra fast";
}
else
{
    outputMessage = "extremely fast";
}


Console.WriteLine(outputMessage);