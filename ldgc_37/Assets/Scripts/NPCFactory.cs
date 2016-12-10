using UnityEngine;
using System.Collections;

public class NPCFactory : MonoBehaviour {
	public float minY, maxY;
	public float enemyCooldown = 1.0f;
	public GameObject enemy;
	float timeWithoutSpawningEnemy = 0.0f;

	// Use this for initialization
	void Start () {
		SpawnEnemy ();
	}

	void SpawnEnemy(){
		float x = -7.0f;
		if (Random.Range (0, 100) < 50) {
			x = 7.0f;
		}
		Vector3 respawnPoint = new Vector3(x, Random.Range (minY, maxY), 0.0f);
		Instantiate (enemy, respawnPoint, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		timeWithoutSpawningEnemy += Time.deltaTime;
		if(timeWithoutSpawningEnemy >= enemyCooldown){
			SpawnEnemy();
			timeWithoutSpawningEnemy = 0.0f;
		}
	}
}
