/**
 * Gues the password
 */


string definedPassword = "s3cr3t!P@ssw0rd";


string inputStream = Console.ReadLine();


//При съвпадение да се изведе "Welcome". При несъвпадение да се изведе "Wrong password!".


if (inputStream == definedPassword)
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("Wrong password!");
}
