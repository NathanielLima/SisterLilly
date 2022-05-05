using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class settings_script : MonoBehaviour
{
    [SerializeField] Slider[] sliders = new Slider[3];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cancel()
    {
        SceneManager.LoadScene("title_screen");
    }

    public void Update_Main_Volume()
    {
        game_manager_script.Instance.MainVolume = sliders[0].value;
        game_manager_script.Instance.Save();
    }

    public void Update_Music_Volume()
    {
        game_manager_script.Instance.MusicVolume = sliders[1].value;
        game_manager_script.Instance.Save();
    }

    public void Update_Sounds_Volume()
    {
        game_manager_script.Instance.SoundsVolume = sliders[2].value;
        game_manager_script.Instance.Save();
    }
}
