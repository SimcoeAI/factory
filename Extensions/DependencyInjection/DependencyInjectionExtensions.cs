using Microsoft.Extensions.DependencyInjection;
using SimcoeAI.Abstractions.Factory;

namespace SimcoeAI.Extensions.Factory
{
	public static class FactoryExtensions
	{
		public static IServiceCollection AddScopedLifetimeFactory<T>(this IServiceCollection services)
			=> services.Scan(scan => scan
				.FromAssemblyOf<T>()
				.AddClasses(classes => classes.AssignableTo<IBaseFactory>())
				.AsImplementedInterfaces()
				.WithScopedLifetime());

		public static IServiceCollection AddSingletonLifetimeFactory<T>(this IServiceCollection services)
			=> services.Scan(scan => scan
				.FromAssemblyOf<T>()
				.AddClasses(classes => classes.AssignableTo<IBaseFactory>())
				.AsImplementedInterfaces()
				.WithSingletonLifetime());

		public static IServiceCollection AddTransientLifetimeFactory<T>(this IServiceCollection services)
			=> services.Scan(scan => scan
				.FromAssemblyOf<T>()
				.AddClasses(classes => classes.AssignableTo<IBaseFactory>())
				.AsImplementedInterfaces()
				.WithTransientLifetime());
	}
}