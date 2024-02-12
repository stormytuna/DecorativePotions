using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PlaceablePotions.Content;

public class DecorativePotionItem : ModItem
{
    private readonly int placeTileType;
    private readonly int potionItemType;

    public DecorativePotionItem(int potionItemType, int placeTileType) {
        this.potionItemType = potionItemType;
        this.placeTileType = placeTileType;
    }

    protected override bool CloneNewInstances => true;

    public override string Name => GetInternalNameFromPotionItemType(potionItemType);

    public static string GetInternalNameFromPotionItemType(int potionItemType) => $"Decorative{ItemID.Search.GetName(potionItemType)}";

    public override void SetDefaults() {
        Item.DefaultToPlaceableTile(placeTileType);
        Item.SetShopValues(ItemRarityID.White, Item.sellPrice(silver: 1));

        Item.maxStack = Item.CommonMaxStack;
        Item.width = 20;
        Item.height = 20;
    }

    public override void AddRecipes() {
        CreateRecipe()
            .AddIngredient(potionItemType)
            .AddTile(TileID.HeavyWorkBench)
            .Register();
    }

    public class DecorativePotionLoader : ILoadable
    {
        public void Load(Mod mod) {
            Register(mod, ItemID.HealingPotion);
            Register(mod, ItemID.GreaterHealingPotion);
            Register(mod, ItemID.SuperHealingPotion);
            Register(mod, ItemID.ManaPotion);
            Register(mod, ItemID.GreaterManaPotion);
            Register(mod, ItemID.SuperManaPotion);
            Register(mod, ItemID.RestorationPotion);
            Register(mod, ItemID.AmmoReservationPotion);
            Register(mod, ItemID.ArcheryPotion);
            Register(mod, ItemID.BattlePotion);
            Register(mod, ItemID.BiomeSightPotion);
            Register(mod, ItemID.BuilderPotion);
            Register(mod, ItemID.CalmingPotion);
            Register(mod, ItemID.CratePotion);
            Register(mod, ItemID.TrapsightPotion);
            Register(mod, ItemID.EndurancePotion);
            Register(mod, ItemID.FeatherfallPotion);
            Register(mod, ItemID.FishingPotion);
            Register(mod, ItemID.FlipperPotion);
            Register(mod, ItemID.GillsPotion);
            Register(mod, ItemID.GravitationPotion);
            Register(mod, ItemID.LuckPotionGreater);
            Register(mod, ItemID.HeartreachPotion);
            Register(mod, ItemID.HunterPotion);
            Register(mod, ItemID.InfernoPotion);
            Register(mod, ItemID.InvisibilityPotion);
            Register(mod, ItemID.IronskinPotion);
            Register(mod, ItemID.LuckPotionLesser);
            Register(mod, ItemID.LifeforcePotion);
            Register(mod, ItemID.LovePotion);
            Register(mod, ItemID.LuckPotion);
            Register(mod, ItemID.MagicPowerPotion);
            Register(mod, ItemID.ManaRegenerationPotion);
            Register(mod, ItemID.MiningPotion);
            Register(mod, ItemID.NightOwlPotion);
            Register(mod, ItemID.ObsidianSkinPotion);
            Register(mod, ItemID.RagePotion);
            Register(mod, ItemID.RegenerationPotion);
            Register(mod, ItemID.ShinePotion);
            Register(mod, ItemID.SonarPotion);
            Register(mod, ItemID.SpelunkerPotion);
            Register(mod, ItemID.StinkPotion);
            Register(mod, ItemID.SummoningPotion);
            Register(mod, ItemID.SwiftnessPotion);
            Register(mod, ItemID.ThornsPotion);
            Register(mod, ItemID.TitanPotion);
            Register(mod, ItemID.WarmthPotion);
            Register(mod, ItemID.WaterWalkingPotion);
            Register(mod, ItemID.WrathPotion);
            Register(mod, ItemID.GenderChangePotion);
            Register(mod, ItemID.PotionOfReturn);
            Register(mod, ItemID.RecallPotion);
            Register(mod, ItemID.TeleportationPotion);
            Register(mod, ItemID.WormholePotion);
            Register(mod, ItemID.FlaskofCursedFlames);
            Register(mod, ItemID.FlaskofFire);
            Register(mod, ItemID.FlaskofGold);
            Register(mod, ItemID.FlaskofIchor);
            Register(mod, ItemID.FlaskofNanites);
            Register(mod, ItemID.FlaskofParty);
            Register(mod, ItemID.FlaskofPoison);
            Register(mod, ItemID.FlaskofVenom);
        }

        public void Unload() { }

        private void Register(Mod mod, int potionItemType) {
            DecorativePotionTile tile = new(potionItemType);
            mod.AddContent(tile);
            mod.AddContent(new DecorativePotionItem(potionItemType, tile.Type));
        }
    }
}
