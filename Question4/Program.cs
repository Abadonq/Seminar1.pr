//Задача 4

int num1 = new Random().Next(1,10); 
int num2 = new Random().Next(1,10); 
int num3 = new Random().Next(1,10); 

if (num1 > num2 && num1>num3)
{
Console.WriteLine($"наибольшее число {num1} среди других чисел {num2} и {num3}" );
}

if (num2 > num1 && num2>num3)
{
Console.WriteLine($"наибольшее число {num2} среди других чисел {num1} и {num3}");
}

if (num3 > num2 && num3>num1)
{
Console.WriteLine($"наибольшее число {num3} среди других чисел {num1} и {num2}" );
}