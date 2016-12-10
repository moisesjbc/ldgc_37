using UnityEngine;
using System.Collections;

public class GobMovement : MonoBehaviour {
	public float speed = 5.0f;
	float liveTime = 0.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		liveTime += Time.deltaTime;
		transform.Translate (transform.up * speed * Time.deltaTime);
		if (liveTime > 5.0f) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		Destroy (col.gameObject);
		Destroy (gameObject);
	}
}
