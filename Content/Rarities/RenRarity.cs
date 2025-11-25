using Microsoft.Xna.Framework;
using RensMod.Core.Utilities;
using Terraria.ModLoader;

namespace RensMod.Content.Rarities;

public class RenRarity : ModRarity
{
    // This rarity color switches between purple and blue.
    public override Color RarityColor => Utilities.ColorSwap(new Color(104, 40, 96), new Color(0, 65, 106), 3f);

    // This is an exclusive rarity, so there is no other rarity for it to go based off of a prefix.
    public override int GetPrefixedRarity(int offset, float valueMult) => Type;
}