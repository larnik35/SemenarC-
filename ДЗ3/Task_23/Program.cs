
//ConНапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
OutCubeNamber (N);


void OutCubeNamber (int namber){
    Console.WriteLine("Куб числа " + namber + " от 1");
    for (int i = 1; i <= namber; i++)
    {   double n = Math.Pow(i, 3);
        Console.Write(n);
        Console.Write(" ");
    }
}

