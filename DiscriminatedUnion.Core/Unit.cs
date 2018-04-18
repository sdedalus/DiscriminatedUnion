namespace DiscriminatedUnion
{
	/// <summary>
	/// The unit type.
	/// </summary>
	public class Unit
	{
		/// <summary>
		/// The default
		/// </summary>
		public static readonly Unit Default = new Unit();

		/// <summary>
		/// Prevents a default instance of the <see cref="Unit"/> class from being created.
		/// </summary>
		private Unit()
		{
		}

		public T Return<T>(T value) => value;
	}
}