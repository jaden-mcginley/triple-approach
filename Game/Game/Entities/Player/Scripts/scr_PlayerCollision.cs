using System.Collections;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;

public class scr_PlayerCollision : MonoBehaviour
{
    [SerializeField] private scr_PlayerSettings playerSettings;

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerSettings.parry)
        {
            UnityEngine.Debug.Log("Parry!");
            playerSettings.currentStamina += 1;
        }
        else
        {
            playerSettings.gameManager.gameSettings.effectsSource.clip = playerSettings.gameManager.damageSoundEffect;
            playerSettings.gameManager.gameSettings.effectsSource.Play();
            playerSettings.playerWasHit = true;
            playerSettings.currentStamina -= 1;

            StartCoroutine(WaitForHitExitTime(1f));
        }
    }

    private IEnumerator WaitForHitExitTime(float seconds)
    {
        playerSettings.spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(seconds);

        playerSettings.spriteRenderer.color = Color.white;
        playerSettings.playerWasHit = false;
    }
}
