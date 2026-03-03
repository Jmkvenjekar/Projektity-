using System.Collections.Generic;
using System.Linq;

namespace BookLibraryApp
{
	public class Kirjasto
	{
		public List<Julkaisu> Julkaisut { get; set; } = new List<Julkaisu>();

		public void AddJulkaisu(Julkaisu julkaisu)
		{
			Julkaisut.Add(julkaisu);
		}

		public List<Julkaisu> GetAll()
		{
			return Julkaisut;
		}

		public List<ILainattava> GetLainattavat()
		{
			return Julkaisut.OfType<ILainattava>().ToList();
		}
	}
}