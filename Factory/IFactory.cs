namespace SimcoeAI.Abstractions.Factory
{
	public interface IFactory<in TSpecs, out TObject> : IBaseFactory
	{
		TObject Create(TSpecs specs);
	}
}
