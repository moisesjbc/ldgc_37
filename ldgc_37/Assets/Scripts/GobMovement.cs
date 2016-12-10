using UnityEngine;
using System.Collections;

public class GobMovement : MonoBehaviour {
	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (transform.up * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		Destroy (col.gameObject);
		Destroy (gameObject);
	}
}
