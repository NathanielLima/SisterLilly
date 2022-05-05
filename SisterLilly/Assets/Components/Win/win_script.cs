using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win_script : MonoBehaviour
{
    [SerializeField] GameObject[] levels = new GameObject[10];
    [SerializeField] GameObject[] stars = new GameObject[3];
    [SerializeField] GameObject next = null;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.FindGameObjectWithTag("LevelInterface"));
        levels[game_manager_script.Instance.currentLevel].SetActive(true);
        for (int i = 0; i < GameObject.FindObjectOfType<score_script>().score; i++)
        {
            stars[i].SetActive(true);
        }
        if (game_manager_script.Instance.currentLevel == 9)
        {
            next.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
