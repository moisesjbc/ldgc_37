using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GapBarScript : MonoBehaviour {

	public float max_gap = 100f;
	public float cur_gap = 0f;
	public Image image;

	// Use this for initialization
	void Start () {
		image = GetComponent < Image > ();
		cur_gap = max_gap;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			DecreaseGap ();
		}
	}

	void DecreaseGap(){
		if(cur_gap >= 20f)
		{
			cur_gap -= 20f;
			float calculated_gap = cur_gap / max_gap;
			SetGapBar (calculated_gap);
		}
	}

	public void FillBar(){
		SetGapBar (1);
		cur_gap = 100f;
	}

	public void SetGapBar (float my_gap_bar){
		image.fillAmount = my_gap_bar;
	}
}