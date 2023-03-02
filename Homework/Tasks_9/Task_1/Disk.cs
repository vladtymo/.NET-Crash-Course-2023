namespace Tasks_9.Task_1
{
	public class Disk : IDisk
	{
		string memory;
		int memSize;

		string Memory { get { return memory; } set {memory = value;}}
		public int MemSize { get { return memSize; } set { memSize = value;}}
		public Disk() { }
		public Disk(string memory, int memSize)
		{
			this.memory = memory;
			this.memSize = memSize;
		}
		public string GetName() => "Gets Name";
		public string Read() => "Read Data";
		public void Write(string text) { Console.WriteLine($"Write {text}"); }
	}
}
