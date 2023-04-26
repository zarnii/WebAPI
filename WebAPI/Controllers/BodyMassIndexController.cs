using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BodyMassIndexController : ControllerBase
	{
		/// <summary>
		/// Класс для сериализации данных в JSON и отправки.
		/// </summary>
		private class AnswerBMI
		{
			public double Mass { get; set; }
			public int Lenght { get; set;}
			public double BMI { get; set; }
		}

		/// <summary>
		/// Метод расчета Индекса массы тела.
		/// </summary>
		/// <param name="mass">Вес.</param>
		/// <param name="length">Рост.</param>
		/// <returns>JSON</returns>

		//GET: api/<BodyMassIndexController>
		[HttpGet(Name = "GetBMI")]
		public string GetBMI(double mass, int length)
		{
			double bmi = BodyMassIndex.Calculate(mass, (double)length / 100);
			if (bmi > 0)
			{
				AnswerBMI answ = new AnswerBMI()
				{
					Mass = mass,
					Lenght = length,
					BMI = bmi
				};
				return JsonSerializer.Serialize(answ);
			}
			return "Не корректный ввод";
		}

	}
}
