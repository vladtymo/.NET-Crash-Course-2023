namespace Tasks_11
{
	public struct Cordinates
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Cordinates(int x, int y)
		{
			X = x; Y = y;
		}
	}
	public abstract class Shape
	{
		public string Name { get; set; }
		
		public Shape(string name)
		{
			Name = name;
			

		}
		public abstract void Print();
		
	}

	public class Rectangle : Shape
	{
		public Cordinates UpperLeftCornerCordinate { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public Rectangle(Cordinates UpperLeftCornerCordinate, int Width,int Height) : base("Rectangle") 
		{
			this.UpperLeftCornerCordinate = UpperLeftCornerCordinate;
			this.Width = Width;
			this.Height = Height;
		}

		public double GetSquare()
		{
			return Width * Height;
		}

		public override void Print()
		{
			Console.WriteLine($"Rectangle\n" + $"Upper-Left Corner Cordinates: X = {UpperLeftCornerCordinate.X} Y = {UpperLeftCornerCordinate.Y}\n" + $"Width - {Width}\n" + $"Height - {Height}\n" + $"");
		}
	}

	public class Line : Shape
	{
		public Cordinates StartCordinate { get; set; }
		public Cordinates EndCordinate { get; set; }

		public Line(Cordinates start, Cordinates end) : base("Line")
		{
			StartCordinate = start;
			EndCordinate = end;
		}
        
		public override void Print()
		{
			Console.WriteLine(
				$"Line\n" +
				$"Start at X={StartCordinate.X} Y = {StartCordinate.Y}\n" +
				$"End at X = {EndCordinate.X} Y = {EndCordinate.Y}\n");
		}
	}

	public class Polyline : Shape
	{
		public List<Cordinates> cordinatesArr;

		public Polyline() : base("Polyline")
		{
			cordinatesArr = new List<Cordinates>();
		}

		public void AddPoint(Cordinates cordinates)
		{
			cordinatesArr.Add(cordinates);
		}

		public override void Print()
		{
			Console.WriteLine("Polyline\n");
			int count = 0;
			foreach(Cordinates point in cordinatesArr)
			{
				count++;
				Console.WriteLine($"Point#{count}\n" +
					$"X = {point.X}, Y = {point.Y}\n");

			}
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle(new Cordinates(10,20),10,20);
			Line line = new Line(new Cordinates(25,45),new Cordinates(85,100));
			Polyline polyline = new Polyline();
			polyline.AddPoint(new Cordinates(5, 4));
			polyline.AddPoint(new Cordinates(15, 77));
			polyline.AddPoint(new Cordinates(35, 49));
			Shape shape = rectangle;
			shape.Print();
			shape = line;
			shape.Print();
			shape = polyline;
			shape.Print();

			Console.ReadKey();
		}
	}
}