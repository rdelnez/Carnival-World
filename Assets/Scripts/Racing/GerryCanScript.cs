using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerryCanScript : MonoBehaviour {

	public int value;
	public float speedY;
	// Use this for initialization
	void Awake() {
		speedY = -6.0f;

	}

	void Start () {
		StartCoroutine(TestRed());
	}
	
	

	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator TestRed() {
		while (true)
		{   //Debug.Log("dfadsfsd");
			Debug.Log(Time.deltaTime + " Can");
			transform.Translate(0 * Time.deltaTime, speedY * Time.deltaTime, 0);
			yield return null;
		}
	}
}
