using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManagement : MonoBehaviour {
	public int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = score.ToString ("000000");
	}
}
