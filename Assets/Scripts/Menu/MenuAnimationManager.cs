using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MenuAnimationManager : MonoBehaviour {

	public List<Image> listButtonImage;
	public Image shopObject;
	public Image highObject;
	public Image racingObject;
	public Image shapesObject;
	public Image animalsObject;
	public Image creditsObject;

	public List<Sprite> listButtonSprite;
	public Sprite shopSpriteOn;
	public Sprite highSpriteOn;
	public Sprite racingSpriteOn;
	public Sprite shapesSpriteOn;
	public Sprite animalsSpriteOn;
	public Sprite creditsSpriteOn;

	public List<Sprite> listButtonSpriteOff;
	public Sprite shopSpriteOff;
	public Sprite highSpriteOff;
	public Sprite racingSpriteOff;
	public Sprite shapesSpriteOff;
	public Sprite animalsSpriteOff;
	public Sprite creditsSpriteOff;

	public Vector3 shopRotation;
	public Vector3 highRotation;
	public Vector3 racingRotation;
	public Vector3 shapesRotation;
	public Vector3 animalsRotation;
	public Vector3 creditsRotation;
	public float speedRotation;

	public Quaternion test;
	public bool isAnimatingMenu;

	public GameObject world;
	
	// Use this for initialization
	void Start () {
		InitializeVariables();
	}
		
	// Update is called once per frame
	void Update () {

	}

	public void InitializeVariables() {

		listButtonImage = new List<Image>();
		listButtonImage.Add(shopObject);
		listButtonImage.Add(highObject);
		listButtonImage.Add(racingObject);
		listButtonImage.Add(shapesObject);
		listButtonImage.Add(animalsObject);
		listButtonImage.Add(creditsObject);

		listButtonSprite = new List<Sprite>();
		listButtonSprite.Add(shopSpriteOn);
		listButtonSprite.Add(highSpriteOn);
		listButtonSprite.Add(racingSpriteOn);
		listButtonSprite.Add(shapesSpriteOn);
		listButtonSprite.Add(animalsSpriteOn);
		listButtonSprite.Add(creditsSpriteOn);

		listButtonSpriteOff = new List<Sprite>();
		listButtonSpriteOff.Add(shopSpriteOff);
		listButtonSpriteOff.Add(highSpriteOff);
		listButtonSpriteOff.Add(racingSpriteOff);
		listButtonSpriteOff.Add(shapesSpriteOff);
		listButtonSpriteOff.Add(animalsSpriteOff);
		listButtonSpriteOff.Add(creditsSpriteOff);

		shopRotation = new Vector3(243f, 0f, 0f);
		highRotation = new Vector3(333f, 0f, 0f);
		racingRotation = new Vector3(153f, 0f, 0f);
		creditsRotation = new Vector3(63f, 0f, 0f);
		animalsRotation = new Vector3(0f, 90f, 63f);
		shapesRotation = new Vector3(0f, 90f, 253f);

		speedRotation = 120.0f;
		isAnimatingMenu = false;


	}

	public void RotateShop() {
		if (isAnimatingMenu == false)
		{
			StartCoroutine(RotateWorldIENumerator(shopRotation));
		}
	}

	

	public void RotateHigh() {
		if (isAnimatingMenu == false)
		{
			StartCoroutine(RotateWorldIENumerator(highRotation));
		}
	}


	public void RotateRacing() {
		if (isAnimatingMenu == false)
		{
			StartCoroutine(RotateWorldIENumerator(racingRotation));
		}
	}

	public void RotateCredits()
	{
		if (isAnimatingMenu == false)
		{
			StartCoroutine(RotateWorldIENumerator(creditsRotation));
		}
	}

	public void RotateAnimals()
	{
		if (isAnimatingMenu == false)
		{
			StartCoroutine(RotateWorldIENumerator(animalsRotation));
		}
	}

	public void RotateShapes()
	{
		if (isAnimatingMenu == false)
		{
			StartCoroutine(RotateWorldIENumerator(shapesRotation));
		}
	}

	public void EnableDisableMenuButton(int _tempIndex) {


		Debug.Log(listButtonImage.Count);

		for (int x=0; x<listButtonImage.Count; x++) {
			listButtonImage[x].sprite = listButtonSpriteOff[x];
		}

		listButtonImage[_tempIndex].sprite = listButtonSprite[_tempIndex] as Sprite;

	
	}


	IEnumerator RotateWorldIENumerator(Vector3 _landPos) {

		isAnimatingMenu = true;
		Quaternion _landPosQuaternion = Quaternion.Euler(_landPos);
		while (isAnimatingMenu) {

			yield return new WaitForSeconds(0.01f);

			if (Quaternion.Angle(world.transform.rotation, _landPosQuaternion) > 1.5f)
			{
				

				world.transform.rotation = Quaternion.RotateTowards(world.transform.rotation, _landPosQuaternion, speedRotation*Time.deltaTime);
			}
			else
			{
				world.transform.eulerAngles = _landPos;
				isAnimatingMenu = false;
			}

			
		}
	}


}
