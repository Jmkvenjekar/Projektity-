namespace BookLibraryApp
{
	public class Kirja : Julkaisu, ILainattava
	{
		public int Pages { get; set; }

		public bool OnLainassa { get; private set; }

		public Kirja() { }

		public Kirja(string title, string author, int pages) : base(title, author)
		{
			Pages = pages;
		}

		public override string Kuvaus()
		{
			return $"{Title} – {Author}, {Pages} sivua (kirja)";
		}

		public void Lainaa()
		{
			OnLainassa = true;
		}

		public void Palauta()
		{
			OnLainassa = false;
		}
	}
}