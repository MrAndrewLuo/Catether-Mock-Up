using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaliperScript : MonoBehaviour
{
    GameObject left, right;

    // Start is called before the first frame update
    void Start()
    {
        left = this.transform.GetChild(0).gameObject;
        right = this.transform.GetChild(1).gameObject;

        left.transform.parent = null;
        right.transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            left.transform.SetParent(transform, false);
            Vector3 position = left.transform.localPosition;
            position.x--;
            //left.transform.localPosition = position;
            Debug.Log(left.transform.localPosition);
        }
        if (Input.GetKey(KeyCode.D))
        {
            left.transform.SetParent(transform, false);
            Vector3 position = left.transform.localPosition;
            position.x++;
            //left.transform.localPosition = position;
            Debug.Log(left.transform.localPosition);
        }
    }
}
