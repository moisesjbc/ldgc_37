using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TimeUpdating : MonoBehaviour {
	public float secondsRemaining = 3.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		secondsRemaining -= Time.deltaTime;

		int minutes = (int)(secondsRemaining / 60);
		int seconds = (int)(secondsRemaining % 60);
		GetComponent<Text> ().text = minutes.ToString () + ":" + seconds.ToString ("00");

		if (minutes <= 0 && seconds <= 0) {
			GameObject.Find ("TimeOver").GetComponent<Image>().enabled = true;
			Time.timeScale = 0f;
			//Application.LoadLevel(Application.loadedLevel);
		}
	}
}
