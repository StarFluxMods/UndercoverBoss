using System.IO;
using Kitchen;
using KitchenLib;
using UnityEngine;

namespace KitchenSystems
{
    public class AddApplianceToHQ : FranchiseFirstFrameSystem
    {
        protected override void OnUpdate()
        {
            if (PreferencesRegistry.Get<UndercoverBoss.UndercoverBossPreference>("undercoverboss:undercoverbosspreference").isEnabled)
                base.Create(UndercoverBoss.Mod.UndercoverDressingRoom.Appliance, new Vector3(-5f, 0f, -4f), Vector3.down);
        }
    }
}