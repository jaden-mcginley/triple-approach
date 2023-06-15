using System.Diagnostics;
using UnityEngine;

public class scr_PlayerOtherCollision : MonoBehaviour
{
    [SerializeField] internal scr_PlayerSettings playerSettings;

    private void OnTriggerEnter(Collider other)
    {
        if (!playerSettings.playerWasHit && other.tag != "CantNearMiss")
        {
            if (playerSettings.currentStamina != playerSettings.maximumStamina)
            {
                playerSettings.currentStamina += 1;
            }

            playerSettings.gameManager.score += 100;
            playerSettings.gameManager.NearMissFlair();

            playerSettings.gameManager.gameSettings.effectsSource.clip = playerSettings.gameManager.healSoundEffect;
            playerSettings.gameManager.gameSettings.effectsSource.Play();
        }
    }
}
