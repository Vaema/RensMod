using Terraria.ModLoader;

namespace RensMod;

public class RensMod : Mod
{
    /// <summary>
    ///     The instance of this mod.
    /// </summary>
    public static Mod Instance
    {
        get;
        private set;
    }

    public override void Load() => Instance = this;

    public override void Unload() => Instance = null;
}