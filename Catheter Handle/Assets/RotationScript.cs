using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]

public class RotationScript : MonoBehaviour
{
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	SerialPort stream = new SerialPort("/dev/cu.usbmodem1411", 9600);

	Button button;
	Image image;

	public ButtonType buttonType;

	void Start()
	{
		Debug.Log("Hello World");
		stream.Open(); //Open the Serial Stream.
		// Get a list of serial port names.
		Debug.Log(SerialPort.GetPortNames());
		Debug.Log("The following serial ports were found:");
		// Display each port name to the console.
		foreach(string port in SerialPort.GetPortNames())
		{
			Debug.Log("___"+port);
		}

	}
	void OnGUI()
	{
		GUI.Box(new Rect(0, 0, 50, 50), "This is a box");
	}

	protected override void OnSkinUI()
	{

		base.OnSkinUI();
		image = GetComponent<Image>();
		button = GetComponent<Button>();

		button.transition = Selectable.Transition.SpriteSwap;
		button.targetGraphic = image;

		image.sprite = skinData.buttonSprite;
		image.type = Image.Type.Sliced;
		button.spriteState = skinData.buttonSpriteState;
	}

	void Update ()
	{
//		string value = stream.ReadLine(); //Read the information
//		print(value);
//
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