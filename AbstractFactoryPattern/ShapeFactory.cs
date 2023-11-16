using System;

namespace AbstractFactoryPattern
{

    public class ShapeFactory:AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            if (string.IsNullOrEmpty(shapeType))
                return null;
            switch (shapeType.ToUpper())
            {
                case "RECTANGLE":
                    return new Rectangle();
                case "SQUARE":
                    return new Square();
                case "CIRCLE":
                    return new Circle();
            }
            return null;
        }

        public override Color getColor(string color)
        {
            return null;
        }
    }

    public interface Shape
    {
        void draw();
    }

    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw square");
        }
    }
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }

    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
}
