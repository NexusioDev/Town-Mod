using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TownModDE.Items
{
	public class DirtSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dreck Schwert"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Das ist ein Dreck Schwert, es ist besser als Kupfer        glaube ich.(Nein, eigentlich nicht)");
		}

		public override void SetDefaults()
		{
			Item.damage = 5;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 80;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10;
			Item.rare = 1;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 8);
			recipe.Register();
		}
	}
}
