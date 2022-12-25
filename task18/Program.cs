// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int Range = Convert.ToInt32(Console.ReadLine());

// if(Range == 1)
// {
    // Console.WriteLine("X > 0 && Y > 0");
// }
// else if(Range == 2)
// {
    // Console.WriteLine("X < 0 && Y > 0");
// }
// else if(Range == 3)
// {
    // Console.WriteLine("X < 0 && Y < 0");
// }
// else if(Range == 4)
// {
    // Console.WriteLine("X > 0 && Y < 0");
// }
// else
// {
   //  Console.WriteLine("Неверный ввод");
// }

string[] quarters = {"X > 0 && Y > 0",
                    "X < 0 && Y > 0",
                    "X < 0 && Y < 0",
                    "X > 0 && Y < 0"};

 Console.Write("Введите цифру плосскости координат ");
 int quater = Convert.ToInt32(Console.ReadLine());
 if(quater >= 1 && quater <= 4)
 {
    Console.WriteLine(quarters[quater -1]);
 }
 else
 {
    Console.WriteLine("Неверный ввод" );
 }                   