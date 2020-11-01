[![Build Status](https://dev.azure.com/simcoeai/ArchitectureLibrary/_apis/build/status/SimcoeAI.factory?branchName=main)](https://dev.azure.com/simcoeai/ArchitectureLibrary/_build/latest?definitionId=17&branchName=main)

![Nuget](https://img.shields.io/nuget/v/SimcoeAI.Abstractions.Factory?color=cc)

# Purpose
A very minimal definition of the factory pattern definition in C#.

# Usage
Simply derive your own factory classes from the following abstact class definition:

```csharp
BaseFactory<TSpecs, TObject>
```
## Wiring up factory classes

Simply call either of the following extensions methods to have factory classes wired up:

```csharp
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
  ```
