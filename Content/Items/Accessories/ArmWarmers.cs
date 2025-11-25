using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RensMod.Content.Items.Accessories;

public class ArmWarmers : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.value = Item.sellPrice(silver: 45);
        Item.rare = ItemRarityID.Blue;
        Item.accessory = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.GetDamage<GenericDamageClass>() += 0.05f;
        player.GetAttackSpeed<GenericDamageClass>() += 0.1f;
    }

    public override void AddRecipes()
    {
        CreateRecipe().
            AddIngredient(ItemID.Silk, 10).
            AddIngredient(ItemID.PurpleMucos).
            AddIngredient(ItemID.BlackInk).
            AddTile(TileID.Loom).
            Register();
    }
}