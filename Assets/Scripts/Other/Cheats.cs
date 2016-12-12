using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour {
    static bool invincibilityActive = false;
    public static void CheatToggle()
    {
        invincibilityActive = !invincibilityActive;

        if (UnitTracker.PlayerShip != null)
            UnitTracker.PlayerShip.GetComponent<Health>().IsInvincible = invincibilityActive;

        if (HUDController.Instance != null)
        {
            if (invincibilityActive)
                HUDController.Instance.DisplayMessage("Invicibility Activated");
            else
                HUDController.Instance.DisplayMessage("Invicibility Deactivated");
        }
    }
}
