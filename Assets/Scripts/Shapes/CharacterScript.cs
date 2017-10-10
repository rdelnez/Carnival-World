using UnityEngine;
using System.Collections;

public class CharacterScript : MonoBehaviour {

	public float speed;
	public bool isHeldDown;
	
	
	public Vector3 playerPos;

	void Start(){

		isHeldDown = false;
		playerPos = new Vector3 (transform.localPosition.x, transform.localPosition.y,transform.localPosition.z);
	
	}


	void Update () 
	{
		float xPos = transform.position.x + (Input.GetAxis("Horizontal") * speed);
       
	
		playerPos = new Vector3 (Mathf.Clamp (xPos, -10f, 10f), transform.position.y, transform.position.z );
		transform.position = playerPos;
		
	}

	public void moveLeft() {

		checkButtonHeld();
		StartCoroutine(isMoving(-1));

	}
	public void moveRight() {

		checkButtonHeld();
		StartCoroutine(isMoving(1));

	}
	IEnumerator isMoving(int direction)
	{

		while (isHeldDown)
		{
			float xPos = transform.position.x + (direction * speed);
			playerPos = new Vector3(Mathf.Clamp(xPos, -10f, 10f), transform.position.y, transform.position.z);
			transform.position = playerPos;
			yield return null;
		}
	}
	void checkButtonHeld() {

		if (isHeldDown == true)
		{
			isHeldDown = false;
		}
		else
		{
			isHeldDown = true;
		}

	}


}
