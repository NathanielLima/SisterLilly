using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class range_script : MonoBehaviour
{
    [SerializeField] hook_script hook = null;

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
            hook.CreateRope();
            gameObject.SetActive(false);
        }
    }
}
