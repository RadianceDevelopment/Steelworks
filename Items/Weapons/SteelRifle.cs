using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Steelworks.Items.Weapons
{
	public class SteelRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Rifle");
			Tooltip.SetDefault("A rifle made of Steel. Very durable.");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.crit = 5;
			item.ranged = true;
			item.width = 40;
			item.height = 50;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 32, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SteelBar"), 8);
			recipe.AddIngredient(mod.GetItem("SteelBinding"), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
