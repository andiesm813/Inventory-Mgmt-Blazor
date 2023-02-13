using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_Management_FINAL.Pages;

namespace TestInventory_Management_FINAL
{
	public class TestReports
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Reports>();
			Assert.NotNull(componentUnderTest);
		}
	}
}