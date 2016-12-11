using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Image> ().enabled == true && Input.anyKeyDown) {
			GetComponent<Image> ().enabled = false;
			Application.LoadLevel (Application.loadedLevel);
			Time.timeScale = 1.0f;
		}
	}
}
