using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterScript : MonoBehaviour {

	public float speed;
	public bool isHeldDown;
	public GM GM;
	
	
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

	public void MoveLeft() {

		CheckButtonHeld();
		StartCoroutine(IsMoving(-1));

	}
	public void MoveRight() {

		CheckButtonHeld();
		StartCoroutine(IsMoving(1));

	}
	IEnumerator IsMoving(int direction)
	{

		while (isHeldDown)
		{
			float xPos = transform.position.x + (direction * speed);
			playerPos = new Vector3(Mathf.Clamp(xPos, -10f, 10f), transform.position.y, transform.position.z);
			transform.position = playerPos;
			yield return null;
		}
	}
	void CheckButtonHeld() {

		if (isHeldDown == true)
		{
			isHeldDown = false;
		}
		else
		{
			isHeldDown = true;
		}


	}
	void OnCollisionEnter(Collision col)
	{

		this.GetComponent<BoxCollider>().enabled = false;

		if (col.gameObject.name == "CorrectWinner(Clone)") {
			GM.AddScore();
		}
		else{

			GM.RemoveLife();

		}

	}
	public void CollisionToggle() {

		this.GetComponent<BoxCollider>().enabled = true;

	}


}
