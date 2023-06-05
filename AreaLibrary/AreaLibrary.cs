namespace AreaLibrary;

public interface IShape
{
    double Area { get; }
}

public class Circle:IShape
{
    private double _radius;
    public double Radius => _radius;
    
    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        if(radius <= 0) throw new ArgumentException("Radius must be positive");

        _radius = radius;
    }
}

public class Triangle:IShape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if(sideA <= 0 || sideB <= 0 || sideC <= 0) throw new ArgumentException("All sides must be positive");
        if(sideA + sideB <= sideC || sideC + sideA <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Sides must be able to form a valid triangle");
        
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double SideA => _sideA;
    public double SideB => _sideB;
    public double SideC => _sideC;

    private double SemiPerimeter => (SideA + SideB + SideC)/2;
    public double Area => 
        Math.Sqrt(SemiPerimeter * (SemiPerimeter - SideA) * (SemiPerimeter - SideB) * (SemiPerimeter - SideC));
    public bool IsOrtogonal
    {
        get
        {
            double aSquare = SideA * SideA;
            double bSquare = SideB * SideB;
            double cSquare = SideC * SideC;

            return aSquare + bSquare == cSquare || bSquare + cSquare == aSquare || aSquare + cSquare == bSquare;
        }
    }
}