using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerryCanManager : MonoBehaviour {

	public Transform can1Pos;
	public Transform can2Pos;
	public Transform can3Pos;

	public Object gerryCanPrefab;
	public GameObject gerryCanGameObject;

	public string difficulty;

	// Use this for initialization
	void Start () {

		difficulty = "normal";

		InstantiateGerryCan();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void InstantiateGerryCan() {

		if (difficulty == "normal") {

			gerryCanGameObject = Instantiate(gerryCanPrefab, can1Pos.localPosition, Quaternion.identity) as GameObject;
			DisplayNumberOnCan(gerryCanGameObject, 9, true);

			gerryCanGameObject = Instantiate(gerryCanPrefab, can2Pos.localPosition, Quaternion.identity) as GameObject;
			DisplayNumberOnCan(gerryCanGameObject, 4, false);

			gerryCanGameObject = Instantiate(gerryCanPrefab, can3Pos.localPosition, Quaternion.identity) as GameObject;
			DisplayNumberOnCan(gerryCanGameObject, 35, false);

		}

	}

	void DisplayNumberOnCan(GameObject tempGerryCan, int tempValue, bool isCorrect) {

		GerryCanScript tempScript;
		tempScript = tempGerryCan.GetComponent<GerryCanScript>();
		tempScript.ChangeGerryCanValue(tempValue);
		if (isCorrect) {
			tempScript.isCorrectAnswer = true;
		}
	}


}
