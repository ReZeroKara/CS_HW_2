// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Main();

void Main()
{
    bool isWorking = true;

    while(isWorking)
    {
        Console.Write("Input task: ");

        string task = Console.ReadLine();

        switch(task)
        {
            case "exit": isWorking = false; break;
            case "t1": Task1(); break;
            default:
            break;
        }
    }
}

void Task1()
{
    int first = sint("a");
    Console.WriteLine(first);
}

int sint(string numb)
{
    int charm1 = fint("n");
    charm1 = charm1 % 10;
    return charm1;
}

int fint(string num)
{
    int charm = Readint("n");
    charm = charm / 10;
    return charm;
}

int Readint(string argument)
{
    int number;

    Console.Write($"Input {argument}:");

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}
