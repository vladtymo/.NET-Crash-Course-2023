namespace Tasks_9.Task_1
{
	public class Flash : Disk, IRemoveableDisk
	{
		bool hasDisk;
		public bool HasDisk => hasDisk;

		public string GetName() => "Flash";
		public void Insert()
		{
			Console.WriteLine("Insert Flash");
		}
		public void Reject()
		{
			Console.WriteLine("Reject Flash");
		}
	}
}
