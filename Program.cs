// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("---------------- LEC_05_HW: ----------------");
Console.WriteLine("--------------------------------------------\n");

Console.WriteLine("------------- EX 1: -------------");
Console.WriteLine("---------------------------------\n");

int counter = 1;
while (true)
{
    Console.WriteLine("\nEnter Number:");
    int.TryParse(Console.ReadLine(),out int num);
    counter++;

    if (num == 23)
    {
        break;
    }
}
Console.WriteLine("While Broke After: {0} Times", counter);

Console.WriteLine("---------------------------------\n");

/*************************************************************/

Console.WriteLine("\n------------- EX 2: -------------");
Console.WriteLine("---------------------------------\n");

int x = 1;
int b = 2;

b =b-x;
x = b+b;

Console.WriteLine("X = {0}\nB = {1}",x,b);

Console.WriteLine("---------------------------------\n");