using System;

namespace AbstractFactoryPattern
{
    public class ColorFactory:AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            return null;
        }
        public override Color getColor(string color)
        {
            if (string.IsNullOrEmpty(color))
                return null;
            switch (color.ToUpper())
            {
                case "RED":
                    return new Red();
                case "GREEN":
                    return new Green();
                case "BLUE":
                    return new Blue();
            }
            return null;
        }
    }

    public interface Color
    {
        void fill();
    }

    public class Blue : Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Blue:fill() method");
        }
    }

    public class Green : Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Green:fill() method");
        }
    }

    public class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("Inside Red:fill() method");
        }
    }

}
