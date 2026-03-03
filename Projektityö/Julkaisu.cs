namespace BookLibraryApp
{
	public abstract class Julkaisu
	{
		public string Title { get; set; }
		public string Author { get; set; }

		protected Julkaisu() { }

		protected Julkaisu(string title, string author)
		{
			Title = title;
			Author = author;
		}

		public abstract string Kuvaus();
	}
}