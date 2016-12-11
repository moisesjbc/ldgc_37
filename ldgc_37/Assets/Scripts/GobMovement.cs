using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GobMovement : MonoBehaviour {
	public float speed = 5.0f;
	float liveTime = 0.0f;
	public GameObject score;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().Play (1);
		score = GameObject.Find ("Score");
	}
	
	// Update is called once per frame
	void Update () {
		liveTime += Time.deltaTime;
		transform.Translate (transform.up * speed * Time.deltaTime, Space.World);
		//transform.position = transform.position + transform.up * speed * Time.deltaTime;
		if (liveTime > 5.0f) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Guard" /*|| col.tag == "WaterGuard"*/) {
			//Destroy (col.gameObject);
			Destroy (gameObject);
			score.GetComponent<ScoreManagement> ().score += 100;
			col.gameObject.GetComponent<EnemyMovement>().Gob();
		}

		if (col.tag == "WaterGuard") {
			col.gameObject.GetComponent <WaterGuardMovement> ().angry = true;
		}

		if (col.tag == "Alcaide") {
			Time.timeScale = 0.0f;
			GameObject.Find ("GameOverImage").GetComponent<Image>().enabled = true;
		}
	}
}
