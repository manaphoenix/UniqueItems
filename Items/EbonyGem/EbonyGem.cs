﻿using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace UniqueItems.Items.EbonyGem
{
	class EbonyGem : ModItem
	{
        public override void SetStaticDefaults()
        {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 1;
            Item.value = Item.sellPrice(0, 7, 40, 20);
            Item.rare = ItemRarityID.Pink;
            Item.accessory = true;
        }

		public override void AddRecipes()
		{
			CreateRecipe()
			    .AddIngredient(ItemID.FallenStar)
			    .AddIngredient(ItemID.SandBlock, 20)
			    .AddIngredient(ItemID.Diamond)
			    .AddIngredient(ItemID.Deathweed)
			    .AddTile(TileID.Furnaces)
			    .Register();
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
        {
            var mp = player.GetModPlayer<UniqueItemsPlayer>();

            mp.ManaVampirism = true;
        }
    }
}
