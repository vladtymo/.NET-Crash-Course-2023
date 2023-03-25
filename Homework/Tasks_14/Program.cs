namespace Tasks_14
{
	public class Program
	{
		public static void InitList(IList<int> ints, int numOfElem,Func<int,int> func)
		{
			for(int i=0; i<numOfElem; i++)
			{
				ints.Add(func(i));
			}
			foreach(int n in ints)
			{
				Console.Write(n + " ");
			}
			Console.WriteLine("\n\n"+ints.Count);
		}

		static void Main(string[] args)
		{
			List<int> arr = new List<int>();
			InitList(arr, 15, x => new Random().Next(1,100));
			InitList(arr, 10, x => x * 2);
			InitList(arr, 20, x => x + 3);
			Console.ReadKey();
		}
	}
}