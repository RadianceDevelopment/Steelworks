using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Steelworks.Items
{
	public class SteelBinding : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Binding");
			Tooltip.SetDefault("A binding made of Steel.\nUsed to bind together Steel to make the final product stronger.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(0, 0, 4, 0);
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SteelBar"), 2);
		    recipe.AddIngredient(ItemID.Chain, 4);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.BlastFurnace);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
