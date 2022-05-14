///Найти расстояние между точками в пространстве 2D/3D (n пространстве)
Console.WriteLine("Введите размерность пространства (больше 1)");
int stepenS = int.Parse(Console.ReadLine());
double[] coordinates1 = new double[stepenS]; ///Массив для координат первой точки
double[] coordinates2 = new double[stepenS]; ///Массив для координат второй точки
double DistKvadrat = 0;                      ///квадрат расстояния между точками
for (int i = 0; i < stepenS; i++)            ///Внесение координат для точек
{
    Console.Write($"Введите {i + 1} коррдинату для первой точки ");
    coordinates1[i] = double.Parse(Console.ReadLine());
    Console.Write($"Введите {i + 1} коррдинату для второй точки ");
    coordinates2[i] = double.Parse(Console.ReadLine());
    DistKvadrat += (coordinates1[i] - coordinates2[i]) * (coordinates1[i] - coordinates2[i]);
}
Console.WriteLine("Координаты первой точки ({0})", String.Join("; ", coordinates1));
Console.WriteLine("Координаты второй точки ({0})", String.Join("; ", coordinates2));
Console.WriteLine("Расстояние между точками = " + Math.Sqrt(DistKvadrat));