using Figure;

namespace FigureTest
{
    public class Tests
    {
        [Test]
        public void CircleAreaTest()
        {
            Circul circle = new(5);
            
            double result = circle.GetArea();
            double corr_result = Math.PI * Math.Pow(5, 2);
            
            Assert.AreEqual(corr_result, result);
        }

        [Test]
        public void TriangleAresTest()
        {
            Triangle triangle = new(9, 8, 10);

            double result = triangle.GetArea();
            double corr_result = 34.197039345533994;                

            Assert.AreEqual(corr_result, result);
        }

        [Test]
        public void RightTriangleTest()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.IsTrue(triangle.RightTriangle());
        }

        [Test]
        public void NonRightTriangleTest() 
        {
            Triangle triangle = new(3, 4, 6);
            Assert.IsFalse(triangle.RightTriangle());
        }

        [Test]
        public void AnyFigureAreaTest_Circle()
        {
            FigureArea area = new();
            Circul circul = new(7);
            double corr_result = Math.PI * Math.Pow(7, 2);
            double result = area.CalculateArea(circul);

            Assert.AreEqual(corr_result, result);
        }

        [Test]
        public void AnyFigureAreaTest_Triangle()
        {
            FigureArea area = new();
            Triangle triangle = new(5, 6, 7);

            double result = area.CalculateArea(triangle);
            double p = (5 + 6 + 7) / 2;
            double corr_result = Math.Sqrt(p * (p - 5) * (p - 6) * (p - 7));

            Assert.AreEqual(corr_result, result);
        }
    }
}