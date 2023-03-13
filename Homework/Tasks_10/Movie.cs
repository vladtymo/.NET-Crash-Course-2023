namespace Tasks_10
{
	public class Movie : ICloneable, IComparable<Movie>
	{
		public string title;
		public string description;
		public string country;
		public int year;
		public short rating;

		public string Title 
		{
			get => title;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					title = value;
				}
				else title = "Unknown";
			}
		}
		public string Description 
		{
			get => description;
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					description = value;
				}
				else description = "Unknown";
			}
		}
		public Director Director { get; set; }
		public string Country 
		{
			get => country;
			set
			{
				if(!string.IsNullOrEmpty(value)) 
				{
					country = value;
				}else country= "Unknown";
			}
		}
		public Genre Genre { get; set; }
	    public int Year 
		{
			get => year;
			set
			{
				if(value >= 0)
				{
					year = value;
				}
				else year = 1970;
			}
		}
		public short Rating 
		{
			get => rating;
			set
			{
				if(value > 0 || value <= 100)
				{
					rating = value;
				}
				else rating = 1;
			}
		}

		public object Clone()
		{
			var clone = (Movie)this.MemberwiseClone();
			clone.Director = (Director)this.Director.Clone();
			return clone;
		}

		public int CompareTo(Movie? other)
		{
			if (other == null) return 1;
			return this.Rating.CompareTo(other.Rating) * -1;
		}

		public override string ToString()
		{
			return
				$"Title: {Title}\n" +
				$"Description: {Description}\n" +
				$"Director: {Director}\n" +
				$"Country: {Country}\n" +
				$"Genre: {Genre}\n" +
				$"Year: {Year}\n" +
				$"Rating: {Rating}";
			
		}
	}
}
