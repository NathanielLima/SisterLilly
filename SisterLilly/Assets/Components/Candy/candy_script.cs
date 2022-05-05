using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candy_script : MonoBehaviour
{
    [SerializeField] GameObject lose = null;
    Rigidbody2D rb;
    bool endLevel = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent != null)
        {
            transform.localPosition = Vector3.zero;
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            gameObject.SetActive(false);
            Instantiate(lose);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bubble"))
        {
            //transform.SetParent(collision.gameObject.transform);
            transform.position = collision.gameObject.transform.position;
        }
        if (collision.gameObject.CompareTag("Character"))
        {
            endLevel = true;
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!endLevel && collision.gameObject.CompareTag("Manager"))
        {
            Instantiate(lose);
        }
    }
}
