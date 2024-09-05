namespace Figure
{
    public interface IFigure //интерфейс для получения площади фигур
    {
        double GetArea();
    }

    //Класс для вычисления площади любой фигуры
    public class FigureArea
    {
        //вычисление площади фигур без знания этой фигуры
        public double CalculateArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
