using SRML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SRML.SR.SlimeRegistry;

namespace CustomizableSlime.shortcut
{
    internal class CustomizableLargos
    {
        public static void CreateIdentifiables()
        {
            LargoIds.CUSTOMIZABLE_EX_PINK_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_PINK_LARGO");
            LargoIds.CUSTOMIZABLE_EX_ROCK_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_ROCK_LARGO");
            LargoIds.CUSTOMIZABLE_EX_TABBY_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_TABBY_LARGO");
            LargoIds.CUSTOMIZABLE_EX_BOOM_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_BOOM_LARGO");
            LargoIds.CUSTOMIZABLE_EX_CRYSTAL_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_CRYSTAL_LARGO");
            LargoIds.CUSTOMIZABLE_EX_DERVISH_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_DERVISH_LARGO");
            LargoIds.CUSTOMIZABLE_EX_FIRE_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_FIRE_LARGO");
            LargoIds.CUSTOMIZABLE_EX_PUDDLE_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_PUDDLE_LARGO");
            LargoIds.CUSTOMIZABLE_EX_HONEY_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_HONEY_LARGO");
            LargoIds.CUSTOMIZABLE_EX_HUNTER_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_HUNTER_LARGO");
            LargoIds.CUSTOMIZABLE_EX_MOSAIC_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_MOSAIC_LARGO");
            LargoIds.CUSTOMIZABLE_EX_PHOSPHOR_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_PHOSPHOR_LARGO");
            LargoIds.CUSTOMIZABLE_EX_QUANTUM_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_QUANTUM_LARGO");
            LargoIds.CUSTOMIZABLE_EX_RAD_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_RAD_LARGO");
            LargoIds.CUSTOMIZABLE_EX_SABER_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_SABER_LARGO");
            LargoIds.CUSTOMIZABLE_EX_TANGLE_LARGO = SRML.SR.IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_TANGLE_LARGO");
        }

        public static void LoadLargos()
        {
            LargoProps array =
                ConfigurationLargoProps.LARGO_PROPERTY_1 |
                ConfigurationLargoProps.LARGO_PROPERTY_2 |
                ConfigurationLargoProps.LARGO_PROPERTY_3 |
                ConfigurationLargoProps.LARGO_PROPERTY_4 |
                ConfigurationLargoProps.LARGO_PROPERTY_5 |
                ConfigurationLargoProps.LARGO_PROPERTY_6 |
                ConfigurationLargoProps.LARGO_PROPERTY_7 |
                ConfigurationLargoProps.LARGO_PROPERTY_8 |
                ConfigurationLargoProps.LARGO_PROPERTY_9 |
                ConfigurationLargoProps.LARGO_PROPERTY_10;

            CraftLargo(LargoIds.CUSTOMIZABLE_EX_PINK_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.PINK_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_ROCK_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.ROCK_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_TABBY_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.TABBY_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_BOOM_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.BOOM_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_CRYSTAL_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.CRYSTAL_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_DERVISH_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.DERVISH_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_FIRE_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.FIRE_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_PUDDLE_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.PUDDLE_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_HONEY_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.HONEY_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_HUNTER_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.HUNTER_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_MOSAIC_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.MOSAIC_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_PHOSPHOR_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.PHOSPHOR_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_QUANTUM_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.QUANTUM_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_RAD_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.RAD_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_SABER_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.SABER_SLIME, array);
            CraftLargo(LargoIds.CUSTOMIZABLE_EX_TANGLE_LARGO, Ids.CUSTOMIZABLE_EX_SLIME, Identifiable.Id.TANGLE_SLIME, array);
        }

        public static void PostloadLargos()
        {

        }
    }
}
