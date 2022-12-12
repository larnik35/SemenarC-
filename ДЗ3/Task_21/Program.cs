// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точки А");
Console.Write("x = ");
int ax = int.Parse(Console.ReadLine());
Console.Write("y = ");
int ay = int.Parse(Console.ReadLine());
Console.Write("z = ");
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("x = ");
int bx = int.Parse(Console.ReadLine());
Console.Write("y = ");
int by = int.Parse(Console.ReadLine());
Console.Write("z = ");
int bz = int.Parse(Console.ReadLine());

PrintLengthSegment(ax, ay, az, bx, by, bz); // Вызов метода

void PrintLengthSegment(int ax, int ay, int az, int bx, int by, int bz)
{
    double ab = Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2) ; 
    double AB = Math.Sqrt(ab);
    Console.WriteLine("Длинна отрезка по трем координатам = " + Math.Round((Decimal)AB, 2));
    
}