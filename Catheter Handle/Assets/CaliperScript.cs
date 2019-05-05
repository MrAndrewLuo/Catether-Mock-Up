using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaliperScript : MonoBehaviour
{
    Transform leftMarker, rightMarker;
    bool isLeft;

    // Start is called before the first frame update
    void Start()
    {
        leftMarker = this.transform.Find("CursorLeft");
        rightMarker = this.transform.Find("CursorRight");
        isLeft = true;
    }

    // Update is called once per frame
    void Update()
    {
        Transform current;
        if (isLeft)
        {
            current = leftMarker;
        }
        else
        {
            current = rightMarker;
        }

        if (Input.GetKey(KeyCode.A))
        {
            current.localPosition += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            current.localPosition += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            isLeft = !isLeft;
        }

        double distance = rightMarker.localPosition.x - leftMarker.localPosition.x;
        Debug.Log("Current distance: " + distance);
    }
}
