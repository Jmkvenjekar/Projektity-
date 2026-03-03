namespace BookLibraryApp
{
	public interface ILainattava
	{
		bool OnLainassa { get; }
		void Lainaa();
		void Palauta();
	}
}