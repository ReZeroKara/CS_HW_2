//Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int[] array = {0, 1, 2, 3, 4, 5, 6, 7};

Console.Write("Введите номер дня недели: ");
int find = int.Parse(Console.ReadLine());

int n = array.Length;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        if(find == array[6])
        {
            Console.WriteLine("Суббота, это выходной!");
        }
        else if(find == array[7])
        {
            Console.WriteLine("Воскресенье, это выходной!");
        }
        else
        {
            Console.WriteLine("Это не выходной!");
        }
        break;
    }
    index++;
}