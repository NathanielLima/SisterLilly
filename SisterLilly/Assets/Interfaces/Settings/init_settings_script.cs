using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class init_settings_script : MonoBehaviour
{
    [SerializeField] Slider[] sliders = new Slider[3];

    // Start is called before the first frame update
    void Start()
    {
        sliders[0].value = game_manager_script.Instance.MainVolume;
        sliders[1].value = game_manager_script.Instance.MusicVolume;
        sliders[2].value = game_manager_script.Instance.SoundsVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
