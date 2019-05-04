using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// cursor area 
public class MoveCaliper2 : MonoBehaviour {
	public bool toggle;
	public KeyCode key;
	private Button button;


	void Start() {
		toggle = true;
	}
	void Awake() {
		button = GetComponent<Button>();

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			Vector3 position = this.transform.position;
			position.x--;
			this.transform.position = position;
			Debug.Log (this.transform.position);
		}
		if (Input.GetKey(KeyCode.D))
		{
			Vector3 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}

//		if (Input.GetKeyDown(key)) {
//			toggle = !toggle;
//			if (toggle) 
//			{
//				button.interactable = false;
//			}
//			else 
//			{
//				button.interactable = true;
//			}
//		}
	}
}
