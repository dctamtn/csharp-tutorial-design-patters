namespace AbstractFactoryPattern
{
    public abstract class AbstractFactory
    {
        public abstract Shape getShape(string shape);
        public abstract Color getColor(string color);
    }
}