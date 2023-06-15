using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scr_GameSettings : MonoBehaviour
{
    [Header("Game Run Settings")]
    [SerializeField] internal AudioSource musicSource;
    [SerializeField] internal AudioSource transitionSource;
    [SerializeField] internal AudioSource effectsSource;

    [Space]

    [SerializeField] internal AudioClip menuMusic;

    [Space]

    [SerializeField] internal float objectScrollSpeed;
    [SerializeField] internal float particleScrollSpeed;

    [Space]

    [SerializeField] internal GameObject optionsMenu;
    [SerializeField] internal bool gameOver = false;

    public float musicVolume = 10;
    public float effectsVolume = 10;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        musicSource = GameObject.FindGameObjectWithTag("MusicSource").GetComponent<AudioSource>();
        transitionSource = GameObject.FindGameObjectWithTag("TransitionSource").GetComponent<AudioSource>();
        effectsSource = GameObject.FindGameObjectWithTag("EffectsSource").GetComponent<AudioSource>();

        optionsMenu = GameObject.FindGameObjectWithTag("OptionsMenu");
        optionsMenu.SetActive(!optionsMenu.activeInHierarchy);

        musicSource.clip = menuMusic;
        musicSource.Play();
    }

    private void Update()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
    }

    public void Button_PlayGame()
    {
        SceneManager.LoadScene("sce_EndlessRunner");
    }

    public void Button_EnableDisableOptions()
    {
        optionsMenu.SetActive(!optionsMenu.activeSelf);
    }

    public void Button_ToMainMenu()
    {
        SceneManager.LoadScene("sce_MainMenu");
    }

    public void MusicScrollbar_Change()
    {
        musicVolume = GameObject.FindGameObjectWithTag("MusicControl").GetComponent<Scrollbar>().value;
        musicSource.volume = musicVolume;
        transitionSource.volume = musicVolume;
    }

    public void EffectsScrollbar_Change()
    {
        effectsVolume = GameObject.FindGameObjectWithTag("EffectsControl").GetComponent<Scrollbar>().value;
        effectsSource.volume = effectsVolume;
    }
}
