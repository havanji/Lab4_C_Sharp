using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

//Основний батьківсткий клас
abstract public class Shape
{
    private string name;

    public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public void Figure(string Name)
	{
		Console.WriteLine($"Це {this.Name}");
	}

	public abstract double Area();

	public abstract double Perimeter();
}

//Коло (Sircle), нащадок Shape
public class Circle : Shape
{   
    //Радіус для подаальшого обчислення
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    //Переписаний Area для обслення площі 
    public override double Area() 
	{
        double area;
        area = Math.Round(Math.PI * this.radius, 2);
        return area;
	}

    //Переписаний Perimeter для обслення ериметру 

    public override double Perimeter()
    {
        double perimeter;
        perimeter = Math.Round(2* Math.PI * this.radius, 2);
        return perimeter;
    }
}

//Квадрат (Square), нащадок Shape
public class Square : Shape
{
    //Сторона для подальшого обчислення
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    //Переписаний Area для обслення площі 
    public override double Area()
    {
        double area;
        area = Math.Round(4 * this.side, 2);
        return area;
    }

    //Переписаний Perimeter для обслення ериметру 
    public override double Perimeter()
    {
        double perimeter;
        perimeter = Math.Round(this.side * this.side, 2);
        return perimeter;
    }
}