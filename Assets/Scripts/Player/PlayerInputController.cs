using UnityEngine;
using System.Collections;

/// <summary>
/// Gets all user input, excluding input captured by PlayerController, and calls necessary methods.
/// </summary>
public class PlayerInputController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            MenuController.Instance.ToggleMenu();

        if (Input.GetKeyDown(KeyCode.I))
            Cheats.CheatToggle();

        /* Free looking around ship without rotating it. *NOT YET IMPLEMENTED*
        if (Input.GetKeyDown(KeyCode.C))
        {
            CameraController.PlayerCameraControllerInstance.SetFreeLookActive(true);
            PlayerController.Instance.SetMouseControlsEnabled(false);
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            CameraController.PlayerCameraControllerInstance.SetFreeLookActive(true);
            PlayerController.Instance.SetMouseControlsEnabled(true);
        }
        */
    }
}
