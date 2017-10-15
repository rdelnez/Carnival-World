using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarnivalWorldBannerScript : MonoBehaviour {
	public Image lightEffect;
	public Sprite lightsOff;
	public Sprite lightsOn;
	public bool lightsAnimating;
	public bool testLights;

	// Use this for initialization
	void Start () {
		lightsAnimating = true;
		testLights = true;
		StartCoroutine(ToggleLights());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator ToggleLights() {
		while (lightsAnimating) {
			if (testLights) {
				lightEffect.sprite = lightsOff;
				testLights = false;
			}
			else{
				lightEffect.sprite = lightsOn;
				testLights = true;
			}
			yield return new WaitForSeconds(0.5f);
		}
	}
}
