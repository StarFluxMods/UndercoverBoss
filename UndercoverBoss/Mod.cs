using KitchenLib;
using KitchenLib.Customs;
using UnityEngine;
using System.IO;
using Kitchen;

namespace UndercoverBoss
{
    public class Mod : BaseMod
    {
        public Mod() : base("undercoverboss", ">=1.0.0 <=1.0.5") {}

        public static CustomAppliance UndercoverDressingRoom;
        public static AssetBundle UndercoverDressingRoomBundle;

        public override void OnInitializeMelon()
        {
            UndercoverBossPreference preference = PreferencesRegistry.Register<UndercoverBossPreference>("undercoverboss:undercoverbosspreference");
            preference.isEnabled = true;

            PreferencesRegistry.WriteToFile("settings.settings");
            UndercoverDressingRoomBundle = AssetBundle.LoadFromFile(Application.streamingAssetsPath + "/undercoverboss");
            UndercoverDressingRoom = AddAppliance<UndercoverDressingRoom>();
        }
    }

    public class UndercoverBossPreference : ModPreference
    {
        public UndercoverBossPreference():base(){}
        public bool isEnabled;
        public override void Serialize(BinaryWriter writer)
        {
            writer.Write(isEnabled);
        }

        public override void Deserialize(BinaryReader reader)
        {
            isEnabled = reader.ReadBoolean();
        }
    }
}
