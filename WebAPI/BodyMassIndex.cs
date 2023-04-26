namespace WebAPI
{
	public static class BodyMassIndex
	{
		
		/// <summary>
		/// Функция проверки на вхождения числа в корректный диапозон.
		/// </summary>
		/// <param name="checking">Провеяремое число.</param>
		/// <param name="left_border">Левая граница.</param>
		/// <param name="right_border">Правая граница.</param>
		/// <returns></returns>
		private static bool Validation(double checking, double left_border, double right_border)
		{
			if((checking >= left_border) && (checking <= right_border))
			{
				return true;
			}
			return false;
		}

		/// <summary>
		/// Расчет индекса массы тела.
		/// </summary>
		/// <param name="weight">Вес.</param>
		/// <param name="length">Рост.</param>
		/// <returns>Вернет 0, если значения не корректны</returns>
		public static double Calculate(double mass, double length)
		{
			if(Validation(mass, 3, 300) && Validation(length, 1.4, 2.3))
			{
				return Math.Round(mass / (length * length),1);
			}
			return 0;
		}
	}
}
