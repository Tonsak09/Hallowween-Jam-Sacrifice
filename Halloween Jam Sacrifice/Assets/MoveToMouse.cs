using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    Rigidbody2D rb;
    Limb limb;

    public float force;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        limb = this.GetComponent<Limb>();
    }

    // Update is called once per frame
    void Update()
    {

        print(limb);
        if(Input.GetMouseButton(0) && limb.selected)
        {
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 dir = worldPosition - (Vector2)this.transform.position;

            dir = dir.normalized;

            rb.AddForce(dir * force);
        }
    }
}
