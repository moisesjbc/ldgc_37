using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuses : MonoBehaviour {

	//private Button MyButtonQuit = null;
	//private Button MyButtonEnter = null;

	// Use this for initialization
	void Start () {
		//MyButtonEnter.onClick.AddListener(() => { PushEnter(); });
		//MyButtonEnter.onClick.AddListener(() => { PushQuit(); });

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape"))
			Application.Quit();

	}

	public void PushQuit(){
		Application.Quit();
	}

	public void PushEnter(){
		Application.LoadLevel ("MainScene");
	}

	public void PushCreditos(){
		Application.LoadLevel ("Creditos");
	}
}
