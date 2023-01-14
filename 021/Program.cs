// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

Console.Write("Введите координату X точки A: ");
int Ax = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y точки A: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z точки A: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double AB = Convert.ToDouble(Math.Sqrt(Math.Pow(Ax - Bx,2) + Math.Pow(Ay - By,2) + Math.Pow(Az - Bz,2)));
Console.WriteLine($"Расстояние между точками А и В равно: {AB:f3}");