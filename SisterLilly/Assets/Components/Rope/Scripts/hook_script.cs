using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hook_script : MonoBehaviour
{
    [SerializeField] GameObject link = null;
    [SerializeField] Transform parent = null;
    List<GameObject> rope = new List<GameObject>();
    HingeJoint2D hj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateRope()
    {
        GameObject candy = GameObject.FindGameObjectWithTag("Candy");
        Vector3 tmpVector = candy.transform.position - transform.position;
        float tmpAngle = Vector3.Angle(Vector3.up, tmpVector);
        int tmpCount = Mathf.FloorToInt(tmpVector.magnitude * 2.0f);
        if (Vector3.up.x * tmpVector.y - Vector3.up.y * tmpVector.x < 0.0f)
        {
            tmpAngle *= -1.0f;
        }
        for (int i = 0; i < tmpCount; i++)
        {
            GameObject tmpLink = Instantiate(link, parent);
            tmpLink.GetComponent<link_script>().hook = gameObject;
            tmpLink.transform.position += (i * 0.5f + 0.25f) * Vector3.down;
            tmpLink.transform.RotateAround(transform.position, Vector3.forward, 180.0f + tmpAngle);
            if (i != 0)
            {
                tmpLink.GetComponent<HingeJoint2D>().connectedBody = rope[i - 1].GetComponent<Rigidbody2D>();
            }
            else
            {
                tmpLink.GetComponent<HingeJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
            }
            rope.Add(tmpLink);
        }
        hj = candy.AddComponent<HingeJoint2D>();
        hj.connectedBody = rope[rope.Count - 1].GetComponent<Rigidbody2D>();
    }

    public void DestroyRope()
    {
        Destroy(hj);
        for (int i = 0; i < rope.Count; i++)
        {
            Destroy(rope[i]);
        }
        rope.Clear();
    }
}
