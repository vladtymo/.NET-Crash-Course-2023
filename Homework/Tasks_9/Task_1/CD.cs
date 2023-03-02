namespace Tasks_9.Task_1
{
	public class CD : Disk, IRemoveableDisk
	{
		bool hasDisk;
		public bool HasDisk => hasDisk;

		public string GetName() => "CD";
		public void Insert()
		{
			Console.WriteLine("Insert CD");
		}
		public void Reject()
		{
			Console.WriteLine("Reject CD");
		}
	}
}
