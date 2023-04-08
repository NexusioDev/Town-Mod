using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TownModEN.Items
{
	public class ShitSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shit Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a basic shitty OP tested fun Sword, better not be in final Release(*NOT FOR RELEASE*).");
		}

		public override void SetDefaults()
		{
			Item.damage = 500;
			Item.DamageType = DamageClass.Melee;
			Item.width = 55;
			Item.height = 6000;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 0;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 50000);
			recipe.Register();
		}
	}
}
