using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BookLibraryApp
{
	public class Kirjasto
	{
		public List<Kirja> Books { get; set; } = new List<Kirja>();

        public Kirja Kirja
        {
            get => default;
            set
            {
            }
        }

        public void AddBook(Kirja book)
		{
			Books.Add(book);
		}

		public List<Kirja> GetAllBooks()
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
			Books = JsonSerializer.Deserialize<List<Kirja>>(json);
		}
	}
}
