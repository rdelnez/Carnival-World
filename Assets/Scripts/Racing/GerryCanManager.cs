using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerryCanManager : MonoBehaviour {

	public Transform can1Pos;
	public Transform can2Pos;
	public Transform can3Pos;

	public Object gerryCanPrefab;

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

			Instantiate(gerryCanPrefab, can1Pos.localPosition, Quaternion.identity);
			Instantiate(gerryCanPrefab, can2Pos.localPosition, Quaternion.identity);
			Instantiate(gerryCanPrefab, can3Pos.localPosition, Quaternion.identity);

		}

	}
}
