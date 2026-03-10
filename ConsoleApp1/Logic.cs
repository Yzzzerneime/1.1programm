namespace AreaComparison
{
    public class Logic
    {
        public static string CompareAreas(double radius, double side)
        {
            double circleArea = 3.14 * radius * radius;
            double squareArea = side * side;

            if (squareArea > circleArea)
                return "квадрат больше!";
            else if (squareArea == circleArea)
                return "Одинаковые!";
            else
                return "круг больше!";
        }

        public static double GetCircleArea(double radius)
        {
            return 3.14 * radius * radius;
        }

        public static double GetSquareArea(double side)
        {
            return side * side;
        }
    }
}