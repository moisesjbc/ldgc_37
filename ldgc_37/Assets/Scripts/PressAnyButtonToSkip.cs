using UnityEngine;
using System.Collections;

public class PressAnyButtonToSkip : MonoBehaviour {
	public string targetSceneName = "MainScene";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			Application.LoadLevel (targetSceneName);
		}
	}
}
