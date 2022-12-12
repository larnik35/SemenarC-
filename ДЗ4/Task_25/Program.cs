// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// Не использовать метод Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine());
ExponentiationNamber(A, B);


void ExponentiationNamber( int a, int b){
double result = A;
int i = 1;
while (i < B)
{
    result = result * A;
    i = i + 1;
}
Console.WriteLine("Число - " + A + " в степени -  " + B + "  Будет равняться " + result);
}