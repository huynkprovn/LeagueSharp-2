﻿#region

using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;

#endregion

namespace LeagueLib
{
    public class Items
    {
        internal static readonly Item[] pre_items =
        {
            new Item(
                3001, "Abyssal Scepter", 0, 580, true, ItemClass.None,
                (ItemCategory.SpellBlock & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 70f, 0f, 0f, 50f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1026), GetItem(1033), GetItem(1033) }),
            new Item(
                3105, "Aegis of the Legion", 0, 820, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 200f,
                20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1028), GetItem(1033), GetItem(1006) }),
            new Item(
                3113, "Aether Wisp", 0, 515, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 30f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1052) }),
            new Item(
                1052, "Amplifying Tome", 0, 435, false, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 20f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3301, "Ancient Coin", 0, 365, false, ItemClass.None, (ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3007, "Archangel's Staff (Crystal Scar)", 0, 1120, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellDamage & ItemCategory.Mana), 0f, 0f, 0f, 0f, 60f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3073), GetItem(1026) }),
            new Item(
                3003, "Archangel's Staff", 0, 1120, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellDamage & ItemCategory.Mana), 0f, 0f, 0f, 0f, 60f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3070), GetItem(1026) }),
            new Item(
                3504, "Ardent Censer", 0, 550, true, ItemClass.None, (ItemCategory.ManaRegen & ItemCategory.SpellDamage),
                0f, 0f, 0f, 0f, 40f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3114), GetItem(3113) }),
            new Item(
                3174, "Athene's Unholy Grail", 0, 880, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellBlock & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 60f, 0f,
                0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3108), GetItem(3028) }),
            new Item(
                3005, "Atma's Impaler", 0, 700, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.Damage & ItemCategory.Armor), 0f, 0f, 0f, 0.15f, 0f, 0f, 0f,
                0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1031), GetItem(3093) }),
            new Item(
                3093, "Avarice Blade", 0, 400, true, ItemClass.None, (ItemCategory.CriticalStrike), 0f, 0f, 0f, 0.1f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1051) }),
            new Item(
                1038, "B. F. Sword", 0, 1550, false, ItemClass.None, (ItemCategory.Damage), 0f, 50f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3060, "Banner of Command", 0, 280, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.SpellBlock & ItemCategory.SpellDamage),
                0f, 0f, 0f, 0f, 60f, 0f, 200f, 20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3105), GetItem(3108) }),
            new Item(
                3102, "Banshee's Veil", 0, 1150, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 450f,
                55f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3211), GetItem(1028) }),
            new Item(
                3254, "Berserker's Greaves - Enchantment: Alacrity", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3006) }),
            new Item(
                3251, "Berserker's Greaves - Enchantment: Captain", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3006) }),
            new Item(
                3253, "Berserker's Greaves - Enchantment: Distortion", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3006) }),
            new Item(
                3252, "Berserker's Greaves - Enchantment: Furor", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3006) }),
            new Item(
                3250, "Berserker's Greaves - Enchantment: Homeguard", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3006) }),
            new Item(
                3006, "Berserker's Greaves", 0, 225, true, ItemClass.None, (ItemCategory.AttackSpeed), 0f, 0f, 45f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1001), GetItem(1042) }),
            new Item(
                3144, "Bilgewater Cutlass", 0, 240, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.LifeSteal),
                0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1036), GetItem(1053) }),
            new Item(
                3188, "Blackfire Torch", 0, 970, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 80f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1026), GetItem(3108) }),
            new Item(
                3153, "Blade of the Ruined King", 0, 900, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.AttackSpeed & ItemCategory.LifeSteal), 0f, 25f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1042), GetItem(3144), GetItem(1042) }),
            new Item(
                1026, "Blasting Wand", 0, 860, false, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 40f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3166, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3167, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3168, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3169, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3171, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3405, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3406, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3407, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3408, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3409, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3411, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3412, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3413, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3414, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3415, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3417, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3418, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3419, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3420, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3421, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3450, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3451, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3452, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3453, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3454, "Bonetooth Necklace", 0, 0, false, ItemClass.RengarsTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3274, "Boots of Mobility - Enchantment: Alacrity", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 105f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3117) }),
            new Item(
                3271, "Boots of Mobility - Enchantment: Captain", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 105f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3117) }),
            new Item(
                3273, "Boots of Mobility - Enchantment: Distortion", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 105f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3117) }),
            new Item(
                3272, "Boots of Mobility - Enchantment: Furor", 0, 475, true, ItemClass.Enchantment, (ItemCategory.None),
                0f, 0f, 105f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3117) }),
            new Item(
                3270, "Boots of Mobility - Enchantment: Homeguard", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 105f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3117) }),
            new Item(
                3117, "Boots of Mobility", 0, 475, true, ItemClass.None, (ItemCategory.None), 0f, 0f, 105f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1001) }),
            new Item(
                1001, "Boots of Speed", 0, 325, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 25f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3284, "Boots of Swiftness - Enchantment: Alacrity", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3009) }),
            new Item(
                3281, "Boots of Swiftness - Enchantment: Captain", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3009) }),
            new Item(
                3283, "Boots of Swiftness - Enchantment: Distortion", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3009) }),
            new Item(
                3282, "Boots of Swiftness - Enchantment: Furor", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3009) }),
            new Item(
                3280, "Boots of Swiftness - Enchantment: Homeguard", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3009) }),
            new Item(
                3009, "Boots of Swiftness", 0, 675, true, ItemClass.None, (ItemCategory.None), 0f, 0f, 60f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1001) }),
            new Item(
                1051, "Brawler's Gloves", 0, 400, false, ItemClass.None, (ItemCategory.CriticalStrike), 0f, 0f, 0f,
                0.08f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3010, "Catalyst the Protector", 0, 400, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.Mana), 0f, 0f,
                0f, 0f, 0f, 0f, 200f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1028), GetItem(1027) }),
            new Item(
                1031, "Chain Vest", 0, 450, true, ItemClass.None, (ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                40f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1029) }),
            new Item(
                3028, "Chalice of Harmony", 0, 140, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1004), GetItem(1033), GetItem(1004) }),
            new Item(
                1018, "Cloak of Agility", 0, 730, false, ItemClass.None, (ItemCategory.CriticalStrike), 0f, 0f, 0f,
                0.15f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1029, "Cloth Armor", 0, 300, false, ItemClass.None, (ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                15f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3801, "Crystalline Bracer", 0, 20, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f, 200f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1028), GetItem(1006) }),
            new Item(
                2041, "Crystalline Flask", 0, 345, false, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Consumable & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1042, "Dagger", 0, 450, false, ItemClass.None, (ItemCategory.AttackSpeed), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3128, "Deathfire Grasp", 0, 680, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 120f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1058), GetItem(3108) }),
            new Item(
                3137, "Dervish Blade", 0, 200, true, ItemClass.None,
                (ItemCategory.SpellBlock & ItemCategory.AttackSpeed), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 45f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3140), GetItem(3101) }),
            new Item(
                1075, "Doran's Blade (Showdown)", 0, 440, false, ItemClass.None,
                (ItemCategory.Health & ItemCategory.Damage & ItemCategory.LifeSteal), 0f, 7f, 0f, 0f, 0f, 0f, 70f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1055, "Doran's Blade", 0, 440, false, ItemClass.None,
                (ItemCategory.Health & ItemCategory.Damage & ItemCategory.LifeSteal), 0f, 7f, 0f, 0f, 0f, 0f, 70f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1076, "Doran's Ring (Showdown)", 0, 400, false, ItemClass.None,
                (ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 15f, 0f, 60f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1056, "Doran's Ring", 0, 400, false, ItemClass.None,
                (ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 15f, 0f, 60f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1074, "Doran's Shield (Showdown)", 0, 440, false, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 2f, 100f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1054, "Doran's Shield", 0, 440, false, ItemClass.None, (ItemCategory.HealthRegen & ItemCategory.Health),
                0f, 0f, 0f, 0f, 0f, 1.2f, 80f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2039, "Elixir of Brilliance", 3, 250, false, ItemClass.None,
                (ItemCategory.Consumable & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2037, "Elixir of Fortitude", 3, 350, false, ItemClass.None,
                (ItemCategory.Consumable & ItemCategory.Health & ItemCategory.Damage), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2138, "Elixir of Iron", 0, 400, false, ItemClass.None, (ItemCategory.Consumable), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2137, "Elixir of Ruin", 0, 400, false, ItemClass.None, (ItemCategory.Consumable & ItemCategory.Health),
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2139, "Elixir of Sorcery", 0, 400, false, ItemClass.None,
                (ItemCategory.Consumable & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2140, "Elixir of Wrath", 0, 400, false, ItemClass.None,
                (ItemCategory.Consumable & ItemCategory.Damage & ItemCategory.LifeSteal), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3184, "Entropy", 0, 500, true, ItemClass.None, (ItemCategory.Health & ItemCategory.Damage), 0f, 55f, 0f,
                0f, 0f, 0f, 275f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3044), GetItem(1037) }),
            new Item(
                3508, "Essence Reaver", 0, 850, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.LifeSteal), 0f, 80f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1053), GetItem(1038) }),
            new Item(
                3123, "Executioner's Calling", 0, 740, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.Damage), 0f, 25f, 0f, 0.2f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3093), GetItem(1036) }),
            new Item(
                2050, "Explorer's Ward", 0, 0, false, ItemClass.None, (ItemCategory.Consumable), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3401, "Face of the Mountain", 0, 485, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f, 500f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3097), GetItem(3067) }),
            new Item(
                1004, "Faerie Charm", 0, 180, false, ItemClass.None, (ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3363, "Farsight Orb (Trinket)", 0, 475, true, ItemClass.AdvancedTrinket, (ItemCategory.None), 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3342) }),
            new Item(
                3160, "Feral Flare", 0, 1800, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.AttackSpeed), 0f,
                12f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3108, "Fiendish Codex", 0, 385, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 30f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1052) }),
            new Item(
                3114, "Forbidden Idol", 0, 240, true, ItemClass.None, (ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1004), GetItem(1004) }),
            new Item(
                3092, "Forst Queen's Claim", 0, 515, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 50f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3098), GetItem(3108) }),
            new Item(
                3098, "Forstfang", 0, 500, true, ItemClass.None, (ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f,
                0f, 0f, 0f, 10f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3303) }),
            new Item(
                3110, "Frozen Heart", 0, 450, true, ItemClass.None, (ItemCategory.Mana & ItemCategory.Armor), 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 100f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3082), GetItem(3024) }),
            new Item(
                3022, "Frozen Mallet", 0, 1025, true, ItemClass.None, (ItemCategory.Health & ItemCategory.Damage), 0f,
                30f, 0f, 0f, 0f, 0f, 700f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1028), GetItem(1011), GetItem(1037) }),
            new Item(
                1011, "Giant's Belt", 0, 1000, false, ItemClass.None, (ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f,
                380f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3024, "Glacial Shroud", 0, 250, true, ItemClass.None, (ItemCategory.Mana & ItemCategory.Armor), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1027), GetItem(1029) }),
            new Item(
                3460, "Golden Transcendence", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3361, "Greater Stealth Totem (Trinket)", 0, 475, true, ItemClass.AdvancedTrinket, (ItemCategory.None),
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3340) }),
            new Item(
                3362, "Greater Vision Totem (Trinket)", 0, 475, true, ItemClass.AdvancedTrinket, (ItemCategory.None), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3340) }),
            new Item(
                3159, "Grez's Spectral Lantern", 0, 180, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.AttackSpeed), 0f, 15f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3106), GetItem(1036), GetItem(1042) }),
            new Item(
                3026, "Guardian Angel", 0, 1500, true, ItemClass.None, (ItemCategory.SpellBlock & ItemCategory.Armor),
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 40f, 50f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1033), GetItem(1031) }),
            new Item(
                2051, "Guardian's Horn", 0, 445, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.SpellBlock & ItemCategory.Armor), 0f, 0f,
                0f, 0f, 0f, 0f, 180f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1006), GetItem(1028) }),
            new Item(
                3124, "Guinsoo's Rageblade", 0, 865, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.AttackSpeed & ItemCategory.SpellDamage & ItemCategory.LifeSteal), 0f,
                30f, 0f, 0f, 40f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1026), GetItem(1037) }),
            new Item(
                3136, "Haunting Guise", 0, 650, true, ItemClass.None, (ItemCategory.Health & ItemCategory.SpellDamage),
                0f, 0f, 0f, 0f, 25f, 0f, 200f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1028), GetItem(1052) }),
            new Item(
                3175, "Head of Kha'Zix", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3410, "Head of Kha'Zix", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3416, "Head of Kha'Zix", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3422, "Head of Kha'Zix", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3455, "Head of Kha'Zix", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2003, "Health Potion", 5, 35, false, ItemClass.None, (ItemCategory.Consumable), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3155, "Hexdrinker", 0, 590, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.SpellBlock), 0f,
                25f, 0f, 0f, 0f, 0f, 0f, 30f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1036), GetItem(1033) }),
            new Item(
                3146, "Hextech Gunblade", 0, 800, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.SpellDamage & ItemCategory.LifeSteal), 0f, 45f, 0f, 0f, 65f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3144), GetItem(3145) }),
            new Item(
                3145, "Hextech Revolver", 0, 330, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 40f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1052), GetItem(1052) }),
            new Item(
                3187, "Hextech Sweeper", 0, 330, true, ItemClass.None,
                (ItemCategory.Health & ItemCategory.Mana & ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 225f, 0f, 25f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3024), GetItem(3067) }),
            new Item(
                1039, "Hunter's Machete", 0, 400, false, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3025, "Iceborn Gauntlet", 0, 750, true, ItemClass.None,
                (ItemCategory.SpellDamage & ItemCategory.Mana & ItemCategory.Armor), 0f, 0f, 0f, 0f, 30f, 0f, 0f, 0f,
                60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3057), GetItem(3024) }),
            new Item(
                2048, "Ichor of Illumination", 3, 500, false, ItemClass.None,
                (ItemCategory.Consumable & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2040, "Ichor of Rage", 3, 500, false, ItemClass.None,
                (ItemCategory.Consumable & ItemCategory.Damage & ItemCategory.AttackSpeed), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3031, "Infinity Edge", 0, 645, true, ItemClass.None, (ItemCategory.CriticalStrike & ItemCategory.Damage),
                0f, 80f, 0f, 0.25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1038), GetItem(1037), GetItem(1018) }),
            new Item(
                3279, "Ionian Boots of Lucidity - Enchantment: Alacrity", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3158) }),
            new Item(
                3276, "Ionian Boots of Lucidity - Enchantment: Captain", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3158) }),
            new Item(
                3278, "Ionian Boots of Lucidity - Enchantment: Distortion", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3158) }),
            new Item(
                3277, "Ionian Boots of Lucidity - Enchantment: Furor", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3158) }),
            new Item(
                3275, "Ionian Boots of Lucidity - Enchantment: Homeguard", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3158) }),
            new Item(
                3158, "Ionian Boots of Lucidity", 0, 675, true, ItemClass.None, (ItemCategory.None), 0f, 0f, 45f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1001) }),
            new Item(
                3067, "Kindlegem", 0, 450, true, ItemClass.None, (ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f, 200f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1028) }),
            new Item(
                3035, "Last Whisper", 0, 1065, true, ItemClass.None, (ItemCategory.Damage), 0f, 40f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1037), GetItem(1036) }),
            new Item(
                3151, "Liandry's Torment", 0, 980, true, ItemClass.None,
                (ItemCategory.Health & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 50f, 0f, 300f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3136), GetItem(1052) }),
            new Item(
                3100, "Lich Bane", 0, 850, true, ItemClass.None, (ItemCategory.SpellDamage & ItemCategory.Mana), 0f, 0f,
                0f, 0f, 80f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0.05f, 0f,
                new Item[] { GetItem(3057), GetItem(3113) }),
            new Item(
                3190, "Locket of the Iron Solari", 0, 50, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 400f,
                20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3105), GetItem(3067) }),
            new Item(
                1036, "Long Sword", 0, 360, false, ItemClass.None, (ItemCategory.Damage), 0f, 10f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3104, "Lord Van Damm's Pillager", 0, 995, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.Damage), 0f, 80f, 0f, 0.25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3122), GetItem(1037), GetItem(1018) }),
            new Item(
                3106, "Madred's Razors", 0, 0, true, ItemClass.None, (ItemCategory.AttackSpeed), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1042) }),
            new Item(
                2004, "Mana Potion", 5, 35, false, ItemClass.None, (ItemCategory.Consumable), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3008, "Manamune (Crystal Scar)", 0, 605, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.Mana), 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3073), GetItem(1037) }),
            new Item(
                3004, "Manamune", 0, 605, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.Mana), 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3070), GetItem(1037) }),
            new Item(
                3156, "Maw of Malmortius", 0, 875, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.SpellBlock),
                0f, 60f, 0f, 0f, 0f, 0f, 0f, 40f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3155), GetItem(1037) }),
            new Item(
                3041, "Mejai's Soulstealer", 0, 965, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f,
                20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1052) }),
            new Item(
                3139, "Mercurial Scimitar", 0, 900, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.SpellBlock), 0f, 80f, 0f, 0f, 0f, 0f, 0f, 35f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1038), GetItem(3140) }),
            new Item(
                3269, "Mercury's Treads - Enchantment: Alacrity", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3111) }),
            new Item(
                3266, "Mercury's Treads - Enchantment: Captain", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3111) }),
            new Item(
                3268, "Mercury's Treads - Enchantment: Distortion", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3111) }),
            new Item(
                3267, "Mercury's Treads - Enchantment: Furor", 0, 475, true, ItemClass.Enchantment, (ItemCategory.None),
                0f, 0f, 45f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3111) }),
            new Item(
                3265, "Mercury's Treads - Enchantment: Homeguard", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3111) }),
            new Item(
                3111, "Mercury's Treads", 0, 375, true, ItemClass.None, (ItemCategory.SpellBlock), 0f, 0f, 45f, 0f, 0f,
                0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1001), GetItem(1033) }),
            new Item(
                3222, "Mikael's Crucible", 0, 850, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 40f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3028), GetItem(3114) }),
            new Item(
                3170, "Moonflair Spellblade", 0, 920, true, ItemClass.None,
                (ItemCategory.SpellBlock & ItemCategory.SpellDamage & ItemCategory.Armor), 0f, 0f, 0f, 0f, 50f, 0f, 0f,
                50f, 50f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3191), GetItem(1033) }),
            new Item(
                3165, "Morellonomicon", 0, 680, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 80f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3108), GetItem(3114) }),
            new Item(
                3042, "Muramana", 0, 2200, false, ItemClass.None, (ItemCategory.None), 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3043, "Muramana", 0, 2200, false, ItemClass.None, (ItemCategory.None), 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3115, "Nashor's Tooth", 0, 850, true, ItemClass.None,
                (ItemCategory.AttackSpeed & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3101), GetItem(3108) }),
            new Item(
                1058, "Needlessly Large Rod", 0, 1600, false, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f,
                80f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3264, "Ninja Tabi - Enchantment: Alacrity", 0, 475, true, ItemClass.Enchantment, (ItemCategory.None), 0f,
                0f, 45f, 0f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3047) }),
            new Item(
                3261, "Ninja Tabi - Enchantment: Captain", 0, 600, true, ItemClass.Enchantment, (ItemCategory.None), 0f,
                0f, 45f, 0f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3047) }),
            new Item(
                3263, "Ninja Tabi - Enchantment: Distortion", 0, 475, true, ItemClass.Enchantment, (ItemCategory.None),
                0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3047) }),
            new Item(
                3262, "Ninja Tabi - Enchantment: Furor", 0, 475, true, ItemClass.Enchantment, (ItemCategory.None), 0f,
                0f, 45f, 0f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3047) }),
            new Item(
                3260, "Ninja Tabi - Enchantment: Homeguard", 0, 475, true, ItemClass.Enchantment, (ItemCategory.None),
                0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3047) }),
            new Item(
                3047, "Ninja Tabi", 0, 375, true, ItemClass.None, (ItemCategory.Armor), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f,
                25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1001), GetItem(1029) }),
            new Item(
                3096, "Nomad's Medallion", 0, 500, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3301) }),
            new Item(
                1033, "Null-Magic Mantle", 0, 500, false, ItemClass.None, (ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3180, "Odyn's Veil", 0, 800, true, ItemClass.None,
                (ItemCategory.Health & ItemCategory.SpellBlock & ItemCategory.Mana), 0f, 0f, 0f, 0f, 0f, 0f, 350f, 50f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1033), GetItem(3010) }),
            new Item(
                3056, "Ohmwrecker", 0, 750, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 300f, 0f,
                50f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(2053), GetItem(3067) }),
            new Item(
                2047, "Orcale's Extract", 0, 250, false, ItemClass.None, (ItemCategory.Consumable), 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3364, "Oracle's Lens (Trinket)", 0, 475, true, ItemClass.AdvancedTrinket, (ItemCategory.None), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3341) }),
            new Item(
                3112, "Orb of Winter", 0, 850, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 70f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1006), GetItem(1006), GetItem(1033), GetItem(1033) }),
            new Item(
                3084, "Overlord's Bloodmail", 0, 1055, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f, 850f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1011), GetItem(1028) }),
            new Item(
                3198, "Perfect Hex Core", 0, 1000, true, ItemClass.None, (ItemCategory.SpellDamage & ItemCategory.Mana),
                0f, 0f, 0f, 0f, 60f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3197) }),
            new Item(
                3044, "Phage", 0, 565, true, ItemClass.None, (ItemCategory.Health & ItemCategory.Damage), 0f, 20f, 0f,
                0f, 0f, 0f, 200f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1028), GetItem(1036) }),
            new Item(
                3046, "Phantom Dancer", 0, 520, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.AttackSpeed), 0f, 0f, 0f, 0.3f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0.05f, 0f, new Item[] { GetItem(1018), GetItem(3086), GetItem(1042) }),
            new Item(
                1037, "Pickaxe", 0, 875, false, ItemClass.None, (ItemCategory.Damage), 0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3722, "Poacher's Knife - Enchantment: Devourer", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.AttackSpeed), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3711), GetItem(1042), GetItem(1042) }),
            new Item(
                3721, "Poacher's Knife - Enchantment: Juggernaut", 0, 250, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3711), GetItem(3067), GetItem(1028) }),
            new Item(
                3720, "Poacher's Knife - Enchantment: Magus", 0, 680, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3711), GetItem(3108) }),
            new Item(
                3719, "Poacher's Knife - Enchantment: Warrior", 0, 163, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3711), GetItem(3134) }),
            new Item(
                3711, "Poacher's Knife", 0, 350, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1039) }),
            new Item(
                2052, "Poro-Snax", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1062, "Prospector's Blade", 0, 950, false, ItemClass.None,
                (ItemCategory.Health & ItemCategory.Damage & ItemCategory.AttackSpeed), 0f, 16f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1063, "Prospector's Ring", 0, 950, false, ItemClass.None,
                (ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 35f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3200, "Prototype Hex Core", 0, 0, true, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3140, "Quicksilver Sash", 0, 750, true, ItemClass.None, (ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 30f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1033) }),
            new Item(
                3204, "Quill Coat", 0, 75, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.ManaRegen & ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1039), GetItem(1029) }),
            new Item(
                3205, "Quill Coat", 0, 75, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.ManaRegen & ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1039), GetItem(1029) }),
            new Item(
                3089, "Rabadon's Deathcap", 0, 840, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f,
                120f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1026), GetItem(1058) }),
            new Item(
                3143, "Randuin's Omen", 0, 800, true, ItemClass.None, (ItemCategory.Health & ItemCategory.Armor), 0f, 0f,
                0f, 0f, 0f, 0f, 500f, 0f, 70f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3082), GetItem(1011) }),
            new Item(
                3726, "Ranger's Trailblazer - Enchantment: Devourer", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.AttackSpeed), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3713), GetItem(1042), GetItem(1042) }),
            new Item(
                3725, "Ranger's Trailblazer - Enchantment: Juggernaut", 0, 250, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3713), GetItem(3067), GetItem(1028) }),
            new Item(
                3724, "Ranger's Trailblazer - Enchantment: Magus", 0, 680, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3713), GetItem(3108) }),
            new Item(
                3723, "Ranger's Trailblazer - Enchantment: Warrior", 0, 163, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3713), GetItem(3134) }),
            new Item(
                3713, "Ranger's Trailblazer", 0, 350, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1039) }),
            new Item(
                2053, "Raptor Cloak", 0, 520, true, ItemClass.None, (ItemCategory.HealthRegen & ItemCategory.Armor), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 30f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1006), GetItem(1029) }),
            new Item(
                3074, "Ravenous Hydra (Melee Only>", 0, 600, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.LifeSteal), 0f, 75f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3077), GetItem(1053) }),
            new Item(
                1043, "Recurve Bow", 0, 900, false, ItemClass.None, (ItemCategory.AttackSpeed), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1006, "Rejuvenation Bead", 0, 180, false, ItemClass.None, (ItemCategory.HealthRegen), 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3302, "Relic Shield", 0, 365, true, ItemClass.None, (ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f, 75f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3800, "Righteous Glory", 0, 700, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.Mana), 0f, 0f, 0f, 0f, 0f, 0f, 500f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3010), GetItem(3801) }),
            new Item(
                3029, "Rod of Ages (Crystal Scar)", 0, 740, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.SpellDamage &
                 ItemCategory.Mana), 0f, 0f, 0f, 0f, 60f, 0f, 450f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3010), GetItem(1026) }),
            new Item(
                3027, "Rod of Ages", 0, 740, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.SpellDamage &
                 ItemCategory.Mana), 0f, 0f, 0f, 0f, 60f, 0f, 450f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3010), GetItem(1026) }),
            new Item(
                1028, "Ruby Crystal", 0, 400, false, ItemClass.None, (ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f, 150f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2045, "Ruby Sightstone", 0, 400, true, ItemClass.None, (ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f,
                400f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(2049), GetItem(1028) }),
            new Item(
                3085, "Runaan's Hurricane (Ranged Only)", 0, 600, true, ItemClass.None, (ItemCategory.AttackSpeed), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1042), GetItem(1043), GetItem(1042) }),
            new Item(
                3116, "Rylai's Crystal Scepter", 0, 605, true, ItemClass.None,
                (ItemCategory.Health & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 100f, 0f, 400f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1026), GetItem(1052), GetItem(1011) }),
            new Item(
                3181, "Sanguine Blade", 0, 600, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.LifeSteal), 0f,
                45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1037), GetItem(1053) }),
            new Item(
                1027, "Sapphire Crystal", 0, 400, false, ItemClass.None, (ItemCategory.Mana), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3342, "Scrying Orb (Trinket)", 0, 0, false, ItemClass.BasicTrinket, (ItemCategory.Consumable), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3191, "Seeker's Armguard", 0, 465, true, ItemClass.None, (ItemCategory.SpellDamage & ItemCategory.Armor),
                0f, 0f, 0f, 0f, 25f, 0f, 0f, 0f, 30f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1029), GetItem(1052) }),
            new Item(
                3040, "Seraph's Embrace", 0, 2700, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 60f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3048, "Seraph's Embrace", 0, 2700, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 60f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3057, "Sheen", 0, 365, true, ItemClass.None, (ItemCategory.SpellDamage & ItemCategory.Mana), 0f, 0f, 0f,
                0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1027), GetItem(1052) }),
            new Item(
                2049, "Sightstone", 0, 400, true, ItemClass.None, (ItemCategory.Health), 0f, 0f, 0f, 0f, 0f, 0f, 150f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1028) }),
            new Item(
                3718, "Skirmisher's Sabre - Enchantment: Devourer", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.AttackSpeed), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3715), GetItem(1042), GetItem(1042) }),
            new Item(
                3717, "Skirmisher's Sabre - Enchantment: Juggernaut", 0, 250, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3715), GetItem(3067), GetItem(1028) }),
            new Item(
                3176, "Skirmisher's Sabre - Enchantment: Magus", 0, 500, true, ItemClass.Enchantment,
                (ItemCategory.Health & ItemCategory.Mana), 0f, 0f, 0f, 0f, 0f, 0f, 400f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, new Item[] { GetItem(3010), GetItem(1028) }),
            new Item(
                3174, "Skirmisher's Sabre - Enchantment: Warrior", 0, 880, true, ItemClass.Enchantment,
                (ItemCategory.ManaRegen & ItemCategory.SpellBlock & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 60f, 0f,
                0f, 25f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3108), GetItem(3028) }),
            new Item(
                3715, "Skirmisher's Sabre", 0, 350, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1039) }),
            new Item(
                3259, "Sorcerer's Shoes - Enchantment: Alacrity", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3020) }),
            new Item(
                3256, "Sorcerer's Shoes - Enchantment: Captain", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3020) }),
            new Item(
                3258, "Sorcerer's Shoes - Enchantment: Distortion", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3020) }),
            new Item(
                3257, "Sorcerer's Shoes - Enchantment: Furor", 0, 475, true, ItemClass.Enchantment, (ItemCategory.None),
                0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3020) }),
            new Item(
                3255, "Sorcerer's Shoes - Enchantment: Homeguard", 0, 475, true, ItemClass.Enchantment,
                (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3020) }),
            new Item(
                3020, "Sorcerer's Shoes", 0, 775, true, ItemClass.None, (ItemCategory.None), 0f, 0f, 45f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1001) }),
            new Item(
                3345, "Soul Anchor (Trinket)", 0, 0, false, ItemClass.BasicTrinket, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3211, "Spectre's Cowl", 0, 300, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 200f,
                35f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1028), GetItem(1033) }),
            new Item(
                3303, "Spellthief's Edge", 0, 365, false, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 5f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                1080, "Spirit Stone", 0, 15, true, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1039), GetItem(1004), GetItem(1006) }),
            new Item(
                3065, "Spirit Visage", 0, 700, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.SpellBlock), 0f, 0f, 0f, 0f, 0f, 0f, 400f,
                55f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3211), GetItem(3067) }),
            new Item(
                3207, "Spirit of the Ancient Golem", 0, 450, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.Armor), 0f, 0f,
                0f, 0f, 0f, 0f, 200f, 0f, 20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3205), GetItem(3067) }),
            new Item(
                3208, "Spirit of the Ancient Golem", 0, 450, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.ManaRegen & ItemCategory.Armor), 0f, 0f,
                0f, 0f, 0f, 0f, 200f, 0f, 20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3204), GetItem(3067) }),
            new Item(
                3209, "Spirit of the Elder Lizard", 0, 580, true, ItemClass.None, (ItemCategory.Damage), 0f, 30f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1080), GetItem(1036), GetItem(1036) }),
            new Item(
                3206, "Spirit of the Spectral Wraith", 0, 480, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f,
                0f, 0f, 50f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1080), GetItem(3108) }),
            new Item(
                3710, "Stalker's Blade - Enchantment: Devourer", 0, 600, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.AttackSpeed), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3706), GetItem(1042), GetItem(1042) }),
            new Item(
                3709, "Stalker's Blade - Enchantment: Juggernaut", 0, 250, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Health & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3706), GetItem(3067), GetItem(1028) }),
            new Item(
                3708, "Stalker's Blade - Enchantment: Magus", 0, 680, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen & ItemCategory.SpellDamage), 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3706), GetItem(3108) }),
            new Item(
                3707, "Stalker's Blade - Enchantment: Warrior", 0, 163, true, ItemClass.Enchantment,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3706), GetItem(3134) }),
            new Item(
                3706, "Stalker's Blade", 0, 350, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Damage & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1039) }),
            new Item(
                3087, "Statikk Shiv", 0, 600, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.AttackSpeed), 0f, 0f, 0f, 0.2f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0.06f, 0f, new Item[] { GetItem(3086), GetItem(3093) }),
            new Item(
                2044, "Stealth Ward", 3, 75, false, ItemClass.None, (ItemCategory.Consumable), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3101, "Stinger", 0, 350, true, ItemClass.None, (ItemCategory.AttackSpeed), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1042), GetItem(1042) }),
            new Item(
                3068, "Sunfire Cape", 0, 850, true, ItemClass.None, (ItemCategory.Health & ItemCategory.Armor), 0f, 0f,
                0f, 0f, 0f, 0f, 450f, 0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1031), GetItem(1011) }),
            new Item(
                3341, "Sweeping Lens (Trinket)", 0, 0, false, ItemClass.BasicTrinket, (ItemCategory.Consumable), 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3131, "Sword of the Divine", 0, 800, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.AttackSpeed), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1043), GetItem(1042) }),
            new Item(
                3141, "Sword of the Occult", 0, 1040, true, ItemClass.None, (ItemCategory.Damage), 0f, 10f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1036) }),
            new Item(
                3069, "Talisman of Ascension", 0, 635, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.ManaRegen), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3096), GetItem(3114) }),
            new Item(
                3097, "Tragon's Brace", 0, 500, true, ItemClass.None, (ItemCategory.HealthRegen & ItemCategory.Health),
                0f, 0f, 0f, 0f, 0f, 0f, 175f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3302) }),
            new Item(
                3073, "Tear of the Goddess (Crystal Scar)", 0, 140, true, ItemClass.None,
                (ItemCategory.ManaRegen & ItemCategory.Mana), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, new Item[] { GetItem(1027), GetItem(1004) }),
            new Item(
                3070, "Tear of the Goddess", 0, 140, true, ItemClass.None, (ItemCategory.ManaRegen & ItemCategory.Mana),
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1027), GetItem(1004) }),
            new Item(
                3071, "The Black Cleaver", 0, 1263, true, ItemClass.None, (ItemCategory.Health & ItemCategory.Damage),
                0f, 50f, 0f, 0f, 0f, 0f, 200f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3134), GetItem(1028) }),
            new Item(
                3599, "The Black Spear", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3072, "The Bloodthirster", 0, 1150, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.LifeSteal),
                0f, 80f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1053), GetItem(1038) }),
            new Item(
                3134, "The Brutalizer", 0, 617, true, ItemClass.None, (ItemCategory.Damage), 0f, 25f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1036), GetItem(1036) }),
            new Item(
                3196, "The Hex Core mk-1", 0, 1000, true, ItemClass.None, (ItemCategory.SpellDamage & ItemCategory.Mana),
                0f, 0f, 0f, 0f, 20f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3200) }),
            new Item(
                3197, "The Hex Core mk-2", 0, 1000, true, ItemClass.None, (ItemCategory.SpellDamage & ItemCategory.Mana),
                0f, 0f, 0f, 0f, 40f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3196) }),
            new Item(
                3185, "The Lightbringer", 0, 350, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.Damage), 0f, 30f, 0f, 0.3f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3122), GetItem(1018) }),
            new Item(
                3075, "Thornmail", 0, 1050, true, ItemClass.None, (ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                100f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1029), GetItem(1031) }),
            new Item(
                3077, "Tiamat (Melee Only)", 0, 305, true, ItemClass.None,
                (ItemCategory.HealthRegen & ItemCategory.Damage), 0f, 40f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1037), GetItem(1036), GetItem(1006), GetItem(1006) }),
            new Item(
                2009, "Total Biscuit of Rejuvenation", 0, 0, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                2010, "Total Biscuit of Rejuvenation", 5, 35, false, ItemClass.None, (ItemCategory.None), 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3078, "Trinity Force", 0, 78, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.Health & ItemCategory.Damage & ItemCategory.AttackSpeed &
                 ItemCategory.SpellDamage & ItemCategory.Mana), 0f, 30f, 0f, 0.1f, 30f, 0f, 250f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0.08f, 0f, new Item[] { GetItem(3086), GetItem(3057), GetItem(3044) }),
            new Item(
                3023, "Twin Shadows", 0, 630, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 80f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0.06f, 0f, new Item[] { GetItem(3108), GetItem(3113) }),
            new Item(
                3290, "Twin Shadows", 0, 630, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 80f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0.06f, 0f, new Item[] { GetItem(3108), GetItem(3113) }),
            new Item(
                1053, "Vampiric Scepter", 0, 440, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.LifeSteal),
                0f, 10f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1036) }),
            new Item(
                2043, "Vision Ward", 2, 100, false, ItemClass.None, (ItemCategory.Consumable), 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3135, "Void Staff", 0, 1000, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f, 70f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1026), GetItem(1052) }),
            new Item(
                3082, "Warden's Mail", 0, 450, true, ItemClass.None, (ItemCategory.Armor), 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 45f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1029), GetItem(1029) }),
            new Item(
                3340, "Warding Totem (Trinket)", 0, 0, false, ItemClass.BasicTrinket, (ItemCategory.None), 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f),
            new Item(
                3083, "Warmog's Armor", 0, 300, true, ItemClass.None, (ItemCategory.HealthRegen & ItemCategory.Health),
                0f, 0f, 0f, 0f, 0f, 0f, 800f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(3801), GetItem(1011), GetItem(3801) }),
            new Item(
                3122, "Wicked Hatchet", 0, 440, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.Damage), 0f, 20f, 0f, 0.1f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(1051), GetItem(1036) }),
            new Item(
                3152, "Will of the Ancients", 0, 480, true, ItemClass.None, (ItemCategory.SpellDamage), 0f, 0f, 0f, 0f,
                80f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3145), GetItem(3108) }),
            new Item(
                3091, "Wit's End", 0, 750, true, ItemClass.None, (ItemCategory.SpellBlock & ItemCategory.AttackSpeed),
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 30f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                new Item[] { GetItem(1043), GetItem(1033), GetItem(1042) }),
            new Item(
                3090, "Wooglet's Witchcap", 0, 1045, true, ItemClass.None,
                (ItemCategory.SpellDamage & ItemCategory.Armor), 0f, 0f, 0f, 0f, 100f, 0f, 0f, 0f, 45f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3191), GetItem(1026), GetItem(1052) }),
            new Item(
                3154, "Wriggle's Lantern", 0, 215, true, ItemClass.None,
                (ItemCategory.Damage & ItemCategory.AttackSpeed), 0f, 12f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3106), GetItem(1036), GetItem(1042) }),
            new Item(
                3142, "Youmuu's Ghostblade", 0, 563, true, ItemClass.None,
                (ItemCategory.CriticalStrike & ItemCategory.Damage & ItemCategory.AttackSpeed), 0f, 30f, 0f, 0.15f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3093), GetItem(3134) }),
            new Item(
                3086, "Zeal", 0, 250, true, ItemClass.None, (ItemCategory.CriticalStrike & ItemCategory.AttackSpeed), 0f,
                0f, 0f, 0.1f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0.05f, 0f,
                new Item[] { GetItem(1051), GetItem(1042) }),
            new Item(
                3050, "Zeke's Herald", 0, 800, true, ItemClass.None,
                (ItemCategory.Health & ItemCategory.Damage & ItemCategory.LifeSteal), 0f, 0f, 0f, 0f, 0f, 0f, 250f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3067), GetItem(1053) }),
            new Item(
                3172, "Zephyr", 0, 725, true, ItemClass.None, (ItemCategory.Damage & ItemCategory.AttackSpeed), 0f, 25f,
                0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0.1f, 0f,
                new Item[] { GetItem(3101), GetItem(1037) }),
            new Item(
                3157, "Zhonya's Hourglass", 0, 500, true, ItemClass.None,
                (ItemCategory.SpellDamage & ItemCategory.Armor), 0f, 0f, 0f, 0f, 120f, 0f, 0f, 0f, 50f, 0f, 0f, 0f, 0f,
                0f, 0f, 0f, 0f, 0f, 0f, new Item[] { GetItem(3191), GetItem(1058) })
        };

        private static readonly List<Item> items = new List<Item>(pre_items);

        public static Item GetItemByName(string name)
        {
            return items.FirstOrDefault(i => i.GetName().Equals(name));
        }

        public static Item GetItem(int itemID)
        {
            var p = items.FirstOrDefault(i => i.GetId() == itemID);
            if (p == null)
            {
                Console.WriteLine(itemID);
            }
            return p ?? GetItem((int)ItemId.Abyssal_Scepter);
        }
    }
}