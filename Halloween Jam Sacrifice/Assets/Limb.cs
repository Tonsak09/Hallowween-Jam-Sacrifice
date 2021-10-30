using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limb : MonoBehaviour
{
    public GameObject parentObj;
    public bool selected = false;

    public KeyCode splitKey = KeyCode.Space;

    // Update is called once per frame
    void Update()
    {
        Split(); // todo find a way to reform 

        ColorWhenSelected();
    }

    private void ColorWhenSelected()
    {
        if (selected)
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    void Split()
    {
        if(selected && Input.GetKey(splitKey) && parentObj != null)
        {
            parentObj.GetComponent<SpringJoint2D>().enabled = false;
        }
    }
}
