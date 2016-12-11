using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shooter : MonoBehaviour {
	public GameObject gob;
	public GameObject gobSpawnPoint;
	public GameObject bottle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && bottle.GetComponent <GapBarScript> ().cur_gap > 0) {
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Debug.Log (mousePosition);
			mousePosition.z = 0.0f;
			Vector3 position = gobSpawnPoint.transform.position;
			Debug.DrawLine(position, mousePosition, Color.magenta);
			Instantiate (gob, position, Quaternion.LookRotation(Vector3.forward, (mousePosition - gobSpawnPoint.transform.position).normalized));
		}
	}
}
