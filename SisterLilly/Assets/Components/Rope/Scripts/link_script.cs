using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class link_script : MonoBehaviour
{
    public GameObject hook;
    Vector3 lastMousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(lastMousePos, currentMousePos);
            //if (hit && hit.transform.gameObject.CompareTag("Candy"))
            //if (hit && hit.collider.gameObject.CompareTag("Rope"))
            if (hit && hit.collider.gameObject == gameObject)
            {
                hook.GetComponent<hook_script>().DestroyRope();
            }
            //lastMousePos = currentMousePos;
        }*/
    }

    private void LateUpdate()
    {
        /*if (Input.GetMouseButton(0))
        {
            lastMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mouse"))
        {
            hook.GetComponent<hook_script>().DestroyRope();
        }
    }
}
