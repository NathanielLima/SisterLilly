using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_unlocker_script : MonoBehaviour
{
    [SerializeField] GameObject[] toUnlock = new GameObject[9];
    [SerializeField] GameObject[] stars = new GameObject[10 * 3];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < game_manager_script.Instance.Progression; i++)
        {
            toUnlock[i].SetActive(true);
        }

        for (int i = 0; i < game_manager_script.Instance.Stars.Length; i++ )
        {
            for (int j = 0; j < game_manager_script.Instance.Stars[i]; j++)
            {
                stars[3 * i + j].SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
