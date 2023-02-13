using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_Management_FINAL.Shared;

namespace TestInventory_Management_FINAL
{
	public class TestMainLayout
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbAvatarModule));
			var componentUnderTest = ctx.RenderComponent<MainLayout>();
			Assert.NotNull(componentUnderTest);
		}
	}
}