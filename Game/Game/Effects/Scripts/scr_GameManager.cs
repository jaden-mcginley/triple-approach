using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.VFX;
using static Unity.VisualScripting.Member;

public class scr_GameManager : MonoBehaviour
{
    internal enum GameState { Title, Options, GameOn, Pause, GameOver };
    internal GameState currentGameState;

    [Header("Reference Scripts")]
    [SerializeField] internal scr_PlayerSettings playerSettings;
    [SerializeField] internal scr_GameSettings gameSettings;
    [SerializeField] internal VisualEffect speedLines;

    [Space]

    [Header("Not Reference Scripts")]
    [SerializeField] internal Gradient healthyLines;
    [SerializeField] internal Gradient hurtLines;

    [Space]

    [SerializeField] internal AudioClip fistStyleTrack;
    [SerializeField] internal AudioClip swordStyleTrack;

    [Space]

    [SerializeField] internal float cutoffTimeFistStyleTrack = 0f;
    [SerializeField] internal float cutoffTimeSwordStyleTrack = 0f;

    [Space]

    [SerializeField] internal AudioClip fistStyleToSwordStyleTransitionTrack;
    [SerializeField] internal AudioClip swordStyleToFistStyleTransitionTrack;

    [Space]

    [SerializeField] internal AudioClip currentTrack;
    [SerializeField] internal AudioClip transitionTrack;
    [SerializeField] internal AudioClip nextTrack;

    [Space]

    [SerializeField] internal bool waitingToTransition;
    [SerializeField] internal bool canTransition;
    [SerializeField] internal float playingAudioLength;
    [SerializeField] internal float currentFourBeatTimer;
    [SerializeField] internal float maximumFourBeatTimer = 1.74f;

    [SerializeField] internal AudioClip jumpRollSoundEffect;
    [SerializeField] internal AudioClip healSoundEffect;
    [SerializeField] internal AudioClip damageSoundEffect;
    [SerializeField] internal AudioClip gameEndSoundEffect;
    [SerializeField] internal AudioClip gameStartSoundEffect;

    [Space]

    [SerializeField] internal GameObject leftScreenWipePanel;
    [SerializeField] internal GameObject rightScreenWipePanel;

    internal string[] nearMissFlair = { "close one!", "radical!", "super cool!", "oh yeah!", "boo-yah!" };
    internal string animationName_NearMiss = "anim_NearMiss";

    internal float savedTime;
    public int score;

    [Space]

    [SerializeField] internal TMP_Text scoreText;
    [SerializeField] internal TMP_Text nearMissText;

    private void Start()
    {
        currentGameState = GameState.Title;

        gameSettings = GameObject.FindGameObjectWithTag("GameSettings").GetComponent<scr_GameSettings>();
        gameSettings.gameOver = false;

        gameSettings.optionsMenu = GameObject.FindGameObjectWithTag("OptionsMenu");
        gameSettings.optionsMenu.SetActive(false);

        leftScreenWipePanel.GetComponent<Animator>().Play("anim_WipeScreenLeftSide");
        rightScreenWipePanel.GetComponent<Animator>().Play("anim_WipeScreenRightSide");

        gameSettings.musicSource.clip = gameStartSoundEffect;
        gameSettings.musicSource.pitch = 1f;
        gameSettings.musicSource.Play();

        StartCoroutine(WaitFor_EndOfStartCountdown(gameStartSoundEffect.length - 1.25f));
        InvokeRepeating("UpdateScore", 0f, .5f);
    }

    private void Update()
    {
        if (gameSettings.gameOver)
        {
        } // If it is game over, stop most things and transition to a game over state.
        else
        {
            CheckGameStatus();
            Audio();
            UpdateSpeedParticles();
        }
    }

