using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]

public class RotationScript : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;

    int x = 0;
    int y = 0;

	Button button;
	Image image;

	void Start()
	{

	}

	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 50, 50), "This is a box");
	}

	void Update ()
	{
        // TODO: do something with x and y

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Rotate (Vector3.left * -Time.deltaTime * turnSpeed, Space.World);
			y += 1;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Rotate (Vector3.left * Time.deltaTime * turnSpeed, Space.World);
			y -= 1;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.back * -Time.deltaTime * turnSpeed, Space.World);
			x -= 1;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.back * Time.deltaTime * turnSpeed, Space.World);
			x += 1;
		}

        // wait for additional inputs
//        x = 0;
//        y = 0;
	}

    void OnSerialLine(string line)
    {
        // TODO: write the appropriate values into x and y
		Debug.Log("Got a line: " + line + " " + x + " " + y);
    }

	Vector3 rotatePointAroundAxis(Vector3 point, float angle, Vector3 axis)
	{
		Quaternion q = Quaternion.AngleAxis(angle, axis);
		return q * point; //Note: q must be first (point * q wouldn't compile)
	}
}