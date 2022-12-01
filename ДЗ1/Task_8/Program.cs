// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int D = N;
int d = 0;
Console.WriteLine("Начинаю магию");
for (int i = 0; i < N; i = i + 1)
{  d = D;
   d = d%2;
   if (d == 0)
   { Console.WriteLine(D);
   }
D = D-1;   
}
