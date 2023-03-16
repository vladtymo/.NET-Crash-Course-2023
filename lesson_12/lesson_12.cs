using System;

public struct Point{
    public int X{get; set;}
    public int Y{get; set;}
    public Point(int x, int y){
        this.X = x;
        this.Y = y;
    }
    public override string ToString(){
        return string.Format("({0}, {1})", X, Y);
    }
}
public abstract class Shape{
    public string ShareType{get; protected set;}
    public Shape(string shareType){
        this.ShareType = shareType;
    }
    public abstract void Print();
}
public class Line : Shape{
    public Point Start{get; set;}
    public Point End{get; set;}
    public Line(Point start, Point end) : base("Line"){
        this.Start = start;
        this.End = end;
    }
    public override void Print(){
        Console.WriteLine("{0}: Start = {1}, End = {2}", ShareType, Start, End);
    }
}
public sealed class Rectangle: Shape{
    public Point TopLeft{get; set;}
    public int Height{get; set;}
    public int Width{get; set;}
    public Rectangle(Point topLeft, int height, int width) : base("Rectangle"){
        this.TopLeft = topLeft;
        this.Height = height;
        this.Width = width;
    }
    public override void Print(){
        Console.WriteLine("{0}: TopLeft = {1}, Height = {2}, Width = {3}", ShareType, TopLeft, Height, Width);
    }
}

public sealed class Polyline: Shape{
    public Point[] Points{get; set;}
    public Polyline(Point[] points) : base("Polyline"){
        this.Points = points;
    }
    public override void Print(){
        for(int i=0; i<Points.Length; ++i){
            Console.Write(Points[i]);
            if(i<Points.Length-1){
                Console.WriteLine("");
            }
        }
        Console.WriteLine();
    }
}

class Program{
    static void Main(){
        Line line = new Line(new Point(0, 0), new Point(7, 7));
        line.Print();
        Rectangle rectangle = new Rectangle(new Point(0, 0), 5, 10);
        rectangle.Print();
        Polyline polyline = new Polyline(new Point[]{new Point(0, 0), new Point(1, 1), new Point(2, 2)});
        polyline.Print();
    }
}