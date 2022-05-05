using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_script : MonoBehaviour
{
    private void Awake()
    {
        transform.position = Vector3.up * 100.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else
        {
            transform.position = Vector3.up * 100.0f;
        }
    }
}
