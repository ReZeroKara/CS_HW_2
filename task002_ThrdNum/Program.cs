//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

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
    int first = fint("a");
    Console.WriteLine(first);
}

int fint(string num)
{
    int charm = Readint("n");

    if(charm > 100)
    {
      charm = charm % 10;
      return charm;  
    }
    else
    {
        Console.WriteLine("Третьей цифры нет!");
        return charm;
    }
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