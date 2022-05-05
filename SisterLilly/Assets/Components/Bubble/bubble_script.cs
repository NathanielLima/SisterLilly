using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble_script : MonoBehaviour
{
    Rigidbody2D rb;
    float radius;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer tmpSr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        radius = tmpSr.sprite.texture.width / (2.0f * tmpSr.sprite.pixelsPerUnit);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (transform.childCount != 0)
        {
            if (transform.GetChild(0).gameObject.activeInHierarchy)
            {
                if (Input.GetMouseButton(0))
                {
                    Vector3 tmpMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    float tmpDist = Mathf.Sqrt(Mathf.Pow(tmpMouse.x - transform.position.x, 2.0f) + Mathf.Pow(tmpMouse.y - transform.position.y, 2.0f));
                    if (tmpDist <= radius)
                    {
                        transform.GetChild(0).SetParent(null);
                        gameObject.SetActive(false);
                    }
                }
            }
            else
            {
                transform.GetChild(0).SetParent(null);
                gameObject.SetActive(false);
            }
        }*/
        if (gameObject.GetComponent<HingeJoint2D>() != null && Input.GetMouseButton(0))
        {
            Vector3 tmpMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float tmpDist = Mathf.Sqrt(Mathf.Pow(tmpMouse.x - transform.position.x, 2.0f) + Mathf.Pow(tmpMouse.y - transform.position.y, 2.0f));
            if (tmpDist <= radius)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Candy"))
        {
            HingeJoint2D hj = gameObject.AddComponent<HingeJoint2D>();
            rb.velocity = Vector2.up * 2.5f;
            hj.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }
}
