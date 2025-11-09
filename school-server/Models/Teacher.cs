namespace School_Server.Models
{
	public class Teacher
	{
		public int Id { get; set; }
		public string? FullName { get; set; }
		public string? Subject { get; set; }
		public int? SchoolId { get; set; }
		public School? School { get; set; }
		public List<Student>? Students { get; set; }
	}
}
