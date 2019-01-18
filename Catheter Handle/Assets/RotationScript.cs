using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;

	void Start()
	{
		Debug.Log("Hello World");
	}
	void Update ()
	{
		if(Input.GetKey(KeyCode.UpArrow))
			transform.Rotate(Vector3.left * -Time.deltaTime * turnSpeed, Space.World);

		if(Input.GetKey(KeyCode.DownArrow))
			transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed, Space.World);

		if(Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.back * -Time.deltaTime * turnSpeed, Space.World);

		if(Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.back * Time.deltaTime * turnSpeed, Space.World);
	}

	Vector3 rotatePointAroundAxis(Vector3 point, float angle, Vector3 axis)
	{
		Quaternion q = Quaternion.AngleAxis(angle, axis);
		return q * point; //Note: q must be first (point * q wouldn't compile)
	}
}