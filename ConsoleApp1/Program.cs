try
{
    Console.WriteLine("старт");
    Console.WriteLine("введите x");
    double x = double.Parse(Console.ReadLine());
    double res = (x * x - 7 * x) / (x * x - 8 * x + 12);
    Console.WriteLine(res);
    Console.WriteLine("конец");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());   
}