Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodByu();
}


static void PrintHello() //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodByu()
{
    Console.WriteLine("See you later, aligator. ");
}