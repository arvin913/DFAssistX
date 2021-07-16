using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace App
{
    internal class Settings
    {
        private static INIFile iniFile;

        public static string Language { get; set; } = "en-us";
        public static bool ShowOverlay { get; set; } = true;
        public static int OverlayX { get; set; } = Global.OVERLAY_XY_UNSET;
        public static int OverlayY { get; set; } = Global.OVERLAY_XY_UNSET;
        public static bool StartupShowMainForm { get; set; } = true;
        public static bool AutoOverlayHide { get; set; } = true;
        public static bool FlashWindow { get; set; } = true;
        public static bool CheatRoulette { get; set; } = true;
        public static bool Remind { get; set; } = false;
        public static bool TTS { get; set; } = true;
        public static bool Debug { get; set; } = false;
        public static bool EurekaMode { get; set; } = false;
        public static bool Updated { get; set; } = true;
        public static HashSet<int> FATEs { get; set; } = new HashSet<int>();

        private static void Init()
        {
        }

        public static void Load()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Global.APPNAME, Global.SETTINGS_FILEPATH);

            iniFile = new INIFile(path);
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                Init();
                Save();
            }
            else
            {
                StartupShowMainForm = iniFile.ReadValue("startup", "show") != "0";
                ShowOverlay = iniFile.ReadValue("overlay", "show") != "0";
                AutoOverlayHide = iniFile.ReadValue("overlay", "autohide") != "0";
                OverlayX = int.Parse(iniFile.ReadValue("overlay", "x") ?? "0");
                OverlayY = int.Parse(iniFile.ReadValue("overlay", "y") ?? "0");
                TTS = iniFile.ReadValue("misc", "tts") == "1";
                FlashWindow = iniFile.ReadValue("notification", "flashwindow") != "0";
                CheatRoulette = iniFile.ReadValue("misc", "cheatroulette") == "1";
                Remind= iniFile.ReadValue("misc", "remind") == "1";
                //CheatRoulette = false; // 防止滥用
                Debug = iniFile.ReadValue("misc", "debug") == "1";
                Language = iniFile.ReadValue("misc", "language") ?? "en-us";
                Updated = iniFile.ReadValue("internal", "updated") != "0";

                var fates = iniFile.ReadValue("fate", "fates");
                if (!string.IsNullOrEmpty(fates))
                {
                    FATEs = new HashSet<int>(from x in fates.Split(',') select int.Parse(x));
                }
            }
        }

        public static void Save()
        {
            iniFile.WriteValue("startup", "show", StartupShowMainForm ? "1" : "0");
            iniFile.WriteValue("overlay", "show", ShowOverlay ? "1" : "0");
            iniFile.WriteValue("overlay", "autohide", AutoOverlayHide ? "1" : "0");
            iniFile.WriteValue("overlay", "x", OverlayX.ToString());
            iniFile.WriteValue("overlay", "y", OverlayY.ToString());
            iniFile.WriteValue("notification", "flashwindow", FlashWindow ? "1" : "0");
            iniFile.WriteValue("misc", "cheatroulette", CheatRoulette ? "1" : "0");
            iniFile.WriteValue("misc", "remind", Remind ? "1" : "0");
            iniFile.WriteValue("misc", "tts", TTS ? "1" : "0");
            iniFile.WriteValue("misc", "debug", Debug ? "1" : "0");
            iniFile.WriteValue("misc", "language", Language);
            iniFile.WriteValue("fate", "fates", string.Join(",", FATEs));
            iniFile.WriteValue("internal", "updated", Updated ? "1" : "0");
        }
    }
}
