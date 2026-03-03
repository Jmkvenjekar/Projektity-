using System;

namespace BookLibraryApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kirjasto kirjasto = new Kirjasto();

			kirjasto.AddJulkaisu(new Kirja("Brave New World", "Aldous Huxley", 311));
			kirjasto.AddJulkaisu(new Ekirja("The Stranger", "Albert Camus", 123));

			Console.WriteLine("Julkaisut (polymorfismi: Kuvaus() vaihtuu tyypin mukaan):");
			foreach (var j in kirjasto.GetAll())
			{
				Console.WriteLine(j.Kuvaus());
			}

			Console.WriteLine("\nLainattavat (rajapinta ILainattava):");
			foreach (var l in kirjasto.GetLainattavat())
			{
				l.Lainaa();
				Console.WriteLine($"OnLainassa: {l.OnLainassa}");
				l.Palauta();
			}
		}
	}
}