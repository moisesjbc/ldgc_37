using UnityEngine;
using System.Collections;

public class WaterGuardMovement : MonoBehaviour {
	public float minSpeed = 1.0f;
	public float maxSpeed = 3.0f;
	public GameObject waterRefillArea;
	public GameObject waterBar;
	float speed = 5.0f;

	Vector3 startPosition;

	public bool angry = false;
	
	// Use this for initialization
	void Start () {
		speed = Random.Range (minSpeed, maxSpeed);
		waterRefillArea = GameObject.Find ("WaterRefillArea");
		waterBar = GameObject.Find ("Liquido");
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!angry) {
			Vector3 movementDirection = waterRefillArea.transform.position - transform.position;
			Debug.Log ("movementDirection: " + movementDirection);
			transform.Translate (movementDirection.normalized * speed * Time.deltaTime);
		} else {
			Vector3 movementDirection = startPosition - transform.position;
			Debug.Log ("movementDirection: " + movementDirection);
			transform.Translate (movementDirection.normalized * speed*4 * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "WaterRefillArea") {
			Debug.LogWarning (waterBar.GetComponent<GapBarScript>().cur_gap);
			waterBar.GetComponent<GapBarScript>().FillBar();
			Destroy (gameObject);
		}
	}
}
