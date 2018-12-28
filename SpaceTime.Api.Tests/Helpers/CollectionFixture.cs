using Xunit;

namespace SpaceTime.Api.Tests.Helpers
{
	[CollectionDefinition("Dependency injection collection")]
	public class CollectionFixture : ICollectionFixture<AssemblyInitialize>
	{ }
}
