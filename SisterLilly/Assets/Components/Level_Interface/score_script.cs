using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_script : MonoBehaviour
{
    [SerializeField] GameObject[] stars = new GameObject[3];
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        stars[score].SetActive(true);
        ++score;
    }
}
