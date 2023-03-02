namespace Tasks_9.Task_1
{
	public interface IRemoveableDisk
	{
		bool HasDisk { get; }

		void Insert();
		void Reject();
	}
}
