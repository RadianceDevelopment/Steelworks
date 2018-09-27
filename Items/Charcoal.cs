using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Steelworks.Items
{
	public class Charcoal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Charcoal");
			Tooltip.SetDefault("Burnt wood. Has a lot of carbon in it..");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(0, 0, 0, 0);
			item.rare = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 2);
			recipe.anyWood = true;
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
