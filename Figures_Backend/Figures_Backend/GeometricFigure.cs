namespace Figures_Backend
{
    public abstract class GeometricFigure
    {
        public String Name { get; set; }


      
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string Tostring() {


            return ($"{Name} - Area: {GetArea():F2}, perimeter: {GetPerimeter():F2}");

        }



    }
}
