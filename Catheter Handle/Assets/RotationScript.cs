using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class RotationScript : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	SerialPort stream = new SerialPort("/dev/cu.applepi0-SerialPort", 9600);

	void Start()
	{
		Debug.Log("Hello World");
		// Get a list of serial port names.
		string[] ports = SerialPort.GetPortNames();

		Debug.Log("The following serial ports were found:");
		// Display each port name to the console.
		foreach(string port in ports)
		{
			Debug.Log(port);
		}
	}
	void Update ()
	{
//		string value = stream.ReadLine(); //Read the information
//		print(value);

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