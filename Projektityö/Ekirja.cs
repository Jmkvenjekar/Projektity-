namespace BookLibraryApp
{
	public class Ekirja : Julkaisu
	{
		public double FileSizeMb { get; set; }

		public Ekirja() { }

		public Ekirja(string title, string author, double fileSizeMb) : base(title, author)
		{
			FileSizeMb = fileSizeMb;
		}

		public override string Kuvaus()
		{
			return $"{Title} – {Author}, {FileSizeMb:0.0} MB (e-kirja)";
		}
	}
}