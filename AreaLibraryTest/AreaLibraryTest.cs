namespace AreaLibraryTest;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void Should_ImplementIShape()
    {
        Circle s = new Circle(2);

        Assert.IsInstanceOfType(s, typeof(IShape));
    }

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(-2)]
    public void Should_ThrowIfRadiusNegativeOrZero(double radius)
    { 
        Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
    }

    [DataTestMethod]
    [DataRow(1, Math.PI)]
    [DataRow(2, Math.PI * 4)]
    [DataRow(3, Math.PI * 9)]
    public void Should_CalculateArea(double radius, double expectedResult)
    {
        Circle s = new Circle(radius);

        Assert.AreEqual(expectedResult, s.Area);
    }
}

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Should_ImplementIShape()
    {
        Triangle s = new Triangle(3,4,5);

        Assert.IsInstanceOfType(s, typeof(IShape));
    }

    [DataTestMethod]
    [DataRow(0, 4, 5)]
    [DataRow(3, -4, 5)]
    [DataRow(3, 4, -5)]
    public void Should_ThrowIfAnySideNegativeOrZero(double sideA, double sideB, double sideC)
    { 
        Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [TestMethod]
    public void Should_ThrowIfSidesCantFormTriangle()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 3, 5));
    }

    [DataTestMethod]
    [DataRow(3, 4, 5, 6)]
    [DataRow(30, 28, 26, 336)]
    public void Should_CalculateArea(double sideA, double sideB, double sideC, double expectedResult)
    {
        Triangle s = new Triangle(sideA, sideB, sideC);

        Assert.AreEqual(expectedResult, s.Area);
    }

    
    [DataTestMethod]
    [DataRow(3, 4, 5, true)]
    [DataRow(3, 3, 3, false)]
    public void Should_DetectOrtogonal(double sideA, double sideB, double sideC, bool expectedResult)
    {
        Triangle s = new Triangle(sideA, sideB, sideC);

        Assert.AreEqual(expectedResult, s.IsOrtogonal);

    }

}