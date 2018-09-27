using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Steelworks.Items.Weapons
{
	public class SteelSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Sword");
			Tooltip.SetDefault("A sword made of Steel. Nice, but could be better.");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.crit = 5;
			item.melee = true;
			item.width = 40;
			item.height = 50;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 32, 0);
			item.rare = 11;
			item.expert = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SteelBar"), 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
