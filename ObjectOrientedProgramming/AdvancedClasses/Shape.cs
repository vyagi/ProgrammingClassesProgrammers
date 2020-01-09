namespace AdvancedClasses
{
    public abstract class Shape
    {
        protected double _density = 1;
        public abstract double Area();
        public virtual double Weight()
        {
            return Area() * _density;
        }
    }
}
