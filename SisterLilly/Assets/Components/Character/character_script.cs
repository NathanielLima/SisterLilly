using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_script : MonoBehaviour
{
    [SerializeField] GameObject win = null;
    [SerializeField] int currentLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            int tmpScore = GameObject.FindObjectOfType<score_script>().score;
            if (game_manager_script.Instance.Progression < 9 && game_manager_script.Instance.Progression < currentLevel + 1)
            {
                game_manager_script.Instance.Progression = currentLevel + 1;
            }
            game_manager_script.Instance.currentLevel = currentLevel;
            if (tmpScore > game_manager_script.Instance.Stars[currentLevel])
            {
                game_manager_script.Instance.Stars[currentLevel] = tmpScore;
            }
            game_manager_script.Instance.Save();
            Instantiate(win);
        }
    }
}
