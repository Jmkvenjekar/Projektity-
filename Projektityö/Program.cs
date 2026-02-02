using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BookLibraryApp
{
	public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public int Pages { get; set; }

		public Book() { }

		public Book(string title, string author, int pages)
		{
			Title = title;
			Author = author;
			Pages = pages;
		}
	}

	public class Library
	{
		public List<Book> Books { get; set; } = new List<Book>();

		public void AddBook(Book book)
		{
			Books.Add(book);
		}

		public List<Book> GetAllBooks()
		{
			return Books;
		}

		public void SaveJSON(string fileName)
		{
			string json = JsonSerializer.Serialize(Books);
			File.WriteAllText(fileName, json);
		}

		public void LoadJSON(string fileName)
		{
			if (!File.Exists(fileName))
				return;

			string json = File.ReadAllText(fileName);
			Books = JsonSerializer.Deserialize<List<Book>>(json);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Library library = new Library();

			library.AddBook(new Book("1984", "George Orwell", 328));
			library.AddBook(new Book("Sinuhe Egyptiläinen", "Mika Waltari", 780));
			library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 310));

			Console.WriteLine("Kirjaston kirjat:");
			foreach (Book book in library.GetAllBooks())
			{
				Console.WriteLine($"{book.Title} – {book.Author}, {book.Pages} sivua");
			}

			library.SaveJSON("books.json");
			Console.WriteLine("\nKirjat tallennettu tiedostoon books.json");

			Library library2 = new Library();
			library2.LoadJSON("books.json");

			Console.WriteLine("\nLadatut kirjat tiedostosta:");
			foreach (Book book in library2.GetAllBooks())
			{
				Console.WriteLine($"{book.Title} – {book.Author}, {book.Pages} sivua");
			}
		}
	}
}