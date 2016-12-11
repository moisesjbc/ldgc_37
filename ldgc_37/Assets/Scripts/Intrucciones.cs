using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Intrucciones : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			GameObject.Find ("Instrucciones").GetComponent<Image>().enabled = false;
			Time.timeScale = 1f;
		}
	}
}
