//Задача 8

int N = new Random().Next(1,100); 
int count=1;

while (count < N+1)
{
    if (count%2==0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}

Console.WriteLine($"Загадываемое число:{N}");


