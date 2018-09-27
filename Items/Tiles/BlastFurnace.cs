using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Steelworks.Items
{
	public class BlastFurnace : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blast Furnace");
			Tooltip.SetDefault("A furnace used to make Steel. \nAs such, it is very hot.");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.crit = 5;
			item.knockBack = 6;
			item.melee = true;
			item.rare = 1;
			item.width = 40;
			item.height = 40;
			item.value = Item.sellPrice(0, 0, 49, 20);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 16);
			recipe.AddIngredient(ItemID.Furnace, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
