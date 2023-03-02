namespace Tasks_9.Task_1
{
	public class DVD : Disk,IRemoveableDisk
	{
		bool hasDisk;
		public bool HasDisk => hasDisk;

		public string GetName() => "DVD";
		public void Insert()
		{
			Console.WriteLine("Insert DVD");
		}
		public void Reject()
		{
			Console.WriteLine("Reject DVD");
		}
	}
}
