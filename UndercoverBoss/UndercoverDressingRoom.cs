using Kitchen;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;
using HarmonyLib;
using Unity.Entities;
using KitchenData;

namespace UndercoverBoss
{
    public class UndercoverDressingRoom : CustomAppliance
    {
        public override int BaseApplianceId { get { return -1357906425; } }

        public override bool PreInteract(InteractionData data, bool isSecondary = false)
        {
            int Janitor = 4;
            CPlayerColour col = new CPlayerColour();
            CPlayerCosmetics cos = new CPlayerCosmetics();

            col.Color = new Color(0.8679245f, 0.6130017f, 0.3389818f, 0);
            cos.OutfitID = (PlayerOutfit)Janitor;

			data.Context.Set<CPlayerColour>(data.Interactor, col);
            data.Context.Set<CPlayerCosmetics>(data.Interactor, cos);
            
            return true;
        }

        public override bool ForceIsInteractionPossible()
        {
            return true;
        }

        public override bool IsInteractionPossible(InteractionData data)
        {
            return true;
        }

        public override string Name { get { return "Undercover Dressing Room"; } }

        public override GameObject Prefab { get {return (GameObject)Mod.UndercoverDressingRoomBundle.LoadAsset("Dressing Room"); } }

        public override void OnRegister(Appliance appliance)
        {
            MaterialUtils.ApplyMaterial(appliance.Prefab, "Dressing_Room/Body", new Material[]{ MaterialUtils.GetExistingMaterial("Wood - Default") });   
            MaterialUtils.ApplyMaterial(appliance.Prefab, "Dressing_Room/Doors", new Material[]{ MaterialUtils.GetExistingMaterial("Wood - Default") });   
            MaterialUtils.ApplyMaterial(appliance.Prefab, "Dressing_Room/Knobs", new Material[]{ MaterialUtils.GetExistingMaterial("Knob") });   
            MaterialUtils.ApplyMaterial(appliance.Prefab, "Dressing_Room/Shirts", new Material[]{ MaterialUtils.GetExistingMaterial("Plastic - Black") });   
        }
    }

}