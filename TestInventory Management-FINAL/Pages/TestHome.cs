using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_Management_FINAL.Pages;
using Inventory_Management_FINAL.InventoryApp;
using Inventory_Management_FINAL.ECommerce;
using Inventory_Management_FINAL.ECommerce1;

namespace TestInventory_Management_FINAL
{
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCardModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbPieChartModule),
				typeof(IgbCategoryChartModule));
			ctx.Services.AddScoped<IInventoryAppService>(sp => new MockInventoryAppService());
			ctx.Services.AddScoped<IECommerceService>(sp => new MockECommerceService());
			ctx.Services.AddScoped<IECommerce1Service>(sp => new MockECommerce1Service());
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}