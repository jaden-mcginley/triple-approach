using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_AudioManager : MonoBehaviour
{
    #region - General Variables -

    [Header("- General -")]
    [Header("Reference Scripts")]
    [SerializeField] scr_GameManager gameManager;

    #endregion

    #region - Music Variables -

    [Header("- Music -")]
    [Header("Music Tracks")]
    [SerializeField] internal AudioClip music_Track_Fist; // 2.37 BPS
    [SerializeField] internal AudioClip music_Track_Sword; // 2.37 BPS

    [Space]

    [Header("Music Transitions")]
    [SerializeField] internal AudioClip music_Transition_FistToSword;
    [SerializeField] internal AudioClip music_Transition_SwordToFist;

    [Header("Music Variables")]

    [SerializeField] internal float currentFourBeatTimer = 1.88f;
    [SerializeField] internal float maximumFourBeatTimer = 1.88f;

    [Space]

    [SerializeField] internal bool currentTrackWaitingToTransition;

    #endregion

    #region - Effects Variables -

    [Header("- Effects -")]
    [Header("Player Effects")]
    [SerializeField] internal AudioClip effect_PlayerDodgeSound;
    [SerializeField] internal AudioClip effect_PlayerJumpSound;
    [SerializeField] internal AudioClip effect_PlayerRollSound;

    [Space]

    [SerializeField] internal AudioClip effect_PlayerHealSound;
    [SerializeField] internal AudioClip effect_PlayerDamageSound;

    #endregion

    #region - Utility Functions -

    public void PlayAudioFromSource(AudioSource audioSource, AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    public void PlayAudioFromSource(AudioSource audioSource, AudioClip audioClip, float playAfterTime)
    {
        StartCoroutine(Wait_PlayerAudioFromSource(audioSource, audioClip, playAfterTime));
    }

    private IEnumerator Wait_PlayerAudioFromSource(AudioSource audioSource, AudioClip audioClip, float playAfterTime)
    {
        yield return new WaitForSeconds(playAfterTime);

        audioSource.clip = audioClip;
        audioSource.Play();
    }

    #endregion
}