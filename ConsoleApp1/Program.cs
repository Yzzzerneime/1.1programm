namespace AreaComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Взаимодействие с пользователем
            double radius = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());
            
            // Логика
            string result = Logic.CompareAreas(radius, side);
            
            // Взаимодействие с пользователем
            Console.WriteLine(result);
        }
    }
}