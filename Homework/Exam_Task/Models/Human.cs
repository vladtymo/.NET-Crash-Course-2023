namespace Exam_Task.Base
{
	public abstract class Human
	{
		public Human() { }
		public Human(string firstName, string lastName, string email, string phone, DateTime birthDate)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
			this.Phone = phone;
			this.BirthDate = birthDate;
		}
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public DateTime BirthDate { get; set; }
	}
}
