public class Rhombus : Square
{
    private double _d1;
    private double _d2;


    public double D1 { get => _d1; set => ValidateD1(value); }
    public double D2 { get => _d2; set => ValidateD2(value); }


    public Rhombus(double d1, double d2)
    {
        D1 = d1;
        D2 = d2;
        Name = "Rhombus";
        A = Math.Sqrt(Math.Pow(D1 / 2, 2) + Math.Pow(D2 / 2, 2));

    }

    public override double GetArea()
    {
        return ((D1 * D2) / 2);
    }

    public override double GetPerimeter()
    {
        return base.GetPerimeter();
    }

    private void ValidateD1(double d1)
    {
        if (d1 < 0)
        {
            throw new ArgumentOutOfRangeException("the diagonal must be greater than 0");
        }
        _d1 = d1;
    }


    private void ValidateD2(double d2)
    {
        if (d2 < 0)
        {
            throw new ArgumentOutOfRangeException("the diagonal must be greater than 0");
        }
        _d2 = d2;

    } 
}