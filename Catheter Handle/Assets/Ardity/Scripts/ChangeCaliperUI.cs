using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCaliperUI : MonoBehaviour {
	[SerializeField] private ChangeCaliperButton butUI;

	// Use this for initialization
	private void Start () {
		var sliders = FindObjectOfType<ChangeCaliper> ().GetSliders ();
		foreach (var slider in sliders) {
			CreateButtonForModel (slider);
		}
	}
	
	// Update is called once per frame
	private void CreateButtonForModel (Transform slider) {
		var button = Instantiate (butUI);
		button.transform.SetParent (this.transform);
		var controller = FindObjectOfType < ChangeCaliper> ();
		button.Initialize (slider, controller.EnableModel);
	}
}
