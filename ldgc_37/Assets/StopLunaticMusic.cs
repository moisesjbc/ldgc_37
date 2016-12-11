using UnityEngine;
using System.Collections;

public class StopLunaticMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (GameObject.Find ("LunaticMusic"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
