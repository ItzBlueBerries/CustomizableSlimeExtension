using MonomiPark.SlimeRancher.Regions;
using SRML;
using SRML.SR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomizableSlime.shortcut;
using System.IO;
using static ShortcutLib.Shortcut;
using static ShortcutLib.Debugging;
using CustomizableSlime.behaviours;
using UnityEngine;
using SRML.Utils;
using SRML.SR.SaveSystem;
using static SRML.SR.SlimeRegistry;
using HarmonyLib;

namespace CustomizableSlime
{
    public class Main : ModEntryPoint
    {
        public override void PreLoad()
        {
            HarmonyInstance.PatchAll();
            Checks.AssetsCheck();
            Enum.Parse(typeof(Identifiable.Id), ConfigurationSlime.WHAT_SLIME_PRODUCES);
            if (ConfigurationSlime.CAN_LARGOFY)
            { CustomizableLargos.CreateIdentifiables(); }
            TranslationPatcher.AddUITranslation("m.foodgroup.plorts", "Plorts");
            TranslationPatcher.AddUITranslation("m.foodgroup.nontarrgold_slimes", "Slimes");
            CustomizablePedia.PreLoadPredia();
            shortcut.CustomizableSlime.PreloadSpawn();
            if (ConfigurationSlime.LARGO_WITH_CUSTOMIZABLE_SLIME)
            {
                LargoIds.CUSTOMIZABLE_EX_CUSTOMIZABLE_LARGO = IdentifiableRegistry.CreateIdentifiableId(EnumPatcher.GetFirstFreeValue(typeof(Identifiable.Id)), "CUSTOMIZABLE_EX_CUSTOMIZABLE_LARGO");
            }
        }
        
        public override void Load()
        {
            if (!SRModLoader.IsModPresent("customizableog"))
                throw new Exception("\nCustomizable Slime is required to use this mod! Please install Customizable Slime before continuing any further.");
            /*CustomizableSlime.LoadCustomizedSlime();
            CustomizablePlort.LoadCustomizedPlort();*/

            shortcut.CustomizableSlime.LoadSlime();
            CustomizablePlort.LoadPlort();
            shortcut.CustomizableSlime.LoadStyle();

            if (ConfigurationSlime.CAN_LARGOFY)
            { CustomizableLargos.LoadLargos(); }

            if (ConfigurationSlime.LARGO_WITH_CUSTOMIZABLE_SLIME)
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

                Largo.CreateLargo("Customizable Ex Customizable Largo", Ids.CUSTOMIZABLE_EX_SLIME, EnumP.ParseID("CUSTOMIZABLE_SLIME"), LargoIds.CUSTOMIZABLE_EX_CUSTOMIZABLE_LARGO, largoProperties: array);
            }
        }

        public override void PostLoad() 
        {

        }
    }
}