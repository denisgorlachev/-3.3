// Горлачев 
Console.WriteLine("Введите число n: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число x: ");
double x = double.Parse(Console.ReadLine());
double s = 0;
double z = 1;
for (int i = 0; i < n; i += 1)
{
    z *= 2;
    s = Math.Pow(x, z)*Math.Cos(z * Math.PI / 3) / z;

}
Console.WriteLine("Ответ: " + s);