    private void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    private void CheckGameStatus()
    {
        if (playerSettings.currentStamina <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        playerSettings.gameManager.gameSettings.transitionSource.clip = playerSettings.gameManager.gameEndSoundEffect;
        playerSettings.gameManager.gameSettings.transitionSource.Play();

        CancelInvoke("UpdateScore");
        Destroy(GameObject.FindGameObjectWithTag("DeleteAfterGameOver"));

        gameSettings.optionsMenu.SetActive(true);
        gameSettings.musicSource.pitch = .8f;

        gameSettings.gameOver = true;
    }

    private void Audio()
    {
        currentFourBeatTimer += Time.deltaTime;
        playingAudioLength += Time.deltaTime;

        if (playingAudioLength >= currentTrack.length)
        {
            playingAudioLength = 0;
        }

        if (currentTrack == fistStyleTrack)
        {
            transitionTrack = fistStyleToSwordStyleTransitionTrack;
            nextTrack = swordStyleTrack;
        }
        else if (currentTrack == swordStyleTrack)
        {
            transitionTrack = swordStyleToFistStyleTransitionTrack;
            nextTrack = fistStyleTrack;
        }

        if (currentFourBeatTimer >= maximumFourBeatTimer)
        {
            currentFourBeatTimer = 0;
            if (waitingToTransition)
            {
                TransitionAudioTrack();
            }
        }

        if (gameSettings.transitionSource.clip == fistStyleToSwordStyleTransitionTrack)
        {
            if (gameSettings.transitionSource.time >= transitionTrack.length - cutoffTimeFistStyleTrack && canTransition)
            {
                canTransition = false;
                savedTime = gameSettings.musicSource.time;
                gameSettings.musicSource.clip = nextTrack;
                gameSettings.musicSource.time = savedTime;
                savedTime = 0f;
                gameSettings.musicSource.Play();
                playingAudioLength = 0;

                currentTrack = nextTrack;
            }
        }
        else if (gameSettings.transitionSource.clip == swordStyleToFistStyleTransitionTrack)
        {
            if (gameSettings.transitionSource.time >= transitionTrack.length - cutoffTimeSwordStyleTrack && canTransition)
            {
                canTransition = false;
                savedTime = gameSettings.musicSource.time;
                gameSettings.musicSource.clip = nextTrack;
                gameSettings.musicSource.time = savedTime;
                savedTime = 0f;
                gameSettings.musicSource.Play();
                playingAudioLength = 0;

                currentTrack = nextTrack;
            }
        }
        else
        {
            // Do nothing
        }
    }

    private void TransitionAudioTrack()
    {
        waitingToTransition = false;
        gameSettings.transitionSource.clip = transitionTrack;
        gameSettings.transitionSource.Play();
        canTransition = true;
    }

    internal void WaitToTransition()
    {
        waitingToTransition = true;
    }

    private void UpdateSpeedParticles()
    {
        if (playerSettings.currentStamina == 1)
        {
            speedLines.SetGradient("colorGradient", hurtLines);
        }
        else if (playerSettings.currentStamina == 2)
        {
            speedLines.SetGradient("colorGradient", healthyLines);
        }

        speedLines.SetFloat("spawnRate", 50 + score/10);
    }

    internal void NearMissFlair()
    {
        int randomPick = Random.Range(0, 5);
        nearMissText.text = nearMissFlair[randomPick];

        nearMissText.gameObject.GetComponent<Animator>().Play(animationName_NearMiss);
    }

    private IEnumerator WaitFor_EndOfStartCountdown(float Seconds)
    {
        yield return new WaitForSeconds(Seconds);

        gameSettings.musicSource.clip = fistStyleTrack;
        gameSettings.musicSource.Play();
    }

    public void Button_TryAgain()
    {
        SceneManager.LoadScene("sce_EndlessRunner");
    }

    public void Button_GoToMainMenu()
    {
        gameSettings.musicSource.clip = swordStyleTrack;
        gameSettings.musicSource.pitch = 1f;
        gameSettings.musicSource.Play();

        SceneManager.LoadScene("sce_MainMenu");
    }
}
