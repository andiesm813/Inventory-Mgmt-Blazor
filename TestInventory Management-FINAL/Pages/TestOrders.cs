using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_Management_FINAL.Pages;
using Inventory_Management_FINAL.Northwind;

namespace TestInventory_Management_FINAL
{
	public class TestOrders
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbInputModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Orders>();
			Assert.NotNull(componentUnderTest);
		}
	}
}