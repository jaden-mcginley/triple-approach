using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class scr_PlayerInput : MonoBehaviour
{
    [SerializeField] private scr_PlayerSettings playerSettings;

    private void Awake()
    {
        playerSettings.defaultInput = new scr_DefaultInput();

        InitializeMovement();
        //InitializeSelect();

        //InitializePrimary();
        //InitializeSecondary();

        playerSettings.defaultInput.Enable();
    }

    private void InitializeMovement()
    {
        playerSettings.defaultInput.PlayerBasics.MovementUp.performed +=
            context =>
            {
                playerSettings.moveUp = true;
            };
        
        playerSettings.defaultInput.PlayerBasics.MovementUp.canceled +=
            context =>
            {
                playerSettings.moveUp = false;
            };

        playerSettings.defaultInput.PlayerBasics.MovementDown.performed +=
            context =>
            {
                playerSettings.moveDown = true;
            };

        playerSettings.defaultInput.PlayerBasics.MovementDown.canceled +=
            context =>
            {
                playerSettings.moveDown = false;
            };

        playerSettings.defaultInput.PlayerBasics.MovementLeft.performed +=
            context =>
            {
                playerSettings.moveLeft = true;
            };

        playerSettings.defaultInput.PlayerBasics.MovementLeft.canceled +=
            context =>
            {
                playerSettings.moveLeft = false;
            };

        playerSettings.defaultInput.PlayerBasics.MovementRight.performed +=
            context =>
            {
                playerSettings.moveRight = true;
            };

        playerSettings.defaultInput.PlayerBasics.MovementRight.canceled +=
            context =>
            {
                playerSettings.moveRight = false;
            };
    }

/*    private void InitializeSelect()
    {
        playerSettings.defaultInput.PlayerBasics.SelectFistStyle.performed +=
            context =>
            {
                if (playerSettings.selectedStyle != scr_PlayerSettings.Style.Fist)
                {
                    playerSettings.gameManager.WaitToTransition();
                    playerSettings.playerMovement.FistStyle_Select();
                }
            };

        playerSettings.defaultInput.PlayerBasics.SelectSwordStyle.performed +=
            context =>
            {
                if (playerSettings.selectedStyle != scr_PlayerSettings.Style.Sword)
                {
                    playerSettings.gameManager.WaitToTransition();
                    playerSettings.playerMovement.SwordStyle_Select();
                }
            };
    }*/

/*    private void InitializePrimary()
    {
        playerSettings.defaultInput.PlayerBasics.Primary.performed +=
            context =>
            {
                if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Sword)
                {
                    playerSettings.charge = true;
                }
                else if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Fist)
                {
                    playerSettings.primaryTriggered = true;
                }
            };

        playerSettings.defaultInput.PlayerBasics.Primary.canceled +=
            context =>
            {
                if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Sword)
                {
                    playerSettings.primaryTriggered = true;
                    playerSettings.charge = false;
                }
                else if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Fist)
                {
                    playerSettings.primaryTriggered = false;
                }
            };
    }
    private void InitializeSecondary()
    {
        playerSettings.defaultInput.PlayerBasics.Secondary.performed +=
            context =>
            {
                playerSettings.secondaryTriggered = true;

                if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Sword)
                {
                    playerSettings.parry = true;
                }
            };

        playerSettings.defaultInput.PlayerBasics.Secondary.canceled +=
            context =>
            {
                playerSettings.secondaryTriggered = false;

                if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Sword)
                {
                    playerSettings.parry = false;
                }
            };
    }*/
}