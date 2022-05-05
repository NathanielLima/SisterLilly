using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_manager_script : MonoBehaviour
{
    public static game_manager_script Instance;
    public float MainVolume = 1.0f;
    public float MusicVolume = 1.0f;
    public float SoundsVolume = 1.0f;
    public int Progression = 0;
    public int[] Stars = new int[10];
    public int currentLevel = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = GetComponent<game_manager_script>();
        DontDestroyOnLoad(gameObject);
        Load();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Load()
    {
        MainVolume = PlayerPrefs.GetFloat("MainVolume", 1.0f);
        MusicVolume = PlayerPrefs.GetFloat("MusicVolume", 1.0f);
        SoundsVolume = PlayerPrefs.GetFloat("SoundsVolume", 1.0f);
        Progression = PlayerPrefs.GetInt("Progression", 0);
        for (int i = 0; i < 10; i++)
        {
            Stars[i] = PlayerPrefs.GetInt("Stars_" + (i + 1), 0);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("MainVolume", MainVolume);
        PlayerPrefs.SetFloat("MusicVolume", MusicVolume);
        PlayerPrefs.SetFloat("SoundsVolume", SoundsVolume);
        PlayerPrefs.SetInt("Progression", Progression);
        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetInt("Stars_" + (i + 1), Stars[i]);
        }
        PlayerPrefs.Save();
    }
}
