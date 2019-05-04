using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCaliper : MonoBehaviour {
	private List<Transform> sliders;

	private void Awake() {
		sliders = new List<Transform> ();
		for (int i = 0; i < transform.childCount; i++) {
			var model = transform.GetChild (i);
			sliders.Add (model);

			model.gameObject.SetActive (i == 0);
		}
	}


	public void EnableModel(Transform modelTransform) {
		for (int i = 0; i < transform.childCount; i++) {
			var transformToToggle = transform.GetChild (i);
			bool shouldBeActive = transformToToggle == modelTransform;
			transformToToggle.gameObject.SetActive (shouldBeActive);
		}
	}
	
	public List<Transform> GetSliders() {
		return new List<Transform> (sliders);
	}
}
