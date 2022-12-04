//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите трехзначное число");
bool isParse = int.TryParse(Console.ReadLine(), out int namber);
int con = 0;
int rem = 0;
if (isParse == false)
{
   Console.WriteLine("Вводите цифра");
    return;
} else {
con = namber - 100;
if (con < 0)
{
  Console.WriteLine("У числа - " + namber + "  нет третьей цифры"); 
}
else {
for (int i = 0; i < 3; i++)
{
   rem = namber % 10;
   namber = (namber - rem)/10; 
}
Console.WriteLine("Третья цифра - " + rem);
}
}










