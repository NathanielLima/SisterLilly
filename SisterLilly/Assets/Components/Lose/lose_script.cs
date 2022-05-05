using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.FindGameObjectWithTag("LevelInterface"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
