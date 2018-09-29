using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Steelworks.Items.Weapons
{
	public class SteelBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Bow");
			Tooltip.SetDefault("A bow made of Steel. Very durable.");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.crit = 5;
			item.ranged = true;
			item.shoot = 10;
			item.shootSpeed = 8;
			item.width = 40;
			item.height = 50;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = Item.sellPrice(0, 0, 28, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SteelBar"), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
