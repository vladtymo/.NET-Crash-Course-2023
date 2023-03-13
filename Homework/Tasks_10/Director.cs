namespace Tasks_10
{
	public class Director : ICloneable
	{
		public string Name { get; set; }
		public string Surname { get; set; }

		public object Clone()
		{
			var clone = (Director)this.MemberwiseClone();
			return clone;
		}

		public override string ToString()
		{
			return 
				$"Name - {Name}\n" +
				$"Surname - {Surname}";
		}
	}
}
