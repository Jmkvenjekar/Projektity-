using System;

namespace BookLibraryApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kirjasto library = new Kirjasto();

			library.AddBook(new Kirja("1984", "George Orwell", 328));
			library.AddBook(new Kirja("Sinuhe Egyptiläinen", "Mika Waltari", 780));
			library.AddBook(new Kirja("The Hobbit", "J.R.R. Tolkien", 310));

			foreach (Kirja book in library.GetAllBooks())
			{
				Console.WriteLine($"{book.Title} – {book.Author}, {book.Pages} sivua");
			}

			library.SaveJSON("books.json");
		}
	}
}
