using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddPatientController : ControllerBase
	{
		// GET: api/<AddPatientController>
		[HttpPost]
		public void GetMass(string LastName, string MidleName, string FirstName, int lenght, double mass, int age)
		{
			DataBase db = new DataBase();
			db.PostPerson(LastName, MidleName, FirstName, lenght, mass, age);
		}

	}
}
