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
	/*
Створити метод для ініціалізації масива.

Метод приймає масив та алгоритм генерації значення у вигляді делегату.
Використовуючи даний метод, створити наступні масиви:
1. масив з 15-ти елементів випадкових значень від 1 до 100
2. масив з 10-ти елементів степенів двійки (2, 4, 8, 16…)
3. масив з 20-ти елементів із значеннями від 0 та кроком збільшення в 3 (0, 3, 6, 
9, 12…)
4. *масив з 10-ти елементів чисел Фібоначчі
!Використати анонімні методи
	 */
}