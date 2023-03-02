namespace Tasks_9.Task_2
{
	public interface IBird
	{
		int FlightHeight { get; set; }
		int FlightSpeed { get; set; }
		double WingSpan { get; set; }

		void Fly();
		
	}
}