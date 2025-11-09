using Microsoft.EntityFrameworkCore;
using School_Server.Data;
using School_Server.Models;
using System.Linq;

namespace School_Server.Repositories
{
	public class SchoolRepository
	{
		private readonly SchoolDbContext _context;
		public SchoolRepository(SchoolDbContext context)
		{
			_context = context;
		}
		public List<School> GetSchools()
		{
			return _context.Schools.Include(s => s.Teachers)
				.ThenInclude(sc => sc.Students)
				.ToList();
		}
	}
}
