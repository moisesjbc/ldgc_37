using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject gob;
	public GameObject gobSpawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			mousePosition.z = 1.0f;
			Debug.Log ("mousePosition: " + mousePosition);
			Vector3 position = gobSpawnPoint.transform.position;
			position.z = 1.0f;
			Instantiate (gob, position, Quaternion.LookRotation(Vector3.forward, mousePosition - gobSpawnPoint.transform.position));
		}
	}
}
