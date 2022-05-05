using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title_screen_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("level_selector");
    }

    public void Settings()
    {
        SceneManager.LoadScene("settings");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
