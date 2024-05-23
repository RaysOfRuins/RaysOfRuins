using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public static SettingsMenu instance;

    [Header("Sliders: ")]
    [SerializeField] Slider _mainVolumeSlider;
    [SerializeField] Slider _musicVolumeSlider;
    [SerializeField] Slider _sfxVolumeSlider;

    [Header("References: ")]
    public GameObject backButton;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            transform.parent.GetComponent<Canvas>().sortingOrder = 50;
            transform.parent.GetComponent<Canvas>().worldCamera = Camera.main;

            gameObject.SetActive(false);
        }
        else
        {
            Destroy(transform.parent.parent.gameObject);
        }
        //Keeps the settings and sound managers from being destroyed on scene change
        DontDestroyOnLoad(transform.parent.parent);

        //Links volume sliders to their respective functions
        _mainVolumeSlider.onValueChanged.AddListener(delegate { OnMainVolumeChange(); });
        _musicVolumeSlider.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });
        _sfxVolumeSlider.onValueChanged.AddListener(delegate { OnSFXVolumeChange(); });

    }
    
    public void ToggleMusic()
    {
        SoundManager.instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        SoundManager.instance.ToggleSFX();
    }

    public void OnMainVolumeChange()
    {
        SoundManager.instance.MainVolume(_mainVolumeSlider.value);
    }

    public void OnMusicVolumeChange()
    {
        SoundManager.instance.MusicVolume(_musicVolumeSlider.value);
    }

    public void OnSFXVolumeChange()
    {
        SoundManager.instance.SFXVolume(_sfxVolumeSlider.value);
    }
}
