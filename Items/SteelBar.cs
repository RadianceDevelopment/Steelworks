using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Steelworks.Items
{
	public class SteelBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Bar");
			Tooltip.SetDefault("A bar of Steel. Very high-quality.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(0, 0, 4, 0);
			item.rare = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("Charcoal"), 1);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Furnaces);
			//recipe.AddTile(TileID.BlastFurnace);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
