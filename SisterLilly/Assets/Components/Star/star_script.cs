using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star_script : MonoBehaviour
{
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
            GameObject.FindObjectOfType<score_script>().AddScore();
            gameObject.SetActive(false);
        }
    }
}
