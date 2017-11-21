using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PMRacing : MonoBehaviour {

    public GameObject MonsterTruck;
    public float xSpeed;
    public float xxSpeed;
    public float Lane3;
    public float Lane2;
    public float Lane1;
    public float NextPos;

    // Use this for initialization
    void Start()
    {
        xSpeed = 4f;
        xxSpeed = -4f;
        Lane3 = 3.18f;
        Lane2 = 0f;
        Lane1 = -3.18f;
    }

    public void MoveRight()
       
    {
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
        while (MonsterTruck.transform.position.x < NextPos)
        {
            MonsterTruck.transform.Translate(xSpeed * Time.deltaTime, 0, 0);

            yield return null;
        }
    }
    IEnumerator MoveCarLeft()
    {
        while (MonsterTruck.transform.position.x > NextPos)
        {
            MonsterTruck.transform.Translate(xxSpeed * Time.deltaTime, 0, 0);

            yield return null;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
