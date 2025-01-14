using System.Diagnostics.CodeAnalysis;
using SpaceShared;
using StardewModdingAPI;

namespace Magic.Framework
{
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = DiagnosticMessages.IsPublicApi)]
    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = DiagnosticMessages.IsPublicApi)]
    internal class Configuration
    {
        public SButton Key_SwapSpells = SButton.Tab;
        public SButton Key_Cast = SButton.Q;
        public SButton Key_Spell1 = SButton.D1;
        public SButton Key_Spell2 = SButton.D2;
        public SButton Key_Spell3 = SButton.D3;
        public SButton Key_Spell4 = SButton.D4;
        public SButton Key_Spell5 = SButton.D5;

        public string AltarLocation = "SeedShop";
        public int AltarX = 36;
        public int AltarY = 16;
    }
}
