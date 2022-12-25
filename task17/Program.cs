// Напишите программу, которая принимает на вход координаты точки (X и Y) 
// причем Х и У не равны 0 и выдает номер четверти плоскости в котор наход эта точка.

Console.Write("Введите координаты Х: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("ТОчка находится в третьей четверти");
}
else
{
    Console.WriteLine("Точка находиться в четвертой четверти");
}