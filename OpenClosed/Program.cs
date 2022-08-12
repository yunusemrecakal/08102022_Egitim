Square square = new Square();
Circle circle = new Circle();

double getArea(Object shape)
{
    if (shape == square)
    {
        return square.length * square.height;
    }
    else if (shape == circle)
    {
        return circle.radius * circle.radius * Math.PI;
    }
    else return 0;
}

public interface Shape
{
    public double getArea();
}
public class Square : Shape
{
    public int height { get; set; }
    public int length { get; set; }
    public double getArea()
    {
        return height * length;
    }
}
public class Circle : Shape
{
    public int radius { get; set; }

    public double getArea()
    {
        return radius * radius * Math.PI;
    }
}