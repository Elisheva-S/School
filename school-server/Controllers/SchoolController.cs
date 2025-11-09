using Microsoft.AspNetCore.Mvc;
using School_Server.Models;
using School_Server.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School_Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SchoolController : ControllerBase
	{
		private readonly SchoolRepository _repository;
		public SchoolController(SchoolRepository repository)
		{
			_repository = repository;
		}
		// GET: api/<SchoolController>
		[HttpGet]
		public List<School> Get()
		{
			return _repository.GetSchools();
		}

		// GET api/<SchoolController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<SchoolController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<SchoolController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<SchoolController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
