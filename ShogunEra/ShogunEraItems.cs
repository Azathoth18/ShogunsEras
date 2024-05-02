using Jotunn.Configs;
using Jotunn.Entities;
using Jotunn.Managers;
using UnityEngine;
using Logger = Jotunn.Logger;
using ShogunEra.Effects;
using System.Collections.Generic;

namespace ShogunEra
{
    internal class ShogunEraItems
    {
        public ShogunEraItems(AssetBundle EmbeddedResourceBundle)

        {

            // Agregar otro ítem llamado "Bokken"
            ItemConfig BokkenConfig = new ItemConfig();
            BokkenConfig.Amount = ShogunConfig.BindServerConfig("Bokken", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            BokkenConfig.AddRequirement(new RequirementConfig("Wood", 10, 5));
            BokkenConfig.AddRequirement(new RequirementConfig("LeatherScraps", 2, 2));
            BokkenConfig.CraftingStation = "piece_workbench_ext2";
            GameObject BokkenPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_bokken.prefab");
            BokkenConfig.Icon = RenderManager.Instance.Render(BokkenPrefab, RenderManager.IsometricRotation);
            var Bokken = new CustomItem(BokkenPrefab, fixReference: true, BokkenConfig);
            ItemManager.Instance.AddItem(Bokken);

            // Agregar otro ítem llamado "Bo"
            ItemConfig BoConfig = new ItemConfig();
            BoConfig.Amount = ShogunConfig.BindServerConfig("Bo", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            BoConfig.AddRequirement(new RequirementConfig("Wood", 20, 5));
            BoConfig.AddRequirement(new RequirementConfig("LeatherScraps", 4, 2));
            BoConfig.CraftingStation = "piece_workbench_ext2";
            GameObject BoPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_bo.prefab");
            BoConfig.Icon = RenderManager.Instance.Render(BoPrefab, RenderManager.IsometricRotation);
            var Bo = new CustomItem(BoPrefab, fixReference: true, BoConfig);
            ItemManager.Instance.AddItem(Bo);

            // Agregar otro ítem llamado "Shinai"
            ItemConfig shinaiConfig = new ItemConfig();
            shinaiConfig.Amount = ShogunConfig.BindServerConfig("Shinai", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            shinaiConfig.AddRequirement(new RequirementConfig("Wood", 20, 10));
            shinaiConfig.AddRequirement(new RequirementConfig("Dandelion", 10, 5));
            shinaiConfig.AddRequirement(new RequirementConfig("LeatherScraps", 4, 2));
            shinaiConfig.CraftingStation = "piece_workbench_ext2";
            GameObject ShinaiPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_shinai.prefab");
            shinaiConfig.Icon = RenderManager.Instance.Render(ShinaiPrefab, RenderManager.IsometricRotation);
            var Shinai = new CustomItem(ShinaiPrefab, fixReference: true, shinaiConfig);
            ItemManager.Instance.AddItem(Shinai);

            // Agregar otro ítem llamado "Katana"
            ItemConfig KatanaConfig = new ItemConfig();
            KatanaConfig.Amount = ShogunConfig.BindServerConfig("Katana", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatanaConfig.AddRequirement(new RequirementConfig("FineWood", 2, 1));
            KatanaConfig.AddRequirement(new RequirementConfig("Tin", 20, 10));
            KatanaConfig.AddRequirement(new RequirementConfig("DeerHide", 2, 1));
            KatanaConfig.CraftingStation = "forge_ext5";
            GameObject KatanaPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katana1.prefab");
            KatanaConfig.Icon = RenderManager.Instance.Render(KatanaPrefab, RenderManager.IsometricRotation);
            var Katana = new CustomItem(KatanaPrefab, fixReference: true, KatanaConfig);
            ItemManager.Instance.AddItem(Katana);

            // Agregar otro ítem llamado "nagatina"
            ItemConfig nagatinaConfig = new ItemConfig();
            nagatinaConfig.Amount = ShogunConfig.BindServerConfig("Nagatina", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            nagatinaConfig.AddRequirement(new RequirementConfig("FineWood", 8, 4));
            nagatinaConfig.AddRequirement(new RequirementConfig("Tin", 16, 8));
            nagatinaConfig.AddRequirement(new RequirementConfig("DeerHide", 2, 1));
            nagatinaConfig.CraftingStation = "forge_ext5";
            GameObject nagatinaPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_nagatina.prefab");
            nagatinaConfig.Icon = RenderManager.Instance.Render(nagatinaPrefab, RenderManager.IsometricRotation);
            var nagatina = new CustomItem(nagatinaPrefab, fixReference: true, nagatinaConfig);
            
            ItemManager.Instance.AddItem(nagatina);

            // Agregar otro ítem llamado "Ninjato"
            ItemConfig NinjatoConfig = new ItemConfig();
            NinjatoConfig.Amount = ShogunConfig.BindServerConfig("Ninjato", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            NinjatoConfig.AddRequirement(new RequirementConfig("FineWood", 2, 1));
            NinjatoConfig.AddRequirement(new RequirementConfig("Tin", 12, 6));
            NinjatoConfig.AddRequirement(new RequirementConfig("DeerHide", 2, 1));
            NinjatoConfig.CraftingStation = "forge_ext5";
            GameObject NinjatoPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_ninjato.prefab");
            NinjatoConfig.Icon = RenderManager.Instance.Render(NinjatoPrefab, RenderManager.IsometricRotation);
            var Ninjato = new CustomItem(NinjatoPrefab, fixReference: true, NinjatoConfig);
            ItemManager.Instance.AddItem(Ninjato);

            // Agregar otro ítem llamado Tanto
            ItemConfig tantoConfig = new ItemConfig();
            tantoConfig.Amount = ShogunConfig.BindServerConfig("Tanto", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            tantoConfig.AddRequirement(new RequirementConfig("ElderBark", 2, 1));
            tantoConfig.AddRequirement(new RequirementConfig("Iron", 20, 10));
            tantoConfig.AddRequirement(new RequirementConfig("TrollHide", 2, 1));
            tantoConfig.CraftingStation = "forge_ext1";
            GameObject tantoprefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_tantoknife.prefab");
            tantoConfig.Icon = RenderManager.Instance.Render(tantoprefab, RenderManager.IsometricRotation);
            var tanto = new CustomItem(tantoprefab, fixReference: true, tantoConfig);
            ItemManager.Instance.AddItem(tanto);

            // Agregar otro ítem llamado "Shakujo"
            ItemConfig ShakujoConfig = new ItemConfig();
            ShakujoConfig.Amount = ShogunConfig.BindServerConfig("Shakujo", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            ShakujoConfig.AddRequirement(new RequirementConfig("FineWood", 8, 4));
            ShakujoConfig.AddRequirement(new RequirementConfig("Bronze", 12, 6));
            ShakujoConfig.AddRequirement(new RequirementConfig("DeerHide", 2, 1));
            ShakujoConfig.CraftingStation = "forge_ext2";
            GameObject ShakujoPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_shakujo.prefab");
            ShakujoConfig.Icon = RenderManager.Instance.Render(ShakujoPrefab, RenderManager.IsometricRotation);
            var Shakujo = new CustomItem(ShakujoPrefab, fixReference: true, ShakujoConfig);
            ItemManager.Instance.AddItem(Shakujo);

            // Agregar otro ítem llamado "Kamayari"
            ItemConfig KamayariConfig = new ItemConfig();
            KamayariConfig.Amount = ShogunConfig.BindServerConfig("Kamayari", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KamayariConfig.AddRequirement(new RequirementConfig("ElderBark", 10, 5));
            KamayariConfig.AddRequirement(new RequirementConfig("Iron", 40, 20));
            KamayariConfig.AddRequirement(new RequirementConfig("TrollHide", 4, 2));
            KamayariConfig.CraftingStation = "forge_ext1";
            GameObject KamayariPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_kamayari.prefab");
            KamayariConfig.Icon = RenderManager.Instance.Render(KamayariPrefab, RenderManager.IsometricRotation);
            var Kamayari = new CustomItem(KamayariPrefab, fixReference: true, KamayariConfig);
            ItemManager.Instance.AddItem(Kamayari);

            // Agregar otro ítem llamado "Kanobo"
            ItemConfig KanoboConfig = new ItemConfig();
            KanoboConfig.Amount = ShogunConfig.BindServerConfig("Kanobo", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KanoboConfig.AddRequirement(new RequirementConfig("ElderBark", 10, 5));
            KanoboConfig.AddRequirement(new RequirementConfig("Iron", 40, 20));
            KanoboConfig.AddRequirement(new RequirementConfig("TrollHide", 8, 4));
            KanoboConfig.CraftingStation = "forge_ext1";
            GameObject KanoboPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_kanobo.prefab");
            KanoboConfig.Icon = RenderManager.Instance.Render(KanoboPrefab, RenderManager.IsometricRotation);
            var Kanobo = new CustomItem(KanoboPrefab, fixReference: true, KanoboConfig);
            ItemManager.Instance.AddItem(Kanobo);

            // Agregar otro ítem llamado "Katana2"
            ItemConfig Katana2Config = new ItemConfig();
            Katana2Config.Amount = ShogunConfig.BindServerConfig("Katana2", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            Katana2Config.AddRequirement(new RequirementConfig("ElderBark", 4, 2));
            Katana2Config.AddRequirement(new RequirementConfig("Iron", 40, 20));
            Katana2Config.AddRequirement(new RequirementConfig("TrollHide", 4, 2));
            Katana2Config.CraftingStation = "forge_ext1";
            GameObject Katana2Prefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katana2.prefab");
            Katana2Config.Icon = RenderManager.Instance.Render(Katana2Prefab, RenderManager.IsometricRotation);
            var Katana2 = new CustomItem(Katana2Prefab, fixReference: true, Katana2Config);
            ItemManager.Instance.AddItem(Katana2);

            // Agregar otro ítem llamado "Katana dorada"
            ItemConfig KatanaDoradaConfig = new ItemConfig();
            KatanaDoradaConfig.Amount = ShogunConfig.BindServerConfig("Katana dorada", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatanaDoradaConfig.AddRequirement(new RequirementConfig("ElderBark", 4, 2));
            KatanaDoradaConfig.AddRequirement(new RequirementConfig("Iron", 40, 20));
            KatanaDoradaConfig.AddRequirement(new RequirementConfig("TrollHide", 4, 2));
            KatanaDoradaConfig.AddRequirement(new RequirementConfig("SurtlingCore", 20, 10));
            KatanaDoradaConfig.AddRequirement(new RequirementConfig("TrophySurtling", 4, 2));
            KatanaDoradaConfig.CraftingStation = "forge_ext1";
            GameObject KatanaDoradaPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katanadefuego1.prefab");
            KatanaDoradaConfig.Icon = RenderManager.Instance.Render(KatanaDoradaPrefab, RenderManager.IsometricRotation);
            var KatanaDorada = new CustomItem(KatanaDoradaPrefab, fixReference: true, KatanaDoradaConfig);
            ItemManager.Instance.AddItem(KatanaDorada);

            // Agregar otro ítem llamado "Katana Valkye"
            ItemConfig KatanaValkyeConfig = new ItemConfig();
            KatanaValkyeConfig.Amount = ShogunConfig.BindServerConfig("Katana Valkye", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatanaValkyeConfig.AddRequirement(new RequirementConfig("ElderBark", 4, 2));
            KatanaValkyeConfig.AddRequirement(new RequirementConfig("Iron", 30, 15));
            KatanaValkyeConfig.AddRequirement(new RequirementConfig("TrollHide", 4, 2));
            KatanaValkyeConfig.CraftingStation = "forge_ext1";
            GameObject KatanaValkyePrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katanavalkyrie.prefab");
            KatanaValkyeConfig.Icon = RenderManager.Instance.Render(KatanaValkyePrefab, RenderManager.IsometricRotation);
            var KatanaValkye = new CustomItem(KatanaValkyePrefab, fixReference: true, KatanaValkyeConfig);
            ItemManager.Instance.AddItem(KatanaValkye);

            // Agregar otro ítem llamado "Sai"
            ItemConfig SaiConfig = new ItemConfig();
            SaiConfig.Amount = ShogunConfig.BindServerConfig("Sai", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            SaiConfig.AddRequirement(new RequirementConfig("FineWood", 2, 2));
            SaiConfig.AddRequirement(new RequirementConfig("Silver", 20, 15));
            SaiConfig.AddRequirement(new RequirementConfig("Iron", 6, 15));
            SaiConfig.AddRequirement(new RequirementConfig("WolfPelt", 2, 2));
            SaiConfig.CraftingStation = "piece_workbench_ext4"; 
            GameObject SaiPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_sai.prefab");
            SaiConfig.Icon = RenderManager.Instance.Render(SaiPrefab, RenderManager.IsometricRotation);
            var Sai = new CustomItem(SaiPrefab, fixReference: true, SaiConfig);
            ItemManager.Instance.AddItem(Sai);

            // Agregar otro ítem llamado "Katana de las nubes"
            ItemConfig KatanadelasnubesConfig = new ItemConfig();
            KatanadelasnubesConfig.Amount = ShogunConfig.BindServerConfig("Katana de las nubes", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatanadelasnubesConfig.AddRequirement(new RequirementConfig("FineWood", 4, 2));
            KatanadelasnubesConfig.AddRequirement(new RequirementConfig("Silver", 50, 25));
            KatanadelasnubesConfig.AddRequirement(new RequirementConfig("Iron", 10, 5));
            KatanadelasnubesConfig.AddRequirement(new RequirementConfig("WolfPelt", 4, 2));
            KatanadelasnubesConfig.CraftingStation = "piece_workbench_ext4";
            GameObject KatanadelasnubesPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katanadelcielo.prefab");
            KatanadelasnubesConfig.Icon = RenderManager.Instance.Render(KatanadelasnubesPrefab, RenderManager.IsometricRotation);
            var Katanadelasnubes = new CustomItem(KatanadelasnubesPrefab, fixReference: true, KatanadelasnubesConfig);
            ItemManager.Instance.AddItem(Katanadelasnubes);

            // Agregar otro ítem llamado "Katana sakura"
            ItemConfig KatanasakuraConfig = new ItemConfig();
            KatanasakuraConfig.Amount = ShogunConfig.BindServerConfig("Katana sakura", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatanasakuraConfig.AddRequirement(new RequirementConfig("FineWood", 2, 2));
            KatanasakuraConfig.AddRequirement(new RequirementConfig("Silver", 60, 30));
            KatanasakuraConfig.AddRequirement(new RequirementConfig("WolfPelt", 2, 2));
            KatanasakuraConfig.CraftingStation = "piece_workbench_ext4";
            GameObject KatanasakuraPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katana3.prefab");
            KatanasakuraConfig.Icon = RenderManager.Instance.Render(KatanasakuraPrefab, RenderManager.IsometricRotation);
            var Katanasakura = new CustomItem(KatanasakuraPrefab, fixReference: true, KatanasakuraConfig);
            ItemManager.Instance.AddItem(Katanasakura);

            // Agregar otro ítem llamado "Katana de un gigante"
            ItemConfig KatanadeungiganteConfig = new ItemConfig();
            KatanadeungiganteConfig.Amount = ShogunConfig.BindServerConfig("Katana de un gigante", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatanadeungiganteConfig.AddRequirement(new RequirementConfig("RoundLog", 10, 5));
            KatanadeungiganteConfig.AddRequirement(new RequirementConfig("Silver", 40, 20));
            KatanadeungiganteConfig.AddRequirement(new RequirementConfig("Iron", 40, 20));
            KatanadeungiganteConfig.AddRequirement(new RequirementConfig("WolfPelt", 10, 5));
            KatanadeungiganteConfig.CraftingStation = "piece_workbench_ext4";
            GameObject KatanadeungigantePrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_gigantekatana.prefab");
            KatanadeungiganteConfig.Icon = RenderManager.Instance.Render(KatanadeungigantePrefab, RenderManager.IsometricRotation);
            var Katanadeungigante = new CustomItem(KatanadeungigantePrefab, fixReference: true, KatanadeungiganteConfig);
            ItemManager.Instance.AddItem(Katanadeungigante);

            // Agregar otro ítem llamado "Katana negra"
            ItemConfig KatananegraConfig = new ItemConfig();
            KatananegraConfig.Amount = ShogunConfig.BindServerConfig("Katana negra", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatananegraConfig.AddRequirement(new RequirementConfig("FineWood", 4, 2));
            KatananegraConfig.AddRequirement(new RequirementConfig("BlackMetal", 50, 25));
            KatananegraConfig.AddRequirement(new RequirementConfig("LinenThread", 16, 8));
            KatananegraConfig.AddRequirement(new RequirementConfig("SurtlingCore", 20, 10));
            KatananegraConfig.AddRequirement(new RequirementConfig("TrophyCultist", 4, 2));
            KatananegraConfig.CraftingStation = "piece_artisanstation";
            GameObject KatananegraPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katanadefuego.prefab");
            KatananegraConfig.Icon = RenderManager.Instance.Render(KatananegraPrefab, RenderManager.IsometricRotation);
            var Katananegra = new CustomItem(KatananegraPrefab, fixReference: true, KatananegraConfig);
            ItemManager.Instance.AddItem(Katananegra);

            // Agregar otro ítem llamado "Katana de hielo"
            ItemConfig KatanahieloConfig = new ItemConfig();
            KatanahieloConfig.Amount = ShogunConfig.BindServerConfig("Katana negra", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KatanahieloConfig.AddRequirement(new RequirementConfig("FineWood", 4, 2));
            KatanahieloConfig.AddRequirement(new RequirementConfig("BlackMetal", 50, 25));
            KatanahieloConfig.AddRequirement(new RequirementConfig("LinenThread", 16, 8));
            KatanahieloConfig.AddRequirement(new RequirementConfig("FreezeGland", 20, 10));
            KatanahieloConfig.AddRequirement(new RequirementConfig("TrophyCultist", 4, 2));
            KatanahieloConfig.CraftingStation = "piece_artisanstation";
            GameObject KatanahieloPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_Katanadehielo.prefab");
            KatanahieloConfig.Icon = RenderManager.Instance.Render(KatanahieloPrefab, RenderManager.IsometricRotation);
            var Katanahielo = new CustomItem(KatanahieloPrefab, fixReference: true, KatanahieloConfig);
            ItemManager.Instance.AddItem(Katanahielo);

            // Agregar otro ítem llamado "Bebedora de sangre"
            ItemConfig BebedoradesangreConfig = new ItemConfig();
            BebedoradesangreConfig.Amount = ShogunConfig.BindServerConfig("Bebedora de sangre", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            BebedoradesangreConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            BebedoradesangreConfig.AddRequirement(new RequirementConfig("Carapace", 50, 25));
            BebedoradesangreConfig.AddRequirement(new RequirementConfig("Eitr", 16, 8));
            BebedoradesangreConfig.AddRequirement(new RequirementConfig("ScaleHide", 16, 8));
            BebedoradesangreConfig.AddRequirement(new RequirementConfig("SurtlingCore", 20, 10));
            BebedoradesangreConfig.AddRequirement(new RequirementConfig("TrophyGoblinKing", 4, 2));
            BebedoradesangreConfig.CraftingStation = "blackforge";
            GameObject BebedoradesangrePrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katanamurasama1.prefab");
            BebedoradesangreConfig.Icon = RenderManager.Instance.Render(BebedoradesangrePrefab, RenderManager.IsometricRotation);
            var Bebedoradesangre = new CustomItem(BebedoradesangrePrefab, fixReference: true, BebedoradesangreConfig);
            ItemManager.Instance.AddItem(Bebedoradesangre);

            // Robo de vida
            var lifeStealEffect = ScriptableObject.CreateInstance<SE_LifeSteal>();
            lifeStealEffect.m_name = "Life Steal";
            lifeStealEffect.m_chanceToStealLife = 0.15f; // 15% de probabilidad
            lifeStealEffect.m_lifeStealMin = 0.1f; // Roba mínimo un 10% de la vida
            lifeStealEffect.m_lifeStealMax = 0.3f; // Roba máximo un 30% de la vida
            var customLifeStealEffect = new CustomStatusEffect(lifeStealEffect, fixReference: false);
            ItemManager.Instance.AddStatusEffect(customLifeStealEffect);
            Bebedoradesangre.ItemDrop.m_itemData.m_shared.m_equipStatusEffect = customLifeStealEffect.StatusEffect;
            Bokken.ItemDrop.m_itemData.m_shared.m_equipStatusEffect = customLifeStealEffect.StatusEffect;


            // Agregar otro ítem llamado "Kanata Musashi"
            ItemConfig KanataMusashiConfig = new ItemConfig();
            KanataMusashiConfig.Amount = ShogunConfig.BindServerConfig("Bebedora de sangre", "craftamount", 1, "the number of items crafted from this recipe", true, 1, 20).Value;
            KanataMusashiConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            KanataMusashiConfig.AddRequirement(new RequirementConfig("Carapace", 50, 25));
            KanataMusashiConfig.AddRequirement(new RequirementConfig("Eitr", 16, 8));
            KanataMusashiConfig.AddRequirement(new RequirementConfig("ScaleHide", 16, 8));
            KanataMusashiConfig.AddRequirement(new RequirementConfig("SurtlingCore", 20, 10));
            KanataMusashiConfig.AddRequirement(new RequirementConfig("TrophyGoblinKing", 4, 2));
            KanataMusashiConfig.CraftingStation = "blackforge";
            GameObject KanataMusashiPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_katanamusashi.prefab");
            KanataMusashiConfig.Icon = RenderManager.Instance.Render(KanataMusashiPrefab, RenderManager.IsometricRotation);
            var KanataMusashi = new CustomItem(KanataMusashiPrefab, fixReference: true, KanataMusashiConfig);
            ItemManager.Instance.AddItem(KanataMusashi);

            // Cascos
            // Casco samurai negro con plateado
            ItemConfig ciberhatConfig = new ItemConfig();
            ciberhatConfig.Amount = 1;
            ciberhatConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            ciberhatConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            ciberhatConfig.CraftingStation = "forge_ext2";
            GameObject ciberhatPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_ciberhat.prefab");
            ciberhatConfig.Icon = RenderManager.Instance.Render(ciberhatPrefab, RenderManager.IsometricRotation);
            var ciberhat = new CustomItem(ciberhatPrefab, fixReference: true, ciberhatConfig);
            ItemManager.Instance.AddItem(ciberhat);

            // Hannya
            ItemConfig hannyamaskConfig = new ItemConfig();
            hannyamaskConfig.Amount = 1;
            hannyamaskConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            hannyamaskConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            hannyamaskConfig.CraftingStation = "forge_ext2";
            GameObject hannyamaskPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_hannyamask.prefab");
            hannyamaskConfig.Icon = RenderManager.Instance.Render(hannyamaskPrefab, RenderManager.IsometricRotation);
            var hannyamask = new CustomItem(hannyamaskPrefab, fixReference: true, hannyamaskConfig);
            ItemManager.Instance.AddItem(hannyamask);

            // Jingasa
            ItemConfig hatjingasaConfig = new ItemConfig();
            hatjingasaConfig.Amount = 1;
            hatjingasaConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            hatjingasaConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            hatjingasaConfig.CraftingStation = "forge_ext2";
            GameObject hatjingasaPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_hatjingasa.prefab");
            hatjingasaConfig.Icon = RenderManager.Instance.Render(hatjingasaPrefab, RenderManager.IsometricRotation);
            var hatjingasa = new CustomItem(hatjingasaPrefab, fixReference: true, hatjingasaConfig);
            ItemManager.Instance.AddItem(hatjingasa);

            // Mempo
            ItemConfig mempomaskConfig = new ItemConfig();
            mempomaskConfig.Amount = 1;
            mempomaskConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            mempomaskConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            mempomaskConfig.CraftingStation = "forge_ext2";
            GameObject mempomaskPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_mempomask.prefab");
            mempomaskConfig.Icon = RenderManager.Instance.Render(mempomaskPrefab, RenderManager.IsometricRotation);
            var mempomask = new CustomItem(mempomaskPrefab, fixReference: true, mempomaskConfig);
            ItemManager.Instance.AddItem(mempomask);


            //Casco Samurai negro con correas
            ItemConfig samuraihelmetkabutoConfig = new ItemConfig();
            samuraihelmetkabutoConfig.Amount = 1;
            samuraihelmetkabutoConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            samuraihelmetkabutoConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            samuraihelmetkabutoConfig.CraftingStation = "forge_ext2";
            GameObject samuraihelmetkabutoPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_samuraihelmetkabuto.prefab");
            samuraihelmetkabutoConfig.Icon = RenderManager.Instance.Render(samuraihelmetkabutoPrefab, RenderManager.IsometricRotation);
            var samuraihelmetkabuto = new CustomItem(samuraihelmetkabutoPrefab, fixReference: true, samuraihelmetkabutoConfig);
            ItemManager.Instance.AddItem(samuraihelmetkabuto);

            //Casco Kabuto
            ItemConfig samuraikabutoConfig = new ItemConfig();
            samuraikabutoConfig.Amount = 1;
            samuraikabutoConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            samuraikabutoConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            samuraikabutoConfig.CraftingStation = "forge_ext2";
            GameObject samuraikabutoPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_samuraikabuto.prefab");
            samuraikabutoConfig.Icon = RenderManager.Instance.Render(samuraikabutoPrefab, RenderManager.IsometricRotation);
            var samuraikabuto = new CustomItem(samuraikabutoPrefab, fixReference: true, samuraikabutoConfig);
            ItemManager.Instance.AddItem(samuraikabuto);

            //Casco Samurai rojo con negro
            ItemConfig samuraikabuto1Config = new ItemConfig();
            samuraikabuto1Config.Amount = 1;
            samuraikabuto1Config.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            samuraikabuto1Config.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            samuraikabuto1Config.CraftingStation = "forge_ext2";
            GameObject samuraikabuto1Prefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_samuraikabuto1.prefab");
            samuraikabuto1Config.Icon = RenderManager.Instance.Render(samuraikabuto1Prefab, RenderManager.IsometricRotation);
            var samuraikabuto1 = new CustomItem(samuraikabuto1Prefab, fixReference: true, samuraikabuto1Config);
            ItemManager.Instance.AddItem(samuraikabuto1);

            //Kabuto Samurai
            ItemConfig samuraikabutoblackConfig = new ItemConfig();
            samuraikabutoblackConfig.Amount = 1;
            samuraikabutoblackConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            samuraikabutoblackConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            samuraikabutoblackConfig.CraftingStation = "forge_ext2";
            GameObject samuraikabutoblackPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_samuraikabutoblack.prefab");
            samuraikabutoblackConfig.Icon = RenderManager.Instance.Render(samuraikabutoblackPrefab, RenderManager.IsometricRotation);
            var samuraikabutoblack = new CustomItem(samuraikabutoblackPrefab, fixReference: true, samuraikabutoblackConfig);
            ItemManager.Instance.AddItem(samuraikabutoblack);

            //Kabuto con astas de ciervo
            ItemConfig samuraikabutomabizashiConfig = new ItemConfig();
            samuraikabutomabizashiConfig.Amount = 1;
            samuraikabutomabizashiConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            samuraikabutomabizashiConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            samuraikabutomabizashiConfig.CraftingStation = "forge_ext2";
            GameObject samuraikabutomabizashiPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_samuraikabutomabizashi.prefab");
            samuraikabutomabizashiConfig.Icon = RenderManager.Instance.Render(samuraikabutomabizashiPrefab, RenderManager.IsometricRotation);
            var samuraikabutomabizashi = new CustomItem(samuraikabutomabizashiPrefab, fixReference: true, samuraikabutomabizashiConfig);
            ItemManager.Instance.AddItem(samuraikabutomabizashi);

            //Tengou 
            ItemConfig tengoumaskConfig = new ItemConfig();
            tengoumaskConfig.Amount = 1;
            tengoumaskConfig.AddRequirement(new RequirementConfig("FineWood", 40, 2));
            tengoumaskConfig.AddRequirement(new RequirementConfig("Bronze", 50, 25));
            tengoumaskConfig.CraftingStation = "forge_ext2";
            GameObject tengoumaskPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("assets/creaciones/eras/shogunera/listos/se_tengoumask.prefab");
            tengoumaskConfig.Icon = RenderManager.Instance.Render(tengoumaskPrefab, RenderManager.IsometricRotation);
            var tengoumask = new CustomItem(tengoumaskPrefab, fixReference: true, tengoumaskConfig);
            ItemManager.Instance.AddItem(tengoumask);

            // Loaded items will resolve localization text like $item_tanto_name, $item_tanto_description to keys in the localizations files

            // Logs a simple notification to the console during startup that this item was loaded, if debug logging is enabled.
            if (ShogunConfig.EnableDebugMode.Value == true) 
            { Logger.LogInfo("Loaded Tanto Item & Recipe.");
              Logger.LogInfo("Loaded Shinai Item & Recipe.");
              Logger.LogInfo("Loaded Bokken Item & Recipe.");
              Logger.LogInfo("Loaded Bo Item & Recipe.");
              Logger.LogInfo("Loaded Katana Item & Recipe.");
              Logger.LogInfo("Loaded Nagitina Item & Recipe.");
              Logger.LogInfo("Loaded Ninjato Item & Recipe.");
              Logger.LogInfo("Loaded Shakujo Item & Recipe.");
              Logger.LogInfo("Loaded Kamayari Item & Recipe.");
              Logger.LogInfo("Loaded Kanobo Item & Recipe.");
              Logger.LogInfo("Loaded Katana2 Item & Recipe.");
              Logger.LogInfo("Loaded Katanadorada Item & Recipe.");
              Logger.LogInfo("Loaded KatanaValkye Item & Recipe.");
              Logger.LogInfo("Loaded Sai Item & Recipe.");
              Logger.LogInfo("Loaded Katana de las nubes Item & Recipe.");
              Logger.LogInfo("Loaded Katana Sakura Item & Recipe.");
              Logger.LogInfo("Loaded Katana de un gigante Item & Recipe.");
              Logger.LogInfo("Loaded Katana negra Item & Recipe.");
              Logger.LogInfo("Loaded Katana hielo Item & Recipe.");
              Logger.LogInfo("Loaded Katana musashi Item & Recipe.");
              Logger.LogInfo("Loaded Bebedora de sangre Item & Recipe.");
      
            }
        }
    }
}