using System;

Console.WriteLine("--- Exercise 01 ---");
Console.WriteLine("Introduce un número:");
int num = Convert.ToInt16(Console.ReadLine());
int index = 1;

while (index <= 10)
{
    Console.WriteLine($"{num} * {index} : { num * index}");
    index++;
}

Console.WriteLine("--- Exercise 02 ---");
Console.WriteLine("Introduce un total de 5 números:");

int contPositive = 0, contNegative = 0, cont = 0;
do
{
    int num2 = Convert.ToInt16(Console.ReadLine());
    if (num2 >= 0)
        contPositive++;
    else
        contNegative++;
    cont++;
} while (cont < 5);
Console.WriteLine($"Número total de positivos: {contPositive} y número total de negativos: {contNegative}");

Console.WriteLine("--- Exercise 03 ---");
Console.WriteLine("Introudce el ancho:");
int width = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Introudce el alto:");
int height = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Introudce si es relleno o no:");
bool filled = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Introudce el número de cuadrados/rectángulos:");
int times = Convert.ToInt16(Console.ReadLine());

while(times > 0) {
    if (filled)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
    else
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
        for (int i = 1; i <= height - 2; i++)
        {
            Console.Write('*');
            for (int j = 1; j <= width - 2; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
        for (int j = 1; j <= width; j++)
        {
            Console.Write('*');
        }
    }
    times--;
    Console.WriteLine();
}