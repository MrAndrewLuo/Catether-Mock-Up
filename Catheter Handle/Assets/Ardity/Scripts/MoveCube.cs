using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {
	
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

	}
}
