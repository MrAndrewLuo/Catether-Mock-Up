using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaliperCursor : MonoBehaviour {
	public Slider sliderObj;
	void Start() {
		sliderObj.minValue = 0;
		sliderObj.maxValue = 100;
		sliderObj.value = 50;
	}
	public void OnValueChanged (float value) {
		Debug.Log("New Value " + value);
	}
}
