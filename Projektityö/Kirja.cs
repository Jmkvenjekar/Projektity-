namespace BookLibraryApp
{
	public class Kirja
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public int Pages { get; set; }

		public Kirja() { }

		public Kirja(string title, string author, int pages)
		{
			Title = title;
			Author = author;
			Pages = pages;
		}
	}
}