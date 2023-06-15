using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class scr_PlayerMovement : MonoBehaviour
{
    [SerializeField] private scr_PlayerSettings playerSettings;

    #region General

    private void Update()
    {
        RechargeStyles();

        if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Fist)
        {
            if (playerSettings.moveUp && !playerSettings.movementLocked)
            {
                FistStyle_MoveUp();
            }
            else if (playerSettings.moveDown && !playerSettings.movementLocked)
            {
                FistStyle_MoveDown();
            }
            else if (playerSettings.moveLeft && !playerSettings.movementLocked)
            {
                FistStyle_MoveLeft();
            }
            else if (playerSettings.moveRight && !playerSettings.movementLocked)
            {
                FistStyle_MoveRight();
            }
            else if (!playerSettings.movementLocked)
            {
                FistStyle_MoveNeutral();
            }

            if (playerSettings.primaryTriggered && !playerSettings.primaryTriggeredOnce && !playerSettings.movementLocked)
            {
                FistStyle_Primary();
            }

            if (playerSettings.secondaryTriggered && !playerSettings.secondaryTriggeredOnce && !playerSettings.movementLocked)
            {
                FistStyle_Secondary();
            }
        }
        else if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Sword)
        {
            if (playerSettings.moveUp && !playerSettings.movementLocked)
            {
                SwordStyle_MoveUp();
            }
            else if (playerSettings.moveDown && !playerSettings.movementLocked)
            {
                SwordStyle_MoveDown();
            }
            else if (playerSettings.moveLeft && !playerSettings.movementLocked)
            {
                SwordStyle_MoveLeft();
            }
            else if (playerSettings.moveRight && !playerSettings.movementLocked)
            {
                SwordStyle_MoveRight();
            }
            else if (!playerSettings.movementLocked)
            {
                SwordStyle_MoveNeutral();
            }

            if (playerSettings.primaryTriggered && !playerSettings.primaryTriggeredOnce && !playerSettings.movementLocked)
            {
                SwordStyle_Primary();
            }

            if (playerSettings.secondaryTriggered && !playerSettings.secondaryTriggeredOnce && !playerSettings.movementLocked)
            {
                SwordStyle_Secondary();
            }
        }

        // Sword Charge
        if (playerSettings.chargeMultiplier <= 3f && playerSettings.charge)
        {
            playerSettings.chargeMultiplier += .01f;
        }
        if (playerSettings.charge == false)
        {
            playerSettings.chargeMultiplier = 0;
        }

        // Sword Parry
        if (playerSettings.currentParryTimer <= playerSettings.maximumParryTimer && playerSettings.parry)
        {
            playerSettings.currentParryTimer += .01f;
        }
        else
        {
            playerSettings.parry = false;
            playerSettings.currentParryTimer = 0;
        }

        // Left and Right Trigger
        if (playerSettings.primaryTriggered == false)
        {
            playerSettings.primaryTriggeredOnce = false;
        }
        else if (playerSettings.primaryTriggered == true)
        {
            playerSettings.primaryTriggeredOnce = true;
        }
        if (playerSettings.secondaryTriggered == false)
        {
            playerSettings.secondaryTriggeredOnce = false;
        }
        else if (playerSettings.secondaryTriggered == true)
        {
            playerSettings.secondaryTriggeredOnce = true;
        }

        // Animation Control
        if (playerSettings.selectedStyle == scr_PlayerSettings.Style.Fist && 
            playerSettings.playerAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1
            && (playerSettings.playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(playerSettings.animationName_Roll)
            || playerSettings.playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(playerSettings.animationName_Jump)
            || playerSettings.playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(playerSettings.animationName_DodgeLeft)
            || playerSettings.playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(playerSettings.animationName_DodgeRight)
            || playerSettings.playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(playerSettings.animationName_Punch)
            || playerSettings.playerAnimator.GetCurrentAnimatorStateInfo(0).IsName(playerSettings.animationName_Kick)))

        {
            playerSettings.movementLocked = false;
            FistStyle_MoveNeutral();
        }
    }

    private void RechargeStyles()
    {
        if (playerSettings.fistStyleCurrentStaminaLeeway == 0)
        {
            playerSettings.fistStyleCurrentRechargeTimer -= Time.deltaTime;
        }
        else
        {
            playerSettings.fistStyleCurrentRechargeTimer = playerSettings.fistStyleMaximumRechargeTimer;
        } // Start and end recharge timer

        if (playerSettings.fistStyleCurrentRechargeTimer <= 0f)
        {
            playerSettings.fistStyleCurrentStaminaLeeway = playerSettings.fistStyleMaximumStaminaLeeway;
        } // When recharge timer is full, gain stamina leeway

        if (playerSettings.swordStyleCurrentStaminaLeeway < playerSettings.swordStyleMaximumStaminaLeeway)
        {
            playerSettings.swordStyleCurrentRechargeTimer -= Time.deltaTime;
        }
        else
        {
            playerSettings.swordStyleCurrentRechargeTimer = playerSettings.swordStyleMaximumRechargeTimer;
        } // Start and end recharge timer

        if (playerSettings.swordStyleCurrentRechargeTimer <= 0f)
        {
            playerSettings.swordStyleCurrentStaminaLeeway = playerSettings.swordStyleMaximumStaminaLeeway;
        } // When recharge timer is full, gain stamina leeway
    }

    #endregion

    #region Fist Style

    internal void FistStyle_Select()
    {
        playerSettings.currentPosition = scr_PlayerSettings.Position.Neutral;
        playerSettings.currentStance = scr_PlayerSettings.Stance.None;

        playerSettings.selectedStyle = scr_PlayerSettings.Style.Fist;
    }

    internal void FistStyle_MoveNeutral()
    {
        playerSettings.currentPosition = scr_PlayerSettings.Position.Neutral;
        playerSettings.boxCollider.center = new Vector3(0, 0, 0);
        playerSettings.playerAnimator.Play(playerSettings.animationName_Run);
    }

    internal void FistStyle_MoveUp()
    {
        playerSettings.gameManager.gameSettings.transitionSource.clip = playerSettings.gameManager.jumpRollSoundEffect;
        playerSettings.gameManager.gameSettings.transitionSource.Play();

        playerSettings.movementLocked = true;
        playerSettings.currentPosition = scr_PlayerSettings.Position.Jump;
        playerSettings.boxCollider.center = new Vector3(0, 0.05f, 0);
        playerSettings.playerAnimator.Play(playerSettings.animationName_Jump);
    }

    internal void FistStyle_MoveDown()
    {

        playerSettings.gameManager.gameSettings.transitionSource.clip = playerSettings.gameManager.jumpRollSoundEffect;
        playerSettings.gameManager.gameSettings.transitionSource.Play();

        playerSettings.movementLocked = true;
        playerSettings.currentPosition = scr_PlayerSettings.Position.Roll;
        playerSettings.boxCollider.center = new Vector3(0, -0.05f, 0);
        playerSettings.playerAnimator.Play(playerSettings.animationName_Roll);
    }
    internal void FistStyle_MoveLeft()
    {
        playerSettings.gameManager.gameSettings.transitionSource.clip = playerSettings.gameManager.jumpRollSoundEffect;
        playerSettings.gameManager.gameSettings.transitionSource.Play();

        playerSettings.movementLocked = true;
        playerSettings.currentPosition = scr_PlayerSettings.Position.Left;
        playerSettings.playerAnimator.Play(playerSettings.animationName_DodgeLeft);
    }

    internal void FistStyle_MoveRight()
    {
        playerSettings.gameManager.gameSettings.transitionSource.clip = playerSettings.gameManager.jumpRollSoundEffect;
        playerSettings.gameManager.gameSettings.transitionSource.Play();

        playerSettings.movementLocked = true;
        playerSettings.currentPosition = scr_PlayerSettings.Position.Right;

        playerSettings.playerAnimator.Play(playerSettings.animationName_DodgeRight);
    }

    internal void FistStyle_Primary()
    {
        if (playerSettings.fistStyleCurrentStaminaLeeway != 0)
        {
            playerSettings.fistStyleCurrentStaminaLeeway -= 1;
        }
        else
        {
            playerSettings.currentStamina -= playerSettings.fistStyleStaminaUsage;
        }

        playerSettings.movementLocked = true;
        playerSettings.playerAnimator.Play(playerSettings.animationName_Punch);
        Instantiate(playerSettings.punchParticle, playerSettings.punchParticleSpawnLocation, Quaternion.Euler(-4.5f, 0, 0));
        // Punch
    }

    internal void FistStyle_Secondary()
    {
        if (playerSettings.fistStyleCurrentStaminaLeeway != 0)
        {
            playerSettings.fistStyleCurrentStaminaLeeway -= 1;
        }
        else
        {
            playerSettings.currentStamina -= playerSettings.fistStyleStaminaUsage;
        }

        playerSettings.movementLocked = true;
        playerSettings.playerAnimator.Play(playerSettings.animationName_Kick);
        Instantiate(playerSettings.kickParticle, playerSettings.kickParticleSpawnLocation, Quaternion.Euler(-4.5f, 0, 0));
        // Kick
    }

    #endregion

    #region Sword Style

    internal void SwordStyle_Select()
    {
        playerSettings.currentPosition = scr_PlayerSettings.Position.None;
        playerSettings.currentStance = scr_PlayerSettings.Stance.Neutral;

        playerSettings.selectedStyle = scr_PlayerSettings.Style.Sword;
    }

    internal void SwordStyle_MoveNeutral()
    {
        playerSettings.currentStance = scr_PlayerSettings.Stance.Neutral;
    }

    internal void SwordStyle_MoveUp()
    {
        playerSettings.currentStance = scr_PlayerSettings.Stance.Up;
    }
    internal void SwordStyle_MoveDown()
    {
        playerSettings.currentStance = scr_PlayerSettings.Stance.Down;
    }
    internal void SwordStyle_MoveLeft()
    {
        playerSettings.currentStance = scr_PlayerSettings.Stance.Left;
    }

    internal void SwordStyle_MoveRight()
    {
        playerSettings.currentStance = scr_PlayerSettings.Stance.Right;
    }

    internal void SwordStyle_Primary()
    {
        playerSettings.primaryTriggered = false;

        if (playerSettings.swordStyleCurrentStaminaLeeway != 0)
        {
            playerSettings.swordStyleCurrentStaminaLeeway -= 1;
        }
        else
        {
            playerSettings.currentStamina -= playerSettings.swordStyleStaminaUsage;
        }

        // Slash
    }

    internal void SwordStyle_Secondary()
    {
        Debug.Log("Sword Secondary");


    }

    #endregion
}