using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnimationManager : MonoBehaviour {

	public Vector3 shopRotation;
	public Vector3 highRotation;
	public Vector3 racingRotation;
	public Vector3 shapesRotation;
	public Vector3 animalsRotation;
	public Vector3 creditsRotation;

	public bool isShopAnimating;
	public bool isHighAnimating;

	public GameObject world;
	
	// Use this for initialization
	void Start () {
		shopRotation = new Vector3(243f, 0f, 0f);
		highRotation = new Vector3(333f, 0f, 0f);
		racingRotation = new Vector3(153f, 0f, 0f);

		isShopAnimating = false;
		isHighAnimating = false;

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void RotateShop() {
		if (isShopAnimating == false || isHighAnimating == false)
			StartCoroutine(RotateToShopIENumerator());
	}

	IEnumerator RotateToShopIENumerator() {
		isShopAnimating = true;
		Quaternion test = Quaternion.Euler(shopRotation);
		while (isShopAnimating) {
			if (Vector3.Distance(world.transform.eulerAngles, shopRotation) > 0.5f) {

				
				world.transform.rotation = Quaternion.Slerp(world.transform.rotation, test, 0.05f);
			}
			else{
				world.transform.eulerAngles = shopRotation;
				isShopAnimating = false;
			}
			yield return new WaitForSeconds(0.01f);
		}
	}

	public void RotateHigh() {
		if(isHighAnimating == false || isHighAnimating == false)
			StartCoroutine(RotateToHighIENumerator());
	}

	IEnumerator RotateToHighIENumerator()
	{
		isHighAnimating = true;
		Quaternion test = Quaternion.Euler(highRotation);
		while (isHighAnimating)
		{
			if (Vector3.Distance(world.transform.eulerAngles, highRotation) > 0.5f)
			{


				world.transform.rotation = Quaternion.Slerp(world.transform.rotation, test, 0.05f);
			}
			else
			{
				world.transform.eulerAngles = highRotation;
				isHighAnimating = false;
			}
			yield return new WaitForSeconds(0.01f);
		}
	}

	/*--
	if(Vector3.Distance(sanctuary.transform.eulerAngles, sancTempVectorRot)>0.01f){
				sanctuary.transform.eulerAngles = Vector3.Lerp(sanctuary.transform.eulerAngles, sancTempVectorRot, 0.1f);
				sanctuary.transform.localPosition = Vector3.Lerp(sanctuary.transform.localPosition, sancTempVector, 0.1f);
			}
			else{
				sanctuary.transform.eulerAngles = sancTempVectorRot;
				PlaySound();
			isAnimating = false;
			}
			--*/
}
