namespace Figures_Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString() 
        {
            return $"{Name,-15} => Area.....: {GetArea(),12:F5}   Perimeter: {GetPerimeter(),12:F5}";
        }
    }
}