using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Instantiate (GameObject.Find ("Score"), new Vector3(0.0f, 0.0f, 1.0f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<Image> ().enabled == true && Input.anyKeyDown) {
			GetComponent<Image> ().enabled = false;
			Application.LoadLevel (Application.loadedLevel);
			Time.timeScale = 1.0f;
			//GameObject.Find ("Score")
		}
	}
}
