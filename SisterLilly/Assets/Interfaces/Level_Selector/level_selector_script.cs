using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_selector_script : MonoBehaviour
{
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

    public void Level_01()
    {
        SceneManager.LoadScene("level_01");
    }

    public void Level_02()
    {
        SceneManager.LoadScene("level_02");
    }

    public void Level_03()
    {
        SceneManager.LoadScene("level_03");
    }

    public void Level_04()
    {
        SceneManager.LoadScene("level_04");
    }

    public void Level_05()
    {
        SceneManager.LoadScene("level_05");
    }

    public void Level_06()
    {
        SceneManager.LoadScene("level_06");
    }

    public void Level_07()
    {
        SceneManager.LoadScene("level_07");
    }

    public void Level_08()
    {
        SceneManager.LoadScene("level_08");
    }

    public void Level_09()
    {
        SceneManager.LoadScene("level_09");
    }

    public void Level_10()
    {
        SceneManager.LoadScene("level_10");
    }
}
