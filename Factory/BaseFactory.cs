namespace SimcoeAI.Abstractions.Factory
{
	public abstract class BaseFactory<TSpecs, TObject> : IFactory<TSpecs, TObject>
	{
		public abstract TObject Create(TSpecs specs);
	}
}
