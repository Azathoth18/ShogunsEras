using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;
using Logger = Jotunn.Logger;

namespace ShogunEra
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class ShogunEra : BaseUnityPlugin
    {
        public const string PluginGUID = "Azathoth18.ShogunEra";
        public const string PluginName = "ShogunEra";
        public const string PluginVersion = "1.0.1";
        // This version should match package/manifest.json, which is the version displayed to clients from the thunderstore etc.

        internal static AssetBundle EmbeddedResourceBundle;
        CustomLocalization Localization;


        private void Awake()
        {
            // build the config class, and ensure defaults are available / configs ingested.
            new ShogunConfig(Config);

            // Load assets
            LoadAssets();

            // Add all the items, we provide the loaded resource bundle here to access all of the prefabs that get loaded.
            new ShogunEraItems(EmbeddedResourceBundle);

            AddLocalizations();
            // UnloadAssets();
        }

        // Check for other mods here and add compatability functionality
        private void Start()
        {

        }

        // This loads all localizations within the localization directory.
        // Localizations should be plain JSON objects with each of the two required entries being seperate eg:
        // "item_sword": "sword-name-here",
        // "item_sword_description": "sword-description-here",
        // the localization file itself should be a casematched language as defined by one of the "folder" language names from here:
        // https://valheim-modding.github.io/Jotunn/data/localization/language-list.html
        private void AddLocalizations()
        {
            Localization = LocalizationManager.Instance.GetLocalization();
            //LocalizationManager.Instance.AddLocalization(Localization);

            // load all localization files within the localizations directory
            // Localizations in that directory must be included in the projected and embedded into the DLL
            foreach (string embeddedResouce in typeof(ShogunEra).Assembly.GetManifestResourceNames())
            {
                if (!embeddedResouce.Contains("localizations")) { continue; }
                // Read the localization file
                if (ShogunConfig.EnableDebugMode.Value == true) { Logger.LogInfo($"Reading {embeddedResouce}"); }
                string localization = ReadEmbeddedResourceFile(embeddedResouce);
                // since I use comments in the localization that are not valid JSON those need to be stripped
                string cleaned_localization = Regex.Replace(localization, @"\/\/.*", "");
                // Just the localization name
                var localization_name = embeddedResouce.Split('.');
                if (ShogunConfig.EnableDebugMode.Value == true) { Logger.LogInfo($"Adding localization: '{localization_name[2]}'"); }
                Localization.AddJsonFile(localization_name[2], cleaned_localization);
            }
        }

        // This loads assets from the embedded asset bundle located at AssetsEmbedded
        private void LoadAssets()
        {
            if (ShogunConfig.EnableDebugMode.Value == true)
            {
                Logger.LogInfo($"Embedded resources: {string.Join(",", typeof(ShogunEra).Assembly.GetManifestResourceNames())}");
            }
            EmbeddedResourceBundle = AssetUtils.LoadAssetBundleFromResources("ShogunEra.AssetsEmbedded.shogunera", typeof(ShogunEra).Assembly);

            if (ShogunConfig.EnableDebugMode.Value == true)
            {
                Logger.LogInfo($"Asset Names: {string.Join(",", EmbeddedResourceBundle.GetAllAssetNames())}");
            }
        }

        // Best practice is to unload your assets after they have all been linked into the game
        private void UnloadAssets()
        {
            EmbeddedResourceBundle.Unload(false);
        }

        // This reads an embedded file resouce name, these are all resouces packed into the DLL
        private string ReadEmbeddedResourceFile(string filename)
        {
            using (var stream = typeof(ShogunEra).Assembly.GetManifestResourceStream(filename))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

    }
}