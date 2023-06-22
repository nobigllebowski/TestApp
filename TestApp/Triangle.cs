namespace TestApp
{
    public class Triangle : IShape
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            var isRight = Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
			return isRight;
        }
    }
}
