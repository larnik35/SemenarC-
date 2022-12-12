// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число");
bool intParse = int.TryParse(Console.ReadLine(), out int namber);
if (intParse == false )
{
   Console.WriteLine("Ведено не число");
   return; 
}
 int res = OutputSumNamber(namber);
Console.Write("Сумма цифр числа - " + namber + "  равна - " + res);



int OutputSumNamber(int nam){
int result = 0;
int rem = 0;
while (nam > 0)
{
    rem = nam % 10;
    nam = (nam - rem)/10;
    result = result + rem;
}
return result;
}




