using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public float minSpeed = 5.0f;
	public float maxSpeed = 10.0f;
	float speed = 5.0f;
	Vector3 movementDirection = Vector3.zero;
	bool movingRight;

	// Use this for initialization
	void Start () {
		speed = Random.Range (minSpeed, maxSpeed);
		if (transform.position.x < 0.0f) {
			movingRight = true;
			movementDirection = Vector3.right;
		} else {
			movingRight = false;
			movementDirection = Vector3.left;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (movingRight && (transform.position.x > 10.0f)) {
			Destroy (gameObject);
		} else if (!movingRight && (transform.position.x < -10.0f)) {
			Destroy (gameObject);
		}
		transform.Translate (movementDirection * speed * Time.deltaTime);
	}
}
