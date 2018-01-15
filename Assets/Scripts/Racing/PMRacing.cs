using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PMRacing : MonoBehaviour {

    public GameObject MonsterTruck;
	public Transform cameraTransform;
    public float xSpeed;
    public float Lane3;
    public float Lane2;
    public float Lane1;
    public float NextPos;
	bool isMoving;
    // Use this for initialization
    void Start()
    {
        xSpeed = 6f;
        Lane3 = 3.18f;
        Lane2 = 0f;
        Lane1 = -3.18f;
		isMoving = false;
    }

    public void MoveRight()   
    {
		if(isMoving)
		{
			StopAllCoroutines();
			isMoving = false;
		}
        if (MonsterTruck.transform.position.x >= Lane2)
        {
            NextPos = Lane3;
            StartCoroutine("MoveCarRight");
        }
        else if (MonsterTruck.transform.position.x >= Lane1)
        {
            NextPos = Lane2;
            StartCoroutine("MoveCarRight");
        }
        else
        {
            NextPos = Lane1;
            StartCoroutine("MoveCarRight");
        }

        
    }

    public void MoveLeft()
    {
		if(isMoving)
		{
			StopAllCoroutines();
			isMoving = false;
		}
		if (MonsterTruck.transform.position.x <= Lane2)
        {
            NextPos = Lane1;
            StartCoroutine("MoveCarLeft");
        }
        else if (MonsterTruck.transform.position.x <= Lane3)
        {
            NextPos = Lane2;
            StartCoroutine("MoveCarLeft");
        }
        else
        {
            NextPos = Lane3;
            StartCoroutine("MoveCarLeft");
        }
    }

    IEnumerator MoveCarRight()
    {
		isMoving = true;
        while (MonsterTruck.transform.position.x < NextPos)
        {
            MonsterTruck.transform.Translate(xSpeed * Time.deltaTime, 0, 0);
			cameraTransform.Translate(xSpeed * Time.deltaTime, 0, 0);

			yield return null;
        }
		cameraTransform.position = new Vector3(NextPos, cameraTransform.position.y, cameraTransform.position.z);
		Vector3 tempVec = MonsterTruck.transform.position;
		tempVec.x = NextPos;
		MonsterTruck.transform.position = tempVec;
		isMoving = false;
	}

    IEnumerator MoveCarLeft()
    {
		isMoving = true;
        while (MonsterTruck.transform.position.x > NextPos)
        {
            MonsterTruck.transform.Translate(-xSpeed * Time.deltaTime, 0, 0);
			cameraTransform.Translate(-xSpeed * Time.deltaTime, 0, 0);
			yield return null;
        }
		cameraTransform.position = new Vector3(NextPos, cameraTransform.position.y, cameraTransform.position.z);
		Vector3 tempVec = MonsterTruck.transform.position;
		tempVec.x = NextPos;
		MonsterTruck.transform.position = tempVec;
		isMoving = false;
	}
}
